using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using GameDll;
using LCL;
using UnityEngine;

namespace HotFix
{ 
    public class LoginMessage:BaseMessageHF
    {
        private static LoginMessage m_Instance;
        public static LoginMessage GetInstance()
        {
            if (m_Instance == null)
            {
                m_Instance = new LoginMessage();
            }
            return m_Instance;
        }
        private string m_AssetBundleName = "";
        private long m_ABId = 0;
        private bool m_bCheckDisconnect = false;
        private bool m_bCheckConnect = false;
        public  LoginData m_Login;
        //使用界面上输入的UI服务器地址
        public bool m_bUserUIServer = false;
        //开启网络连接检测
        private bool m_bEnableConnectCheck = false;

        public LoginMessage()
        {

            m_Login = new LoginData();
        }
        public override void AddMessage()
        {
            PacketHandlerManagerHF.Register((ushort)emPacket_Login.EM_SC_LoginRst, SC_LoginRst);
            PacketHandlerManagerHF.Register((ushort)emPacket_Login.EM_SC_LoginGateWayRst, OnLoginGameResult);
            PacketHandlerManagerHF.Register((ushort)emPacket_Login.em_SC_PlayerInfo, OnPlayerInfo);
        }
        public override void RemoveMessage()
        {
            PacketHandlerManagerHF.Unregister((ushort)emPacket_Login.EM_SC_LoginRst);
            PacketHandlerManagerHF.Unregister((ushort)emPacket_Login.EM_SC_LoginGateWayRst);
            PacketHandlerManagerHF.Unregister((ushort)emPacket_Login.em_SC_PlayerInfo);
        }

        public  void Destroy()
        {
            m_AssetBundleName = "";
        }

       
        private emLoginResult m_LoginRst;
        public int m_LoginGameRst;

        private CS_Login m_LoginMsg = null;




        private Login_Popup_wnd m_login_wnd;
        public void OpenAccountInputDlg()
        {
            //m_login_wnd = UIManager.WindowOpen(login_wnd.UIClassName, null) as login_wnd;
            m_login_wnd = UIManager.WindowOpenEX<Login_Popup_wnd>(null);
            loading_wnd.CloseLoading();
        }
        public void CloseAccountInputDlg()
        {
            UIManager.WindowClose(m_login_wnd);
        }
        private int LoadLoginServerInfo()
        {
            Setting setting = LogicRoot.GetSetting();
            int id = 2;
            if (setting.UseLocalServer)
            {
                id = 2;
            }
            else
            {
                id = 4;
            }
            t_serverBeanHF server = t_serverBeanHF.GetConfig(id);
            if (server == null)
            {
                UnityEngine.Debug.LogError("网关配置数据无法读取到");
                return -1;
            }
            string ip = server.t_ip;
            int port = server.t_port;
            m_Login.m_LoginInfo.m_szIp = ip;
            m_Login.m_LoginInfo.m_iPort = port;
            return 0;
        }
        public void CheckAccount(byte platform,string account,string pwd,string param)
        {
            m_LoginMsg = new CS_Login();
            m_LoginMsg.m_account = account;
            m_LoginMsg.m_pwd = pwd;
            CGameProcedure.SetProcedureStatus((int)LoginStatus.Login);
        }

        //登录服消息返回
        private void SC_LoginRst(WfPacket packet)
        {
            //获取登录服务器信息
            SC_LoginRst pak = PooledClassManagerHF<SC_LoginRst>.CreateClass();
            pak.DeSerialize(packet);
            int result = pak.m_rst;
            if (result == 0)
            {
                m_Login.m_GameServers.Clear();
                GameServerInfo info = new GameServerInfo();
                info.m_szIp = m_Login.m_LoginInfo.m_szIp;
                info.m_iPort = 24000;
                info.m_SessionId = pak.m_sessionid;
                m_Login.m_GameServers.Add(info);
                Debug.Log("获取服务器信息成功：" + info.m_SessionId);

                m_LoginRst = emLoginResult.emLoginResult_OK;
                CGameProcedure.SetProcedureStatus((int)LoginStatus.LoginRst_Ok);

                //连接游戏服务器
                //StartLoginGame();
            }
            else
            {
                m_LoginRst = emLoginResult.emLoginResult_Failed;
                CGameProcedure.SetProcedureStatus((int)LoginStatus.LoginRst_Ok);
                Debug.LogError("登录失败");
            }

            pak.DestroyClass();
        }

        private void OnPlayerInfo(WfPacket packet)
        {
            SC_PlayerInfo pak = new SC_PlayerInfo();
            pak.DeSerialize(packet);


            LeaveLoginScene();
            CGameProcedure.SetActiveProc(CGameProcedure.s_ProcLobby);
        }
        private void OnLoginGameResult(WfPacket packet)
        {
            SC_LoginGateWayRst pak = new SC_LoginGateWayRst();
            pak.DeSerialize(packet);
            Debug.Log("rcv EM_SC_LoginGateWayRst");
            int result = pak.m_rst;
            if (result == (int)emLoginResult.emLoginResult_OK)
            {
                m_LoginGameRst = (int)emLoginResult.emLoginResult_OK;
                m_bEnableConnectCheck = true;
                m_bCheckDisconnect = true;
                CGameProcedure.SetProcedureStatus((int)LoginStatus.LoginGameRst_OK);

                LeaveLoginScene();
            }
            else
            {
                m_LoginGameRst = (int)emLoginResult.emLoginResult_Failed;
                CGameProcedure.SetProcedureStatus((int)LoginStatus.LoginGameRst_OK);
            }
            UnityEngine.Debug.Log("连接游戏服务器结果：" + result);
        }        

        public void EnterLoginScene()
        {
            UnityEngine.Debug.Log("cshotfix  EnterLogin start");
            t_mapBeanHF map = t_mapBeanHF.GetConfig(2);
            //map = null;
            m_AssetBundleName = map.t_map_abname.ToLower();
            string assetName = map.t_map_assetname;
            m_AssetBundleName = "scene/login/login_scene.jpg";
            assetName = "login_scene";
            m_ABId = ResourceManager.LoadLevel(m_AssetBundleName, assetName, 0, LoadedScene);
            UnityEngine.Debug.Log("cshotfix  EnterLogin end");
        }
        private void LoadedScene()
        {
            OpenAccountInputDlg();
            string level = Path.GetFileNameWithoutExtension(m_AssetBundleName);
            ResourceManager.ActiveLevel(level);
        }
        public void LeaveLoginScene()
        {
            UIManager.WindowClose(m_login_wnd);
            m_login_wnd = null;
            ResourceManager.UnloadPrefab(m_ABId);
            m_ABId = 0;
            m_AssetBundleName = "";
        }

        private busy_wnd m_busy_wnd;
        //掉线,直接连接
        public void OnDisconnect()
        {

        }
    }
}
