using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class HotFixDllLoader : MonoBehaviour {
    public TextAsset HotFixDll;


    private ILRuntime.Runtime.Enviorment.AppDomain m_AssemblyILR = new ILRuntime.Runtime.Enviorment.AppDomain();
    private IGameHotFixInterface m_HotFixDll = null;

    public void Init()
    {
        using (System.IO.MemoryStream fs = new MemoryStream(HotFixDll.bytes))
        {
            m_AssemblyILR.LoadAssembly(fs);
        }
        m_AssemblyILR.AllowUnboundCLRMethod = true;

        ILRuntime.Runtime.Enviorment.AppDomain.ShowDebugInfo = false;
        

        //注册跨域类
        m_AssemblyILR.RegisterCrossBindingAdaptor(new IGameHotFixInterfaceAdapter());


        m_AssemblyILR.DelegateManager.RegisterMethodDelegate<UnityEngine.GameObject>();
        m_AssemblyILR.DelegateManager.RegisterMethodDelegate<System.Int32>();
        m_AssemblyILR.DelegateManager.RegisterMethodDelegate<System.Boolean>();
        m_AssemblyILR.DelegateManager.RegisterMethodDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance>();

        m_AssemblyILR.DelegateManager.RegisterMethodDelegate<System.Int32, System.Int32>();
        m_AssemblyILR.DelegateManager.RegisterMethodDelegate<System.Object>();

        LCLFunctionDelegate.Reg(m_AssemblyILR);

        ILRuntime.Runtime.Generated.CLRBindings.Initialize(m_AssemblyILR);

        string HotFixLoop = "LCL.HotFixLoop";
        m_HotFixDll = m_AssemblyILR.Instantiate<IGameHotFixInterface>(HotFixLoop);
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
