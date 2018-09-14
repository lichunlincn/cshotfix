using System;
using System.Collections.Generic;

using System.Text;

namespace GameDll
{
    public  class VariableManager
    {
        private Dictionary<string, string> m_Map = new Dictionary<string, string>();
        public void SetValue(string key, int value)
        {
            if (string.IsNullOrEmpty(key))
                return;
            if (m_Map.ContainsKey(key))
            {
                m_Map[key] = value.ToString();
            }
            else
            {
                m_Map.Add(key, value.ToString());
            }
        }
        public class GetValueIntParam
        {
            public bool hr;
            public int value;
        }
        public static GetValueIntParam m_IntParam;
        public GetValueIntParam GetVauleInt(string key)
        {
            m_IntParam.hr = false;
            m_IntParam.value = 0;
            if (string.IsNullOrEmpty(key))
                return m_IntParam;
            string hr = "";
            if (m_Map.TryGetValue(key, out hr))
            {
                m_IntParam.hr = int.TryParse(hr, out m_IntParam.value);
                return m_IntParam;
            }
            return m_IntParam;
        }

        public void SetValue(string key, float value)
        {
            if (string.IsNullOrEmpty(key))
                return;
            if (m_Map.ContainsKey(key))
            {
                m_Map[key] = value.ToString();
            }
            else
            {
                m_Map.Add(key, value.ToString());
            }
        }
        public class GetValueFloatParam
        {
            public bool hr;
            public float value;
        }
        public static GetValueFloatParam m_FloatParam;
        public GetValueFloatParam GetVauleFloat(string key)
        {
            m_FloatParam.hr = false;
            m_FloatParam.value = 0;
            if (string.IsNullOrEmpty(key))
                return m_FloatParam;
            string hr = "";
            if (m_Map.TryGetValue(key, out hr))
            {
                m_FloatParam.hr = float.TryParse(hr, out m_FloatParam.value);
                return m_FloatParam;
            }
            return m_FloatParam;
        }

        public void SetValue(string key, string value)
        {
            if (string.IsNullOrEmpty(key))
                return;
            if (m_Map.ContainsKey(key))
            {
                m_Map[key] = value;
            }
            else
            {
                m_Map.Add(key, value);
            }
        }
        public class GetValueStringParam
        {
            public bool hr;
            public string value;
        }
        public static GetValueStringParam m_StringParam;
        public GetValueStringParam GetVauleString(string key)
        {
            m_StringParam.value = "";
            m_StringParam.hr = false;
            if (string.IsNullOrEmpty(key))
                return m_StringParam;
            m_StringParam.hr = m_Map.TryGetValue(key, out m_StringParam.value);
            return m_StringParam;
        }
    }
}
