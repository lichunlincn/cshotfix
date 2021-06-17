using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace LCL
{
    public class SetImageSpriteParam
    {
        public string abName;
        public string assetName;
        public Image img;
        public Action<SetImageSpriteParam, Sprite> call;
    }
    /// <summary>
    /// 所有的接口都是采用回调的方式处理
    /// </summary>
    public class AtlasManager
    {
        private static Dictionary<long, SetImageSpriteParam> m_Textures = new Dictionary<long, SetImageSpriteParam>();

        private static bool m_UseTexturePacker = false;
        public static long SetImageSprite(SetImageSpriteParam param)
        {
            if (string.IsNullOrEmpty(param.abName) || string.IsNullOrEmpty(param.assetName))
            {
                return 0;
            }
            Type t = null;
            if (m_UseTexturePacker)
            {
                t = typeof(UIAtals);
            }
            else
            {
                t = typeof(Sprite);
            }
            long id = ResourceManager.LoadPrefab(t, param.abName, param.assetName, OnLoadedAtlas);
            m_Textures.Add(id, param);
            return id;
        }

        private static void OnLoadedAtlas(ABObject list)
        {
            SetImageSpriteParam param;
            if (m_Textures.TryGetValue(list.m_Id, out param))
            {
                if (list != null)
                {
                    if (m_UseTexturePacker)
                    {
                        if (list.m_UObjectList[0] is UIAtals)
                        {
                            UIAtals atlas = list.m_UObjectList[0] as UIAtals;

                            if (param.call != null)
                            {
                                param.call(param, atlas.GetSprite(param.assetName));
                            }
                        }
                    }
                    else
                    {
                        var sprite = list.m_UObjectList[0] as Sprite;
                        if (param.call != null)
                        {
                            param.call(param, sprite);
                        }
                    }
                }
            }
        }

        public static void ReturnImageSprite(long id)
        {
            if (id <= 0)
            {
                return;
            }
            if (m_Textures.ContainsKey(id))
            {
                ResourceManager.UnloadPrefab(id);
                m_Textures.Remove(id);
            }
            else
            {
                UnityEngine.Debug.LogError("需要释放的图片资源id不存在" + id.ToString());
            }
        }

        private static Dictionary<object, List<long>> m_Collectors = new Dictionary<object, List<long>>();
        public static void WindowImageIdCollect(object wnd, long id)
        {
            if (wnd == null)
            {
                UnityEngine.Debug.LogError("wnd is null");
                return;
            }
            if (m_Collectors.ContainsKey(wnd))
            {
                List<long> ids = m_Collectors[wnd];
                ids.Add(id);
            }
            else
            {
                List<long> ids = new List<long>();
                ids.Add(id);
                m_Collectors.Add(wnd, ids);
            }
        }
        //当通过WindowImageIdCollect方法添加管理后，如果不需要他管理了调用
        public static void WindowImageIdReturn(object wnd, long returnid)
        {
            if (wnd == null)
            {
                UnityEngine.Debug.LogError("wnd is null");
                return;
            }
            if (m_Collectors.ContainsKey(wnd))
            {
                List<long> ids = m_Collectors[wnd];
                int count = ids.Count;
                for (int i = 0; i < count; ++i)
                {
                    long id = ids[i];
                    if (id == returnid)
                    {
                        ids.Remove(id);
                        ReturnImageSprite(id);
                        break;
                    }

                }
            }
        }
        //这里只是清空，同时兼顾gc
        public static void WindowImageIdReturn(object wnd)
        {
            if (wnd == null)
            {
                UnityEngine.Debug.LogError("wnd is null");
                return;
            }
            if (m_Collectors.ContainsKey(wnd))
            {
                List<long> ids = m_Collectors[wnd];
                int count = ids.Count;
                for (int i = 0; i < count; ++i)
                {
                    long id = ids[i];
                    ReturnImageSprite(id);
                    id = 0;
                }
                ids.Clear();
            }
        }
    }

}