using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameDll;

namespace HotFix
{
    public class ProcedureEvent
    {
        public static void RegEvent()
        {

            CGameProcedure.s_EventManager.OnStartApplication_OnAppInitOk += StartApplication.OnAppInitOk;
            CGameProcedure.s_EventManager.OnLoginMessageHF_EnterLoginScene += LoginMessage.GetInstance().EnterLoginScene;



        }
        public static void UnregEvent()
        {

            CGameProcedure.s_EventManager.OnStartApplication_OnAppInitOk -= StartApplication.OnAppInitOk;
            CGameProcedure.s_EventManager.OnLoginMessageHF_EnterLoginScene -= LoginMessage.GetInstance().EnterLoginScene;



        }
    }
}
