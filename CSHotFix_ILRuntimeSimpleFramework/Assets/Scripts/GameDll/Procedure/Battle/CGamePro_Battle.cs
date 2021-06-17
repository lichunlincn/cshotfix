using System;
using System.Collections.Generic;
using System.Text;

namespace GameDll
{
    public enum BattleStatus
    {
        None,
        EnterBattle,
        LoadingBattle,
        MainLoop,
        LeaveBattle,
        Exit,
        PrepareBattleOk,
    }
    public class CGamePro_Battle : CGameProcedure
    {
        protected override void Init()
        {

            m_Status = (int)BattleStatus.EnterBattle;
            
            m_ProType = EProcedureType.eBattle;
            
        }
        protected override void Tick()
        {
            switch (m_Status)
            {
                case (int)BattleStatus.EnterBattle:
                    {
                        OnEnterBattle();
                        break;
                    }
                case (int)BattleStatus.LoadingBattle:
                    {
                        OnLoadingBattle();
                        break;
                    }
                case (int)BattleStatus.PrepareBattleOk:
                    {
                        OnPrepareBattleOk();
                        break;
                    }
                case (int)BattleStatus.MainLoop:
                    {
                        break;
                    }
                case (int)BattleStatus.LeaveBattle:
                    {
                        OnLeaveBattle();
                        break;
                    }
                case (int)BattleStatus.Exit:
                    {
                        OnLeaveBattle();
                       // WorldService.GetInstance().LeaveLogin();
                        
                        break;
                    }
            }
        }

        private void OnPrepareBattleOk()
        {
            SetStatus((int)BattleStatus.MainLoop);
            CGameProcedure.s_EventManager.OnPrepareBattleOk.SafeInvoke();
        }

        private void OnLoadingBattle()
        {
            
        }
        private void OnLoadingBattleOk()
        {
            SetStatus((int)BattleStatus.PrepareBattleOk);
        }
        private void OnLeaveBattle()
        {
            CGameProcedure.s_EventManager.OnPrepareOkEvent -= OnLoadingBattleOk;
            SetActiveProc(CGameProcedure.s_ProcLogIn);
            s_BattleManager.LeaveBattle();
        }

        private void OnEnterBattle()
        {
            CGameProcedure.s_EventManager.OnPrepareOkEvent += OnLoadingBattleOk;
            SetStatus((int)BattleStatus.LoadingBattle);

            BattleType battleType = BattleType.TreasureBattle;  
            IBattle battle = s_BattleManager.CreateBattle(battleType);
            s_BattleManager.EnterBattle(battle);
        }


    }
}
