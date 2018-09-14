using System;

namespace LITJson {


[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class JsonIgnore : Attribute {
}

/// <summary>
/// Attribute to be placed on non-public fields or properties to include them in serialization.
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class JsonInclude : Attribute {
}

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class JsonAlias : Attribute {

	public string Alias { get; private set; }

	public bool AcceptOriginal { get; private set; }

	public JsonAlias(string aliasName, bool acceptOriginalName) {
		Alias = aliasName;
		AcceptOriginal = acceptOriginalName;
	}

		
		public JsonAlias(string aliasName) {
			Alias = aliasName;
			AcceptOriginal = false;
		}
	}
}
