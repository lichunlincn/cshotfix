using UnityEngine;
using System.Collections;
using UnityEngine.UI;
namespace UnityUI
{
    [ExecuteInEditMode]
    [AddComponentMenu("UITools/Others/UIGray")]
    public class UIGray : MonoBehaviour
    {
        public Graphic m_Graphics;

        private bool _Gray;
        public bool Gray
        {
            set
            {
                _Gray = value;
                OnGray();
            }
            get
            {
                return _Gray;
            }
        }
        void Start()
        {
            OnGray();
        }
        void OnGray()
        {
            if (m_Graphics != null)
            {

                if (_Gray)
                {
                    m_Graphics.material = new Material(GameDll.ShaderManager.GetShader("Custom/UI/Transparent Colored Gray Stencil"));
                    m_Graphics.material.name = "UIGrayMaterial";
                }
                else
                {
                    m_Graphics.material = null;
                }
            }
        }
    }
}