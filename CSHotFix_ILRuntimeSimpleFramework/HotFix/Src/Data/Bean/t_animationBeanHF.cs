/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_animationBeanHF
 */
using System.IO;
using System.Collections.Generic;
public class t_animationBeanHF
{
    public int t_id;
    public int t_render_id;
    public string t_name;
    public int t_fade_in_time;
    public int t_during;
    public int t_loop;
    private static Dictionary<int, t_animationBeanHF> m_Dic = new Dictionary<int, t_animationBeanHF>(); 
    public static t_animationBeanHF GetConfig(int key)
    { 
        t_animationBeanHF bean = null;
        
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
    private static t_animationBeanHF GetConfigImp(int key)
    {
        t_animationBeanHF bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_animationBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_animationBeanHF();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_render_id = GameDll.DataManager.ReadInt();
            bean.t_name = GameDll.DataManager.ReadString();
            bean.t_fade_in_time = GameDll.DataManager.ReadInt();
            bean.t_during = GameDll.DataManager.ReadInt();
            bean.t_loop = GameDll.DataManager.ReadInt();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_animationBeanHF Id:"+key);
            return null;
        }
        return bean; 
    }
}