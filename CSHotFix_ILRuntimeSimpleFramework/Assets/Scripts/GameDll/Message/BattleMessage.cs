using System;
using System.Collections.Generic;
using System.Text;
using LCL;
using UnityEngine;
namespace GameDll
{
    public class BattleMessage : BaseMessage
    {
        private static BattleMessage m_Instance;
        public static BattleMessage GetInstance()
        {
            if (m_Instance == null)
            {
                m_Instance = new BattleMessage();
            }
            return m_Instance;
        }

        //public override void AddMessage()
        //{
        //    PacketHandlerManager.Register((ushort)emPacket_Battle.em_SC_PrepareOk, ResPrepareOk);
        //    PacketHandlerManager.Register((ushort)emPacket_Battle.em_SC_Fps, OnClientFrame);
        //    PacketHandlerManager.Register((ushort)emPacket_Battle.em_SC_StartBattle, ResStartBattle);
        //    PacketHandlerManager.Register((ushort)emPacket_Battle.em_SC_PreBattle, ResPreBattle);
        //    PacketHandlerManager.Register((ushort)emPacket_Battle.em_Battle_End, ResEndBattle);
        //}



        //public override void RemoveMessage()
        //{
        //    PacketHandlerManager.Unregister((ushort)emPacket_Battle.em_SC_PrepareOk);
        //    PacketHandlerManager.Unregister((ushort)emPacket_Battle.em_SC_Fps);
        //    PacketHandlerManager.Unregister((ushort)emPacket_Battle.em_SC_StartBattle);
        //    PacketHandlerManager.Unregister((ushort)emPacket_Battle.em_SC_PreBattle);
        //    PacketHandlerManager.Unregister((ushort)emPacket_Battle.em_Battle_End);
        //}

        //private void ResEndBattle(WfPacket obj)
        //{

        //    UnityEngine.Debug.Log("ResEndBattle");
        //}

        ////所有的玩家都准备好了，开始加载场景
        //private void ResPreBattle(WfPacket obj)
        //{
        //    SC_PreBattle pak = new SC_PreBattle();
        //    pak.DeSerialize(obj);
        //    var playerdatas = pak.datas;
        //    int id = 0;
        //    CObjectManager.GetInstance().ClearAll();
        //    uint myPlayerId = (uint)CGameProcedure.s_MainHotFixManager.OnMono2GameDll("PlayerMyself_GetId");
        //    foreach (var kv in playerdatas)
        //    {
        //        //创建玩家和实体之间的数据
        //        Player character = CObjectManager.GetInstance().NewObject(2, (int)kv.m_jobid) as Player;
        //        if (character != null)
        //        {
        //            character.InitInstance();
        //            character.SetId(id++);
        //            character.SetPlayer(kv.m_playerid);
        //            character.SetForward(VInt3.forward);
        //        }
        //        if(kv.m_playerid == myPlayerId)
        //        {
        //            CObjectManager.GetInstance().SetMySelf(character);
        //        }
        //        CObjectManager.GetInstance().AddObject(character, true);
        //    }
        //    CGameProcedure.s_EventManager.OnStartLoadLevelEvent.SafeInvoke(1);
        //    UnityEngine.Debug.Log("ResPreBattle  所有的玩家都准备好了，开始加载场景");
        //}

        //private void ResStartBattle(WfPacket obj)
        //{
        //    UnityEngine.Debug.Log("start battle");
        //}

        //private BattleData m_BattleData = new BattleData();
        //public void InitBattle()
        //{
        //    m_BattleData.m_BattleInfo.m_Index = 0;
        //    m_BattleData.m_BattleInfo.m_Key = 0;
        //    m_BattleData.m_BattleInfo.m_szIp = "";
        //    m_BattleData.m_BattleInfo.m_iPort = 0;

        //    NetworkManager.SetKcpHandShakeDelay(2000);
        //    NetworkManager.SetkcpHandShakeRetry(10);
        //    NetworkManager.InitKcpNet(m_BattleData.m_BattleInfo.m_szIp,
        //        m_BattleData.m_BattleInfo.m_iPort,
        //        m_BattleData.m_BattleInfo.m_Index,
        //        m_BattleData.m_BattleInfo.m_Key);


        //}

        //public void ExitBattle()
        //{
        //   NetworkManager.Shutdown( NetworkProtol.Kcp);
        //}



        //uint32 frameId
        //uint32 inputCount
        //for inputCount 
        //   --uint8 inputType
        // --指令数据
        //end
      
        public class ReqUseSkillParam
        {
            public uint skillId;
            public int casterId;
            public int targetId;
            public int x;
            public int z;
        }
       

        ////请求移动
        //public void ReqMove(int id, float x, float z)
        //{
        //    Packet_Move msg = new Packet_Move();
        //    msg.m_ObjId = id;
        //    msg.m_x = (int)( x * 1000 );
        //    msg.m_z = (int)( z * 1000 );

        //    //UnityEngine.Debug.Log("send ReqMove:" + msg.m_x +" "+msg.m_z);

        //    WfPacket pak = PooledClassManager<WfPacket>.CreateClass();
        //    pak.InitWrite((ushort)emPacket_Battle.em_CS_InputEvent);
        //    pak.Write((int)emInputEvent.emInputEvent_Move);
        //    msg.Serialize(pak);
        //    pak.Swap();
        //    NetworkManager.SendPacket(NetworkProtol.Tcp, pak);

        //}
        //public void ReqMovePath(int id, List<int> x, List<int> z)
        //{
        //    Packet_MovePath msg = new Packet_MovePath();
        //    msg.m_ObjId = id;
        //    msg.m_xlist = x;
        //    msg.m_zlist = z;

        //    WfPacket pak = PooledClassManager<WfPacket>.CreateClass();
        //    pak.InitWrite((int)emPacket_Battle.em_CS_InputEvent);
        //    pak.Write((int)emInputEvent.emInputEvent_MovePath);
        //    msg.Serialize(pak);
        //    pak.Swap();
        //    NetworkManager.SendPacket(NetworkProtol.Tcp, pak);
        //}

        //private CCommand OnInputEvent_Move(uint frame, WfPacket packet)
        //{
        //    Packet_Move data = new Packet_Move();
        //    data.DeSerialize(packet);
        //    int id = data.m_ObjId;
        //    CObjectCommand_Move cmd = new CObjectCommand_Move();
        //    cmd.m_ObjId = id;
        //    cmd.m_x = data.m_x;
        //    cmd.m_z = data.m_z;
        //    cmd.m_bMapCheck = true;
        //    cmd.SetLogicCount((int)frame);
        //    //UnityEngine.Debug.Log("recv Move:" + data.m_x + " " + data.m_z);
        //    return cmd;
        //}

        //private void OnInputEvent_MovePath(uint frame, WfPacket packet)
        //{
        //    Packet_MovePath data = new Packet_MovePath();
        //    data.DeSerialize(packet);
        //    int id = (int)data.m_ObjId;
        //    List<int> x = data.m_xlist;
        //    List<int> z = data.m_zlist;


        //    Actor obj = (Actor)CObjectManager.GetInstance().GetObjectById(id);
        //    if (obj != null)
        //    {
        //        obj.OnMovePath(x, z);
        //    }
        //}
        //public void ReqStopMove(int id)
        //{
        //    Packet_StopMove msg = new Packet_StopMove();
        //    msg.m_ObjId = id;
        //    //UnityEngine.Debug.Log("send ReqStopMove");

        //    WfPacket pak = PooledClassManager<WfPacket>.CreateClass();
        //    pak.InitWrite((int)emPacket_Battle.em_CS_InputEvent);
        //    pak.Write((int)emInputEvent.emInputEvent_StopMove);
        //    msg.Serialize(pak);
        //    pak.Swap();
        //    NetworkManager.SendPacket(NetworkProtol.Tcp, pak);
        //}

        //private CCommand OnInputEvent_StopMove(uint frame, WfPacket packet)
        //{
        //    Packet_StopMove data = new Packet_StopMove();
        //    data.DeSerialize(packet);
        //    int id = data.m_ObjId;
        //    CObjectCommand_StopMove cmd = new CObjectCommand_StopMove();
        //    cmd.m_ObjId = id;
        //    cmd.SetLogicCount((int)frame);
        //    return cmd;
        //}
        //private CCommand OnInputEvent_SelObj(uint frameId, WfPacket packet)
        //{
        //    Packet_SelObj data = new Packet_SelObj();
        //    data.DeSerialize(packet);
        //    int id = data.m_ObjId;
        //    int playerId = data.m_PlayerId;
        //    CPlayerCommand_SelObj cmd = new CPlayerCommand_SelObj();
        //    cmd.m_PlayerId = (uint)playerId;
        //    cmd.m_ObjId = id;
        //    cmd.SetLogicCount((int)frameId);
        //    return cmd;
        //}

        //private CCommand OnInputEvent_CreateObj(uint frameId, WfPacket packet)
        //{
        //    Packet_CreateObj data = new Packet_CreateObj();
        //    data.DeSerialize(packet);
        //    int templateid = data.m_TemplateId;
        //    int objecttype = data.m_ObjectType;
        //    int objectId = (int)data.m_EntityId;
        //    //以下操作只是帧同步需要的基本数据，表现层并未真正加载模型等资源。
        //    Entity character = CObjectManager.GetInstance().NewObject(objecttype, templateid);
        //    if (character != null)
        //    {
        //        character.InitInstance();
        //        character.SetId(objectId);
        //    }
        //    CBattleCommand_CreateObj cmd = new CBattleCommand_CreateObj();
        //    cmd.m_TemplateId = templateid;
        //    cmd.m_ObjectType = objecttype;
        //    cmd.m_Object = character;
        //    cmd.SetLogicCount((int)frameId);
        //    return cmd;
        //}

        //private CCommand OnInputEvent_UseSkill(uint frameId, WfPacket packet)
        //{
        //    Packet_UseSkill data = new Packet_UseSkill();
        //    data.DeSerialize(packet);
        //    int ent_id = data.m_ObjId;
        //    int pos_x = data.m_x;
        //    int pos_z = data.m_y;
        //    int targetid = data.m_TargetId;
        //    uint skill_id = data.m_SkillId;

        //    SkillParam_EP ep = new SkillParam_EP();
        //    ep.m_CasterId = ent_id;
        //    ep.m_SkillId = skill_id;
        //    ep.m_x = pos_x;
        //    ep.m_z = pos_z;
        //    ep.m_TargetId = targetid;
        //    CObjectCommand_UseSkill cmd = new CObjectCommand_UseSkill();
        //    cmd.m_ObjId = ent_id;
        //    cmd.m_SkillParam = ep;
        //    cmd.SetLogicCount((int)frameId);
        //    return cmd;
        //}
    }
}
