using UnityEngine;
using System.Collections;

namespace UnityUI
{

    public class UIPositionBy3D : MonoBehaviour
    {
        public Transform m_FromTransform;
        public Transform m_SetTransrom;
        public Vector2 m_Offset;

        void Update()
        {
            if (m_FromTransform != null && m_SetTransrom != null)
            {
                Vector2 player2DPosition = Camera.main.WorldToScreenPoint(m_FromTransform.position);
                m_SetTransrom.position = player2DPosition + m_Offset;
            }
        }
    }

}