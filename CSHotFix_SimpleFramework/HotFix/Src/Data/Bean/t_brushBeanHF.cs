/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_brushBeanHF
 */
using System.IO;
using System.Collections.Generic;
public class t_brushBeanHF
{
    public int t_id;
    public int t_map_id;
    public string t_layer_info;
    public int t_pos_range;
    public int t_render_cfg;
    public int t_brush_class;
    public int t_object_type;
    public int t_ai;
    public int t_number;
    public int t_interval_time;
    public int t_max_count;
    private static Dictionary<int, t_brushBeanHF> m_Dic = new Dictionary<int, t_brushBeanHF>(); 
    public static t_brushBeanHF GetConfig(int key)
    { 
        t_brushBeanHF bean = null;
        
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
    private static t_brushBeanHF GetConfigImp(int key)
    {
        t_brushBeanHF bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_brushBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_brushBeanHF();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_map_id = GameDll.DataManager.ReadInt();
            bean.t_layer_info = GameDll.DataManager.ReadString();
            bean.t_pos_range = GameDll.DataManager.ReadInt();
            bean.t_render_cfg = GameDll.DataManager.ReadInt();
            bean.t_brush_class = GameDll.DataManager.ReadInt();
            bean.t_object_type = GameDll.DataManager.ReadInt();
            bean.t_ai = GameDll.DataManager.ReadInt();
            bean.t_number = GameDll.DataManager.ReadInt();
            bean.t_interval_time = GameDll.DataManager.ReadInt();
            bean.t_max_count = GameDll.DataManager.ReadInt();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_brushBeanHF Id:"+key);
            return null;
        }
        return bean; 
    }
}