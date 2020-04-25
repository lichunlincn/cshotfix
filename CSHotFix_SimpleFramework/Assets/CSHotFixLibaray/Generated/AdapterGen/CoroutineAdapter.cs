using CSHotFix.CLR.Method;
using CSHotFix.Runtime.Enviorment;
using CSHotFix.Runtime.Intepreter;
using System;
using System.Collections;
using System.Collections.Generic;

public class CoroutineAdapter : CrossBindingAdaptor
{
    public override Type BaseCLRType
    {
        get { return null; }
    }
    public override Type[] BaseCLRTypes
    {
        get { return new Type[] { typeof(IEnumerator<object>), typeof(IEnumerator), typeof(IDisposable) }; }
    }
    public override Type AdaptorType
    {
        get { return typeof(Adaptor); }
    }
    public override object CreateCLRInstance(CSHotFix.Runtime.Enviorment.AppDomain appdomain,
        ILTypeInstance instance)
    {
        return new Adaptor(appdomain, instance);
    }
    class Adaptor : IEnumerator<object>, IEnumerator, IDisposable, CrossBindingAdaptorType
    {
        ILTypeInstance instance;
        CSHotFix.Runtime.Enviorment.AppDomain appdomain;
        public Adaptor()
        {
        }
        public Adaptor(CSHotFix.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
        {
            this.appdomain = appdomain;
            this.instance = instance;
        }
        public ILTypeInstance ILInstance
        {
            get { return instance; }
        }
        IMethod m_moveNextMethod;
        bool m_moveNextMethodGot;
        public bool MoveNext()
        {
            if (!m_moveNextMethodGot)
            {
                m_moveNextMethod = instance.Type.GetMethod("MoveNext", 0);
                m_moveNextMethodGot = true;
            }
            if (m_moveNextMethod != null)
                return (bool)appdomain.Invoke(m_moveNextMethod, instance, null);
            return false;
        }
        IMethod m_resetMethod;
        bool m_resetMethodGot;
        public void Reset()
        {
            if (!m_resetMethodGot)
            {
                m_resetMethod = instance.Type.GetMethod("Reset", 0);
                m_resetMethodGot = true;
            }
            if (m_resetMethod != null)
                appdomain.Invoke(m_resetMethod, instance, null);
        }
        IMethod m_getCurrentMethod;
        bool m_getCurrentMethodGot;
        public object Current
        {
            get
            {
                if (!m_getCurrentMethodGot)
                {
                    m_getCurrentMethod = instance.Type.GetMethod("get_Current", 0);
                    if (m_getCurrentMethod == null)
                    {
                        //如果实现的是System.Collections.IEnumerator接口，则用下面的读取方式
                        m_getCurrentMethod = instance.Type.GetMethod("System.Collections.IEnumerator.get_Current", 0);
                    }
                    m_getCurrentMethodGot = true;
                }
                if (m_getCurrentMethod != null)
                    return (object)appdomain.Invoke(m_getCurrentMethod, instance, null);
                return null;
            }
        }
        IMethod m_disposeMethod;
        bool m_disposeMethodGot;
        public void Dispose()
        {
            if (!m_disposeMethodGot)
            {
                m_disposeMethod = instance.Type.GetMethod("Dispose", 0);
                if (m_disposeMethod == null)
                {
                    //如果实现的是System.IDisposable接口，则用下面的读取方式
                    m_disposeMethod = instance.Type.GetMethod("System.IDisposable.Dispose", 0);
                }
                m_disposeMethodGot = true;
            }
            if (m_disposeMethod != null)
                appdomain.Invoke(m_disposeMethod, instance, null);
        }
    }
}