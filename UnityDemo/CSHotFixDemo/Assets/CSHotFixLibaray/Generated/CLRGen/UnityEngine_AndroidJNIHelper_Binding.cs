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
    unsafe class UnityEngine_AndroidJNIHelper_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.AndroidJNIHelper);
            args = new Type[]{};
            method = type.GetMethod("get_debug", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_debug_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_debug", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_debug_1);
            args = new Type[]{typeof(System.Object[])};
            method = type.GetMethod("CreateJNIArgArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateJNIArgArray_2);
            args = new Type[]{typeof(System.Object[]), typeof(UnityEngine.jvalue[])};
            method = type.GetMethod("DeleteJNIArgArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DeleteJNIArgArray_3);
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("GetSignature", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSignature_4);
            args = new Type[]{typeof(System.Object[])};
            method = type.GetMethod("GetSignature", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSignature_5);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AndroidJNIHelper[s]);


        }


        static StackObject* get_debug_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.AndroidJNIHelper.debug;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_debug_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;

            UnityEngine.AndroidJNIHelper.debug = value;

            return __ret;
        }

        static StackObject* CreateJNIArgArray_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object[] args = (System.Object[])typeof(System.Object[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.AndroidJNIHelper.CreateJNIArgArray(args);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* DeleteJNIArgArray_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.jvalue[] jniArgs = (UnityEngine.jvalue[])typeof(UnityEngine.jvalue[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Object[] args = (System.Object[])typeof(System.Object[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.AndroidJNIHelper.DeleteJNIArgArray(args, jniArgs);

            return __ret;
        }

        static StackObject* GetSignature_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object obj = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.AndroidJNIHelper.GetSignature(obj);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetSignature_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object[] args = (System.Object[])typeof(System.Object[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.AndroidJNIHelper.GetSignature(args);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}
