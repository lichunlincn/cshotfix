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
    unsafe class UnityEngine_Networking_PlayerConnection_PlayerConnection_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Networking.PlayerConnection.PlayerConnection);
            args = new Type[]{};
            method = type.GetMethod("get_instance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_instance_0);
            args = new Type[]{};
            method = type.GetMethod("get_isConnected", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isConnected_1);
            args = new Type[]{};
            method = type.GetMethod("OnEnable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnEnable_2);
            args = new Type[]{typeof(System.Guid), typeof(UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs>)};
            method = type.GetMethod("Register", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Register_3);
            args = new Type[]{typeof(System.Guid), typeof(UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs>)};
            method = type.GetMethod("Unregister", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Unregister_4);
            args = new Type[]{typeof(UnityEngine.Events.UnityAction<System.Int32>)};
            method = type.GetMethod("RegisterConnection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterConnection_5);
            args = new Type[]{typeof(UnityEngine.Events.UnityAction<System.Int32>)};
            method = type.GetMethod("RegisterDisconnection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterDisconnection_6);
            args = new Type[]{typeof(System.Guid), typeof(System.Byte[])};
            method = type.GetMethod("Send", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Send_7);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Networking.PlayerConnection.PlayerConnection());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Networking.PlayerConnection.PlayerConnection[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_instance_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Networking.PlayerConnection.PlayerConnection.instance;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_isConnected_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.PlayerConnection.PlayerConnection instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.PlayerConnection.PlayerConnection)typeof(UnityEngine.Networking.PlayerConnection.PlayerConnection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isConnected;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* OnEnable_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.PlayerConnection.PlayerConnection instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.PlayerConnection.PlayerConnection)typeof(UnityEngine.Networking.PlayerConnection.PlayerConnection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnEnable();

            return __ret;
        }

        static StackObject* Register_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback = (UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs>)typeof(UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Guid messageId = (System.Guid)typeof(System.Guid).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Networking.PlayerConnection.PlayerConnection instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.PlayerConnection.PlayerConnection)typeof(UnityEngine.Networking.PlayerConnection.PlayerConnection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Register(messageId, callback);

            return __ret;
        }

        static StackObject* Unregister_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback = (UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs>)typeof(UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Guid messageId = (System.Guid)typeof(System.Guid).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Networking.PlayerConnection.PlayerConnection instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.PlayerConnection.PlayerConnection)typeof(UnityEngine.Networking.PlayerConnection.PlayerConnection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Unregister(messageId, callback);

            return __ret;
        }

        static StackObject* RegisterConnection_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Events.UnityAction<System.Int32> callback = (UnityEngine.Events.UnityAction<System.Int32>)typeof(UnityEngine.Events.UnityAction<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.PlayerConnection.PlayerConnection instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.PlayerConnection.PlayerConnection)typeof(UnityEngine.Networking.PlayerConnection.PlayerConnection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RegisterConnection(callback);

            return __ret;
        }

        static StackObject* RegisterDisconnection_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Events.UnityAction<System.Int32> callback = (UnityEngine.Events.UnityAction<System.Int32>)typeof(UnityEngine.Events.UnityAction<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.PlayerConnection.PlayerConnection instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.PlayerConnection.PlayerConnection)typeof(UnityEngine.Networking.PlayerConnection.PlayerConnection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RegisterDisconnection(callback);

            return __ret;
        }

        static StackObject* Send_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Byte[] data = (System.Byte[])typeof(System.Byte[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Guid messageId = (System.Guid)typeof(System.Guid).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Networking.PlayerConnection.PlayerConnection instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.PlayerConnection.PlayerConnection)typeof(UnityEngine.Networking.PlayerConnection.PlayerConnection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Send(messageId, data);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Networking.PlayerConnection.PlayerConnection();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
