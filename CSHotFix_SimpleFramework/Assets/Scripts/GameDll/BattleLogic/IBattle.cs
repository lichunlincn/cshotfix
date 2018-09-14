using System;
using System.Collections.Generic;
using System.Text;

namespace GameDll
{
    public enum BattleType
    {
        TreasureBattle

    }
    public class IBattle
    {
        protected BattleType m_BattleType = BattleType.TreasureBattle;
        private uint m_RandomSeed = 1000121;
        public virtual void Init()
        {
            //先设置整个战斗的随机种子
            ///LRandom.Seed(m_RandomSeed);
            CGameProcedure.s_EventManager.OnSceneLoadEvent += OnSceneLoaded;
            CGameProcedure.s_EventManager.OnPrepareOkEvent += OnPreparedBattle;
        }
        //服务器返回各种数据完毕，可以操作了。
        protected virtual void OnPreparedBattle()
        {
            
        }


        public virtual void Update()
        {

        }
        //对接帧更新逻辑
        public virtual void FpsUpdate(float t)
        {

        }
        public virtual void Destroy()
        {
            CGameProcedure.s_EventManager.OnSceneLoadEvent -= OnSceneLoaded;
            CGameProcedure.s_EventManager.OnPrepareOkEvent -=OnPreparedBattle;
        }
        protected virtual void LoadScene()
        {

        }
        protected virtual void OnSceneLoaded(bool ok)
        {
            
        }
        //public virtual UScene GetScene()
        //{
        //    return null;
        //}
        //public virtual CameraManager GetCameraManager()
        //{
        //    return null;
        //}
        //public virtual LockStepManager GetLockStepManager()
        //{
        //    return null;
        //}
        //public virtual CommandManager GetCmdManager()
        //{
        //    return null;
        //}
        //public virtual BattleLogManager GetLogManager()
        //{
        //    return null;
        //}
        //public virtual BattleProgress GetProgress()
        //{
        //    return null;
        //}
    }
}
