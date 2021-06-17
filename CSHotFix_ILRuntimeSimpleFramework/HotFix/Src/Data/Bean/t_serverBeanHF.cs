/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_serverBeanHF
 */
using System.IO;
using System.Collections.Generic;
public class t_serverBeanHF
{
    public int t_id;
    public string t_ip;
    public int t_port;
    private static Dictionary<int, t_serverBeanHF> m_Dic = new Dictionary<int, t_serverBeanHF>(); 
    public static t_serverBeanHF GetConfig(int key)
    { 
        t_serverBeanHF bean = null;
        
        if (m_Dic.TryGetValue(key, out bean))
        {
            return bean;
        }
        else
        {
            bean = GetConfigImp(key);
            m_Dic.Add(key, bean);
            return bean;
        }
    }
    public static void ClearConfig()
    {
        m_Dic.Clear();
    }
    private static t_serverBeanHF GetConfigImp(int key)
    {
        t_serverBeanHF bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_serverBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_serverBeanHF();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_ip = GameDll.DataManager.ReadString();
            bean.t_port = GameDll.DataManager.ReadInt();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_serverBeanHF Id:"+key);
            return null;
        }
        return bean; 
    }
}