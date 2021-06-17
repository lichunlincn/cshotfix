using System;
using System.Collections.Generic;
using System.Text;

namespace GameDll
{
    public class BattleManager
    {
        private IBattle m_Battle = null;
        public void Init()
        {

        }
        public IBattle CreateBattle(BattleType _type)
        {
            IBattle battle = null;
            switch(_type)
            {
                case BattleType.TreasureBattle:
                    {
                        //battle = new TreasureBattle();
                        break;
                    }
                default:
                    break;
            }
            return battle;
        }
        public void EnterBattle(IBattle battle)
        {
            if (battle == null)
            {
                UnityEngine.Debug.LogError("battle == null");
                return;
            }
            if (m_Battle == null)
            {
                m_Battle = battle;
                m_Battle.Init();
            }
        }
        public void Update()
        {
            if (m_Battle != null)
            {
                m_Battle.Update();
            }
        }
        public void LeaveBattle()
        {
            if (m_Battle != null)
            {
                m_Battle.Destroy();
                m_Battle = null;
                CGameProcedure.SetActiveProc(CGameProcedure.s_ProcLobby);
                CGameProcedure.SetProcedureStatus((int)LobbyStatus.None);
            }
        }
        public IBattle GetCurrentBattle()
        {
            return m_Battle;
        }
        public void Destroy()
        {
            LeaveBattle();
            UnityEngine.Debug.Log("BattleManager Destroy");
        }
    }
}
