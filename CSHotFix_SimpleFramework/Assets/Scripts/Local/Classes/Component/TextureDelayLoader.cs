using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// 延迟加载一张大图。
/// 目前已知bug是：当该大图被放在的一个根节点，而根节点下面还有控件的时候，控件会无法响应。
/// 建议使用大图的时候把大图预制件放在和控件没有父子关系的层级
/// </summary>
namespace LCL
{
    public class TextureDelayLoader : MonoBehaviour
    {
        public Image m_Image;
        public string m_ABName;
        public string m_AssetName;

        public float m_DelayTime = 0.0f;

        private bool m_bStartLoad = false;
        private float m_fPastTime = 0.0f;
        private long m_id = 0;
        void Start()
        {
            if (m_Image != null &&
                !string.IsNullOrEmpty(m_ABName))
            {
                m_ABName = m_ABName.ToLower();
                if (m_DelayTime <= 0)
                {
                    m_bStartLoad = true;
                    StartLoad();
                }
            }
        }
        void Update()
        {
            if (!m_bStartLoad)
            {
                m_fPastTime += Time.deltaTime;
                if (m_fPastTime >= m_DelayTime)
                {
                    m_bStartLoad = true;
                    StartLoad();
                }
            }
        }
        void StartLoad()
        {
            SetImageSpriteParam param = new SetImageSpriteParam();
            param.abName = m_ABName;
            param.assetName = m_AssetName;
            param.img = m_Image;
            param.call = OnGetSprite;

            m_id = AtlasManager.SetImageSprite(param);

        }

        private void OnGetSprite(SetImageSpriteParam param, Sprite sp)
        {
            if (sp != null)
            {
                param.img.sprite = sp;
            }
        }
        private void OnDestroy()
        {
            AtlasManager.ReturnImageSprite(m_id);
            m_id = 0;
        }
        void Destroy()
        {
            OnDestroy();
            m_Image = null;
        }
    }
}