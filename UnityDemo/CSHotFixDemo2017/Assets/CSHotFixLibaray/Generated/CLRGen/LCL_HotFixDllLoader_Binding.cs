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

namespace CSHotFix.Runtime.Generated
{
    unsafe class LCL_HotFixDllLoader_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(LCL.HotFixDllLoader);
            args = new Type[]{};
            method = type.GetMethod("Init", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Init_0);

            field = type.GetField("HotFixDll", flag);
            app.RegisterCLRFieldGetter(field, get_HotFixDll_0);
            app.RegisterCLRFieldSetter(field, set_HotFixDll_0);
            field = type.GetField("HotFixDllMdb", flag);
            app.RegisterCLRFieldGetter(field, get_HotFixDllMdb_1);
            app.RegisterCLRFieldSetter(field, set_HotFixDllMdb_1);
            field = type.GetField("IsHotFix", flag);
            app.RegisterCLRFieldGetter(field, get_IsHotFix_2);
            app.RegisterCLRFieldSetter(field, set_IsHotFix_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new LCL.HotFixDllLoader());
            app.RegisterCLRCreateArrayInstance(type, s => new LCL.HotFixDllLoader[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Init_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LCL.HotFixDllLoader instance_of_this_method;
            instance_of_this_method = (LCL.HotFixDllLoader)typeof(LCL.HotFixDllLoader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Init();

            return __ret;
        }


        static object get_HotFixDll_0(ref object o)
        {
            return ((LCL.HotFixDllLoader)o).HotFixDll;
        }
        static void set_HotFixDll_0(ref object o, object v)
        {
LCL.HotFixDllLoader _o = (LCL.HotFixDllLoader)o;
    _o.HotFixDll = (UnityEngine.TextAsset)v;
        }
        static object get_HotFixDllMdb_1(ref object o)
        {
            return ((LCL.HotFixDllLoader)o).HotFixDllMdb;
        }
        static void set_HotFixDllMdb_1(ref object o, object v)
        {
LCL.HotFixDllLoader _o = (LCL.HotFixDllLoader)o;
    _o.HotFixDllMdb = (UnityEngine.TextAsset)v;
        }
        static object get_IsHotFix_2(ref object o)
        {
            return LCL.HotFixDllLoader.IsHotFix;
        }
        static void set_IsHotFix_2(ref object o, object v)
        {
            LCL.HotFixDllLoader.IsHotFix = (System.Boolean)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new LCL.HotFixDllLoader();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
