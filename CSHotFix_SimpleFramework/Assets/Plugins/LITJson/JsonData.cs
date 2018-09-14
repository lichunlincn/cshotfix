#region Header
/*
 * The authors disclaim copyright to this source code. For more details, see
 * the COPYING file included with this distribution.
 */
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;

namespace LITJson {

/// <summary>
/// Generic type to hold JSON data (objects, arrays, and so on).
/// This isthe default type returned by JsonMapper.ToObject().
/// </summary>
public class JsonData : IJsonWrapper, IEquatable<JsonData> {
	private object val;
	private string json;
	private JsonType type;

	// Used to implement the IOrderedDictionary interface
	private IList<KeyValuePair<string, JsonData>> list;

	#region JsonData Properties

	public int Count {
		get { return EnsureCollection().Count; }
	}

	#endregion

	#region IJsonWrapper Properties

	public bool IsArray {
		get { return type == JsonType.Array; }
	}

	public bool IsBoolean {
		get { return type == JsonType.Boolean; }
	}

	public bool IsReal {
		get { return type == JsonType.Real; }
	}

	public bool IsNatural {
		get { return type == JsonType.Natural; }
	}

	public bool IsObject {
		get { return type == JsonType.Object; }
	}

	public bool IsString {
		get { return type == JsonType.String; }
	}

	public ICollection<string> Keys {
		get {
			EnsureDictionary();
			return GetObject().Keys;
		}
	}
	#endregion

	#region ICollection Properties

	int ICollection.Count {
		get { return Count; }
	}

	bool ICollection.IsSynchronized {
		get { return EnsureCollection().IsSynchronized; }
	}

	object ICollection.SyncRoot {
		get { return EnsureCollection().SyncRoot; }
	}

	#endregion

	#region IDictionary Properties

	bool IDictionary.IsFixedSize {
		get { return EnsureDictionary().IsFixedSize; }
	}

	bool IDictionary.IsReadOnly {
		get { return EnsureDictionary().IsReadOnly; }
	}

	ICollection IDictionary.Keys {
		get {
			EnsureDictionary();
			IList<string> keys = new List<string>();
			foreach (KeyValuePair<string, JsonData> entry in list) {
				keys.Add(entry.Key);
			}
			return (ICollection)keys;
		}
	}

	ICollection IDictionary.Values {
		get {
			EnsureDictionary();
			IList<JsonData> values = new List<JsonData>();
			foreach (KeyValuePair<string, JsonData> entry in list) {
				values.Add(entry.Value);
			}
			return (ICollection)values;
		}
	}

	#endregion

	#region IList Properties

	bool IList.IsFixedSize {
		get { return EnsureList().IsFixedSize; }
	}

	bool IList.IsReadOnly {
		get { return EnsureList().IsReadOnly; }
	}

	#endregion

	#region IDictionary Indexer

	object IDictionary.this[object key] {
		get { return EnsureDictionary()[key]; }
		set {
			if (!(key is string)) {
				throw new ArgumentException("The key has to be a string");
			}
			JsonData data = ToJsonData(value);
			this[(string)key] = data;
		}
	}

	#endregion

	#region IOrderedDictionary Indexer

	object IOrderedDictionary.this[int idx] {
		get {
			EnsureDictionary();
			return list[idx].Value;
		}
		set {
			EnsureDictionary();
			JsonData data = ToJsonData(value);
			KeyValuePair<string, JsonData> old = list[idx];
			GetObject()[old.Key] = data;
			KeyValuePair<string, JsonData> entry = new KeyValuePair<string, JsonData>(old.Key, data);
			list[idx] = entry;
		}
	}

	#endregion

	#region IList Indexer

	object IList.this[int index] {
		get { return EnsureList()[index]; }
		set {
			EnsureList();
			JsonData data = ToJsonData(value);
			this[index] = data;
		}
	}

	#endregion

	#region Public Indexers

	public JsonData this[string name] {
		get {
			EnsureDictionary();
			return GetObject()[name];
		}
		set {
			EnsureDictionary();
			KeyValuePair<string, JsonData> entry = new KeyValuePair<string, JsonData>(name, value);
			if (GetObject().ContainsKey(name)) {
				for (int i = 0; i < list.Count; i++) {
					if (list[i].Key == name) {
						list[i] = entry;
						break;
					}
				}
			} else {
				list.Add(entry);
			}
			GetObject()[name] = value;
			json = null;
		}
	}

	public JsonData this[int index] {
		get {
			EnsureCollection();
			if (type == JsonType.Array) {
				return GetArray()[index];
			}
			return list[index].Value;
		}
		set {
			EnsureCollection();
			if (type == JsonType.Array) {
				GetArray()[index] = value;
			} else {
				KeyValuePair<string, JsonData> old = list[index];
				KeyValuePair<string, JsonData> entry = new KeyValuePair<string, JsonData>(old.Key, value);
				list[index] = entry;
				GetObject()[old.Key] = value;
			}
			json = null;
		}
	}

	#endregion

	#region Constructors

	public JsonData(bool boolean) {
		type = JsonType.Boolean;
		val = boolean;
	}

	public JsonData(double number) {
		type = JsonType.Real;
		val = number;
	}

	public JsonData(long number) {
		type = JsonType.Natural;
		val = number;
	}

	public JsonData(string str) {
		type = JsonType.String;
		val = str;
	}

	public JsonData(object obj) {
		if (obj is bool) {
			type = JsonType.Boolean;
		}  else if (obj is double) {
			type = JsonType.Real;
		} else if (obj is long) {
			type = JsonType.Natural;
		} else if (obj is string) {
			type = JsonType.String;
		} else if (obj is sbyte) {
			type = JsonType.Natural;
			obj = (long)(sbyte)obj;
		} else if (obj is byte) {
			type = JsonType.Natural;
			obj = (long)(byte)obj;
		} else if (obj is short) {
			type = JsonType.Natural;
			obj = (long)(short)obj;
		} else if (obj is ushort) {
			type = JsonType.Natural;
			obj = (long)(ushort)obj;
		} else if (obj is int) {
			type = JsonType.Natural;
			obj = (long)(int)obj;
		} else if (obj is uint) {
			type = JsonType.Natural;
			obj = (long)(uint)obj;
		} else if (obj is ulong) {
			type = JsonType.Natural;
			obj = (long)(ulong)obj;
		} else if (obj is float) {
			type = JsonType.Real;
			obj = (double)(float)obj;
		} else if (obj is decimal) {
			type = JsonType.Real;
			obj = (double)(decimal)obj;
		} else {
			throw new ArgumentException ("Unable to wrap "+obj+" of type "+(obj == null ? null : obj.GetType())+" with JsonData");
		}
		val = obj;
	}

	public JsonData() {
	}

	public JsonData(sbyte number) : this((long)number) {
	}

	public JsonData(byte number) : this((long)number) {
	}

	public JsonData(short number) : this((long)number) {
	}

	public JsonData(ushort number) : this((long)number) {
	}

	public JsonData(int number) : this((long)number) {
	}

	public JsonData(uint number) : this((long)number) {
	}

	public JsonData(ulong number) : this((long)number) {
	}

	public JsonData(float number) : this((double)number) {
	}

	public JsonData(decimal number) : this((double)number) {
	}

	#endregion

	#region Implicit Conversions

	// Implicit cast operations should not loose precision.
	// As such, types not directly supported (unsigned numbers, decimal, etc.) cannot be implicitly cast from.

	public static implicit operator JsonData(bool data) {
		return new JsonData(data);
	}

	public static implicit operator JsonData(double data) {
		return new JsonData(data);
	}

	public static implicit operator JsonData(long data) {
		return new JsonData(data);
	}

	public static implicit operator JsonData(string data) {
		return new JsonData(data);
	}

	#endregion

	#region Explicit Conversions

	// Explicit cast operations can loose precision.
	// As such, types not normally supported can still be cast to.

	public static explicit operator bool(JsonData data) {
		if (data.IsBoolean) {
			return data.GetBoolean();
		}
		throw new InvalidCastException("Instance of JsonData doesn't hold a boolean");
	}

	public static explicit operator float(JsonData data) {
		if (data.IsReal) {
			return (float)data.GetReal();
		}
		if (data.IsNatural) {
			return (float)data.GetNatural();
		}
		throw new InvalidCastException("Instance of JsonData doesn't hold a real or natural number");
	}

	public static explicit operator double(JsonData data) {
		if (data.IsReal) {
			return data.GetReal();
		}
		if (data.IsNatural) {
			return (double)data.GetNatural();
		}
		throw new InvalidCastException("Instance of JsonData doesn't hold a real or natural number");
	}

	public static explicit operator decimal(JsonData data) {
		if (data.IsReal) {
			return (decimal)data.GetReal();
		}
		if (data.IsNatural) {
			return (decimal)data.GetNatural();
		}
		throw new InvalidCastException("Instance of JsonData doesn't hold a real or natural number");
	}

	public static explicit operator sbyte(JsonData data) {
		if (data.IsNatural) {
			return (sbyte)data.GetNatural();
		}
		if (data.IsReal) {
			return (sbyte)data.GetReal();
		}
		throw new InvalidCastException("Instance of JsonData doesn't hold a real or natural number");
	}

	public static explicit operator byte(JsonData data) {
		if (data.IsNatural) {
			return (byte)data.GetNatural();
		}
		if (data.IsReal) {
			return (byte)data.GetReal();
		}
		throw new InvalidCastException("Instance of JsonData doesn't hold a real or natural number");
	}

	public static explicit operator short(JsonData data) {
		if (data.IsNatural) {
			return (short)data.GetNatural();
		}
		if (data.IsReal) {
			return (short)data.GetReal();
		}
		throw new InvalidCastException("Instance of JsonData doesn't hold a real or natural number");
	}

	public static explicit operator ushort(JsonData data) {
		if (data.IsNatural) {
			return (ushort)data.GetNatural();
		}
		if (data.IsReal) {
			return (ushort)data.GetReal();
		}
		throw new InvalidCastException("Instance of JsonData doesn't hold a real or natural number");
	}

	public static explicit operator int(JsonData data) {
		if (data.IsNatural) {
			return (int)data.GetNatural();
		}
		if (data.IsReal) {
			return (int)data.GetReal();
		}
		throw new InvalidCastException("Instance of JsonData doesn't hold a real or natural number");
	}

	public static explicit operator uint(JsonData data) {
		if (data.IsNatural) {
			return (uint)data.GetNatural();
		}
		if (data.IsReal) {
			return (uint)data.GetReal();
		}
		throw new InvalidCastException("Instance of JsonData doesn't hold a real or natural number");
	}

	public static explicit operator long(JsonData data) {
		if (data.IsNatural) {
			return data.GetNatural();
		}
		if (data.IsReal) {
			return (long)data.GetReal();
		}
		throw new InvalidCastException("Instance of JsonData doesn't hold a real or natural number");
	}

	public static explicit operator ulong(JsonData data) {
		if (data.IsNatural) {
			return (ulong)data.GetNatural();
		}
		if (data.IsReal) {
			return (ulong)data.GetReal();
		}
		throw new InvalidCastException("Instance of JsonData doesn't hold a real or natural number");
	}

	public static explicit operator string(JsonData data) {
		return data.val == null ? null : data.val.ToString();
	}

	#endregion

	#region ICollection Methods

	void ICollection.CopyTo(Array array, int index) {
		EnsureCollection().CopyTo(array, index);
	}

	#endregion

	#region IDictionary Methods

	void IDictionary.Add(object key, object value) {
		JsonData data = ToJsonData(value);
		EnsureDictionary().Add(key, data);
		KeyValuePair<string, JsonData> entry = new KeyValuePair<string, JsonData>((string)key, data);
		list.Add(entry);
		json = null;
	}

	void IDictionary.Clear() {
		EnsureDictionary().Clear();
		list.Clear();
		json = null;
	}

	bool IDictionary.Contains(object key) {
		return EnsureDictionary().Contains(key);
	}

	IDictionaryEnumerator IDictionary.GetEnumerator() {
		return ((IOrderedDictionary)this).GetEnumerator();
	}

	void IDictionary.Remove(object key) {
		EnsureDictionary().Remove(key);
		for (int i = 0; i < list.Count; i++) {
			if (list[i].Key == (string)key) {
				list.RemoveAt(i);
				break;
			}
		}
		json = null;
	}

	#endregion

	#region IEnumerable Methods

	IEnumerator IEnumerable.GetEnumerator() {
		return EnsureCollection().GetEnumerator();
	}

	#endregion

	#region IJsonWrapper Methods

	public bool GetBoolean() {
		if (IsBoolean) {
			return (bool)val;
		}
		throw new InvalidOperationException("JsonData instance doesn't hold a boolean");
	}

	public double GetReal() {
		if (IsReal) {
			return (double)val;
		}
		throw new InvalidOperationException("JsonData instance doesn't hold a real number");
	}

	public long GetNatural() {
		if (IsNatural) {
			try {
				return (long)val;
			} catch {
				throw new InvalidCastException("expected long but got "+val.GetType()+" from "+val);
			}
		}
		throw new InvalidOperationException("JsonData instance doesn't hold a natural number");
	}

	public string GetString() {
		if (IsString) {
			return (string)val;
		}
		throw new InvalidOperationException("JsonData instance doesn't hold a string");
	}

	private IDictionary<string, JsonData> GetObject() {
		if (IsObject) {
			return (IDictionary<string, JsonData>)val;
		}
		throw new InvalidOperationException("JsonData instance doesn't hold an object");
	}

	private IList<JsonData> GetArray() {
		if (IsArray) {
			return (IList<JsonData>)val;
		}
		throw new InvalidOperationException("JsonData instance doesn't hold an array");
	}

	public void SetBoolean(bool val) {
		type = JsonType.Boolean;
		this.val = val;
		json = null;
	}

	public void SetReal(double val) {
		type = JsonType.Real;
		this.val = val;
		json = null;
	}

	public void SetNatural(long val) {
		type = JsonType.Natural;
		this.val = val;
		json = null;
	}

	public void SetString(string val) {
		type = JsonType.String;
		this.val = val;
		json = null;
	}

	void IJsonWrapper.ToJson(JsonWriter writer) {
		ToJson(writer);
	}

	#endregion

	#region IList Methods

	int IList.Add(object value) {
		return Add(value);
	}

	void IList.Clear() {
		EnsureList().Clear();
		json = null;
	}

	bool IList.Contains(object value) {
		return EnsureList().Contains(value);
	}

	int IList.IndexOf(object value) {
		return EnsureList().IndexOf(value);
	}

	void IList.Insert(int index, object value) {
		EnsureList().Insert(index, value);
		json = null;
	}

	void IList.Remove(object value) {
		EnsureList().Remove(value);
		json = null;
	}

	void IList.RemoveAt(int index) {
		EnsureList().RemoveAt(index);
		json = null;
	}

	#endregion

	#region IOrderedDictionary Methods

	IDictionaryEnumerator IOrderedDictionary.GetEnumerator() {
		EnsureDictionary();
		return new OrderedDictionaryEnumerator(list.GetEnumerator());
	}

	void IOrderedDictionary.Insert(int idx, object key, object value) {
		string property = (string)key;
		JsonData data = ToJsonData(value);
		this[property] = data;
		KeyValuePair<string, JsonData> entry = new KeyValuePair<string, JsonData>(property, data);
		list.Insert(idx, entry);
	}

	void IOrderedDictionary.RemoveAt(int idx) {
		EnsureDictionary();
		GetObject().Remove(list[idx].Key);
		list.RemoveAt(idx);
	}

	#endregion

	#region Private Methods

	private ICollection EnsureCollection() {
		if (IsArray || IsObject) {
			return (ICollection)val;
		}
		throw new InvalidOperationException("The JsonData instance has to be initialized first");
	}

	private IDictionary EnsureDictionary() {
		if (IsObject) {
			return (IDictionary)val;
		}
		if (type != JsonType.None) {
			throw new InvalidOperationException("Instance of JsonData is not a dictionary");
		}
		type = JsonType.Object;
		val = new Dictionary<string, JsonData>();
		list = new List<KeyValuePair<string, JsonData>>();
		return (IDictionary)val;
	}

	private IList EnsureList() {
		if (IsArray) {
			return (IList)val;
		}
		if (type != JsonType.None) {
			throw new InvalidOperationException("Instance of JsonData is not a list");
		}
		type = JsonType.Array;
		val = new List<JsonData>();
		return (IList)val;
	}

	private JsonData ToJsonData(object obj) {
		if (obj == null) {
			return null;
		}
		if (obj is JsonData) {
			return (JsonData)obj;
		}
		return new JsonData(obj);
	}

	private static void WriteJson(IJsonWrapper obj, JsonWriter writer) {
		if (obj == null) {
			writer.Write(null);
		} else if (obj.IsString) {
			writer.Write(obj.GetString());
		} else if (obj.IsBoolean) {
			writer.Write(obj.GetBoolean());
		} else if (obj.IsReal) {
			writer.Write(obj.GetReal());
		} else if (obj.IsNatural) {
			writer.Write(obj.GetNatural());
		} else if (obj.IsArray) {
			writer.WriteArrayStart();
			foreach (object elem in (IList)obj) {
				WriteJson((JsonData)elem, writer);
			}
			writer.WriteArrayEnd();
		} else if (obj.IsObject) {
			writer.WriteObjectStart();
			foreach (DictionaryEntry entry in ((IDictionary)obj)) {
				writer.WritePropertyName((string)entry.Key);
				WriteJson((JsonData)entry.Value, writer);
			}
			writer.WriteObjectEnd();
		}
	}

	#endregion

	public int Add(object value) {
		JsonData data = ToJsonData(value);
		json = null;
		return EnsureList().Add(data);
	}

	public void Clear() {
		if (IsObject) {
			((IDictionary)this).Clear();
		} else if (IsArray) {
			((IList)this).Clear();
		}
	}

	public bool Equals(JsonData data) {
		return Equals((object)data);
	}

	public override bool Equals(object obj) {
		if (obj == null) {
			return false;
		}
		if (!(obj is JsonData)) {
			return false;
		}
		JsonData data = (JsonData)obj;
		if (type != data.type) {
			return false;
		}
		switch (type) {
		case JsonType.None:
			return true;
		case JsonType.Object:
			return GetObject().Equals(data.GetObject());
		case JsonType.Array:
			return GetArray().Equals(data.GetArray());
		case JsonType.String:
			return GetString().Equals(data.GetString());
		case JsonType.Natural:
			return GetNatural().Equals(data.GetNatural());
		case JsonType.Real:
			return GetReal().Equals(data.GetReal());
		case JsonType.Boolean:
			return GetBoolean().Equals(data.GetBoolean());
		}
		return false;
	}

	public override int GetHashCode() {
		if (val == null) {
			return 0;
		}
		return val.GetHashCode();
	}

	public JsonType GetJsonType() {
		return type;
	}

	public void SetJsonType(JsonType type) {
		if (this.type == type) {
			return;
		}
		switch (type) {
		case JsonType.None:
			break;
		case JsonType.Object:
			val = new Dictionary<string, JsonData>();
			list = new List<KeyValuePair<string, JsonData>>();
			break;
		case JsonType.Array:
			val = new List<JsonData>();
			break;
		case JsonType.String:
			val = default(string);
			break;
		case JsonType.Natural:
			val = default(long);
			break;
		case JsonType.Real:
			val = default(double);
			break;
		case JsonType.Boolean:
			val = default(bool);
			break;
		}
		this.type = type;
	}

	public string ToJson() {
		if (json != null) {
			return json;
		}
		StringWriter sw = new StringWriter();
		JsonWriter writer = new JsonWriter(sw);
		writer.Validate = false;
		WriteJson(this, writer);
		json = sw.ToString();
		return json;
	}

	public void ToJson(JsonWriter writer) {
		bool old = writer.Validate;
		writer.Validate = false;
		WriteJson(this, writer);
		writer.Validate = old;
	}

	public override string ToString() {
		switch (type) {
		case JsonType.Array:
			return "JsonData array";
		case JsonType.Object:
			return "JsonData object";
		case JsonType.None:
			return "Uninitialized JsonData";
		}
		return val == null ? "null" : val.ToString();
	}
}

internal class OrderedDictionaryEnumerator : IDictionaryEnumerator {
	private IEnumerator<KeyValuePair<string, JsonData>> enumerator;

	public object Current {
		get { return Entry; }
	}

	public DictionaryEntry Entry {
		get {
			KeyValuePair<string, JsonData> curr = enumerator.Current;
			return new DictionaryEntry(curr.Key, curr.Value);
		}
	}

	public object Key {
		get { return enumerator.Current.Key; }
	}

	public object Value {
		get { return enumerator.Current.Value; }
	}

	public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator) {
		this.enumerator = enumerator;
	}

	public bool MoveNext() {
		return enumerator.MoveNext();
	}

	public void Reset() {
		enumerator.Reset();
	}
}

}
