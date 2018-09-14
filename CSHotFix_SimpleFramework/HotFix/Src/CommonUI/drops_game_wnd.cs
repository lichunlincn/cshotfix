using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityUI;

namespace HotFix
{
    public class drops_game_wnd : WindowBase
    {
        private Text m_lbtips = null;
        private Button m_btnLogin = null;

        protected override void OnInitComponent()
        {
            m_lbtips = GetControl<Text>("WindowContent/lbtips");
            m_btnLogin = GetControl<Button>("WindowContent/btnLogin");

            UIInterface.AddListener(m_btnLogin, UIEventType.onClick, OnClickLogin);
        }

        protected override void OnDestroy()
        {              
            UIInterface.RemoveListener(m_btnLogin, UIEventType.onClick); 
        }

        void OnClickLogin(GameObject obj)
        {
           // CGameProcedure.SetProcedureStatus(LoginStatus.ReLoginGameServer);
           //  SetVisiable(false);
        }
    }
}
