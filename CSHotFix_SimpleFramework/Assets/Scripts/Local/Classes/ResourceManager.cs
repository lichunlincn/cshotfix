using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
namespace LCL
{
    public class ABObject : PooledClassObject
    {
        public List<UnityEngine.Object> m_UObjectList = new List<UnityEngine.Object>();
        public long m_Id = ResourceManager.IdNone;
        public override void New(object param)
        {
            m_Id = ResourceManager.IdNone;
        }
        public override void DestroyClass()
        {
            //这里需要清理m_UObjectList，否则会有资源泄漏
            m_UObjectList.Clear();
            PooledClassManager<ABObject>.DeleteClass(this);
        }
    }
    public class ResourceManager
    {
        public const long IdNone = 0;
        private static ResourceManagerMono m_ResMgr;
        public static void Initialize(System.Action initOK)
        {
            GameObject main = GameObject.FindGameObjectWithTag("GameMain");
            m_ResMgr = main.GetComponent<ResourceManagerMono>();
            if (m_ResMgr == null)
            {
                Debug.LogError("ResourceManagerMono 没有找到");
                return;
            }
            m_ResMgr.Initialize(initOK);
        }
        public static long LoadPrefab(Type t, string abName, string assetName, Action< ABObject> func)
        {
            return m_ResMgr.LoadPrefab(t, abName, assetName, func);
        }
        //同步
        public static ABObject LoadPrefab(Type t, string abName, string assetName)
        {
            return m_ResMgr.LoadPrefab(t, abName, assetName);
        }
        public static long LoadPrefab(Type t, string abName, string[] assetNames, Action<ABObject> func)
        {
            return m_ResMgr.LoadPrefab(t, abName, assetNames, func);
        }
        public static ABObject LoadPrefab(Type t, string abName, string[] assetName)
        {
            return m_ResMgr.LoadPrefab(t, abName, assetName);
        }
        public static long LoadLevel(string abName, string assetName, int mode, System.Action func)
        {
            return m_ResMgr.LoadLevel(abName, assetName, mode, func);
        }
        public static void ActiveLevel(string level)
        {
            m_ResMgr.ActiveLevel(level);
        }
        public static void UnloadPrefab(long id)
        {
            m_ResMgr.UnloadPrefab(id);
        }
        public static void UnloadLevel(long id)
        {
            m_ResMgr.UnloadLevel(id);
        }
        public static void LoadBytes(string abName, string assetName, Action<byte[]> func)
        {
            m_ResMgr.LoadBytes(abName, assetName, func);
        }
        public static byte[] LoadBytes(string resName)
        {
            return ResourceManagerMono.LoadBytes(resName);
        }

        public static string GetDataPath()
        {
            return ResourceManagerMono.GetDataPath();
        }
        public static string makeFullPath(string strFileName)
        {
            return ResourceManagerMono.makeFullPath(strFileName);
        }

        public static void UnloadUnusedAssets()
        {
            m_ResMgr.UnloadUnusedAssets();
        }
    }
}