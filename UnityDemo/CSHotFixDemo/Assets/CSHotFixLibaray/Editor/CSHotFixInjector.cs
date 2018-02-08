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
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using System.Diagnostics;
using System.IO;

public class InjectEditor : ScriptableObject
{
    [MenuItem("CSHotFix/GenHotFixDelegate", false, 1)]
    public static void HotfixGenDelegate()
    {
        if (EditorApplication.isCompiling || Application.isPlaying)
        {
            return;
        }
        if (!EditorUtility.DisplayDialog("警告", "你是否需要重新生成热更新委托信息？", "需要", "按错了"))
        {
            return;
        }

        LCL.Injector.RunGen("GenDelegate");
        AssetDatabase.Refresh();
    }
    [MenuItem("CSHotFix/GenHotFixField", false, 2)]
    public static void HotfixGenStaticField()
    {
        if (EditorApplication.isCompiling || Application.isPlaying)
        {
            return;
        }
        if (!EditorUtility.DisplayDialog("警告", "你是否需要重新生成热更新字段信息？", "需要", "按错了"))
        {
            return;
        }
        LCL.Injector.RunGen("GenStaticField");
        AssetDatabase.Refresh();
    }

    [PostProcessScene]
    [MenuItem("CSHotFix/GenHotFix", false, 3)]
    public static void HotfixInject()
    {
        if (EditorApplication.isCompiling || Application.isPlaying)
        {
            return;
        }
        LCL.Injector.RunGen("InjectIL");
        AssetDatabase.Refresh();
    }
}