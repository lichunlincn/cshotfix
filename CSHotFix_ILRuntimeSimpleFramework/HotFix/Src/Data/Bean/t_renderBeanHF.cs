/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_renderBeanHF
 */
using System.IO;
using System.Collections.Generic;
public class t_renderBeanHF
{
    public int t_id;
    public string t_name;
    public string t_res_assetname;
    public string t_res_abname;
    public string t_animations;
    public string t_hang_wing;
    public string t_hang_head;
    private static Dictionary<int, t_renderBeanHF> m_Dic = new Dictionary<int, t_renderBeanHF>(); 
    public static t_renderBeanHF GetConfig(int key)
    { 
        t_renderBeanHF bean = null;
        
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
    private static t_renderBeanHF GetConfigImp(int key)
    {
        t_renderBeanHF bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_renderBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_renderBeanHF();
            bean.t_id = GameDll.DataManager.ReadInt();
            bean.t_name = GameDll.DataManager.ReadString();
            bean.t_res_assetname = GameDll.DataManager.ReadString();
            bean.t_res_abname = GameDll.DataManager.ReadString();
            bean.t_animations = GameDll.DataManager.ReadString();
            bean.t_hang_wing = GameDll.DataManager.ReadString();
            bean.t_hang_head = GameDll.DataManager.ReadString();
        }
        GameDll.DataManager.EndRead();
        GameDll.Tool.StringBuilder.Clear();
        if(bean == null)
        {
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_renderBeanHF Id:"+key);
            return null;
        }
        return bean; 
    }
}