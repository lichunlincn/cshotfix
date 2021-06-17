#region Header
/*
 * The authors disclaim copyright to this source code.
 * For more details, see the COPYING file included with this distribution.
 */
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Linq;

namespace LITJson {

internal struct PropertyMetadata {
	public Type Type { get; set; }
	public MemberInfo Info { get; set; }
	public bool Ignore { get; set; }
	public string Alias { get; set; }
	public bool IsField { get; set; }
	public bool Include { get; set; }
}

internal struct ArrayMetadata {
	public bool IsArray { get; set; }
	public bool IsList { get; set; }

	private Type elemType;
	public Type ElementType {
		get {
			if (elemType == null) {
				elemType = typeof(JsonData);
			}
			return elemType;
		}
		set {
			elemType = value;
		}
	}
}

internal struct ObjectMetadata {
	public IDictionary<string, PropertyMetadata> Properties { get; set; }
	public bool IsDictionary { get; set; }

	private Type elemType;
	public Type ElementType {
		get {
			if (elemType == null) {
				elemType = typeof(JsonData);
			}
			return elemType;
		}
		set {
			elemType = value;
		}
	}
}

internal delegate void ExporterFunc(object obj, JsonWriter writer);
public delegate void ExporterFunc<T>(T obj, JsonWriter writer);

internal delegate object ImporterFunc(object input);
public delegate TValue ImporterFunc<TJson, TValue>(TJson input);

internal delegate object FactoryFunc();
public delegate T FactoryFunc<T>();

public delegate IJsonWrapper WrapperFactory();

/// <summary>
/// JSON to .Net object and object to JSON conversions.
/// </summary>
public class JsonMapper {
	private static readonly int maxNestingDepth;
	private static readonly IFormatProvider datetimeFormat;

	private static readonly IDictionary<Type, ExporterFunc> baseExportTable;
	private static readonly IDictionary<Type, ExporterFunc> customExportTable;

	private static readonly IDictionary<Type, IDictionary<Type, ImporterFunc>> baseImportTable;
	private static readonly IDictionary<Type, IDictionary<Type, ImporterFunc>> customImportTable;

	private static readonly IDictionary<Type, FactoryFunc> customFactoryTable;

	private static readonly IDictionary<Type, ArrayMetadata> arrayMetadata;

	private static readonly IDictionary<Type, IDictionary<Type, MethodInfo>> convOps;

	private static readonly IDictionary<Type, ObjectMetadata> objectMetadata;

	static JsonMapper() {
		maxNestingDepth = 100;
		datetimeFormat = DateTimeFormatInfo.InvariantInfo;

		arrayMetadata = new Dictionary<Type, ArrayMetadata>();
		objectMetadata = new Dictionary<Type, ObjectMetadata>();
		convOps = new Dictionary<Type, IDictionary<Type, MethodInfo>>();

		baseExportTable = new Dictionary<Type, ExporterFunc>();
		customExportTable = new Dictionary<Type, ExporterFunc>();

		baseImportTable = new Dictionary<Type, IDictionary<Type, ImporterFunc>>();
		customImportTable = new Dictionary<Type, IDictionary<Type, ImporterFunc>>();

		customFactoryTable = new Dictionary<Type, FactoryFunc>();

		RegisterBaseExporters();
		RegisterBaseImporters();
        UnityTypeBindings.Register();
	}

	private static ArrayMetadata AddArrayMetadata(Type type) {
		if (arrayMetadata.ContainsKey(type)) {
			return arrayMetadata[type];
		}
		ArrayMetadata data = new ArrayMetadata();
		data.IsArray = type.IsArray;
		if (type.GetInterface("System.Collections.IList") != null) {
			data.IsList = true;
		}
		foreach (PropertyInfo pinfo in type.GetProperties()) {
			if (pinfo.Name != "Item") {
				continue;
			}
			ParameterInfo[] parameters = pinfo.GetIndexParameters();
			if (parameters.Length != 1) {
				continue;
			}
			if (parameters[0].ParameterType == typeof(int)) {
				data.ElementType = pinfo.PropertyType;
			}
		}
		arrayMetadata[type] = data;
		return data;
	}

	private static ObjectMetadata AddObjectMetadata(Type type) {
		if (objectMetadata.ContainsKey(type)) {
			return objectMetadata[type];
		}
		ObjectMetadata data = new ObjectMetadata();
		if (type.GetInterface("System.Collections.IDictionary") != null) {
			data.IsDictionary = true;
		}
		data.Properties = new Dictionary<string, PropertyMetadata>();
		
		// Get all kinds of declared properties
		BindingFlags pflags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
		foreach (PropertyInfo pinfo in type.GetProperties(pflags)) {
			if (pinfo.Name == "Item") {
				ParameterInfo[] parameters = pinfo.GetIndexParameters();
				if (parameters.Length != 1) {
					continue;
				}
				if (parameters[0].ParameterType == typeof(string)) {
					data.ElementType = pinfo.PropertyType;
				}
				continue;
			}
			// Include properties automatically that have at least one public accessor
			bool autoInclude =
				(pinfo.GetGetMethod() != null && pinfo.GetGetMethod().IsPublic) ||
				(pinfo.GetSetMethod() != null && pinfo.GetSetMethod().IsPublic);
			// If neither accessor is public and we don't have a [JsonInclude] attribute, skip it
			if (!autoInclude && pinfo.GetCustomAttributes(typeof(JsonInclude), true).Count() == 0) {
				continue;
			}
			PropertyMetadata pdata = new PropertyMetadata();
			pdata.Info = pinfo;
			pdata.Type = pinfo.PropertyType;
			object[] ignoreAttrs = pinfo.GetCustomAttributes(typeof(JsonIgnore), true).ToArray();
			if (ignoreAttrs.Length > 0) {
				pdata.Ignore = true;
			}
			object[] aliasAttrs = pinfo.GetCustomAttributes(typeof(JsonAlias), true).ToArray();
			if (aliasAttrs.Length > 0) {
				JsonAlias aliasAttr = (JsonAlias)aliasAttrs[0];
				if (aliasAttr.Alias == pinfo.Name) {
					throw new JsonException(string.Format("Alias name '{0}' must be different from the property it represents for type '{1}'", pinfo.Name, type));
				}
				if (data.Properties.ContainsKey(aliasAttr.Alias)) {
					throw new JsonException(string.Format("'{0}' already contains the property or alias name '{1}'", type, aliasAttr.Alias));
				}
				pdata.Alias = aliasAttr.Alias;
				if (aliasAttr.AcceptOriginal) {
					data.Properties.Add(pinfo.Name, pdata);
				}
			}
			if (pdata.Alias != null) {
				data.Properties.Add(pdata.Alias, pdata);
			} else {
				if (data.Properties.ContainsKey(pinfo.Name)) {
					throw new JsonException(string.Format("'{0}' already contains the property or alias name '{1}'", type, pinfo.Name));
				}
				data.Properties.Add(pinfo.Name, pdata);
			}
		}
		// Get all kinds of declared fields
		BindingFlags fflags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
		foreach (FieldInfo finfo in type.GetFields(fflags)) {
			// If the field isn't public and doesn't have an [Include] attribute, skip it
			if (!finfo.IsPublic && finfo.GetCustomAttributes(typeof(JsonInclude), true).Count() == 0) {
				continue;
			}
			PropertyMetadata pdata = new PropertyMetadata();
			pdata.Info = finfo;
			pdata.IsField = true;
			pdata.Type = finfo.FieldType;
			object[] ignoreAttrs = finfo.GetCustomAttributes(typeof(JsonIgnore), true).ToArray();
			if (ignoreAttrs.Length > 0) {
				pdata.Ignore = true;
			}
			object[] aliasAttrs = finfo.GetCustomAttributes(typeof(JsonAlias), true).ToArray();
			if (aliasAttrs.Length > 0) {
				JsonAlias aliasAttr = (JsonAlias)aliasAttrs[0];
				if (aliasAttr.Alias == finfo.Name) {
					throw new JsonException(string.Format("Alias name '{0}' must be different from the field it represents for type '{1}'", finfo.Name, type));
				}
				if (data.Properties.ContainsKey(aliasAttr.Alias)) {
					throw new JsonException(string.Format("'{0}' already contains the field or alias name '{1}'", type, aliasAttr.Alias));
				}
				pdata.Alias = aliasAttr.Alias;
				if (aliasAttr.AcceptOriginal) {
					data.Properties.Add(finfo.Name, pdata);
				}
			}
			if (pdata.Alias != null) {
				data.Properties.Add(pdata.Alias, pdata);
			} else {
				if (data.Properties.ContainsKey(finfo.Name)) {
					throw new JsonException(string.Format("'{0}' already contains the field or alias name '{1}'", type, finfo.Name));
				}
				data.Properties.Add(finfo.Name, pdata);
			}
		}
		objectMetadata.Add(type, data);
		return data;
	}

	private static object CreateInstance(Type type) {
		FactoryFunc factory;
		if (customFactoryTable.TryGetValue(type, out factory)) {
			return factory();
		}
		// construct the new instance with the default constructor (if present), handles structs as well
		BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
		ConstructorInfo constructor = type.GetConstructor(flags, null, new Type[0], null);
		if (constructor != null) {
			constructor.Invoke(null);   
		}
		return Activator.CreateInstance(type);
	}

	private static MethodInfo GetConvOp(Type t1, Type t2) {
		if (!convOps.ContainsKey(t1)) {
			convOps.Add(t1, new Dictionary<Type, MethodInfo>());
		}
		if (convOps[t1].ContainsKey(t2)) {
			return convOps[t1][t2];
		}
		MethodInfo op = t1.GetMethod("op_Implicit", new Type[]{t2});
		convOps[t1][t2] = op;
		return op;
	}

	private static ImporterFunc GetImporter(Type jsonType, Type valueType) {
		if (customImportTable.ContainsKey(jsonType) &&
			customImportTable[jsonType].ContainsKey(valueType)) {

			return customImportTable[jsonType][valueType];
		}
		if (baseImportTable.ContainsKey(jsonType) &&
			baseImportTable[jsonType].ContainsKey(valueType)) {

			return baseImportTable[jsonType][valueType];
		}
		return null;
	}

	private static ExporterFunc GetExporter(Type valueType) {
		if (customExportTable.ContainsKey(valueType)) {
			return customExportTable[valueType];
		}
		if (baseExportTable.ContainsKey(valueType)) {
			return baseExportTable[valueType];
		}
		return null;
	}

	private static object ReadValue(Type instType, JsonReader reader) {
		reader.Read();
		if (reader.Token == JsonToken.ArrayEnd) {
			return null;
		}
		Type underlyingType = Nullable.GetUnderlyingType(instType);
		Type valueType = underlyingType ?? instType;
		if (reader.Token == JsonToken.Null) {
			#if JSON_WINRT || (UNITY_METRO && !UNITY_EDITOR)
			/* IsClass is made a getter here as a comparability
			patch for WinRT build targets, see Platform.cs */
			if (instType.IsClass() || underlyingType != null) {
			#else
			if (instType.IsClass || underlyingType != null) {
			#endif
				return null;
			}
			throw new JsonException(string.Format("Can't assign null to an instance of type {0}", instType));
		}
		if (reader.Token == JsonToken.Real ||
			reader.Token == JsonToken.Natural ||
			reader.Token == JsonToken.String ||
			reader.Token == JsonToken.Boolean) {

			Type jsonType = reader.Value.GetType();
			if (valueType.IsAssignableFrom(jsonType)) {
				return reader.Value;
			}
			// Try to find a custom or base importer
			ImporterFunc importer = GetImporter(jsonType, valueType);
			if (importer != null) {
				return importer(reader.Value);
			}
			// Maybe it's an enum
			#if JSON_WINRT || (UNITY_METRO && !UNITY_EDITOR)
			/* IsClass is made a getter here as a comparability
			patch for WinRT build targets, see Platform.cs */
			if (valueType.IsEnum()) {
			#else
			if (valueType.IsEnum) {
			#endif
				return Enum.ToObject(valueType, reader.Value);
			}
			// Try using an implicit conversion operator
			MethodInfo convOp = GetConvOp(valueType, jsonType);
			if (convOp != null) {
				return convOp.Invoke(null, new object[]{reader.Value});
			}
			// No luck
			throw new JsonException(string.Format("Can't assign value '{0}' (type {1}) to type {2}", reader.Value, jsonType, instType));
		}
		object instance = null;
		if (reader.Token == JsonToken.ArrayStart) {
			// If there's a custom importer that fits, use it
			ImporterFunc importer = GetImporter(typeof(JsonData), instType);
			if (importer != null) {
				instType = typeof(JsonData);
			}
			AddArrayMetadata(instType);
			ArrayMetadata tdata = arrayMetadata[instType];
			if (!tdata.IsArray && !tdata.IsList) {
				throw new JsonException(string.Format("Type {0} can't act as an array", instType));
			}
			IList list;
			Type elemType;
			if (!tdata.IsArray) {
				list = (IList)CreateInstance(instType);
				elemType = tdata.ElementType;
			} else {
				//list = new ArrayList();
				list = new List<object>();
				elemType = instType.GetElementType();
			}
			while (true) {
				object item = ReadValue(elemType, reader);
				if (item == null && reader.Token == JsonToken.ArrayEnd) {
					break;
				}
				list.Add(item);
			}
			if (tdata.IsArray) {
				int n = list.Count;
				instance = Array.CreateInstance(elemType, n);
				for (int i = 0; i < n; i++) {
					((Array)instance).SetValue (list[i], i);
				}
			} else {
				instance = list;
			}
			if (importer != null) {
				instance = importer(instance);
			}
		} else if (reader.Token == JsonToken.ObjectStart) {
			bool done = false;
			string property = null;
			reader.Read();
			if (reader.Token == JsonToken.ObjectEnd) {
				done = true;
			} else {
				property = (string)reader.Value;
				if (reader.TypeHinting && property == reader.HintTypeName)
				{
                    valueType = reader.ReadType();
                    reader.Read();
                    property = (string)reader.Value;
                    //reader.Read();
                    //string typeName = (string)reader.Value;
                    //reader.Read();
                    //if ((string)reader.Value == reader.HintValueName)
                    //{
                    //    valueType = Type.GetType(typeName);
                    //    object value = ReadValue(valueType, reader);
                    //    reader.Read();
                    //    if (reader.Token != JsonToken.ObjectEnd)
                    //    {
                    //        throw new JsonException(string.Format("Invalid type hinting object, has too many properties: {0}...", reader.Token));
                    //    }
                    //    return value;
                    //}
                    //else
                    //{
                    //    throw new JsonException(string.Format("Expected \"{0}\" property for type hinting but instead got \"{1}\"", reader.HintValueName, reader.Value));
                    //}
                }
			}
			// If there's a custom importer that fits, use to create a JsonData type instead.
			// Once the object is deserialzied, it will be invoked to create the actual converted object.
			ImporterFunc importer = GetImporter(typeof(JsonData), valueType);
			if (importer != null) {
				valueType = typeof(JsonData);
			}
			ObjectMetadata tdata = AddObjectMetadata(valueType);
			instance = CreateInstance(valueType);
			bool firstRun = true;
			while (!done) {
				if (firstRun) {
					firstRun = false;
				} else {
					reader.Read();
					if (reader.Token == JsonToken.ObjectEnd) {
						break;   
					}
					property = (string)reader.Value;
				}
				PropertyMetadata pdata;
				if (tdata.Properties.TryGetValue(property, out pdata)) {
					// Don't deserialize a field or property that has a JsonIgnore attribute with deserialization usage.
                    if (pdata.Ignore)
                    {
						ReadSkip(reader);
						continue;
					}
					if (pdata.IsField) {
						((FieldInfo)pdata.Info).SetValue(instance, ReadValue(pdata.Type, reader));
					} else {
						PropertyInfo pinfo = (PropertyInfo)pdata.Info;
						if (pinfo.CanWrite) {
							pinfo.SetValue(instance, ReadValue(pdata.Type, reader), null);
						} else {
							ReadValue(pdata.Type, reader);
						}
					}
				} else {
					if (!tdata.IsDictionary) {
						if (!reader.SkipNonMembers) {
							throw new JsonException(string.Format("The type {0} doesn't have the property '{1}'", instType, property));
						} else {
							ReadSkip(reader);
							continue;
						}
					}
					((IDictionary)instance).Add(property, ReadValue(tdata.ElementType, reader));
				}
			}
			if (importer != null) {
				instance = importer(instance);
			}
		}
		return instance;
	}

	private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader) {
		reader.Read();
		if (reader.Token == JsonToken.ArrayEnd ||
			reader.Token == JsonToken.Null) {

			return null;
		}
		IJsonWrapper instance = factory();
		if (reader.Token == JsonToken.String) {
			instance.SetString((string)reader.Value);
			return instance;
		}
		if (reader.Token == JsonToken.Real) {
			instance.SetReal((double)reader.Value);
			return instance;
		}
		if (reader.Token == JsonToken.Natural) {
			instance.SetNatural((long)reader.Value);
			return instance;
		}
		if (reader.Token == JsonToken.Boolean) {
			instance.SetBoolean((bool)reader.Value);
			return instance;
		}
		if (reader.Token == JsonToken.ArrayStart) {
			instance.SetJsonType(JsonType.Array);
			while (true) {
				IJsonWrapper item = ReadValue(factory, reader);
				if (item == null && reader.Token == JsonToken.ArrayEnd) {
					break;
				}
				((IList)instance).Add(item);
			}
		} else if (reader.Token == JsonToken.ObjectStart) {
			instance.SetJsonType(JsonType.Object);
			while (true) {
				reader.Read();
				if (reader.Token == JsonToken.ObjectEnd) {
					break;
				}
				string property = (string)reader.Value;
				((IDictionary)instance)[property] = ReadValue(factory, reader);
			}
		}
		return instance;
	}

	private static void ReadSkip(JsonReader reader) {
		ToWrapper(delegate {
			return new JsonMockWrapper();
		}, reader);
	}

	private static void RegisterBaseExporters() {
		baseExportTable[typeof(sbyte)] = delegate(object obj, JsonWriter writer) {
			writer.Write(Convert.ToInt64((sbyte)obj));
		};
		baseExportTable[typeof(byte)] = delegate(object obj, JsonWriter writer) {
			writer.Write(Convert.ToInt64((byte)obj));
		};
		baseExportTable[typeof(char)] = delegate(object obj, JsonWriter writer) {
			writer.Write(Convert.ToString((char)obj));
		};
		baseExportTable[typeof(short)] = delegate(object obj, JsonWriter writer) {
			writer.Write(Convert.ToInt64((short)obj));
		};
		baseExportTable[typeof(ushort)] = delegate(object obj, JsonWriter writer) {
			writer.Write(Convert.ToInt64((ushort)obj));
		};
		baseExportTable[typeof(int)] = delegate(object obj, JsonWriter writer) {
			writer.Write(Convert.ToInt64((int)obj));
		};
		baseExportTable[typeof(uint)] = delegate(object obj, JsonWriter writer) {
			writer.Write(Convert.ToInt64((uint)obj));
		};
		baseExportTable[typeof(ulong)] = delegate(object obj, JsonWriter writer) {
			writer.Write(Convert.ToUInt64((ulong)obj));
		};
		baseExportTable[typeof(float)] = delegate(object obj, JsonWriter writer) {
			writer.Write(Convert.ToDouble((float)obj));
		};
		baseExportTable[typeof(decimal)] = delegate(object obj, JsonWriter writer) {
			writer.Write(Convert.ToDecimal((decimal)obj));
		};
		baseExportTable[typeof(DateTime)] = delegate(object obj, JsonWriter writer) {
			writer.Write(Convert.ToString((DateTime)obj, datetimeFormat));
		};
	}

	private static void RegisterBaseImporters() {
		RegisterImporter(baseImportTable, typeof(long), typeof(sbyte), delegate(object input) {
			return Convert.ToSByte((long)input);
		});
		RegisterImporter(baseImportTable, typeof(long), typeof(byte), delegate(object input) {
			return Convert.ToByte((long)input);
		});
		RegisterImporter(baseImportTable, typeof(long), typeof(short), delegate(object input) {
			return Convert.ToInt16((long)input);
		});
		RegisterImporter(baseImportTable, typeof(long), typeof(ushort), delegate(object input) {
			return Convert.ToUInt16((long)input);
		});
		RegisterImporter(baseImportTable, typeof(long), typeof(int), delegate(object input) {
			return Convert.ToInt32((long)input);
		});
		RegisterImporter(baseImportTable, typeof(long), typeof(uint), delegate(object input) {
			return Convert.ToUInt32((long)input);
		});
		RegisterImporter(baseImportTable, typeof(long), typeof(ulong), delegate(object input) {
			return Convert.ToUInt64((long)input);
		});
		RegisterImporter(baseImportTable, typeof(long), typeof(float), delegate(object input) {
			return Convert.ToSingle((long)input);
		});
		RegisterImporter(baseImportTable, typeof(long), typeof(double), delegate(object input) {
			return Convert.ToDouble((long)input);
		});
		RegisterImporter(baseImportTable, typeof(long), typeof(decimal), delegate(object input) {
			return Convert.ToDecimal((long)input);
		});
		RegisterImporter(baseImportTable, typeof(double), typeof(float), delegate(object input) {
			return Convert.ToSingle((double)input);
		});
		RegisterImporter(baseImportTable, typeof(double), typeof(decimal), delegate(object input) {
			return Convert.ToDecimal((double)input);
		});
		RegisterImporter(baseImportTable, typeof(string), typeof(char), delegate(object input) {
			return Convert.ToChar((string)input);
		});
		RegisterImporter(baseImportTable, typeof(string), typeof(DateTime), delegate(object input) {
			return Convert.ToDateTime((string)input, datetimeFormat);
		});
	}

	private static void RegisterImporter(IDictionary<Type, IDictionary<Type, ImporterFunc>> table, Type jsonType, Type valueType, ImporterFunc importer) {
		if (!table.ContainsKey(jsonType)) {
			table.Add(jsonType, new Dictionary<Type, ImporterFunc>());
		}
		table[jsonType][valueType] = importer;
	}

	private static void WriteValue(object obj, JsonWriter writer, bool privateWriter, int depth) {
		if (depth > maxNestingDepth) {
			throw new JsonException(string.Format("Max allowed object depth reached while trying to export from type {0}", obj.GetType()));
		}
		if (obj == null) {
			writer.Write(null);
			return;
		}
		if (obj is IJsonWrapper) {
			if (privateWriter) {
				writer.TextWriter.Write(((IJsonWrapper)obj).ToJson());
			} else {
				((IJsonWrapper)obj).ToJson(writer);
			}
			return;
		}
		if (obj is string) {
			writer.Write((string)obj);
			return;
		}
		if (obj is double) {
			writer.Write((double)obj);
			return;
		}
		if (obj is long) {
			writer.Write((long)obj);
			return;
		}
		if (obj is bool) {
			writer.Write((bool)obj);
			return;
		}
		if (obj is Array) {
			writer.WriteArrayStart();
			Array arr = (Array)obj;
			Type elemType = arr.GetType().GetElementType();
			foreach (object elem in arr) {
				// if the collection contains polymorphic elements, we need to include type information for deserialization
				//if (writer.TypeHinting && elem != null & elem.GetType() != elemType) {
				//	writer.WriteObjectStart();
				//	writer.WritePropertyName(writer.HintTypeName);
				//	writer.Write(elem.GetType().FullName);
				//	writer.WritePropertyName(writer.HintValueName);
				//	WriteValue(elem, writer, privateWriter, depth + 1);
				//	writer.WriteObjectEnd();
				//} else {
					WriteValue(elem, writer, privateWriter, depth + 1);    
				//}
			}
			writer.WriteArrayEnd();
			return;
		}
		if (obj is IList) {
			writer.WriteArrayStart();
			IList list = (IList)obj;
			// collection might be non-generic type like Arraylist
			Type elemType = typeof(object);
			if (list.GetType().GetGenericArguments().Length > 0) {
				// collection is a generic type like List<T>
				elemType = list.GetType().GetGenericArguments()[0];
			}
			foreach (object elem in list) {
				// if the collection contains polymorphic elements, we need to include type information for deserialization
				//if (writer.TypeHinting && elem != null && elem.GetType() != elemType) {
				//	writer.WriteObjectStart();
				//	writer.WritePropertyName(writer.HintTypeName);
				//	writer.Write(elem.GetType().AssemblyQualifiedName);
				//	writer.WritePropertyName(writer.HintValueName);
				//	WriteValue(elem, writer, privateWriter, depth + 1);
				//	writer.WriteObjectEnd();
				//} else {
					WriteValue(elem, writer, privateWriter, depth + 1);    
				//}
			}
			writer.WriteArrayEnd();
			return;
		}
		if (obj is IDictionary) {
			writer.WriteObjectStart();
			IDictionary dict = (IDictionary)obj;
			// collection might be non-generic type like Hashtable
			Type elemType = typeof(object);
			if (dict.GetType().GetGenericArguments().Length > 1) {
				// collection is a generic type like Dictionary<T, V>
				elemType = dict.GetType().GetGenericArguments()[1];
			}
			foreach (DictionaryEntry entry in dict) {
				writer.WritePropertyName((string)entry.Key);
				// if the collection contains polymorphic elements, we need to include type information for deserialization
				//if (writer.TypeHinting && entry.Value != null && entry.Value.GetType() != elemType) {
				//	writer.WriteObjectStart();
				//	writer.WritePropertyName(writer.HintTypeName);
				//	writer.Write(entry.Value.GetType().AssemblyQualifiedName);
				//	writer.WritePropertyName(writer.HintValueName);
				//	WriteValue(entry.Value, writer, privateWriter, depth + 1);
				//	writer.WriteObjectEnd();
				//} else {
					WriteValue(entry.Value, writer, privateWriter, depth + 1);
				//}
			}
			writer.WriteObjectEnd();
			return;
		}
		Type objType = obj.GetType();
		// Try a base or custom importer if one exists
		ExporterFunc exporter = GetExporter(objType);
		if (exporter != null) {
			exporter(obj, writer);
			return;
		}
		// Last option, let's see if it's an enum
		if (obj is Enum) {
			Type enumType = Enum.GetUnderlyingType(objType);
			if (enumType == typeof(long)) {
				writer.Write((long)obj);
			} else {
				ExporterFunc enumConverter = GetExporter(enumType);
				if (enumConverter != null) {
					enumConverter(obj, writer);
				}
			}
			return;
		}
		// Okay, it looks like the input should be exported as an object
		ObjectMetadata tdata = AddObjectMetadata(objType);
		writer.WriteObjectStart();
        //在Json的第一个字段前插入类型标识
	    if (writer.TypeHinting)
	    {
	        writer.WriteType(objType);
	    }
		foreach (string property in tdata.Properties.Keys) {
			PropertyMetadata pdata = tdata.Properties[property];
			// Don't serialize soft aliases (which get added to ObjectMetadata.Properties twice).
			if (pdata.Alias != null && property != pdata.Info.Name && tdata.Properties.ContainsKey(pdata.Info.Name)) {
				continue;
			}
			// Don't serialize a field or property with the JsonIgnore attribute with serialization usage
            if (pdata.Ignore)
            {
				continue;
			}
			if (pdata.IsField) {
				FieldInfo info = (FieldInfo)pdata.Info;
				if (pdata.Alias != null) {
					writer.WritePropertyName(pdata.Alias);
				} else {
					writer.WritePropertyName(info.Name);
				}
				object value = info.GetValue(obj);
				//if (writer.TypeHinting && value != null && info.FieldType != value.GetType()) {
				//	// the object stored in the field might be a different type that what was declared, need type hinting
				//	writer.WriteObjectStart();
				//	writer.WritePropertyName(writer.HintTypeName);
				//	writer.Write(value.GetType().AssemblyQualifiedName);
				//	writer.WritePropertyName(writer.HintValueName);
				//	WriteValue(value, writer, privateWriter, depth + 1);
				//	writer.WriteObjectEnd();
				//} else {
					WriteValue(value, writer, privateWriter, depth + 1);
				//}
			}
            //暂时去除类属性的序列化操作,因为静态数据里面带有不需要序列化的属性
			//else {
			//	PropertyInfo info = (PropertyInfo)pdata.Info;
			//	if (info.CanRead) {
			//		if (pdata.Alias != null) {
			//			writer.WritePropertyName(pdata.Alias);
			//		} else {
			//			writer.WritePropertyName(info.Name);
			//		}
			//		object value = info.GetValue(obj, null);
			//		//if (writer.TypeHinting && value != null && info.PropertyType != value.GetType()) {
			//		//	// the object stored in the property might be a different type that what was declared, need type hinting
			//		//	writer.WriteObjectStart();
			//		//	writer.WritePropertyName(writer.HintTypeName);
			//		//	writer.Write(value.GetType().AssemblyQualifiedName);
			//		//	writer.WritePropertyName(writer.HintValueName);
			//		//	WriteValue(value, writer, privateWriter, depth + 1);
			//		//	writer.WriteObjectEnd();
			//		//} else {
			//			WriteValue(value, writer, privateWriter, depth + 1);
			//		//}
			//	}
			//}
		}
		writer.WriteObjectEnd();
	}

	public static string ToJson(object obj) {
        return ToJson (obj,false);
	}

    public static string ToJson(object obj,bool prettyPrint) {
        JsonWriter writer = new JsonWriter();
        writer.PrettyPrint = prettyPrint;
        WriteValue(obj, writer, true, 0);
        return writer.ToString();
    }

	public static void ToJson(object obj, JsonWriter writer) {
		WriteValue(obj, writer, false, 0);
	}

	public static JsonData ToObject(JsonReader reader) {
		return (JsonData)ToWrapper(delegate {
			return new JsonData();
		}, reader);
	}

	public static JsonData ToObject(TextReader reader) {
		JsonReader jsonReader = new JsonReader(reader);
		return (JsonData)ToWrapper(delegate {
			return new JsonData();
		}, jsonReader);
	}

	public static JsonData ToObject(string json) {
		return (JsonData)ToWrapper(delegate {
			return new JsonData();
		}, json);
	}

	public static T ToObject<T>(JsonReader reader) {
		return (T)ReadValue(typeof(T), reader);
	}

	public static T ToObject<T>(TextReader reader) {
		JsonReader jsonReader = new JsonReader(reader);
		return (T)ReadValue(typeof(T), jsonReader);
	}

    public static T ToObject<T>(string json)
    {
		if (string.IsNullOrEmpty(json))
		{
			return default(T);
		}
		else
		{
			JsonReader reader = new JsonReader(json);
			return (T)ReadValue(typeof(T), reader);
		}
	}

    public static object ToObject(string json, Type t)
    {
        JsonReader reader = new JsonReader(json);
        return ReadValue(t, reader);
    }

	public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader) {
		return ReadValue(factory, reader);
	}

	public static IJsonWrapper ToWrapper(WrapperFactory factory, string json) {
		JsonReader reader = new JsonReader(json);
		return ReadValue(factory, reader);
	}

	public static void RegisterExporter<T>(ExporterFunc<T> exporter) {
		ExporterFunc wrapper = delegate(object obj, JsonWriter writer) {
			exporter((T)obj, writer);
		};
		customExportTable[typeof(T)] = wrapper;
	}

	public static void RegisterImporter<TJson, TValue>(ImporterFunc<TJson, TValue> importer) {
		ImporterFunc wrapper = delegate(object input) {
			return importer((TJson)input);
		};
		RegisterImporter(customImportTable, typeof(TJson), typeof(TValue), wrapper);
	}

	public static void RegisterFactory<T>(FactoryFunc<T> factory) {
		FactoryFunc factoryWrapper = delegate {
			return factory();
		};
		customFactoryTable[typeof(T)] = factoryWrapper;
	}

	public static void UnregisterFactories() {
		customFactoryTable.Clear();
	}

	public static void UnregisterExporters() {
		customExportTable.Clear();
	}

	public static void UnregisterImporters() {
		customImportTable.Clear();
	}
}

}
