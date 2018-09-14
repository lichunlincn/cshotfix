using LCL;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using GameDll;

namespace HotFix
{
    public class loading_wnd : WindowBase
    {
        private static loading_wnd m_loading_wnd = null;
        public static void OpenLoading()
        {
            if (m_loading_wnd == null)
            {
                m_loading_wnd = UIManager.WindowOpenEX<loading_wnd>(null);
            }
        }
        public static void CloseLoading()
        {
            if(m_loading_wnd != null)
            {
                UIManager.WindowClose(m_loading_wnd);
                m_loading_wnd = null;
            }
        }
        public Text m_txtInfo = null;
        public Text m_lbTips = null;
        public loading_wnd()
        {
            m_Layer = WindowLayer.Loading;
        }
        protected override void OnInitComponent()
        {
            Debug.Log("bind start");
            m_txtInfo = GetControl<Text>("WindowContent/txtinfo");
            m_lbTips = GetControl<Text>( "WindowContent/txttips");

            //不起作用，因为该函数只对root gameobject有用
            //GameObject.DontDestroyOnLoad(m_WinObj);

            m_lbTips.text = "经常清理手机内存，暴击更多哦！";
            Debug.Log("OnOpenUI loading_wnd");
        }



        protected override void OnDestroy()
        {

            
        }
    }
}
