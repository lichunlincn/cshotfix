/*
* LCL support c# hotfix here.
*Copyright(C) LCL.All rights reserved.
* URL:https://github.com/qq576067421/cshotfix 
*QQ:576067421 
* QQ Group: 673735733 
 * Licensed under the GNU License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at 
* http://fsf.org/ 
* Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License. 
*/
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace LCL
{
    public class HotFixLoop : IGameHotFixInterface
    {
        private static HotFixLoop m_Instance;
        private GameMain m_GameMain;
        public override void Start()
        {
            m_Instance = this;

            //根据发布版或者开发版情况开放是否需要修复mono的bug
            HotFixBugsManager.OpenBugFixReg = HotFixDllLoader.IsHotFix;
            HotFixBugsManager.RegDelegate();

            //开始热更新主逻辑
            m_GameMain = new GameMain();
            m_GameMain.Start();
        }





        public override void Update()
        {
            m_GameMain.Update();
        }
        public static HotFixLoop GetInstance()
        {
            return m_Instance;
        }

        public override void OnDestroy()
        {
            if(m_GameMain!= null)
            {
                m_GameMain.Destroy();
            }
        }
        public override void OnApplicationQuit()
        {
            if (m_GameMain != null)
            {
                m_GameMain.Destroy();
            }
        }
        public override object OnMono2GameDll(string func, params object[] data)
        {
            return null;
        }

    }
}
