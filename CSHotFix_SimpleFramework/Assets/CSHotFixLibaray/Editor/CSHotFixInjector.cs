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
    [MenuItem("CSHotFix/单步操作/生成注入委托", false, 1)]
    public static void HotfixGenDelegate()
    {
        if (EditorApplication.isCompiling || Application.isPlaying)
        {
            EditorUtility.DisplayDialog("警告", "你当前处于编译或者运行中，请等待编译完成或者停止运行", "了解");
            return;
        }
        //if (!EditorUtility.DisplayDialog("警告", "你是否需要重新生成热更新委托信息？", "需要", "按错了"))
        //{
        //    return;
        //}
        watch.Reset();
        watch.Start();
        LCL.Injector.RunGen("GenDelegate");
        UnityEngine.Debug.Log("GenDelegate time:" + watch.ElapsedMilliseconds+" ms");
        AssetDatabase.Refresh();
    }
    [MenuItem("CSHotFix/单步操作/生成注入字段", false, 2)]
    public static void HotfixGenStaticField()
    {
        if (EditorApplication.isCompiling || Application.isPlaying)
        {
            EditorUtility.DisplayDialog("警告", "你当前处于编译或者运行中，请等待编译完成或者停止运行", "了解");
            return;
        }
        //if (!EditorUtility.DisplayDialog("警告", "你是否需要重新生成热更新字段信息？", "需要", "按错了"))
        //{
        //    return;
        //}
        watch.Reset();
        watch.Start();
        LCL.Injector.RunGen("GenStaticField");
        UnityEngine.Debug.Log("GenStaticField time:" + watch.ElapsedMilliseconds+" ms");
        AssetDatabase.Refresh();
    }

    [PostProcessScene]
    [MenuItem("CSHotFix/单步操作/注入代码", false, 3)]
    public static void HotfixInject()
    {
        if (EditorApplication.isCompiling || Application.isPlaying)
        {
            //EditorUtility.DisplayDialog("警告", "你当前处于编译或者运行中，请等待编译完成或者停止运行", "了解");
            UnityEngine.Debug.LogWarning("编辑器正在运行或者编译");
            return;
        }
        if(!GenConfigEditor.NeedInject)
        {
            UnityEngine.Debug.LogWarning("编辑器设置为不需要注入，所以这里没有注入");
            return;
        }
        watch.Reset();
        watch.Start();
        LCL.Injector.RunGen("InjectIL");
        UnityEngine.Debug.Log("InjectIL time:" + watch.ElapsedMilliseconds+" ms");
        AssetDatabase.Refresh();

        string src = Path.GetFullPath(GenConfigEditor.CSHotFixMonoDllPath);
        if(File.Exists(src))
        {
            string dest = Path.GetFullPath(GenConfigEditor.CSHotFixMonoDll2019Path);
            if(File.Exists(dest))
            {
                File.Copy(src, dest, true);
                UnityEngine.Debug.Log("复制" + src + " 到" + dest);
            }
        }
    }

    [MenuItem("CSHotFix/单步操作/清理注入委托和字段", false, 2)]
    public static void ClearDelegateField()
    {
        //清理注入委托和字段
        {
            string copyFile = Path.GetFullPath(GenConfigEditor.CSHotFixDelegateGenPath + "/LCLFunctionDelegate.cs_");
            string destFile = Path.GetFullPath(GenConfigEditor.CSHotFixDelegateGenPath + "/LCLFunctionDelegate.cs");
            if (File.Exists(copyFile))
            {
                File.Copy(copyFile, destFile, true);
                UnityEngine.Debug.Log("清理委托完成,请等待编译通过");
                AssetDatabase.Refresh();
            }
            else
            {
                UnityEngine.Debug.LogError("文件没有找到：" + copyFile);
            }
        }

        {
            string copyFile = Path.GetFullPath(GenConfigEditor.CSHotFixDelegateGenPath + "/LCLFieldDelegateName.cs_");
            string destFile = Path.GetFullPath(GenConfigEditor.CSHotFixDelegateGenPath + "/LCLFieldDelegateName.cs");
            if (File.Exists(copyFile))
            {
                File.Copy(copyFile, destFile, true);
                UnityEngine.Debug.Log("清理注入字段完成,请等待编译通过");
                AssetDatabase.Refresh();
            }
            else
            {
                UnityEngine.Debug.LogError("文件没有找到：" + copyFile);
            }
        }
    }

    [MenuItem("CSHotFix/单步操作/清理注入代码", false, 4)]
    public static void RemoveHotfixInject()
    {
        ClearDelegateField();
        AssetDatabase.ImportAsset(GenConfigEditor.CSHotFixReCompileFile);
        AssetDatabase.Refresh();
    }



}