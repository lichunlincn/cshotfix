using System;
using System.Collections.Generic;
using System.Text;
using LITJson;

namespace LCL
{
    public class JsonDataWrapper
    {

        public static int Count(JsonData m_JsonData)
        {
            return m_JsonData.Count;
        }
        public static bool IsArray(JsonData m_JsonData)
        {
            return m_JsonData.IsArray;
        }
        public static bool IsBoolean(JsonData m_JsonData)
        {
            return m_JsonData.IsBoolean;
        }
        public static bool IsReal(JsonData m_JsonData)
        {
            return m_JsonData.IsReal;
        }
        public static bool IsNatural(JsonData m_JsonData)
        {
            return m_JsonData.IsNatural;
        }
        public static bool IsObject(JsonData m_JsonData)
        {
            return m_JsonData.IsObject;
        }
        public static bool IsString(JsonData m_JsonData)
        {
            return m_JsonData.IsString;
        }
        public static ICollection<string> Keys(JsonData m_JsonData)
        {
            return m_JsonData.Keys;
        }
        public static bool HasKey(JsonData m_JsonData, string name)
        {
            return m_JsonData.Keys.Contains(name);
        }
        public static JsonData GetByName(JsonData m_JsonData, string name)
        {
            return m_JsonData[name];
        }
        public static JsonData GetByIndex(JsonData m_JsonData, int index)
        {
            return m_JsonData[index];
        }
        public static bool GetBoolean(JsonData m_JsonData)
        {
            return m_JsonData.GetBoolean();
        }
        public static double GetReal(JsonData m_JsonData)
        {
            return m_JsonData.GetReal();
        }
        public static string GetString(JsonData m_JsonData)
        {
            return m_JsonData.GetString();
        }
        public static void SetBoolean(JsonData m_JsonData, bool val)
        {
            m_JsonData.SetBoolean(val);
        }
        public static void SetReal(JsonData m_JsonData, double val)
        {
            m_JsonData.SetReal(val);
        }
        public static void SetString(JsonData m_JsonData, string val)
        {
            m_JsonData.SetString(val);
        }
        public static int Add(JsonData m_JsonData, object value)
        {
            return m_JsonData.Add(value);
        }
        public static void Clear(JsonData m_JsonData)
        {
            m_JsonData.Clear();
        }
        public static bool Equals(JsonData m_JsonData, JsonData data)
        {
            return m_JsonData.Equals(data);
        }
        public static bool EqualsOverride(JsonData m_JsonData, object obj)
        {
            return m_JsonData.Equals(obj);
        }
        public static int GethashCodeOverride(JsonData m_JsonData)
        {
            return m_JsonData.GetHashCode();
        }
        public static int GetJsonType(JsonData m_JsonData)
        {
            return (int)m_JsonData.GetJsonType();
        }
        public static void SetJsonType(JsonData m_JsonData, int type)
        {
            m_JsonData.SetJsonType((JsonType)type);
        }
        public static string ToJson(JsonData m_JsonData)
        {
            return m_JsonData.ToJson();
        }
        public static string ToStringOveride(JsonData m_JsonData)
        {
            return m_JsonData.ToString();
        }
        public static int SetAsInt(JsonData m_JsonData)
        {
            return (int)m_JsonData;
        }
        public static string SetAsString(JsonData m_JsonData)
        {
            return (string)m_JsonData;
        }
        public static float SetAsFloat(JsonData m_JsonData)
        {
            return (float)m_JsonData;
        }
        public static double SetAsDouble(JsonData m_JsonData)
        {
            return (double)m_JsonData;
        }
        public static bool SetAsBool(JsonData m_JsonData)
        {
            return (bool)m_JsonData;
        }
        public static sbyte SetAsSByte(JsonData m_JsonData)
        {
            return (sbyte)m_JsonData;
        }
        public static byte SetAsByte(JsonData m_JsonData)
        {
            return (byte)m_JsonData;
        }

        public static short SetAsShort(JsonData m_JsonData)
        {
            return (short)m_JsonData;
        }
        public static ushort SetAsUshort(JsonData m_JsonData)
        {
            return (ushort)m_JsonData;
        }

        public static uint SetAsUint(JsonData m_JsonData)
        {
            return (uint)m_JsonData;
        }
    }

}