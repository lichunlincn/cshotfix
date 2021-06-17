/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_globalBeanHF
 */
using System.IO;
using System.Collections.Generic;
public class t_globalBeanHF
{
    public int t_id;
    public string t_string;
    public int t_int;
    private static Dictionary<int, t_globalBeanHF> m_Dic = new Dictionary<int, t_globalBeanHF>(); 
    public static t_globalBeanHF GetConfig(int key)
    { 
        t_globalBeanHF bean = null;
        
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
    private static t_globalBeanHF GetConfigImp(int key)
    {
        t_globalBeanHF bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_globalBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_globalBeanHF();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_string = GameDll.DataManager.ReadString();
            bean.t_int = GameDll.DataManager.ReadInt();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_globalBeanHF Id:"+key);
            return null;
        }
        return bean; 
    }
}