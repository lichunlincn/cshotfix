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
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace LCL
{
    public class HotFixDllLoader : MonoBehaviour
    {
        //这里是处于演示版本的需要采用了挂脚本的方式，实际项目可能需要用AB的方式来加载
        public TextAsset HotFixDll;
        public TextAsset HotFixDllMdb;
        private IGameHotFixInterface m_DllInstance = null;

        public static bool IsHotFix = false;

#if CSHotFix
    private CSHotFix.Runtime.Enviorment.AppDomain m_Assembly = new CSHotFix.Runtime.Enviorment.AppDomain();
    public void Init()
    {
        IsHotFix = true;
        using (System.IO.MemoryStream fs = new MemoryStream(HotFixDll.bytes))
        {
            m_Assembly.LoadAssembly(fs);
        }
        m_Assembly.AllowUnboundCLRMethod = true;

        //注册跨域类
        AdapterRegister.RegisterCrossBindingAdaptor(m_Assembly);


        m_Assembly.DelegateManager.RegisterMethodDelegate<UnityEngine.GameObject>();
        m_Assembly.DelegateManager.RegisterMethodDelegate<System.Int32>();
        m_Assembly.DelegateManager.RegisterMethodDelegate<System.Boolean>();
        m_Assembly.DelegateManager.RegisterMethodDelegate<CSHotFix.Runtime.Intepreter.ILTypeInstance>();

        m_Assembly.DelegateManager.RegisterMethodDelegate<System.Int32, System.Int32>();
        m_Assembly.DelegateManager.RegisterMethodDelegate<System.Object>();

        LCLFunctionDelegate.Reg(m_Assembly);

        CSHotFix.Runtime.Generated.CLRBindings.Initialize(m_Assembly);

        string HotFixLoop = "LCL.HotFixLoop";
        m_DllInstance = m_Assembly.Instantiate<IGameHotFixInterface>(HotFixLoop);
        m_DllInstance.Start();
    }

#else
        private System.Reflection.Assembly m_Assembly = null;
        public void Init()
        {
            IsHotFix = false;
            if (HotFixDllMdb != null)
            {
                m_Assembly = System.Reflection.Assembly.Load(HotFixDll.bytes, HotFixDllMdb.bytes);
            }
            else
            {
                m_Assembly = System.Reflection.Assembly.Load(HotFixDll.bytes);
            }
            string HotFixLoop = "LCL.HotFixLoop";
            m_DllInstance = (IGameHotFixInterface)m_Assembly.CreateInstance(HotFixLoop);
            m_DllInstance.Start();
        }
#endif












        void Start()
        {
            if (HotFixDll == null)
            {
                Debug.LogError("请先将dll拖入到HotFixDllLoader脚本里面。");
                return;
            }
            if (HotFixDllMdb == null)
            {
#if CSHotFix
#else
                Debug.LogWarning("mdb 信息没有拖入到HotFixDllLoader，调试信息缺失");
#endif
            }
            Init();

            Debug.Log("开始热更新测试");
            int i = 15;
            float o = 0;
            LCL.MainTest mt = new LCL.MainTest();
            mt.Test2(i, o);
            Debug.Log("结束热更新测试");
        }

        void Update()
        {
            m_DllInstance.Update();
        }
        private void OnDestroy()
        {
            m_DllInstance.OnDestroy();
        }
    }
}