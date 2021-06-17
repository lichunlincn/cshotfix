using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using LCL;

namespace HotFix
{
    public class joystick_wnd : WindowBase
    {
        public joystick_wnd()
        {
            m_Layer = WindowLayer.Hold;
        }
        protected override void OnInitComponent()
        {

        }
        protected override void OnOpen()
        {
            MonoTool.SetMoveBase(false);
        }

        protected override void OnDestroy()
        {    
        }

    }
}
