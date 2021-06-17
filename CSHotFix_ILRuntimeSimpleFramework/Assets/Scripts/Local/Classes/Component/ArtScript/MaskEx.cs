using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class MaskEx : Mask
{
    private Dictionary<Renderer, List<Shader>> m_RendererShaders = new Dictionary<Renderer, List<Shader>>();
    protected override void Start()
    {
        base.Start();
        Change();
    }
    protected override void OnRectTransformDimensionsChange()
    {
        base.OnRectTransformDimensionsChange();
        Change();
    }
    public void OnUpdate()
    {
        Change();
    }
    protected override void OnDestroy()
    {
        foreach (var kv in m_RendererShaders)
        {
            if (kv.Key != null && !kv.Key.Equals(null))
            {
                var count = kv.Key.materials.Length;
                for (int i = 0; i < count; ++i)
                {
                    kv.Key.materials[i].shader = kv.Value[i];
                }
            }
        }
    }
    private void Change()
    {
        var renderers = GetComponentsInChildren<Renderer>();
        if ( renderers == null)
        {
            return;
        }
        Vector3[] corners = new Vector3[4];
        RectTransform rectTransform = transform as RectTransform;
        rectTransform.GetWorldCorners(corners);
        float minX, minY, maxX, maxY;
        minX = corners[0].x;
        minY = corners[0].y;
        maxX = corners[2].x;
        maxY = corners[2].y;

        foreach (Renderer _render in renderers)
        {
            Material[] ms = _render.materials;
            if (ms != null && ms.Length > 0)
            {
                if (!m_RendererShaders.ContainsKey(_render))
                {
                    List<Shader> oldShaders = new List<Shader>();
                    int count = ms.Length;
                    for (int i = 0; i < count; ++i)
                    {
                        Material m = ms[i];
                        oldShaders.Add(m.shader);
                        //本身用的较少，不推荐缓存使用，可能会有问题。
                        Shader shader = GameDll.ShaderManager.GetShaderAllowNull(m.shader.name + "_MaskEx");
                        if (shader != null)
                        {
                            m.shader = shader;
                        }
                    }
                    m_RendererShaders.Add(_render, oldShaders);
                }
                foreach (var m in _render.materials)
                {
                    m.SetFloat("_MinX", minX);
                    m.SetFloat("_MinY", minY);
                    m.SetFloat("_MaxX", maxX);
                    m.SetFloat("_MaxY", maxY);
                }
            }
        }
    }
}