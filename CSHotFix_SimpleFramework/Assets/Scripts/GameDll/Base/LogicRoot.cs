using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using System.IO;
namespace GameDll
{
    //处理游戏各种数据和帮助
    public static class LogicRoot
    {
        public static bool m_bUsePBNet = true;
        public static int m_nLoginScene = 999;
        //public static bool m_bUseDatabase = true;
        public static int m_GameFrameRate = -1;
        public static ThreadPriority m_LoadThreadPriority = ThreadPriority.Normal;
        //渲染逻辑的时间差（秒）
        private static float m_fTimeSinceLastFrame = 0;
        public static float TimeSinceLastFrame
        {
            get
            {
                return m_fTimeSinceLastFrame;
            }
            set
            {
                m_fTimeSinceLastFrame = value;
            }
        }
        public static Vector2 m_ScreenDesignSize = new Vector2(960, 640);
        public static bool m_bResCache = false;
        public static bool m_bIsDebugMode = true;
        public static float m_fTimeDelay = 0.0f;
        public static StreamReader getStream(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            if (fs==null)
            {
                return null;
            }
            StreamReader sr = new StreamReader(fs);
            return sr;
        }
        public static StreamReader getStream(byte[] byte_data)
        {
            if (byte_data!=null&&byte_data.Length>0)
            {
                MemoryStream memStream = new MemoryStream(byte_data);
                return new StreamReader(memStream);
            }
            return null;
        }
        public static string getLanguage()
        {
            return "CN";
        }
        public static string getURLNameNoExt(string url)
        {
            return System.IO.Path.GetFileNameWithoutExtension(url);
        }
        public static string getURLName(string url)
        {
            return System.IO.Path.GetFileName(url);
        }
        public static string getURLExt(string url)
        {
            return System.IO.Path.GetExtension(url);
        }
        public static string getURLDir(string url)
        {
            return System.IO.Path.GetDirectoryName(url);
        }
        public static void ShowDebugInfo(bool bShow)
        {
            //DebugHelper.m_bShow = bShow;
        }
        public static string GetPlatformName()
        {
            return GetPlatformForAssetBundles(Application.platform);
        }
        private static string GetPlatformForAssetBundles(RuntimePlatform platform)
        {
            switch (platform)
            {
                case RuntimePlatform.Android:
                    return "Android";
                case RuntimePlatform.IPhonePlayer:
                    return "iOS";
                case RuntimePlatform.WindowsPlayer:
                    return "Android";
                case RuntimePlatform.OSXPlayer:
                    return "iOS";
                // Add more build targets for your own.
                default:
                    return "Android";
            }
        }
        private static GameObject _GameMain = null;
        public static GameObject GameMain
        {
            get
            {
                if (_GameMain == null)
                {
                    _GameMain = GameObject.FindGameObjectWithTag("GameMain");
                    GameObject.DontDestroyOnLoad(_GameMain);
                }
                return _GameMain;
            }
        }
        private static Setting m_Setting = null;
        //public static float m_SecondPerGameFrame;
        public static Setting GetSetting()
        {
            if (m_Setting == null)
            {
                m_Setting = GameMain.GetComponent<Setting>();
            }
            return m_Setting;
        }
        public static void SetLoadThreadPriority(ThreadPriority priority)
        {
            m_LoadThreadPriority = priority;
            Application.backgroundLoadingPriority = priority;
        }
        public static ThreadPriority GetLoadThreadPriority()
        {
            return m_LoadThreadPriority;
        }
    }
}
