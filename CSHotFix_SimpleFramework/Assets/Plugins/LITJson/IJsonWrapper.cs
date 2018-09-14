#region Header
/*
 * The authors disclaim copyright to this source code.
 * For more details, see the COPYING file included with this distribution.
 */
#endregion

using System.Collections;
using System.Collections.Specialized;

namespace LITJson {

/// <summary>
/// This enum contains the possible types a JSON value can have.
/// </summary>
public enum JsonType {
	None,
	Object,
	Array,
	String,
	Natural,
	Real,
	Boolean
}

/// <summary>
/// Interface that represents a type capable of handling all kinds of JSON data.
/// This is mainly used when mapping objects through JsonMapper, and it's implemented by JsonData.
/// </summary>
public interface IJsonWrapper : IList, IOrderedDictionary {
	bool IsObject { get; }
	bool IsArray { get; }
	bool IsString { get; }
	bool IsNatural { get; }
	bool IsReal { get; }
	bool IsBoolean { get; }

	JsonType GetJsonType();
	string GetString();
	long GetNatural();
	double GetReal();
	bool GetBoolean();

	void SetJsonType(JsonType type);
	void SetString(string val);
	void SetNatural(long val);
	void SetReal(double val);
	void SetBoolean(bool val);

	string ToJson();
	void ToJson(JsonWriter writer);
}

}
