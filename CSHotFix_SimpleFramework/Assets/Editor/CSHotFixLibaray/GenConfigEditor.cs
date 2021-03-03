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
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

/// <summary>
/// 配置一些没有在命名空间内的必须要导出的类型
/// </summary>
public class GenConfigEditor
{

    public static List<Type> ExportTypeList = new List<Type>()
    {
        //typeof(WfPacket),
        typeof(ISerializePacket),
        typeof(ClassPrivateTool),
        typeof(PooledClassObject),
        typeof(MyExtensionMethods),
        typeof(ActionRewrite),
        typeof(Setting),

        typeof(MaskEx),
        //typeof(UIInterface),

    };

    //手动导出值类型类
    public static List<Type> valueTypeList = new List<Type>()
    {
        typeof(Vector3),
        typeof(Vector2),
        typeof(Quaternion),
        typeof(Ray),
        typeof(RaycastHit),
    };

    //一些没有在命名空间，需要注入和导出委托的类
    public static List<Type> whiteTypeList = new List<Type>()
    {

    };
    public static List<string> whiteNameSpaceList = new List<string>()
    {
        "LCL",
        "GameDll",
        "UnityUI"
    };

    public static List<string> whiteAssemblyList = new List<string>()
    {
        "UnityEngine",
        "UnityEngine.UI",
        "UnityEngine.CoreModule",
        "UnityEngine.UIModule"
    };
    public static List<string> whiteUserAssemblyList = new List<string>()
    {
        "Assembly-CSharp",

    };

    public static string CSHotFixCLRGen1Path = "Assets/CSHotFixLibaray/Generated/CLRGen1";
    public static string CSHotFixCLRGen2Path = "Assets/CSHotFixLibaray/Generated/CLRGen2";
    public static string CSHotFixAdapterGenPath = "Assets/CSHotFixLibaray/Generated/AdapterGen/";
    public static string CSHotFixDelegateGenPath = "Assets/CSHotFixLibaray/Generated/DelegateGen";
    public static string CSHotFixDllPath = "Assets/Art/Out/GameDll/HotFix.dll.bytes";
    public static string CSHotFixReCompileFile = "Assets/Scripts/Local/Classes/Main.cs";
    public static string CSHotFixMonoDll2019Path = "Library/PlayerScriptAssemblies/Assembly-CSharp.dll";
    public static string CSHotFixMonoDllPath = "Library/ScriptAssemblies/Assembly-CSharp.dll";

    public static string[] CSHotFixMonoDepDllPathes = 
    {
        //相对于Assets的路径
        Path.GetFullPath("./Library/UnityAssemblies"),
		Path.GetFullPath("./UnityEngineLibaray"),

    };
    public static bool   NeedInject
    {
        get
        {
            return !CodeManager.EnableDevelopment;
        }
    }
}


