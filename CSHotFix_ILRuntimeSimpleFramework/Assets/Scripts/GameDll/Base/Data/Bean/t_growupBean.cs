/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_growupBean
 */
using System.IO;
using System.Collections.Generic;
public class t_growupBean
{
    public int t_id;
    public int t_base_hp;
    public int t_level_hp;
    public int t_base_mp;
    public int t_level_mp;
    private static Dictionary<int, t_growupBean> m_Dic = new Dictionary<int, t_growupBean>(); 
    public static t_growupBean GetConfig(int key)
    { 
        t_growupBean bean = null;
        
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
    private static t_growupBean GetConfigImp(int key)
    {
        t_growupBean bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_growupBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_growupBean();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_base_hp = GameDll.DataManager.ReadInt();
            bean.t_level_hp = GameDll.DataManager.ReadInt();
            bean.t_base_mp = GameDll.DataManager.ReadInt();
            bean.t_level_mp = GameDll.DataManager.ReadInt();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_growupBean Id:"+key);
            return null;
        }
        return bean; 
    }
}