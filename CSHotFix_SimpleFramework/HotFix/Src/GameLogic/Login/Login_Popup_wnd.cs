using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using GameDll;
using UnityUI;
using LCL;
using System.Collections;

namespace HotFix
{
    public class Login_Popup_wnd : WindowBase
    {
        private v_Login_Popup_wnd m_view_wnd_Popup_Login = null;
        //private USound m_Sound = null;
        private long m_TimerId = -1;
        public Login_Popup_wnd()
        {
            m_Layer = WindowLayer.Popup;
        }

        protected override void OnInitComponent()
        {
            //DebugHelper.StartStopwatch();
            m_view_wnd_Popup_Login = new v_Login_Popup_wnd();
            m_view_wnd_Popup_Login.InitComponent(m_WinObj);
            //UIInterface.SetText(m_view_wnd_Popup_Login.m_txtUserName_InputField, PlayerPrefs.GetString("LastLoginUserName", "robot_1"));
            //UIInterface.SetText(m_view_wnd_Popup_Login.m_txtPassword_InputField, "123456");
            //UIInterface.AddListener(m_view_wnd_Popup_Login.m_btnLogin_Button, UIEventType.onClick, OnClickLogin);
            //UIInterface.AddListener(m_view_wnd_Popup_Login.m_toggleServer_Toggle, UIEventType.onClick, OnClickServerToggle);
            //UIInterface.AddListener(m_view_wnd_Popup_Login.m_btnStart_Button, UIEventType.onClick, OnClickStart);
            //UIInterface.AddListener(m_view_wnd_Popup_Login.m_btnTestUI_Button, UIEventType.onClick, OnTestUI);
            //UIInterface.AddListener(m_view_wnd_Popup_Login.m_btnTestUI2_Button, UIEventType.onClick, OnTestUI2);
            //UIInterface.AddListener(m_view_wnd_Popup_Login.m_btnTestUI3_Button, UIEventType.onClick, OnTestUI3);
            //m_Sound = new USound();
            //m_Sound.CreateObject(1);
            //m_Sound.Pause();
            //m_Sound.SetPersist(true);

            //TestDictionaryActionKey test = new TestDictionaryActionKey();
            //test.Test();
            //m_Password.text ="time:" + DebugHelper.StopStopwatch().ToString();

            //测试协程
            var coroutine = (CoroutineCom)m_WinObj.AddComponent(typeof(CoroutineCom));
            coroutine.OnStartCoroutine(OnTestCoroutine(12, new GameObject()));
        }

        private IEnumerator OnTestCoroutine(int v, GameObject gameObject)
        {
            Debug.Log("测试协程1");
            yield return new WaitForSeconds(1.0f);
            Debug.Log("测试协程2");
        }



        private void OnTestUI3(GameObject obj)
        {
            //Image img = UIInterface.GetImage(m_view_wnd_Popup_Login.m_btnTestUI3_Button, "bg");
            //string atlas = "texture_set/common.jpg";
            //string icon = "anniu4H_4zi_C";
            //SetImage(img, atlas, icon);
        }

        private void OnTestUI2(GameObject obj)
        {

        }

        private int m_nTestIndex = 0;
        private void OnTestUI(GameObject btn)
        {
            //System.GC.Collect();
            //m_nTestIndex = 0;
            //int.TryParse(m_Password.text, out m_nTestIndex);
            ////UIManagerHF.WindowOpen(test_all_ui_control_wnd.UIClassName);
            //switch(m_nTestIndex)
            //{
            //    case 0:
            //        {
            //            GameObject go = new GameObject();
            //            m_UserName.text = TestPerformance.Test0(go.transform);
            //            break;
            //        }
            //    case 1:
            //        {
            //            GameObject go = new GameObject();
            //            m_UserName.text = TestPerformance.Test1(go.transform);
            //            break;
            //        }
            //    case 2:
            //        {
            //            m_UserName.text = TestPerformance.Test2();
            //            break;
            //        }
            //    case 3:
            //        {
            //            m_UserName.text = TestPerformance.Test3();
            //            break;
            //        }
            //    case 4:
            //        {
            //            m_UserName.text = TestPerformance.Test4();
            //            break;
            //        }
            //    case 5:
            //        {
            //            m_UserName.text = TestPerformance.Test5();
            //            break;
            //        }
            //    case 6:
            //        {
            //            m_UserName.text = TestPerformance.Test6();
            //            break;
            //        }
            //    case 7:
            //        {
            //            m_UserName.text = TestPerformance.Test7();
            //            break;
            //        }
            //    case 8:
            //        {
            //            m_UserName.text = TestPerformance.Test8();
            //            break;
            //        }
            //    case 9:
            //        {
            //            m_UserName.text = TestPerformance.Test9();
            //            break;
            //        }
            //    case 10:
            //        {
            //            GameObject go = new GameObject();
            //            m_UserName.text = TestPerformance.Test10(go.transform);
            //            break;
            //        }
            //}
            //m_nTestIndex++;
            //for (int i = 0; i < 10; ++i)
            //{
            //    var wnd = UIManager.WindowOpenEX<test_windows_parent_wnd>(null);
            //}


            //测试打开一个子窗口 再打开这个窗口之前我们先要打开一个顶级窗口
            //这个窗口是当我们的背景窗口打开的时候，打开的一个顶级窗口
            //Action opencall = () =>
            //{
            //    UIManager.WindowOpenEX<test_ui_eff_hud2_wnd>(this);
            //};
            //UIManager.WindowOpenEX<test_windows_parent_wnd>(this);

            //UIManager.WindowOpenEX<test_ui_eff_hud1_wnd>(null, opencall);
        }

        //用于直接开始单机游戏
        private void OnClickStart(GameObject btn)
        {
            CGameProcedure.s_EventManager.OnTestMapEvent.SafeInvoke();
        }


        protected override void OnOpen()
        {
            //m_Sound.Play();
            Timer timer = new Timer();
            timer.finishCall = OnFinish;
            m_TimerId = timer.GetId();
            timer.intervalMMSeconds = 1000;
            timer.totalMMSeconds = 10000;
            timer.perCall = OnPerCall;

            TimerManager.StaticAddTimer(timer);

            //m_Sound.Play();
            //for (int i =0;i<5;++i)
            //{
            //    GameDll.TestManager.TestChangeCloth();
            //}

        }

        void OnPerCall(int obj)
        {
            Debug.Log("test timer");
        }

        void OnFinish()
        {
            m_TimerId = 0;
            UnityEngine.Debug.Log("Login Timer Finish");
        }

        private void OnClickServerToggle(GameObject obj)
        {
            //UnityEngine.Debug.Log(m_UserInputServer.isOn.ToString());
            if (m_view_wnd_Popup_Login.m_toggleServer_Toggle.isOn)
            {
                //使用输入的ip地址

            }
            else
            {
                //否则使用配置表里面默认的远程服务器地址

            }
        }
        protected override void OnClose()
        {
            //m_Sound.Stop();
            //UIInterface.SetActive(m_RTRenderer, false);
            //UIInterface.SetActive(m_EffectRTRenderer, false);
            if(m_TimerId != 0)
            {
                TimerManager.StaticRemoveTimer(m_TimerId);
                m_TimerId = 0;
            }
            //m_Sound.Pause();
        }

        protected override void OnDestroy()
        {
            //if(m_Sound!= null)
            //{
            //    m_Sound.Destroy();
            //    m_Sound = null;
            //}
            m_view_wnd_Popup_Login = null;
        }

        void OnClickLogin(GameObject obj)
        {
            //for (int i = 0; i < 100; ++i)
            //{
            //    var data = PooledClassManagerHF<TestClass>.CreateClass();
            //    PooledClassManagerHF<TestClass>.DeleteClass(ref data);
            //}
            //if(true)
            //{
            //    return;
            //}
            string name = "robot_" + UnityEngine.Random.Range(1, 15); //m_UserName.text.Trim();
            string pwd = m_view_wnd_Popup_Login.m_txtPassword_InputField.text.Trim();
            if (m_view_wnd_Popup_Login.m_toggleServer_Toggle.isOn)
            {
                LoginMessage.GetInstance().m_bUserUIServer = true;
                LoginMessage.GetInstance().m_Login.m_LoginInfo.m_szIp = m_view_wnd_Popup_Login.m_txtIp_InputField.text.Trim();
                LoginMessage.GetInstance().m_Login.m_LoginInfo.m_iPort = 25550;
                int port = 25550;
                if (int.TryParse(m_view_wnd_Popup_Login.m_txtPort_InputField.text.Trim(), out port))
                {
                    LoginMessage.GetInstance().m_Login.m_LoginInfo.m_iPort = port;
                }
                UnityEngine.Debug.Log("使用界面上面输入服务器地址，" + m_view_wnd_Popup_Login.m_txtIp_InputField.text
                    + m_view_wnd_Popup_Login.m_txtPort_InputField.text);
            }
            else
            {
                LoginMessage.GetInstance().m_bUserUIServer = false;
            }
            LoginMessage.GetInstance().CheckAccount(0, name, pwd, "");
            PlayerPrefs.SetString("LastLoginUserName", name);
            ////测试新的寻路
            //LobbyData lobbydata = DataPoolHF.GetInstance().GetLobbyData();
            //CRoomData rd = new CRoomData();
            //rd.m_BattleType = BattleType.TreasureBattle;
            //rd.m_uMapId = 1;
            //rd.m_uRoomId = 1;
            //lobbydata.AddRoom(rd);
            //lobbydata.SetCurrRoomId(1);
            //CGameProcedure.SetActiveProc(CGameProcedure.s_ProcBattle);
        }
    }
}
