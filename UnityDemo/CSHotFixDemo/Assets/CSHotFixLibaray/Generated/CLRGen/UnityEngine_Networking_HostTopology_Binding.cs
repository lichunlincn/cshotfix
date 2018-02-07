
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
    unsafe class UnityEngine_Networking_HostTopology_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Networking.HostTopology);
            args = new Type[]{};
            method = type.GetMethod("get_DefaultConfig", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_DefaultConfig_0);
            args = new Type[]{};
            method = type.GetMethod("get_MaxDefaultConnections", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaxDefaultConnections_1);
            args = new Type[]{};
            method = type.GetMethod("get_SpecialConnectionConfigsCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_SpecialConnectionConfigsCount_2);
            args = new Type[]{};
            method = type.GetMethod("get_SpecialConnectionConfigs", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_SpecialConnectionConfigs_3);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetSpecialConnectionConfig", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSpecialConnectionConfig_4);
            args = new Type[]{};
            method = type.GetMethod("get_ReceivedMessagePoolSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ReceivedMessagePoolSize_5);
            args = new Type[]{typeof(System.UInt16)};
            method = type.GetMethod("set_ReceivedMessagePoolSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ReceivedMessagePoolSize_6);
            args = new Type[]{};
            method = type.GetMethod("get_SentMessagePoolSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_SentMessagePoolSize_7);
            args = new Type[]{typeof(System.UInt16)};
            method = type.GetMethod("set_SentMessagePoolSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_SentMessagePoolSize_8);
            args = new Type[]{};
            method = type.GetMethod("get_MessagePoolSizeGrowthFactor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MessagePoolSizeGrowthFactor_9);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_MessagePoolSizeGrowthFactor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MessagePoolSizeGrowthFactor_10);
            args = new Type[]{typeof(UnityEngine.Networking.ConnectionConfig)};
            method = type.GetMethod("AddSpecialConnectionConfig", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddSpecialConnectionConfig_11);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Networking.HostTopology[s]);

            args = new Type[]{typeof(UnityEngine.Networking.ConnectionConfig), typeof(System.Int32)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_DefaultConfig_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.HostTopology instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.HostTopology)typeof(UnityEngine.Networking.HostTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DefaultConfig;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_MaxDefaultConnections_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.HostTopology instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.HostTopology)typeof(UnityEngine.Networking.HostTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MaxDefaultConnections;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_SpecialConnectionConfigsCount_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.HostTopology instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.HostTopology)typeof(UnityEngine.Networking.HostTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SpecialConnectionConfigsCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_SpecialConnectionConfigs_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.HostTopology instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.HostTopology)typeof(UnityEngine.Networking.HostTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SpecialConnectionConfigs;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetSpecialConnectionConfig_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 i = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.HostTopology instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.HostTopology)typeof(UnityEngine.Networking.HostTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetSpecialConnectionConfig(i);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_ReceivedMessagePoolSize_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.HostTopology instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.HostTopology)typeof(UnityEngine.Networking.HostTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ReceivedMessagePoolSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_ReceivedMessagePoolSize_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt16 value = (ushort)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.HostTopology instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.HostTopology)typeof(UnityEngine.Networking.HostTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ReceivedMessagePoolSize = value;

            return __ret;
        }

        static StackObject* get_SentMessagePoolSize_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.HostTopology instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.HostTopology)typeof(UnityEngine.Networking.HostTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SentMessagePoolSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_SentMessagePoolSize_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt16 value = (ushort)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.HostTopology instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.HostTopology)typeof(UnityEngine.Networking.HostTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SentMessagePoolSize = value;

            return __ret;
        }

        static StackObject* get_MessagePoolSizeGrowthFactor_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.HostTopology instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.HostTopology)typeof(UnityEngine.Networking.HostTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MessagePoolSizeGrowthFactor;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_MessagePoolSizeGrowthFactor_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.HostTopology instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.HostTopology)typeof(UnityEngine.Networking.HostTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MessagePoolSizeGrowthFactor = value;

            return __ret;
        }

        static StackObject* AddSpecialConnectionConfig_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig config = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.HostTopology instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.HostTopology)typeof(UnityEngine.Networking.HostTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AddSpecialConnectionConfig(config);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 maxDefaultConnections = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig defaultConfig = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new UnityEngine.Networking.HostTopology(defaultConfig, maxDefaultConnections);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
