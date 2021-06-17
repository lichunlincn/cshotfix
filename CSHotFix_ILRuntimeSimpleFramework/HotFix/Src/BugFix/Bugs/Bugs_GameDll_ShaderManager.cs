using GameDll;
using System;
using UnityEngine;
using LCL;
using System.Collections.Generic;

namespace HotFix
{
    public class Bugs_GameDll_ShaderManager
    {
        public static void CacheShader(object _this)
        {
            UnityEngine.Debug.LogError("ShaderManager CacheShader bug fix");

            ClassPrivateTool.SetStaticPrivateField(typeof(ShaderManager), "m_bLoadedShaderList", true);

            var main = ResourceManager.LoadPrefab(typeof(GameObject), "shader/shaderslist.jpg", "shaderslist");
            if (main != null)
            {
                GameObject clone = (GameObject)GameObject.Instantiate(main.m_UObjectList[0]);
                GameObject.DontDestroyOnLoad(clone);
                ShadersList _shaderslist = clone.GetComponent(typeof(ShadersList)) as ShadersList;

                Dictionary<string, Shader> m_ShaderList = (Dictionary<string, Shader>)ClassPrivateTool.GetStaticPrivateField(typeof(ShaderManager), "m_ShaderList");
                foreach (Shader _shader in _shaderslist.list)
                {
                    if (!m_ShaderList.ContainsKey(_shader.name))
                    {
                        UnityEngine.Debug.Log("Bugs_GameDll_ShaderManager, CacheShader, Add shader:" + _shader.name);
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
    }
}

