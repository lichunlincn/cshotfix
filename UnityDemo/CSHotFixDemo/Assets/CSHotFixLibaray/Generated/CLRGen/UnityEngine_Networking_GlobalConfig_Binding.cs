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
    unsafe class UnityEngine_Networking_GlobalConfig_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Networking.GlobalConfig);
            args = new Type[]{};
            method = type.GetMethod("get_ThreadAwakeTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ThreadAwakeTimeout_0);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("set_ThreadAwakeTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ThreadAwakeTimeout_1);
            args = new Type[]{};
            method = type.GetMethod("get_ReactorModel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ReactorModel_2);
            args = new Type[]{typeof(UnityEngine.Networking.ReactorModel)};
            method = type.GetMethod("set_ReactorModel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ReactorModel_3);
            args = new Type[]{};
            method = type.GetMethod("get_ReactorMaximumReceivedMessages", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ReactorMaximumReceivedMessages_4);
            args = new Type[]{typeof(System.UInt16)};
            method = type.GetMethod("set_ReactorMaximumReceivedMessages", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ReactorMaximumReceivedMessages_5);
            args = new Type[]{};
            method = type.GetMethod("get_ReactorMaximumSentMessages", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ReactorMaximumSentMessages_6);
            args = new Type[]{typeof(System.UInt16)};
            method = type.GetMethod("set_ReactorMaximumSentMessages", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ReactorMaximumSentMessages_7);
            args = new Type[]{};
            method = type.GetMethod("get_MaxPacketSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaxPacketSize_8);
            args = new Type[]{typeof(System.UInt16)};
            method = type.GetMethod("set_MaxPacketSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MaxPacketSize_9);
            args = new Type[]{};
            method = type.GetMethod("get_MaxHosts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaxHosts_10);
            args = new Type[]{typeof(System.UInt16)};
            method = type.GetMethod("set_MaxHosts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MaxHosts_11);
            args = new Type[]{};
            method = type.GetMethod("get_ThreadPoolSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ThreadPoolSize_12);
            args = new Type[]{typeof(System.Byte)};
            method = type.GetMethod("set_ThreadPoolSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ThreadPoolSize_13);
            args = new Type[]{};
            method = type.GetMethod("get_MinTimerTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MinTimerTimeout_14);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("set_MinTimerTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MinTimerTimeout_15);
            args = new Type[]{};
            method = type.GetMethod("get_MaxTimerTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaxTimerTimeout_16);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("set_MaxTimerTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MaxTimerTimeout_17);
            args = new Type[]{};
            method = type.GetMethod("get_MinNetSimulatorTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MinNetSimulatorTimeout_18);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("set_MinNetSimulatorTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MinNetSimulatorTimeout_19);
            args = new Type[]{};
            method = type.GetMethod("get_MaxNetSimulatorTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaxNetSimulatorTimeout_20);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("set_MaxNetSimulatorTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MaxNetSimulatorTimeout_21);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Networking.GlobalConfig());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Networking.GlobalConfig[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_ThreadAwakeTimeout_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ThreadAwakeTimeout;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_ThreadAwakeTimeout_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 value = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ThreadAwakeTimeout = value;

            return __ret;
        }

        static StackObject* get_ReactorModel_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ReactorModel;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_ReactorModel_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ReactorModel value = (UnityEngine.Networking.ReactorModel)typeof(UnityEngine.Networking.ReactorModel).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ReactorModel = value;

            return __ret;
        }

        static StackObject* get_ReactorMaximumReceivedMessages_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ReactorMaximumReceivedMessages;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_ReactorMaximumReceivedMessages_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt16 value = (ushort)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ReactorMaximumReceivedMessages = value;

            return __ret;
        }

        static StackObject* get_ReactorMaximumSentMessages_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ReactorMaximumSentMessages;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_ReactorMaximumSentMessages_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt16 value = (ushort)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ReactorMaximumSentMessages = value;

            return __ret;
        }

        static StackObject* get_MaxPacketSize_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MaxPacketSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_MaxPacketSize_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt16 value = (ushort)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MaxPacketSize = value;

            return __ret;
        }

        static StackObject* get_MaxHosts_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MaxHosts;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_MaxHosts_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt16 value = (ushort)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MaxHosts = value;

            return __ret;
        }

        static StackObject* get_ThreadPoolSize_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ThreadPoolSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_ThreadPoolSize_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Byte value = (byte)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ThreadPoolSize = value;

            return __ret;
        }

        static StackObject* get_MinTimerTimeout_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MinTimerTimeout;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_MinTimerTimeout_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 value = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MinTimerTimeout = value;

            return __ret;
        }

        static StackObject* get_MaxTimerTimeout_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MaxTimerTimeout;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_MaxTimerTimeout_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 value = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MaxTimerTimeout = value;

            return __ret;
        }

        static StackObject* get_MinNetSimulatorTimeout_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MinNetSimulatorTimeout;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_MinNetSimulatorTimeout_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 value = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MinNetSimulatorTimeout = value;

            return __ret;
        }

        static StackObject* get_MaxNetSimulatorTimeout_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MaxNetSimulatorTimeout;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_MaxNetSimulatorTimeout_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 value = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.GlobalConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.GlobalConfig)typeof(UnityEngine.Networking.GlobalConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MaxNetSimulatorTimeout = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Networking.GlobalConfig();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
