using System;
using System.Collections.Generic;

using System.Text;

//封包解包类
public class ISerializePacketHF:PooledClassObjectHF
{

    public ISerializePacketHF()
    {
    }
    public virtual void Serialize(WfPacket w)
    {
    }
    public virtual void DeSerialize(WfPacket r)
    {
    }

    public override void New(object param)
    {
    }

    public override void Delete()
    {
    }
}

