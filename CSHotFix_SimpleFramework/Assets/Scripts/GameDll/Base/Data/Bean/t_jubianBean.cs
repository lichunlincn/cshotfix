/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_jubianBean
 */
using System.IO;
using System.Collections.Generic;
public class t_jubianBean
{
    public int t_id;
    public string t_path;
    public string t_name;
    public string t_type;
    private static Dictionary<int, t_jubianBean> m_Dic = new Dictionary<int, t_jubianBean>(); 
    public static t_jubianBean GetConfig(int key)
    { 
        t_jubianBean bean = null;
        
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
    private static t_jubianBean GetConfigImp(int key)
    {
        t_jubianBean bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_jubianBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_jubianBean();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_path = GameDll.DataManager.ReadString();
            bean.t_name = GameDll.DataManager.ReadString();
            bean.t_type = GameDll.DataManager.ReadString();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_jubianBean Id:"+key);
            return null;
        }
        return bean; 
    }
}