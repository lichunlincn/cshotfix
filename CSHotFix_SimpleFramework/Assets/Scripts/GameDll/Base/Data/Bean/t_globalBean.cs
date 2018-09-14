/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_globalBean
 */
using System.IO;
using System.Collections.Generic;
public class t_globalBean
{
    public int t_id;
    public string t_string;
    public int t_int;
    private static Dictionary<int, t_globalBean> m_Dic = new Dictionary<int, t_globalBean>(); 
    public static t_globalBean GetConfig(int key)
    { 
        t_globalBean bean = null;
        
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
    private static t_globalBean GetConfigImp(int key)
    {
        t_globalBean bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_globalBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_globalBean();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_string = GameDll.DataManager.ReadString();
            bean.t_int = GameDll.DataManager.ReadInt();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_globalBean Id:"+key);
            return null;
        }
        return bean; 
    }
}