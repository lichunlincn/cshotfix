/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_missionBean
 */
using System.IO;
using System.Collections.Generic;
public class t_missionBean
{
    public int t_id;
    public string t_uCurrentNpc;
    public string t_Name;
    public string t_AwardId;
    public string t_TalkId;
    private static Dictionary<int, t_missionBean> m_Dic = new Dictionary<int, t_missionBean>(); 
    public static t_missionBean GetConfig(int key)
    { 
        t_missionBean bean = null;
        
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
    private static t_missionBean GetConfigImp(int key)
    {
        t_missionBean bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_missionBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_missionBean();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_uCurrentNpc = GameDll.DataManager.ReadString();
            bean.t_Name = GameDll.DataManager.ReadString();
            bean.t_AwardId = GameDll.DataManager.ReadString();
            bean.t_TalkId = GameDll.DataManager.ReadString();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_missionBean Id:"+key);
            return null;
        }
        return bean; 
    }
}