using System;
using System.Collections.Generic;
using System.Text;

namespace GameDll
{
    public class MessageManager
    {
        private static List<BaseMessage> m_MsgList = new List<BaseMessage>();
        public static void RegMessages()
        {
            InitMessage(BattleMessage.GetInstance());
            //InitMessage(LoginMessage.GetInstance());
            //InitMessage(LobbyMessage.GetInstance());
        }
        private static void InitMessage(BaseMessage msg)
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
                BaseMessage msg = m_MsgList[i];
                msg.RemoveMessage();
            }
            m_MsgList.Clear();
            UnityEngine.Debug.Log("MessageManager UnregMessages");
        }
    }
}
