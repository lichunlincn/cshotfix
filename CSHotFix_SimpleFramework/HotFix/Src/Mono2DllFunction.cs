using System;
using System.Collections.Generic;
using System.Text;
using GameDll;

namespace HotFix
{
    public class Mono2DllFunction
    {
        public object OnMono2GameDll(string func, params object[] data)
        {
            if (func == "GameResultMessageHF_OnGameOver")
            {
                //GameResultMessageHF_OnGameOver(data);
            }
            else if(func == "PlayerMyself_GetId")
            {
                return 0;// PlayerMyself_GetId();
            }
            return null;
        }
        //private object PlayerMyself_GetId()
        //{
        //    return PlayerMyself.GetInstance().GetId();
        //}
        //private void GameResultMessageHF_OnGameOver(object[] data)
        //{
        //    GameResultMessageHF.GetInstance().OnGameOver(data);
        //}
    }
}
