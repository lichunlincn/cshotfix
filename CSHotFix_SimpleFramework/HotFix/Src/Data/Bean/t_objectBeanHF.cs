/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_objectBeanHF
 */
using System.IO;
using System.Collections.Generic;
public class t_objectBeanHF
{
    public int t_id;
    public int t_render_id;
    public int t_object_type;
    public int t_object_info;
    private static Dictionary<int, t_objectBeanHF> m_Dic = new Dictionary<int, t_objectBeanHF>(); 
    public static t_objectBeanHF GetConfig(int key)
    { 
        t_objectBeanHF bean = null;
        
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
    private static t_objectBeanHF GetConfigImp(int key)
    {
        t_objectBeanHF bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_objectBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_objectBeanHF();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_render_id = GameDll.DataManager.ReadInt();
            bean.t_object_type = GameDll.DataManager.ReadInt();
            bean.t_object_info = GameDll.DataManager.ReadInt();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_objectBeanHF Id:"+key);
            return null;
        }
        return bean; 
    }
}