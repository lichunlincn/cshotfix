using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityUI
{
    public class UIRotateModel : MonoBehaviour
    {
        private Vector3 startFingerPos;
        private Vector3 nowFingerPos;
        private float xMoveDistance;
        private float yMoveDistance;
        private int backValue = 0;

        private bool _mouseDown = false;

        public Transform RotationObj;
        public float speed = 2;
        void Update()
        {
            if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
            {

                if (Input.touchCount <= 0)
                {
                    return;
                }

                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    //Debug.Log("======开始触摸=====");  
                    startFingerPos = Input.GetTouch(0).position;
                }

                nowFingerPos = Input.GetTouch(0).position;

                if ((Input.GetTouch(0).phase == TouchPhase.Stationary) || (Input.GetTouch(0).phase == TouchPhase.Ended))
                {
                    startFingerPos = nowFingerPos;
                    return;
                }
                if (startFingerPos == nowFingerPos)
                {
                    return;
                }
                xMoveDistance = Mathf.Abs(nowFingerPos.x - startFingerPos.x);
                if (nowFingerPos.x - startFingerPos.x > 0)
                {
                    //Debug.Log("=======沿着X轴负方向移动=====");  
                    backValue = -1; //沿着X轴负方向移动  
                }
                else
                {
                    //Debug.Log("=======沿着X轴正方向移动=====");  
                    backValue = 1; //沿着X轴正方向移动  
                }

                if (backValue == -1)
                {
                    RotationObj.Rotate(Vector3.up * -1 * Time.deltaTime * speed, Space.World);
                }
                else if (backValue == 1)
                {
                    RotationObj.Rotate(Vector3.up * Time.deltaTime * speed, Space.World);
                }
            }
            else
            {
                if (Input.GetMouseButtonDown(0))
                    _mouseDown = true;
                else if (Input.GetMouseButtonUp(0))
                    _mouseDown = false;


                if (_mouseDown)
                {
                    float fMouseX = Input.GetAxis("Mouse X");
                    RotationObj.Rotate(Vector3.up, -fMouseX * speed, Space.World);
                }
            }

        }
    }
}