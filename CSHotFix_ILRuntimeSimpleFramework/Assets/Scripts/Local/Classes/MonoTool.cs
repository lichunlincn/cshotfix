using UnityEngine;
using System.Collections;
using System;
using System.Text;
using LITJson;
using System.Collections.Generic;

namespace LCL
{
    public class MonoTool
    {
        public static string GetRuntimePlatformName()
        {
            switch (Application.platform)
            {
                case RuntimePlatform.Android:
                    return "android";
                case RuntimePlatform.IPhonePlayer:
                    return "ios";
                case RuntimePlatform.WindowsPlayer:
                    return "windows";
                case RuntimePlatform.WindowsEditor:
#if UNITY_ANDROID
                    return "android";
#else
                    return "windows";
#endif
                case RuntimePlatform.OSXPlayer:
                    return "mac";
                // Add more build targets for your own.
                default:
                    return "android";
            }
        }

        public static float GetInputAxisX()
        {
            return 0;
        }
        public static float GetInputAxisY()
        {
            return 0;
        }
        public static void SetMoveBase(bool canMove)
        {
            //CnControls.SimpleJoystick joyStick = GameObject.FindObjectOfType<CnControls.SimpleJoystick>();
            //if (joyStick != null)
            //{
            //    joyStick.MoveBase = canMove;
            //}
        }
        public static Component AddComponent(Component go, Type t)
        {
            if (go != null)
            {
                return go.gameObject.AddComponent(t);
            }
            else
            {
                return null;
            }
        }

        public static bool isLoadAssetBundleManifest { get; set; }
        public static JsonData LoadJson(string jsonPath)
        {
            string fullJsonPath = ResourceManager.makeFullPath(jsonPath);
            byte[] data = ResourceManager.LoadBytes(fullJsonPath);
            string str = System.Text.Encoding.UTF8.GetString(data);
            JsonData json = JsonMapper.ToObject(str);
            return json;
        }
        public static JsonData SetJson(TextAsset data)
        {
            string str = System.Text.Encoding.UTF8.GetString(data.bytes);
            JsonData json = JsonMapper.ToObject(str);
            return json;
        }

        /// <summary> 
        /// 获取时间戳 
        /// </summary> 
        /// <returns></returns> 
        public static long GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds);
        }
        // 时间戳转为C#格式时间
        public static DateTime StampToDateTime(long lTime)
        {
            DateTime dateTimeStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            TimeSpan toNow = new TimeSpan(lTime);
            return dateTimeStart.Add(toNow);
        }
        // DateTime时间格式转换为Unix时间戳格式
        public static long DateTimeToStamp(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (long)(time - startTime).TotalMilliseconds;
        }

        public static string GeDataPathHeader()
        {
            string downPath = null;
            if (Application.platform == RuntimePlatform.Android)
            {
                downPath = "jar:file://";
            }
            else if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                downPath = "file://";
            }
            else if (Application.platform == RuntimePlatform.WindowsEditor)
            {
#if UNITY_ANDROID
                downPath = "";
#else
                downPath = "";
#endif
            }
            return downPath;
        }
        public static string GetWWWDataPathHeader()
        {
            string downPath = null;
            if (Application.platform == RuntimePlatform.Android)
            {
                downPath = "jar:file://";
            }
            else if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                downPath = "file://";
            }
            else if (Application.platform == RuntimePlatform.WindowsEditor)
            {
#if UNITY_ANDROID
                downPath = "file://";
#else
                downPath = "file://";
#endif
            }
            else if(Application.platform == RuntimePlatform.WindowsPlayer)
            {
                downPath = "file://";
            }
            return downPath;
        }
        public static string GetDataPath()
        {
            string downPath = null;
            if (Application.platform == RuntimePlatform.Android)
            {
                downPath = Application.dataPath + "!/assets/android/";

            }
            else if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                downPath = Application.dataPath + "/Raw/ios/";
            }
            else if (Application.platform == RuntimePlatform.WindowsEditor)
            {
#if UNITY_ANDROID
                downPath = Application.dataPath + "/../build/StreamingAssets/android/";
#else
                downPath = Application.dataPath + "/../build/StreamingAssets/windows/";
#endif

            }
            else if (Application.platform == RuntimePlatform.WindowsPlayer)
            {
                downPath = Application.dataPath + "/StreamingAssets/windows/";
            }
            return downPath;
        }
        public static string GetPersistentPath()
        {
            string persistentPath = "";
            if (Application.platform == RuntimePlatform.Android)
            {
                persistentPath = Application.persistentDataPath + "/android/";
            }
            else if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                persistentPath = Application.persistentDataPath + "/Raw/ios/";
            }
            else if (Application.platform == RuntimePlatform.WindowsEditor)
            {
                //这里有一个调试模式，需要在电脑上面看下android的一些东西。
#if UNITY_ANDROID
                persistentPath = Application.persistentDataPath + "/android/";
#else
                persistentPath = Application.persistentDataPath + "/windows/";
#endif
            }
            else if (Application.platform == RuntimePlatform.WindowsPlayer)
            {
                persistentPath = Application.persistentDataPath + "/windows/";
            }
            else
            {
            }
            return persistentPath;
        }

        public static void SetLayer(GameObject gameObjectRoot, bool withChildren, string layerName)
        {
            int layer = LayerMask.NameToLayer(layerName);
            gameObjectRoot.layer = layer;
            if(withChildren)
            {
                var children = gameObjectRoot.GetComponentsInChildren<Transform>();
                int count = children.Length;
                for(int i=0;i<count;++i)
                {
                    children[i].gameObject.layer = layer;
                }
            }
        }
        private static string m_lcl_www_lcl_flag = "lcl_www_lcl";
        public static string GetBackDownloadFlag()
        {
            return m_lcl_www_lcl_flag;
        }
        private static string m_BackDownloadName = "downloadfilelist.json";
        public static string GetBackDownloadFileName()
        {
            return m_BackDownloadName;
        }

        private static string m_AssetbundleSuffix = ".jpg";
        public static string GetAssetbundleSuffix()
        {
            return m_AssetbundleSuffix;
        }
    }
}