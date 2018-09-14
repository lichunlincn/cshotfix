using System;
using System.Collections.Generic;
using System.Text;
using LCL;
using UnityEngine;

namespace GameDll
{
    //--------------------------------------------------------------
    //登录状态
    public enum StartApplicationStatus
    {
        None,
        FirstOpenGame,
        InitingResMgr,
        AppInitOk,
    };
    /// <summary>
    /// 游戏启动流程
    /// </summary>
    public class CGamePro_StartApplication:CGameProcedure
    {
        protected override void Init()
        {
            m_ProType = EProcedureType.eStart;
            m_Status = (int)StartApplicationStatus.FirstOpenGame;
            
        }
        protected override void Tick()
        {
            switch (m_Status)
            {
                case (int)StartApplicationStatus.FirstOpenGame:
                    {
                        FirstOpenGame();
                        break;
                    }
                case (int)StartApplicationStatus.InitingResMgr:
                    {
                        break;
                    }
                case (int)StartApplicationStatus.AppInitOk:
                    {
                        OnAppInitOk();
                        break;
                    }
            }
        }
        private void FirstOpenGame()
        {
            ResourceManager.Initialize(OnInitResMgr);
            SetStatus((int)StartApplicationStatus.InitingResMgr);
        }
        private void OnAppInitOk()
        {
            CGameProcedure.s_EventManager.OnStartApplication_OnAppInitOk.SafeInvoke();
            SetActiveProc(CGameProcedure.s_ProcLogIn);
        }
        private void OnInitResMgr()
        {
            ShaderManager.CacheShader();
            SetStatus((int)StartApplicationStatus.AppInitOk);
        }
        protected override void Release()
        {
        }
    }
}
