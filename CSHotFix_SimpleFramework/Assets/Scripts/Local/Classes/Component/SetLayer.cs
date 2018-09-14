using UnityEngine;
using System.Collections;
namespace LCL
{
    public class SetLayer : MonoBehaviour
    {
        public string m_Layer;
        public PrefabHolder m_Prefab;
        public void OnSetLayer()
        {
            if (m_Prefab != null && !string.IsNullOrEmpty(m_Layer))
            {
                GameObject prefab = m_Prefab.GetPrefab();
                if (prefab != null)
                {
                    SetLayerRecursively(prefab);
                }
            }
        }
        private void SetLayerRecursively(GameObject go)
        {
            go.layer = LayerMask.NameToLayer(m_Layer);
            foreach (Transform aTransform in go.transform)
            {
                GameObject aGameObject = aTransform.gameObject;
                SetLayerRecursively(aGameObject);
            }
        }
    }
}