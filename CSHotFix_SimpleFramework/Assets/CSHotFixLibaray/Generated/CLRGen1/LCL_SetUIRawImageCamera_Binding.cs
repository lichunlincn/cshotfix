
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
    unsafe class LCL_SetUIRawImageCamera_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(LCL.SetUIRawImageCamera);
            args = new Type[]{};
            method = type.GetMethod("OnSetRawImageCamera", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnSetRawImageCamera_0);

            field = type.GetField("m_Image", flag);
            app.RegisterCLRFieldGetter(field, get_m_Image_0);
            app.RegisterCLRFieldSetter(field, set_m_Image_0);
            field = type.GetField("m_Prefab", flag);
            app.RegisterCLRFieldGetter(field, get_m_Prefab_1);
            app.RegisterCLRFieldSetter(field, set_m_Prefab_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new LCL.SetUIRawImageCamera());
            app.RegisterCLRCreateArrayInstance(type, s => new LCL.SetUIRawImageCamera[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* OnSetRawImageCamera_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LCL.SetUIRawImageCamera instance_of_this_method = (LCL.SetUIRawImageCamera)typeof(LCL.SetUIRawImageCamera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnSetRawImageCamera();

            return __ret;
        }


        static object get_m_Image_0(ref object o)
        {
            return ((LCL.SetUIRawImageCamera)o).m_Image;
        }
        static void set_m_Image_0(ref object o, object v)
        {
LCL.SetUIRawImageCamera _o = (LCL.SetUIRawImageCamera)o;
    _o.m_Image = (UnityEngine.UI.RawImage)v;
        }
        static object get_m_Prefab_1(ref object o)
        {
            return ((LCL.SetUIRawImageCamera)o).m_Prefab;
        }
        static void set_m_Prefab_1(ref object o, object v)
        {
LCL.SetUIRawImageCamera _o = (LCL.SetUIRawImageCamera)o;
    _o.m_Prefab = (LCL.PrefabHolder)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new LCL.SetUIRawImageCamera();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
