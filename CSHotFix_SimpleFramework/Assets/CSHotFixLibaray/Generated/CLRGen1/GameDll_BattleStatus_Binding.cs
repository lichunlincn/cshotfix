
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
    unsafe class GameDll_BattleStatus_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(GameDll.BattleStatus);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            field = type.GetField("EnterBattle", flag);
            app.RegisterCLRFieldGetter(field, get_EnterBattle_1);
            field = type.GetField("LoadingBattle", flag);
            app.RegisterCLRFieldGetter(field, get_LoadingBattle_2);
            field = type.GetField("MainLoop", flag);
            app.RegisterCLRFieldGetter(field, get_MainLoop_3);
            field = type.GetField("LeaveBattle", flag);
            app.RegisterCLRFieldGetter(field, get_LeaveBattle_4);
            field = type.GetField("Exit", flag);
            app.RegisterCLRFieldGetter(field, get_Exit_5);
            field = type.GetField("PrepareBattleOk", flag);
            app.RegisterCLRFieldGetter(field, get_PrepareBattleOk_6);


            app.RegisterCLRCreateDefaultInstance(type, () => new GameDll.BattleStatus());
            app.RegisterCLRCreateArrayInstance(type, s => new GameDll.BattleStatus[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref GameDll.BattleStatus instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as GameDll.BattleStatus[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_None_0(ref object o)
        {
            return GameDll.BattleStatus.None;
        }
        static object get_EnterBattle_1(ref object o)
        {
            return GameDll.BattleStatus.EnterBattle;
        }
        static object get_LoadingBattle_2(ref object o)
        {
            return GameDll.BattleStatus.LoadingBattle;
        }
        static object get_MainLoop_3(ref object o)
        {
            return GameDll.BattleStatus.MainLoop;
        }
        static object get_LeaveBattle_4(ref object o)
        {
            return GameDll.BattleStatus.LeaveBattle;
        }
        static object get_Exit_5(ref object o)
        {
            return GameDll.BattleStatus.Exit;
        }
        static object get_PrepareBattleOk_6(ref object o)
        {
            return GameDll.BattleStatus.PrepareBattleOk;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new GameDll.BattleStatus();
            ins = (GameDll.BattleStatus)o;
            return ins;
        }


    }
}
#endif
