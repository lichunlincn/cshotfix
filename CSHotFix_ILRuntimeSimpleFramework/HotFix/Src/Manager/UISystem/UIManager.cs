using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using GameDll;
using LCL;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityUI;

namespace HotFix
{
    public enum UIEventTypeHF
    {
        Submit = 0,
        Click,
        DoubleClick,
        Hover,
        Press,
        Select,
        Scroll,
        Drag,
        Drop,
        Key,
        Count
    }
    public enum WindowLayer
    {
        Effect = 0,
        Hold,
        HUD,
        Popup,
        Guide,
        Loading,
        Notice,
        Count
    }

    public class UIManager
    {
        private static GameObject m_GlobalCanvas;
        private static GameObject m_GlobalUI;
        private static Dictionary<int, Transform> m_LayerGameObjects = new Dictionary<int, Transform>();
        //存储某个层的基础渲染顺序
        private static Dictionary<int, int> m_LayerRenderOrder = new Dictionary<int, int>();
        //存储某个层的逻辑窗口
        private static Dictionary<int, List<WindowBase>> m_LayerWindows = new Dictionary<int, List<WindowBase>>();
        public static EventSystem m_EventSystem;
        public static Camera m_UICamera;
        public static CanvasScaler m_CanvasScaler;
        public static RectTransform m_CanvasRect;


        public static void Init()
        {
            CreateUIStruct();

        }
        public static void Destroy()
        {
            int loaded_count = m_OpenedList.Count;
            for (int i = 0; i < loaded_count; ++i)
            {
                WindowBase ui = m_OpenedList[i];
                ui.Destroy();
            }
            m_OpenedList.Clear();
            UnityEngine.Debug.Log("UIManagerHF Destroy");
        }

        public static void CreateUIStruct()
        {
            Debug.Log("Create UI Struct In Dll");
            m_GlobalUI = new GameObject("GlobalUI");
            GameObject.DontDestroyOnLoad(m_GlobalUI);


            //相机
            GameObject camgo = new GameObject("UICamera");
            Transform cam = camgo.transform;

            m_UICamera = cam.gameObject.AddComponent(typeof(Camera)) as Camera;
            m_UICamera.allowHDR = false;
            m_UICamera.orthographicSize = 1;
            m_UICamera.orthographic = true;
            m_UICamera.useOcclusionCulling = true;
            m_UICamera.nearClipPlane = 1.0f;
            m_UICamera.farClipPlane = 100;
            m_UICamera.clearFlags = CameraClearFlags.Depth;
            m_UICamera.cullingMask = LayerMask.GetMask("UI", "UI3D", "UIVFX");
            m_UICamera.transform.position = new Vector3(10000, 10000, 0);

            //画布
            m_GlobalCanvas = new GameObject("GlobalCanavs");
            m_GlobalCanvas.transform.SetParent(m_GlobalUI.transform, false);

            cam.transform.SetParent(m_GlobalCanvas.transform, false);

            m_GlobalCanvas.layer = LayerMask.NameToLayer("UI");
            Canvas canvas = m_GlobalCanvas.AddComponent(typeof(Canvas)) as Canvas;
            canvas.renderMode = RenderMode.ScreenSpaceCamera;
            canvas.worldCamera = m_UICamera;
            canvas.planeDistance = 15;
            canvas.additionalShaderChannels = AdditionalCanvasShaderChannels.TexCoord1 | AdditionalCanvasShaderChannels.Normal | AdditionalCanvasShaderChannels.Tangent;

            m_CanvasRect = m_GlobalCanvas.GetComponent(typeof(RectTransform)) as RectTransform;

            //画布适配器
            m_CanvasScaler = m_GlobalCanvas.AddComponent(typeof(CanvasScaler)) as CanvasScaler;
            m_CanvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            m_CanvasScaler.referenceResolution = LogicRoot.m_ScreenDesignSize;
            m_CanvasScaler.matchWidthOrHeight = SetMatchWidthOrHeight( Screen.width , Screen.height );
            m_GlobalCanvas.AddComponent(typeof(GraphicRaycaster));
            

            //事件
            GameObject evtObj = new GameObject("EventSystem");
            evtObj.transform.SetParent(m_GlobalUI.transform, false);
            m_EventSystem = evtObj.AddComponent(typeof(EventSystem)) as EventSystem;
            //evtObj.AddComponent<TouchInputModule>();
            evtObj.AddComponent(typeof(StandaloneInputModule));



            //层级
            //注意：枚举的GetValues可能无法在热更新里面用
            for (int i=0;i < (int)WindowLayer.Count; ++i)
            {
                WindowLayer layer = (WindowLayer)i;
                string name = GetWindowLayerName(layer);
                Transform tr = m_GlobalCanvas.transform.Find(name);
                if (tr == null)
                {
                    GameObject obj = new GameObject(name);
                    obj.transform.SetParent(m_GlobalCanvas.transform, false);
                    RectTransform rt = obj.AddComponent(typeof(RectTransform)) as RectTransform;
                    obj.layer = LayerMask.NameToLayer("UI");

                    rt.anchorMin = new Vector2(0, 0);
                    rt.anchorMax = new Vector2(1, 1);
                    rt.sizeDelta = new Vector2(0, 0);
                    tr = rt;
                    SetWindowLayerCanvas(obj, layer);
                }
                m_LayerGameObjects.Add((int)layer, tr);
            }
        }
        //0表示适配width，  1表示适配高度
        private static float SetMatchWidthOrHeight(float width, float height)
        {
            if(width >= height)
            {
                return 1;
            }
            else
            {
                return width / height;
            }
        }
        private static void SetWindowLayerCanvas(GameObject obj, WindowLayer layer)
        {
            int idx = (int)layer;
            Canvas childCanvas = obj.AddComponent(typeof(Canvas)) as Canvas;
            childCanvas.overrideSorting = true;
            childCanvas.sortingLayerName = "Default";
            childCanvas.sortingOrder = idx*1000;
            childCanvas.additionalShaderChannels = AdditionalCanvasShaderChannels.TexCoord1 | AdditionalCanvasShaderChannels.Normal | AdditionalCanvasShaderChannels.Tangent;

            m_LayerRenderOrder.Add(idx, childCanvas.sortingOrder);

            childCanvas.gameObject.transform.localPosition = new Vector3(10000, 10000, 12000 - idx * 2000);
            obj.AddComponent(typeof(GraphicRaycaster));
            
        }
        private static string GetWindowLayerName(WindowLayer layer)
        {
            string name = "";
            if (layer == WindowLayer.Effect)
            {
                name = "Effect";
            }
            else if (layer == WindowLayer.Guide)
            {
                name = "Guide";
            }
            else if (layer == WindowLayer.Hold)
            {
                name = "Hold";
            }
            else if (layer == WindowLayer.HUD)
            {
                name = "HUD";
            }
            else if (layer == WindowLayer.Loading)
            {
                name = "Loading";
            }
            else if (layer == WindowLayer.Notice)
            {
                name = "Notice";
            }
            else if (layer == WindowLayer.Popup)
            {
                name = "Popup";
            }
            else
            {
                name = "NoneLayer";
            }
            return name;
        }

        public static WindowBase GetWindow(long id)
        {
            int count = m_OpenedList.Count;
            for (int i = 0; i < count; ++i)
            {
                WindowBase ui = m_OpenedList[i];
                if (ui != null)
                {
                    if (ui.m_ABId == id)
                    {
                        return ui;
                    }
                }
            }
            return null;
        }
        public static void WindowClose(WindowBase ui)
        {
            if (ui != null)
            {
                int layer = (int)ui.m_Layer;

                if(m_LayerWindows.ContainsKey(layer))
                {
                    m_LayerWindows[layer].Remove(ui);
                }

                if (ui.isVisiable())
                {
                    ui.SetLogicOpen(false);
                    ui.CloseWindowWithChild();
                }
            }
            else
            {
                //UnityEngine.Debug.LogError("关闭的窗口不存在，" + classEnum);
            }
        }
        public static void CloseAll()
        {
            int count = m_OpenedList.Count;
            for (int i = 0; i < count; ++i)
            {
                WindowBase ui = m_OpenedList[i];
                if (ui != null)
                {
                    WindowClose(ui);
                }
            }
        }
        public static void WindowDestroy(WindowBase ui)
        {
            if (ui != null)
            {
                ui.Destroy();
                m_OpenedList.Remove(ui);
            }
        }
        private static List<WindowBase> m_OpenedList = new List<WindowBase>();
        /// <summary>
        /// 打开界面
        /// </summary>
        /// <param index="param">界面名字</param>
        //public static WindowBase WindowOpen(string classEnum, WindowBase parent)
        //{
        //    int count = m_OpenedList.Count;
        //    for(int i=0;i<count;++i)
        //    {
        //        var win = m_OpenedList[i];
        //        if(win.m_UIName == classEnum)
        //        {
        //            if (!win.isVisiable())
        //            {
        //                if(parent!= null)
        //                {
        //                    parent.AddChild(win);
        //                }
        //                win.OpenWindow();
        //                SortLayerWindows(win.m_Layer);
        //            }
        //            return win;
        //        }
        //    }
        //    return WindowCreate(classEnum, parent);

        //}
        public static void HideAll()
        {
            m_GlobalUI.SetActive(false);
        }
        public static Vector2 GetUIScreenSize()
        {
            return m_CanvasRect.sizeDelta;
        }


        public static T WindowOpenEX<T>(WindowBase parent, params object[] param) where T:WindowBase,new()
        {
            int count = m_OpenedList.Count;
            for (int i = 0; i < count; ++i)
            {
                var win = m_OpenedList[i];
                if (win is T)
                {
                    if (win.IsObjLoaded() && 
                        !win.isVisiable())
                    {
                        if (parent != null)
                        {
                            parent.AddChild(win);
                        }
                        win.SetUserData(param);
                        win.ShowWindowObj();
                        //这里remove，add是为了将界面进行重新排序
                        List<WindowBase> wins = GetWindowsByLayer(win.m_Layer);
                        wins.Remove(win);

                        wins = AddWindowToParentLast(wins, win, parent);

                        SortLayerWindows(wins, win.m_Layer);
                        win.DoWindowDataBind();
                        return win as T;
                    }

                }
            }
            return WindowCreateEX<T>(parent, param);

        }
        //将窗口加载到紧邻父窗口的子窗口列表的最后一个位置
        private static List<WindowBase> AddWindowToParentLast(List<WindowBase> windows, WindowBase wnd, WindowBase parent)
        {
            if (parent == null)
            {
                windows.Add(wnd);
                return windows;
            }
            else
            {
                int count = windows.Count;
                bool findParent = false;
                for (int i = 0; i < count; ++i)
                {
                    WindowBase window = windows[i];
                    //先要找到父对象
                    if (!findParent && window == parent)
                    {
                        findParent = true;
                        continue;
                    }
                    if (window != null && findParent)
                    {
                        if (window.IsChildOf(parent) || window.IsGrandsonOf(parent))
                        {
                            continue;
                        }

                        windows.Insert(i, wnd);
                        return windows;
                    }
                }
                windows.Add(wnd);
                return windows;
            }
        }
        private static T WindowCreateEX<T>(WindowBase parent, params object[] param) where T:WindowBase,new()
        {
            T win = new T();
            string uifile = typeof(T).Name;
            if (win != null)
            {
                StringBuilder sb = Tool.StringBuilder.AppendFormat("ui/{0}" + MonoTool.GetAssetbundleSuffix(), uifile.ToLower());
                string abname = sb.ToString();
                sb.Clear();
                win.SetLogicOpen(true);
                win.m_UIName = uifile;
                win.SetUserData(param);
                win.m_ABId = ResourceManager.LoadPrefab(typeof(GameObject), abname, uifile, (abobject) =>
                {
                    #region 异步加载UI资源回调
                    win.m_WinObj = (GameObject)GameObject.Instantiate(abobject.m_UObjectList[0]);
                    win.m_WinTransform = win.m_WinObj.transform;
                    Transform AttachObject = GetLayer(win.m_Layer);

                    if (AttachObject == null)
                    {
                        UnityEngine.Debug.LogWarning("挂节点没有找到");
                        return;
                    }
                    //先将大小还原到他的父对象的局部坐标
                    Vector3 parentScale = AttachObject.localScale;
                    Vector3 now = win.m_WinTransform.localScale;
                    Vector3 childScale = new Vector3(now.x * parentScale.x, now.y * parentScale.y, now.z * parentScale.z);
                    win.m_WinTransform.localScale = childScale;


                    //挂接到对应的位置
                    RectTransform rect = win.m_WinObj.GetComponent(typeof(RectTransform)) as RectTransform;
                    if (rect != null)
                    {
                        Vector3 pos = rect.anchoredPosition3D;

                        Quaternion rotation = rect.localRotation;

                        Vector3 scale = rect.localScale;

                        Vector2 offsetMax = rect.offsetMax;

                        Vector2 offsetMin = rect.offsetMin;

                        win.m_WinTransform.SetParent(AttachObject);
                        rect.anchoredPosition3D = pos;
                        rect.localRotation = rotation;
                        rect.localScale = scale;


                        rect.offsetMax = offsetMax;
                        rect.offsetMin = offsetMin;

                    }
                    win.m_WindowPos = win.m_WinTransform.position;
                    win.ShowWindowObj();
                    //设置该layer下面层级
                    List<WindowBase> wins = GetWindowsByLayer(win.m_Layer);
                    SortLayerWindows(wins, win.m_Layer);
                    win.m_WindowPos = win.m_WinTransform.position;
                    win.DoWindowDataBind();

                    #endregion
                });
                if (parent != null)
                {
                    parent.AddChild(win);
                }
                m_OpenedList.Add(win);
                //添加逻辑窗口和层的对应关系
                List<WindowBase> winList = GetWindowsByLayer(win.m_Layer);
                if (winList != null)
                {
                    winList = AddWindowToParentLast(winList, win, parent);
                }
                else
                {
                    winList = new List<WindowBase>();
                    winList = AddWindowToParentLast(winList, win, parent);
                    m_LayerWindows.Add((int)win.m_Layer, winList);
                }
                return win;
            }
            else
            {
                UnityEngine.Debug.LogError("打开的窗口不存在，" + uifile);
            }
            return null;
        }
        //private static WindowBase WindowCreate(string uifile, WindowBase parent)
        //{
        //    WindowBase win = UICreator.GetUIInstance(uifile);
        //    if (win != null)
        //    {
        //        StringBuilder sb = Tool.StringBuilder.AppendFormat("ui/{0}", uifile.ToLower());
        //        string abname = sb.ToString();
        //        sb.Clear();
        //        win.m_UIName = uifile;
        //        win.m_ABId = ResourceManager.LoadPrefab(typeof(GameObject), abname, uifile, (abobject)=> 
        //        {
        //            #region 异步加载UI资源回调
        //            win.m_WinObj = (GameObject)GameObject.Instantiate(abobject.m_UObjectList[0]);

        //            GameObject AttachObject = GetLayer(win.m_Layer);

        //            if (AttachObject == null)
        //            {
        //                UnityEngine.Debug.LogWarning("挂节点没有找到");
        //                return;
        //            }
        //            //先将大小还原到他的父对象的局部坐标
        //            Vector3 parentScale = AttachObject.transform.localScale;
        //            Vector3 now = win.m_WinTransform.localScale;
        //            Vector3 childScale = new Vector3(now.x * parentScale.x, now.y * parentScale.y, now.z * parentScale.z);
        //            win.m_WinTransform.localScale = childScale;


        //            //挂接到对应的位置
        //            RectTransform rect = win.m_WinObj.GetComponent(typeof(RectTransform)) as RectTransform;
        //            if (rect != null)
        //            {
        //                Vector3 pos = rect.anchoredPosition3D;

        //                Quaternion rotation = rect.localRotation;

        //                Vector3 scale = rect.localScale;

        //                Vector2 offsetMax = rect.offsetMax;

        //                Vector2 offsetMin = rect.offsetMin;

        //                win.m_WinTransform.SetParent(AttachObject.transform);
        //                rect.anchoredPosition3D = pos;
        //                rect.localRotation = rotation;
        //                rect.localScale = scale;


        //                rect.offsetMax = offsetMax;
        //                rect.offsetMin = offsetMin;

        //            }
        //            win.m_WindowPos = win.m_WinTransform.position;
        //            win.OpenWindow();
        //            //设置该layer下面层级
        //            SortLayerWindows(win.m_Layer);
        //            win.m_WindowPos = win.m_WinTransform.position;


        //            #endregion
        //        });
        //        if(parent!= null)
        //        {
        //            parent.AddChild(win);
        //        }
        //        m_OpenedList.Add(win);
        //        //添加逻辑窗口和层的对应关系
        //        List<WindowBase> winList = null;
        //        if (m_LayerWindows.TryGetValue((int)win.m_Layer, out winList))
        //        {
        //            winList.Add(win);
        //        }
        //        else
        //        {
        //            winList = new List<WindowBase>();
        //            winList.Add(win);
        //            m_LayerWindows.Add((int)win.m_Layer, winList);
        //        }
        //        return win;
        //    }
        //    else
        //    {
        //        UnityEngine.Debug.LogError("打开的窗口不存在，" + uifile);
        //    }

        //    return null;
        //}
        private static List<WindowBase> GetWindowsByLayer(WindowLayer layer)
        {
            int layerInt = (int)layer;
            if (m_LayerWindows.ContainsKey(layerInt))
            {
                return m_LayerWindows[layerInt];
            }
            else
            {
                return null;
            }
        }
        private static void SortLayerWindows(List<WindowBase> wins, WindowLayer layer)
        {
            if(wins == null)
            {
                Debug.LogError("UI层排序错误，该层没有任何UI" + layer.ToString());
                return;
            }
            int childCount = wins.Count;
            int baseLayerOrder = m_LayerRenderOrder[(int)layer];
            int showLayer = 0;
            for(int i= 0; i < childCount;++i)
            {
                WindowBase win = wins[i];
                if (win.IsObjLoaded())
                {
                    win.SetAsLastSibling();
                    Canvas canvas = win.GetOrAddWindowCanvas();
                    win.AddWindowBlock();
                    win.m_RenderOrder = baseLayerOrder + showLayer * 100;
                    if (canvas != null)
                    {
                        canvas.overrideSorting = true;
                        canvas.sortingOrder = win.m_RenderOrder;
                    }
                    showLayer++;
                    win.SetAsLastSibling();
                    win.SortRender();
                    Vector3 pos = win.m_WinTransform.localPosition;
                    win.m_WinTransform.localPosition = new Vector3(pos.x, pos.y, -showLayer * 300);
                }
            }
        }
        public  static Transform GetLayer(WindowLayer layer)
        {
            return m_LayerGameObjects[(int)layer];
        }

        //public static List<WindowBase> GetWindows(WindowLayer layer)
        //{
        //    List<WindowBase> wins = null;
        //    int count = m_OpenedList.Count;
        //    for (int i = 0; i < count;++i )
        //    {
        //        WindowBase ui = m_OpenedList[i];
        //        if (ui.m_Layer == layer)
        //        {
        //            if (wins == null)
        //            {
        //                wins = new List<WindowBase>();
        //            }
        //            wins.Add(ui);
        //        }
        //    }
        //    return wins;
        //}
       
    }
}
