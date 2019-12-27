
#if CSHotFix
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using CSHotFix.CLR.TypeSystem;
using CSHotFix.CLR.Method;
using CSHotFix.Runtime.Enviorment;
using CSHotFix.Runtime.Intepreter;
using CSHotFix.Runtime.Stack;
using CSHotFix.Reflection;
using CSHotFix.CLR.Utils;
using System.Linq;
namespace CSHotFix.Runtime.Generated
{
    unsafe class LCL_DetachGoChild_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(LCL.DetachGoChild);
            args = new Type[]{};
            method = type.GetMethod("Detach", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Detach_0);
            args = new Type[]{};
            method = type.GetMethod("OnDetach", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnDetach_1);
            args = new Type[]{};
            method = type.GetMethod("OnParentPositionDirty", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnParentPositionDirty_2);
            args = new Type[]{};
            method = type.GetMethod("OnParentRotationDirty", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnParentRotationDirty_3);
            args = new Type[]{};
            method = type.GetMethod("OnParentScaleDirty", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnParentScaleDirty_4);
            args = new Type[]{};
            method = type.GetMethod("Attach", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Attach_5);
            args = new Type[]{};
            method = type.GetMethod("OnAttach", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnAttach_6);
            args = new Type[]{};
            method = type.GetMethod("OnParentDestroy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnParentDestroy_7);

            field = type.GetField("m_DetachGoParent", flag);
            app.RegisterCLRFieldGetter(field, get_m_DetachGoParent_0);
            app.RegisterCLRFieldSetter(field, set_m_DetachGoParent_0);
            field = type.GetField("m_DetachFromParent", flag);
            app.RegisterCLRFieldGetter(field, get_m_DetachFromParent_1);
            app.RegisterCLRFieldSetter(field, set_m_DetachFromParent_1);
            field = type.GetField("m_DelayDestroy", flag);
            app.RegisterCLRFieldGetter(field, get_m_DelayDestroy_2);
            app.RegisterCLRFieldSetter(field, set_m_DelayDestroy_2);
            field = type.GetField("m_DelayTime", flag);
            app.RegisterCLRFieldGetter(field, get_m_DelayTime_3);
            app.RegisterCLRFieldSetter(field, set_m_DelayTime_3);


            app.RegisterCLRCreateDefaultInstance(type, () => new LCL.DetachGoChild());
            app.RegisterCLRCreateArrayInstance(type, s => new LCL.DetachGoChild[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Detach_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LCL.DetachGoChild instance_of_this_method = (LCL.DetachGoChild)typeof(LCL.DetachGoChild).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Detach();

            return __ret;
        }

        static StackObject* OnDetach_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LCL.DetachGoChild instance_of_this_method = (LCL.DetachGoChild)typeof(LCL.DetachGoChild).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnDetach();

            return __ret;
        }

        static StackObject* OnParentPositionDirty_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LCL.DetachGoChild instance_of_this_method = (LCL.DetachGoChild)typeof(LCL.DetachGoChild).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnParentPositionDirty();

            return __ret;
        }

        static StackObject* OnParentRotationDirty_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LCL.DetachGoChild instance_of_this_method = (LCL.DetachGoChild)typeof(LCL.DetachGoChild).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnParentRotationDirty();

            return __ret;
        }

        static StackObject* OnParentScaleDirty_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LCL.DetachGoChild instance_of_this_method = (LCL.DetachGoChild)typeof(LCL.DetachGoChild).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnParentScaleDirty();

            return __ret;
        }

        static StackObject* Attach_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LCL.DetachGoChild instance_of_this_method = (LCL.DetachGoChild)typeof(LCL.DetachGoChild).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Attach();

            return __ret;
        }

        static StackObject* OnAttach_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LCL.DetachGoChild instance_of_this_method = (LCL.DetachGoChild)typeof(LCL.DetachGoChild).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnAttach();

            return __ret;
        }

        static StackObject* OnParentDestroy_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LCL.DetachGoChild instance_of_this_method = (LCL.DetachGoChild)typeof(LCL.DetachGoChild).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnParentDestroy();

            return __ret;
        }


        static object get_m_DetachGoParent_0(ref object o)
        {
            return ((LCL.DetachGoChild)o).m_DetachGoParent;
        }
        static void set_m_DetachGoParent_0(ref object o, object v)
        {
LCL.DetachGoChild _o = (LCL.DetachGoChild)o;
    _o.m_DetachGoParent = (LCL.DetachGoParent)v;
        }
        static object get_m_DetachFromParent_1(ref object o)
        {
            return ((LCL.DetachGoChild)o).m_DetachFromParent;
        }
        static void set_m_DetachFromParent_1(ref object o, object v)
        {
LCL.DetachGoChild _o = (LCL.DetachGoChild)o;
    _o.m_DetachFromParent = (System.Boolean)v;
        }
        static object get_m_DelayDestroy_2(ref object o)
        {
            return ((LCL.DetachGoChild)o).m_DelayDestroy;
        }
        static void set_m_DelayDestroy_2(ref object o, object v)
        {
LCL.DetachGoChild _o = (LCL.DetachGoChild)o;
    _o.m_DelayDestroy = (System.Boolean)v;
        }
        static object get_m_DelayTime_3(ref object o)
        {
            return ((LCL.DetachGoChild)o).m_DelayTime;
        }
        static void set_m_DelayTime_3(ref object o, object v)
        {
LCL.DetachGoChild _o = (LCL.DetachGoChild)o;
    _o.m_DelayTime = (System.Single)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new LCL.DetachGoChild();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
