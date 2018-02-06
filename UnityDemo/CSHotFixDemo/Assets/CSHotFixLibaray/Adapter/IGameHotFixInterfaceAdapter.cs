using System;
using System.Collections;
using System.Collections.Generic;
using CSHotFix.CLR.Method;
using CSHotFix.Runtime.Enviorment;
using CSHotFix.Runtime.Intepreter;

public class IGameHotFixInterfaceAdapter : CrossBindingAdaptor
{
    public override Type BaseCLRType
    {
        get
        {
            return typeof(IGameHotFixInterface);//这是你想继承的那个类
        }
    }

    public override Type AdaptorType
    {
        get
        {
            return typeof(Adaptor);//这是实际的适配器类
        }
    }

    public override object CreateCLRInstance(CSHotFix.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
    {
        return new Adaptor(appdomain, instance);//创建一个新的实例
    }

    //实际的适配器类需要继承你想继承的那个类，并且实现CrossBindingAdaptorType接口
    class Adaptor : IGameHotFixInterface, CrossBindingAdaptorType
    {
        ILTypeInstance instance;
        CSHotFix.Runtime.Enviorment.AppDomain appdomain;
        //缓存这个数组来避免调用时的GC Alloc
        object[] param1 = new object[1];

        public Adaptor()
        {

        }

        public Adaptor(CSHotFix.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
        {
            this.appdomain = appdomain;
            this.instance = instance;
        }

        public ILTypeInstance ILInstance { get { return instance; } }

        //你需要重写所有你希望在热更脚本里面重写的方法，并且将控制权转到脚本里去
        bool m_bStartGot = false;
        IMethod m_Start = null;
        public override void Start()
        {
            if (!m_bStartGot)
            {
                m_Start = instance.Type.GetMethod("Start", 0);
                m_bStartGot = true;
            }
            if (m_Start != null)
            {
                appdomain.Invoke(m_Start, instance, null);//没有参数建议显式传递null为参数列表，否则会自动new object[0]导致GC Alloc
            }
        }

        //bool m_bFixedUpdateGot = false;
        //IMethod m_FixedUpdate = null;
        //public override void FixedUpdate()
        //{
        //    if (!m_bFixedUpdateGot)
        //    {
        //        m_FixedUpdate = instance.Type.GetMethod("FixedUpdate", 0);
        //        m_bFixedUpdateGot = true;
        //    }
        //    if (m_FixedUpdate != null)
        //    {
        //        appdomain.Invoke(m_FixedUpdate, instance, null);//没有参数建议显式传递null为参数列表，否则会自动new object[0]导致GC Alloc
        //    }
        //}

        bool m_bUpdateGot = false;
        IMethod m_Update = null;
        public override void Update()
        {
            if (!m_bUpdateGot)
            {
                m_Update = instance.Type.GetMethod("Update", 0);
                m_bUpdateGot = true;
            }
            if (m_Update != null)
            {
                appdomain.Invoke(m_Update, instance,null);//没有参数建议显式传递null为参数列表，否则会自动new object[0]导致GC Alloc
            }
        }

        //bool m_bLateUpdateGot = false;
        //IMethod m_LateUpdate = null;
        //public override void LateUpdate()
        //{
        //    if (!m_bLateUpdateGot)
        //    {
        //        m_LateUpdate = instance.Type.GetMethod("LateUpdate", 0);
        //        m_bLateUpdateGot = true;
        //    }
        //    if (m_LateUpdate != null)
        //    {
        //        appdomain.Invoke(m_LateUpdate, instance, null);//没有参数建议显式传递null为参数列表，否则会自动new object[0]导致GC Alloc
        //    }
        //}

        //bool m_bOnGUIGot = false;
        //IMethod m_OnGUI = null;
        //public override bool OnGUI()
        //{
        //    if (!m_bOnGUIGot)
        //    {
        //        m_OnGUI = instance.Type.GetMethod("OnGUI", 0);
        //        m_bOnGUIGot = true;
        //    }
        //    if (m_OnGUI != null)
        //    {
        //        return (bool)appdomain.Invoke(m_OnGUI, instance, null);//没有参数建议显式传递null为参数列表，否则会自动new object[0]导致GC Alloc
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //bool m_bOnApplicationPauseGot = false;
        //IMethod m_OnApplicationPause = null;
        //public override void OnApplicationPause()
        //{
        //    if (!m_bOnApplicationPauseGot)
        //    {
        //        m_OnApplicationPause = instance.Type.GetMethod("OnApplicationPause", 0);
        //        m_bOnApplicationPauseGot = true;
        //    }
        //    if (m_OnApplicationPause != null)
        //    {
        //        appdomain.Invoke(m_OnApplicationPause, instance, null);//没有参数建议显式传递null为参数列表，否则会自动new object[0]导致GC Alloc
        //    }
        //}

        bool m_bOnDestroyGot = false;
        IMethod m_OnDestroy = null;
        public override void OnDestroy()
        {
            if (!m_bOnDestroyGot)
            {
                m_OnDestroy = instance.Type.GetMethod("OnDestroy", 0);
                m_bOnDestroyGot = true;
            }
            if (m_OnDestroy != null)
            {
                appdomain.Invoke(m_OnDestroy, instance, null);//没有参数建议显式传递null为参数列表，否则会自动new object[0]导致GC Alloc
            }
        }

        bool m_bOnApplicationQuitGot = false;
        IMethod m_OnApplicationQuit = null;
        public override void OnApplicationQuit()
        {
            if (!m_bOnApplicationQuitGot)
            {
                m_OnApplicationQuit = instance.Type.GetMethod("OnApplicationQuit", 0);
                m_bOnApplicationQuitGot = true;
            }
            if (m_OnApplicationQuit != null)
            {
                appdomain.Invoke(m_OnApplicationQuit, instance, null);//没有参数建议显式传递null为参数列表，否则会自动new object[0]导致GC Alloc
            }
        }

        //bool m_bOnPlatformMessageGot = false;
        //IMethod m_OnPlatformMessage = null;
        //public override void OnPlatformMessage(string message)
        //{
        //    if (!m_bOnPlatformMessageGot)
        //    {
        //        m_OnPlatformMessage = instance.Type.GetMethod("OnPlatformMessage", 1);
        //        m_bOnPlatformMessageGot = true;
        //    }
        //    if (m_OnPlatformMessage != null)
        //    {
        //        appdomain.Invoke(m_OnPlatformMessage, instance, message);//没有参数建议显式传递null为参数列表，否则会自动new object[0]导致GC Alloc
        //    }
        //}

        bool m_bOnMono2GameDllGot = false;
        IMethod m_OnMono2GameDll = null;
        public override object OnMono2GameDll(string func,params object[] data)
        {
            if (!m_bOnMono2GameDllGot)
            {
                m_OnMono2GameDll = instance.Type.GetMethod("OnMono2GameDll", 2);
                m_bOnMono2GameDllGot = true;
            }
            if (m_OnMono2GameDll != null)
            {
                return appdomain.Invoke(m_OnMono2GameDll, instance, func, data);//没有参数建议显式传递null为参数列表，否则会自动new object[0]导致GC Alloc
            }
            else
            {
                return null;
            }
        }
    }
}