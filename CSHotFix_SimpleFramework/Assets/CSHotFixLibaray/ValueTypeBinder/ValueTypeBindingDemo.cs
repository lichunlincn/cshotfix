using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using CSHotFix.CLR.TypeSystem;
using CSHotFix.CLR.Method;
using CSHotFix.Runtime.Enviorment;

public class ValueTypeBindingDemo : MonoBehaviour
{
    //AppDomain是CSHotFix的入口，最好是在一个单例类中保存，整个游戏全局就一个，这里为了示例方便，每个例子里面都单独做了一个
    //大家在正式项目中请全局只创建一个AppDomain
    AppDomain appdomain;

    void Start()
    {
        StartCoroutine(LoadHotFixAssembly());
    }

    IEnumerator LoadHotFixAssembly()
    {
        //首先实例化CSHotFix的AppDomain，AppDomain是一个应用程序域，每个AppDomain都是一个独立的沙盒
        appdomain = new CSHotFix.Runtime.Enviorment.AppDomain();
        //正常项目中应该是自行从其他地方下载dll，或者打包在AssetBundle中读取，平时开发以及为了演示方便直接从StreammingAssets中读取，
        //正式发布的时候需要大家自行从其他地方读取dll

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //这个DLL文件是直接编译HotFix_Project.sln生成的，已经在项目中设置好输出目录为StreamingAssets，在VS里直接编译即可生成到对应目录，无需手动拷贝
#if UNITY_ANDROID
        WWW www = new WWW(Application.streamingAssetsPath + "/HotFix_Project.dll");
#else
        WWW www = new WWW("file:///" + Application.streamingAssetsPath + "/HotFix_Project.dll");
#endif
        while (!www.isDone)
            yield return null;
        if (!string.IsNullOrEmpty(www.error))
            UnityEngine.Debug.LogError(www.error);
        byte[] dll = www.bytes;
        www.Dispose();

        //PDB文件是调试数据库，如需要在日志中显示报错的行号，则必须提供PDB文件，不过由于会额外耗用内存，正式发布时请将PDB去掉，下面LoadAssembly的时候pdb传null即可
#if UNITY_ANDROID
        www = new WWW(Application.streamingAssetsPath + "/HotFix_Project.pdb");
#else
        www = new WWW("file:///" + Application.streamingAssetsPath + "/HotFix_Project.pdb");
#endif
        while (!www.isDone)
            yield return null;
        if (!string.IsNullOrEmpty(www.error))
            UnityEngine.Debug.LogError(www.error);
        byte[] pdb = www.bytes;
        using (System.IO.MemoryStream fs = new MemoryStream(dll))
        {
            using (System.IO.MemoryStream p = new MemoryStream(pdb))
            {
                appdomain.LoadAssembly(fs, p, new Mono.Cecil.Pdb.PdbReaderProvider());
            }
        }

        InitializeCSHotFix();
        yield return new WaitForSeconds(0.5f);
        RunTest();
        yield return new WaitForSeconds(0.5f);
        RunTest2();
        yield return new WaitForSeconds(0.5f);
        RunTest3();
    }

    void InitializeCSHotFix()
    {
        //这里做一些CSHotFix的注册，这里我们注册值类型Binder，注释和解注下面的代码来对比性能差别
        appdomain.RegisterValueTypeBinder(typeof(Vector3), new Vector3Binder());
        appdomain.RegisterValueTypeBinder(typeof(Quaternion), new QuaternionBinder());
        appdomain.RegisterValueTypeBinder(typeof(Vector2), new Vector2Binder());
    }

    void RunTest()
    {
        Debug.Log("Vector3等Unity常用值类型如果不做任何处理，在CSHotFix中使用会产生较多额外的CPU开销和GC Alloc");
        Debug.Log("我们通过值类型绑定可以解决这个问题，只有Unity主工程的值类型才需要此处理，热更DLL内定义的值类型不需要任何处理");        
        Debug.Log("请注释或者解注InitializeCSHotFix里的代码来对比进行值类型绑定前后的性能差别");
        //调用无参数静态方法，appdomain.Invoke("类名", "方法名", 对象引用, 参数列表);
        appdomain.Invoke("HotFix_Project.TestValueType", "RunTest", null, null);
    }

    void RunTest2()
    {
        Debug.Log("=======================================");
        Debug.Log("Quaternion测试");
        //调用无参数静态方法，appdomain.Invoke("类名", "方法名", 对象引用, 参数列表);
        appdomain.Invoke("HotFix_Project.TestValueType", "RunTest2", null, null);
    }

    void RunTest3()
    {
        Debug.Log("=======================================");
        Debug.Log("Vector2测试");
        //调用无参数静态方法，appdomain.Invoke("类名", "方法名", 对象引用, 参数列表);
        appdomain.Invoke("HotFix_Project.TestValueType", "RunTest3", null, null);
    }
}
