using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
namespace LCL
{
    public class UIAtals : ScriptableObject
    {
        [HideInInspector]
        public Texture2D mainTexture;
        [HideInInspector]
        public List<Sprite> spriteLists = new List<Sprite>();

        private static Sprite m_NullSprite = new Sprite();
        /// <summary>
        /// 根据图片名称获取sprite
        /// </summary>
        /// <param name="spritename">图片名称</param>
        /// <returns></returns>
        public Sprite GetSprite(string spritename)
        {
            if (string.IsNullOrEmpty(spritename))
            {
                Debug.LogError("GetSprite spritename IsNullOrEmpty");
                return m_NullSprite;
            }
            int count = spriteLists.Count;
            for (int i = 0; i < count; ++i)
            {
                Sprite sp = spriteLists[i];
                if (sp != null && sp.name == spritename)
                {
                    return sp;
                }
            }

            Debug.LogError("GetSprite spritename not find");
            return m_NullSprite;
        }

        /// <summary>
        /// 设置Image的Sprite
        /// </summary>
        /// <param name="im">Image</param>
        /// <param name="spritename">图片名称</param>
        public void SetSprite(Image im, string spritename)
        {

            if (im == null || im.Equals(null))
            {
                return;
            }
            Sprite sp = GetSprite(spritename);
            if (sp != null)
            {
                im.overrideSprite = sp;
            }
            else
            {
                Debug.Log("图集没有对应的图片:" + spritename);
            }
        }
    }
}