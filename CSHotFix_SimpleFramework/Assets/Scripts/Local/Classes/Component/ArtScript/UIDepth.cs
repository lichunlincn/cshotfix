using UnityEngine;
using System.Collections;
using UnityEngine.UI;
namespace UnityUI
{
    public enum UIRenderType
    {
        UI,
        Particle,
        Model
    }
    public class UIDepth : MonoBehaviour
    {
        public UIRenderType RenderType = UIRenderType.Particle;
        public int Order = -1;
        public void SetOrder(int order)
        {
            Order = order;
            //获取窗口上面的数据
            if (RenderType == UIRenderType.UI)
            {
                Canvas canvas = GetComponent<Canvas>();
                if (canvas == null)
                {
                    canvas = gameObject.AddComponent<Canvas>();
                }
                canvas.overrideSorting = true;
                canvas.sortingOrder = order;

            }
            else if(RenderType == UIRenderType.Particle || RenderType == UIRenderType.Model)
            {
                Renderer[] renders = GetComponentsInChildren<Renderer>();

                foreach (Renderer render in renders)
                {
                    render.sortingOrder = order;
                }
            }
        }
    }

}
