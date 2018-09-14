/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_skillBeanHF
 */
using System.IO;
using System.Collections.Generic;
public class t_skillBeanHF
{
    public int t_id;
    public int t_class;
    public int t_cast_time;
    public int t_continue;
    public int t_continue_time;
    public string t_add_buff;
    public int t_eff_id;
    public int t_range;
    public int t_cast_distance;
    public string t_skill_icon;
    public string t_skill_icon_set_abname;
    public string t_skill_icon_set;
    public int t_cooldown_time;
    public int t_target_pos_type;
    public int t_target_num_type;
    private static Dictionary<int, t_skillBeanHF> m_Dic = new Dictionary<int, t_skillBeanHF>(); 
    public static t_skillBeanHF GetConfig(int key)
    { 
        t_skillBeanHF bean = null;
        
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
    private static t_skillBeanHF GetConfigImp(int key)
    {
        t_skillBeanHF bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_skillBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_skillBeanHF();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_class = GameDll.DataManager.ReadInt();
            bean.t_cast_time = GameDll.DataManager.ReadInt();
            bean.t_continue = GameDll.DataManager.ReadInt();
            bean.t_continue_time = GameDll.DataManager.ReadInt();
            bean.t_add_buff = GameDll.DataManager.ReadString();
            bean.t_eff_id = GameDll.DataManager.ReadInt();
            bean.t_range = GameDll.DataManager.ReadInt();
            bean.t_cast_distance = GameDll.DataManager.ReadInt();
            bean.t_skill_icon = GameDll.DataManager.ReadString();
            bean.t_skill_icon_set_abname = GameDll.DataManager.ReadString();
            bean.t_skill_icon_set = GameDll.DataManager.ReadString();
            bean.t_cooldown_time = GameDll.DataManager.ReadInt();
            bean.t_target_pos_type = GameDll.DataManager.ReadInt();
            bean.t_target_num_type = GameDll.DataManager.ReadInt();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_skillBeanHF Id:"+key);
            return null;
        }
        return bean; 
    }
}