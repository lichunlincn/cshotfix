using System;
using System.Collections.Generic;
using System.Text;
using GameDll;
using LCL;
using UnityEngine;
using UnityEngine.UI;
using UnityUI;

namespace HotFix
{
    public abstract class WindowBase
    {
        //该UI是否已经创建并且目前没有被释放，正常使用中
        private bool m_bBind = false;
        public long m_ABId = 0;
        public string m_UIName;
        public WindowLayer m_Layer = WindowLayer.Popup;
        public int m_RenderOrder = -1;
        private bool m_bDestroy = true;
        private bool m_bLogicOpen = false;
        //打开界面可能会用到一些调用数据
        protected object[] m_UserData;
        //窗口缓存时间(ms)
        private int m_WindowCacheTime = 10000;
        public void SetWindowCacheTime(int timeMMSec)
        {
            m_WindowCacheTime = timeMMSec;
        }
        public void SetUserData(params object[] userdata)
        {
            m_UserData = userdata;
        }
        public GameObject m_WinObj
        {
            get;
            set;
        }
        public Transform m_WinTransform
        {
            get;
            set;
        }
        public Vector3 m_WindowPos = Vector3.zero;
        private bool m_bSwitchOut = false;
        private Timer m_DestroyTimer = null;

        public bool IsDestroy()
        {
            return m_bDestroy;
        }
        public void SetAsLastSibling()
        {
            if(m_WinObj != null)
            {
                m_WinTransform.SetAsLastSibling();
            }
        }
        public void SortRender()
        {
            if (m_WinObj != null)
            {
                Component[] depth =  m_WinObj.GetComponentsInChildren(typeof(UIDepth));
                if (depth != null)
                {
                    int count = depth.Length;
                    for (int i = 0; i < count; ++i)
                    {
                        UIDepth d = depth[i] as UIDepth;
                        if (d != null)
                        {
                            d.SetOrder(m_RenderOrder + i);
                        }
                    }
                }
            }
        }
        private void DestroyTimeCall()
        {
            if (m_DestroyTimer != null)
            {
                m_DestroyTimer.DestroyClass();
                m_DestroyTimer = null;
                UIManager.WindowDestroy(this);
            }

        }
        public bool IsObjLoaded()
        {
            return m_WinObj != null && !m_WinObj.Equals(null);
        }
        private Canvas m_WindowCanvas;
        public Canvas GetOrAddWindowCanvas()
        {
            if(m_WindowCanvas!= null)
            {
                return m_WindowCanvas;
            }
            if(IsObjLoaded())
            {
                m_WindowCanvas = m_WinObj.GetComponent(typeof(Canvas)) as Canvas;
                if (m_WindowCanvas == null)
                {
                    m_WindowCanvas = m_WinObj.AddComponent(typeof(Canvas)) as Canvas;
                    m_WindowCanvas.additionalShaderChannels = AdditionalCanvasShaderChannels.TexCoord1 | AdditionalCanvasShaderChannels.Normal | AdditionalCanvasShaderChannels.Tangent;
                }
                return m_WindowCanvas;
            }
            else
            {
                return null;
            }
        }
        private GraphicRaycaster m_Blocker;
        //设置窗口不可被点穿
        public void AddWindowBlock()
        {
            if(m_Blocker == null)
            {
                if (IsObjLoaded())
                {
                    m_Blocker = m_WinObj.AddComponent(typeof(GraphicRaycaster)) as GraphicRaycaster;
                }
            }
        }
        public bool isVisiable()
        {
            if (!IsObjLoaded())
            {
                return false;
            }
            if (m_bSwitchOut)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        protected abstract void OnInitComponent();

        protected virtual void OnOpen()
        {
        }

        protected virtual void OnClose()
        {

        }
        protected virtual void OnDestroy()
        {
        }
        public void Destroy()
        {

            OnDestroy();
            m_bBind = false;
            GameObject.Destroy(m_WinObj);
            m_WinObj = null;
            WindowDestroyClearImages();
            ResourceManager.UnloadPrefab(m_ABId);
            m_ABId = 0;
            m_bDestroy = true;
            //System.GC.Collect();
        }
        protected Transform GetTransform(string path)
        {
            return m_WinTransform.Find(path);
        }
        protected T GetControl<T>(string name = "", Component parent = null) where T: Component
        {
            if (parent == null)
            {
                parent = m_WinObj.transform;
            }
            Type type = typeof(T);
            if (name == "")
            {
                return parent.GetComponent(type) as T;
            }
            else
            {
                Transform tr = parent.transform.Find(name);
                if (tr == null)
                {
                    Tool.StringBuilder.Append(name);
                    Tool.StringBuilder.Append("not find");
                    UnityEngine.Debug.LogError(Tool.StringBuilder.ToString());
                    Tool.StringBuilder.Clear();
                    return null;
                }
                return tr.GetComponent(type) as T;
            }
        }


        //整合一个小红点的

        #region 窗口父子关系逻辑
        private List<WindowBase> m_ChildWindows = new List<WindowBase>();
        private WindowBase m_ParentWindow = null;
        public void AddChild(WindowBase win)
        {
            if (win != null)
            {
                int count = m_ChildWindows.Count;
                for(int i=0;i<count;++i)
                {
                    if(m_ChildWindows[i] == win)
                    {
                        return;
                    }
                }
                if (win.m_ParentWindow != null)
                {
                    win.m_ParentWindow.m_ChildWindows.Remove(win);
                }
                win.m_ParentWindow = this;
                m_ChildWindows.Add(win);
            }
        }
        public void RemoveChild(WindowBase win)
        {
            if(win != null && win.m_ParentWindow == this)
            {
                win.m_ParentWindow = null;
                m_ChildWindows.Remove(win);
            }
        }
        //该接口只能由UIManager调用
        public void ShowWindowObj()
        {
            m_bDestroy = false;

            if (m_DestroyTimer != null)
            {
                TimerManager.StaticRemoveTimer(m_DestroyTimer.GetId());
                m_DestroyTimer.DestroyClass();
                m_DestroyTimer = null;
            }

            if (m_WinObj == null)
            {
                return;
            }
            if (!m_bBind)
            {
                OnInitComponent();
                m_bBind = true;
            }

            m_bSwitchOut = false;
            m_WinTransform.position = m_WindowPos;
        }
        //提供给UIManager调用的接口
        public void DoWindowDataBind()
        {
            OnOpen();
        }
        //提供给UIManager使用
        public void SetLogicOpen(bool open)
        {
            m_bLogicOpen = open;
        }
        //提供给UIManager使用
        public bool IsLogicOpen()
        {
            return m_bLogicOpen;
        }

        //该接口只能由UIManager调用
        private List<WindowBase> m_tempChildWnds = new List<WindowBase>();
        public void CloseWindowWithChild()
        {
            //先要断开和父对象的关系
            if(m_ParentWindow!= null)
            {
                m_ParentWindow.RemoveChild(this);
            }
            if(m_ChildWindows.Count>0)
            {
                int count = m_ChildWindows.Count;
                m_tempChildWnds.Clear();
                for(int i=0;i<count;++i)
                {
                    m_tempChildWnds.Add(m_ChildWindows[i]);
                }
                for(int i =0; i<count; ++i)
                {
                    WindowBase win = m_tempChildWnds[i];
                    UIManager.WindowClose(win);
                }
            }
            CloseWindowObj();
        }
        public bool IsChildOf(WindowBase parent)
        {
            return m_ParentWindow == parent;
        }
        public bool IsGrandsonOf(WindowBase parent)
        {
            WindowBase wnd = m_ParentWindow;
            while(wnd!= null)
            {
                bool child = wnd.IsChildOf(parent);
                if(child)
                {
                    return true;
                }
                else
                {
                    wnd = wnd.m_ParentWindow;
                }
            }
            return false;
        }
        private void CloseWindowObj()
        {
            if (m_DestroyTimer != null)
            {
                UnityEngine.Debug.LogError("上一次删除缓存还未结束");
                return;
            }
            //ClearAllRedPoint();
            //HotFixLoop.GetInstance().GetEvent().OnRedPointValueChange -= OnRedDotRefreshEvent;
            OnClose();
            //记录本次关闭时候窗口的位置
            m_WindowPos = m_WinTransform.position;
            //将窗口移动到很远地方

            Vector3 far = Const.Vector3Max;
            m_WinTransform.position = far;
            m_bSwitchOut = true;



            m_DestroyTimer = Timer.CreateClass();
            m_DestroyTimer.totalMMSeconds = m_WindowCacheTime;
            m_DestroyTimer.finishCall = DestroyTimeCall;
            TimerManager.StaticAddTimer(m_DestroyTimer);
        }
        #endregion



        #region 窗口基类帮助函数
        private Dictionary<Image, long> m_ImageIds = new Dictionary<Image, long>();
        protected void SetImage(Image img, string atlas, string icon)
        {
            SetImageSpriteParam param = new SetImageSpriteParam();
            param.abName = atlas;// "texture_set/common.jpg";
            param.assetName = icon;// "anniu4H_4zi_C";
            param.img = img;
            param.call = OnSetImageCallback;
            long id = -1;
            if(m_ImageIds.ContainsKey(img))
            {
                id = m_ImageIds[img];
                AtlasManager.WindowImageIdReturn(this, id);
                id = AtlasManager.SetImageSprite(param);
                m_ImageIds[img] = id;
            }
            else
            {
                id = AtlasManager.SetImageSprite(param);
                m_ImageIds.Add(img, id);
            }
            //AtlasManager.WindowImageIdCollect(this, id);
        }

        private void OnSetImageCallback(SetImageSpriteParam param,Sprite sp)
        {
            param.img.sprite = sp;
            Debug.Log("使用图集改变按钮图片成功");
        }
        protected void ClearImage(Image img)
        {
            if (m_ImageIds.ContainsKey(img))
            {
                long id = m_ImageIds[img];
                AtlasManager.WindowImageIdReturn(this, id);
                m_ImageIds.Remove(img);
            }
        }
        private void WindowDestroyClearImages()
        {
            AtlasManager.WindowImageIdReturn(this);
            m_ImageIds.Clear();
        }
        #endregion
    }
}