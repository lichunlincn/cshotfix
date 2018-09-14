using System;
using System.Collections.Generic;
using System.Text;
using LCL;

namespace GameDll
{
    public enum EProcedureType
    {
        eStart,
        eLogin,
        eLobby,
        eChangeScene,
        eBattle,
    }
    public abstract class CGameProcedure
    {
        public EProcedureType m_ProType = EProcedureType.eStart;
        //渲染暂停
        protected static bool m_bRenderingPaused=false;
        //窗口最小化
        protected static bool m_bMinimized=false;
        //窗口处于焦点状态
        protected static bool m_bActive=true;

        //掉线
        protected static bool m_bDisconnect = false;


        //
        // 游戏运行的过程
        //
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///物体管理器
        //public static CObjectManager s_RoleManager;

        // 计时器
        public static TimerManager s_TimerManager;

        // 变量管理器
        public static VariableManager s_VariableManager;

        public static HotFixManager s_MainHotFixManager;
        public static HotFixManager_SystemDll s_MainHotFixManager_SystemDll;

        //游戏事件管理器
        public static Events s_EventManager;

        //public static JBManager s_JBmanager = null;

        //public static CameraManager s_CameraManager = null;

        public static BattleManager s_BattleManager = null;


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //
        // 游戏运行的流程.
        //
        /// 启动游戏流程
        public static CGamePro_StartApplication s_ProcStartApp = null;
        /// 登录游戏循环
        public static CGamePro_Login s_ProcLogIn=null;

        /// 人物创建流程
        //public static CGamePro_CharCreate s_pProcCharCreate;
        /// 主游戏循环
        public static CGamePro_Battle s_ProcBattle;

        public static CGamePro_Lobby s_ProcLobby;

        /// 当前激活的流程.
        public static CGameProcedure s_ActiveProcedure=null;
        //上一个激活的循环，只在切换过程中使用
        protected static CGameProcedure s_ProcPrev = null;

        // 切换服务器流程
        //public static CGamePro_ChangeScene s_pProcChangeScene;

        //初始化静态变量
        public static void InitStaticMemeber()
        {
            s_EventManager = new Events();

            //PrefabLoaderManager.Init();
            Main main = Tool.Main();
            if (main.m_UseCSHotFixDll)
            {
                s_MainHotFixManager = new HotFixManager();
                s_MainHotFixManager.Init("HotFix");
                UnityEngine.Debug.Log("Use Manual .Net");
            }
            else
            {
                s_MainHotFixManager_SystemDll = new HotFixManager_SystemDll();
                s_MainHotFixManager_SystemDll.Init("HotFix");
                UnityEngine.Debug.Log("Use System .Net");
            }
            //初始化所有的循环实例
            s_ProcStartApp = new CGamePro_StartApplication();//启动游戏
            s_ProcLogIn = new CGamePro_Login();			//!< 登录循环
            //s_pProcCharCreate = new CGamePro_CharCreate();	//!< 人物创建流程
            s_ProcBattle = new CGamePro_Battle();			//!< 主游戏循环
            s_ProcLobby = new CGamePro_Lobby();

            //NetworkManager.Init();
            //NetworkManager.StartNetwork(NetworkProtol.Tcp);



            s_TimerManager = new TimerManager();
            
            //s_RoleManager = new CObjectManager();
            //s_VariableManager = new VariableManager();
            //s_JBmanager = new JBManager();

            s_BattleManager = new BattleManager();
            
            ////-------------------------------------------------------------------
            ////初始化工作节点
            //s_pVariableSystem.Initial(object.Zero);
            //s_pEventSystem.Initial(object.Zero);
            //s_pWorldManager.Initial(object.Zero); 
            //if (s_pUISystem != null) s_pUISystem.Initial(object.Zero);
            //DataManager.Init();


            MessageManager.RegMessages();


            InputManager.Init();
            //s_JBmanager.Init(null, null);

            //Test-------------------------------------------------------------

            s_BattleManager.Init();


            s_ActiveProcedure = s_ProcStartApp;
            s_EventManager.OnHurtEvent.SafeInvoke(12,11);
            s_EventManager.OnCameraPositionChangedEvent.SafeInvoke();
        }
        //将一个游戏循环激活
        public static void SetActiveProc(CGameProcedure toActive)
        {
            if (toActive == null || s_ActiveProcedure == toActive) return;
            s_ProcPrev = s_ActiveProcedure;
            s_ActiveProcedure = toActive;
        }
        //进入当前游戏循环的数据逻辑函数
        public static void TickActive()
        {
            //如果要转入新的游戏循环...
            if (s_ActiveProcedure != s_ProcPrev)
            {
                //调用旧循环的释放函数
                if (s_ProcPrev!=null) s_ProcPrev.Release();
                //调用新循环的初始化函数
                if (s_ActiveProcedure!=null) s_ActiveProcedure.Init();
                //开始新的循环
                s_ProcPrev = s_ActiveProcedure;
            }
            //执行激活循环的数据逻辑
            if (s_ActiveProcedure!=null) s_ActiveProcedure.Tick();
        }
        //玩家请求退出程序事件
        public static void ProcessCloseRequest()
        {
            //执行激活循环的渲染函数
            if (s_ActiveProcedure == s_ProcPrev && s_ActiveProcedure!=null)
            {
                s_ActiveProcedure.CloseRequest();
            }
        }
        //释放静态变量
        public static void ReleaseStaticMember()
        {
            if (s_BattleManager != null)
            {
                s_BattleManager.Destroy();
                s_BattleManager = null;
            }



            if (s_TimerManager != null)
            {
                s_TimerManager.Destroy();
                s_TimerManager = null;
            }
            //if (s_JBmanager != null)
            //{
            //    s_JBmanager.Destroy();
            //    s_JBmanager = null;
            //}

            MessageManager.UnregMessages();

            //NetworkManager.Destroy();


            //DataManager.Destroy();



            //释放所有的循环实例
            if (s_ProcLogIn != null) s_ProcLogIn = null;
            if (s_ProcBattle != null) s_ProcBattle = null;
            if (s_ProcLobby != null) s_ProcLobby = null;
            s_ProcPrev = s_ActiveProcedure = null;

            if (s_MainHotFixManager != null)
            {
                s_MainHotFixManager.OnApplicationQuit();
                s_MainHotFixManager.Destroy();
                s_MainHotFixManager = null;
            }
            if(s_MainHotFixManager_SystemDll != null)
            {
                s_MainHotFixManager_SystemDll.OnApplicationQuit();
                s_MainHotFixManager_SystemDll.Destroy();
                s_MainHotFixManager_SystemDll = null;
            }
            s_EventManager = null;

            //PrefabLoaderManager.Destroy();
        }
        //消息主循环
        public static void Update()
        {
            //PrefabLoaderManager.Update();

            Tool.s_UpdateOnceFrame.SafeInvoke(UnityEngine.Time.deltaTime);
            InputManager.Update();

            TickActive();


            //NetworkManager.Update();
            //s_JBmanager.Update();
            s_BattleManager.Update();
            s_TimerManager.Update();

            if (s_MainHotFixManager != null)
            {
                s_MainHotFixManager.Update();
            }
            if(s_MainHotFixManager_SystemDll!= null)
            {
                s_MainHotFixManager_SystemDll.Update();
            }
        }

        public static void SetProcedureStatus(int state)
        {
            s_ActiveProcedure.SetStatus(state);
        }
        public static int GetProcedureStatus()
        {
            return s_ActiveProcedure.GetStatus();
        }
        protected int m_Status;
        protected  void SetStatus(int state)
        {
            m_Status = state;
        }
        protected  int GetStatus()
        {
            return m_Status;
        }
        //得到当前激活的循环
        public static CGameProcedure GetActiveProcedure()
        {
            return s_ActiveProcedure;
        }
        //主窗口是否处于激活状态
        public static bool IsWindowActive()
        {
            return m_bActive;
        }


        protected static CGameProcedure getPreProcedure()
        {
            return s_ProcPrev;
        }


        protected abstract void Init();
        protected abstract void Tick();
        protected virtual void Release()
        {
        }
        protected virtual void CloseRequest()
        {

        }

        public static void SetDisconnect(bool disconnect)
        {
            m_bDisconnect = disconnect;
        }
        public static  bool IsDisconnect()
        {
            return m_bDisconnect;
        }

        public static bool m_bNeedFreshMinimap { get; set; }

        public static bool m_bWaitNeedFreshMinimap { get; set; }

    }
}
