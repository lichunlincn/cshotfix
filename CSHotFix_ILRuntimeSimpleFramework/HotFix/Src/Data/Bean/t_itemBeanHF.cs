/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_itemBeanHF
 */
using System.IO;
using System.Collections.Generic;
public class t_itemBeanHF
{
    public int t_id;
    public string t_icon;
    public string t_icon_set;
    public int t_delay_time;
    public int t_effect_range;
    public int t_effect_time;
    public int t_model_id;
    public int t_effect_eff;
    private static Dictionary<int, t_itemBeanHF> m_Dic = new Dictionary<int, t_itemBeanHF>(); 
    public static t_itemBeanHF GetConfig(int key)
    { 
        t_itemBeanHF bean = null;
        
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
    private static t_itemBeanHF GetConfigImp(int key)
    {
        t_itemBeanHF bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_itemBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_itemBeanHF();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_icon = GameDll.DataManager.ReadString();
            bean.t_icon_set = GameDll.DataManager.ReadString();
            bean.t_delay_time = GameDll.DataManager.ReadInt();
            bean.t_effect_range = GameDll.DataManager.ReadInt();
            bean.t_effect_time = GameDll.DataManager.ReadInt();
            bean.t_model_id = GameDll.DataManager.ReadInt();
            bean.t_effect_eff = GameDll.DataManager.ReadInt();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_itemBeanHF Id:"+key);
            return null;
        }
        return bean; 
    }
}