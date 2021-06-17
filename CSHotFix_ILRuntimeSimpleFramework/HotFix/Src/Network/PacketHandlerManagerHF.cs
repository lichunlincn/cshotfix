using System;
using System.Collections.Generic;

using System.Text;
using System.Collections;
using UnityEngine;
namespace HotFix
{
    public class PacketHandlerManagerHF
    {

        public delegate void PacketHandler(WfPacket p);
        protected static Dictionary<int, PacketHandler> m_Handlers = new Dictionary<int, PacketHandler>();
        public static void Register(int msg, PacketHandler handler)
        {
            m_Handlers[msg] = handler;
        }
        public static void Unregister(int msg)
        {
            if (m_Handlers.ContainsKey(msg))
            {
                m_Handlers.Remove(msg);
            }
        }
        public static void ProcessPacket(int msgType,int msgLength, WfPacket packet)
        {
            //此时包内已经处理了ReadHeader
            if (m_Handlers.ContainsKey(msgType))
            {
                try
                {
                    m_Handlers[msgType](packet);
                }
                catch (Exception ex)
                {
                    Debug.LogException(ex);
                }
            }
        }
    }

}