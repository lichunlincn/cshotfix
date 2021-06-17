using System;
using System.Collections.Generic;

using System.Text;


public static class ActionRewrite
{
    public static void SafeInvoke(this Action evt)
    {
        if (evt != null)
        {
            evt();
        }
    }
    public static void SafeInvoke<T>(this Action<T> evt, T arg)
    {
        if (evt != null)
        {
            evt(arg);
        }
    }
    public static void SafeInvoke<T1,T2>(this Action<T1,T2> evt, T1 arg1, T2 arg2)
    {
        if (evt != null)
        {
            evt(arg1, arg2);
        }
    }
    public static void SafeInvoke<T1, T2, T3>(this Action<T1, T2, T3> evt, T1 arg1, T2 arg2, T3 arg3)
    {
        if (evt != null)
        {
            evt(arg1, arg2, arg3);
        }
    }
    public static TResult SafeInvoke<TResult>(this Func<TResult> evt)
    {
        if(evt != null)
        {
            return evt();
        }
        return default(TResult);
    }

    public static TResult SafeInvoke<T1, TResult>(this Func<T1, TResult> evt, T1 arg1)
    {
        if (evt != null)
        {
            return evt(arg1);
        }
        return default(TResult);
    }
}

namespace GameDll
{

    public class Events
    {

        public Action OnCameraPositionChangedEvent;
        public Action OnPrepareOkEvent;
        public Action OnOnAddRoomsEvent;
        public Action OnObjectPositionChangedEvent;



        public Action<bool> OnSceneLoadEvent;



        public Action<int> OnCameraTargetChangedEvent;
        public Action<int> OnChangeMySelfEvent;
        public Action<int> OnPingChangeEvent;
        public Action<int> OnStartLoadLevelEvent;
        public Action<int> OnCreatePlayerBoardEvent;
        public Action<int> OnScoreChangeEvent;
        public Action<int> OnTimeChangeEvent;


        public Action<IEventParam> OnPickObjEvent;

        public Action<int, int> OnRemovePlayerBoardEvent;
        public Action<int, int> OnHurtEvent;
        public Action<int, int> OnPropertyChangedEvent;

        public Action OnTestMapEvent;

        public Action OnBattleOpenUIs;
        public Action OnBattleCloseUIs;
        public Action OnStartApplication_OnAppInitOk;
        public Action OnLoginMessageHF_EnterLoginScene;
        public Action OnLoginMessageHF_StartLogin;
        public Action<int, int> OnNetStateChanged;

        public Action OnLobby_EnterLobbyScene;
        public Action OnLobby_LeaveLobbyScene;

        public Action OnPrepareBattleOk;
    }
}
