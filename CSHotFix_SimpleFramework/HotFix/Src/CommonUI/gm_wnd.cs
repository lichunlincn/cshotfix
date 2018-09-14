using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using GameDll;
using UnityUI;

namespace HotFix
{
    public class gm_wnd : WindowBase
    {
        InputField m_txtCmd = null;
        Button m_btnExecute = null;
        Button m_btnHide = null;
        private bool m_bHideWnd = true;
        protected override void OnInitComponent()
        {
            m_btnExecute = GetControl<Button>("WindowContent/btnexecute");
            m_btnHide = GetControl<Button>("WindowContent/btnhide");
            m_txtCmd = GetControl<InputField>("WindowContent/txtcmd");

            m_txtCmd.text = "open XXX";
            UIInterface.AddListener(m_btnExecute, UIEventType.onClick, OnClickExecute);
            UIInterface.AddListener(m_btnHide, UIEventType.onClick, OnHide);

        }

        private void OnHide(GameObject go)
        {
            m_bHideWnd = !m_bHideWnd;
            m_btnExecute.gameObject.SetActive(m_bHideWnd);
            m_txtCmd.gameObject.SetActive(m_bHideWnd);
        }

        protected override void OnDestroy()
        {
            UIInterface.RemoveListener(m_btnExecute, UIEventType.onClick);
            UIInterface.RemoveListener(m_btnHide, UIEventType.onClick);
        }

        void OnClickExecute(GameObject obj)
        {
            string cmd = m_txtCmd.text.Trim();
            if (!string.IsNullOrEmpty(cmd))
            {
                GMManager.GetInstance().SendGM(cmd);
            }

        }
    }
}
