using UnityEngine;
using System.Collections;
using System.IO;
using System.Reflection;

public class LoadGameDll:MonoBehaviour
{
    //先尝试加载sdcard的dll，没有的话，再加载内部的
	internal static Assembly m_Assembly=null;
    internal static bool m_EditorUseAssetbundleDll = false;
	public static bool Load()
	{
		if(m_Assembly!=null)
			return true;
        byte[] dllData = null;
        string dll_path = "";
        if (Application.platform==RuntimePlatform.Android)
        {
            //先尝试有平台方指定的目录或者平台默认的sdcard目录
            string outer_path = Application.persistentDataPath;
            outer_path=outer_path.Trim();
            if (!outer_path.EndsWith("/"))
            {
                outer_path= outer_path + "/";
            }
            dll_path = outer_path + "android/codeconfig/gamedll/gamedll.dll.bytes";
            //从手动指定的路径查找
            if (!File.Exists(dll_path))
            {
                dll_path = Application.dataPath + "!assets/android/codeconfig/gamedll/gamedll.dll.bytes";
            }
            AssetBundle ab = AssetBundle.LoadFromFile(dll_path);
            if (ab == null)
            {
                Debug.LogError("load dll failed ,path is:" + dll_path);
            }
            else
            {
                Debug.Log("load dll ok, path is:" + dll_path);
                dllData = ab.LoadAsset<TextAsset>("gamedll.dll.bytes").bytes;
            }
 
        }
        else if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            if (m_EditorUseAssetbundleDll)
            {
                dll_path = Application.dataPath + "/../../../../build/StreamingAssets/android/codeconfig/gamedll/gamedll.dll.bytes";
                AssetBundle ab = AssetBundle.LoadFromFile(dll_path);
                TextAsset ta = ab.LoadAsset<TextAsset>("gamedll.dll.bytes");
                if (ta != null)
                {
                    dllData = ta.bytes;
                    Debug.Log("GameDll 版本：打包版本");
                }


            }
            else
            {
                dll_path = Application.dataPath + "/Art/Out/GameDll/GameDll.dll.bytes";
                FileStream fileStream = File.OpenRead(dll_path);
                if (fileStream != null && fileStream.Length > 0)
                {
                    byte[] byteData = new byte[fileStream.Length];
                    fileStream.Read(byteData, 0, (int)fileStream.Length);
                    fileStream.Close();
                    dllData = byteData;
                    Debug.Log("GameDll 版本：原始版本");
                }
            }
        }
        else if (Application.platform == RuntimePlatform.WindowsPlayer)
        {
            string outer_path = Application.persistentDataPath;
            outer_path = outer_path.Trim();
            if (!outer_path.EndsWith("/"))
            {
                outer_path = outer_path + "/";
            }
            dll_path = outer_path + "windows/codeconfig/gamedll/gamedll.dll.bytes";
            //从手动指定的路径查找
            if (!File.Exists(dll_path))
            {
                dll_path = Application.dataPath + "/StreamingAssets/windows/codeconfig/gamedll/gamedll.dll.bytes";
            }
            AssetBundle ab = AssetBundle.LoadFromFile(dll_path);
            if (ab == null)
            {
                Debug.LogError("load dll failed ,path is:" + dll_path);
            }
            else
            {
                Debug.Log("load dll ok, path is:" + dll_path);
                dllData = ab.LoadAsset<TextAsset>("gamedll.dll.bytes").bytes;
            }
        }
        if (dllData==null)
        {
            Debug.LogError("GameDll can not find !");
            return false;
        }
        
		byte[] pdbData=null;
        if (Application.platform==RuntimePlatform.WindowsEditor)
        {
            FileStream fileStream = File.OpenRead(Application.dataPath + "/Art/Out/GameDll/GameDll.dll.mdb");
            if (fileStream != null && fileStream.Length > 0)
            {
                byte[] byteData = new byte[fileStream.Length];
                fileStream.Read(byteData, 0, (int)fileStream.Length);
                fileStream.Close();
                pdbData = byteData;
            }
        }
		if(dllData!=null)
		{
			if(pdbData!=null)
			{
				m_Assembly = Assembly.Load(dllData,pdbData);
			}
			else
			{
				m_Assembly=Assembly.Load(dllData);
			}
		}
		return true;
	}
	
}

