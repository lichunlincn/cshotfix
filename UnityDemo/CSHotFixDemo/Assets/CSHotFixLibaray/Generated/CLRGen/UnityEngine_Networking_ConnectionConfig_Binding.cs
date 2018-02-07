
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
    unsafe class UnityEngine_Networking_ConnectionConfig_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Networking.ConnectionConfig);
            args = new Type[]{typeof(UnityEngine.Networking.ConnectionConfig)};
            method = type.GetMethod("Validate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Validate_0);
            args = new Type[]{};
            method = type.GetMethod("get_PacketSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_PacketSize_1);
            args = new Type[]{typeof(System.UInt16)};
            method = type.GetMethod("set_PacketSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_PacketSize_2);
            args = new Type[]{};
            method = type.GetMethod("get_FragmentSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_FragmentSize_3);
            args = new Type[]{typeof(System.UInt16)};
            method = type.GetMethod("set_FragmentSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_FragmentSize_4);
            args = new Type[]{};
            method = type.GetMethod("get_ResendTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ResendTimeout_5);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("set_ResendTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ResendTimeout_6);
            args = new Type[]{};
            method = type.GetMethod("get_DisconnectTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_DisconnectTimeout_7);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("set_DisconnectTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_DisconnectTimeout_8);
            args = new Type[]{};
            method = type.GetMethod("get_ConnectTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ConnectTimeout_9);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("set_ConnectTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ConnectTimeout_10);
            args = new Type[]{};
            method = type.GetMethod("get_MinUpdateTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MinUpdateTimeout_11);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("set_MinUpdateTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MinUpdateTimeout_12);
            args = new Type[]{};
            method = type.GetMethod("get_PingTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_PingTimeout_13);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("set_PingTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_PingTimeout_14);
            args = new Type[]{};
            method = type.GetMethod("get_ReducedPingTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ReducedPingTimeout_15);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("set_ReducedPingTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ReducedPingTimeout_16);
            args = new Type[]{};
            method = type.GetMethod("get_AllCostTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AllCostTimeout_17);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("set_AllCostTimeout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_AllCostTimeout_18);
            args = new Type[]{};
            method = type.GetMethod("get_NetworkDropThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_NetworkDropThreshold_19);
            args = new Type[]{typeof(System.Byte)};
            method = type.GetMethod("set_NetworkDropThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_NetworkDropThreshold_20);
            args = new Type[]{};
            method = type.GetMethod("get_OverflowDropThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_OverflowDropThreshold_21);
            args = new Type[]{typeof(System.Byte)};
            method = type.GetMethod("set_OverflowDropThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_OverflowDropThreshold_22);
            args = new Type[]{};
            method = type.GetMethod("get_MaxConnectionAttempt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaxConnectionAttempt_23);
            args = new Type[]{typeof(System.Byte)};
            method = type.GetMethod("set_MaxConnectionAttempt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MaxConnectionAttempt_24);
            args = new Type[]{};
            method = type.GetMethod("get_AckDelay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AckDelay_25);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("set_AckDelay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_AckDelay_26);
            args = new Type[]{};
            method = type.GetMethod("get_SendDelay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_SendDelay_27);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("set_SendDelay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_SendDelay_28);
            args = new Type[]{};
            method = type.GetMethod("get_MaxCombinedReliableMessageSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaxCombinedReliableMessageSize_29);
            args = new Type[]{typeof(System.UInt16)};
            method = type.GetMethod("set_MaxCombinedReliableMessageSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MaxCombinedReliableMessageSize_30);
            args = new Type[]{};
            method = type.GetMethod("get_MaxCombinedReliableMessageCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaxCombinedReliableMessageCount_31);
            args = new Type[]{typeof(System.UInt16)};
            method = type.GetMethod("set_MaxCombinedReliableMessageCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MaxCombinedReliableMessageCount_32);
            args = new Type[]{};
            method = type.GetMethod("get_MaxSentMessageQueueSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaxSentMessageQueueSize_33);
            args = new Type[]{typeof(System.UInt16)};
            method = type.GetMethod("set_MaxSentMessageQueueSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MaxSentMessageQueueSize_34);
            args = new Type[]{};
            method = type.GetMethod("get_AcksType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AcksType_35);
            args = new Type[]{typeof(UnityEngine.Networking.ConnectionAcksType)};
            method = type.GetMethod("set_AcksType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_AcksType_36);
            args = new Type[]{};
            method = type.GetMethod("get_UsePlatformSpecificProtocols", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_UsePlatformSpecificProtocols_37);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_UsePlatformSpecificProtocols", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_UsePlatformSpecificProtocols_38);
            args = new Type[]{};
            method = type.GetMethod("get_InitialBandwidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_InitialBandwidth_39);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("set_InitialBandwidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_InitialBandwidth_40);
            args = new Type[]{};
            method = type.GetMethod("get_BandwidthPeakFactor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_BandwidthPeakFactor_41);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_BandwidthPeakFactor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_BandwidthPeakFactor_42);
            args = new Type[]{};
            method = type.GetMethod("get_WebSocketReceiveBufferMaxSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_WebSocketReceiveBufferMaxSize_43);
            args = new Type[]{typeof(System.UInt16)};
            method = type.GetMethod("set_WebSocketReceiveBufferMaxSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_WebSocketReceiveBufferMaxSize_44);
            args = new Type[]{};
            method = type.GetMethod("get_UdpSocketReceiveBufferMaxSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_UdpSocketReceiveBufferMaxSize_45);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("set_UdpSocketReceiveBufferMaxSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_UdpSocketReceiveBufferMaxSize_46);
            args = new Type[]{};
            method = type.GetMethod("get_SSLCertFilePath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_SSLCertFilePath_47);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_SSLCertFilePath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_SSLCertFilePath_48);
            args = new Type[]{};
            method = type.GetMethod("get_SSLPrivateKeyFilePath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_SSLPrivateKeyFilePath_49);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_SSLPrivateKeyFilePath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_SSLPrivateKeyFilePath_50);
            args = new Type[]{};
            method = type.GetMethod("get_SSLCAFilePath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_SSLCAFilePath_51);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_SSLCAFilePath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_SSLCAFilePath_52);
            args = new Type[]{};
            method = type.GetMethod("get_ChannelCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ChannelCount_53);
            args = new Type[]{typeof(UnityEngine.Networking.QosType)};
            method = type.GetMethod("AddChannel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddChannel_54);
            args = new Type[]{typeof(System.Byte)};
            method = type.GetMethod("GetChannel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetChannel_55);
            args = new Type[]{};
            method = type.GetMethod("get_Channels", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Channels_56);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Networking.ConnectionConfig());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Networking.ConnectionConfig[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(UnityEngine.Networking.ConnectionConfig)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);

        }


        static StackObject* Validate_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig config = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Networking.ConnectionConfig.Validate(config);

            return __ret;
        }

        static StackObject* get_PacketSize_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.PacketSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_PacketSize_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt16 value = (ushort)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PacketSize = value;

            return __ret;
        }

        static StackObject* get_FragmentSize_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FragmentSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_FragmentSize_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt16 value = (ushort)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.FragmentSize = value;

            return __ret;
        }

        static StackObject* get_ResendTimeout_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ResendTimeout;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_ResendTimeout_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 value = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResendTimeout = value;

            return __ret;
        }

        static StackObject* get_DisconnectTimeout_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DisconnectTimeout;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_DisconnectTimeout_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 value = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DisconnectTimeout = value;

            return __ret;
        }

        static StackObject* get_ConnectTimeout_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ConnectTimeout;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_ConnectTimeout_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 value = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ConnectTimeout = value;

            return __ret;
        }

        static StackObject* get_MinUpdateTimeout_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MinUpdateTimeout;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_MinUpdateTimeout_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 value = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MinUpdateTimeout = value;

            return __ret;
        }

        static StackObject* get_PingTimeout_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.PingTimeout;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_PingTimeout_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 value = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PingTimeout = value;

            return __ret;
        }

        static StackObject* get_ReducedPingTimeout_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ReducedPingTimeout;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_ReducedPingTimeout_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 value = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ReducedPingTimeout = value;

            return __ret;
        }

        static StackObject* get_AllCostTimeout_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AllCostTimeout;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_AllCostTimeout_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 value = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AllCostTimeout = value;

            return __ret;
        }

        static StackObject* get_NetworkDropThreshold_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.NetworkDropThreshold;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_NetworkDropThreshold_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Byte value = (byte)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.NetworkDropThreshold = value;

            return __ret;
        }

        static StackObject* get_OverflowDropThreshold_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.OverflowDropThreshold;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_OverflowDropThreshold_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Byte value = (byte)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OverflowDropThreshold = value;

            return __ret;
        }

        static StackObject* get_MaxConnectionAttempt_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MaxConnectionAttempt;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_MaxConnectionAttempt_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Byte value = (byte)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MaxConnectionAttempt = value;

            return __ret;
        }

        static StackObject* get_AckDelay_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AckDelay;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_AckDelay_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 value = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AckDelay = value;

            return __ret;
        }

        static StackObject* get_SendDelay_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SendDelay;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_SendDelay_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 value = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendDelay = value;

            return __ret;
        }

        static StackObject* get_MaxCombinedReliableMessageSize_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MaxCombinedReliableMessageSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_MaxCombinedReliableMessageSize_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt16 value = (ushort)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MaxCombinedReliableMessageSize = value;

            return __ret;
        }

        static StackObject* get_MaxCombinedReliableMessageCount_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MaxCombinedReliableMessageCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_MaxCombinedReliableMessageCount_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt16 value = (ushort)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MaxCombinedReliableMessageCount = value;

            return __ret;
        }

        static StackObject* get_MaxSentMessageQueueSize_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MaxSentMessageQueueSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_MaxSentMessageQueueSize_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt16 value = (ushort)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MaxSentMessageQueueSize = value;

            return __ret;
        }

        static StackObject* get_AcksType_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AcksType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_AcksType_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionAcksType value = (UnityEngine.Networking.ConnectionAcksType)typeof(UnityEngine.Networking.ConnectionAcksType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AcksType = value;

            return __ret;
        }

        static StackObject* get_UsePlatformSpecificProtocols_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.UsePlatformSpecificProtocols;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_UsePlatformSpecificProtocols_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UsePlatformSpecificProtocols = value;

            return __ret;
        }

        static StackObject* get_InitialBandwidth_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.InitialBandwidth;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_InitialBandwidth_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 value = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.InitialBandwidth = value;

            return __ret;
        }

        static StackObject* get_BandwidthPeakFactor_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.BandwidthPeakFactor;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_BandwidthPeakFactor_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.BandwidthPeakFactor = value;

            return __ret;
        }

        static StackObject* get_WebSocketReceiveBufferMaxSize_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.WebSocketReceiveBufferMaxSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_WebSocketReceiveBufferMaxSize_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt16 value = (ushort)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WebSocketReceiveBufferMaxSize = value;

            return __ret;
        }

        static StackObject* get_UdpSocketReceiveBufferMaxSize_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.UdpSocketReceiveBufferMaxSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_UdpSocketReceiveBufferMaxSize_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 value = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UdpSocketReceiveBufferMaxSize = value;

            return __ret;
        }

        static StackObject* get_SSLCertFilePath_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SSLCertFilePath;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_SSLCertFilePath_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SSLCertFilePath = value;

            return __ret;
        }

        static StackObject* get_SSLPrivateKeyFilePath_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SSLPrivateKeyFilePath;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_SSLPrivateKeyFilePath_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SSLPrivateKeyFilePath = value;

            return __ret;
        }

        static StackObject* get_SSLCAFilePath_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SSLCAFilePath;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_SSLCAFilePath_52(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SSLCAFilePath = value;

            return __ret;
        }

        static StackObject* get_ChannelCount_53(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ChannelCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* AddChannel_54(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.QosType value = (UnityEngine.Networking.QosType)typeof(UnityEngine.Networking.QosType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AddChannel(value);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetChannel_55(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Byte idx = (byte)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetChannel(idx);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Channels_56(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Channels;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Networking.ConnectionConfig();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionConfig config = (UnityEngine.Networking.ConnectionConfig)typeof(UnityEngine.Networking.ConnectionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new UnityEngine.Networking.ConnectionConfig(config);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
