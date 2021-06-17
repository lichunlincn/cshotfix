//功能：TestBridgeUI_Popup_wnd的窗口配置文件
//工具作者：lichunlin
//生成时间：5/31/2018 2:34:38 PM
//描述：以下文件是自动生成的，任何手动修改都会被下次自动生成覆盖。

using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityUI;
namespace HotFix
{
     public class v_TestBridgeUI_Popup_wnd
     {
          //TestBridgeUI_Popup_wnd/
          public ComponentBridge m_Bridge;

          //TestBridgeUI_Popup_wnd/WindowContent/togglegroup_1
          public ToggleGroup m_togglegroup_1_ToggleGroup;

          //TestBridgeUI_Popup_wnd/WindowContent/togglegroup_2
          public ToggleGroup m_togglegroup_2_ToggleGroup;

          //TestBridgeUI_Popup_wnd/WindowContent/dropdown_4_1_
          public Image m_dropdown_4_1__Image;

          public void InitComponent(GameObject go)
          {
               m_Bridge = go.GetComponent(typeof(ComponentBridge)) as ComponentBridge;
               m_togglegroup_1_ToggleGroup = m_Bridge.GetControl(0) as ToggleGroup;
               m_togglegroup_2_ToggleGroup = m_Bridge.GetControl(1) as ToggleGroup;
               m_dropdown_4_1__Image = m_Bridge.GetControl(2) as Image;
          }
          public class v_GameObject
          {
               //GameObject/
               public ComponentBridge m_Bridge;

               //GameObject/button_1
               public Button m_button_1_Button;

               //GameObject/button_2
               public Button m_button_2_Button;

               public void InitComponent(GameObject go)
               {
                    m_Bridge = go.GetComponent(typeof(ComponentBridge)) as ComponentBridge;
                    m_button_1_Button = m_Bridge.GetControl(0) as Button;
                    m_button_2_Button = m_Bridge.GetControl(1) as Button;
               }
               public class v_GameObject_1_
               {
                    //GameObject_1_/
                    public ComponentBridge m_Bridge;

                    //GameObject_1_/uitransform_3/button_1
                    public Button m_button_1_Button;

                    //GameObject_1_/uitransform_2
                    public UITransform m_uitransform_2_UITransform;

                    //GameObject_1_/uitransform_3
                    public UITransform m_uitransform_3_UITransform;

                    public void InitComponent(GameObject go)
                    {
                         m_Bridge = go.GetComponent(typeof(ComponentBridge)) as ComponentBridge;
                         m_button_1_Button = m_Bridge.GetControl(0) as Button;
                         m_uitransform_2_UITransform = m_Bridge.GetControl(1) as UITransform;
                         m_uitransform_3_UITransform = m_Bridge.GetControl(2) as UITransform;
                    }
               }
          }
     }
}

