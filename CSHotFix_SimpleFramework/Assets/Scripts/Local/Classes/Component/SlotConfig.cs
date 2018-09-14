using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace LCL
{
    /// <summary>
    /// 用于配置一个角色的挂点数据
    /// </summary>
    [System.Serializable]
    public class KeyGameObject
    {
        public uint m_Pos;
        public GameObject m_GameObject;
    }
    public class SlotConfig : MonoBehaviour
    {
        public List<KeyGameObject> m_ListGameObject = new List<KeyGameObject>();
    }
}
