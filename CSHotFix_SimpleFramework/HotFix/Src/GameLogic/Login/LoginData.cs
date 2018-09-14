using System;
using System.Collections.Generic;
using System.Text;

namespace HotFix
{
    // login server 状态.
    public enum GameServerStatus
    {
        Full = 0,   // 爆满
        Busy,		 // 拥挤
        Normal,	 // 正常
        Idle,		 // 空闲
        Stop,		 // 维护

    };

    // 网关结构信息
    public class LoginServerInfo
    {
        public string m_szIp;									// ip地址				
        public int m_iPort;										// 端口号
    };
    // 游戏服务器结构信息
    public class GameServerInfo
    {
        public string m_szLoginServerName;						// login server的名字
        public string m_szIp;									// ip地址				
        public int m_iPort;										// 端口号
        public uint m_AccountId;
        public string m_SessionId;
        public GameServerStatus m_Status;                    //当前游戏服务器状态
    };

    public class LoginData
    {
        public LoginServerInfo m_LoginInfo = new LoginServerInfo();
        public List<GameServerInfo> m_GameServers = new List<GameServerInfo>();

        public int m_nCurrentSelectIndex = 0;
        public GameServerInfo GetCurrentGameServer()
        {
            return m_GameServers[0];
        }
    }
}
