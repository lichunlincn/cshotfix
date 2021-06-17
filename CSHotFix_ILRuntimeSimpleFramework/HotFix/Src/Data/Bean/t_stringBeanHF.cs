/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_stringBeanHF
 */
using System.IO;
using System.Collections.Generic;
public class t_stringBeanHF
{
    public int t_id;
    public string t_string;
    private static Dictionary<int, t_stringBeanHF> m_Dic = new Dictionary<int, t_stringBeanHF>(); 
    public static t_stringBeanHF GetConfig(int key)
    { 
        t_stringBeanHF bean = null;
        
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
    private static t_stringBeanHF GetConfigImp(int key)
    {
        t_stringBeanHF bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_stringBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_stringBeanHF();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_string = GameDll.DataManager.ReadString();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_stringBeanHF Id:"+key);
            return null;
        }
        return bean; 
    }
}