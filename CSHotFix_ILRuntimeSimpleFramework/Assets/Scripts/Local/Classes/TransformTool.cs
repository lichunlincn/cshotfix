using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace LCL
{
    public class TransformTool
    {
        private static Vector2 m_ScreenPointToLocalPointInRectangleLocalPosition;
        public static Vector2 GetScreenPointToLocalPointInRectangleLocalPosition()
        {
            return m_ScreenPointToLocalPointInRectangleLocalPosition;
        }
        public static bool ScreenPointToLocalPointInRectangle(RectTransform tran, Vector2 screenPoint, Camera cam)
        {
            return RectTransformUtility.ScreenPointToLocalPointInRectangle(tran, screenPoint, cam, out m_ScreenPointToLocalPointInRectangleLocalPosition);
        }
        public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPosition)
        {
           return RectTransformUtility.WorldToScreenPoint(cam, worldPosition);
        }

        public static Vector3 ScreenToWorldPoint(Camera cam, Vector3 v)
        {
            return  cam.ScreenToWorldPoint(v);
        }

        public static Ray ScreenPointToRay(Camera cam, Vector3 v)
        {
            return cam.ScreenPointToRay(v);
        }
        public static void CopyTransform(Transform tr, Transform other)
        {
            tr.position = other.position;
            tr.rotation = other.rotation;
            tr.localScale = other.localScale;
        }
        public static void CopyTransform(RectTransform tr, RectTransform other)
        {
            tr.position = other.position;
            tr.rotation = other.rotation;
            tr.localScale = other.localScale;
        }
    }

}