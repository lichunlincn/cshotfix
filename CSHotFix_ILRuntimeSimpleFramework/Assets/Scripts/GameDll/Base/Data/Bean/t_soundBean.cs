/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_soundBean
 */
using System.IO;
using System.Collections.Generic;
public class t_soundBean
{
    public int t_id;
    public string t_name;
    public string t_res_assetname;
    public string t_res_abname;
    private static Dictionary<int, t_soundBean> m_Dic = new Dictionary<int, t_soundBean>(); 
    public static t_soundBean GetConfig(int key)
    { 
        t_soundBean bean = null;
        
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
    private static t_soundBean GetConfigImp(int key)
    {
        t_soundBean bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_soundBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_soundBean();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_name = GameDll.DataManager.ReadString();
            bean.t_res_assetname = GameDll.DataManager.ReadString();
            bean.t_res_abname = GameDll.DataManager.ReadString();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_soundBean Id:"+key);
            return null;
        }
        return bean; 
    }
}