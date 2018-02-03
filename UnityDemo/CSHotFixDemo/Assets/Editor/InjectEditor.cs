using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using System.Diagnostics;
using System.IO;

public class InjectEditor : ScriptableObject
{
    [MenuItem("CSHotFix/HotfixGenDelegateAndStaticField", false, 2)]
    public static void HotfixGenDelegateAndStaticField()
    {
        if (EditorApplication.isCompiling || Application.isPlaying)
        {
            return;
        }
        string editorpath = Application.dataPath;
        editorpath = Path.GetFullPath(editorpath);
        editorpath = editorpath.Replace("UnityDemo\\CSHotFixDemo\\Assets", "");
        editorpath = Path.Combine(editorpath, "CSHotFixInjector\\bin\\Debug\\CSHotFixInjector.exe");
        Process InjectorEditorProcess = new Process();
        InjectorEditorProcess.StartInfo.FileName = editorpath;
        InjectorEditorProcess.StartInfo.Arguments = "HotfixGenDelegateAndStaticField";
        InjectorEditorProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
        InjectorEditorProcess.StartInfo.RedirectStandardOutput = true;
        InjectorEditorProcess.StartInfo.UseShellExecute = false;
        InjectorEditorProcess.StartInfo.CreateNoWindow = true;
        InjectorEditorProcess.Start();
        InjectorEditorProcess.WaitForExit();
        UnityEngine.Debug.Log(InjectorEditorProcess.StandardOutput.ReadToEnd());
        AssetDatabase.Refresh();
    }

    [PostProcessScene]
    [MenuItem("CSHotFix/InjectIL", false, 3)]
    public static void HotfixInject()
    {
        if (EditorApplication.isCompiling || Application.isPlaying)
        {
            return;
        }
        string editorpath = Application.dataPath;
        editorpath = Path.GetFullPath(editorpath);
        editorpath = editorpath.Replace("UnityDemo\\CSHotFixDemo\\Assets","");
        editorpath = Path.Combine(editorpath, "CSHotFixInjector\\bin\\Debug\\CSHotFixInjector.exe");
        Process InjectorEditorProcess = new Process();
        InjectorEditorProcess.StartInfo.FileName = editorpath;
        InjectorEditorProcess.StartInfo.Arguments = "InjectIL";
        InjectorEditorProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
        InjectorEditorProcess.StartInfo.RedirectStandardOutput = true;
        InjectorEditorProcess.StartInfo.UseShellExecute = false;
        InjectorEditorProcess.StartInfo.CreateNoWindow = true;
        InjectorEditorProcess.Start();
        InjectorEditorProcess.WaitForExit();
        UnityEngine.Debug.Log(InjectorEditorProcess.StandardOutput.ReadToEnd());
        AssetDatabase.Refresh();
    }
}