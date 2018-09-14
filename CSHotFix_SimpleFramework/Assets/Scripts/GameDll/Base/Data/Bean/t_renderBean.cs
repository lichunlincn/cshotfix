/**
 * Auto generated, do not edit it
 *Author lichunlin
 * t_renderBean
 */
using System.IO;
using System.Collections.Generic;
public class t_renderBean
{
    public int t_id;
    public string t_name;
    public string t_res_assetname;
    public string t_res_abname;
    public string t_animations;
    public string t_hang_wing;
    public string t_hang_head;
    private static Dictionary<int, t_renderBean> m_Dic = new Dictionary<int, t_renderBean>(); 
    public static t_renderBean GetConfig(int key)
    { 
        t_renderBean bean = null;
        
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
    private static t_renderBean GetConfigImp(int key)
    {
        t_renderBean bean = null;
        GameDll.Tool.StringBuilder.Append("select * from t_renderBean where t_id = ");
        GameDll.Tool.StringBuilder.Append(key); 
        if(GameDll.DataManager.BeginRead(GameDll.Tool.StringBuilder.ToString()))
        {
            bean = new t_renderBean();
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
            UnityEngine.Debug.LogError("没有找到配置表，配置表是：t_renderBean Id:"+key);
            return null;
        }
        return bean; 
    }
}