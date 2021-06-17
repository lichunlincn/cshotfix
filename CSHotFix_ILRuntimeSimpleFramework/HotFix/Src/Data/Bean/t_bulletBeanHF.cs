/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_bulletBeanHF
 */
using System.IO;
using System.Collections.Generic;
public class t_bulletBeanHF
{
    public int t_id;
    public int t_contrail_type;
    public int t_contrail_param;
    public int t_fly_sound_id;
    public int t_fly_dis;
    public int t_fly_speed;
    public int t_hit_eff_id;
    public int t_hit_sound_id;
    public int t_be_hit_eff_locator;
    public int t_desc_id;
    private static Dictionary<int, t_bulletBeanHF> m_Dic = new Dictionary<int, t_bulletBeanHF>(); 
    public static t_bulletBeanHF GetConfig(int key)
    { 
        t_bulletBeanHF bean = null;
        
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
    private static t_bulletBeanHF GetConfigImp(int key)
    {
        t_bulletBeanHF bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_bulletBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_bulletBeanHF();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_contrail_type = GameDll.DataManager.ReadInt();
            bean.t_contrail_param = GameDll.DataManager.ReadInt();
            bean.t_fly_sound_id = GameDll.DataManager.ReadInt();
            bean.t_fly_dis = GameDll.DataManager.ReadInt();
            bean.t_fly_speed = GameDll.DataManager.ReadInt();
            bean.t_hit_eff_id = GameDll.DataManager.ReadInt();
            bean.t_hit_sound_id = GameDll.DataManager.ReadInt();
            bean.t_be_hit_eff_locator = GameDll.DataManager.ReadInt();
            bean.t_desc_id = GameDll.DataManager.ReadInt();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_bulletBeanHF Id:"+key);
            return null;
        }
        return bean; 
    }
}