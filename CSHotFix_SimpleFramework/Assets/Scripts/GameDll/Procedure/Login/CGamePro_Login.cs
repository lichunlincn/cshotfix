using System;
using System.Collections.Generic;
using System.Text;


namespace GameDll
{
    //登录状态

    public enum LoginStatus
    {
        None,
        //加载登陆场景
        EnterLoginScene,
        EnteringLoginScene,
        EnterLoginSceneOK,
        EnterLoginSceneFailed,

        WaitingForLoginScene,
        //账号登陆
        Login,
        Logining,
        LoginRst_Ok,
        LoginRst_Failed,
        //登陆游戏服务器
        LoginGame,
        LoginGameing,
        LoginGameRst_OK,
        LoginGameRst_Failed,
        GoLobby,

    };
    public class CGamePro_Login:CGameProcedure
    {

        public CGamePro_Login()
        {
            m_JumpLogin = LogicRoot.GetSetting().JumpLogin;
        }

        //根据设置跳过登录环节
        private bool m_JumpLogin = false;
        protected override void Init()
        {

            m_Status = (int)LoginStatus.EnterLoginScene;
            
            m_ProType = EProcedureType.eLogin;
            s_EventManager.OnTestMapEvent += OnStartTestMap;
        }

        private void OnStartTestMap()
        {
            //MapTest test = new MapTest();
            //var scene = new UScene();
            //scene.Init(1);
        }

        protected override void Tick()
        {
 	        switch(m_Status)
 	        {
                case (int)LoginStatus.EnterLoginScene:
                    {
                        s_EventManager.OnLoginMessageHF_EnterLoginScene.SafeInvoke();
                        SetStatus((int)LoginStatus.EnteringLoginScene);
                        break;
                    }
                case (int)LoginStatus.EnteringLoginScene:
                    {
                        break;
                    }
                case (int)LoginStatus.EnterLoginSceneOK:
                    {
                        SetStatus((int)LoginStatus.WaitingForLoginScene);
                        break;
                    }
                case (int)LoginStatus.WaitingForLoginScene:
                    {
                        break;
                    }
                case (int)LoginStatus.EnterLoginSceneFailed:
                    {
                        break;
                    }

                case (int)LoginStatus.Login:
                    {
                        CGameProcedure.s_EventManager.OnLoginMessageHF_StartLogin.SafeInvoke();
                        SetStatus((int)LoginStatus.Logining);
                        break;
                    }
                case (int)LoginStatus.Logining:
                    {
                        break;
                    }
                case (int)LoginStatus.LoginRst_Ok:
                    {
                        SetStatus((int)LoginStatus.LoginGame);
                        break;
                    }
                case (int)LoginStatus.LoginRst_Failed:
                    {

                        break;
                    }
                case (int)LoginStatus.LoginGame:
                    {
                        SetStatus((int)LoginStatus.LoginGameing);
                        break;
                    }
                    
                case (int)LoginStatus.LoginGameing:
                    {
                        break;
                    }
                case (int)LoginStatus.LoginGameRst_OK:
                    {
                        SetStatus((int)LoginStatus.GoLobby);
                        break;
                    }
                case (int)LoginStatus.LoginGameRst_Failed:
                    {
                        break;
                    }
                case (int)LoginStatus.GoLobby:
                    {
                        SetActiveProc(s_ProcLobby);
                        break;
                    }
             default:
 		        break;
 	        }
        }
    }
}
