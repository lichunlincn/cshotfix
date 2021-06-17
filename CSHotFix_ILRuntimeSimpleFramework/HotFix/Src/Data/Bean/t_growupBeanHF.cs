/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_growupBeanHF
 */
using System.IO;
using System.Collections.Generic;
public class t_growupBeanHF
{
    public int t_id;
    public int t_base_hp;
    public int t_level_hp;
    public int t_base_mp;
    public int t_level_mp;
    private static Dictionary<int, t_growupBeanHF> m_Dic = new Dictionary<int, t_growupBeanHF>(); 
    public static t_growupBeanHF GetConfig(int key)
    { 
        t_growupBeanHF bean = null;
        
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
    private static t_growupBeanHF GetConfigImp(int key)
    {
        t_growupBeanHF bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_growupBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_growupBeanHF();
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
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_growupBeanHF Id:"+key);
            return null;
        }
        return bean; 
    }
}