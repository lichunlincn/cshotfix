using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HotFix
{
    public class HotFixLoop : IGameHotFixInterface
    {
        private static HotFixLoop m_Instance;
        private EventsHF m_EventManagerHF = null;
        private Mono2DllFunction m_Mono2DllFunction = new Mono2DllFunction();


        public override void Start()
        {
            m_Instance = this;
            BugFixManager.IsOpenHotFix = true;
            ProcedureEvent.RegEvent();

            //GameDll.PacketHandlerManager.PacketHandlerMgrHF_ProcessPacket = PacketHandlerManagerHF.ProcessPacket;
            BugFixManager.RegHotFixFunction();

            UIManager.Init();
            MessageManagerHF.RegMessages();
            m_EventManagerHF = new EventsHF();
            GameDll.CGameProcedure.s_EventManager.OnCameraPositionChangedEvent += OnCameraPositionChangedEvent;
            Debug.Log("HotFix Start Ok");
        }
        SC_LoginRst msg = null;
        private int m_count = 0;
        public override void Update()
        {
            if(msg == null)
            {
                msg = new SC_LoginRst();
            }
            if(m_count<10)
            {
                m_count++;
                return;
            }
            m_count = 0;
            for (int i = 0; i < 10; ++i)
            {
                //NetworkManagerHF.SendPacketToMe(msg, (ushort)emPacket_Login.EM_SC_LoginRst);
            }
        }
        public EventsHF GetEvent()
        {
            return m_EventManagerHF;
        }
        private void OnCameraPositionChangedEvent()
        {
            //Debug.Log("huat:");
        }

        public static HotFixLoop GetInstance()
        {
            return m_Instance;
        }

        public override void OnDestroy()
        {

        }
        public override void OnApplicationQuit()
        {
            //ProcedureEvent.UnregEvent();
            UnityEngine.Debug.Log("HotFixLoop OnApplicationQuit");
            UIManager.Destroy();
            MessageManagerHF.UnregMessages();

        }
        public override object OnMono2GameDll(string func, params object[] data)
        {
            return m_Mono2DllFunction.OnMono2GameDll(func, data);
        }
    }
}
