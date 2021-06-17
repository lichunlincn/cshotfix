using System;
using System.Collections.Generic;
using System.Text;
using GameDll;

namespace HotFix
{
    public class MessageManagerHF
    {
        private static List<BaseMessageHF> m_MsgList = new List<BaseMessageHF>();
        public static void RegMessages()
        {
            //InitMessage(BattleMessage.GetInstance());
            InitMessage(LoginMessage.GetInstance());

        }
        private static void InitMessage(BaseMessageHF msg)
        {
            if (msg != null)
            {
                msg.AddMessage();
                m_MsgList.Add(msg);
            }
        }
        public static void UnregMessages()
        {
            int count = m_MsgList.Count;
            for (int i = 0; i < count; ++i)
            {
                BaseMessageHF msg = m_MsgList[i];
                msg.RemoveMessage();
            }
            m_MsgList.Clear();
        }
    }
}
