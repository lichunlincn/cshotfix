
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
    unsafe class LCL_PrefabHolder_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(LCL.PrefabHolder);
            args = new Type[]{};
            method = type.GetMethod("GetPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPrefab_0);
            args = new Type[]{typeof(UnityEngine.Events.UnityEvent)};
            method = type.GetMethod("AddLoadedCall", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddLoadedCall_1);

            field = type.GetField("Parent", flag);
            app.RegisterCLRFieldGetter(field, get_Parent_0);
            app.RegisterCLRFieldSetter(field, set_Parent_0);
            field = type.GetField("Asset", flag);
            app.RegisterCLRFieldGetter(field, get_Asset_1);
            app.RegisterCLRFieldSetter(field, set_Asset_1);
            field = type.GetField("InnerCall", flag);
            app.RegisterCLRFieldGetter(field, get_InnerCall_2);
            app.RegisterCLRFieldSetter(field, set_InnerCall_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new LCL.PrefabHolder());
            app.RegisterCLRCreateArrayInstance(type, s => new LCL.PrefabHolder[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* GetPrefab_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LCL.PrefabHolder instance_of_this_method = (LCL.PrefabHolder)typeof(LCL.PrefabHolder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPrefab();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AddLoadedCall_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Events.UnityEvent @call = (UnityEngine.Events.UnityEvent)typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            LCL.PrefabHolder instance_of_this_method = (LCL.PrefabHolder)typeof(LCL.PrefabHolder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddLoadedCall(@call);

            return __ret;
        }


        static object get_Parent_0(ref object o)
        {
            return ((LCL.PrefabHolder)o).Parent;
        }
        static void set_Parent_0(ref object o, object v)
        {
LCL.PrefabHolder _o = (LCL.PrefabHolder)o;
    _o.Parent = (UnityEngine.GameObject)v;
        }
        static object get_Asset_1(ref object o)
        {
            return ((LCL.PrefabHolder)o).Asset;
        }
        static void set_Asset_1(ref object o, object v)
        {
LCL.PrefabHolder _o = (LCL.PrefabHolder)o;
    _o.Asset = (UnityEngine.GameObject)v;
        }
        static object get_InnerCall_2(ref object o)
        {
            return ((LCL.PrefabHolder)o).InnerCall;
        }
        static void set_InnerCall_2(ref object o, object v)
        {
LCL.PrefabHolder _o = (LCL.PrefabHolder)o;
    _o.InnerCall = (UnityEngine.Events.UnityEvent)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new LCL.PrefabHolder();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
