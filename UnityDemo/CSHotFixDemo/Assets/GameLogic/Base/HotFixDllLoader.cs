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

public class HotFixDllLoader : MonoBehaviour {
    public TextAsset HotFixDll;


    private CSHotFix.Runtime.Enviorment.AppDomain m_AssemblyHotFix = new CSHotFix.Runtime.Enviorment.AppDomain();
    private IGameHotFixInterface m_HotFixDll = null;

    public void Init()
    {
        using (System.IO.MemoryStream fs = new MemoryStream(HotFixDll.bytes))
        {
            m_AssemblyHotFix.LoadAssembly(fs);
        }
        m_AssemblyHotFix.AllowUnboundCLRMethod = true;

        //注册跨域类
        m_AssemblyHotFix.RegisterCrossBindingAdaptor(new IGameHotFixInterfaceAdapter());


        m_AssemblyHotFix.DelegateManager.RegisterMethodDelegate<UnityEngine.GameObject>();
        m_AssemblyHotFix.DelegateManager.RegisterMethodDelegate<System.Int32>();
        m_AssemblyHotFix.DelegateManager.RegisterMethodDelegate<System.Boolean>();
        m_AssemblyHotFix.DelegateManager.RegisterMethodDelegate<CSHotFix.Runtime.Intepreter.ILTypeInstance>();

        m_AssemblyHotFix.DelegateManager.RegisterMethodDelegate<System.Int32, System.Int32>();
        m_AssemblyHotFix.DelegateManager.RegisterMethodDelegate<System.Object>();

        LCLFunctionDelegate.Reg(m_AssemblyHotFix);
#if CSHotFix
        CSHotFix.Runtime.Generated.CLRBindings.Initialize(m_AssemblyHotFix);
#endif
        string HotFixLoop = "LCL.HotFixLoop";
        m_HotFixDll = m_AssemblyHotFix.Instantiate<IGameHotFixInterface>(HotFixLoop);
        m_HotFixDll.Start();
    }














    void Start ()
    {
        Init();

        Debug.Log("开始热更新测试");
        int i = 15;
        float o = 0;
        LCL.MainTest mt = new LCL.MainTest();
        mt.Test2(i, o);
        Debug.Log("结束热更新测试");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
