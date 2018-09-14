using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System;

namespace UnityUI
{
    //lcl 2017年1月16日19:09:05
    //桥接窗口组件和代码
    public class ComponentBridge : MonoBehaviour
    {
        [SerializeField]
        private List<Component> m_ListComponent = new List<Component>();

        public Component GetControl(int index)
        {
            if (index >= 0 && index < m_ListComponent.Count)
            {
                Component tr = m_ListComponent[index];
                return tr;
            }
            else
            {
                return null;
            }
        }
        public List<Component> GetAllComponents()
        {
            return m_ListComponent;
        }
    }
}