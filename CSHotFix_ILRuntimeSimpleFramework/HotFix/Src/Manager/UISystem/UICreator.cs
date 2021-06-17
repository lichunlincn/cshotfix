using System;
using System.Collections.Generic;
using System.Text;
using GameDll;

namespace HotFix
{
    public  class UICreator
    {

        public static WindowBase GetUIInstance(string uifile, params object[] data)
        {
            WindowBase ui = null;
            Type t = Type.GetType("HotFix."+uifile);
            if (t == null)
            {
                UnityEngine.Debug.LogError("HotFix 实例化失败，" + uifile);
                return null;
            }
            ui = (WindowBase)Activator.CreateInstance(t);
            return ui;
        }
    }
}
