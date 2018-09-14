using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
namespace GameDll
{
    public class GMManager
    {
        private static GMManager m_Instance = null;
        public static GMManager GetInstance()
        {
            if (m_Instance == null)
            {
                m_Instance = new GMManager();
            }
            return m_Instance;
        }

        public GMManager()
        {
        }

        //private void OnSendGMResult(WfPacket packet)
        //{
        //}
        public void SendGM(string str)
        {
            //List<string> cmdString = Tool.ParseStrings(str);
            //if (cmdString != null && cmdString.Count > 0)
            //{
            //    if (cmdString[0] == "local")
            //    {
            //        DoLocalGM(cmdString);
            //    }
            //    else
            //    {

            //    }
            //}
            //else
            //{
            //    UnityEngine.Debug.LogWarning("空GM指令不会发送和处理");
            //}
        }
        public  void Update(float dt)
        {
        }
        public  void Destroy()
        {
            
        }

        public void DoLocalGM(List<string> cmd)
        {

        }
    }
}
