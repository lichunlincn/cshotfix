using UnityEngine;
using System.Collections;
using LCL;
using System.IO;
using System;

public class Main : MonoBehaviour 
{
	public static  IGameInterface m_Game=null;

    public bool m_EnableLog =false;
    public bool m_CheckUnBoundClass = true;
    public bool m_UseCSHotFixDll = true;
    public bool m_FixBug = true;
    public bool m_PingGuoPreviewVersion = false;
    public bool m_EditorManualDebugConfig = false;
    // Use this for initialization
    void Start () 
	{
        //进入到游戏逻辑
        Debug.Log("进入游戏逻辑");
        if(!m_EditorManualDebugConfig)
        {
            LoadDebugConfig();
        }
        else
        {
            Debug.LogWarning("跳过了调试配置，将会使用Inspector的默认配置");
        }

        CallPlatform.callFunc("Push", "hello");
        //加载逻辑组件
        if (m_Game==null)
        {
            bool ok=InitLogicPlugin();
            if (!ok)
            {
                Debug.LogError("InitLogicPlugin failed");
                return;
            }
               
        }
        Debug.LogWarning("改变系统日志开关：" + m_EnableLog);
        Debug.unityLogger.logEnabled = m_EnableLog;

        if (m_Game != null)
        {
            m_Game.Start();
        }
	}
    #region 调试信息代码
    private string m_DebugConfigPath = "";
    private string DebugConfigPath
    {
        get
        {
            if(string.IsNullOrEmpty(m_DebugConfigPath))
            {
#if UNITY_EDITOR
                m_DebugConfigPath = Application.streamingAssetsPath + "/debug_config.json";
#else
                m_DebugConfigPath = Application.persistentDataPath + "/debug_config.json";        
#endif
            }
            return m_DebugConfigPath;
        }
    }
    public void LoadDebugConfig()
    {
        if(!File.Exists(DebugConfigPath))
        {
            return;
        }
        else
        {
            FileStream fs = null;
            BinaryReader br = null;
            try
            {
                fs = new FileStream(DebugConfigPath, FileMode.Open);
                br = new BinaryReader(fs);

                m_EnableLog = br.ReadBoolean();
                m_CheckUnBoundClass = br.ReadBoolean();
                m_UseCSHotFixDll = br.ReadBoolean();
                m_FixBug = br.ReadBoolean();
                m_PingGuoPreviewVersion = br.ReadBoolean();
                if (m_PingGuoPreviewVersion == false)
                {
                    Debug.LogWarning("是否显示Log：" + m_EnableLog);
                    Debug.LogWarning("是否检测边界：" + m_CheckUnBoundClass);
                    Debug.LogWarning("是否使用CSHotFix："+m_UseCSHotFixDll);
                    Debug.LogWarning("是否修复错误：" + m_FixBug);
                }
                
            }
            catch(Exception e)
            {
                Debug.LogError(e.Message);
            }
            finally
            {
                if(br!= null)
                {
                    br.Close();
                    br = null;
                }
                if(fs != null)
                {
                    fs.Close();
                    fs = null;
                }
            }
        }

    }
    public void CreateDebugConfig()
    {
        FileStream fs = null;
        BinaryWriter bw = null;
        try
        {
            fs = new FileStream(DebugConfigPath, FileMode.Create);
            bw = new BinaryWriter(fs);

            bw.Write(m_EnableLog);
            bw.Write(m_CheckUnBoundClass);
            bw.Write(m_UseCSHotFixDll);
            bw.Write(m_FixBug);
            bw.Write(m_PingGuoPreviewVersion);
        }
        catch(Exception e)
        {
            Debug.LogError(e.Message);
        }
        finally
        {
            if(bw != null)
            {
                bw.Close();
                bw = null;
            }
            if(fs != null)
            {
                fs.Close();
                fs = null;
            }
        }
    }
    #endregion
    void FixedUpdate()
    {
        if (m_Game != null)
        {
            m_Game.FixedUpdate();
        }
        
    }

	// Update is called once per frame
	void Update () 
	{
		if(m_Game!=null)
		{
			bool hr=m_Game.Update();
			if(!hr)
			{
                Exit();
                Debug.Log("bool hr=m_Game.MainLoop() return false----normal Exit success");
			}
		}
	}
    void LateUpdate()
    {
        if (m_Game != null)
        {
            m_Game.LateUpdate();
        }
        
    }
    void OnGUI()
    {
        if (m_Game != null)
        {
            m_Game.OnGUI();
        }
    }
    void OnApplicationPause()
    {
        if (m_Game != null)
        {
            m_Game.OnApplicationPause() ;
        }
    }

    public object OnMono2GameDll(string func, object data = null)
    {
        if (m_Game != null)
        {
            return m_Game.OnMono2GameDll(func,data);
        }
        return null;
    }

    void OnDestroy()
    {
        if (m_Game != null)
        {
            m_Game.OnDestroy();
        }
        Debug.Log("Ondestroy");
    }
    void OnApplicationQuit()
    {
        if (m_Game != null)
        {
            m_Game.OnApplicationQuit();
        }
        Debug.Log("OnApplicationQuit");
    }
    //接受来自平台的消息
	void PlatfomMessgae(string str)
	{
        if (m_Game != null)
        {
            m_Game.OnPlatformMessage(str);
        }
	}
    private bool InitLogicPlugin()
    {
        bool hr = true;
        m_Game = new LogicMain();
        if (m_Game == null)
        {
            Debug.LogError("GameDll load fail");
            hr = false;
            Exit();
        }
        return hr;
    }
    private void Exit()
    {
        gameObject.SetActive(false);
        GameObject.DestroyImmediate(gameObject);
    }
}
