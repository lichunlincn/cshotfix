using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using GameDll;
using LCL;
using UnityEngine;

namespace HotFix
{ 
    public class StartApplication
    {
        public static void OnAppInitOk()
        {
            loading_wnd.OpenLoading();
        }
    }
}
