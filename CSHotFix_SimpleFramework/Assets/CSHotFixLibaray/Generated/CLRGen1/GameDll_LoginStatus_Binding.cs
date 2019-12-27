
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
    unsafe class GameDll_LoginStatus_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(GameDll.LoginStatus);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            field = type.GetField("EnterLoginScene", flag);
            app.RegisterCLRFieldGetter(field, get_EnterLoginScene_1);
            field = type.GetField("EnteringLoginScene", flag);
            app.RegisterCLRFieldGetter(field, get_EnteringLoginScene_2);
            field = type.GetField("EnterLoginSceneOK", flag);
            app.RegisterCLRFieldGetter(field, get_EnterLoginSceneOK_3);
            field = type.GetField("EnterLoginSceneFailed", flag);
            app.RegisterCLRFieldGetter(field, get_EnterLoginSceneFailed_4);
            field = type.GetField("WaitingForLoginScene", flag);
            app.RegisterCLRFieldGetter(field, get_WaitingForLoginScene_5);
            field = type.GetField("Login", flag);
            app.RegisterCLRFieldGetter(field, get_Login_6);
            field = type.GetField("Logining", flag);
            app.RegisterCLRFieldGetter(field, get_Logining_7);
            field = type.GetField("LoginRst_Ok", flag);
            app.RegisterCLRFieldGetter(field, get_LoginRst_Ok_8);
            field = type.GetField("LoginRst_Failed", flag);
            app.RegisterCLRFieldGetter(field, get_LoginRst_Failed_9);
            field = type.GetField("LoginGame", flag);
            app.RegisterCLRFieldGetter(field, get_LoginGame_10);
            field = type.GetField("LoginGameing", flag);
            app.RegisterCLRFieldGetter(field, get_LoginGameing_11);
            field = type.GetField("LoginGameRst_OK", flag);
            app.RegisterCLRFieldGetter(field, get_LoginGameRst_OK_12);
            field = type.GetField("LoginGameRst_Failed", flag);
            app.RegisterCLRFieldGetter(field, get_LoginGameRst_Failed_13);
            field = type.GetField("GoLobby", flag);
            app.RegisterCLRFieldGetter(field, get_GoLobby_14);


            app.RegisterCLRCreateDefaultInstance(type, () => new GameDll.LoginStatus());
            app.RegisterCLRCreateArrayInstance(type, s => new GameDll.LoginStatus[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref GameDll.LoginStatus instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as GameDll.LoginStatus[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_None_0(ref object o)
        {
            return GameDll.LoginStatus.None;
        }
        static object get_EnterLoginScene_1(ref object o)
        {
            return GameDll.LoginStatus.EnterLoginScene;
        }
        static object get_EnteringLoginScene_2(ref object o)
        {
            return GameDll.LoginStatus.EnteringLoginScene;
        }
        static object get_EnterLoginSceneOK_3(ref object o)
        {
            return GameDll.LoginStatus.EnterLoginSceneOK;
        }
        static object get_EnterLoginSceneFailed_4(ref object o)
        {
            return GameDll.LoginStatus.EnterLoginSceneFailed;
        }
        static object get_WaitingForLoginScene_5(ref object o)
        {
            return GameDll.LoginStatus.WaitingForLoginScene;
        }
        static object get_Login_6(ref object o)
        {
            return GameDll.LoginStatus.Login;
        }
        static object get_Logining_7(ref object o)
        {
            return GameDll.LoginStatus.Logining;
        }
        static object get_LoginRst_Ok_8(ref object o)
        {
            return GameDll.LoginStatus.LoginRst_Ok;
        }
        static object get_LoginRst_Failed_9(ref object o)
        {
            return GameDll.LoginStatus.LoginRst_Failed;
        }
        static object get_LoginGame_10(ref object o)
        {
            return GameDll.LoginStatus.LoginGame;
        }
        static object get_LoginGameing_11(ref object o)
        {
            return GameDll.LoginStatus.LoginGameing;
        }
        static object get_LoginGameRst_OK_12(ref object o)
        {
            return GameDll.LoginStatus.LoginGameRst_OK;
        }
        static object get_LoginGameRst_Failed_13(ref object o)
        {
            return GameDll.LoginStatus.LoginGameRst_Failed;
        }
        static object get_GoLobby_14(ref object o)
        {
            return GameDll.LoginStatus.GoLobby;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new GameDll.LoginStatus();
            ins = (GameDll.LoginStatus)o;
            return ins;
        }


    }
}
#endif
