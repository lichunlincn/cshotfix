
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

namespace CSHotFix.Runtime.Generated
{
    unsafe class UnityEngine_NetworkConnectionError_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.NetworkConnectionError);

            field = type.GetField("NoError", flag);
            app.RegisterCLRFieldGetter(field, get_NoError_0);
            field = type.GetField("RSAPublicKeyMismatch", flag);
            app.RegisterCLRFieldGetter(field, get_RSAPublicKeyMismatch_1);
            field = type.GetField("InvalidPassword", flag);
            app.RegisterCLRFieldGetter(field, get_InvalidPassword_2);
            field = type.GetField("ConnectionFailed", flag);
            app.RegisterCLRFieldGetter(field, get_ConnectionFailed_3);
            field = type.GetField("TooManyConnectedPlayers", flag);
            app.RegisterCLRFieldGetter(field, get_TooManyConnectedPlayers_4);
            field = type.GetField("ConnectionBanned", flag);
            app.RegisterCLRFieldGetter(field, get_ConnectionBanned_5);
            field = type.GetField("AlreadyConnectedToServer", flag);
            app.RegisterCLRFieldGetter(field, get_AlreadyConnectedToServer_6);
            field = type.GetField("AlreadyConnectedToAnotherServer", flag);
            app.RegisterCLRFieldGetter(field, get_AlreadyConnectedToAnotherServer_7);
            field = type.GetField("CreateSocketOrThreadFailure", flag);
            app.RegisterCLRFieldGetter(field, get_CreateSocketOrThreadFailure_8);
            field = type.GetField("IncorrectParameters", flag);
            app.RegisterCLRFieldGetter(field, get_IncorrectParameters_9);
            field = type.GetField("EmptyConnectTarget", flag);
            app.RegisterCLRFieldGetter(field, get_EmptyConnectTarget_10);
            field = type.GetField("InternalDirectConnectFailed", flag);
            app.RegisterCLRFieldGetter(field, get_InternalDirectConnectFailed_11);
            field = type.GetField("NATTargetNotConnected", flag);
            app.RegisterCLRFieldGetter(field, get_NATTargetNotConnected_12);
            field = type.GetField("NATTargetConnectionLost", flag);
            app.RegisterCLRFieldGetter(field, get_NATTargetConnectionLost_13);
            field = type.GetField("NATPunchthroughFailed", flag);
            app.RegisterCLRFieldGetter(field, get_NATPunchthroughFailed_14);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.NetworkConnectionError());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.NetworkConnectionError[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.NetworkConnectionError instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.NetworkConnectionError[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_NoError_0(ref object o)
        {
            return UnityEngine.NetworkConnectionError.NoError;
        }
        static object get_RSAPublicKeyMismatch_1(ref object o)
        {
            return UnityEngine.NetworkConnectionError.RSAPublicKeyMismatch;
        }
        static object get_InvalidPassword_2(ref object o)
        {
            return UnityEngine.NetworkConnectionError.InvalidPassword;
        }
        static object get_ConnectionFailed_3(ref object o)
        {
            return UnityEngine.NetworkConnectionError.ConnectionFailed;
        }
        static object get_TooManyConnectedPlayers_4(ref object o)
        {
            return UnityEngine.NetworkConnectionError.TooManyConnectedPlayers;
        }
        static object get_ConnectionBanned_5(ref object o)
        {
            return UnityEngine.NetworkConnectionError.ConnectionBanned;
        }
        static object get_AlreadyConnectedToServer_6(ref object o)
        {
            return UnityEngine.NetworkConnectionError.AlreadyConnectedToServer;
        }
        static object get_AlreadyConnectedToAnotherServer_7(ref object o)
        {
            return UnityEngine.NetworkConnectionError.AlreadyConnectedToAnotherServer;
        }
        static object get_CreateSocketOrThreadFailure_8(ref object o)
        {
            return UnityEngine.NetworkConnectionError.CreateSocketOrThreadFailure;
        }
        static object get_IncorrectParameters_9(ref object o)
        {
            return UnityEngine.NetworkConnectionError.IncorrectParameters;
        }
        static object get_EmptyConnectTarget_10(ref object o)
        {
            return UnityEngine.NetworkConnectionError.EmptyConnectTarget;
        }
        static object get_InternalDirectConnectFailed_11(ref object o)
        {
            return UnityEngine.NetworkConnectionError.InternalDirectConnectFailed;
        }
        static object get_NATTargetNotConnected_12(ref object o)
        {
            return UnityEngine.NetworkConnectionError.NATTargetNotConnected;
        }
        static object get_NATTargetConnectionLost_13(ref object o)
        {
            return UnityEngine.NetworkConnectionError.NATTargetConnectionLost;
        }
        static object get_NATPunchthroughFailed_14(ref object o)
        {
            return UnityEngine.NetworkConnectionError.NATPunchthroughFailed;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.NetworkConnectionError();
            ins = (UnityEngine.NetworkConnectionError)o;
            return ins;
        }


    }
}
#endif
