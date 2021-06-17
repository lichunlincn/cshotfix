using System;
using System.Collections.Generic;
using System.Text;


namespace GameDll
{
    //主界面状态
    public enum LobbyStatus
    {
        None,
        Loop,
        Exit,
        GoBattle,
    };
    public class CGamePro_Lobby : CGameProcedure
    {

        public CGamePro_Lobby()
        {

        }
        protected override void Init()
        {
            m_Status = (int)LobbyStatus.None;
            m_ProType = EProcedureType.eLobby;
            s_EventManager.OnStartLoadLevelEvent += OnStartLoadLevel;
        }

        private void OnStartLoadLevel(int id)
        {
            SetStatus((int)LobbyStatus.GoBattle);
        }
        protected override void Tick()
        {
            switch (m_Status)
            {
                case (int)LobbyStatus.None:
                    {
                        OnNone();
                        break;
                    }
                case (int)LobbyStatus.Loop:
                    {
                        OnLoop();
                        break;
                    }
                case (int)LobbyStatus.Exit:
                    {

                        OnExit();
                        break;
                    }
                case (int)LobbyStatus.GoBattle:
                    {
                        OnGoBattle();
                        break;
                    }

                default:
                    break;
            }
        }
        private void OnNone()
        {
            CGameProcedure.s_EventManager.OnLobby_EnterLobbyScene.SafeInvoke();
            SetStatus((int)LobbyStatus.Loop);
        }

        private void OnLoop()
        {
        }

        private void OnExit()
        {

        }

        private void OnGoBattle()
        {
            SetActiveProc(s_ProcBattle);
            s_EventManager.OnLobby_LeaveLobbyScene.SafeInvoke();
        }
        protected override void Release()
        {
            s_EventManager.OnStartLoadLevelEvent -= OnStartLoadLevel;
        }
    }
}
