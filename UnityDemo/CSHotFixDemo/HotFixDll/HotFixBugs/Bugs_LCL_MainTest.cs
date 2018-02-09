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
using System.Linq;
using System.Text;
using UnityEngine;

namespace LCL
{
    public class Bugs_LCL_MainTest
    {
        public static void OnHotFixTest(object main_test, int arg1, float arg2)
        {
            Debug.Log("修复一个bug arg1:" + arg1.ToString() + "arg2:" + arg2.ToString());
            Debug.Log("开始测试反射访问私有变量");
            main_test.CallPrivateMethod("Test1", 10);
            Debug.Log("结束测试反射访问私有变量");

            //尝试使用mono的一个delegate
            TestDelegate.TestExportDelegate call = OnCallDelegate;
            TestDelegateData data = new TestDelegateData();
            data.m_Field = 12;
            Debug.Log(call(data, 2, 2));
        }

        private static int OnCallDelegate(TestDelegateData a, int b, long c)
        {
            return a.m_Field + b;
        }
    }
}
