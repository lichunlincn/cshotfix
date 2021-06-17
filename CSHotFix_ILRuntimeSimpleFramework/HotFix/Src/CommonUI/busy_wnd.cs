using GameDll;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace HotFix
{
    public class busy_wnd : WindowBase
    {
        private Text m_txttips = null;
        public string m_strBusyTips = "";
        private int m_PastTime = 0;
        private string m_Dot = "";
        private Timer m_UpdateTimer = null;
        protected override void OnInitComponent()
        {
            Debug.Log("bind start");
            m_txttips = GetControl<Text>("WindowContent/txttips");
            m_txttips.text = m_strBusyTips;

        }
        protected override void OnOpen()
        {
            m_UpdateTimer = Timer.CreateClass();
            m_UpdateTimer.totalMMSeconds = int.MaxValue;
            m_UpdateTimer.perCall = UpdateText;
            CGameProcedure.s_TimerManager.AddTimer(m_UpdateTimer);
        }
        public void UpdateText(int dt)
        {
            m_PastTime += dt;
            if (m_PastTime >= 500 && m_PastTime < 1000)
            {
                m_Dot = ".";
            }
            else if (m_PastTime >= 1000 && m_PastTime < 1500)
            {
                m_Dot = "..";
            }
            else if (m_PastTime >= 1500 && m_PastTime < 2000)
            {
                m_Dot = "...";
            }
            else
            {
                m_PastTime = 0;
            }
            m_txttips.text = m_strBusyTips + m_Dot;
        }
        protected override void OnClose()
        {
            if (m_UpdateTimer != null)
            {
                CGameProcedure.s_TimerManager.RemoveTimer(m_UpdateTimer.GetId());
                m_UpdateTimer = null;
            }
        }
        protected override void OnDestroy()
        {


        }
    }
}
