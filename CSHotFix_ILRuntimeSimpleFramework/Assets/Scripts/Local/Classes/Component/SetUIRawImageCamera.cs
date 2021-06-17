using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace LCL
{
    public class SetUIRawImageCamera : MonoBehaviour
    {
        public RawImage m_Image;
        public PrefabHolder m_Prefab;
        public void OnSetRawImageCamera()
        {
            if (m_Image != null && m_Prefab != null)
            {
                GameObject prefab = m_Prefab.GetPrefab();
                //Camera cam = prefab.GetComponentInChildren<Camera>();
                //if (cam != null)
                //{
                //    m_Image.RenderCamera = cam;
                //}
            }
        }
    }
}
