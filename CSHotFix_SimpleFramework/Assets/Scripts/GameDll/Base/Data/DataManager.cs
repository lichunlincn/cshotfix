
using System;
using System.IO;
using UnityEngine;
namespace GameDll
{
    public class DataManager
    {


        //private static SQLiteHelper m_SQL = null;
        //public static void Init()
        //{
        //    string path = "";
        //    if (Application.platform == RuntimePlatform.Android)
        //    {
        //        path = Application.persistentDataPath + "/android/codeconfig/config/config.sqlitedb" + LCL.MonoTool.GetAssetbundleSuffix();
        //    }
        //    else if (Application.platform == RuntimePlatform.IPhonePlayer)
        //    {
        //        path = Application.persistentDataPath + "/Raw/ios/codeconfig/config/config.sqlitedb"+ LCL.MonoTool.GetAssetbundleSuffix();
        //    }
        //    else if (Application.platform == RuntimePlatform.WindowsEditor)
        //    {
        //        path = Application.dataPath + "/Art/Out/config/config.sqlitedb";
        //    }
        //    else if (Application.platform == RuntimePlatform.WindowsPlayer)
        //    {
        //        path = Application.persistentDataPath + "/windows/codeconfig/config/config.sqlitedb"+ LCL.MonoTool.GetAssetbundleSuffix();
        //    }

        //    try
        //    {
        //        UnityEngine.Debug.Log("sqlite path is:" + path.ToLower());
        //        m_SQL = new SQLiteHelper(path.ToLower());
        //        UnityEngine.Debug.Log("Init database ok");
        //    }
        //    catch (Exception e)
        //    {
        //        UnityEngine.Debug.LogError("初始化数据库失败，原因是：" + e.Message + e.StackTrace);
        //        return;
        //    }
        //}



        //public static void Destroy()
        //{
        //    if (m_SQL != null)
        //    {
        //        m_SQL.CloseConnection();
        //        m_SQL = null;
        //        UnityEngine.Debug.Log("数据库关闭成功");
        //    }
        //}

        public static bool BeginRead(string queryString)
        {
            return true;
        }
        public static int ReadInt()
        {
            return 0;
        }
        public static long ReadLong()
        {
            return 0;
        }
        public static string ReadString()
        {
            return "";
        }
        public static float ReadFloat()
        {
            return 0;
        }
        public static byte[] ReadBytes()
        {
            return new byte[10];
        }
        public static void EndRead()
        {
            //m_SQL.EndRead();
        }

    }
}