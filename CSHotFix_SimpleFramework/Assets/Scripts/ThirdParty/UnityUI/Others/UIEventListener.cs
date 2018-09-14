using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
namespace UnityUI
{
    public enum UIEventType
    {
        onSubmit,
        onClick,
        onHover,
        onToggleChanged,
        onSliderChanged,
        onScrollbarChanged,
        onDrapDownChanged,
        onInputFieldChanged,
    }
    public class UIEventListener : EventTrigger
    {



        public System.Action<GameObject> onSubmit { get; set; }
        public System.Action<GameObject> onClick { get; set; }
        public System.Action<GameObject, bool> onHover { get; set; }
        public System.Action<GameObject, bool> onToggleChanged { get; set; }
        public System.Action<GameObject, float> onSliderChanged { get; set; }
        public System.Action<GameObject, float> onScrollbarChanged { get; set; }
        public System.Action<GameObject, int> onDrapDownChanged { get; set; }
        public System.Action<GameObject, string> onInputFieldChanged { get; set; }
        public object m_UserData { get; set; }

        public override void OnSubmit(BaseEventData eventData)
        {
            if (onSubmit != null)
                onSubmit(gameObject);
        }
        public override void OnPointerEnter(PointerEventData eventData)
        {
            if (onHover != null)
                onHover(gameObject, true);
        }
        public override void OnPointerClick(PointerEventData eventData)
        {
            if (onClick != null)
                onClick(gameObject);
            if (onToggleChanged != null)
                onToggleChanged(gameObject, gameObject.GetComponent<Toggle>().isOn);

        }
        public override void OnPointerExit(PointerEventData eventData)
        {
            if (onHover != null)
                onHover(gameObject, false);
        }
        public override void OnDrag(PointerEventData eventData)
        {
            if (onSliderChanged != null)
                onSliderChanged(gameObject, gameObject.GetComponent<Slider>().value);
            if (onScrollbarChanged != null)
                onScrollbarChanged(gameObject, gameObject.GetComponent<Scrollbar>().value);

        }
        public override void OnSelect(BaseEventData eventData)
        {
            if (onDrapDownChanged != null)
                onDrapDownChanged(gameObject, gameObject.GetComponent<Dropdown>().value);
        }
        public override void OnUpdateSelected(BaseEventData eventData)
        {
            if (onInputFieldChanged != null)
                onInputFieldChanged(gameObject, gameObject.GetComponent<InputField>().text);
        }
        public override void OnDeselect(BaseEventData eventData)
        {
            if (onInputFieldChanged != null)
                onInputFieldChanged(gameObject, gameObject.GetComponent<InputField>().text);
        }
        //----------------------------------------------------------------------------------------
        public static void AddListener(Component com, UIEventType et, System.Action<GameObject> func, object userdata = null)
        {
            UIEventListener listener = GetOrAdd(com);
            if (listener == null)
            {
                Debug.LogError("设置事件的组件为空");
                return;
            }
            if (et == UIEventType.onSubmit)
            {
                listener.onSubmit = func;

            }
            else if (et == UIEventType.onClick)
            {
                listener.onClick = func;
            }
            if (listener != null)
            {
                listener.m_UserData = userdata;
            }
        }
        public static void RemoveListener(Component com, UIEventType et)
        {
            UIEventListener listener = GetOrAdd(com);
            if (listener == null)
            {
                Debug.LogError("设置事件的组件为空");
                return;
            }
            if (et == UIEventType.onSubmit)
            {
                listener.onSubmit = null;
            }
            else if (et == UIEventType.onClick)
            {
                listener.onClick = null;
            }
            else if (et == UIEventType.onSliderChanged)
            {
                listener.onSliderChanged = null;
            }
            else if (et == UIEventType.onScrollbarChanged)
            {
                listener.onScrollbarChanged = null;
            }
            else if (et == UIEventType.onHover)
            {
                listener.onHover = null;
            }
            else if (et == UIEventType.onToggleChanged)
            {
                listener.onToggleChanged = null;
            }
            else if (et == UIEventType.onDrapDownChanged)
            {
                listener.onDrapDownChanged = null;
            }
            else if (et == UIEventType.onInputFieldChanged)
            {
                listener.onInputFieldChanged = null;
            }
            if (listener != null)
            {
                listener.m_UserData = null;
            }
        }
        public static void AddListener(Component com, UIEventType et, System.Action<GameObject, bool> func, object userdata = null)
        {
            UIEventListener listener = GetOrAdd(com);
            if (listener == null)
            {
                Debug.LogError("设置事件的组件为空");
                return;
            }
            if (et == UIEventType.onHover)
            {
                listener.onHover = func;
            }
            else if (et == UIEventType.onToggleChanged)
            {
                listener.onToggleChanged = func;
            }
            if (listener != null)
            {
                listener.m_UserData = userdata;
            }

        }

        public static void AddListener(Component com, UIEventType et, System.Action<GameObject, float> func, object userdata)
        {
            UIEventListener listener = GetOrAdd(com);
            if (listener == null)
            {
                Debug.LogError("设置事件的组件为空");
                return;
            }
            if (et == UIEventType.onSliderChanged)
            {
                listener.onSliderChanged = func;
            }
            else if (et == UIEventType.onScrollbarChanged)
            {
                listener.onScrollbarChanged = func;
            }
            if (listener != null)
            {
                listener.m_UserData = userdata;
            }
        }

        public static void AddListener(Component com, UIEventType et, System.Action<GameObject, int> func, object userdata)
        {
            UIEventListener listener = GetOrAdd(com);
            if (listener == null)
            {
                Debug.LogError("设置事件的组件为空");
                return;
            }
            if (et == UIEventType.onDrapDownChanged)
            {
                listener.onDrapDownChanged = func;
            }
            if (listener != null)
            {
                listener.m_UserData = userdata;
            }
        }
        public static void AddListener(Component com, UIEventType et, System.Action<GameObject, string> func, object userdata)
        {
            UIEventListener listener = GetOrAdd(com);
            if (listener == null)
            {
                Debug.LogError("设置事件的组件为空");
                return;
            }
            if (et == UIEventType.onInputFieldChanged)
            {
                listener.onInputFieldChanged = func;
            }
            if (listener != null)
            {
                listener.m_UserData = userdata;
            }
        }
        public static UIEventListener Get(Component com)
        {
            if (com == null)
            {
                return null;
            }
            UIEventListener listener = com.GetComponent<UIEventListener>();
            return listener;
        }
        public static UIEventListener Get(GameObject go)
        {
            if (go == null)
            {
                return null;
            }
            UIEventListener listener = go.GetComponent<UIEventListener>();
            return listener;
        }
        private static UIEventListener GetOrAdd(Component com)
        {
            if (com == null)
            {
                return null;
            }
            else
            {
                if (com.gameObject == null || com.gameObject.Equals(null))
                {
                    return null;
                }
                else
                {
                    GameObject go = com.gameObject;
                    UIEventListener listener = go.GetComponent<UIEventListener>();
                    if (listener == null)
                    {
                        listener = go.AddComponent<UIEventListener>();
                    }
                    return listener;
                }
            }
        }
    }
}