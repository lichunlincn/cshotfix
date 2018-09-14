using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityUI;

namespace GameDll
{
    public class UIObjLoader
    {
        protected UIRTRenderer m_Renderer;
        //protected UUI m_UIGo;
        private System.Action<object> m_Call;
        public void Init()
        {
            //m_UIGo = new UUI();
        }
        
        public virtual void Load(string abName, string assetName, Transform parent, System.Action<object> call)
        {
            //m_Call = call;
            //m_UIGo.SetResName(abName, assetName);
            //m_UIGo.LoadShowObjFromFileAsync(null);
            //m_UIGo.AddLoadedCall(OnLoadedObj);
            //m_UIGo.SetParent(parent.gameObject,"", false);
            //m_UIGo.SetActive(false);
        }

        protected virtual void OnLoadedObj()
        {
            //GameObject obj = m_UIGo.GetShowObj() as GameObject;
            //obj.transform.localScale = Vector3.one;
            //obj.transform.eulerAngles = Vector3.zero;
            //Tool.SetLayerWithChild(obj, "UI3D");
            //m_UIGo.SetActive(true);
            //if(m_Call!= null)
            //{
            //    m_Call((object)m_UIGo);
            //}
        }
        public void UnLoad()
        {
            //if(m_UIGo!= null)
            //{
            //    m_UIGo.Destroy();
            //}
        }
        public void Destory()
        {
            //UnLoad();
            //m_UIGo = null;
        }
    }
}
