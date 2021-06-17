using UnityEngine;
using System.Collections;
namespace LCL
{
    public class DetachGoChild : MonoBehaviour
    {
        public DetachGoParent m_DetachGoParent;
        public bool m_DetachFromParent = false;
        public bool m_DelayDestroy = false;
        public float m_DelayTime = 0;

        private bool m_InDestroyProgress = false;
        private float m_InDestroyPastTime = 0;

        private Vector3 m_LocalPositionInit;
        private Vector3 m_LocalEulerAnglesInit;
        private Vector3 m_LocalScaleInit;
        public void Detach()
        {
            gameObject.transform.SetParent(null);
            OnDetach();
        }
        public void OnDetach()
        {
            transform.position = m_LocalPositionInit + m_DetachGoParent.transform.position;
            transform.eulerAngles = m_LocalEulerAnglesInit + m_DetachGoParent.transform.eulerAngles;
            transform.localScale.Set(m_LocalScaleInit.x * m_DetachGoParent.transform.localScale.x,
                                     m_LocalScaleInit.y * m_DetachGoParent.transform.localScale.y,
                                     m_LocalScaleInit.z * m_DetachGoParent.transform.localScale.z);

        }
        public void OnParentPositionDirty()
        {
            transform.position = m_LocalPositionInit + m_DetachGoParent.transform.position;
        }
        public void OnParentRotationDirty()
        {
            transform.eulerAngles = m_LocalEulerAnglesInit + m_DetachGoParent.transform.eulerAngles;
        }
        public void OnParentScaleDirty()
        {
            transform.localScale.Set(m_LocalScaleInit.x * m_DetachGoParent.transform.localScale.x,
                             m_LocalScaleInit.y * m_DetachGoParent.transform.localScale.y,
                             m_LocalScaleInit.z * m_DetachGoParent.transform.localScale.z);
        }
        public void Attach()
        {
            if (m_DetachGoParent != null)
            {
                gameObject.transform.SetParent(m_DetachGoParent.transform);
                OnAttach();
            }
            else
            {
                Debug.LogError("attach parent is null");
            }
        }
        public void OnAttach()
        {
            transform.localPosition = m_LocalPositionInit;
            transform.localEulerAngles = m_LocalEulerAnglesInit;
            transform.localScale = m_LocalScaleInit;
        }
        void Awake()
        {
            m_LocalPositionInit = transform.localPosition;
            m_LocalEulerAnglesInit = transform.localEulerAngles;
            m_LocalScaleInit = transform.localScale;

            m_InDestroyPastTime = 0;
            m_InDestroyProgress = false;
        }
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (m_InDestroyProgress)
            {
                if (m_DelayTime == 0)
                {
                    DestroyImp();
                }
                else
                {
                    m_InDestroyPastTime += Time.deltaTime;
                    if (m_InDestroyPastTime >= m_DelayTime)
                    {
                        DestroyImp();
                    }
                }
            }
        }
        private void DestroyImp()
        {
            m_InDestroyProgress = false;
            m_InDestroyPastTime = 0;
            Destroy(gameObject);
        }
        public void OnParentDestroy()
        {
            m_InDestroyProgress = true;
        }
    }
}