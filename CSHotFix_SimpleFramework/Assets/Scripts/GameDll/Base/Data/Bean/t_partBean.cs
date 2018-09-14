/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_partBean
 */
using System.IO;
using System.Collections.Generic;
public class t_partBean
{
    public int t_id;
    public string t_path;
    public string t_animations;
    public int t_dummy;
    public int t_pos;
    private static Dictionary<int, t_partBean> m_Dic = new Dictionary<int, t_partBean>(); 
    public static t_partBean GetConfig(int key)
    { 
        t_partBean bean = null;
        
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
    private static t_partBean GetConfigImp(int key)
    {
        t_partBean bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_partBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_partBean();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_path = GameDll.DataManager.ReadString();
            bean.t_animations = GameDll.DataManager.ReadString();
            bean.t_dummy = GameDll.DataManager.ReadInt();
            bean.t_pos = GameDll.DataManager.ReadInt();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_partBean Id:"+key);
            return null;
        }
        return bean; 
    }
}