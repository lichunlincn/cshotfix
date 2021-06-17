using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using LCL;

public class ResourceManagerMono : MonoBehaviour
{
    public class AssetBundleInfo
    {
        public AssetBundle m_AssetBundle;
        public int m_ReferencedCount;
        public float m_DiscardTime = 0;

        public AssetBundleInfo(AssetBundle bundle)
        {
            m_AssetBundle = bundle;
            m_ReferencedCount = 0;
        }
    }
    AssetBundleManifest m_AssetBundleManifest = null;
    Dictionary<string, string[]> m_Dependencies = new Dictionary<string, string[]>();
    Dictionary<string, AssetBundleInfo> m_LoadedAssetBundles = new Dictionary<string, AssetBundleInfo>();
    Dictionary<long, string> m_LoadedIdABName = new Dictionary<long, string>();
    List<long> m_UnloadedIdABName = new List<long>();
    //注意这里无法嵌套，等android测试通过了要修改
    Dictionary<string, List<LoadAssetRequest>> m_LoadRequests = new Dictionary<string, List<LoadAssetRequest>>();
    float m_fLastGCTime = 0;
    float m_fGCInternal = 10;
    //异步加载的资源id
    long m_AsyncLoadIndex = 0;
    //同步加载的资源id
    long m_SyncLoadIndex = 0;
    long m_CallBackIndex = 1;
    //加载完的回调列表
    List<LoadAssetRequest> m_CallBackList = new List<LoadAssetRequest>();
    //private float m_fLastFrameTime = 0;
    //private System.Diagnostics.Stopwatch m_StopWatch = new System.Diagnostics.Stopwatch();
    class LoadAssetRequest
    {
        public Type assetType;
        public string[] assetNames;
        public Action<ABObject> sharpFunc;
        public System.Action levelSharpFunc;
        public long LoadIndex = -1;
        public bool Error = false;
        public ABObject ObjList;
    }
    public void Initialize(System.Action initOK)
    {
        string manifestName = MonoTool.GetRuntimePlatformName() + MonoTool.GetAssetbundleSuffix();
        m_fLastGCTime = Time.realtimeSinceStartup;
        //注意这里的 "AssetBundleManifest" 参数是和bundle文件的主bundle的manifest文件里面的AssetBundleManifest对应的，不能随意修改
        LoadAsset(typeof(AssetBundleManifest), manifestName, new string[] { "AssetBundleManifest" },
        (ABObject objs) =>
        {
            if (objs.m_UObjectList.Count > 0)
            {
                m_AssetBundleManifest = objs.m_UObjectList[0] as AssetBundleManifest;
            }
            if (initOK != null)
                initOK();
        });
    }
    public long LoadPrefab(Type t, string abName, string assetName, Action<ABObject> func)
    {
        abName = abName.ToLower();
        return LoadAsset(t, abName, new string[] { assetName }, func);
    }
    //同步
    public ABObject LoadPrefab(Type t, string abName, string assetName)
    {
        abName = abName.ToLower();
        ABObject list = LoadAsset(t, abName, new string[] { assetName });
        if (list != null)
        {
            return list;
        }
        else
        {
            return null;
        }
    }
    public long LoadPrefab(Type t, string abName, string[] assetNames, Action<ABObject> func)
    {
        abName = abName.ToLower();
        return LoadAsset(t, abName, assetNames, func);
    }
    public ABObject LoadPrefab(Type t, string abName, string[] assetName)
    {
        abName = abName.ToLower();
        return LoadAsset(t, abName, assetName);
    }
    public long LoadLevel(string abName, string assetName, int mode, System.Action func)
    {
        abName = abName.ToLower();
        return LoadLevelAsset(abName, assetName, mode, func);
    }
    long LoadLevelAsset(string abName, string assetName, int mode, System.Action func)
    {
        LoadAssetRequest request = new LoadAssetRequest();
        request.assetType = typeof(UnityEngine.SceneManagement.Scene);
        request.assetNames = new string[] { assetName };
        request.levelSharpFunc = func;
        request.LoadIndex = ++m_AsyncLoadIndex;

        List<LoadAssetRequest> requests = null;
        if (!m_LoadRequests.TryGetValue(abName, out requests))
        {
            requests = new List<LoadAssetRequest>();
            requests.Add(request);
            m_LoadRequests.Add(abName, requests);
            StartCoroutine(OnLoadLevelAsset(abName, mode));
        }
        else
        {
            requests.Add(request);
        }
        return request.LoadIndex;
    }
    public void ActiveLevel(string level)
    {
        UnityEngine.SceneManagement.Scene scene = UnityEngine.SceneManagement.SceneManager.GetSceneByName(level);
        if (scene != null)
        {
            UnityEngine.SceneManagement.SceneManager.SetActiveScene(scene);
        }
    }
    /// <summary>
    /// 载入素材
    /// </summary>
    long LoadAsset(Type t, string abName, string[] assetNames, Action<ABObject> action)
    {
        //Debug.LogWarning("StartLoad Asset :" + abName);
        //abName = makeFullPath(abName);

        LoadAssetRequest request = new LoadAssetRequest();
        request.assetType = t;
        request.assetNames = assetNames;
        request.sharpFunc = action;
        request.LoadIndex = ++m_AsyncLoadIndex;

        List<LoadAssetRequest> requests = null;
        if (!m_LoadRequests.TryGetValue(abName, out requests))
        {
            requests = new List<LoadAssetRequest>();
            requests.Add(request);
            m_LoadRequests.Add(abName, requests);
            StartCoroutine(OnLoadAsset(t, abName));
        }
        else
        {
            requests.Add(request);
        }
        return request.LoadIndex;
    }
    //同步
    ABObject LoadAsset(Type t, string abName, string[] assetNames)
    {
        //abName = makeFullPath(abName);
        ABObject result = new ABObject();
        result.m_Id = --m_SyncLoadIndex;
        AssetBundleInfo abi = GetLoadedAssetBundle(abName);
        if (abi == null)
        {
            abi = OnLoadAssetBundle(abName);
        }
        //已经加载了
        AssetBundle ab = abi.m_AssetBundle;
        abi.m_ReferencedCount++;
        for (int j = 0; j < assetNames.Length; j++)
        {
            string assetPath = assetNames[j];
            UnityEngine.Object obj = ab.LoadAsset(assetPath);
#if UNITY_EDITOR
            if (obj is GameObject)
            {
                RecoveryShader((GameObject)obj);
            }
#endif
            result.m_UObjectList.Add(obj);
        }
        return result;
    }
    //同步
    AssetBundleInfo OnLoadAssetBundle(string abName)
    {
        abName = abName.ToLower();
        string[] dependencies = m_AssetBundleManifest.GetAllDependencies(abName);
        if (dependencies.Length > 0)
        {
            m_Dependencies.Add(abName, dependencies);
            for (int i = 0; i < dependencies.Length; i++)
            {
                string depName = dependencies[i].ToLower();
                AssetBundleInfo bundleInfo = null;
                if (m_LoadedAssetBundles.TryGetValue(depName, out bundleInfo))
                {
                    //依赖已经加载了的
                    bundleInfo.m_ReferencedCount++;
                }
                else
                {
                    //没有加载我们就加载
                    bundleInfo = OnLoadAssetBundle(depName);
                    //对依赖项进行使用
                    bundleInfo.m_ReferencedCount++;
                }
            }
        }
        //加载完毕依赖项就加载自己
        string url = makeFullPath(abName);
        AssetBundleInfo info = new AssetBundleInfo(AssetBundle.LoadFromFile(url));
        m_LoadedAssetBundles.Add(abName, info);
        return info;
    }
    IEnumerator OnLoadLevelAsset(string abName, int mode)
    {
        //为了确保异步，强制添加一个返回
        yield return null;

        AssetBundleInfo bundleInfo = GetLoadedAssetBundle(abName);
        if (bundleInfo == null)
        {
            yield return StartCoroutine(OnLoadLevelAssetBundle(abName));

            bundleInfo = GetLoadedAssetBundle(abName);
            if (bundleInfo == null)
            {
                m_LoadRequests.Remove(abName);
                yield break;
            }
        }
        List<LoadAssetRequest> list = null;
        if (!m_LoadRequests.TryGetValue(abName, out list))
        {
            m_LoadRequests.Remove(abName);
            yield break;
        }


        for (int i = 0; i < list.Count; i++)
        {
            string[] assetNames = list[i].assetNames;
            List<string> result = new List<string>();

            AssetBundle ab = bundleInfo.m_AssetBundle;
            //m_StopWatch.Reset();
            //m_StopWatch.Start();
            for (int j = 0; j < assetNames.Length; j++)
            {
                string assetPath = assetNames[j];
                AsyncOperation oper = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(assetPath, (UnityEngine.SceneManagement.LoadSceneMode) mode );
                yield return oper;
                result.Add(assetPath);
#if UNITY_EDITOR
                //得到level自带的非外部打包的预制件，将他们的shader进行恢复
                GameObject levelRoot = GameObject.Find(assetPath);
                if (levelRoot!=null)
                {
                    RecoveryShader(levelRoot);
                }
#endif
            }
            //m_StopWatch.Stop();
            //Debug.Log("LoadSceneAsync time:" + m_StopWatch.ElapsedMilliseconds);
            m_LoadedIdABName.Add(list[i].LoadIndex, abName);

            if (list[i].levelSharpFunc != null)
            {
                //list[i].levelSharpFunc();
                //list[i].levelSharpFunc = null;
                m_CallBackList.Add(list[i]);
                //m_CallBackList.Sort(OnSortCallList);
            }
            bundleInfo.m_ReferencedCount++;
        }
        m_LoadRequests.Remove(abName);
        string[] Dependencies = null;
        if (m_Dependencies.TryGetValue(abName, out Dependencies))
        {
            foreach (var dependency in Dependencies)
            {
                AssetBundleInfo depABInfo = GetLoadedAssetBundle(dependency);
                depABInfo.m_ReferencedCount++;
                m_LoadRequests.Remove(dependency);
            }
        }
    }
    private bool IsUnloadId(long id)
    {
        int count = m_UnloadedIdABName.Count;
        for (int i = 0; i < count; ++i)
        {
            if (m_UnloadedIdABName[i] == id)
            {
                return true;
            }
        }
        return false;
    }
    private int OnSortCallList(LoadAssetRequest x, LoadAssetRequest y)
    {
        return x.LoadIndex.CompareTo(y.LoadIndex);
    }

    IEnumerator OnLoadAsset(Type t, string abName)
    {
        //为了确保异步，强制添加一个返回
        yield return null;

        List<LoadAssetRequest> list = null;

        AssetBundleInfo bundleInfo = GetLoadedAssetBundle(abName);
        if (bundleInfo == null)
        {
            yield return StartCoroutine(OnLoadAssetBundle(abName, t));

            bundleInfo = GetLoadedAssetBundle(abName);

            if (bundleInfo == null)
            {
                //加载资源失败了
                if (m_LoadRequests.TryGetValue(abName, out list))
                {
                    if(list != null)
                    {
                        int count = list.Count;
                        for(int i =0;i<count;++i)
                        {
                            LoadAssetRequest r = list[i];
                            if(r.sharpFunc!= null)
                            {
                                //r.sharpFunc(null);
                                //r.sharpFunc = null;
                                r.Error = true;
                                r.ObjList = null;
                                m_CallBackList.Add(list[i]);
                                //m_CallBackList.Sort(OnSortCallList);
                            }
                        }
                    }
                    m_LoadRequests.Remove(abName);
                }
                Debug.LogError("OnLoadAsset--->>>" + abName);
                yield break;
            }
        }

        //这个位置的异常处理可能有问题，没有合理通知逻辑层资源有问题。
        if(!m_LoadRequests.TryGetValue(abName, out list))
        {
            yield break;
        }
        else
        {
            if(list == null)
            {
                m_LoadRequests.Remove(abName);
                yield break;
            }
        }
        

        for (int i = 0; i < list.Count; i++)
        {
            string[] assetNames = list[i].assetNames;
            //List<UnityEngine.Object> result = new List<UnityEngine.Object>();
            ABObject result = PooledClassManager<ABObject>.CreateClass();
            AssetBundle ab = bundleInfo.m_AssetBundle;

            for (int j = 0; j < assetNames.Length; j++)
            {
                string assetPath = assetNames[j];

                AssetBundleRequest request = ab.LoadAssetAsync(assetPath, list[i].assetType);
                yield return request;
                UnityEngine.Object obj = request.asset;
#if UNITY_EDITOR
                if (obj is GameObject)
                {
                    RecoveryShader((GameObject)obj);
                }
#endif
                result.m_UObjectList.Add(obj);
            }
            //Debug.Log("OnLoadAsset " + abName);
            bundleInfo.m_ReferencedCount++;
            //处理依赖
            string[] deps = null;
            if (m_Dependencies.TryGetValue(abName, out deps))
            {
                foreach (var dependency in deps)
                {
                    AssetBundleInfo depABInfo = GetLoadedAssetBundle(dependency);
                    depABInfo.m_ReferencedCount++;
                }
            }

            //将加载完成的id和abName绑定
            m_LoadedIdABName.Add(list[i].LoadIndex, abName);
            
                
            //这段代码不能去掉，因为我们的AssetBundleManifest依赖它来回调
            if (list[i].sharpFunc != null)
            {
                //list[i].sharpFunc(result);
                //list[i].sharpFunc = null;
                list[i].ObjList = result;
                m_CallBackList.Add(list[i]);
                //m_CallBackList.Sort(OnSortCallList);

            }

        }

        m_LoadRequests.Remove(abName);

        string[] Dependencies = null;
        if (m_Dependencies.TryGetValue(abName, out Dependencies))
        {
            foreach (var dependency in Dependencies)
            {
                //释放依赖AB
                //AssetBundleInfo depABInfo = GetLoadedAssetBundle(dependency);
                //depABInfo.m_ReferencedCount++;
                m_LoadRequests.Remove(dependency);
            }
        }
    }
    IEnumerator OnLoadAssetBundle(string abName, Type type)
    {
        abName = abName.ToString();
        string url = makeFullPath(abName);
        url = url.ToLower();
        //Debug.LogError("加载asset路径是："+url+ " abName:"+abName);
        AssetBundleCreateRequest download = null;
        if (type == typeof(AssetBundleManifest))
        {
            download = AssetBundle.LoadFromFileAsync(url);
        }
        else
        {
            string[] dependencies = m_AssetBundleManifest.GetAllDependencies(abName);
            if (dependencies.Length > 0)
            {
                //注意下面这行报key重复，多半是因为abName在用的地方没有注意大小写，导致资源加载失败，
                //一般底层ab读取都用小写。
                m_Dependencies.Add(abName, dependencies);
                for (int i = 0; i < dependencies.Length; i++)
                {
                    string depName = dependencies[i];
                    AssetBundleInfo bundleInfo = null;
                    if (m_LoadedAssetBundles.TryGetValue(depName, out bundleInfo))
                    {
                        bundleInfo.m_ReferencedCount++;
                    }
                    else if (!m_LoadRequests.ContainsKey(depName))
                    {
                        m_LoadRequests.Add(depName, null);
                        yield return StartCoroutine(OnLoadAssetBundle(depName, type));
                    }
                }
            }
            //Debug.LogWarning("即将WWW下载AB" + url);
            //此处资源部分，也就是ABName必须是小写，否则AssetBundle会永久加载并且不做任何回复
            //凡是资源加载不了，又没有错误提示的，请检查这里的路径是否是大小写问题，是否是空格和斜杠问题
            download = AssetBundle.LoadFromFileAsync(url);
        }
        yield return download;
        AssetBundle assetObj = download.assetBundle;
        if (assetObj != null)
        {
            if (m_LoadedAssetBundles.ContainsKey(abName))
            {
                //1、有可能因为同步加载等原因我们要加载的资源已经加载了
                //2、把这次的加载取消
                //3、用同步加载的资源继续(默认操作就可以了)
                assetObj.Unload(false);
                assetObj = null;
            }
            else
            {
                m_LoadedAssetBundles.Add(abName, new AssetBundleInfo(assetObj));
                //Debug.LogWarning("WWW下载AB成功:" + url);
            }
        }
        else
        {
            Debug.LogError("OnLoadAssetBundle(string abName, Type type) assetObj == null"+ url);
        }
        download = null;
    }
    //恢复丢失的着色器
    public static void RecoveryShader(GameObject go)
    {
        //如果当前运行过程已经是window环境了，就不需要在编辑器模式下手动纠正shader
        if(RuntimePlatform.WindowsEditor == Application.platform)
        {
            return;
        }
        if (go == null)
        {
            return;
        }
        else
        {
            Renderer[] renders =go.GetComponentsInChildren<Renderer>(true);
            if(renders!=null)
            {
                int render_count = renders.Length;
                for (int i = 0; i < render_count; ++i)
                {
                    Renderer render = renders[i];
                    if (render != null)
                    {
                        Material[] mats = render.sharedMaterials;
                        int mat_count = mats.Length;
                        for (int j = 0; j < mat_count; ++j)
                        {
                            Material mat = mats[j];
                            if (mat != null)
                            {
                                mat.shader = GameDll.ShaderManager.GetShader(mat.shader.name);
                            }
                        }
                    }
                }
            }

            UnityEngine.UI.Graphic[] gps = go.GetComponentsInChildren<UnityEngine.UI.Graphic>(true);
            if (gps != null)
            {
                int gp_count = gps.Length;
                for (int i = 0; i < gp_count; ++i)
                {
                    UnityEngine.UI.Graphic gp = gps[i];
                    if (gp != null)
                    {
                        if (gp.material)
                            gp.material.shader = GameDll.ShaderManager.GetShader(gp.material.shader.name);
                    }
                }
            }
        }
    }

    IEnumerator OnLoadLevelAssetBundle(string abName)
    {
        abName = abName.ToLower();
        string url = makeFullPath(abName);
        url = url.ToLower();

        AssetBundleCreateRequest download = null;

        string[] dependencies = m_AssetBundleManifest.GetAllDependencies(abName);
        if (dependencies.Length > 0)
        {
            m_Dependencies.Add(abName, dependencies);
            for (int i = 0; i < dependencies.Length; i++)
            {
                string depName = dependencies[i];
                AssetBundleInfo bundleInfo = null;
                if (m_LoadedAssetBundles.TryGetValue(depName, out bundleInfo))
                {
                    bundleInfo.m_ReferencedCount++;
                }
                else if (!m_LoadRequests.ContainsKey(depName))
                {
                    m_LoadRequests.Add(depName, null);
                    yield return StartCoroutine(OnLoadLevelAssetBundle(depName));
                }
            }
        }
        //Debug.LogWarning("即将WWW下载AB" + url);
        //m_StopWatch.Start();
        download = AssetBundle.LoadFromFileAsync(url);
        //m_StopWatch.Stop();
        //Debug.Log("LoadFromFileAsync time:" + m_StopWatch.ElapsedMilliseconds);
        yield return download;

        AssetBundle assetObj = download.assetBundle;
        if (assetObj != null)
        {
            AssetBundleInfo info = new AssetBundleInfo(assetObj);
            m_LoadedAssetBundles.Add(abName, info);
            //Debug.LogWarning("WWW下载AB成功:" + url);
        }
        else
        {
            Debug.LogError("OnLoadLevelAssetBundle assetObj == null: "+ url);
        }
        download = null;
    }

    AssetBundleInfo GetLoadedAssetBundle(string abName)
    {
        AssetBundleInfo bundle = null;
        m_LoadedAssetBundles.TryGetValue(abName.ToLower(), out bundle);
        if (bundle == null) return null;

        // No dependencies are recorded, only the bundle itself is required.
        string[] dependencies = null;
        if (!m_Dependencies.TryGetValue(abName.ToLower(), out dependencies))
            return bundle;

        // Make sure all dependencies are loaded
        foreach (var dependency in dependencies)
        {
            AssetBundleInfo dependentBundle = null;
            m_LoadedAssetBundles.TryGetValue(dependency, out dependentBundle);
            if (dependentBundle == null) return null;
        }
        return bundle;
    }
    public void UnloadPrefab(long id)
    {
        string abName = "";
        if (m_LoadedIdABName.TryGetValue(id, out abName))
        {
            abName = abName.ToLower();
            //abName = makeFullPath(abName);
            UnloadAssetBundleInternal(abName);
            UnloadDependencies(abName);
           
            m_LoadedIdABName.Remove(id);
        }
        else
        {
            if (IsUnloadId(id))
            {
                Debug.LogError("重复释放资源，Id：" + id +" 资源加载失败的话，资源管理系统会自动释放，无需逻辑层处理");
            }
            else
            {
                m_UnloadedIdABName.Add(id);
            }
        }
    }
    public void UnloadLevel(long id)
    {
        string level = "";
        if (m_LoadedIdABName.TryGetValue(id, out level))
        {
            UnloadPrefab(id);

            string levelname = Path.GetFileNameWithoutExtension(level);
            UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(levelname);
            Debug.Log("UnloadLevel " + level);
        }
    }
    void UnloadDependencies(string abName)
    {
        string[] dependencies = null;
        if (!m_Dependencies.TryGetValue(abName, out dependencies))
            return;

        // Loop dependencies.
        int length = dependencies.Length;
        for (int i =0;i<length; ++i)
        {
            UnloadAssetBundleInternal(dependencies[i]);
        }
        m_Dependencies.Remove(abName);
    }
    void UnloadAssetBundleInternal(string abName)
    {
        AssetBundleInfo bundle = GetLoadedAssetBundle(abName);
        if (bundle == null)
        {
            Debug.LogError("需要释放的abName没有找到," + abName);
            return;
        }
        if (bundle.m_ReferencedCount == 0)
        {
            Debug.LogError("需要释放引用的资源已经没有引用");
        }
        else
        {
            if (--bundle.m_ReferencedCount == 0)
            {
                //m_LoadedAssetBundles.Remove(abName);
                bundle.m_DiscardTime = Time.realtimeSinceStartup;
                //Debug.LogWarning(abName + " Reference count is 0 ");
                //这里只需要负责添加处理请求，如果后来引用不为0了，可以不用理会，虽然DoGC依然会处理这里的请求，但是那时候引用不为0，所以
                //相当于是一次空的处理，但是我们其他添加引用的地方手动遍历找到m_DiscardABNameList的ABName的效率会比较频繁却低效。
                m_DiscardABNameList.Add(abName);
                m_DiscardTimeList.Add(bundle.m_DiscardTime);
            }
        }
    }
    void Update()
    {
        if (Time.realtimeSinceStartup - m_fLastGCTime > m_fGCInternal)
        {
            DoGC();
            m_fLastGCTime = Time.realtimeSinceStartup;
        }

        if(m_CallBackList.Count>0)
        {
            LoadAssetRequest r = m_CallBackList[0];
            m_CallBackIndex = r.LoadIndex;
            //暂时不要之前的那个加载顺序的判断
            if (IsUnloadId(m_CallBackIndex))
            {

                if (r.levelSharpFunc != null)
                {
                    UnloadLevel(m_CallBackIndex);

                }
                else
                {
                    UnloadPrefab(m_CallBackIndex);
                }
                m_UnloadedIdABName.Remove(m_CallBackIndex);
            }
            else
            {
                if (r.levelSharpFunc != null)
                {

                    r.levelSharpFunc();
                    r.levelSharpFunc = null;
                }
                else if (r.sharpFunc != null)
                {
                    if (r.ObjList != null)
                    {
                        r.ObjList.m_Id = m_CallBackIndex;
                    }
                    else
                    {
                        UnloadPrefab(m_CallBackIndex);
                    }
                    r.sharpFunc(r.ObjList);
                    r.sharpFunc = null;
                }
            }
            if(r.ObjList!= null)
            {
                r.ObjList.DestroyClass();
                r.ObjList = null;
            }
            m_CallBackList.RemoveAt(0);
            
        }
    }
    //应该交由业务层在合适的时间调用，例如切换场景前
    public void UnloadUnusedAssets()
    {
        Resources.UnloadUnusedAssets();
        GC.Collect();
    }
    List<string> m_DiscardABNameList = new List<string>();
    List<float> m_DiscardTimeList = new List<float>();
    void DoGC()
    {
        //PrintMemory();
        //m_DiscardList.Clear();
        //foreach (var kv in m_LoadedAssetBundles)
        //{
        //    m_DiscardList.Add(kv.Key, kv.Value.m_DiscardTime);
        //}
        int count = m_DiscardABNameList.Count;
        for(int i = count-1; i >= 0; --i)
        {
            string abName = m_DiscardABNameList[i];
            AssetBundleInfo abInfo = null;
            if (m_LoadedAssetBundles.TryGetValue(abName, out abInfo))
            {
                if (abInfo.m_ReferencedCount == 0)
                {
                    if (Time.realtimeSinceStartup - m_DiscardTimeList[i] > m_fGCInternal)
                    {
                        if (abInfo.m_AssetBundle)
                        {
                            //所有的已经实例化的资源我们都自己来处理释放，这里只是将原始包释放了
                            Debug.LogError("实际上删除模型，使用Unload(false)");
                            abInfo.m_AssetBundle.Unload(false);
                            abInfo.m_AssetBundle = null;
                        }
                        m_LoadedAssetBundles.Remove(abName);
                        m_Dependencies.Remove(abName);

                        m_DiscardTimeList.RemoveAt(i);
                        m_DiscardABNameList.RemoveAt(i);
                        //Debug.LogWarning("资源由于长时间未被使用，被底层释放：" + abName + " 当前AB数量：" + m_LoadedAssetBundles.Count);
                    }
                }
                else
                {
                    //如果不为0，表明后来有添加了引用
                    m_DiscardTimeList.RemoveAt(i);
                    m_DiscardABNameList.RemoveAt(i);
                }
            }
            else
            {
                //有可能需要释放的资源正在加载中
            }

        }

        //GC.Collect();
        //Debug.Log("GC  time:" + Time.realtimeSinceStartup);
        //PrintMemory();
    }
    void PrintMemory()
    {
        int unityTotalReservedMemory = (int)UnityEngine.Profiling.Profiler.GetTotalReservedMemory();
        int unityTotalAllocatedMem = (int)UnityEngine.Profiling.Profiler.GetTotalAllocatedMemory();
        int unityUnusedReservedMemory = (int)UnityEngine.Profiling.Profiler.GetTotalUnusedReservedMemory();
        int MonoHeapSize = (int)UnityEngine.Profiling.Profiler.GetMonoHeapSize();
        int MonoUsedHeapSize = (int)UnityEngine.Profiling.Profiler.GetMonoUsedSize();
        int systemMemory = (int)System.GC.GetTotalMemory(false);

        Debug.LogWarningFormat("unityTotalReservedMemory:{0} unityTotalAllocatedMem:{1} unityUnusedReservedMemory:{2} MonoHeapSize:{3} MonoUsedHeapSize:{4} systemMemory:{5}"
            , unityTotalReservedMemory, unityTotalAllocatedMem, unityUnusedReservedMemory, MonoHeapSize, MonoUsedHeapSize, systemMemory);
    }


    public void LoadBytes(string abName, string assetName, Action<byte[]> func)
    {
        StartCoroutine(OnLoadBytes(abName, assetName,func));
    }
    IEnumerator OnLoadBytes(string abName, string assetName, Action<byte[]> func)
    {
        string url = makeFullPath(abName);
        url = url.ToLower();
        AssetBundleCreateRequest download = null;
        //AssetBundle ab = AssetBundle.LoadFromFile(url.ToLower());
        download = AssetBundle.LoadFromFileAsync(url);
        yield return download;
        AssetBundle assetObj = download.assetBundle;
        if (assetObj != null)
        {
            AssetBundleRequest request = assetObj.LoadAssetAsync<TextAsset>(assetName);
            yield return request;
            TextAsset ta = (TextAsset)request.asset;
            func(ta.bytes);
            assetObj.Unload(true);
        }
        else
        {
            Debug.LogError("OnLoadBytes :assetObj == null  "+url);
        }
        download = null;
    }
    public static byte[] LoadBytes(string resName)
    {
        resName = resName.ToLower();
        AssetBundle ab = AssetBundle.LoadFromFile(resName);
        string assetName = Path.GetFileNameWithoutExtension(resName);
        TextAsset ta = ab.LoadAsset<TextAsset>(assetName);
        ab.Unload(true);
        return ta.bytes;
    }


    private static string m_DataPath = "";
    public static string GetDataPath()
    {
        if(m_DataPath!= "")
        {
            return m_DataPath;
        }
        m_DataPath = MonoTool.GeDataPathHeader() + MonoTool.GetDataPath();
        //Debug.LogError("getSystemPath:" + path);
        return m_DataPath;
    }
    public static string makeFullPath(string strFileName)
    {
        string strFullName = "";
        if (strFileName == null)
        {
            return null;
        }
        strFullName = Path.Combine(MonoTool.GetPersistentPath(), strFileName);
        
        //对该路径进行检测，如果没有找到，就为他尽量指定一个默认路径
        if (File.Exists(strFullName))
        {
            //Debug.Log("file find at manu folder,path is" + strFullName);
            return strFullName;
        }
        else
        {
            //Debug.Log("file not find at the path : " + strFullName + " ,using File.Exists for test");
            strFullName = MonoTool.GeDataPathHeader() + Path.Combine( MonoTool.GetDataPath() , strFileName);
            //Debug.Log("change path to system path :" + strFullName);
        }
        
        //Debug.LogError("makeFullPath:" + strFullName);
        return strFullName;
    }
    void OnApplicationQuit()
    {
        Debug.Log("ResourceManagerMono OnApplicationQuit");
    }
    

}