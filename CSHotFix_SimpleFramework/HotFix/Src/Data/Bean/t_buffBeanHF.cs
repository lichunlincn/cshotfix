/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_buffBeanHF
 */
using System.IO;
using System.Collections.Generic;
public class t_buffBeanHF
{
    public int t_id;
    public int t_class;
    public int t_base_time;
    public int t_eff_id;
    private static Dictionary<int, t_buffBeanHF> m_Dic = new Dictionary<int, t_buffBeanHF>(); 
    public static t_buffBeanHF GetConfig(int key)
    { 
        t_buffBeanHF bean = null;
        
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
    private static t_buffBeanHF GetConfigImp(int key)
    {
        t_buffBeanHF bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_buffBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_buffBeanHF();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_class = GameDll.DataManager.ReadInt();
            bean.t_base_time = GameDll.DataManager.ReadInt();
            bean.t_eff_id = GameDll.DataManager.ReadInt();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_buffBeanHF Id:"+key);
            return null;
        }
        return bean; 
    }
}