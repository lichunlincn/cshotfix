using UnityEngine;
using System.Collections;
using UnityEngine.Events;

namespace LCL
{
    public class PrefabHolder : MonoBehaviour
    {
        public GameObject Parent;
        public GameObject Asset;
        [SerializeField]
        public UnityEvent InnerCall;
        private UnityEvent MannalCall;
        private GameObject AssetInst;
        void Start()
        {
            if (Asset != null)
            {
                AssetInst = Instantiate(Asset) as GameObject;
#if UNITY_EDITOR
                ResourceManagerMono.RecoveryShader(AssetInst);
#endif
                if (Parent != null)
                {
                    AssetInst.transform.SetParent(Parent.transform, false);
                }
            }
        }
        void Update()
        {
            if (Asset != null)
            {
                OnLoadedCall();
            }
        }
        public GameObject GetPrefab()
        {
            return AssetInst;
        }
        public void AddLoadedCall(UnityEvent call)
        {
            MannalCall = call;
            if (AssetInst != null)
            {
                OnLoadedCall();
            }
        }
        private void OnLoadedCall()
        {
            if (InnerCall != null)
            {
                InnerCall.Invoke();
                InnerCall = null;
            }
            if (MannalCall != null)
            {
                MannalCall.Invoke();
                MannalCall = null;
            }

        }
        void Destroy()
        {
            if (AssetInst != null)
            {
                GameObject.DestroyObject(AssetInst);
                AssetInst = null;
            }
            if (Asset != null)
            {
                Asset = null;
            }
            if (InnerCall != null)
            {
                InnerCall = null;
            }
            if (MannalCall != null)
            {
                MannalCall = null;
            }
        }
    }
}