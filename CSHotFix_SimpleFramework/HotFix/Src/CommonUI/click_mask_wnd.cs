using System;
using System.Collections.Generic;

using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityUI;

namespace HotFix
{
    public delegate void ClickCloseFuncPtr();
    //点击关闭界面
    public class click_mask_wnd : WindowBase
    {
        private List<ClickCloseFuncPtr> m_MaskUIList = new List<ClickCloseFuncPtr>();
        private Button m_BtnMask = null;
        protected override void OnInitComponent()
        {
            m_BtnMask = GetControl<Button>("WindowContent/mask");
            UIInterface.AddListener(m_BtnMask, UIEventType.onClick, OnClose);
        }

        protected override void OnDestroy()
        {
            UIInterface.RemoveListener(m_BtnMask, UIEventType.onClick);            
        }


        void OnClose(GameObject go)
        {
            int count =m_MaskUIList.Count; 
            if (count>0)
            {
                ClickCloseFuncPtr func = m_MaskUIList[count - 1];
                func();
                m_MaskUIList.RemoveAt(count - 1);
                count--;
            }
            if (count==0)
            {
                UIManager.WindowClose(this);
            }
        }
        public void AddMask(ClickCloseFuncPtr func)
        {
            m_MaskUIList.Add(func);
        }

        
    }
}
