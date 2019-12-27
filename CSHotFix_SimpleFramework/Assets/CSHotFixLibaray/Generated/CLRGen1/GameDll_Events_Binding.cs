
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
    unsafe class GameDll_Events_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(GameDll.Events);

            field = type.GetField("OnCameraPositionChangedEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnCameraPositionChangedEvent_0);
            app.RegisterCLRFieldSetter(field, set_OnCameraPositionChangedEvent_0);
            field = type.GetField("OnPrepareOkEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnPrepareOkEvent_1);
            app.RegisterCLRFieldSetter(field, set_OnPrepareOkEvent_1);
            field = type.GetField("OnOnAddRoomsEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnOnAddRoomsEvent_2);
            app.RegisterCLRFieldSetter(field, set_OnOnAddRoomsEvent_2);
            field = type.GetField("OnObjectPositionChangedEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnObjectPositionChangedEvent_3);
            app.RegisterCLRFieldSetter(field, set_OnObjectPositionChangedEvent_3);
            field = type.GetField("OnSceneLoadEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnSceneLoadEvent_4);
            app.RegisterCLRFieldSetter(field, set_OnSceneLoadEvent_4);
            field = type.GetField("OnCameraTargetChangedEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnCameraTargetChangedEvent_5);
            app.RegisterCLRFieldSetter(field, set_OnCameraTargetChangedEvent_5);
            field = type.GetField("OnChangeMySelfEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnChangeMySelfEvent_6);
            app.RegisterCLRFieldSetter(field, set_OnChangeMySelfEvent_6);
            field = type.GetField("OnPingChangeEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnPingChangeEvent_7);
            app.RegisterCLRFieldSetter(field, set_OnPingChangeEvent_7);
            field = type.GetField("OnStartLoadLevelEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnStartLoadLevelEvent_8);
            app.RegisterCLRFieldSetter(field, set_OnStartLoadLevelEvent_8);
            field = type.GetField("OnCreatePlayerBoardEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnCreatePlayerBoardEvent_9);
            app.RegisterCLRFieldSetter(field, set_OnCreatePlayerBoardEvent_9);
            field = type.GetField("OnScoreChangeEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnScoreChangeEvent_10);
            app.RegisterCLRFieldSetter(field, set_OnScoreChangeEvent_10);
            field = type.GetField("OnTimeChangeEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnTimeChangeEvent_11);
            app.RegisterCLRFieldSetter(field, set_OnTimeChangeEvent_11);
            field = type.GetField("OnPickObjEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnPickObjEvent_12);
            app.RegisterCLRFieldSetter(field, set_OnPickObjEvent_12);
            field = type.GetField("OnRemovePlayerBoardEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnRemovePlayerBoardEvent_13);
            app.RegisterCLRFieldSetter(field, set_OnRemovePlayerBoardEvent_13);
            field = type.GetField("OnHurtEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnHurtEvent_14);
            app.RegisterCLRFieldSetter(field, set_OnHurtEvent_14);
            field = type.GetField("OnPropertyChangedEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnPropertyChangedEvent_15);
            app.RegisterCLRFieldSetter(field, set_OnPropertyChangedEvent_15);
            field = type.GetField("OnTestMapEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnTestMapEvent_16);
            app.RegisterCLRFieldSetter(field, set_OnTestMapEvent_16);
            field = type.GetField("OnBattleOpenUIs", flag);
            app.RegisterCLRFieldGetter(field, get_OnBattleOpenUIs_17);
            app.RegisterCLRFieldSetter(field, set_OnBattleOpenUIs_17);
            field = type.GetField("OnBattleCloseUIs", flag);
            app.RegisterCLRFieldGetter(field, get_OnBattleCloseUIs_18);
            app.RegisterCLRFieldSetter(field, set_OnBattleCloseUIs_18);
            field = type.GetField("OnStartApplication_OnAppInitOk", flag);
            app.RegisterCLRFieldGetter(field, get_OnStartApplication_OnAppInitOk_19);
            app.RegisterCLRFieldSetter(field, set_OnStartApplication_OnAppInitOk_19);
            field = type.GetField("OnLoginMessageHF_EnterLoginScene", flag);
            app.RegisterCLRFieldGetter(field, get_OnLoginMessageHF_EnterLoginScene_20);
            app.RegisterCLRFieldSetter(field, set_OnLoginMessageHF_EnterLoginScene_20);
            field = type.GetField("OnLoginMessageHF_StartLogin", flag);
            app.RegisterCLRFieldGetter(field, get_OnLoginMessageHF_StartLogin_21);
            app.RegisterCLRFieldSetter(field, set_OnLoginMessageHF_StartLogin_21);
            field = type.GetField("OnNetStateChanged", flag);
            app.RegisterCLRFieldGetter(field, get_OnNetStateChanged_22);
            app.RegisterCLRFieldSetter(field, set_OnNetStateChanged_22);
            field = type.GetField("OnLobby_EnterLobbyScene", flag);
            app.RegisterCLRFieldGetter(field, get_OnLobby_EnterLobbyScene_23);
            app.RegisterCLRFieldSetter(field, set_OnLobby_EnterLobbyScene_23);
            field = type.GetField("OnLobby_LeaveLobbyScene", flag);
            app.RegisterCLRFieldGetter(field, get_OnLobby_LeaveLobbyScene_24);
            app.RegisterCLRFieldSetter(field, set_OnLobby_LeaveLobbyScene_24);
            field = type.GetField("OnPrepareBattleOk", flag);
            app.RegisterCLRFieldGetter(field, get_OnPrepareBattleOk_25);
            app.RegisterCLRFieldSetter(field, set_OnPrepareBattleOk_25);


            app.RegisterCLRCreateDefaultInstance(type, () => new GameDll.Events());
            app.RegisterCLRCreateArrayInstance(type, s => new GameDll.Events[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_OnCameraPositionChangedEvent_0(ref object o)
        {
            return ((GameDll.Events)o).OnCameraPositionChangedEvent;
        }
        static void set_OnCameraPositionChangedEvent_0(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnCameraPositionChangedEvent = (System.Action)v;
        }
        static object get_OnPrepareOkEvent_1(ref object o)
        {
            return ((GameDll.Events)o).OnPrepareOkEvent;
        }
        static void set_OnPrepareOkEvent_1(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnPrepareOkEvent = (System.Action)v;
        }
        static object get_OnOnAddRoomsEvent_2(ref object o)
        {
            return ((GameDll.Events)o).OnOnAddRoomsEvent;
        }
        static void set_OnOnAddRoomsEvent_2(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnOnAddRoomsEvent = (System.Action)v;
        }
        static object get_OnObjectPositionChangedEvent_3(ref object o)
        {
            return ((GameDll.Events)o).OnObjectPositionChangedEvent;
        }
        static void set_OnObjectPositionChangedEvent_3(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnObjectPositionChangedEvent = (System.Action)v;
        }
        static object get_OnSceneLoadEvent_4(ref object o)
        {
            return ((GameDll.Events)o).OnSceneLoadEvent;
        }
        static void set_OnSceneLoadEvent_4(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnSceneLoadEvent = (System.Action<System.Boolean>)v;
        }
        static object get_OnCameraTargetChangedEvent_5(ref object o)
        {
            return ((GameDll.Events)o).OnCameraTargetChangedEvent;
        }
        static void set_OnCameraTargetChangedEvent_5(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnCameraTargetChangedEvent = (System.Action<System.Int32>)v;
        }
        static object get_OnChangeMySelfEvent_6(ref object o)
        {
            return ((GameDll.Events)o).OnChangeMySelfEvent;
        }
        static void set_OnChangeMySelfEvent_6(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnChangeMySelfEvent = (System.Action<System.Int32>)v;
        }
        static object get_OnPingChangeEvent_7(ref object o)
        {
            return ((GameDll.Events)o).OnPingChangeEvent;
        }
        static void set_OnPingChangeEvent_7(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnPingChangeEvent = (System.Action<System.Int32>)v;
        }
        static object get_OnStartLoadLevelEvent_8(ref object o)
        {
            return ((GameDll.Events)o).OnStartLoadLevelEvent;
        }
        static void set_OnStartLoadLevelEvent_8(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnStartLoadLevelEvent = (System.Action<System.Int32>)v;
        }
        static object get_OnCreatePlayerBoardEvent_9(ref object o)
        {
            return ((GameDll.Events)o).OnCreatePlayerBoardEvent;
        }
        static void set_OnCreatePlayerBoardEvent_9(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnCreatePlayerBoardEvent = (System.Action<System.Int32>)v;
        }
        static object get_OnScoreChangeEvent_10(ref object o)
        {
            return ((GameDll.Events)o).OnScoreChangeEvent;
        }
        static void set_OnScoreChangeEvent_10(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnScoreChangeEvent = (System.Action<System.Int32>)v;
        }
        static object get_OnTimeChangeEvent_11(ref object o)
        {
            return ((GameDll.Events)o).OnTimeChangeEvent;
        }
        static void set_OnTimeChangeEvent_11(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnTimeChangeEvent = (System.Action<System.Int32>)v;
        }
        static object get_OnPickObjEvent_12(ref object o)
        {
            return ((GameDll.Events)o).OnPickObjEvent;
        }
        static void set_OnPickObjEvent_12(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnPickObjEvent = (System.Action<GameDll.IEventParam>)v;
        }
        static object get_OnRemovePlayerBoardEvent_13(ref object o)
        {
            return ((GameDll.Events)o).OnRemovePlayerBoardEvent;
        }
        static void set_OnRemovePlayerBoardEvent_13(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnRemovePlayerBoardEvent = (System.Action<System.Int32, System.Int32>)v;
        }
        static object get_OnHurtEvent_14(ref object o)
        {
            return ((GameDll.Events)o).OnHurtEvent;
        }
        static void set_OnHurtEvent_14(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnHurtEvent = (System.Action<System.Int32, System.Int32>)v;
        }
        static object get_OnPropertyChangedEvent_15(ref object o)
        {
            return ((GameDll.Events)o).OnPropertyChangedEvent;
        }
        static void set_OnPropertyChangedEvent_15(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnPropertyChangedEvent = (System.Action<System.Int32, System.Int32>)v;
        }
        static object get_OnTestMapEvent_16(ref object o)
        {
            return ((GameDll.Events)o).OnTestMapEvent;
        }
        static void set_OnTestMapEvent_16(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnTestMapEvent = (System.Action)v;
        }
        static object get_OnBattleOpenUIs_17(ref object o)
        {
            return ((GameDll.Events)o).OnBattleOpenUIs;
        }
        static void set_OnBattleOpenUIs_17(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnBattleOpenUIs = (System.Action)v;
        }
        static object get_OnBattleCloseUIs_18(ref object o)
        {
            return ((GameDll.Events)o).OnBattleCloseUIs;
        }
        static void set_OnBattleCloseUIs_18(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnBattleCloseUIs = (System.Action)v;
        }
        static object get_OnStartApplication_OnAppInitOk_19(ref object o)
        {
            return ((GameDll.Events)o).OnStartApplication_OnAppInitOk;
        }
        static void set_OnStartApplication_OnAppInitOk_19(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnStartApplication_OnAppInitOk = (System.Action)v;
        }
        static object get_OnLoginMessageHF_EnterLoginScene_20(ref object o)
        {
            return ((GameDll.Events)o).OnLoginMessageHF_EnterLoginScene;
        }
        static void set_OnLoginMessageHF_EnterLoginScene_20(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnLoginMessageHF_EnterLoginScene = (System.Action)v;
        }
        static object get_OnLoginMessageHF_StartLogin_21(ref object o)
        {
            return ((GameDll.Events)o).OnLoginMessageHF_StartLogin;
        }
        static void set_OnLoginMessageHF_StartLogin_21(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnLoginMessageHF_StartLogin = (System.Action)v;
        }
        static object get_OnNetStateChanged_22(ref object o)
        {
            return ((GameDll.Events)o).OnNetStateChanged;
        }
        static void set_OnNetStateChanged_22(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnNetStateChanged = (System.Action<System.Int32, System.Int32>)v;
        }
        static object get_OnLobby_EnterLobbyScene_23(ref object o)
        {
            return ((GameDll.Events)o).OnLobby_EnterLobbyScene;
        }
        static void set_OnLobby_EnterLobbyScene_23(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnLobby_EnterLobbyScene = (System.Action)v;
        }
        static object get_OnLobby_LeaveLobbyScene_24(ref object o)
        {
            return ((GameDll.Events)o).OnLobby_LeaveLobbyScene;
        }
        static void set_OnLobby_LeaveLobbyScene_24(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnLobby_LeaveLobbyScene = (System.Action)v;
        }
        static object get_OnPrepareBattleOk_25(ref object o)
        {
            return ((GameDll.Events)o).OnPrepareBattleOk;
        }
        static void set_OnPrepareBattleOk_25(ref object o, object v)
        {
GameDll.Events _o = (GameDll.Events)o;
    _o.OnPrepareBattleOk = (System.Action)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new GameDll.Events();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
