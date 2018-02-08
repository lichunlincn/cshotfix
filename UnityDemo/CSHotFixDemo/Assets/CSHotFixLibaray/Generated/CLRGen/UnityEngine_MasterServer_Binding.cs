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
    unsafe class UnityEngine_MasterServer_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.MasterServer);
            args = new Type[]{};
            method = type.GetMethod("get_ipAddress", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ipAddress_0);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_ipAddress", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ipAddress_1);
            args = new Type[]{};
            method = type.GetMethod("get_port", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_port_2);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_port", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_port_3);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("RequestHostList", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RequestHostList_4);
            args = new Type[]{};
            method = type.GetMethod("PollHostList", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PollHostList_5);
            args = new Type[]{typeof(System.String), typeof(System.String), typeof(System.String)};
            method = type.GetMethod("RegisterHost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterHost_6);
            args = new Type[]{typeof(System.String), typeof(System.String)};
            method = type.GetMethod("RegisterHost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterHost_7);
            args = new Type[]{};
            method = type.GetMethod("UnregisterHost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UnregisterHost_8);
            args = new Type[]{};
            method = type.GetMethod("ClearHostList", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearHostList_9);
            args = new Type[]{};
            method = type.GetMethod("get_updateRate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_updateRate_10);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_updateRate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_updateRate_11);
            args = new Type[]{};
            method = type.GetMethod("get_dedicatedServer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_dedicatedServer_12);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_dedicatedServer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_dedicatedServer_13);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.MasterServer());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.MasterServer[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_ipAddress_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.MasterServer.ipAddress;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_ipAddress_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.MasterServer.ipAddress = value;

            return __ret;
        }

        static StackObject* get_port_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.MasterServer.port;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_port_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;

            UnityEngine.MasterServer.port = value;

            return __ret;
        }

        static StackObject* RequestHostList_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String gameTypeName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.MasterServer.RequestHostList(gameTypeName);

            return __ret;
        }

        static StackObject* PollHostList_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.MasterServer.PollHostList();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RegisterHost_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String comment = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String gameName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String gameTypeName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.MasterServer.RegisterHost(gameTypeName, gameName, comment);

            return __ret;
        }

        static StackObject* RegisterHost_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String gameName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String gameTypeName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.MasterServer.RegisterHost(gameTypeName, gameName);

            return __ret;
        }

        static StackObject* UnregisterHost_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            UnityEngine.MasterServer.UnregisterHost();

            return __ret;
        }

        static StackObject* ClearHostList_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            UnityEngine.MasterServer.ClearHostList();

            return __ret;
        }

        static StackObject* get_updateRate_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.MasterServer.updateRate;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_updateRate_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;

            UnityEngine.MasterServer.updateRate = value;

            return __ret;
        }

        static StackObject* get_dedicatedServer_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.MasterServer.dedicatedServer;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_dedicatedServer_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;

            UnityEngine.MasterServer.dedicatedServer = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.MasterServer();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
