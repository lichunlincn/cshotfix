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
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using System.Diagnostics;
using System.IO;

public class InjectEditor : ScriptableObject
{
    static Stopwatch watch= new Stopwatch();
    [MenuItem("CSHotFix/GenHotFixDelegate", false, 1)]
    public static void HotfixGenDelegate()
    {
        if (EditorApplication.isCompiling || Application.isPlaying)
        {
            EditorUtility.DisplayDialog("警告", "你当前处于编译或者运行中，请等待编译完成或者停止运行", "了解");
            return;
        }
        if (!EditorUtility.DisplayDialog("警告", "你是否需要重新生成热更新委托信息？", "需要", "按错了"))
        {
            return;
        }
        watch.Reset();
        watch.Start();
        LCL.Injector.RunGen("GenDelegate");
        UnityEngine.Debug.Log("GenDelegate time:" + watch.ElapsedMilliseconds+" ms");
        AssetDatabase.Refresh();
    }
    [MenuItem("CSHotFix/GenHotFixField", false, 2)]
    public static void HotfixGenStaticField()
    {
        if (EditorApplication.isCompiling || Application.isPlaying)
        {
            EditorUtility.DisplayDialog("警告", "你当前处于编译或者运行中，请等待编译完成或者停止运行", "了解");
            return;
        }
        if (!EditorUtility.DisplayDialog("警告", "你是否需要重新生成热更新字段信息？", "需要", "按错了"))
        {
            return;
        }
        watch.Reset();
        watch.Start();
        LCL.Injector.RunGen("GenStaticField");
        UnityEngine.Debug.Log("GenStaticField time:" + watch.ElapsedMilliseconds+" ms");
        AssetDatabase.Refresh();
    }

    [PostProcessScene]
    [MenuItem("CSHotFix/GenHotFix", false, 3)]
    public static void HotfixInject()
    {
        if (EditorApplication.isCompiling || Application.isPlaying)
        {
            //EditorUtility.DisplayDialog("警告", "你当前处于编译或者运行中，请等待编译完成或者停止运行", "了解");
            return;
        }
#if CSHotFixSafe
        if(EditorUtility.DisplayDialog("错误", "当前处于发布版的安全模式，该模式使用于生成绑定代码的", "了解"))
        {
            UnityEngine.Debug.LogError("注入失败！当前处于发布版的安全模式，该模式使用于生成绑定代码的");
            return;
        }
#endif
        watch.Reset();
        watch.Start();
        LCL.Injector.RunGen("InjectIL");
        UnityEngine.Debug.Log("InjectIL time:" + watch.ElapsedMilliseconds+" ms");
        AssetDatabase.Refresh();
    }
    [MenuItem("CSHotFix/ReCompileCode", false, 4)]
    public static void RemoveHotfixInject()
    {
        AssetDatabase.ImportAsset("Assets/com.chunlinge.app/Local/Classes/Main.cs");
        AssetDatabase.Refresh();
    }



}