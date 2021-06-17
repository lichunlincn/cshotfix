using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
namespace UnityUI
{
    public class UGUIRoot
    {
        private static Canvas m_GlobalCanvas = null;
        private static Camera m_UICamera = null;
        public static Canvas GlobalCanvas
        {
            get
            {
                if (m_GlobalCanvas == null)
                {
                    GameObject vas = GameObject.Find("GlobalUI/GlobalCanvas");
                    if (vas != null)
                    {
                        m_GlobalCanvas = vas.GetComponent<Canvas>();
                    }
                }
                return m_GlobalCanvas;
            }
        }
        public static Camera UICamera
        {
            get
            {
                if (m_UICamera == null)
                {
                    m_UICamera = GlobalCanvas.worldCamera;
                }
                return m_UICamera;
            }
        }
    }

}