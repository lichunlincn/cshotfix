using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace UnityUI
{
    public class UIRTRenderer : MonoBehaviour
    {
        public Camera Camera;
        [HideInInspector]
        public RenderTexture Texture;
        [Range(2, 2048)]
        public int Width = 128;
        [Range(2, 2048)]
        public int Height = 128;
        public int Depth = 2;
        public RenderTextureFormat Format = RenderTextureFormat.ARGB32;
    }
}