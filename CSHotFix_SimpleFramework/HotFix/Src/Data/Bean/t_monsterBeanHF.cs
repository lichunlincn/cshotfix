/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_monsterBeanHF
 */
using System.IO;
using System.Collections.Generic;
public class t_monsterBeanHF
{
    public int t_id;
    public string t_name;
    public string t_desc;
    public string t_skill;
    public int t_attack_dist;
    private static Dictionary<int, t_monsterBeanHF> m_Dic = new Dictionary<int, t_monsterBeanHF>(); 
    public static t_monsterBeanHF GetConfig(int key)
    { 
        t_monsterBeanHF bean = null;
        
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
    private static t_monsterBeanHF GetConfigImp(int key)
    {
        t_monsterBeanHF bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_monsterBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_monsterBeanHF();
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
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_monsterBeanHF Id:"+key);
            return null;
        }
        return bean; 
    }
}