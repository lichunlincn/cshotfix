
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
    unsafe class UnityEngine_MasterServerEvent_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.MasterServerEvent);

            field = type.GetField("RegistrationFailedGameName", flag);
            app.RegisterCLRFieldGetter(field, get_RegistrationFailedGameName_0);
            field = type.GetField("RegistrationFailedGameType", flag);
            app.RegisterCLRFieldGetter(field, get_RegistrationFailedGameType_1);
            field = type.GetField("RegistrationFailedNoServer", flag);
            app.RegisterCLRFieldGetter(field, get_RegistrationFailedNoServer_2);
            field = type.GetField("RegistrationSucceeded", flag);
            app.RegisterCLRFieldGetter(field, get_RegistrationSucceeded_3);
            field = type.GetField("HostListReceived", flag);
            app.RegisterCLRFieldGetter(field, get_HostListReceived_4);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.MasterServerEvent());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.MasterServerEvent[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.MasterServerEvent instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.MasterServerEvent[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_RegistrationFailedGameName_0(ref object o)
        {
            return UnityEngine.MasterServerEvent.RegistrationFailedGameName;
        }
        static object get_RegistrationFailedGameType_1(ref object o)
        {
            return UnityEngine.MasterServerEvent.RegistrationFailedGameType;
        }
        static object get_RegistrationFailedNoServer_2(ref object o)
        {
            return UnityEngine.MasterServerEvent.RegistrationFailedNoServer;
        }
        static object get_RegistrationSucceeded_3(ref object o)
        {
            return UnityEngine.MasterServerEvent.RegistrationSucceeded;
        }
        static object get_HostListReceived_4(ref object o)
        {
            return UnityEngine.MasterServerEvent.HostListReceived;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.MasterServerEvent();
            ins = (UnityEngine.MasterServerEvent)o;
            return ins;
        }


    }
}
#endif
