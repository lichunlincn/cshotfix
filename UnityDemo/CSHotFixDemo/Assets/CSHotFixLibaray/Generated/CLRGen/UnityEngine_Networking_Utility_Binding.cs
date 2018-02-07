
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
    unsafe class UnityEngine_Networking_Utility_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Networking.Utility);
            args = new Type[]{};
            method = type.GetMethod("GetSourceID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSourceID_0);
            args = new Type[]{typeof(UnityEngine.Networking.Types.NetworkID), typeof(UnityEngine.Networking.Types.NetworkAccessToken)};
            method = type.GetMethod("SetAccessTokenForNetwork", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAccessTokenForNetwork_1);
            args = new Type[]{typeof(UnityEngine.Networking.Types.NetworkID)};
            method = type.GetMethod("GetAccessTokenForNetwork", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAccessTokenForNetwork_2);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Networking.Utility[s]);


        }


        static StackObject* GetSourceID_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Networking.Utility.GetSourceID();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetAccessTokenForNetwork_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.Types.NetworkAccessToken accessToken = (UnityEngine.Networking.Types.NetworkAccessToken)typeof(UnityEngine.Networking.Types.NetworkAccessToken).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.Types.NetworkID netId = (UnityEngine.Networking.Types.NetworkID)typeof(UnityEngine.Networking.Types.NetworkID).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Networking.Utility.SetAccessTokenForNetwork(netId, accessToken);

            return __ret;
        }

        static StackObject* GetAccessTokenForNetwork_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.Types.NetworkID netId = (UnityEngine.Networking.Types.NetworkID)typeof(UnityEngine.Networking.Types.NetworkID).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.Networking.Utility.GetAccessTokenForNetwork(netId);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}
