//功能：testlist_Popup_wnd的窗口配置文件
//工具作者：lichunlin
//生成时间：6/2/2018 4:05:56 PM
//描述：以下文件是自动生成的，任何手动修改都会被下次自动生成覆盖。

using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityUI;
namespace HotFix
{
     public class v_testlist_Popup_wnd
     {
          //testlist_Popup_wnd/
          public ComponentBridge m_Bridge;

          //testlist_Popup_wnd/WindowContent/my/ScrollViewRoot_1/bigList
          //public LoopListView2 m_bigList_LoopListView2;

          public void InitComponent(GameObject go)
          {
               m_Bridge = go.GetComponent(typeof(ComponentBridge)) as ComponentBridge;
               //m_bigList_LoopListView2 = m_Bridge.GetControl(0) as LoopListView2;
          }
          public class v_ItemPrefab1_c_1
          {
               //ItemPrefab1/
               public ComponentBridge m_Bridge;

               //ItemPrefab1/ItemIcon
               public Image m_ItemIcon_Image;

               //ItemPrefab1/TextName
               public Text m_TextName_Text;

               //ItemPrefab1/starCount
               public Text m_starCount_Text;

               //ItemPrefab1/star
               public Image m_star_Image;

               //ItemPrefab1/TextDesc
               public Text m_TextDesc_Text;

               //ItemPrefab1/smallList
               //public LoopListView2 m_smallList_LoopListView2;

               public void InitComponent(GameObject go)
               {
                    m_Bridge = go.GetComponent(typeof(ComponentBridge)) as ComponentBridge;
                    m_ItemIcon_Image = m_Bridge.GetControl(0) as Image;
                    m_TextName_Text = m_Bridge.GetControl(1) as Text;
                    m_starCount_Text = m_Bridge.GetControl(2) as Text;
                    m_star_Image = m_Bridge.GetControl(3) as Image;
                    m_TextDesc_Text = m_Bridge.GetControl(4) as Text;
                    //m_smallList_LoopListView2 = m_Bridge.GetControl(5) as LoopListView2;
               }
               public class v_ItemPrefab1_c_2
               {
                    //ItemPrefab1/
                    public ComponentBridge m_Bridge;

                    //ItemPrefab1/text_2
                    public Text m_text_2_Text;

                    public void InitComponent(GameObject go)
                    {
                         m_Bridge = go.GetComponent(typeof(ComponentBridge)) as ComponentBridge;
                         m_text_2_Text = m_Bridge.GetControl(0) as Text;
                    }
               }
          }
     }
}

