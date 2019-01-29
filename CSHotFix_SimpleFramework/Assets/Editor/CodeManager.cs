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
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

[InitializeOnLoad]
public class CodeManager
{
    static CodeManager()
    {
#if CSHotFix
        Debug.Log("Test CSHotFix File Gen Start");
        var definesList = GetDefineSymbols();
        bool ok1 = File.Exists("Assets/CSHotFixLibaray/Generated/CLRGen2/CLRBindings2.cs");
        if(!ok1)
        {
            Debug.LogError("Assets/CSHotFixLibaray/Generated/CLRGen2/CLRBindings2.cs 丢失");
        }
        bool ok2= File.Exists("Assets/CSHotFixLibaray/Generated/AdapterGen/AdapterRegister.cs");
        if(!ok2)
        {
            Debug.LogError("Assets/CSHotFixLibaray/Generated/AdapterGen/AdapterRegister.cs 丢失");
        }
        bool ok3 = File.Exists("Assets/CSHotFixLibaray/Generated/DelegateGen/LCLFunctionDelegate.cs");
        if(!ok3)
        {
            Debug.LogError("Assets/CSHotFixLibaray/Generated/DelegateGen/LCLFunctionDelegate.cs 丢失");
        }
        if (!(ok1 && ok2 && ok3))
        {
            Debug.LogError("你设置为发布版，但是还没有生成绑定代码，系统自动切换到发布版的安全模式，否则无法通过编译");

            if (!definesList.Contains("CSHotFixSafe"))
            {
                definesList.Add("CSHotFixSafe");
            }
        }
        else
        {
            if (definesList.Contains("CSHotFixSafe"))
            {
                definesList.Remove("CSHotFixSafe");
            }
            Debug.Log("CSHotFix File Gen OK");
        }
        ChangeDefineSymbol(definesList);
        Debug.Log("Test CSHotFix File Gen End");
#endif
    }
    public static bool EnableDevelopment
    {
        get
        {
#if CSHotFix
            return false;
#else
            return true;
#endif
        }
    }


    [MenuItem("CSHotFix/模式切换/开发模式", true, 1)]
    public static bool ValidateDevelopmentOption()
    {
        return !EnableDevelopment;
    }

    [MenuItem("CSHotFix/模式切换/开发模式", false, 1)]
    public static void ChangeToDevelopment()
    {
        var definesList = GetDefineSymbols();
        definesList.Remove("CSHotFix");

        ChangeDefineSymbol(definesList);
    }

    public static List<string> GetDefineSymbols()
    {
#if UNITY_IPHONE
        string symbolsDefines = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.iOS);
#elif UNITY_ANDROID
        string symbolsDefines = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
#else
        string symbolsDefines = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone);
#endif
        return symbolsDefines.Split(';').ToList();
    }


    [MenuItem("CSHotFix/模式切换/发布模式", true, 1)]
    public static bool ValidateHotfixOption()
    {
        return EnableDevelopment;
    }

    [MenuItem("CSHotFix/模式切换/发布模式", false, 1)]
    public static void ChangeToCSHotFix()
    {
        var definesList = GetDefineSymbols();
        if (!definesList.Contains("CSHotFix"))
        {
            definesList.Add("CSHotFix");
        }
        ChangeDefineSymbol(definesList);
    }
    private static void ChangeDefineSymbol(List<string> definesList)
    {
        string defineSymbols = string.Join(";", definesList.ToArray());
#if UNITY_IPHONE
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iOS, defineSymbols);
#elif UNITY_ANDROID
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, defineSymbols);
#else
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone, defineSymbols);
#endif
    }

    [MenuItem("CSHotFix/一键生成", false, 2)]
    public static void OneKeyGen()
    {
        PlayerPrefs.SetInt("CodeManager_OneKeyGen_Step", 0);
        var definesList = GetDefineSymbols();
        definesList.Remove("CSHotFix");
        ChangeDefineSymbol(definesList);
        InjectEditor.RemoveHotfixInject();
    }
    //处理一键生成注入、导出需要的东西
    [UnityEditor.Callbacks.DidReloadScripts]
    public static void OnScriptsReloaded()
    {
        int step = PlayerPrefs.GetInt("CodeManager_OneKeyGen_Step", -1);
        if (  step< 0)
        {
            return;
        }

        if (step == 1)
        {
            try
            {
                InjectEditor.HotfixGenDelegate();
                step++;
                PlayerPrefs.SetInt("CodeManager_OneKeyGen_Step", step);
                var definesList = GetDefineSymbols();
                if (definesList.Contains("CSHotFix") == false)
                {
                    definesList.Add("CSHotFix");
                    ChangeDefineSymbol(definesList);
                }
            }
            catch(System.Exception e)
            {
                step = -1;
                PlayerPrefs.SetInt("CodeManager_OneKeyGen_Step", step);
                Debug.LogError("一键生成注入导出失败，" + e.Message);
            }
        }
        else if(step == 2)
        {
            try
            {
                InjectEditor.HotfixGenStaticField();
                step++;
                PlayerPrefs.SetInt("CodeManager_OneKeyGen_Step", step);
            }
            catch (System.Exception e)
            {
                step = -1;
                PlayerPrefs.SetInt("CodeManager_OneKeyGen_Step", step);
                Debug.LogError("一键生成注入导出失败，" + e.Message);
            }
        }
        else if(step == 0)
        {
            try
            {
                CSHotFixCLRBinding.GenerateCLRBinding1a();
                CSHotFixCLRBinding.GenerateCLRBinding1b();

                step++;
                PlayerPrefs.SetInt("CodeManager_OneKeyGen_Step", step);
            }
            catch (System.Exception e)
            {
                step = -1;
                PlayerPrefs.SetInt("CodeManager_OneKeyGen_Step", step);
                Debug.LogError("一键生成注入导出失败，" + e.Message);
            }
        }
        else if (step == 3)
        {
            try
            {
                CSHotFixCLRBinding.GenerateCLRBinding2a();
                step++;
                PlayerPrefs.SetInt("CodeManager_OneKeyGen_Step", step);
                //让代码强制编译一次
                AssetDatabase.ImportAsset(GenConfigEditor.CSHotFixReCompileFile);
                AssetDatabase.Refresh();

            }
            catch (System.Exception e)
            {
                step = -1;
                PlayerPrefs.SetInt("CodeManager_OneKeyGen_Step", step);
                Debug.LogError("一键生成注入导出失败，" + e.Message);
            }
        }
        else if(step == 4)
        {
            try
            {
                CSHotFixCLRBinding.GenerateCLRBinding2b();
                step++;
                PlayerPrefs.SetInt("CodeManager_OneKeyGen_Step", step);

            }
            catch (System.Exception e)
            {
                step = -1;
                PlayerPrefs.SetInt("CodeManager_OneKeyGen_Step", step);
                Debug.LogError("一键生成注入导出失败，" + e.Message);
            }
        }
        else if(step == 5)
        {
            Debug.Log("一键生成注入导出成功");
            step = -1;
            PlayerPrefs.SetInt("CodeManager_OneKeyGen_Step", step);
        }

    }


}