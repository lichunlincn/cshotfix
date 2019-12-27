
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
    unsafe class GameDll_ConstString_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(GameDll.ConstString);

            field = type.GetField("FenHao_Semicolon", flag);
            app.RegisterCLRFieldGetter(field, get_FenHao_Semicolon_0);
            field = type.GetField("JiaHao_Plus", flag);
            app.RegisterCLRFieldGetter(field, get_JiaHao_Plus_1);
            field = type.GetField("Position", flag);
            app.RegisterCLRFieldGetter(field, get_Position_2);
            field = type.GetField("Distance", flag);
            app.RegisterCLRFieldGetter(field, get_Distance_3);
            field = type.GetField("Target", flag);
            app.RegisterCLRFieldGetter(field, get_Target_4);
            field = type.GetField("NearstEnemy", flag);
            app.RegisterCLRFieldGetter(field, get_NearstEnemy_5);
            field = type.GetField("MinEnemy", flag);
            app.RegisterCLRFieldGetter(field, get_MinEnemy_6);
            field = type.GetField("FollowObj", flag);
            app.RegisterCLRFieldGetter(field, get_FollowObj_7);
            field = type.GetField("Duration", flag);
            app.RegisterCLRFieldGetter(field, get_Duration_8);
            field = type.GetField("Speed", flag);
            app.RegisterCLRFieldGetter(field, get_Speed_9);
            field = type.GetField("Tree", flag);
            app.RegisterCLRFieldGetter(field, get_Tree_10);
            field = type.GetField("AddPosition", flag);
            app.RegisterCLRFieldGetter(field, get_AddPosition_11);


            app.RegisterCLRCreateDefaultInstance(type, () => new GameDll.ConstString());
            app.RegisterCLRCreateArrayInstance(type, s => new GameDll.ConstString[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_FenHao_Semicolon_0(ref object o)
        {
            return GameDll.ConstString.FenHao_Semicolon;
        }
        static object get_JiaHao_Plus_1(ref object o)
        {
            return GameDll.ConstString.JiaHao_Plus;
        }
        static object get_Position_2(ref object o)
        {
            return GameDll.ConstString.Position;
        }
        static object get_Distance_3(ref object o)
        {
            return GameDll.ConstString.Distance;
        }
        static object get_Target_4(ref object o)
        {
            return GameDll.ConstString.Target;
        }
        static object get_NearstEnemy_5(ref object o)
        {
            return GameDll.ConstString.NearstEnemy;
        }
        static object get_MinEnemy_6(ref object o)
        {
            return GameDll.ConstString.MinEnemy;
        }
        static object get_FollowObj_7(ref object o)
        {
            return GameDll.ConstString.FollowObj;
        }
        static object get_Duration_8(ref object o)
        {
            return GameDll.ConstString.Duration;
        }
        static object get_Speed_9(ref object o)
        {
            return GameDll.ConstString.Speed;
        }
        static object get_Tree_10(ref object o)
        {
            return GameDll.ConstString.Tree;
        }
        static object get_AddPosition_11(ref object o)
        {
            return GameDll.ConstString.AddPosition;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new GameDll.ConstString();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
