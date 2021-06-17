/*
/*
* LCL support c# hotfix here.
*Copyright(C) LCL.All rights reserved.
* URL:https://github.com/qq576067421/cshotfix 
*QQ:576067421 
* QQ Group: 673735733 
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at 
*  
* Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum InjectFlagEnum
{
    NoInject,
    Inject,
    None
}
public class CSHotFixAttribute : Attribute
{
    //这个标记默认true吧
    //private bool m_CheckHasRefOut = true;

    //public bool CheckHasRefOut
    //{
    //    get { return this.m_CheckHasRefOut; }

    //    set { this.m_CheckHasRefOut = value; }
    //}

    //private bool m_CheckHasGenericType = true;
    //public bool CheckHasGenericType
    //{
    //    get { return this.m_CheckHasGenericType; }

    //    set { this.m_CheckHasGenericType = value; }
    //}
    private InjectFlagEnum m_InjectFlag = InjectFlagEnum.None;

    public InjectFlagEnum InjectFlag
    {
        get { return this.m_InjectFlag; }

        set { this.m_InjectFlag = value; }
    }
}
