using System;
using System.Text;
using UnityEngine;
public static class MyExtensionMethods
{
    public static Vector3 vec3 = Vector3.zero;

    public static void Clear(this StringBuilder sb)
    {
        sb.Length = 0;
    }
    public static void AppendLineEx(this StringBuilder sb, string str = "")
    {
        sb.Append(str + "\r\n");
    }
    public static Vector2 GetValue(this Vector2 v2)
    {
        Vector2 hr = Vector2.zero;
        hr.x = v2.x;
        hr.y = v2.y;
        return hr;
    }
    //写该扩展方法的原因是js里面的Vector2和3是类，没有结构体的概念，我们实际上只是需要一个值而已
    public static Vector3 GetValue(this Vector3 v3)
    {
        Vector3 hr = Vector3.zero;
        hr.x = v3.x;
        hr.y = v3.y;
        hr.z = v3.z;
        return hr;
    }
}
