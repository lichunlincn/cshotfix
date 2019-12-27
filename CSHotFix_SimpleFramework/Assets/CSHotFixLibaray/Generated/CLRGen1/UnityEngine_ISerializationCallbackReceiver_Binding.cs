
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
    unsafe class UnityEngine_ISerializationCallbackReceiver_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.ISerializationCallbackReceiver);
            args = new Type[]{};
            method = type.GetMethod("OnBeforeSerialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnBeforeSerialize_0);
            args = new Type[]{};
            method = type.GetMethod("OnAfterDeserialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnAfterDeserialize_1);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ISerializationCallbackReceiver[s]);


        }


        static StackObject* OnBeforeSerialize_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ISerializationCallbackReceiver instance_of_this_method = (UnityEngine.ISerializationCallbackReceiver)typeof(UnityEngine.ISerializationCallbackReceiver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnBeforeSerialize();

            return __ret;
        }

        static StackObject* OnAfterDeserialize_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ISerializationCallbackReceiver instance_of_this_method = (UnityEngine.ISerializationCallbackReceiver)typeof(UnityEngine.ISerializationCallbackReceiver).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnAfterDeserialize();

            return __ret;
        }





    }
}
#endif
