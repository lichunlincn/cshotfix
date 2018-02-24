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
    public class HotFixBugsManager
    {
        public static bool OpenBugFixReg = true;
        //注册需要替换的Mono委托字段
        //可以通过查看ILSpy等软件了解对应出bug的函数的委托字段
        public static void RegDelegate()
        {
            if(!OpenBugFixReg)
            {
                return;
            }
            //注册需要修复的bug
            LCLFieldDelegateName.__LCL_MainTest__Test2_Int32_Single_Void__Delegate += Bugs_LCL_MainTest.OnHotFixTest;

        }

    }
}
