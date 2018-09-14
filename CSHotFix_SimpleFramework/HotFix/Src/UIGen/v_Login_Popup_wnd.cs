//功能：Login_Popup_wnd的窗口配置文件
//工具作者：lichunlin
//生成时间：7/2/2018 4:37:55 PM
//描述：以下文件是自动生成的，任何手动修改都会被下次自动生成覆盖。

using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityUI;
namespace HotFix
{
     public class v_Login_Popup_wnd
     {
          //Login_Popup_wnd/
          public ComponentBridge m_Bridge;

          //Login_Popup_wnd/WindowContent/bg
          public Image m_bg_Image;

          //Login_Popup_wnd/WindowContent/btnLogin
          public Button m_btnLogin_Button;

          //Login_Popup_wnd/WindowContent/txtUserName
          public InputField m_txtUserName_InputField;

          //Login_Popup_wnd/WindowContent/txtPassword
          public InputField m_txtPassword_InputField;

          //Login_Popup_wnd/WindowContent/txtPort
          public InputField m_txtPort_InputField;

          //Login_Popup_wnd/WindowContent/txtIp
          public InputField m_txtIp_InputField;

          //Login_Popup_wnd/WindowContent/toggleServer
          public Toggle m_toggleServer_Toggle;

          //Login_Popup_wnd/WindowContent/bgsound
          public UITransform m_bgsound_UITransform;

          //Login_Popup_wnd/WindowContent/btnStart
          public Button m_btnStart_Button;

          //Login_Popup_wnd/WindowContent/btnTestUI
          public Button m_btnTestUI_Button;

          //Login_Popup_wnd/WindowContent/btnTestUI2
          public Button m_btnTestUI2_Button;

          //Login_Popup_wnd/WindowContent/btnTestUI3
          public Button m_btnTestUI3_Button;

          //Login_Popup_wnd/WindowContent/txtIp/Text
          public Text m_Text_Text;

          //Login_Popup_wnd/WindowContent/toggleServer/Label
          public Text m_Label_Text;

          //Login_Popup_wnd/WindowContent/toggleServer/Background
          public Image m_Background_Image;

          //Login_Popup_wnd/WindowContent/btnTestUI/bg
          public Image m_bg_new_Image;

          //Login_Popup_wnd/WindowContent/btnTestUI2/bg
          public Image m_bg_new_new_Image;

          //Login_Popup_wnd/WindowContent/btnTestUI2/txt
          public Text m_txt_Text;

          //Login_Popup_wnd/WindowContent/btnTestUI/txt
          public Text m_txt_new_Text;

          public void InitComponent(GameObject go)
          {
               m_Bridge = go.GetComponent(typeof(ComponentBridge)) as ComponentBridge;
               m_bg_Image = m_Bridge.GetControl(0) as Image;
               m_btnLogin_Button = m_Bridge.GetControl(1) as Button;
               m_txtUserName_InputField = m_Bridge.GetControl(2) as InputField;
               m_txtPassword_InputField = m_Bridge.GetControl(3) as InputField;
               m_txtPort_InputField = m_Bridge.GetControl(4) as InputField;
               m_txtIp_InputField = m_Bridge.GetControl(5) as InputField;
               m_toggleServer_Toggle = m_Bridge.GetControl(6) as Toggle;
               m_bgsound_UITransform = m_Bridge.GetControl(7) as UITransform;
               m_btnStart_Button = m_Bridge.GetControl(8) as Button;
               m_btnTestUI_Button = m_Bridge.GetControl(9) as Button;
               m_btnTestUI2_Button = m_Bridge.GetControl(10) as Button;
               m_btnTestUI3_Button = m_Bridge.GetControl(11) as Button;
               m_Text_Text = m_Bridge.GetControl(12) as Text;
               m_Label_Text = m_Bridge.GetControl(13) as Text;
               m_Background_Image = m_Bridge.GetControl(14) as Image;
               m_bg_new_Image = m_Bridge.GetControl(15) as Image;
               m_bg_new_new_Image = m_Bridge.GetControl(16) as Image;
               m_txt_Text = m_Bridge.GetControl(17) as Text;
               m_txt_new_Text = m_Bridge.GetControl(18) as Text;
          }
     }
}

