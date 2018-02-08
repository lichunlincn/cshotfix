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
    unsafe class UnityEngine_Networking_PlayerConnection_MessageEventArgs_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Networking.PlayerConnection.MessageEventArgs);

            field = type.GetField("playerId", flag);
            app.RegisterCLRFieldGetter(field, get_playerId_0);
            app.RegisterCLRFieldSetter(field, set_playerId_0);
            field = type.GetField("data", flag);
            app.RegisterCLRFieldGetter(field, get_data_1);
            app.RegisterCLRFieldSetter(field, set_data_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Networking.PlayerConnection.MessageEventArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Networking.PlayerConnection.MessageEventArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_playerId_0(ref object o)
        {
            return ((UnityEngine.Networking.PlayerConnection.MessageEventArgs)o).playerId;
        }
        static void set_playerId_0(ref object o, object v)
        {
UnityEngine.Networking.PlayerConnection.MessageEventArgs _o = (UnityEngine.Networking.PlayerConnection.MessageEventArgs)o;
    _o.playerId = (System.Int32)v;
        }
        static object get_data_1(ref object o)
        {
            return ((UnityEngine.Networking.PlayerConnection.MessageEventArgs)o).data;
        }
        static void set_data_1(ref object o, object v)
        {
UnityEngine.Networking.PlayerConnection.MessageEventArgs _o = (UnityEngine.Networking.PlayerConnection.MessageEventArgs)o;
    _o.data = (System.Byte[])v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Networking.PlayerConnection.MessageEventArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
