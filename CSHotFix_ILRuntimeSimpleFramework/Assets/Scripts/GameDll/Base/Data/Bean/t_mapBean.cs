/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_mapBean
 */
using System.IO;
using System.Collections.Generic;
public class t_mapBean
{
    public int t_id;
    public string t_name;
    public string t_map_pathdata;
    public string t_map_data_abname;
    public string t_map_info;
    public string t_map_assetname;
    public string t_map_abname;
    public string t_jubian;
    public string t_brush_id;
    private static Dictionary<int, t_mapBean> m_Dic = new Dictionary<int, t_mapBean>(); 
    public static t_mapBean GetConfig(int key)
    { 
        t_mapBean bean = null;
        
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
    private static t_mapBean GetConfigImp(int key)
    {
        t_mapBean bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_mapBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_mapBean();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_name = GameDll.DataManager.ReadString();
            bean.t_map_pathdata = GameDll.DataManager.ReadString();
            bean.t_map_data_abname = GameDll.DataManager.ReadString();
            bean.t_map_info = GameDll.DataManager.ReadString();
            bean.t_map_assetname = GameDll.DataManager.ReadString();
            bean.t_map_abname = GameDll.DataManager.ReadString();
            bean.t_jubian = GameDll.DataManager.ReadString();
            bean.t_brush_id = GameDll.DataManager.ReadString();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_mapBean Id:"+key);
            return null;
        }
        return bean; 
    }
}