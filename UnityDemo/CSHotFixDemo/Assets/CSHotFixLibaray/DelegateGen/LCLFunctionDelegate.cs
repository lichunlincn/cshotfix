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
public class LCLFunctionDelegate
{
     public delegate void method_delegate0(System.Object arg0);
     public delegate void method_delegate1(System.Object arg0,System.Int32 arg1);
     public delegate void method_delegate2(System.Object arg0,System.Int32 arg1,System.Single arg2);
     public delegate LCL.DataClass function_delegate3(System.Object arg0,LCL.DataClass arg1);
     public delegate System.Int32 function_delegate4(System.Object arg0,System.Int32 arg1,System.Int32 arg2);
    public static void Reg(ILRuntime.Runtime.Enviorment.AppDomain appDomain)
{ 
appDomain.DelegateManager.RegisterMethodDelegate<System.Object>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate0>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate0((arg0) =>
       {
       ((Action<System.Object>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.Int32>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate1>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate1((arg0,arg1) =>
       {
       ((Action<System.Object,System.Int32>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.Int32,System.Single>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate2>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate2((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,System.Int32,System.Single>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,LCL.DataClass,LCL.DataClass>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate3>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate3((arg0,arg1) =>
       {
       return ((Func<System.Object,LCL.DataClass,LCL.DataClass>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Int32,System.Int32,System.Int32>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate4>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate4((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,System.Int32,System.Int32,System.Int32>)act)(arg0,arg1,arg2);
       });
   });

}
}