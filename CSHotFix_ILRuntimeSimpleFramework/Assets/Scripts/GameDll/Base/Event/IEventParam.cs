using System;
using System.Collections.Generic;
using System.Text;

namespace GameDll
{
    public class IEventParam:PooledClassObject
    {


    }
    public class SkillParam_EP : IEventParam
    {
        public override void DestroyClass()
        {
            PooledClassManager<SkillParam_EP>.DeleteClass(this);
        }
        public override void New(object param)
        {
            m_CasterId = 0;
            m_TargetId = 0;
            m_SkillId = 0;
            m_x = 0;
            m_z = 0;
        }
        public int m_CasterId;
        public int m_TargetId;
        public uint m_SkillId;
        public int m_x;
        public int m_z;
    }

    public class PickObjParam : IEventParam
    {
        public override void DestroyClass()
        {
            PooledClassManager<PickObjParam>.DeleteClass(this);
        }
        public override void New(object param)
        {
            //m_PickObjs.Clear();
            m_WhoPick = 0;
        }

        public int m_WhoPick = 0;
    }
}
