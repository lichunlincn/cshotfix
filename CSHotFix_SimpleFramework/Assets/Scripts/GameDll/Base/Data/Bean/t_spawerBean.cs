/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_spawerBean
 */
using System.IO;
using System.Collections.Generic;
public class t_spawerBean
{
    public int t_id;
    public int t_map;
    public int t_posx;
    public int t_posy;
    public int t_posz;
    public int t_dir;
    private static Dictionary<int, t_spawerBean> m_Dic = new Dictionary<int, t_spawerBean>(); 
    public static t_spawerBean GetConfig(int key)
    { 
        t_spawerBean bean = null;
        
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
    private static t_spawerBean GetConfigImp(int key)
    {
        t_spawerBean bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_spawerBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_spawerBean();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_map = GameDll.DataManager.ReadInt();
            bean.t_posx = GameDll.DataManager.ReadInt();
            bean.t_posy = GameDll.DataManager.ReadInt();
            bean.t_posz = GameDll.DataManager.ReadInt();
            bean.t_dir = GameDll.DataManager.ReadInt();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_spawerBean Id:"+key);
            return null;
        }
        return bean; 
    }
}