#if CSHotFix
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
public class LCLFunctionDelegate
{
     public delegate void method_delegate0(System.Object arg0,System.Int32 arg1);
     public delegate void method_delegate1(System.Object arg0,System.Boolean arg1);
     public delegate System.Boolean function_delegate2(System.Object arg0);
     public delegate void method_delegate3(System.Object arg0);
     public delegate System.String function_delegate4(System.Object arg0);
     public delegate void method_delegate5(System.Object arg0,System.String arg1);
     public delegate System.Action<UnityEngine.GameObject> function_delegate6(System.Object arg0);
     public delegate void method_delegate7(System.Object arg0,System.Action<UnityEngine.GameObject> arg1);
     public delegate System.Action<UnityEngine.GameObject, System.Boolean> function_delegate8(System.Object arg0);
     public delegate void method_delegate9(System.Object arg0,System.Action<UnityEngine.GameObject, System.Boolean> arg1);
     public delegate System.Action<UnityEngine.GameObject, System.Single> function_delegate10(System.Object arg0);
     public delegate void method_delegate11(System.Object arg0,System.Action<UnityEngine.GameObject, System.Single> arg1);
     public delegate System.Action<UnityEngine.GameObject, System.Int32> function_delegate12(System.Object arg0);
     public delegate void method_delegate13(System.Object arg0,System.Action<UnityEngine.GameObject, System.Int32> arg1);
     public delegate System.Action<UnityEngine.GameObject, System.String> function_delegate14(System.Object arg0);
     public delegate void method_delegate15(System.Object arg0,System.Action<UnityEngine.GameObject, System.String> arg1);
     public delegate System.Object function_delegate16(System.Object arg0);
     public delegate void method_delegate17(System.Object arg0,System.Object arg1);
     public delegate void method_delegate18(System.Object arg0,UnityEngine.EventSystems.BaseEventData arg1);
     public delegate void method_delegate19(System.Object arg0,UnityEngine.EventSystems.PointerEventData arg1);
     public delegate void method_delegate20(System.Object arg0,UnityEngine.Component arg1,UnityUI.UIEventType arg2,System.Action<UnityEngine.GameObject> arg3,System.Object arg4);
     public delegate void method_delegate21(System.Object arg0,UnityEngine.Component arg1,UnityUI.UIEventType arg2);
     public delegate void method_delegate22(System.Object arg0,UnityEngine.Component arg1,UnityUI.UIEventType arg2,System.Action<UnityEngine.GameObject, System.Boolean> arg3,System.Object arg4);
     public delegate void method_delegate23(System.Object arg0,UnityEngine.Component arg1,UnityUI.UIEventType arg2,System.Action<UnityEngine.GameObject, System.Single> arg3,System.Object arg4);
     public delegate void method_delegate24(System.Object arg0,UnityEngine.Component arg1,UnityUI.UIEventType arg2,System.Action<UnityEngine.GameObject, System.Int32> arg3,System.Object arg4);
     public delegate void method_delegate25(System.Object arg0,UnityEngine.Component arg1,UnityUI.UIEventType arg2,System.Action<UnityEngine.GameObject, System.String> arg3,System.Object arg4);
     public delegate UnityUI.UIEventListener function_delegate26(System.Object arg0,UnityEngine.Component arg1);
     public delegate UnityUI.UIEventListener function_delegate27(System.Object arg0,UnityEngine.GameObject arg1);
     public delegate UnityEngine.Canvas function_delegate28(System.Object arg0);
     public delegate UnityEngine.Camera function_delegate29(System.Object arg0);
     public delegate UnityEngine.Component function_delegate30(System.Object arg0,System.Int32 arg1);
     public delegate System.Collections.Generic.List<UnityEngine.Component> function_delegate31(System.Object arg0);
     public delegate System.String function_delegate32(System.Object arg0,System.String arg1,System.String arg2);
     public delegate void method_delegate33(System.Object arg0,UnityEngine.Material arg1,LCL.RenderingMode arg2);
     public delegate System.Int64 function_delegate34(System.Object arg0,LCL.SetImageSpriteParam arg1);
     public delegate void method_delegate35(System.Object arg0,LCL.ABObject arg1);
     public delegate void method_delegate36(System.Object arg0,System.Int64 arg1);
     public delegate void method_delegate37(System.Object arg0,System.Object arg1,System.Int64 arg2);
     public delegate UnityEngine.Sprite function_delegate38(System.Object arg0,System.String arg1);
     public delegate void method_delegate39(System.Object arg0,UnityEngine.UI.Image arg1,System.String arg2);
     public delegate System.String function_delegate40(System.Object arg0,System.String arg1);
     public delegate UnityEngine.GameObject function_delegate41(System.Object arg0);
     public delegate void method_delegate42(System.Object arg0,UnityEngine.Events.UnityEvent arg1);
     public delegate void method_delegate43(System.Object arg0,UnityEngine.GameObject arg1);
     public delegate void method_delegate44(System.Object arg0,LCL.SetImageSpriteParam arg1,UnityEngine.Sprite arg2);
     public delegate UnityEngine.Coroutine function_delegate45(System.Object arg0,System.Collections.IEnumerator arg1);
     public delegate System.Collections.IEnumerator function_delegate46(System.Object arg0,System.Collections.IEnumerator[] arg1);
     public delegate System.Int32 function_delegate47(System.Object arg0,LITJson.JsonData arg1);
     public delegate System.Boolean function_delegate48(System.Object arg0,LITJson.JsonData arg1);
     public delegate System.Collections.Generic.ICollection<System.String> function_delegate49(System.Object arg0,LITJson.JsonData arg1);
     public delegate System.Boolean function_delegate50(System.Object arg0,LITJson.JsonData arg1,System.String arg2);
     public delegate LITJson.JsonData function_delegate51(System.Object arg0,LITJson.JsonData arg1,System.String arg2);
     public delegate LITJson.JsonData function_delegate52(System.Object arg0,LITJson.JsonData arg1,System.Int32 arg2);
     public delegate System.Double function_delegate53(System.Object arg0,LITJson.JsonData arg1);
     public delegate System.String function_delegate54(System.Object arg0,LITJson.JsonData arg1);
     public delegate void method_delegate55(System.Object arg0,LITJson.JsonData arg1,System.Boolean arg2);
     public delegate void method_delegate56(System.Object arg0,LITJson.JsonData arg1,System.Double arg2);
     public delegate void method_delegate57(System.Object arg0,LITJson.JsonData arg1,System.String arg2);
     public delegate System.Int32 function_delegate58(System.Object arg0,LITJson.JsonData arg1,System.Object arg2);
     public delegate void method_delegate59(System.Object arg0,LITJson.JsonData arg1);
     public delegate System.Boolean function_delegate60(System.Object arg0,LITJson.JsonData arg1,LITJson.JsonData arg2);
     public delegate System.Boolean function_delegate61(System.Object arg0,LITJson.JsonData arg1,System.Object arg2);
     public delegate void method_delegate62(System.Object arg0,LITJson.JsonData arg1,System.Int32 arg2);
     public delegate System.Single function_delegate63(System.Object arg0,LITJson.JsonData arg1);
     public delegate System.SByte function_delegate64(System.Object arg0,LITJson.JsonData arg1);
     public delegate System.Byte function_delegate65(System.Object arg0,LITJson.JsonData arg1);
     public delegate System.Int16 function_delegate66(System.Object arg0,LITJson.JsonData arg1);
     public delegate System.UInt16 function_delegate67(System.Object arg0,LITJson.JsonData arg1);
     public delegate System.UInt32 function_delegate68(System.Object arg0,LITJson.JsonData arg1);
     public delegate System.Single function_delegate69(System.Object arg0);
     public delegate UnityEngine.Component function_delegate70(System.Object arg0,UnityEngine.Component arg1,System.Type arg2);
     public delegate LITJson.JsonData function_delegate71(System.Object arg0,System.String arg1);
     public delegate LITJson.JsonData function_delegate72(System.Object arg0,UnityEngine.TextAsset arg1);
     public delegate System.Int64 function_delegate73(System.Object arg0);
     public delegate System.DateTime function_delegate74(System.Object arg0,System.Int64 arg1);
     public delegate System.Int64 function_delegate75(System.Object arg0,System.DateTime arg1);
     public delegate void method_delegate76(System.Object arg0,UnityEngine.GameObject arg1,System.Boolean arg2,System.String arg3);
     public delegate void method_delegate77(System.Object arg0,System.Action arg1);
     public delegate System.Int64 function_delegate78(System.Object arg0,System.Type arg1,System.String arg2,System.String arg3,System.Action<LCL.ABObject> arg4);
     public delegate LCL.ABObject function_delegate79(System.Object arg0,System.Type arg1,System.String arg2,System.String arg3);
     public delegate System.Int64 function_delegate80(System.Object arg0,System.Type arg1,System.String arg2,System.String[] arg3,System.Action<LCL.ABObject> arg4);
     public delegate LCL.ABObject function_delegate81(System.Object arg0,System.Type arg1,System.String arg2,System.String[] arg3);
     public delegate System.Int64 function_delegate82(System.Object arg0,System.String arg1,System.String arg2,System.Int32 arg3,System.Action arg4);
     public delegate void method_delegate83(System.Object arg0,System.String arg1,System.String arg2,System.Action<System.Byte[]> arg3);
     public delegate System.Byte[] function_delegate84(System.Object arg0,System.String arg1);
     public delegate UnityEngine.Vector2 function_delegate85(System.Object arg0);
     public delegate System.Boolean function_delegate86(System.Object arg0,UnityEngine.RectTransform arg1,UnityEngine.Vector2 arg2,UnityEngine.Camera arg3);
     public delegate UnityEngine.Vector2 function_delegate87(System.Object arg0,UnityEngine.Camera arg1,UnityEngine.Vector3 arg2);
     public delegate UnityEngine.Vector3 function_delegate88(System.Object arg0,UnityEngine.Camera arg1,UnityEngine.Vector3 arg2);
     public delegate UnityEngine.Ray function_delegate89(System.Object arg0,UnityEngine.Camera arg1,UnityEngine.Vector3 arg2);
     public delegate void method_delegate90(System.Object arg0,UnityEngine.Transform arg1,UnityEngine.Transform arg2);
     public delegate void method_delegate91(System.Object arg0,UnityEngine.RectTransform arg1,UnityEngine.RectTransform arg2);
     public delegate System.Boolean function_delegate92(System.Object arg0,System.String arg1);
     public delegate System.Int32 function_delegate93(System.Object arg0);
     public delegate System.Byte[] function_delegate94(System.Object arg0);
     public delegate void method_delegate95(System.Object arg0,System.Single arg1);
     public delegate System.IO.StreamReader function_delegate96(System.Object arg0,System.String arg1);
     public delegate System.IO.StreamReader function_delegate97(System.Object arg0,System.Byte[] arg1);
     public delegate System.String function_delegate98(System.Object arg0,UnityEngine.RuntimePlatform arg1);
     public delegate global::Setting function_delegate99(System.Object arg0);
     public delegate void method_delegate100(System.Object arg0,UnityEngine.ThreadPriority arg1);
     public delegate UnityEngine.ThreadPriority function_delegate101(System.Object arg0);
     public delegate GameDll.GMManager function_delegate102(System.Object arg0);
     public delegate void method_delegate103(System.Object arg0,System.Collections.Generic.List<System.String> arg1);
     public delegate UnityEngine.Vector3 function_delegate104(System.Object arg0);
     public delegate System.Boolean function_delegate105(System.Object arg0,System.Single arg1,System.Single arg2,System.Int32 arg3);
     public delegate void method_delegate106(System.Object arg0,UnityEngine.Ray arg1);
     public delegate void method_delegate107(System.Object arg0,UnityEngine.Vector3 arg1);
     public delegate UnityEngine.Shader function_delegate108(System.Object arg0,System.String arg1);
     public delegate GameDll.Timer function_delegate109(System.Object arg0);
     public delegate void method_delegate110(System.Object arg0,GameDll.Timer arg1);
     public delegate GameDll.Timer function_delegate111(System.Object arg0,System.Int64 arg1);
     public delegate void method_delegate112(System.Object arg0,System.String arg1,System.Int32 arg2);
     public delegate GameDll.VariableManager.GetValueIntParam function_delegate113(System.Object arg0,System.String arg1);
     public delegate void method_delegate114(System.Object arg0,System.String arg1,System.Single arg2);
     public delegate GameDll.VariableManager.GetValueFloatParam function_delegate115(System.Object arg0,System.String arg1);
     public delegate void method_delegate116(System.Object arg0,System.String arg1,System.String arg2);
     public delegate GameDll.VariableManager.GetValueStringParam function_delegate117(System.Object arg0,System.String arg1);
     public delegate System.Boolean function_delegate118(System.Object arg0,System.Single arg1,System.Single arg2);
     public delegate UnityEngine.Vector3 function_delegate119(System.Object arg0,System.IO.BinaryReader arg1);
     public delegate UnityEngine.Quaternion function_delegate120(System.Object arg0,System.IO.BinaryReader arg1);
     public delegate void method_delegate121(System.Object arg0,UnityEngine.GameObject arg1,System.String arg2);
     public delegate System.Boolean function_delegate122(System.Object arg0,System.Collections.Generic.List<System.Int32> arg1,System.String arg2,System.Char arg3);
     public delegate System.Boolean function_delegate123(System.Object arg0,System.Collections.Generic.List<System.String> arg1,System.String arg2,System.Char arg3);
     public delegate UnityEngine.Vector3 function_delegate124(System.Object arg0,System.String arg1,System.Char arg2);
     public delegate System.Collections.Generic.List<System.Single> function_delegate125(System.Object arg0,System.String arg1,System.Char arg2);
     public delegate System.Single function_delegate126(System.Object arg0,UnityEngine.Vector3 arg1,UnityEngine.Vector3 arg2);
     public delegate System.Boolean function_delegate127(System.Object arg0,UnityEngine.Vector3 arg1,UnityEngine.Vector3 arg2,System.Single arg3);
     public delegate void method_delegate128(System.Object arg0,System.Boolean arg1,System.String arg2);
     public delegate System.Single function_delegate129(System.Object arg0,GameDll.Tool.bezieratParam arg1);
     public delegate UnityEngine.Vector2 function_delegate130(System.Object arg0,UnityEngine.Vector3 arg1);
     public delegate UnityEngine.Vector2 function_delegate131(System.Object arg0,UnityEngine.Vector2 arg1);
     public delegate UnityEngine.Vector3 function_delegate132(System.Object arg0,System.Single arg1,System.Single arg2,System.Single arg3);
     public delegate UnityEngine.Ray function_delegate133(System.Object arg0,UnityEngine.Vector3 arg1);
     public delegate void method_delegate134(System.Object arg0,UnityEngine.GameObject arg1,System.Boolean arg2);
     public delegate void method_delegate135(System.Object arg0,UnityEngine.GameObject arg1,System.Single arg2);
     public delegate UnityEngine.Transform function_delegate136(System.Object arg0,UnityEngine.Transform arg1,System.String arg2);
     public delegate System.Single function_delegate137(System.Object arg0,UnityEngine.GameObject arg1);
     public delegate System.Single function_delegate138(System.Object arg0,UnityEngine.Vector3 arg1,System.Single arg2,UnityEngine.Vector3 arg3,System.Single arg4);
     public delegate void method_delegate139(System.Object arg0,UnityEngine.Transform arg1,System.String arg2);
     public delegate UnityEngine.GameObject function_delegate140(System.Object arg0,UnityEngine.GameObject arg1);
     public delegate UnityEngine.GameObject function_delegate141(System.Object arg0,UnityEngine.GameObject arg1,UnityEngine.GameObject arg2);
     public delegate void method_delegate142(System.Object arg0,UnityEngine.Transform arg1);
     public delegate void method_delegate143(System.Object arg0,UnityEngine.GameObject arg1,UnityEngine.GameObject arg2);
     public delegate UnityEngine.GameObject function_delegate144(System.Object arg0,UnityEngine.GameObject arg1,System.String arg2);
     public delegate System.Boolean function_delegate145(System.Object arg0,UnityEngine.GameObject arg1,UnityEngine.GameObject arg2);
     public delegate System.Object function_delegate146(System.Object arg0,System.String arg1,System.Object arg2);
     public delegate System.Single function_delegate147(System.Object arg0,System.Single arg1,System.Single arg2,System.Single arg3,System.Single arg4);
     public delegate System.Single function_delegate148(System.Object arg0,UnityEngine.Vector2 arg1,UnityEngine.Vector2 arg2);
     public delegate UnityEngine.Vector3 function_delegate149(System.Object arg0,System.Single arg1);
     public delegate UnityEngine.Vector3 function_delegate150(System.Object arg0,UnityEngine.Vector3 arg1,UnityEngine.Vector3 arg2);
     public delegate System.Single function_delegate151(System.Object arg0,System.Single arg1,System.Single arg2);
     public delegate UnityEngine.Vector2 function_delegate152(System.Object arg0,UnityEngine.RectTransform arg1,UnityEngine.Vector2 arg2,UnityEngine.Camera arg3);
     public delegate System.Single function_delegate153(System.Object arg0,System.Int32 arg1);
     public delegate System.Collections.Generic.List<LCL.KeyGameObject> function_delegate154(System.Object arg0,UnityEngine.GameObject arg1);
     public delegate GameDll.IBattle function_delegate155(System.Object arg0);
     public delegate System.Boolean function_delegate156(System.Object arg0,UnityEngine.Vector3 arg1,UnityEngine.Vector3 arg2,System.Boolean arg3);
     public delegate System.Int32 function_delegate157(System.Object arg0,System.Single arg1);
     public delegate System.Int32 function_delegate158(System.Object arg0,System.Single arg1,System.Single arg2);
     public delegate global::Main function_delegate159(System.Object arg0);
     public delegate UnityEngine.EventSystems.EventSystem function_delegate160(System.Object arg0);
     public delegate UnityEngine.UI.CanvasScaler function_delegate161(System.Object arg0);
     public delegate GameDll.IBattle function_delegate162(System.Object arg0,GameDll.BattleType arg1);
     public delegate void method_delegate163(System.Object arg0,GameDll.IBattle arg1);
     public delegate GameDll.BattleMessage function_delegate164(System.Object arg0);
     public delegate void method_delegate165(System.Object arg0,GameDll.BaseMessage arg1);
     public delegate void method_delegate166(System.Object arg0,GameDll.CGameProcedure arg1);
     public delegate GameDll.CGameProcedure function_delegate167(System.Object arg0);
     public delegate GameDll.RTInfo function_delegate168(System.Object arg0,System.Int32 arg1,System.Int32 arg2,System.Int32 arg3,UnityEngine.RenderTextureFormat arg4);
     public delegate void method_delegate169(System.Object arg0,UnityEngine.RenderTexture arg1);
     public delegate void method_delegate170(System.Object arg0,System.String arg1,System.String arg2,UnityEngine.Transform arg3,System.Action<System.Object> arg4);
    public static void Reg(CSHotFix.Runtime.Enviorment.AppDomain appDomain)
{ 
appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.Int32>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate0>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate0((arg0,arg1) =>
       {
       ((Action<System.Object,System.Int32>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.Boolean>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate1>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate1((arg0,arg1) =>
       {
       ((Action<System.Object,System.Boolean>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Boolean>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate2>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate2((arg0) =>
       {
       return ((Func<System.Object,System.Boolean>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate3>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate3((arg0) =>
       {
       ((Action<System.Object>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.String>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate4>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate4((arg0) =>
       {
       return ((Func<System.Object,System.String>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.String>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate5>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate5((arg0,arg1) =>
       {
       ((Action<System.Object,System.String>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<UnityEngine.GameObject>();

appDomain.DelegateManager.RegisterMethodDelegate<UnityEngine.GameObject,System.Boolean>();

appDomain.DelegateManager.RegisterMethodDelegate<UnityEngine.GameObject,System.Single>();

appDomain.DelegateManager.RegisterMethodDelegate<UnityEngine.GameObject,System.Int32>();

appDomain.DelegateManager.RegisterMethodDelegate<UnityEngine.GameObject,System.String>();

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Action<UnityEngine.GameObject>>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate6>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate6((arg0) =>
       {
       return ((Func<System.Object,System.Action<UnityEngine.GameObject>>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.Action<UnityEngine.GameObject>>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate7>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate7((arg0,arg1) =>
       {
       ((Action<System.Object,System.Action<UnityEngine.GameObject>>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Action<UnityEngine.GameObject, System.Boolean>>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate8>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate8((arg0) =>
       {
       return ((Func<System.Object,System.Action<UnityEngine.GameObject, System.Boolean>>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.Action<UnityEngine.GameObject, System.Boolean>>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate9>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate9((arg0,arg1) =>
       {
       ((Action<System.Object,System.Action<UnityEngine.GameObject, System.Boolean>>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Action<UnityEngine.GameObject, System.Single>>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate10>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate10((arg0) =>
       {
       return ((Func<System.Object,System.Action<UnityEngine.GameObject, System.Single>>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.Action<UnityEngine.GameObject, System.Single>>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate11>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate11((arg0,arg1) =>
       {
       ((Action<System.Object,System.Action<UnityEngine.GameObject, System.Single>>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Action<UnityEngine.GameObject, System.Int32>>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate12>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate12((arg0) =>
       {
       return ((Func<System.Object,System.Action<UnityEngine.GameObject, System.Int32>>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.Action<UnityEngine.GameObject, System.Int32>>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate13>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate13((arg0,arg1) =>
       {
       ((Action<System.Object,System.Action<UnityEngine.GameObject, System.Int32>>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Action<UnityEngine.GameObject, System.String>>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate14>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate14((arg0) =>
       {
       return ((Func<System.Object,System.Action<UnityEngine.GameObject, System.String>>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.Action<UnityEngine.GameObject, System.String>>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate15>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate15((arg0,arg1) =>
       {
       ((Action<System.Object,System.Action<UnityEngine.GameObject, System.String>>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Object>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate16>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate16((arg0) =>
       {
       return ((Func<System.Object,System.Object>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.Object>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate17>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate17((arg0,arg1) =>
       {
       ((Action<System.Object,System.Object>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.EventSystems.BaseEventData>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate18>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate18((arg0,arg1) =>
       {
       ((Action<System.Object,UnityEngine.EventSystems.BaseEventData>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.EventSystems.PointerEventData>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate19>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate19((arg0,arg1) =>
       {
       ((Action<System.Object,UnityEngine.EventSystems.PointerEventData>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.Component,UnityUI.UIEventType,System.Action<UnityEngine.GameObject>,System.Object>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate20>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate20((arg0,arg1,arg2,arg3,arg4) =>
       {
       ((Action<System.Object,UnityEngine.Component,UnityUI.UIEventType,System.Action<UnityEngine.GameObject>,System.Object>)act)(arg0,arg1,arg2,arg3,arg4);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.Component,UnityUI.UIEventType>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate21>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate21((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,UnityEngine.Component,UnityUI.UIEventType>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.Component,UnityUI.UIEventType,System.Action<UnityEngine.GameObject, System.Boolean>,System.Object>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate22>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate22((arg0,arg1,arg2,arg3,arg4) =>
       {
       ((Action<System.Object,UnityEngine.Component,UnityUI.UIEventType,System.Action<UnityEngine.GameObject, System.Boolean>,System.Object>)act)(arg0,arg1,arg2,arg3,arg4);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.Component,UnityUI.UIEventType,System.Action<UnityEngine.GameObject, System.Single>,System.Object>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate23>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate23((arg0,arg1,arg2,arg3,arg4) =>
       {
       ((Action<System.Object,UnityEngine.Component,UnityUI.UIEventType,System.Action<UnityEngine.GameObject, System.Single>,System.Object>)act)(arg0,arg1,arg2,arg3,arg4);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.Component,UnityUI.UIEventType,System.Action<UnityEngine.GameObject, System.Int32>,System.Object>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate24>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate24((arg0,arg1,arg2,arg3,arg4) =>
       {
       ((Action<System.Object,UnityEngine.Component,UnityUI.UIEventType,System.Action<UnityEngine.GameObject, System.Int32>,System.Object>)act)(arg0,arg1,arg2,arg3,arg4);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.Component,UnityUI.UIEventType,System.Action<UnityEngine.GameObject, System.String>,System.Object>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate25>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate25((arg0,arg1,arg2,arg3,arg4) =>
       {
       ((Action<System.Object,UnityEngine.Component,UnityUI.UIEventType,System.Action<UnityEngine.GameObject, System.String>,System.Object>)act)(arg0,arg1,arg2,arg3,arg4);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.Component,UnityUI.UIEventListener>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate26>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate26((arg0,arg1) =>
       {
       return ((Func<System.Object,UnityEngine.Component,UnityUI.UIEventListener>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.GameObject,UnityUI.UIEventListener>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate27>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate27((arg0,arg1) =>
       {
       return ((Func<System.Object,UnityEngine.GameObject,UnityUI.UIEventListener>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.Canvas>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate28>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate28((arg0) =>
       {
       return ((Func<System.Object,UnityEngine.Canvas>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.Camera>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate29>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate29((arg0) =>
       {
       return ((Func<System.Object,UnityEngine.Camera>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Int32,UnityEngine.Component>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate30>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate30((arg0,arg1) =>
       {
       return ((Func<System.Object,System.Int32,UnityEngine.Component>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Collections.Generic.List<UnityEngine.Component>>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate31>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate31((arg0) =>
       {
       return ((Func<System.Object,System.Collections.Generic.List<UnityEngine.Component>>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.String,System.String,System.String>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate32>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate32((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,System.String,System.String,System.String>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.Material,LCL.RenderingMode>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate33>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate33((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,UnityEngine.Material,LCL.RenderingMode>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<LCL.SetImageSpriteParam,UnityEngine.Sprite>();

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,LCL.SetImageSpriteParam,System.Int64>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate34>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate34((arg0,arg1) =>
       {
       return ((Func<System.Object,LCL.SetImageSpriteParam,System.Int64>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,LCL.ABObject>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate35>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate35((arg0,arg1) =>
       {
       ((Action<System.Object,LCL.ABObject>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.Int64>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate36>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate36((arg0,arg1) =>
       {
       ((Action<System.Object,System.Int64>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.Object,System.Int64>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate37>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate37((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,System.Object,System.Int64>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.String,UnityEngine.Sprite>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate38>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate38((arg0,arg1) =>
       {
       return ((Func<System.Object,System.String,UnityEngine.Sprite>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.UI.Image,System.String>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate39>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate39((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,UnityEngine.UI.Image,System.String>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.String,System.String>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate40>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate40((arg0,arg1) =>
       {
       return ((Func<System.Object,System.String,System.String>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.GameObject>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate41>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate41((arg0) =>
       {
       return ((Func<System.Object,UnityEngine.GameObject>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.Events.UnityEvent>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate42>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate42((arg0,arg1) =>
       {
       ((Action<System.Object,UnityEngine.Events.UnityEvent>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.GameObject>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate43>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate43((arg0,arg1) =>
       {
       ((Action<System.Object,UnityEngine.GameObject>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,LCL.SetImageSpriteParam,UnityEngine.Sprite>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate44>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate44((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,LCL.SetImageSpriteParam,UnityEngine.Sprite>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Collections.IEnumerator,UnityEngine.Coroutine>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate45>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate45((arg0,arg1) =>
       {
       return ((Func<System.Object,System.Collections.IEnumerator,UnityEngine.Coroutine>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Collections.IEnumerator[],System.Collections.IEnumerator>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate46>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate46((arg0,arg1) =>
       {
       return ((Func<System.Object,System.Collections.IEnumerator[],System.Collections.IEnumerator>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,LITJson.JsonData,System.Int32>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate47>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate47((arg0,arg1) =>
       {
       return ((Func<System.Object,LITJson.JsonData,System.Int32>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,LITJson.JsonData,System.Boolean>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate48>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate48((arg0,arg1) =>
       {
       return ((Func<System.Object,LITJson.JsonData,System.Boolean>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,LITJson.JsonData,System.Collections.Generic.ICollection<System.String>>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate49>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate49((arg0,arg1) =>
       {
       return ((Func<System.Object,LITJson.JsonData,System.Collections.Generic.ICollection<System.String>>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,LITJson.JsonData,System.String,System.Boolean>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate50>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate50((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,LITJson.JsonData,System.String,System.Boolean>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,LITJson.JsonData,System.String,LITJson.JsonData>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate51>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate51((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,LITJson.JsonData,System.String,LITJson.JsonData>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,LITJson.JsonData,System.Int32,LITJson.JsonData>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate52>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate52((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,LITJson.JsonData,System.Int32,LITJson.JsonData>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,LITJson.JsonData,System.Double>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate53>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate53((arg0,arg1) =>
       {
       return ((Func<System.Object,LITJson.JsonData,System.Double>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,LITJson.JsonData,System.String>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate54>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate54((arg0,arg1) =>
       {
       return ((Func<System.Object,LITJson.JsonData,System.String>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,LITJson.JsonData,System.Boolean>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate55>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate55((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,LITJson.JsonData,System.Boolean>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,LITJson.JsonData,System.Double>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate56>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate56((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,LITJson.JsonData,System.Double>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,LITJson.JsonData,System.String>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate57>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate57((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,LITJson.JsonData,System.String>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,LITJson.JsonData,System.Object,System.Int32>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate58>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate58((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,LITJson.JsonData,System.Object,System.Int32>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,LITJson.JsonData>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate59>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate59((arg0,arg1) =>
       {
       ((Action<System.Object,LITJson.JsonData>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,LITJson.JsonData,LITJson.JsonData,System.Boolean>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate60>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate60((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,LITJson.JsonData,LITJson.JsonData,System.Boolean>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,LITJson.JsonData,System.Object,System.Boolean>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate61>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate61((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,LITJson.JsonData,System.Object,System.Boolean>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,LITJson.JsonData,System.Int32>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate62>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate62((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,LITJson.JsonData,System.Int32>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,LITJson.JsonData,System.Single>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate63>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate63((arg0,arg1) =>
       {
       return ((Func<System.Object,LITJson.JsonData,System.Single>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,LITJson.JsonData,System.SByte>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate64>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate64((arg0,arg1) =>
       {
       return ((Func<System.Object,LITJson.JsonData,System.SByte>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,LITJson.JsonData,System.Byte>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate65>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate65((arg0,arg1) =>
       {
       return ((Func<System.Object,LITJson.JsonData,System.Byte>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,LITJson.JsonData,System.Int16>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate66>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate66((arg0,arg1) =>
       {
       return ((Func<System.Object,LITJson.JsonData,System.Int16>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,LITJson.JsonData,System.UInt16>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate67>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate67((arg0,arg1) =>
       {
       return ((Func<System.Object,LITJson.JsonData,System.UInt16>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,LITJson.JsonData,System.UInt32>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate68>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate68((arg0,arg1) =>
       {
       return ((Func<System.Object,LITJson.JsonData,System.UInt32>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Single>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate69>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate69((arg0) =>
       {
       return ((Func<System.Object,System.Single>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.Component,System.Type,UnityEngine.Component>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate70>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate70((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,UnityEngine.Component,System.Type,UnityEngine.Component>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.String,LITJson.JsonData>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate71>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate71((arg0,arg1) =>
       {
       return ((Func<System.Object,System.String,LITJson.JsonData>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.TextAsset,LITJson.JsonData>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate72>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate72((arg0,arg1) =>
       {
       return ((Func<System.Object,UnityEngine.TextAsset,LITJson.JsonData>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Int64>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate73>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate73((arg0) =>
       {
       return ((Func<System.Object,System.Int64>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Int64,System.DateTime>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate74>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate74((arg0,arg1) =>
       {
       return ((Func<System.Object,System.Int64,System.DateTime>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.DateTime,System.Int64>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate75>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate75((arg0,arg1) =>
       {
       return ((Func<System.Object,System.DateTime,System.Int64>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.GameObject,System.Boolean,System.String>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate76>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate76((arg0,arg1,arg2,arg3) =>
       {
       ((Action<System.Object,UnityEngine.GameObject,System.Boolean,System.String>)act)(arg0,arg1,arg2,arg3);
       });
   });

   appDomain.DelegateManager.RegisterDelegateConvertor<System.Action>((act) =>
   {
       return new System.Action(() =>
       {
       ((Action)act)();
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.Action>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate77>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate77((arg0,arg1) =>
       {
       ((Action<System.Object,System.Action>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<LCL.ABObject>();

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Type,System.String,System.String,System.Action<LCL.ABObject>,System.Int64>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate78>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate78((arg0,arg1,arg2,arg3,arg4) =>
       {
       return ((Func<System.Object,System.Type,System.String,System.String,System.Action<LCL.ABObject>,System.Int64>)act)(arg0,arg1,arg2,arg3,arg4);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Type,System.String,System.String,LCL.ABObject>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate79>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate79((arg0,arg1,arg2,arg3) =>
       {
       return ((Func<System.Object,System.Type,System.String,System.String,LCL.ABObject>)act)(arg0,arg1,arg2,arg3);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Type,System.String,System.String[],System.Action<LCL.ABObject>,System.Int64>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate80>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate80((arg0,arg1,arg2,arg3,arg4) =>
       {
       return ((Func<System.Object,System.Type,System.String,System.String[],System.Action<LCL.ABObject>,System.Int64>)act)(arg0,arg1,arg2,arg3,arg4);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Type,System.String,System.String[],LCL.ABObject>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate81>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate81((arg0,arg1,arg2,arg3) =>
       {
       return ((Func<System.Object,System.Type,System.String,System.String[],LCL.ABObject>)act)(arg0,arg1,arg2,arg3);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.String,System.String,System.Int32,System.Action,System.Int64>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate82>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate82((arg0,arg1,arg2,arg3,arg4) =>
       {
       return ((Func<System.Object,System.String,System.String,System.Int32,System.Action,System.Int64>)act)(arg0,arg1,arg2,arg3,arg4);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Byte[]>();

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.String,System.String,System.Action<System.Byte[]>>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate83>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate83((arg0,arg1,arg2,arg3) =>
       {
       ((Action<System.Object,System.String,System.String,System.Action<System.Byte[]>>)act)(arg0,arg1,arg2,arg3);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.String,System.Byte[]>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate84>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate84((arg0,arg1) =>
       {
       return ((Func<System.Object,System.String,System.Byte[]>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.Vector2>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate85>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate85((arg0) =>
       {
       return ((Func<System.Object,UnityEngine.Vector2>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.RectTransform,UnityEngine.Vector2,UnityEngine.Camera,System.Boolean>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate86>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate86((arg0,arg1,arg2,arg3) =>
       {
       return ((Func<System.Object,UnityEngine.RectTransform,UnityEngine.Vector2,UnityEngine.Camera,System.Boolean>)act)(arg0,arg1,arg2,arg3);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.Camera,UnityEngine.Vector3,UnityEngine.Vector2>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate87>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate87((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,UnityEngine.Camera,UnityEngine.Vector3,UnityEngine.Vector2>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.Camera,UnityEngine.Vector3,UnityEngine.Vector3>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate88>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate88((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,UnityEngine.Camera,UnityEngine.Vector3,UnityEngine.Vector3>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.Camera,UnityEngine.Vector3,UnityEngine.Ray>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate89>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate89((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,UnityEngine.Camera,UnityEngine.Vector3,UnityEngine.Ray>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.Transform,UnityEngine.Transform>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate90>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate90((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,UnityEngine.Transform,UnityEngine.Transform>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.RectTransform,UnityEngine.RectTransform>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate91>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate91((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,UnityEngine.RectTransform,UnityEngine.RectTransform>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.String,System.Boolean>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate92>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate92((arg0,arg1) =>
       {
       return ((Func<System.Object,System.String,System.Boolean>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Int32>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate93>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate93((arg0) =>
       {
       return ((Func<System.Object,System.Int32>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Byte[]>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate94>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate94((arg0) =>
       {
       return ((Func<System.Object,System.Byte[]>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Boolean>();

appDomain.DelegateManager.RegisterMethodDelegate<System.Int32>();

appDomain.DelegateManager.RegisterMethodDelegate<GameDll.IEventParam>();

appDomain.DelegateManager.RegisterMethodDelegate<System.Int32,System.Int32>();

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.Single>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate95>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate95((arg0,arg1) =>
       {
       ((Action<System.Object,System.Single>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.String,System.IO.StreamReader>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate96>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate96((arg0,arg1) =>
       {
       return ((Func<System.Object,System.String,System.IO.StreamReader>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Byte[],System.IO.StreamReader>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate97>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate97((arg0,arg1) =>
       {
       return ((Func<System.Object,System.Byte[],System.IO.StreamReader>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.RuntimePlatform,System.String>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate98>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate98((arg0,arg1) =>
       {
       return ((Func<System.Object,UnityEngine.RuntimePlatform,System.String>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,global::Setting>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate99>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate99((arg0) =>
       {
       return ((Func<System.Object,global::Setting>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.ThreadPriority>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate100>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate100((arg0,arg1) =>
       {
       ((Action<System.Object,UnityEngine.ThreadPriority>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.ThreadPriority>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate101>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate101((arg0) =>
       {
       return ((Func<System.Object,UnityEngine.ThreadPriority>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,GameDll.GMManager>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate102>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate102((arg0) =>
       {
       return ((Func<System.Object,GameDll.GMManager>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.Collections.Generic.List<System.String>>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate103>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate103((arg0,arg1) =>
       {
       ((Action<System.Object,System.Collections.Generic.List<System.String>>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.Vector3>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate104>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate104((arg0) =>
       {
       return ((Func<System.Object,UnityEngine.Vector3>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Single,System.Single,System.Int32,System.Boolean>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate105>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate105((arg0,arg1,arg2,arg3) =>
       {
       return ((Func<System.Object,System.Single,System.Single,System.Int32,System.Boolean>)act)(arg0,arg1,arg2,arg3);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.Ray>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate106>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate106((arg0,arg1) =>
       {
       ((Action<System.Object,UnityEngine.Ray>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.Vector3>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate107>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate107((arg0,arg1) =>
       {
       ((Action<System.Object,UnityEngine.Vector3>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.String,UnityEngine.Shader>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate108>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate108((arg0,arg1) =>
       {
       return ((Func<System.Object,System.String,UnityEngine.Shader>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,GameDll.Timer>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate109>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate109((arg0) =>
       {
       return ((Func<System.Object,GameDll.Timer>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,GameDll.Timer>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate110>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate110((arg0,arg1) =>
       {
       ((Action<System.Object,GameDll.Timer>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Int64,GameDll.Timer>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate111>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate111((arg0,arg1) =>
       {
       return ((Func<System.Object,System.Int64,GameDll.Timer>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.String,System.Int32>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate112>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate112((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,System.String,System.Int32>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.String,GameDll.VariableManager.GetValueIntParam>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate113>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate113((arg0,arg1) =>
       {
       return ((Func<System.Object,System.String,GameDll.VariableManager.GetValueIntParam>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.String,System.Single>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate114>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate114((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,System.String,System.Single>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.String,GameDll.VariableManager.GetValueFloatParam>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate115>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate115((arg0,arg1) =>
       {
       return ((Func<System.Object,System.String,GameDll.VariableManager.GetValueFloatParam>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.String,System.String>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate116>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate116((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,System.String,System.String>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.String,GameDll.VariableManager.GetValueStringParam>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate117>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate117((arg0,arg1) =>
       {
       return ((Func<System.Object,System.String,GameDll.VariableManager.GetValueStringParam>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Single>();

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Single,System.Single,System.Boolean>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate118>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate118((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,System.Single,System.Single,System.Boolean>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.IO.BinaryReader,UnityEngine.Vector3>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate119>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate119((arg0,arg1) =>
       {
       return ((Func<System.Object,System.IO.BinaryReader,UnityEngine.Vector3>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.IO.BinaryReader,UnityEngine.Quaternion>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate120>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate120((arg0,arg1) =>
       {
       return ((Func<System.Object,System.IO.BinaryReader,UnityEngine.Quaternion>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.GameObject,System.String>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate121>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate121((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,UnityEngine.GameObject,System.String>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Collections.Generic.List<System.Int32>,System.String,System.Char,System.Boolean>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate122>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate122((arg0,arg1,arg2,arg3) =>
       {
       return ((Func<System.Object,System.Collections.Generic.List<System.Int32>,System.String,System.Char,System.Boolean>)act)(arg0,arg1,arg2,arg3);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Collections.Generic.List<System.String>,System.String,System.Char,System.Boolean>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate123>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate123((arg0,arg1,arg2,arg3) =>
       {
       return ((Func<System.Object,System.Collections.Generic.List<System.String>,System.String,System.Char,System.Boolean>)act)(arg0,arg1,arg2,arg3);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.String,System.Char,UnityEngine.Vector3>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate124>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate124((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,System.String,System.Char,UnityEngine.Vector3>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.String,System.Char,System.Collections.Generic.List<System.Single>>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate125>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate125((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,System.String,System.Char,System.Collections.Generic.List<System.Single>>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.Vector3,UnityEngine.Vector3,System.Single>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate126>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate126((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,UnityEngine.Vector3,UnityEngine.Vector3,System.Single>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.Vector3,UnityEngine.Vector3,System.Single,System.Boolean>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate127>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate127((arg0,arg1,arg2,arg3) =>
       {
       return ((Func<System.Object,UnityEngine.Vector3,UnityEngine.Vector3,System.Single,System.Boolean>)act)(arg0,arg1,arg2,arg3);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.Boolean,System.String>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate128>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate128((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,System.Boolean,System.String>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,GameDll.Tool.bezieratParam,System.Single>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate129>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate129((arg0,arg1) =>
       {
       return ((Func<System.Object,GameDll.Tool.bezieratParam,System.Single>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.Vector3,UnityEngine.Vector2>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate130>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate130((arg0,arg1) =>
       {
       return ((Func<System.Object,UnityEngine.Vector3,UnityEngine.Vector2>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.Vector2,UnityEngine.Vector2>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate131>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate131((arg0,arg1) =>
       {
       return ((Func<System.Object,UnityEngine.Vector2,UnityEngine.Vector2>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Single,System.Single,System.Single,UnityEngine.Vector3>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate132>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate132((arg0,arg1,arg2,arg3) =>
       {
       return ((Func<System.Object,System.Single,System.Single,System.Single,UnityEngine.Vector3>)act)(arg0,arg1,arg2,arg3);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.Vector3,UnityEngine.Ray>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate133>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate133((arg0,arg1) =>
       {
       return ((Func<System.Object,UnityEngine.Vector3,UnityEngine.Ray>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.GameObject,System.Boolean>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate134>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate134((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,UnityEngine.GameObject,System.Boolean>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.GameObject,System.Single>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate135>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate135((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,UnityEngine.GameObject,System.Single>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.Transform,System.String,UnityEngine.Transform>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate136>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate136((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,UnityEngine.Transform,System.String,UnityEngine.Transform>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.GameObject,System.Single>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate137>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate137((arg0,arg1) =>
       {
       return ((Func<System.Object,UnityEngine.GameObject,System.Single>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.Vector3,System.Single,UnityEngine.Vector3,System.Single,System.Single>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate138>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate138((arg0,arg1,arg2,arg3,arg4) =>
       {
       return ((Func<System.Object,UnityEngine.Vector3,System.Single,UnityEngine.Vector3,System.Single,System.Single>)act)(arg0,arg1,arg2,arg3,arg4);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.Transform,System.String>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate139>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate139((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,UnityEngine.Transform,System.String>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.GameObject,UnityEngine.GameObject>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate140>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate140((arg0,arg1) =>
       {
       return ((Func<System.Object,UnityEngine.GameObject,UnityEngine.GameObject>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.GameObject,UnityEngine.GameObject,UnityEngine.GameObject>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate141>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate141((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,UnityEngine.GameObject,UnityEngine.GameObject,UnityEngine.GameObject>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.Transform>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate142>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate142((arg0,arg1) =>
       {
       ((Action<System.Object,UnityEngine.Transform>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.GameObject,UnityEngine.GameObject>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate143>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate143((arg0,arg1,arg2) =>
       {
       ((Action<System.Object,UnityEngine.GameObject,UnityEngine.GameObject>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.GameObject,System.String,UnityEngine.GameObject>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate144>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate144((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,UnityEngine.GameObject,System.String,UnityEngine.GameObject>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.GameObject,UnityEngine.GameObject,System.Boolean>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate145>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate145((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,UnityEngine.GameObject,UnityEngine.GameObject,System.Boolean>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.String,System.Object,System.Object>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate146>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate146((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,System.String,System.Object,System.Object>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Single,System.Single,System.Single,System.Single,System.Single>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate147>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate147((arg0,arg1,arg2,arg3,arg4) =>
       {
       return ((Func<System.Object,System.Single,System.Single,System.Single,System.Single,System.Single>)act)(arg0,arg1,arg2,arg3,arg4);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.Vector2,UnityEngine.Vector2,System.Single>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate148>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate148((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,UnityEngine.Vector2,UnityEngine.Vector2,System.Single>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Single,UnityEngine.Vector3>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate149>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate149((arg0,arg1) =>
       {
       return ((Func<System.Object,System.Single,UnityEngine.Vector3>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Vector3>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate150>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate150((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Vector3>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Single,System.Single,System.Single>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate151>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate151((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,System.Single,System.Single,System.Single>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.RectTransform,UnityEngine.Vector2,UnityEngine.Camera,UnityEngine.Vector2>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate152>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate152((arg0,arg1,arg2,arg3) =>
       {
       return ((Func<System.Object,UnityEngine.RectTransform,UnityEngine.Vector2,UnityEngine.Camera,UnityEngine.Vector2>)act)(arg0,arg1,arg2,arg3);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Int32,System.Single>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate153>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate153((arg0,arg1) =>
       {
       return ((Func<System.Object,System.Int32,System.Single>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.GameObject,System.Collections.Generic.List<LCL.KeyGameObject>>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate154>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate154((arg0,arg1) =>
       {
       return ((Func<System.Object,UnityEngine.GameObject,System.Collections.Generic.List<LCL.KeyGameObject>>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,GameDll.IBattle>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate155>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate155((arg0) =>
       {
       return ((Func<System.Object,GameDll.IBattle>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.Vector3,UnityEngine.Vector3,System.Boolean,System.Boolean>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate156>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate156((arg0,arg1,arg2,arg3) =>
       {
       return ((Func<System.Object,UnityEngine.Vector3,UnityEngine.Vector3,System.Boolean,System.Boolean>)act)(arg0,arg1,arg2,arg3);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Single,System.Int32>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate157>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate157((arg0,arg1) =>
       {
       return ((Func<System.Object,System.Single,System.Int32>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Single,System.Single,System.Int32>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate158>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate158((arg0,arg1,arg2) =>
       {
       return ((Func<System.Object,System.Single,System.Single,System.Int32>)act)(arg0,arg1,arg2);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,global::Main>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate159>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate159((arg0) =>
       {
       return ((Func<System.Object,global::Main>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.EventSystems.EventSystem>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate160>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate160((arg0) =>
       {
       return ((Func<System.Object,UnityEngine.EventSystems.EventSystem>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,UnityEngine.UI.CanvasScaler>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate161>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate161((arg0) =>
       {
       return ((Func<System.Object,UnityEngine.UI.CanvasScaler>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,GameDll.BattleType,GameDll.IBattle>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate162>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate162((arg0,arg1) =>
       {
       return ((Func<System.Object,GameDll.BattleType,GameDll.IBattle>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,GameDll.IBattle>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate163>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate163((arg0,arg1) =>
       {
       ((Action<System.Object,GameDll.IBattle>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,GameDll.BattleMessage>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate164>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate164((arg0) =>
       {
       return ((Func<System.Object,GameDll.BattleMessage>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,GameDll.BaseMessage>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate165>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate165((arg0,arg1) =>
       {
       ((Action<System.Object,GameDll.BaseMessage>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,GameDll.CGameProcedure>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate166>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate166((arg0,arg1) =>
       {
       ((Action<System.Object,GameDll.CGameProcedure>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,GameDll.CGameProcedure>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate167>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate167((arg0) =>
       {
       return ((Func<System.Object,GameDll.CGameProcedure>)act)(arg0);
       });
   });

appDomain.DelegateManager.RegisterFunctionDelegate<System.Object,System.Int32,System.Int32,System.Int32,UnityEngine.RenderTextureFormat,GameDll.RTInfo>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.function_delegate168>((act) =>
   {
       return new LCLFunctionDelegate.function_delegate168((arg0,arg1,arg2,arg3,arg4) =>
       {
       return ((Func<System.Object,System.Int32,System.Int32,System.Int32,UnityEngine.RenderTextureFormat,GameDll.RTInfo>)act)(arg0,arg1,arg2,arg3,arg4);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,UnityEngine.RenderTexture>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate169>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate169((arg0,arg1) =>
       {
       ((Action<System.Object,UnityEngine.RenderTexture>)act)(arg0,arg1);
       });
   });

appDomain.DelegateManager.RegisterMethodDelegate<System.Object>();

appDomain.DelegateManager.RegisterMethodDelegate<System.Object,System.String,System.String,UnityEngine.Transform,System.Action<System.Object>>();
   appDomain.DelegateManager.RegisterDelegateConvertor<LCLFunctionDelegate.method_delegate170>((act) =>
   {
       return new LCLFunctionDelegate.method_delegate170((arg0,arg1,arg2,arg3,arg4) =>
       {
       ((Action<System.Object,System.String,System.String,UnityEngine.Transform,System.Action<System.Object>>)act)(arg0,arg1,arg2,arg3,arg4);
       });
   });

}
}
#endif