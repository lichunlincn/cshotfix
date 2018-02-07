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
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;


public class CodeManager
{
    private static bool EnableDevelopment
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


    [MenuItem("CSHotFix/CodeManager/ChangeToDev", true, 1)]
    public static bool ValidateDevelopmentOption()
    {
        return !EnableDevelopment;
    }

    [MenuItem("CSHotFix/CodeManager/ChangeToDev", false, 1)]
    public static void ChangeToDevelopment()
    {
        var definesList = GetDefineSymbols();
        definesList.Remove("CSHotFix");

        string defineSymbols = string.Join(";", definesList.ToArray());
#if UNITY_IPHONE
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iPhone, defineSymbols);
#elif UNITY_ANDROID
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, defineSymbols);
#else
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone, defineSymbols);
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.WebPlayer, defineSymbols);
#endif
    }

    public static List<string> GetDefineSymbols()
    {
#if UNITY_IPHONE
        string symbolsDefines = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.iPhone);
#elif UNITY_ANDROID
        string symbolsDefines = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
#else
        string symbolsDefines = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone);
#endif
        return symbolsDefines.Split(';').ToList();
    }


    [MenuItem("CSHotFix/CodeManager/ChangeToRelease", true, 1)]
    public static bool ValidateHotfixOption()
    {
        return EnableDevelopment;
    }

    [MenuItem("CSHotFix/CodeManager/ChangeToRelease", false, 1)]
    public static void ChangeToCSHotFix()
    {
        var definesList = GetDefineSymbols();
        if (!definesList.Contains("CSHotFix"))
        {
            definesList.Add("CSHotFix");
        }


        string defineSymbols = string.Join(";", definesList.ToArray());
#if UNITY_IPHONE
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iPhone, defineSymbols);
#elif UNITY_ANDROID
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, defineSymbols);
#else
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone, defineSymbols);
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.WebPlayer, defineSymbols);
#endif
    }
}