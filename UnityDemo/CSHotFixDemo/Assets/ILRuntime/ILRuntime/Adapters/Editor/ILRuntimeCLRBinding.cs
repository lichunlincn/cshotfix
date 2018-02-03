#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System;
using System.Text;
using System.Collections.Generic;
using System.Reflection;
using System.IO;

[System.Reflection.Obfuscation(Exclude = true)]
public class ILRuntimeCLRBinding
{
    [MenuItem("ILRuntime/生成所有绑定文件")]
    static void GenerateCLRBinding()
    {
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
        types.Add(typeof(List<ILRuntime.Runtime.Intepreter.ILTypeInstance>));
        AddGameDllTypes(types);

        ILRuntime.Runtime.CLRBinding.BindingCodeGenerator.GenerateBindingCode(types, "Assets/ILRuntime/ILRuntime/Generated", true);
        AssetDatabase.Refresh();

    }
    private static void AddGameDllTypes(List<Type> outTypes)
    {
        Type[] _types = Assembly.Load("Assembly-CSharp").GetTypes();
        foreach(var t in _types)
        {
            if( t.Namespace!= null && t.Namespace.Contains("LCL"))
            {
                if( t.BaseType == typeof(Delegate) || t.BaseType == typeof(MulticastDelegate))
                {
                    continue;
                }
                if(t.Name.Contains("<"))
                {
                    continue;
                }
                if(t.IsEnum)
                {
                    continue;
                }
                outTypes.Add(t);
            }
        }
    }

    [MenuItem("ILRuntime/按照热更工程实际使用情况生成绑定文件")]
    static void GenerateCLRBindingByAnalysis()
    {
        //用新的分析热更dll调用引用来生成绑定代码
        string[] fileNames =  Directory.GetFiles("Assets/Resource", "*.dll.bytes");
        foreach (var filename in fileNames)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = new ILRuntime.Runtime.Enviorment.AppDomain();
            using (System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                domain.LoadAssembly(fs);
            }
            //Crossbind Adapter is needed to generate the correct binding code
            InitILRuntime(domain);
            ILRuntime.Runtime.CLRBinding.BindingCodeGenerator.GenerateBindingCode(domain, "Assets/ILRuntime/ILRuntime/Generated", false);
            AssetDatabase.Refresh();
            Debug.Log("生成CLRBinding：" + filename);
        }
    }

    static void InitILRuntime(ILRuntime.Runtime.Enviorment.AppDomain domain)
    {
        //这里需要注册所有热更DLL中用到的跨域继承Adapter，否则无法正确抓取引用
        //domain.RegisterCrossBindingAdaptor(new MonoBehaviourAdapter());
        //domain.RegisterCrossBindingAdaptor(new CoroutineAdapter());
        domain.RegisterCrossBindingAdaptor(new IGameHotFixInterfaceAdapter());

    }
}
#endif
