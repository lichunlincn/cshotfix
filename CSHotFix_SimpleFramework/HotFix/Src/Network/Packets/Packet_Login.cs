using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;

public enum emLoginResult{
	emLoginResult_Failed = 1,
	emLoginResult_Timeout = 2,
	emLoginResult_OK = 0,
	emLoginResult_None = 255,
}

public enum emPacket_Login{
	EM_CS_Login = 257,
	EM_SC_LoginRst = 258,
	EM_CS_Register = 259,
	EM_SC_RegisterRst = 260,
	EM_CS_LoginGateWay = 261,
	EM_SC_LoginGateWayRst = 262,
	em_SC_PlayerInfo = 263,
}

public class CS_Login : ISerializePacketHF
{
	public int m_type;
	public String m_account = String.Empty;
	public String m_pwd = String.Empty;
	public String m_equipment = String.Empty;
	public String m_machine = String.Empty;
	public override void New(object param)
	{
 		int _TempSize = 0; 
		m_type = default(int);
		m_account = String.Empty;
		m_pwd = String.Empty;
		m_equipment = String.Empty;
		m_machine = String.Empty;
 
	} 


	public override void Serialize( WfPacket w )
	{
		w.Write( m_type);
		w.Write( m_account);
		w.Write( m_pwd);
		w.Write( m_equipment);
		w.Write( m_machine);
	}
	public override void DeSerialize( WfPacket r )
	{
		 m_type = r.ReadInt();
		 m_account = r.ReadString();
		 m_pwd = r.ReadString();
		 m_equipment = r.ReadString();
		 m_machine = r.ReadString();
	}
	public override void DestroyClass()
	{
		PooledClassManagerHF<CS_Login>.DeleteClass(this);
	}
}

public class SC_LoginRst : ISerializePacketHF
{
	public int m_rst;
	public String m_sessionid = String.Empty;
	public override void New(object param)
	{
 		int _TempSize = 0; 
		m_rst = default(int);
		m_sessionid = String.Empty;
 
	} 


	public override void Serialize( WfPacket w )
	{
		w.Write( m_rst);
		w.Write( m_sessionid);
	}
	public override void DeSerialize( WfPacket r )
	{
		 m_rst = r.ReadInt();
		 m_sessionid = r.ReadString();
	}
	public override void DestroyClass()
	{
		PooledClassManagerHF<SC_LoginRst>.DeleteClass(this);
	}
}

public class CS_Register : ISerializePacketHF
{
	public String m_account = String.Empty;
	public String m_pwd = String.Empty;
	public override void New(object param)
	{
 		int _TempSize = 0; 
		m_account = String.Empty;
		m_pwd = String.Empty;
 
	} 


	public override void Serialize( WfPacket w )
	{
		w.Write( m_account);
		w.Write( m_pwd);
	}
	public override void DeSerialize( WfPacket r )
	{
		 m_account = r.ReadString();
		 m_pwd = r.ReadString();
	}
	public override void DestroyClass()
	{
		PooledClassManagerHF<CS_Register>.DeleteClass(this);
	}
}

public class SC_RegisterRst : ISerializePacketHF
{
	public int m_rst;
	public override void New(object param)
	{
 		int _TempSize = 0; 
		m_rst = default(int);
 
	} 


	public override void Serialize( WfPacket w )
	{
		w.Write( m_rst);
	}
	public override void DeSerialize( WfPacket r )
	{
		 m_rst = r.ReadInt();
	}
	public override void DestroyClass()
	{
		PooledClassManagerHF<SC_RegisterRst>.DeleteClass(this);
	}
}

public class CS_LoginGateWay : ISerializePacketHF
{
	public String m_sessionid = String.Empty;
	public override void New(object param)
	{
 		int _TempSize = 0; 
		m_sessionid = String.Empty;
 
	} 


	public override void Serialize( WfPacket w )
	{
		w.Write( m_sessionid);
	}
	public override void DeSerialize( WfPacket r )
	{
		 m_sessionid = r.ReadString();
	}
	public override void DestroyClass()
	{
		PooledClassManagerHF<CS_LoginGateWay>.DeleteClass(this);
	}
}

public class SC_LoginGateWayRst : ISerializePacketHF
{
	public int m_rst;
	public uint m_playerid;
	public override void New(object param)
	{
 		int _TempSize = 0; 
		m_rst = default(int);
		m_playerid = default(uint);
 
	} 


	public override void Serialize( WfPacket w )
	{
		w.Write( m_rst);
		w.Write( m_playerid);
	}
	public override void DeSerialize( WfPacket r )
	{
		 m_rst = r.ReadInt();

	}
	public override void DestroyClass()
	{
		PooledClassManagerHF<SC_LoginGateWayRst>.DeleteClass(this);
	}
}

public class SC_PlayerInfo : ISerializePacketHF
{
	public uint m_playerid;
	public String m_nickname = String.Empty;
	public ulong m_money;
	public override void New(object param)
	{
 		int _TempSize = 0; 
		m_playerid = default(uint);
		m_nickname = String.Empty;
		m_money = default(ulong);
 
	} 


	public override void Serialize( WfPacket w )
	{
		w.Write( m_playerid);
		w.Write( m_nickname);
		w.Write( m_money);
	}
	public override void DeSerialize( WfPacket r )
	{
		 //m_playerid = r.ReadUInt();
		 //m_nickname = r.ReadString();
		 //m_money = r.ReadUInt64();
	}
	public override void DestroyClass()
	{
		PooledClassManagerHF<SC_PlayerInfo>.DeleteClass(this);
	}
}

