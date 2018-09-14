using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotFix
{
    public class NetworkManagerHF
    {
        public static void SendPacket(ISerializePacketHF req, int msgType)
        {
            //WfPacket pak = LCL.NetworkManager.CreatePacket();
            //pak.InitWrite((ushort)msgType);
            //req.Serialize(pak);
            //pak.Swap();
            //LCL.NetworkManager.SendPacket(LCL.NetworkProtol.Tcp, pak);
        }

        public static void SendPacketToMe(ISerializePacketHF msg, int msgType)
        {
            //WfPacket pak = LCL.NetworkManager.CreatePacket();
            //pak.InitWrite((ushort)msgType);
            //msg.Serialize(pak);
            //pak.Swap();
            //ushort _msgType = 0;
            //ushort length = 0;
            //pak.ReadHeader(ref _msgType, ref length);
            //PacketHandlerManagerHF.ProcessPacket(msgType, length, pak);
            //pak.DestroyClass();
            //pak = null;

        }
    }
}
