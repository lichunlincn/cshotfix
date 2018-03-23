/*
* LCL support c# hotfix here.
*Copyright(C) LCL.All rights reserved
* URL:https://github.com/qq576067421/cshotfix
*QQ:576067421
* QQ Group: 673735733
* Licensed under the MIT License (the 'License'); you may not use this file except in compliance with the License. You may obtain a copy of the License at
* 
* Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an 'AS IS' BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/
using System;
using System.Collections;
using System.Collections.Generic;
using CSHotFix.CLR.Method;
using CSHotFix.Runtime.Enviorment;
using CSHotFix.Runtime.Intepreter;
public class IGameHotFixInterfaceAdapter:CrossBindingAdaptor
{
public override Type BaseCLRType
{
    get
    {
        return typeof(IGameHotFixInterface);//这是你想继承的那个类
    }
}
public override Type AdaptorType
{
    get
    {
        return typeof(Adaptor);//这是实际的适配器类
    }
}
public override object CreateCLRInstance(CSHotFix.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
{
    return new Adaptor(appdomain, instance);//创建一个新的实例
}
//实际的适配器类需要继承你想继承的那个类，并且实现CrossBindingAdaptorType接口
class Adaptor : IGameHotFixInterface, CrossBindingAdaptorType
{
    ILTypeInstance instance;
    CSHotFix.Runtime.Enviorment.AppDomain appdomain;
    //缓存这个数组来避免调用时的GC Alloc
    object[] param1 = new object[1];
    public Adaptor()
    {

    }
    public Adaptor(CSHotFix.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
    {
        this.appdomain = appdomain;
        this.instance = instance;
    }
    public ILTypeInstance ILInstance { get { return instance; } }
bool m_bStartGot = false;
IMethod m_Start = null;
public override void Start ()
{
   if(!m_bStartGot)
   {
       m_Start = instance.Type.GetMethod("Start",0);
       m_bStartGot = true;
   }
          if(m_Start != null)
       {
            appdomain.Invoke(m_Start, instance,null);
        }
       else
       {
           
       } 
}
bool m_bUpdateGot = false;
IMethod m_Update = null;
public override void Update ()
{
   if(!m_bUpdateGot)
   {
       m_Update = instance.Type.GetMethod("Update",0);
       m_bUpdateGot = true;
   }
          if(m_Update != null)
       {
            appdomain.Invoke(m_Update, instance,null);
        }
       else
       {
           
       } 
}
bool m_bOnDestroyGot = false;
IMethod m_OnDestroy = null;
public override void OnDestroy ()
{
   if(!m_bOnDestroyGot)
   {
       m_OnDestroy = instance.Type.GetMethod("OnDestroy",0);
       m_bOnDestroyGot = true;
   }
          if(m_OnDestroy != null)
       {
            appdomain.Invoke(m_OnDestroy, instance,null);
        }
       else
       {
           
       } 
}
bool m_bOnApplicationQuitGot = false;
IMethod m_OnApplicationQuit = null;
public override void OnApplicationQuit ()
{
   if(!m_bOnApplicationQuitGot)
   {
       m_OnApplicationQuit = instance.Type.GetMethod("OnApplicationQuit",0);
       m_bOnApplicationQuitGot = true;
   }
          if(m_OnApplicationQuit != null)
       {
            appdomain.Invoke(m_OnApplicationQuit, instance,null);
        }
       else
       {
           
       } 
}
bool m_bOnMono2GameDllGot = false;
IMethod m_OnMono2GameDll = null;
public override System.Object OnMono2GameDll (System.String arg0,System.Object[] arg1)
{
   if(!m_bOnMono2GameDllGot)
   {
       m_OnMono2GameDll = instance.Type.GetMethod("OnMono2GameDll",2);
       m_bOnMono2GameDllGot = true;
   }
          if(m_OnMono2GameDll != null)
       {
           return appdomain.Invoke(m_OnMono2GameDll, instance,arg0,arg1);
        }
       else
       {
           return null;
       } 
}
}
}