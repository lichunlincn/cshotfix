using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

public class GenConfig
{
    public static List<Type> blackTypeList = new List<Type>()
    {

#if UNITY_EDITOR
            typeof(NavMeshTriangulation),
            typeof(UnityEngineInternal.Input.NativeGenericEvent),
            typeof(UnityEngine.ClusterInput),
            typeof(UnityEngine.EventProvider),
            typeof(UnityEngine.ClusterNetwork),
            typeof(UnityEngine.MovieTexture),
            typeof(UnityEngine.SamsungTV),
            typeof(UnityEngine.UI.GraphicRebuildTracker),

            typeof(UnityEngine.TerrainData),
            typeof(SphericalHarmonicsL2),


            typeof(UnityEngine.GUIStyleState),
            typeof(UnityEngine.Handheld),
            typeof(UnityEngine.Caching),
            typeof(UnityEngine.iPhoneUtils),



#endif

    };

    public static List<string> blackNamespaceList = new List<string>()
        {
            "UnityEngineInternal",
            "UnityEngine.VR",
            "UnityEngine.WSA",
            "UnityEngine.Windows",
            "UnityEngine.Apple",
            "UnityEngine.Collections",
            "UnityEngine.Tizen",
            "UnityEngine.iOS",
        };

    public static List< List<string> > SpecialBlackTypeList = new List<List<string>>()
    {
        new List<string>() { "Input", "IsJoystickPreconfigured" },
        new List<string>() { "UnityEngine.MonoBehaviour", "runInEditMode" },

        new List<string>(){"UnityEngine.UI.Graphic", "OnRebuildRequested"},
        new List<string>(){"UnityEngine.UI.Text", "OnRebuildRequested"},
        new List<string>(){"UnityEngine.WWW", "movie"},
#if UNITY_WEBGL
        new List<string>(){"UnityEngine.WWW", "threadPriority"},
#endif
        new List<string>(){"UnityEngine.Texture2D", "alphaIsTransparency"},
        new List<string>(){"UnityEngine.Security", "GetChainOfTrustValue"},
        new List<string>(){"UnityEngine.CanvasRenderer", "onRequestRebuild"},
        new List<string>(){"UnityEngine.Light", "areaSize"},
        new List<string>(){"UnityEngine.Light", "lightmapBakeType"},
        new List<string>(){ "UnityEngine.WWWAudioExtensions", "GetMovieTexture"},
        new List<string>(){ "UnityEngine.Terrain", "bakeLightProbesForTrees"},
        new List<string>(){ "UnityEngine.Terrain", "bakeLightProbesForTrees"},
        new List<string>(){ "UnityEngine.AnimatorControllerParameter", "name"},
#if !UNITY_WEBPLAYER
        new List<string>(){"UnityEngine.Application", "ExternalEval"},
#endif
        new List<string>(){"UnityEngine.GameObject", "networkView"},
        new List<string>(){"UnityEngine.Component", "networkView"},  
        new List<string>(){"System.IO.FileInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
        new List<string>(){"System.IO.FileInfo", "SetAccessControl", "System.Security.AccessControl.FileSecurity"},
        new List<string>(){"System.IO.DirectoryInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
        new List<string>(){"System.IO.DirectoryInfo", "SetAccessControl", "System.Security.AccessControl.DirectorySecurity"},
        new List<string>(){"System.IO.DirectoryInfo", "CreateSubdirectory", "System.String", "System.Security.AccessControl.DirectorySecurity"},
        new List<string>(){"System.IO.DirectoryInfo", "Create", "System.Security.AccessControl.DirectorySecurity"}
    };
}


