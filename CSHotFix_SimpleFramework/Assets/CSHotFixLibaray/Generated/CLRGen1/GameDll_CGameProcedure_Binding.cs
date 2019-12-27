
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
    unsafe class GameDll_CGameProcedure_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(GameDll.CGameProcedure);
            args = new Type[]{};
            method = type.GetMethod("InitStaticMemeber", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InitStaticMemeber_0);
            args = new Type[]{typeof(GameDll.CGameProcedure)};
            method = type.GetMethod("SetActiveProc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetActiveProc_1);
            args = new Type[]{};
            method = type.GetMethod("TickActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TickActive_2);
            args = new Type[]{};
            method = type.GetMethod("ProcessCloseRequest", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ProcessCloseRequest_3);
            args = new Type[]{};
            method = type.GetMethod("ReleaseStaticMember", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReleaseStaticMember_4);
            args = new Type[]{};
            method = type.GetMethod("Update", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Update_5);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("SetProcedureStatus", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetProcedureStatus_6);
            args = new Type[]{};
            method = type.GetMethod("GetProcedureStatus", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetProcedureStatus_7);
            args = new Type[]{};
            method = type.GetMethod("GetActiveProcedure", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetActiveProcedure_8);
            args = new Type[]{};
            method = type.GetMethod("IsWindowActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsWindowActive_9);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("SetDisconnect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDisconnect_10);
            args = new Type[]{};
            method = type.GetMethod("IsDisconnect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsDisconnect_11);

            field = type.GetField("m_ProType", flag);
            app.RegisterCLRFieldGetter(field, get_m_ProType_0);
            app.RegisterCLRFieldSetter(field, set_m_ProType_0);
            field = type.GetField("s_TimerManager", flag);
            app.RegisterCLRFieldGetter(field, get_s_TimerManager_1);
            app.RegisterCLRFieldSetter(field, set_s_TimerManager_1);
            field = type.GetField("s_VariableManager", flag);
            app.RegisterCLRFieldGetter(field, get_s_VariableManager_2);
            app.RegisterCLRFieldSetter(field, set_s_VariableManager_2);
            field = type.GetField("s_MainHotFixManager", flag);
            app.RegisterCLRFieldGetter(field, get_s_MainHotFixManager_3);
            app.RegisterCLRFieldSetter(field, set_s_MainHotFixManager_3);
            field = type.GetField("s_MainHotFixManager_SystemDll", flag);
            app.RegisterCLRFieldGetter(field, get_s_MainHotFixManager_SystemDll_4);
            app.RegisterCLRFieldSetter(field, set_s_MainHotFixManager_SystemDll_4);
            field = type.GetField("s_EventManager", flag);
            app.RegisterCLRFieldGetter(field, get_s_EventManager_5);
            app.RegisterCLRFieldSetter(field, set_s_EventManager_5);
            field = type.GetField("s_BattleManager", flag);
            app.RegisterCLRFieldGetter(field, get_s_BattleManager_6);
            app.RegisterCLRFieldSetter(field, set_s_BattleManager_6);
            field = type.GetField("s_ProcStartApp", flag);
            app.RegisterCLRFieldGetter(field, get_s_ProcStartApp_7);
            app.RegisterCLRFieldSetter(field, set_s_ProcStartApp_7);
            field = type.GetField("s_ProcLogIn", flag);
            app.RegisterCLRFieldGetter(field, get_s_ProcLogIn_8);
            app.RegisterCLRFieldSetter(field, set_s_ProcLogIn_8);
            field = type.GetField("s_ProcBattle", flag);
            app.RegisterCLRFieldGetter(field, get_s_ProcBattle_9);
            app.RegisterCLRFieldSetter(field, set_s_ProcBattle_9);
            field = type.GetField("s_ProcLobby", flag);
            app.RegisterCLRFieldGetter(field, get_s_ProcLobby_10);
            app.RegisterCLRFieldSetter(field, set_s_ProcLobby_10);
            field = type.GetField("s_ActiveProcedure", flag);
            app.RegisterCLRFieldGetter(field, get_s_ActiveProcedure_11);
            app.RegisterCLRFieldSetter(field, set_s_ActiveProcedure_11);


            app.RegisterCLRCreateArrayInstance(type, s => new GameDll.CGameProcedure[s]);


        }


        static StackObject* InitStaticMemeber_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            GameDll.CGameProcedure.InitStaticMemeber();

            return __ret;
        }

        static StackObject* SetActiveProc_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            GameDll.CGameProcedure @toActive = (GameDll.CGameProcedure)typeof(GameDll.CGameProcedure).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            GameDll.CGameProcedure.SetActiveProc(@toActive);

            return __ret;
        }

        static StackObject* TickActive_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            GameDll.CGameProcedure.TickActive();

            return __ret;
        }

        static StackObject* ProcessCloseRequest_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            GameDll.CGameProcedure.ProcessCloseRequest();

            return __ret;
        }

        static StackObject* ReleaseStaticMember_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            GameDll.CGameProcedure.ReleaseStaticMember();

            return __ret;
        }

        static StackObject* Update_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            GameDll.CGameProcedure.Update();

            return __ret;
        }

        static StackObject* SetProcedureStatus_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @state = ptr_of_this_method->Value;


            GameDll.CGameProcedure.SetProcedureStatus(@state);

            return __ret;
        }

        static StackObject* GetProcedureStatus_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = GameDll.CGameProcedure.GetProcedureStatus();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetActiveProcedure_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = GameDll.CGameProcedure.GetActiveProcedure();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* IsWindowActive_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = GameDll.CGameProcedure.IsWindowActive();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetDisconnect_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @disconnect = ptr_of_this_method->Value == 1;


            GameDll.CGameProcedure.SetDisconnect(@disconnect);

            return __ret;
        }

        static StackObject* IsDisconnect_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = GameDll.CGameProcedure.IsDisconnect();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static object get_m_ProType_0(ref object o)
        {
            return ((GameDll.CGameProcedure)o).m_ProType;
        }
        static void set_m_ProType_0(ref object o, object v)
        {
GameDll.CGameProcedure _o = (GameDll.CGameProcedure)o;
    _o.m_ProType = (GameDll.EProcedureType)v;
        }
        static object get_s_TimerManager_1(ref object o)
        {
            return GameDll.CGameProcedure.s_TimerManager;
        }
        static void set_s_TimerManager_1(ref object o, object v)
        {
            GameDll.CGameProcedure.s_TimerManager = (GameDll.TimerManager)v;
        }
        static object get_s_VariableManager_2(ref object o)
        {
            return GameDll.CGameProcedure.s_VariableManager;
        }
        static void set_s_VariableManager_2(ref object o, object v)
        {
            GameDll.CGameProcedure.s_VariableManager = (GameDll.VariableManager)v;
        }
        static object get_s_MainHotFixManager_3(ref object o)
        {
            return GameDll.CGameProcedure.s_MainHotFixManager;
        }
        static void set_s_MainHotFixManager_3(ref object o, object v)
        {
            GameDll.CGameProcedure.s_MainHotFixManager = (global::HotFixManager)v;
        }
        static object get_s_MainHotFixManager_SystemDll_4(ref object o)
        {
            return GameDll.CGameProcedure.s_MainHotFixManager_SystemDll;
        }
        static void set_s_MainHotFixManager_SystemDll_4(ref object o, object v)
        {
            GameDll.CGameProcedure.s_MainHotFixManager_SystemDll = (global::HotFixManager_SystemDll)v;
        }
        static object get_s_EventManager_5(ref object o)
        {
            return GameDll.CGameProcedure.s_EventManager;
        }
        static void set_s_EventManager_5(ref object o, object v)
        {
            GameDll.CGameProcedure.s_EventManager = (GameDll.Events)v;
        }
        static object get_s_BattleManager_6(ref object o)
        {
            return GameDll.CGameProcedure.s_BattleManager;
        }
        static void set_s_BattleManager_6(ref object o, object v)
        {
            GameDll.CGameProcedure.s_BattleManager = (GameDll.BattleManager)v;
        }
        static object get_s_ProcStartApp_7(ref object o)
        {
            return GameDll.CGameProcedure.s_ProcStartApp;
        }
        static void set_s_ProcStartApp_7(ref object o, object v)
        {
            GameDll.CGameProcedure.s_ProcStartApp = (GameDll.CGamePro_StartApplication)v;
        }
        static object get_s_ProcLogIn_8(ref object o)
        {
            return GameDll.CGameProcedure.s_ProcLogIn;
        }
        static void set_s_ProcLogIn_8(ref object o, object v)
        {
            GameDll.CGameProcedure.s_ProcLogIn = (GameDll.CGamePro_Login)v;
        }
        static object get_s_ProcBattle_9(ref object o)
        {
            return GameDll.CGameProcedure.s_ProcBattle;
        }
        static void set_s_ProcBattle_9(ref object o, object v)
        {
            GameDll.CGameProcedure.s_ProcBattle = (GameDll.CGamePro_Battle)v;
        }
        static object get_s_ProcLobby_10(ref object o)
        {
            return GameDll.CGameProcedure.s_ProcLobby;
        }
        static void set_s_ProcLobby_10(ref object o, object v)
        {
            GameDll.CGameProcedure.s_ProcLobby = (GameDll.CGamePro_Lobby)v;
        }
        static object get_s_ActiveProcedure_11(ref object o)
        {
            return GameDll.CGameProcedure.s_ActiveProcedure;
        }
        static void set_s_ActiveProcedure_11(ref object o, object v)
        {
            GameDll.CGameProcedure.s_ActiveProcedure = (GameDll.CGameProcedure)v;
        }



    }
}
#endif
