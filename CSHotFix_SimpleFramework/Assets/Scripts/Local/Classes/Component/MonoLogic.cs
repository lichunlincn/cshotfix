using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace LCL
{
    public class MonoLogic : MonoBehaviour
    {
        void Start()
        {
            MonoMessage.Register();
        }
        void Update()
        {
            Ping.Update();
        }
        void Destroy()
        {
            MonoMessage.Unregister();
        }
    }

}