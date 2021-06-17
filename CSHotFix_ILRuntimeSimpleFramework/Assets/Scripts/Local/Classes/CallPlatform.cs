using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;

namespace LCL
{
    public static class CallPlatform
    {
#if UNITY_IPHONE
        //http://blog.csdn.net/hey_zng/article/details/50989083
        [DllImport("__Internal")]
        private static extern string LIOSClass_CallPlatform(string methodName, string strData);
#elif UNITY_ANDROID
		
#elif UNITY_EDITOR

#endif
        public static string callFunc(string methodName, string strData)
        {
            string strResult = "";
#if UNITY_ANDROID
            if (Application.platform == RuntimePlatform.Android)
            {
                //调用AndroidJavaObject，生成一个Android端com.chunlinge.test.AndroidClass类实例
                try
                {
                    AndroidJavaObject jo = new AndroidJavaObject("com.chunlinge.mygame.LAndroidClass");
                    if (jo != null)
                    {
                        //调用该类的一个方法
                        if (strData != null)
                            strResult = jo.CallStatic<string>(methodName, new System.Object[1] { strData });
                        else
                            strResult = jo.CallStatic<string>(methodName);
                        jo = null;
                    }
                    else
                    {
                        Debug.LogWarning("没有找到平台代码");
                    }
                }
                catch (Exception e)
                {
                    Debug.LogWarning("没有找到com.chunlinge.test.LAndroidClass，注意可能是android平台代码没有，但是这几乎不影响游戏，测试期间不会用到该代码" + e.StackTrace);
                }
            }
            else
            {
                strResult = LWindowsClass.CallPlatform(methodName, strData);
            }
#elif UNITY_IPHONE
            try
            {
                if (Application.platform == RuntimePlatform.IPhonePlayer)
                {
                    strResult = LIOSClass_CallPlatform(methodName, strData);
                }
                else
                {
                    strResult = LWindowsClass.CallPlatform(methodName, strData);
                }
            }
            catch (Exception e)
            {
                Debug.LogWarning(e.Message + e.StackTrace);
            }

#else
        strResult = LWindowsClass.CallPlatform(methodName, strData);
#endif


            if (strResult == null)
            {
                strResult = "";
            }
            return strResult;
        }
    }
}