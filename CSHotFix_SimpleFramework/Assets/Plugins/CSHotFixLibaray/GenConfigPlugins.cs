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
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

public class GenConfigPlugins
{
    //适配器的完整类型字符串，命名空间在内的
    public static List<string> adapterGenList = new List<string>()
    {
        "IGameHotFixInterface",
        //"ISerializePacket",
        //"PooledClassObject"
    };

    //和系统相关的
    public static List<Type> whiteTypeList = new List<Type>()
    {
        typeof(System.String),
        typeof(System.Text.StringBuilder),
        typeof(System.Enum),
        typeof(System.Object),
        typeof(System.Type),
        typeof(System.Guid),
        typeof(System.IDisposable),
        typeof(System.IO.Path),
        typeof(System.Convert),
        typeof(System.Array),
        typeof(System.Int32),
        typeof(System.UInt32),
        typeof(System.UInt16),
        typeof(System.Boolean),
        typeof(System.Collections.IEnumerator),
        typeof(System.Activator),
        typeof(List<System.Action>),

    };
    public static List<Type> blackTypeList = new List<Type>()
    {

#if UNITY_EDITOR
            typeof(NavMeshTriangulation),

            typeof(TextureCompressionQuality),
            
            typeof(UnityEngine.iOS.ActivityIndicatorStyle),
            typeof(Physics),
            typeof(Physics2D),
            typeof(PhysicsUpdateBehaviour2D),
            typeof(PhysicMaterialCombine),
            typeof(PhysicMaterial),
            typeof(PhysicsMaterial2D),
            typeof(ParticlePhysicsExtensions),

            typeof(GUI),
            typeof(GUIContent),
            typeof(GUIElement),
            typeof(GUILayer),
            typeof(GUILayoutOption),
            typeof(GUILayoutUtility),
            typeof(GUISettings),
            typeof(GUISkin),
            typeof(GUIStyle),
            typeof(GUIStyleState),
            typeof(GUITargetAttribute),
            typeof(GUIText),
            typeof(GUITexture),
            typeof(GUIUtility),

            typeof(Graphics),

            typeof(Animator),

            typeof(Rigidbody),
            typeof(Rigidbody2D),
            typeof(RigidbodyConstraints),
            typeof(RigidbodyConstraints2D),
            typeof(RigidbodyInterpolation),
            typeof(RigidbodyInterpolation2D),
            typeof(RigidbodySleepMode2D),
            typeof(RigidbodyType2D),

            typeof(Terrain),
            typeof(TerrainChangedFlags),
            typeof(TerrainCollider),
            typeof(TerrainData),
            typeof(TerrainExtensions),
            typeof(TerrainRenderFlags),

#if UNITY_STANDALONE
            typeof(UnityEngine.FullScreenMovieControlMode),
            typeof(UnityEngine.FullScreenMovieScalingMode),
            typeof(UnityEngine.AndroidActivityIndicatorStyle),
            typeof(UnityEngine.AndroidInput),
            typeof(UnityEngine.AndroidJavaClass),
            typeof(UnityEngine.AndroidJavaException),
            typeof(UnityEngine.AndroidJavaObject),
            typeof(UnityEngine.AndroidJavaProxy),
            typeof(UnityEngine.AndroidJavaRunnable),
            typeof(UnityEngine.AndroidJNI),
            typeof(UnityEngine.AndroidJNIHelper),
            typeof(UnityEngine.TouchScreenKeyboard),
            typeof(UnityEngine.TouchScreenKeyboardType),
            typeof(iPhoneSettings),
#elif UNITY_ANDROID || UNITY_IOS
            typeof(UnityEngine.FullScreenMovieControlMode),
            typeof(UnityEngine.FullScreenMovieScalingMode),
            typeof(UnityEngine.AndroidActivityIndicatorStyle),
            typeof(UnityEngine.AndroidInput),
            typeof(UnityEngine.AndroidJavaClass),
            typeof(UnityEngine.AndroidJavaException),
            typeof(UnityEngine.AndroidJavaObject),
            typeof(UnityEngine.AndroidJavaProxy),
            typeof(UnityEngine.AndroidJavaRunnable),
            typeof(UnityEngine.AndroidJNI),
            typeof(UnityEngine.AndroidJNIHelper),
            typeof(UnityEngine.TouchScreenKeyboard),
            typeof(UnityEngine.TouchScreenKeyboardType),
            typeof(iPhoneSettings),
            typeof(UnityEngine.MovieTexture),

#if !UNITY_2018 && !UNITY_2019
            typeof(Unity.Collections.LowLevel.Unsafe.UnsafeUtility),                        
            typeof(UnityEngine.ClusterNetwork),
            typeof(UnityEngine.ClusterInput),
            typeof(UnityEngine.ClusterInputType),
#endif


#endif
            typeof(UnityEngine.EventProvider),
            typeof(UnityEngine.MovieTexture),


#if UNITY_2017 || UNITY_2018 || UNITY_2019 
        typeof(UnityEngine.Playables.PlayableBehaviour),

#else
            typeof(UnityEngine.SamsungTV),                        
            typeof(ConstructorSafeAttribute), 

            typeof(ThreadSafeAttribute),
#endif
            //typeof(UnityEngine.UI.GraphicRebuildTracker),

            typeof(UnityEngine.TerrainData),
            typeof(SphericalHarmonicsL2),


            typeof(UnityEngine.GUIStyleState),
            typeof(UnityEngine.Handheld),
            typeof(UnityEngine.Caching),
            typeof(UnityEngine.iPhoneUtils),

            typeof(UnityEngine.DrivenRectTransformTracker),
            typeof(LightProbeGroup),
            typeof(Light),
            typeof(QualitySettings),
            typeof(TextureFormat),
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
            "UnityEngine.Experimental",
            "UnityEngine.Networking",
            "UnityEngine.AI",
            "UnityEngine.Rendering",
            "UnityEngine.Internal.VR",
            "Unity.Collections.LowLevel.Unsafe",
            "UnityEngine.tvOS",
            "UnityEngine.Playables",
            "Unity.IO.LowLevel.Unsafe"
        };

    public static List< List<string> > SpecialBlackTypeList = new List<List<string>>()
    {
        new List<string>() { "LCL.PrefabLightmapData", "SaveLightmap" },
        new List<string>() { "Input", "IsJoystickPreconfigured" },
        new List<string>() { "UnityEngine.MonoBehaviour", "runInEditMode" },
        new List<string>() { "UnityEngine.AudioSettings", "GetSpatializerPluginName" },
        new List<string>() { "UnityEngine.AudioSettings", "GetSpatializerPluginNames" },
        new List<string>() { "UnityEngine.AudioSettings", "SetSpatializerPluginName" },
        new List<string>(){"UnityEngine.UI.Graphic", "OnRebuildRequested"},
        new List<string>(){"UnityEngine.UI.Text", "OnRebuildRequested"},
        new List<string>(){"UnityEngine.WWW", "movie"},
        new List<string>(){ "UnityEngine.Texture", "imageContentsHash"},
        new List<string>(){ "System.Type", "IsSZArray" },
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
