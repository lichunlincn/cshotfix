/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_monsterBean
 */
using System.IO;
using System.Collections.Generic;
public class t_monsterBean
{
    public int t_id;
    public string t_name;
    public string t_desc;
    public string t_skill;
    public int t_attack_dist;
    private static Dictionary<int, t_monsterBean> m_Dic = new Dictionary<int, t_monsterBean>(); 
    public static t_monsterBean GetConfig(int key)
    { 
        t_monsterBean bean = null;
        
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
    private static t_monsterBean GetConfigImp(int key)
    {
        t_monsterBean bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_monsterBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_monsterBean();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_name = GameDll.DataManager.ReadString();
            bean.t_desc = GameDll.DataManager.ReadString();
            bean.t_skill = GameDll.DataManager.ReadString();
            bean.t_attack_dist = GameDll.DataManager.ReadInt();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_monsterBean Id:"+key);
            return null;
        }
        return bean; 
    }
}