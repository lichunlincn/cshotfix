using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace GameDll
{
    public class RTInfo
    {
        public bool m_bIsInUse = false;
        public RenderTexture m_RenderTexture;
        public Vector3 m_Position;
    }
    public class RenderTextureManager
    {

        private static List<RTInfo> m_RTInfos = new List<RTInfo>();
        private static Vector3 m_CurrentPosition = new Vector3(-10000, -10000, -10000);
        //一张RT图片对应一个摄像机，然后可以对应多个RawImage，所以销毁的时候由摄像机和RT对应
        public static RTInfo CreateRTTexture(int w, int h, int depth, RenderTextureFormat rtf)
        {
            RTInfo info = null;
            int count = m_RTInfos.Count;
            for(int i=0;i<count;++i)
            {
                info = m_RTInfos[i];
                if(!info.m_bIsInUse)
                {
                    if(info.m_RenderTexture.width == w &&
                        info.m_RenderTexture.height == h &&
                        info.m_RenderTexture.depth == depth && 
                        info.m_RenderTexture.format == rtf)
                    {
                        info.m_bIsInUse = true;
                        return info;
                    }
                    
                }
            }
            info = new RTInfo();
            info.m_bIsInUse = false;
            info.m_RenderTexture = new RenderTexture(w, h, depth, rtf);
            info.m_Position = m_CurrentPosition + new Vector3(w, w, w);
            m_RTInfos.Add(info);
            return info;
        }
        public static void DestroyRTTexure(RenderTexture rt)
        {
            RTInfo info = null;
            int count = m_RTInfos.Count;
            for (int i = 0; i < count; ++i)
            {
                info = m_RTInfos[i];
                if (!info.m_bIsInUse)
                {
                    if (info.m_RenderTexture.width == rt.width &&
                        info.m_RenderTexture.height == rt.height &&
                        info.m_RenderTexture.depth == rt.depth &&
                        info.m_RenderTexture.format == rt.format)
                    {
                        info.m_bIsInUse = false;
                    }

                }
            }
        }

    }
}
