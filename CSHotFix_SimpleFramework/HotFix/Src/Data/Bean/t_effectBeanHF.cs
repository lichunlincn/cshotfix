/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_effectBeanHF
 */
using System.IO;
using System.Collections.Generic;
public class t_effectBeanHF
{
    public int t_id;
    public int t_render_id;
    public int t_type;
    public int t_sub_data;
    public int t_during_time;
    private static Dictionary<int, t_effectBeanHF> m_Dic = new Dictionary<int, t_effectBeanHF>(); 
    public static t_effectBeanHF GetConfig(int key)
    { 
        t_effectBeanHF bean = null;
        
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
    private static t_effectBeanHF GetConfigImp(int key)
    {
        t_effectBeanHF bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_effectBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_effectBeanHF();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_render_id = GameDll.DataManager.ReadInt();
            bean.t_type = GameDll.DataManager.ReadInt();
            bean.t_sub_data = GameDll.DataManager.ReadInt();
            bean.t_during_time = GameDll.DataManager.ReadInt();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_effectBeanHF Id:"+key);
            return null;
        }
        return bean; 
    }
}