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
    [MenuItem("CSHotFix/GenMonoType")]
    static void GenerateCLRBinding()
    {
        if (!EditorUtility.DisplayDialog("警告", "你是否需要重新生成绑定信息？", "需要", "按错了"))
        {
            return;
        }
        List<Type> types = new List<Type>();
        types.Add(typeof(int));
        types.Add(typeof(float));
        types.Add(typeof(long));
        types.Add(typeof(object));
        types.Add(typeof(string));
        types.Add(typeof(Array));
        types.Add(typeof(Vector2));
        types.Add(typeof(Vector3));
        types.Add(typeof(Quaternion));
        types.Add(typeof(GameObject));
        types.Add(typeof(UnityEngine.Object));
        types.Add(typeof(Transform));
        types.Add(typeof(RectTransform));
        types.Add(typeof(Time));
        types.Add(typeof(Debug));
        //types.Add(typeof(UIEventListener));
        //所有DLL内的类型的真实C#类型都是ILTypeInstance
        types.Add(typeof(List<CSHotFix.Runtime.Intepreter.ILTypeInstance>));
        types.AddRange( AddGameDllTypes());
        types.AddRange(AddUnityDll());

        CSHotFix.Runtime.CLRBinding.BindingCodeGenerator.GenerateBindingCode(types, "Assets/CSHotFixLibaray/Generated/CLRGen", true);
        AddCSHotFixDefine();
        AssetDatabase.Refresh();

    }
    static List<string> GetDefineSymbols()
    {
#if UNITY_IPHONE
        string symbolsDefines = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.iPhone);
#elif UNITY_ANDROID
        string symbolsDefines = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
#else
        string symbolsDefines = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone);
#endif
        return symbolsDefines.Split(';').ToList();
    }
    static void AddCSHotFixDefine()
    {
        var definesList = GetDefineSymbols();
        if (!definesList.Contains("CSHotFix"))
        {
            definesList.Add("CSHotFix");
        }
        string defineSymbols = string.Join(";", definesList.ToArray());
#if UNITY_IPHONE
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iPhone, defineSymbols);
#elif UNITY_ANDROID
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, defineSymbols);
#else
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone, defineSymbols);
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.WebPlayer, defineSymbols);
#endif
    }


    static List<Type> AddUnityDll()
    {
        List<Type> _outTypes = new List<Type>();
        _outTypes.AddRange(Assembly.Load("UnityEngine").GetTypes());
        _outTypes.AddRange(Assembly.Load("UnityEngine.UI").GetTypes());



        List<Type> outTypes = new List<Type>();
        foreach (var t in _outTypes)
        {
            if (FilterCommon(t))
            {
                continue;
            }
            //进行其他过滤，例如和移动平台不相干的、不适合的，和版本不相符的，以及其他不支持的。
            if (GenConfig.blackNamespaceList.Exists((_black) =>
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
            if (GenConfig.blackTypeList.Exists((_black)=>{return t == _black; }))
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
        if (t.IsEnum)
        {
            return true;
        }
        return false;
    }

    static List<Type> AddGameDllTypes()
    {
        List<Type> outTypes = new List<Type>();
        Type[] _types = Assembly.Load("Assembly-CSharp").GetTypes();
        foreach(var t in _types)
        {
            if( t.Namespace!= null && t.Namespace.Contains("LCL"))
            {
                if(FilterCommon(t))
                {
                    continue;
                }
                outTypes.Add(t);
            }
        }
        return outTypes;
    }

    //[MenuItem("CSHotFix/按照热更工程实际使用情况生成绑定文件")]
    static void GenerateCLRBindingByAnalysis()
    {
        //用新的分析热更dll调用引用来生成绑定代码
        string[] fileNames =  Directory.GetFiles("Assets/Resource", "*.dll.bytes");
        foreach (var filename in fileNames)
        {
            CSHotFix.Runtime.Enviorment.AppDomain domain = new CSHotFix.Runtime.Enviorment.AppDomain();
            using (System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                domain.LoadAssembly(fs);
            }
            //Crossbind Adapter is needed to generate the correct binding code
            InitCSHotFix(domain);
            CSHotFix.Runtime.CLRBinding.BindingCodeGenerator.GenerateBindingCode(domain, "Assets/CSHotFixLibaray/Generated/CLRGen", false);
            AssetDatabase.Refresh();
            Debug.Log("生成CLRBinding：" + filename);
        }
    }

    static void InitCSHotFix(CSHotFix.Runtime.Enviorment.AppDomain domain)
    {
        //这里需要注册所有热更DLL中用到的跨域继承Adapter，否则无法正确抓取引用
        //domain.RegisterCrossBindingAdaptor(new MonoBehaviourAdapter());
        //domain.RegisterCrossBindingAdaptor(new CoroutineAdapter());
        domain.RegisterCrossBindingAdaptor(new IGameHotFixInterfaceAdapter());

    }
}
#endif
