using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;

public enum emPacket_Notice{
	em_BattleResult_Begin = 0,
	em_BattleResult_End = 767,
	em_SC_CommonNotice = 531,
}

public class SC_CommonNotice : ISerializePacketHF
{
	public String m_content = String.Empty;
	public override void New(object param)
	{
 		int _TempSize = 0; 
		m_content = String.Empty;
 
	} 


	public override void Serialize( WfPacket w )
	{
		w.Write( m_content);
	}
	public override void DeSerialize( WfPacket r )
	{
		 m_content = r.ReadString();
	}
	public override void DestroyClass()
	{
		PooledClassManagerHF<SC_CommonNotice>.DeleteClass(this);
	}
}

