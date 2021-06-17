using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;

public enum emInputEvent{
	emInputEvent_MovePath = 1,
	emInputEvent_StopMove = 2,
	emInputEvent_SelObj = 3,
	emInputEvent_CreateObj = 4,
	emInputEvent_UseSkill = 5,
	emInputEvent_Move = 0,
}

public enum emPacket_Battle{
	em_Battle_Begin = 3840,
	em_SC_PreBattle = 3841,
	em_CS_LoadSceneOk = 3842,
	em_SC_PrepareOk = 3843,
	em_SC_StartBattle = 3844,
	em_CS_InputEvent = 3845,
	em_SC_Fps = 3846,
	em_Battle_End = 4095,
}

public class t_PreparePlayerData : ISerializePacket
{
	public uint m_playerid;
	public String m_name = String.Empty;
	public uint m_jobid;
	public override void New(object param)
	{
 		int _TempSize = 0; 
		m_playerid = default(uint);
		m_name = String.Empty;
		m_jobid = default(uint);
 
	} 


	//public override void Serialize( WfPacket w )
	//{
	//	w.Write( m_playerid);
	//	w.Write( m_name);
	//	w.Write( m_jobid);
	//}
	//public override void DeSerialize( WfPacket r )
	//{
	//	 m_playerid = r.ReadUInt();
	//	 m_name = r.ReadString();
	//	 m_jobid = r.ReadUInt();
	//}
	public override void DestroyClass()
	{
		PooledClassManager<t_PreparePlayerData>.DeleteClass(this);
	}
}

public class SC_PreBattle : ISerializePacket
{
	public List<t_PreparePlayerData> datas = new List<t_PreparePlayerData>();
	public override void New(object param)
	{
 		int _TempSize = 0; 

		_TempSize =  datas.Count;
		for( int i =0;i< _TempSize;++i)
		{
			var _var = datas[i];
			_var.DestroyClass();
			_var = null;
		}
		datas.Clear();
 
	} 


	//public override void Serialize( WfPacket w )
	//{
	//	int _TempSize = 0;
	//	_TempSize = datas.Count;
	//	w.Write( _TempSize );
	//	for(int i = 0; i < _TempSize; ++i)
	//	{
	//		var _var = datas[i];
	//		_var.Serialize(w);
	//	}

	//}
	//public override void DeSerialize( WfPacket r )
	//{
	//	int _TempSize = 0;
	//	_TempSize =  r.ReadInt();
	//	for( int i =0;i< _TempSize;++i)
	//	{
	//		var _var = new t_PreparePlayerData(); 
	//		_var.DeSerialize(r);
	//		datas.Add(_var);
	//	}

	//}
	public override void DestroyClass()
	{
		PooledClassManager<SC_PreBattle>.DeleteClass(this);
	}
}

public class SC_PrepareOk : ISerializePacket
{
	public List<t_PreparePlayerData> datas = new List<t_PreparePlayerData>();
	public override void New(object param)
	{
 		int _TempSize = 0; 

		_TempSize =  datas.Count;
		for( int i =0;i< _TempSize;++i)
		{
			var _var = datas[i];
			_var.DestroyClass();
			_var = null;
		}
		datas.Clear();
 
	} 


	//public override void Serialize( WfPacket w )
	//{
	//	int _TempSize = 0;
	//	_TempSize = datas.Count;
	//	w.Write( _TempSize );
	//	for(int i = 0; i < _TempSize; ++i)
	//	{
	//		var _var = datas[i];
	//		_var.Serialize(w);
	//	}

	//}
	//public override void DeSerialize( WfPacket r )
	//{
	//	int _TempSize = 0;
	//	_TempSize =  r.ReadInt();
	//	for( int i =0;i< _TempSize;++i)
	//	{
	//		var _var = new t_PreparePlayerData(); 
	//		_var.DeSerialize(r);
	//		datas.Add(_var);
	//	}

	//}
	public override void DestroyClass()
	{
		PooledClassManager<SC_PrepareOk>.DeleteClass(this);
	}
}

public class CS_LoadSceneOk : ISerializePacket
{
	public uint m_RoomId;
	public override void New(object param)
	{
 		int _TempSize = 0; 
		m_RoomId = default(uint);
 
	} 


	//public override void Serialize( WfPacket w )
	//{
	//	w.Write( m_RoomId);
	//}
	//public override void DeSerialize( WfPacket r )
	//{
	//	 m_RoomId = r.ReadUInt();
	//}
	public override void DestroyClass()
	{
		PooledClassManager<CS_LoadSceneOk>.DeleteClass(this);
	}
}

public class Packet_Move : ISerializePacket
{
	public int m_ObjId;
	public int m_x;
	public int m_z;
	public override void New(object param)
	{
 		int _TempSize = 0; 
		m_ObjId = default(int);
		m_x = default(int);
		m_z = default(int);
 
	} 


	//public override void Serialize( WfPacket w )
	//{
	//	w.Write( m_ObjId);
	//	w.Write( m_x);
	//	w.Write( m_z);
	//}
	//public override void DeSerialize( WfPacket r )
	//{
	//	 m_ObjId = r.ReadInt();
	//	 m_x = r.ReadInt();
	//	 m_z = r.ReadInt();
	//}
	public override void DestroyClass()
	{
		PooledClassManager<Packet_Move>.DeleteClass(this);
	}
}

public class Packet_MovePath : ISerializePacket
{
	public int m_ObjId;
	public int m_curx;
	public int m_curz;
	public List<int> m_xlist = new List<int>();
	public List<int> m_zlist = new List<int>();
	public override void New(object param)
	{
 		int _TempSize = 0; 
		m_ObjId = default(int);
		m_curx = default(int);
		m_curz = default(int);
		m_xlist.Clear();
		m_zlist.Clear();
 
	} 


	//public override void Serialize( WfPacket w )
	//{
	//	w.Write( m_ObjId);
	//	w.Write( m_curx);
	//	w.Write( m_curz);
	//	int _TempSize = 0;
	//	_TempSize = m_xlist.Count;
	//	w.Write( _TempSize );
	//	for(int i = 0; i < _TempSize; ++i)
	//	{
	//		var _var = m_xlist[i];
	//		w.Write(_var);
	//	}

	//	_TempSize = m_zlist.Count;
	//	w.Write( _TempSize );
	//	for(int i = 0; i < _TempSize; ++i)
	//	{
	//		var _var = m_zlist[i];
	//		w.Write(_var);
	//	}

	//}
	//public override void DeSerialize( WfPacket r )
	//{
	//	 m_ObjId = r.ReadInt();
	//	 m_curx = r.ReadInt();
	//	 m_curz = r.ReadInt();
	//	int _TempSize = 0;
	//	_TempSize =  r.ReadInt();
	//	for( int i =0;i< _TempSize;++i)
	//	{
	//		int _var = r.ReadInt();
	//		m_xlist.Add(_var);
	//	}

	//	_TempSize =  r.ReadInt();
	//	for( int i =0;i< _TempSize;++i)
	//	{
	//		int _var = r.ReadInt();
	//		m_zlist.Add(_var);
	//	}

	//}
	public override void DestroyClass()
	{
		PooledClassManager<Packet_MovePath>.DeleteClass(this);
	}
}

public class Packet_StopMove : ISerializePacket
{
	public int m_ObjId;
	public override void New(object param)
	{
 		int _TempSize = 0; 
		m_ObjId = default(int);
 
	} 


	//public override void Serialize( WfPacket w )
	//{
	//	w.Write( m_ObjId);
	//}
	//public override void DeSerialize( WfPacket r )
	//{
	//	 m_ObjId = r.ReadInt();
	//}
	public override void DestroyClass()
	{
		PooledClassManager<Packet_StopMove>.DeleteClass(this);
	}
}

public class Packet_SelObj : ISerializePacket
{
	public int m_PlayerId;
	public int m_ObjId;
	public override void New(object param)
	{
 		int _TempSize = 0; 
		m_PlayerId = default(int);
		m_ObjId = default(int);
 
	} 


	//public override void Serialize( WfPacket w )
	//{
	//	w.Write( m_PlayerId);
	//	w.Write( m_ObjId);
	//}
	//public override void DeSerialize( WfPacket r )
	//{
	//	 m_PlayerId = r.ReadInt();
	//	 m_ObjId = r.ReadInt();
	//}
	public override void DestroyClass()
	{
		PooledClassManager<Packet_SelObj>.DeleteClass(this);
	}
}

public class Packet_CreateObj : ISerializePacket
{
	public int m_TemplateId;
	public int m_ObjectType;
	public int m_EntityId;
	public override void New(object param)
	{
 		int _TempSize = 0; 
		m_TemplateId = default(int);
		m_ObjectType = default(int);
		m_EntityId = default(int);
 
	} 


	//public override void Serialize( WfPacket w )
	//{
	//	w.Write( m_TemplateId);
	//	w.Write( m_ObjectType);
	//	w.Write( m_EntityId);
	//}
	//public override void DeSerialize( WfPacket r )
	//{
	//	 m_TemplateId = r.ReadInt();
	//	 m_ObjectType = r.ReadInt();
	//	 m_EntityId = r.ReadInt();
	//}
	public override void DestroyClass()
	{
		PooledClassManager<Packet_CreateObj>.DeleteClass(this);
	}
}

public class Packet_UseSkill : ISerializePacket
{
	public int m_ObjId;
	public uint m_SkillId;
	public int m_x;
	public int m_y;
	public int m_TargetId;
	public override void New(object param)
	{
 		int _TempSize = 0; 
		m_ObjId = default(int);
		m_SkillId = default(uint);
		m_x = default(int);
		m_y = default(int);
		m_TargetId = default(int);
 
	} 


	//public override void Serialize( WfPacket w )
	//{
	//	w.Write( m_ObjId);
	//	w.Write( m_SkillId);
	//	w.Write( m_x);
	//	w.Write( m_y);
	//	w.Write( m_TargetId);
	//}
	//public override void DeSerialize( WfPacket r )
	//{
	//	 m_ObjId = r.ReadInt();
	//	 m_SkillId = r.ReadUInt();
	//	 m_x = r.ReadInt();
	//	 m_y = r.ReadInt();
	//	 m_TargetId = r.ReadInt();
	//}
	public override void DestroyClass()
	{
		PooledClassManager<Packet_UseSkill>.DeleteClass(this);
	}
}

