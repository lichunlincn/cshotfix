using System;
using System.Collections.Generic;
using System.Text;
using LCL;
using UnityEngine;

namespace GameDll
{
    public class ShaderManager
    {

        private static Dictionary<string, Shader> m_ShaderList = new Dictionary<string, Shader>();
        //曾经加载过shaderlist，有可能因为shaderlist本来就为空，所以没有数据，这是正常情况
        private static bool m_bLoadedShaderList = false;
        public static void CacheShader()
        {
            m_bLoadedShaderList = true;
            var main = ResourceManager.LoadPrefab(typeof(GameObject), "shader/shaderslist.jpg", "shaderslist");
            if (main != null)
            {
                GameObject clone = GameObject.Instantiate(main.m_UObjectList[0]) as GameObject;
                GameObject.DontDestroyOnLoad(clone);
                ShadersList _shaderslist = clone.GetComponent<ShadersList>();
                foreach (Shader _shader in _shaderslist.list)
                {
                    if (!m_ShaderList.ContainsKey(_shader.name))
                    {
                        m_ShaderList.Add(_shader.name, _shader);
                    }
                }
                //GameObject.Destroy(main);
                UnityEngine.Debug.Log("加载shaderslist成功，加载" + m_ShaderList.Count.ToString() + "个shader");
            }
            else
            {
                UnityEngine.Debug.LogError("加载shaderslist失败");
            }

        }
        public static bool IsLoadedShader()
        {
            return m_bLoadedShaderList;
        }
        public static Shader GetShaderAllowNull(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                if (m_ShaderList.ContainsKey(name))
                {
                    return m_ShaderList[name];
                }
            }

            return null;
            
        }
        public static Shader GetShader(string name)
        {
            if(!string.IsNullOrEmpty(name))
            {
                if (m_ShaderList.ContainsKey(name))
                {
                    return m_ShaderList[name];
                }
            }
            Debug.LogError("shader没有找到：" + name);
            return Shader.Find("Mobile/Diffuse");

        }
    }
}
