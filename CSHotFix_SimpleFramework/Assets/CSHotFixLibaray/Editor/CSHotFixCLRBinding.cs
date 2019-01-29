/*
* LCL support c# hotfix here.
*Copyright(C) LCL.All rights reserved.
* URL:https://github.com/qq576067421/cshotfix 
*QQ:576067421 
* QQ Group: 673735733 
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at 
*  
* Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License. 
*/
#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System;
using System.Text;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using UnityEngine.AI;
using UnityEngine.Rendering;
using System.Linq;

[System.Reflection.Obfuscation(Exclude = true)]
public class CSHotFixCLRBinding
{
    [MenuItem("CSHotFix/单步操作/清理类型绑定")]
    public static void GenerateCLRBinding1a()
    {
        if (Directory.Exists(GenConfigEditor.CSHotFixCLRGen1Path))
        {
            string[] files = Directory.GetFiles(GenConfigEditor.CSHotFixCLRGen1Path, "*.cs");
            foreach (string file in files)
            {
                File.Delete(file);
            }
            string copyFile = Path.GetFullPath(GenConfigEditor.CSHotFixCLRGen1Path + "/CLRBindings.cs_");
            string destFile = Path.GetFullPath(GenConfigEditor.CSHotFixCLRGen1Path + "/CLRBindings.cs");
            if (File.Exists(copyFile))
            {
                File.Copy(copyFile, destFile, true);
                Debug.Log("清理类型绑定完成,请等待编译通过");
                AssetDatabase.Refresh();
            }
            else
            {
                Debug.LogError("文件没有找到：" + copyFile);
            }
        }
    }

    [MenuItem("CSHotFix/单步操作/导出类型绑定")]
    public static void GenerateCLRBinding1b()
    {
        //if (!EditorUtility.DisplayDialog("警告", "你是否需要重新生成绑定信息？", "需要", "按错了"))
        //{
        //    return;
        //}
        List<Type> types = new List<Type>();
        //types.Add(typeof(UIEventListener));
        //所有DLL内的类型的真实C#类型都是ILTypeInstance
        types.Add(typeof(List<CSHotFix.Runtime.Intepreter.ILTypeInstance>));
        types.AddRange( AddGameDllTypes());
        types.AddRange(AddUnityDll());
        types.AddRange(GenConfigPlugins.whiteTypeList);
        types.AddRange(GenConfigEditor.ExportTypeList);

        CSHotFix.Runtime.CLRBinding.BindingCodeGenerator.GenerateBindingCode(types, GenConfigEditor.CSHotFixCLRGen1Path);

        //AddCSHotFixDefine();
        AssetDatabase.Refresh();

    }
    [MenuItem("CSHotFix/单步操作/清理HotFix内类型绑定")]
    public static void GenerateCLRBinding2a()
    {

        if(Directory.Exists(GenConfigEditor.CSHotFixCLRGen2Path))
        {
            string[] files = Directory.GetFiles(GenConfigEditor.CSHotFixCLRGen2Path, "*.cs");
            foreach(string file in files)
            {
                File.Delete(file);
            }
            string copyFile = Path.GetFullPath( GenConfigEditor.CSHotFixCLRGen2Path + "/CLRBindings2.cs_");
            string destFile = Path.GetFullPath( GenConfigEditor.CSHotFixCLRGen2Path + "/CLRBindings2.cs");
            if (File.Exists(copyFile))
            {
                File.Copy(copyFile, destFile, true);
                Debug.Log("清理HotFix内类型绑定完成,请等待编译通过");
                AssetDatabase.Refresh();
            }
            else
            {
                Debug.LogError("文件没有找到：" + copyFile);
            }
        }
    }
    [MenuItem("CSHotFix/单步操作/生成HotFix内类型绑定")]
    public static void GenerateCLRBinding2b()
    {
#if CSHotFix
        //用新的分析热更dll调用引用来生成绑定代码
        CSHotFix.Runtime.Enviorment.AppDomain domain = new CSHotFix.Runtime.Enviorment.AppDomain();
        using (System.IO.FileStream fs = new System.IO.FileStream(GenConfigEditor.CSHotFixDllPath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
        {
            domain.LoadAssembly(fs);
        }
        //Crossbind Adapter is needed to generate the correct binding code

        HotFixManager.InitScript(domain);
        CSHotFix.Runtime.CLRBinding.BindingCodeGenerator.GenerateBindingCode(domain, GenConfigEditor.CSHotFixCLRGen2Path);
        AssetDatabase.Refresh();
#else
        if (!EditorUtility.DisplayDialog("错误", "当前不是发布模式，无法进行绑定生成的第二步", "知道了"))
        {
            Debug.LogError("当前不是发布模式，无法进行绑定生成的第二步");
            return;
        }
#endif
    }
//    static List<string> GetDefineSymbols()
//    {
//#if UNITY_IPHONE
//        string symbolsDefines = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.);
//#elif UNITY_ANDROID
//        string symbolsDefines = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
//#else
//        string symbolsDefines = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone);
//#endif
//        return symbolsDefines.Split(';').ToList();
//    }
//    static void AddCSHotFixDefine()
//    {
//        var definesList = GetDefineSymbols();
//        if (!definesList.Contains("CSHotFix"))
//        {
//            definesList.Add("CSHotFix");
//        }
//        string defineSymbols = string.Join(";", definesList.ToArray());
//#if UNITY_IPHONE
//        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iOS, defineSymbols);
//#elif UNITY_ANDROID
//        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, defineSymbols);
//#else
//        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone, defineSymbols);
//#endif
//    }


    static List<Type> AddUnityDll()
    {
        List<Type> _outTypes = new List<Type>();
        foreach (var assembly in GenConfigEditor.whiteAssemblyList)
        {
            _outTypes.AddRange(Assembly.Load(assembly).GetTypes());
        }
        List<Type> outTypes = new List<Type>();
        foreach (var t in _outTypes)
        {
            if (FilterCommon(t))
            {
                continue;
            }
            //进行其他过滤，例如和移动平台不相干的、不适合的，和版本不相符的，以及其他不支持的。
            if (GenConfigPlugins.blackNamespaceList.Exists((_black) =>
            {
                if(t.Namespace!= null)
                {
                    return t.Namespace.Contains(_black);
                }
                else
                {
                    return false;
                }

            }))
            {
                continue;
            }
            if (GenConfigPlugins.blackTypeList.Exists((_black)=>{return t == _black; }))
            {
                continue;
            }

            outTypes.Add(t);
            
        }
        return outTypes;
    }

    static bool FilterCommon(Type t)
    {
        if(t.IsNotPublic || !t.IsPublic)
        {
            return true;
        }
        if(t.IsGenericType)
        {
            return true;
        }
        if (t.BaseType == typeof(Delegate) || t.BaseType == typeof(MulticastDelegate))
        {
            return true;
        }
        if (t.Name.Contains("<"))
        {
            return true;
        }
        //if (t.IsEnum)
        //{
        //    return true;
        //}
        return false;
    }

    static List<Type> AddGameDllTypes()
    {
        List<Type> outTypes = new List<Type>();
        List<Type> temp = new List<Type>();
        foreach (var assembly in GenConfigEditor.whiteUserAssemblyList)
        {
            temp.AddRange(Assembly.Load(assembly).GetTypes());
        }
        //进行过滤
        foreach (var t in temp)
        {
            var attr = t.GetCustomAttributes(false).ToList().Find((obj) => { return obj is CSHotFixMonoTypeExportAttribute; }) as CSHotFixMonoTypeExportAttribute;
            if (attr != null)
            {
                if (attr.ExportFlag == CSHotFixMonoTypeExportFlagEnum.Export)
                {
                    outTypes.Add(t);
                }
            }
            else
            {
                if (t.Namespace == null)
                {
                    continue;
                }
                else
                {
                    bool isInNamespace = GenConfigEditor.whiteNameSpaceList.Exists((name) => { return t.Namespace == name; });
                    if (isInNamespace)
                    {
                        if (FilterCommon(t))
                        {
                            continue;
                        }
                        outTypes.Add(t);
                    }
                }

            }
        }
        return outTypes;
    }
}
#endif
