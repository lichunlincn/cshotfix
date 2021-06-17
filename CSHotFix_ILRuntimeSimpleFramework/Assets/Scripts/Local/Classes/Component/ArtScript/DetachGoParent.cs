using UnityEngine;
using System.Collections;
namespace LCL
{
    public class DetachGoParent : MonoBehaviour
    {
        Vector3 m_Position;
        Vector3 m_Rotation;
        Vector3 m_Scale;
        public DetachGoChild m_DetachGoChild;
        void Awake()
        {
            m_Position = transform.position;
            m_Rotation = transform.eulerAngles;
            m_Scale = transform.localScale;
            if (m_DetachGoChild != null)
            {
                if (m_DetachGoChild.m_DetachFromParent)
                {
                    m_DetachGoChild.Detach();
                }
            }

        }

        // Update is called once per frame
        void Update()
        {
            if (m_Position != transform.position)
            {
                m_Position = transform.position;
                if (m_DetachGoChild != null)
                {
                    m_DetachGoChild.OnParentPositionDirty();
                }
            }
            if (m_Rotation != transform.eulerAngles)
            {
                m_Rotation = transform.eulerAngles;
                if (m_DetachGoChild != null)
                {
                    m_DetachGoChild.OnParentRotationDirty();
                }
            }
            if (m_Scale != transform.localScale)
            {
                m_Scale = transform.localScale;
                if (m_DetachGoChild != null)
                {
                    m_DetachGoChild.OnParentScaleDirty();
                }
            }
        }

        void Destroy()
        {
            if (m_DetachGoChild != null)
            {
                m_DetachGoChild.OnParentDestroy();
            }
        }
    }
}