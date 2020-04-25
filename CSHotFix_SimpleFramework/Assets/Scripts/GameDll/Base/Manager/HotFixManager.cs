using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using GameDll;
using CSHotFix.Runtime.Enviorment;
using UnityEngine;
using System.Reflection;

public class HotFixManager
{
    private CSHotFix.Runtime.Enviorment.AppDomain m_Assembly = null;
    private IGameHotFixInterface m_HotFixDll = null;
    public void Init(string dllName)
    {
        if (!Load(dllName))
        {
            UnityEngine.Debug.LogError("script dll load err");
            return;
        }
        Main main = Tool.Main();
        if (main != null)
        {
            m_Assembly.AllowUnboundCLRMethod = main.m_CheckUnBoundClass;
            UnityEngine.Debug.Log("CSHotFix 检测是否绑定类：" + main.m_CheckUnBoundClass);
        }
#if CSHotFixSafe

#else
        InitScript(m_Assembly);

#if CSHotFix
        CSHotFix.Runtime.Generated.CLRBindings.Initialize(m_Assembly);
        CSHotFix.Runtime.Generated.CLRBindings2.Initialize(m_Assembly);
#endif

#endif
        string HotFixLoop = dllName + ".HotFixLoop";
        m_HotFixDll = m_Assembly.Instantiate<IGameHotFixInterface>(HotFixLoop);
        m_HotFixDll.Start();
    }

    public static void InitScript(object obj)
    {
        CSHotFix.Runtime.Enviorment.AppDomain appDomain = obj as CSHotFix.Runtime.Enviorment.AppDomain;
        //根据实际情况手动添加几个注册
        //appDomain.DelegateManager.RegisterMethodDelegate<UnityEngine.GameObject>();
        //appDomain.DelegateManager.RegisterMethodDelegate<WfPacket>();
        appDomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction>((act) =>
            {
                return new UnityEngine.Events.UnityAction(() =>
                    {
                        ((Action)act)();
                    });
            });
        appDomain.DelegateManager.RegisterMethodDelegate<CSHotFix.Runtime.Intepreter.ILTypeInstance>();

#if CSHotFixSafe

#else

#if CSHotFix
        LCLFunctionDelegate.Reg(appDomain);
#endif

#endif
        AdapterRegister.RegisterCrossBindingAdaptor(appDomain);
        //单独注册协程
        appDomain.RegisterCrossBindingAdaptor(new CoroutineAdapter());
        //注册值类型
        appDomain.RegisterValueTypeBinder(typeof(Vector3), new Vector3Binder());
        appDomain.RegisterValueTypeBinder(typeof(Quaternion), new QuaternionBinder());
        appDomain.RegisterValueTypeBinder(typeof(Vector2), new Vector2Binder());
    }

    public bool Load(string dllName)
    {
        byte[] dllData = null;
        string dll_path = "";
        if (Application.platform == RuntimePlatform.Android)
        {
            //先尝试有平台方指定的目录或者平台默认的sdcard目录
            string outer_path = Application.persistentDataPath;
            outer_path = outer_path.Trim();
            if (!outer_path.EndsWith("/"))
            {
                outer_path = outer_path + "/";
            }
            dll_path = outer_path + "android/codeconfig/gamedll/" + dllName.ToLower() + ".dll.bytes"+ LCL.MonoTool.GetAssetbundleSuffix();
            //从手动指定的路径查找
            if (!File.Exists(dll_path))
            {
                dll_path = Application.dataPath + "!assets/android/codeconfig/gamedll/" + dllName.ToLower() + ".dll.bytes"+ LCL.MonoTool.GetAssetbundleSuffix();
                Debug.Log(dllName.ToLower() + " 版本：包内版本, path:" + dll_path);
            }
            else
            {
                Debug.Log(dllName.ToLower() + " 版本：热更版本, path is：" + dll_path);
            }
            AssetBundle ab = AssetBundle.LoadFromFile(dll_path);
            if (ab == null)
            {
                Debug.LogError("load dll failed ,path is:" + dll_path);
            }
            else
            {
                Debug.Log("load dll ok, path is:" + dll_path);
                dllData = ab.LoadAsset<TextAsset>(dllName.ToLower() + ".dll.bytes").bytes;
            }

        }
        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //先尝试有平台方指定的目录或者平台默认的sdcard目录
            string outer_path = Application.persistentDataPath;
            outer_path = outer_path.Trim();
            if (!outer_path.EndsWith("/"))
            {
                outer_path = outer_path + "/";
            }
            dll_path = outer_path + "ios/codeconfig/gamedll/" + dllName.ToLower() + ".dll.bytes"+ LCL.MonoTool.GetAssetbundleSuffix();
            //从手动指定的路径查找
            if (!File.Exists(dll_path))
            {
                dll_path = Application.dataPath + "/Raw/ios/codeconfig/gamedll/" + dllName.ToLower() + ".dll.bytes"+ LCL.MonoTool.GetAssetbundleSuffix();
                Debug.Log(dllName.ToLower() + " 版本：包内版本, path:" + dll_path);
            }
            else
            {
                Debug.Log(dllName.ToLower() + " 版本：热更版本, path is：" + dll_path);
            }
            AssetBundle ab = AssetBundle.LoadFromFile(dll_path);
            if (ab == null)
            {
                Debug.LogError("load dll failed ,path is:" + dll_path);
            }
            else
            {
                Debug.Log("load dll ok, path is:" + dll_path);
                dllData = ab.LoadAsset<TextAsset>(dllName.ToLower() + ".dll.bytes").bytes;
            }
        }
        else if (Application.platform == RuntimePlatform.WindowsEditor)
        {

            dll_path = Application.dataPath + "/Art/Out/GameDll/" + dllName.ToLower() + ".dll.bytes";
            FileStream fileStream = File.OpenRead(dll_path);
            if (fileStream != null && fileStream.Length > 0)
            {
                byte[] byteData = new byte[fileStream.Length];
                fileStream.Read(byteData, 0, (int)fileStream.Length);
                fileStream.Close();
                dllData = byteData;
                Debug.Log(dllName.ToLower() + " 版本：包内版本, path:" + dll_path);
            }
        }
        else if (Application.platform == RuntimePlatform.WindowsPlayer)
        {
            string outer_path = Application.persistentDataPath;
            outer_path = outer_path.Trim();
            if (!outer_path.EndsWith("/"))
            {
                outer_path.Insert(outer_path.Length, "/");
            }
            dll_path = outer_path + "windows/codeconfig/gamedll/" + dllName.ToLower() + ".dll.bytes"+ LCL.MonoTool.GetAssetbundleSuffix();
            //从手动指定的路径查找
            if (!File.Exists(dll_path))
            {
                dll_path = Application.dataPath + "/StreamingAssets/windows/codeconfig/gamedll/" + dllName.ToLower() + ".dll.bytes"+ LCL.MonoTool.GetAssetbundleSuffix();
            }
            AssetBundle ab = AssetBundle.LoadFromFile(dll_path);
            if (ab == null)
            {
                Debug.LogError("load dll failed ,path is:" + dll_path);
            }
            else
            {
                Debug.Log("load dll ok, path is:" + dll_path);
                dllData = ab.LoadAsset<TextAsset>(dllName.ToLower() + ".dll.bytes").bytes;
            }
        }
        if (dllData == null)
        {
            Debug.LogError(dllName.ToLower() + " can not find !");
            return false;
        }

        byte[] pdbData = null;
        if (Application.platform == RuntimePlatform.WindowsEditor)
        {

            FileStream fileStream = File.OpenRead(Application.dataPath + "/Art/Out/GameDll/" + dllName.ToLower() + ".dll.pdb");
            if (fileStream != null && fileStream.Length > 0)
            {
                byte[] byteData = new byte[fileStream.Length];
                fileStream.Read(byteData, 0, (int)fileStream.Length);
                fileStream.Close();
                pdbData = byteData;
            }

        }
        if (dllData != null)
        {

            if (m_Assembly == null)
            {
                m_Assembly = new CSHotFix.Runtime.Enviorment.AppDomain();
            }

            if (pdbData != null)
            {

                using (System.IO.MemoryStream fs = new MemoryStream(dllData))
                {
                    using (System.IO.MemoryStream p = new MemoryStream(pdbData))
                    {
                        m_Assembly.LoadAssembly(fs, p, new Mono.Cecil.Pdb.PdbReaderProvider());
                    }
                }

            }
            else
            {

                using (System.IO.MemoryStream fs = new MemoryStream(dllData))
                {
                    m_Assembly.LoadAssembly(fs);
                }
            }
        }
        return true;
    }

    public void Destroy()
    {
        m_HotFixDll.OnDestroy();
    }
    public void Update()
    {
        m_HotFixDll.Update();
    }
    public void OnApplicationQuit()
    {
        m_HotFixDll.OnApplicationQuit();
    }
    public object OnMono2GameDll(string func, params object[] data)
    {
        return m_HotFixDll.OnMono2GameDll(func, data);
    }
}





public class HotFixManager_SystemDll
{
    //先尝试加载sdcard的dll，没有的话，再加载内部的
    private Assembly m_Assembly = null;
    private IGameHotFixInterface m_HotFixDll = null;

    //区分多个dll，用于加载类似子游戏的
    public void Init(string dllName)
    {
        if (!Load(dllName))
        {
            UnityEngine.Debug.LogError("script dll load err");
            return;
        }
        //HotFix.HotFixLoop
        string HotFixLoop = dllName + ".HotFixLoop";
        m_HotFixDll = (IGameHotFixInterface)m_Assembly.CreateInstance(HotFixLoop);
        m_HotFixDll.Start();
    }
    public bool Load(string dllName)
    {
        byte[] dllData = null;
        string dll_path = "";
        if (Application.platform == RuntimePlatform.Android)
        {
            //先尝试有平台方指定的目录或者平台默认的sdcard目录
            string outer_path = Application.persistentDataPath;
            outer_path = outer_path.Trim();
            if (!outer_path.EndsWith("/"))
            {
                outer_path.Insert(outer_path.Length, "/");
            }
            dll_path = outer_path + "android/codeconfig/gamedll/" + dllName.ToLower() + ".dll.bytes" + LCL.MonoTool.GetAssetbundleSuffix();
            //从手动指定的路径查找
            if (!File.Exists(dll_path))
            {
                dll_path = Application.dataPath + "!assets/android/codeconfig/gamedll/" + dllName.ToLower() + ".dll.bytes" + LCL.MonoTool.GetAssetbundleSuffix();
            }
            AssetBundle ab = AssetBundle.LoadFromFile(dll_path);
            if (ab == null)
            {
                Debug.LogError("load dll failed ,path is:" + dll_path);
            }
            else
            {
                Debug.Log("load dll ok, path is:" + dll_path);
                dllData = ab.LoadAsset<TextAsset>(dllName.ToLower() + ".dll.bytes").bytes;
            }

        }
        else if (Application.platform == RuntimePlatform.WindowsEditor)
        {

            dll_path = Application.dataPath + "/Art/Out/GameDll/" + dllName.ToLower() + ".dll.bytes";
            FileStream fileStream = File.OpenRead(dll_path);
            if (fileStream != null && fileStream.Length > 0)
            {
                byte[] byteData = new byte[fileStream.Length];
                fileStream.Read(byteData, 0, (int)fileStream.Length);
                fileStream.Close();
                dllData = byteData;
                Debug.Log(dllName.ToLower() + " 版本：原始版本");
            }

        }
        else if (Application.platform == RuntimePlatform.WindowsPlayer)
        {
            string outer_path = Application.persistentDataPath;
            outer_path = outer_path.Trim();
            if (!outer_path.EndsWith("/"))
            {
                outer_path.Insert(outer_path.Length, "/");
            }
            dll_path = outer_path + "windows/codeconfig/gamedll/" + dllName.ToLower() + ".dll.bytes" + LCL.MonoTool.GetAssetbundleSuffix();
            //从手动指定的路径查找
            if (!File.Exists(dll_path))
            {
                dll_path = Application.dataPath + "/StreamingAssets/windows/codeconfig/gamedll/" + dllName.ToLower() + ".dll.bytes" + LCL.MonoTool.GetAssetbundleSuffix();
            }
            AssetBundle ab = AssetBundle.LoadFromFile(dll_path);
            if (ab == null)
            {
                Debug.LogError("load dll failed ,path is:" + dll_path);
            }
            else
            {
                Debug.Log("load dll ok, path is:" + dll_path);
                dllData = ab.LoadAsset<TextAsset>(dllName.ToLower() + ".dll.bytes").bytes;
            }
        }
        if (dllData == null)
        {
            Debug.LogError(dllName.ToLower() + " can not find !");
            return false;
        }

        byte[] pdbData = null;
        if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            FileStream fileStream = File.OpenRead(Application.dataPath + "/Art/Out/GameDll/" + dllName.ToLower() + ".dll.mdb");
            if (fileStream != null && fileStream.Length > 0)
            {
                byte[] byteData = new byte[fileStream.Length];
                fileStream.Read(byteData, 0, (int)fileStream.Length);
                fileStream.Close();
                pdbData = byteData;
            }

        }
        if (dllData != null)
        {
            if (pdbData != null)
            {
                m_Assembly = Assembly.Load(dllData, pdbData);
            }
            else
            {
                m_Assembly = Assembly.Load(dllData);
            }
        }
        return true;
    }
    public void Destroy()
    {
        m_HotFixDll.OnDestroy();
    }
    public void Update()
    {
        m_HotFixDll.Update();
    }
    public void OnApplicationQuit()
    {
        m_HotFixDll.OnApplicationQuit();
    }
    public object OnMono2GameDll(string func, params object[] data)
    {
        return m_HotFixDll.OnMono2GameDll(func, data);
    }

    public static void InitScript(object obj)
    {

    }

}