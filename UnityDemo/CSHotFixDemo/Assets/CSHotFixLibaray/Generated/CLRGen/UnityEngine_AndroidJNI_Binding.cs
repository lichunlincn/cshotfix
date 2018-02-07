
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
    unsafe class UnityEngine_AndroidJNI_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.AndroidJNI);
            args = new Type[]{};
            method = type.GetMethod("AttachCurrentThread", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AttachCurrentThread_0);
            args = new Type[]{};
            method = type.GetMethod("DetachCurrentThread", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DetachCurrentThread_1);
            args = new Type[]{};
            method = type.GetMethod("GetVersion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetVersion_2);
            args = new Type[]{};
            method = type.GetMethod("ExceptionDescribe", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ExceptionDescribe_3);
            args = new Type[]{};
            method = type.GetMethod("ExceptionClear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ExceptionClear_4);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("FatalError", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FatalError_5);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("PushLocalFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PushLocalFrame_6);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("EnsureLocalCapacity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EnsureLocalCapacity_7);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AndroidJNI[s]);


        }


        static StackObject* AttachCurrentThread_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.AndroidJNI.AttachCurrentThread();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* DetachCurrentThread_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.AndroidJNI.DetachCurrentThread();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetVersion_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.AndroidJNI.GetVersion();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* ExceptionDescribe_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            UnityEngine.AndroidJNI.ExceptionDescribe();

            return __ret;
        }

        static StackObject* ExceptionClear_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            UnityEngine.AndroidJNI.ExceptionClear();

            return __ret;
        }

        static StackObject* FatalError_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.AndroidJNI.FatalError(message);

            return __ret;
        }

        static StackObject* PushLocalFrame_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 capacity = ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.AndroidJNI.PushLocalFrame(capacity);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* EnsureLocalCapacity_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 capacity = ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.AndroidJNI.EnsureLocalCapacity(capacity);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }





    }
}
