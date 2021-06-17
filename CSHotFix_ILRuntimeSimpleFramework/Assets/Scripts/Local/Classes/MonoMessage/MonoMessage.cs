using System;
using System.Collections.Generic;

using System.Text;


public class MonoMessage
{
    public static void Register()
    {
        //GameDll.PacketHandlerManager.Register((ushort)WfClientPacketsSpecial.ESC_Heart, SC_Heart);
    }
    public static void Unregister()
    {
       // GameDll.PacketHandlerManager.Unregister((ushort)WfClientPacketsSpecial.ESC_Heart);
    }
    //private static void SC_Heart(WfPacket packet)
    //{
    //    long clientAndServerTime = packet.ReadInt64();
    //    Ping.OnPingBack(clientAndServerTime);
    //}
    public static void ReqHeart(long clientTime)
    {
        //WfPacket pak = new WfPacket();
        //pak.InitWrite((ushort)WfClientPacketsSpecial.ECS_Heart);
        //pak.Write(clientTime);
        //LCL.NetworkManager.SendPacket(LCL.NetworkProtol.Tcp,pak);
    }
}

