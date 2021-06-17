using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.IO;

#if JSON_WINRT || (UNITY_METRO && !UNITY_EDITOR)
namespace LitJson {

	public interface IOrderedDictionary : IDictionary, ICollection, IEnumerable {
		object this [int index] {
			get;
			set;
		}
		new IDictionaryEnumerator GetEnumerator ();
		void Insert (int index, object key, object value);
		void RemoveAt (int index);
	}
	
	public static class Platform {

		public static Type GetInterface(this Type _type,string name){
			foreach(Type t in _type.GetTypeInfo().ImplementedInterfaces){
				if(t.Name == name){
					return t;
				}
			}
			return null;
		}

		public static FieldInfo[] GetFields(this Type _type){
			return _type.GetTypeInfo().DeclaredFields.ToArray();
		}

		// No way to patch BindingFlags...
		public static FieldInfo[] GetFields(this Type _type,BindingFlags flags){
			return _type.GetTypeInfo().DeclaredFields.ToArray();
		}

		public static PropertyInfo[] GetProperties(this Type _type){
			return _type.GetTypeInfo().DeclaredProperties.ToArray();
		}

		// No way to patch BindingFlags...
		public static PropertyInfo[] GetProperties(this Type _type,BindingFlags flags){
			return _type.GetTypeInfo().DeclaredProperties.ToArray();
		}

		public static MethodInfo GetMethod(this Type _type,string name, Type[] types){
			return _type.GetRuntimeMethod(name,types);
		}
		
		public static bool IsAssignableFrom(this Type _type,Type other){
			return _type.GetTypeInfo().IsAssignableFrom(other.GetTypeInfo());
		}

		public static Type[] GetGenericArguments(this Type _type){
			return _type.GetTypeInfo().GenericTypeArguments;
		}
		
		public static object[] GetCustomAttributes(this Type _type, Type attributeType, bool inherit){
			return _type.GetTypeInfo().GetCustomAttributes(attributeType,inherit).ToArray();
		}
		
		public static ConstructorInfo GetConstructor(this Type _type, BindingFlags bindingAttr, object binder, Type[] types, object[] modifiers){
			return _type.GetTypeInfo().DeclaredConstructors.Where(c=>c.GetParameters().Count() == 0).Select(c=>c).FirstOrDefault();
		}

		// Replace with extention properties if they are ever added to .net
		public static bool IsClass(this Type _type){
			return _type.GetTypeInfo().IsClass;
		}
		
		// Replace with extention properties if they are ever added to .net
		public static bool IsEnum(this Type _type){
			return _type.GetTypeInfo().IsEnum;
		}

		public static MethodInfo GetGetMethod(this PropertyInfo property ){
			return property.GetMethod;
		}
		
		public static MethodInfo GetSetMethod(this PropertyInfo property ){
			return property.SetMethod;
		}

		public static void Close(this TextReader _reader){
			_reader.Dispose();
		}
		
	}
}
#endif
