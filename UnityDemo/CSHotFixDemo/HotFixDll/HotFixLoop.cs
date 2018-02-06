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
            //注册需要修复的bug
            LCLFieldDelegateName.__LCL_MainTest__Test2_Int32_Single__Delegate += OnHotFixTest;


            m_GameMain = new GameMain();
            m_GameMain.Start();
        }

        private void OnHotFixTest(object main_test, int arg1, float arg2)
        {
            Debug.Log("修复一个bug arg1:"+arg1+"arg2:"+arg2);

            Debug.Log("开始测试反射访问私有变量");
            main_test.CallPrivateMethod("Test1", 10);
            Debug.Log("结束测试反射访问私有变量");

            //尝试使用mono的一个delegate
            TestDelegate.TestExportDelegate call = OnCallDelegate;
            TestDelegateData data = new TestDelegateData();
            data.m_Field = 12;
            Debug.Log( call(data,2,3));
        }

        private int OnCallDelegate(TestDelegateData a, int b, long c)
        {
            return a.m_Field + b;
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
