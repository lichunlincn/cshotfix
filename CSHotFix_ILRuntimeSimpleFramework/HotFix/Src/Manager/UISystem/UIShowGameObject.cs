using UnityEngine;
using System.Collections;
using LCL;
using System.Collections.Generic;
using System;

namespace UnityUI
{
    public class UIShowGameObject
    {
        //[Tooltip("加载的预制件包名的名字")]
        [SerializeField]
        public string ABName = "";
        //[Tooltip("加载的预制件的名字")]
        //[SerializeField]
        public string AssetName = "";
        //[SerializeField]
        public Vector3 Position = Vector3.zero;
        //[SerializeField]
        public Vector3 Rotation = Vector3.zero;
        //[SerializeField]
        public Vector3 Scale = Vector3.one;
        //[SerializeField]
        public Transform Parent;
        //[SerializeField]
        public MaskEx MaskEx = null;
        //[SerializeField]
        public UIDepth UIDepth = null;
        //[SerializeField]
        public GameObject ShowObj = null;

        public void OnShow(GameObject showObj)
        {
            if(showObj!= null)
            {
                ShowObj = showObj;
            }
            if(Parent!= null && !Parent.Equals(null))
            {
                Transform showTrans = showObj.transform;
                showTrans.SetParent(Parent);
                showTrans.localEulerAngles = Rotation;
                showTrans.localScale = Scale;
                showTrans.localPosition = Position;
                MonoTool.SetLayer(showObj, true, "UI");
                if(MaskEx!= null)
                {
                    MaskEx.OnUpdate();
                }

                if(UIDepth != null)
                {
                    UIDepth.SetOrder(UIDepth.Order);
                }

                if(!showObj.activeSelf)
                {
                    showObj.SetActive(true);
                }
            }
        }
    }
}