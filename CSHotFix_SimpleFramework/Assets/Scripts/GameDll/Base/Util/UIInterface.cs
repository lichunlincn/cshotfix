using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityUI;



public class UIInterface
{
    /// <summary>
    /// 判断组件是否为空
    /// </summary>
    /// <param name="com"></param>
    /// <returns></returns>
    public static bool IsNull(Component com)
    {
        if (com == null || com.gameObject.Equals(null))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    /// <summary>
    /// 设置文本组件的文本和颜色
    /// </summary>
    /// <param name="txt"></param>
    /// <param name="str"></param>
    /// <param name="color"></param>
    public static void SetText(Text txt, string str, string color = null)
    {
        if (IsNull(txt))
        {
            UnityEngine.Debug.LogError("SetText txt nil");
            return;
        }
        if (color != null)
        {
            str = "<color=#" + color + ">" + str + "</color>";
        }
        txt.text = str;
    }
    public static void SetText(InputField txt, string str, string color = null)
    {
        if (IsNull(txt))
        {
            UnityEngine.Debug.LogError("SetText txt nil");
            return;
        }
        if (color != null)
        {
            str = "<color=#" + color + ">" + str + "</color>";
        }
        txt.text = str;
    }
    /// <summary>
    /// 获取文本
    /// </summary>
    /// <param name="txt"></param>
    /// <returns></returns>
    public static string GetText(Text txt)
    {
        if (IsNull(txt))
        {
            UnityEngine.Debug.LogError("SetText txt nil");
            return string.Empty;
        }
        return txt.text;
    }
    public static string GetText(InputField txt)
    {
        if (IsNull(txt))
        {
            UnityEngine.Debug.LogError("SetText txt nil");
            return string.Empty;
        }
        return txt.text;
    }
    /// <summary>
    /// 设置组件的世界位置信息
    /// </summary>
    /// <param name="com"></param>
    /// <param name="pos"></param>
    public static void SetPosition(Component com, Vector3 pos)
    {
        if (IsNull(com))
        {
            return;
        }
        com.transform.position = pos;
    }
    /// <summary>
    /// 获取组件的世界位置信息
    /// </summary>
    /// <param name="com"></param>
    /// <returns></returns>
    public static Vector3 GetPosition(Component com)
    {
        if (IsNull(com))
        {
            Debug.LogError("GetPosition com is null");
            return Vector3.zero;
        }
        return com.transform.position;
    }

    public static Component GetComponent(Component com, Type _type, string path)
    {
        if (IsNull(com))
        {
            Debug.LogError("GetComponent com is null");
            return null;
        }
        if (string.IsNullOrEmpty(path))
        {
            return com.GetComponent(_type);
        }
        else
        {
            var trans = com.transform.Find(path);
            if (trans != null)
            {
                return trans.GetComponent(_type);
            }
            else
            {
                return null;
            }
        }
    }
    public static Component GetComponent(GameObject com, Type _type, string path)
    {
        if (com != null)
        {
            return GetComponent(com.transform, _type, path);
        }
        else
        {
            return null;
        }
    }

    /// <summary>
    /// 设置组件的本地位置信息
    /// </summary>
    /// <param name="com"></param>
    /// <param name="pos"></param>
    public static void SetLocalPosition(Component com, Vector3 pos)
    {
        if (IsNull(com))
        {
            return;
        }
        com.transform.localPosition = pos;
    }
    /// <summary>
    /// 获取组件本地位置信息
    /// </summary>
    /// <param name="com"></param>
    /// <returns></returns>
    public static Vector3 GetLocalPosition(Component com)
    {
        if (IsNull(com))
        {
            Debug.LogError("GetLocalPosition com is null");
            return Vector3.zero;
        }
        return com.transform.localPosition;
    }

    /// <summary>
    /// 设置大小，这里一般是针对LocalScale的
    /// </summary>
    /// <param name="com"></param>
    /// <param name="scale"></param>
    public static void SetScale(Component com, Vector3 scale)
    {
        if (IsNull(com))
        {
            Debug.LogError("SetScale com is null");
            return;
        }
        com.transform.localScale = scale;
    }
    public static Vector3 GetScale(Component com)
    {
        if (IsNull(com))
        {
            Debug.LogError("GetScale com is null");
            return Vector3.one;
        }
        return com.transform.localScale;
    }

    public static void SetEulaRotation(Component com, Vector3 rotation)
    {
        if (IsNull(com))
        {
            Debug.LogError("SetEulaRotation com is null");
            return;
        }
        com.transform.eulerAngles = rotation;
    }
    public static Vector3 GetEulaRotation(Component com)
    {
        if (IsNull(com))
        {
            Debug.LogError("GetEulaRotation com is null");
            return Vector3.zero;
        }
        return com.transform.eulerAngles;
    }
    public static void SetLocalEulaRotation(Component com, Vector3 rotation)
    {
        if (IsNull(com))
        {
            Debug.LogError("SetLocalEulaRotation com is null");
            return;
        }
        com.transform.localEulerAngles = rotation;
    }
    public static Vector3 GetLocalEulaRotation(Component com)
    {
        if (IsNull(com))
        {
            Debug.LogError("GetLocalEulaRotation com is null");
            return Vector3.zero;
        }
        return com.transform.localEulerAngles;
    }
    /// <summary>
    /// 将组件的转换矩阵归一化
    /// </summary>
    /// <param name="com"></param>
    public static void ResetTransform(Component com, bool resetLocal)
    {
        if (IsNull(com))
        {
            Debug.LogError("ResetTransform com is null");
            return;
        }
        Transform trans = com.transform;
        if (resetLocal)
        {
            trans.localScale = Vector3.one;
            trans.localEulerAngles = Vector3.zero;
            trans.localPosition = Vector3.zero;
        }
        else
        {
            trans.localScale = Vector3.one;
            trans.eulerAngles = Vector3.zero;
            trans.position = Vector3.zero;
        }

    }
    /// <summary>
    /// 设置组件的父对象，并且设置是否保持世界坐标不变化
    /// </summary>
    /// <param name="child"></param>
    /// <param name="parent"></param>
    /// <param name="worldPositionStays"></param>
    public static void SetParent(Component child, Transform parent, bool worldPositionStays)
    {
        if (IsNull(child))
        {
            Debug.LogError("SetParent com is null");
            return;
        }
        child.transform.SetParent(parent, worldPositionStays);
    }
    /// <summary>
    /// 获取组件的父对象
    /// </summary>
    /// <param name="child"></param>
    /// <returns></returns>
    public static Transform GetParent(Component child)
    {
        if (IsNull(child))
        {
            Debug.LogError("GetParent com is null");
            return null;
        }
        return child.transform.parent;
    }

    public static Component AddComponent(Component addTo, Type addType)
    {
        if (IsNull(addTo))
        {
            return null;
        }
        return addTo.gameObject.AddComponent(addType);
    }

    public static Component GetOrAddComponent(Component addTo, Type addType)
    {
        if (IsNull(addTo))
        {
            return null;
        }
        Component hrCom = addTo.gameObject.GetComponent(addType);
        if (hrCom == null)
        {
            hrCom = addTo.gameObject.AddComponent(addType);
        }
        return hrCom;
    }
    public static void SetActive(Component com, bool active)
    {
        if (IsNull(com))
        {
            return;
        }
        com.gameObject.SetActive(active);
    }
    public static bool GetActive(Component com)
    {
        if (IsNull(com))
        {
            return false;
        }
        return com.gameObject.activeSelf;
    }
    #region UI 事件监听注册
    public static void AddListener(Component com, UIEventType et, System.Action<GameObject> func, object userdata = null)
    {
        UIEventListener.AddListener(com, et, func, userdata);
    }
    public static void RemoveListener(Component com, UIEventType et)
    {
        UIEventListener.RemoveListener(com, et);
    }
    public static void AddListener(Component com, UIEventType et, System.Action<GameObject, bool> func, object userdata = null)
    {
        UIEventListener.AddListener(com, et, func, userdata);
    }

    public static void AddListener(Component com, UIEventType et, System.Action<GameObject, float> func, object userdata = null)
    {
        UIEventListener.AddListener(com, et, func, userdata);
    }

    public static void AddListener(Component com, UIEventType et, System.Action<GameObject, int> func, object userdata = null)
    {
        UIEventListener.AddListener(com, et, func, userdata);
    }
    public static void AddListener(Component com, UIEventType et, System.Action<GameObject, string> func, object userdata = null)
    {
        UIEventListener.AddListener(com, et, func, userdata);
    }
    public static UIEventListener Get(Component com)
    {
        return UIEventListener.Get(com);
    }
    public static UIEventListener Get(GameObject go)
    {
        return UIEventListener.Get(go);
    }
    #endregion

    #region UI常用的一些节省开销的函数
    public static Image GetImage(Component com, string path)
    {
        Transform tr = null;
        if (string.IsNullOrEmpty(path))
        {
            tr = com.transform;
        }
        else
        {
            tr = GetTransform(com, path);
        }
        return GetImage(tr);
    }
    public static Image GetImage(Component com)
    {
        if (com == null)
        {
            return null;
        }
        else
        {
            return com.GetComponent<Image>();
        }
    }
    public static Text GetText(Component com, string path)
    {
        Transform tr = null;
        if (string.IsNullOrEmpty(path))
        {
            tr = com.transform;
        }
        else
        {
            tr = GetTransform(com, path);
        }
        return GetText(tr);
    }
    public static Text GetText(Component com)
    {
        if (com == null)
        {
            return null;
        }
        else
        {
            return com.GetComponent<Text>();
        }
    }
    public static Button GetButton(Component com, string path)
    {
        Transform tr = null;
        if (string.IsNullOrEmpty(path))
        {
            tr = com.transform;
        }
        else
        {
            tr = GetTransform(com, path);
        }
        return GetButton(tr);
    }
    public static Button GetButton(Component com)
    {
        if (com == null)
        {
            return null;
        }
        else
        {
            return com.GetComponent<Button>();
        }
    }
    //public static LoopListView2 GetList(Component com, string path)
    //{
    //    Transform tr = null;
    //    if (string.IsNullOrEmpty(path))
    //    {
    //        tr = com.transform;
    //    }
    //    else
    //    {
    //        tr = GetTransform(com, path);
    //    }
    //    return GetList(tr);
    //}
    //public static LoopListView2 GetList(Component com)
    //{
    //    if (com == null)
    //    {
    //        return null;
    //    }
    //    else
    //    {
    //        return com.GetComponent<LoopListView2>();
    //    }
    //}
    public static Transform GetTransform(Component com, string path)
    {
        if (com == null)
        {
            return null;
        }
        if (string.IsNullOrEmpty(path))
        {
            return com.transform;
        }
        else
        {
            return com.transform.Find(path);
        }
    }
    public static Transform GetTransform(GameObject com, string path)
    {
        if (com == null)
        {
            return null;
        }
        if (string.IsNullOrEmpty(path))
        {
            return com.transform;
        }
        else
        {
            return com.transform.Find(path);
        }
    }
    #endregion
}

