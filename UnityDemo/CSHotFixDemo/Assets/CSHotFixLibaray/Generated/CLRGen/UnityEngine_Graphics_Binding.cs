using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using CSHotFix.CLR.TypeSystem;
using CSHotFix.CLR.Method;
using CSHotFix.Runtime.Enviorment;
using CSHotFix.Runtime.Intepreter;
using CSHotFix.Runtime.Stack;
using CSHotFix.Reflection;
using CSHotFix.CLR.Utils;

namespace CSHotFix.Runtime.Generated
{
    unsafe class UnityEngine_Graphics_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Graphics);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_0);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Boolean)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_1);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_2);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_3);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_4);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_5);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_6);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(UnityEngine.Transform)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_7);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_8);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_9);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(UnityEngine.Transform), typeof(System.Boolean)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_10);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_11);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Boolean)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_12);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_13);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_14);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_15);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_16);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_17);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(UnityEngine.Transform)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_18);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_19);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_20);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(UnityEngine.Transform), typeof(System.Boolean)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_21);
            args = new Type[]{typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("DrawProcedural", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProcedural_22);
            args = new Type[]{typeof(UnityEngine.MeshTopology), typeof(System.Int32)};
            method = type.GetMethod("DrawProcedural", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProcedural_23);
            args = new Type[]{typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32)};
            method = type.GetMethod("DrawProceduralIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProceduralIndirect_24);
            args = new Type[]{typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer)};
            method = type.GetMethod("DrawProceduralIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProceduralIndirect_25);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4[]), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_26);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4[]), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_27);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4[]), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_28);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4[]), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_29);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4[]), typeof(System.Int32)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_30);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4[])};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_31);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4[]), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32), typeof(UnityEngine.Camera)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_32);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_33);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_34);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_35);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>), typeof(UnityEngine.MaterialPropertyBlock)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_36);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_37);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32), typeof(UnityEngine.Camera)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_38);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Bounds), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32)};
            method = type.GetMethod("DrawMeshInstancedIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstancedIndirect_39);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Bounds), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean)};
            method = type.GetMethod("DrawMeshInstancedIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstancedIndirect_40);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Bounds), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode)};
            method = type.GetMethod("DrawMeshInstancedIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstancedIndirect_41);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Bounds), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock)};
            method = type.GetMethod("DrawMeshInstancedIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstancedIndirect_42);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Bounds), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32)};
            method = type.GetMethod("DrawMeshInstancedIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstancedIndirect_43);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Bounds), typeof(UnityEngine.ComputeBuffer)};
            method = type.GetMethod("DrawMeshInstancedIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstancedIndirect_44);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Bounds), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32), typeof(UnityEngine.Camera)};
            method = type.GetMethod("DrawMeshInstancedIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstancedIndirect_45);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.Material)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_46);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_47);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_48);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Material)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_49);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_50);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_51);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Material)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_52);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_53);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_54);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color), typeof(UnityEngine.Material)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_55);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_56);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color), typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_57);
            args = new Type[]{typeof(UnityEngine.Rendering.CommandBuffer)};
            method = type.GetMethod("ExecuteCommandBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ExecuteCommandBuffer_58);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.RenderTexture)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_59);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Material)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_60);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_61);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.Material)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_62);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_63);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Material), typeof(UnityEngine.Vector2[])};
            method = type.GetMethod("BlitMultiTap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BlitMultiTap_64);
            args = new Type[]{};
            method = type.GetMethod("get_activeColorBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_activeColorBuffer_65);
            args = new Type[]{};
            method = type.GetMethod("get_activeDepthBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_activeDepthBuffer_66);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.RenderTexture)};
            method = type.GetMethod("SetRandomWriteTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRandomWriteTarget_67);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.ComputeBuffer)};
            method = type.GetMethod("SetRandomWriteTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRandomWriteTarget_68);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Boolean)};
            method = type.GetMethod("SetRandomWriteTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRandomWriteTarget_69);
            args = new Type[]{};
            method = type.GetMethod("ClearRandomWriteTargets", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearRandomWriteTargets_70);
            args = new Type[]{};
            method = type.GetMethod("get_activeTier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_activeTier_71);
            args = new Type[]{typeof(UnityEngine.Rendering.GraphicsTier)};
            method = type.GetMethod("set_activeTier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_activeTier_72);
            args = new Type[]{typeof(UnityEngine.RenderTexture)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_73);
            args = new Type[]{typeof(UnityEngine.RenderTexture), typeof(System.Int32)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_74);
            args = new Type[]{typeof(UnityEngine.RenderTexture), typeof(System.Int32), typeof(UnityEngine.CubemapFace)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_75);
            args = new Type[]{typeof(UnityEngine.RenderTexture), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_76);
            args = new Type[]{typeof(UnityEngine.RenderBuffer), typeof(UnityEngine.RenderBuffer)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_77);
            args = new Type[]{typeof(UnityEngine.RenderBuffer), typeof(UnityEngine.RenderBuffer), typeof(System.Int32)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_78);
            args = new Type[]{typeof(UnityEngine.RenderBuffer), typeof(UnityEngine.RenderBuffer), typeof(System.Int32), typeof(UnityEngine.CubemapFace)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_79);
            args = new Type[]{typeof(UnityEngine.RenderBuffer), typeof(UnityEngine.RenderBuffer), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_80);
            args = new Type[]{typeof(UnityEngine.RenderBuffer[]), typeof(UnityEngine.RenderBuffer)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_81);
            args = new Type[]{typeof(UnityEngine.RenderTargetSetup)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_82);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.Texture)};
            method = type.GetMethod("CopyTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTexture_83);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(System.Int32), typeof(UnityEngine.Texture), typeof(System.Int32)};
            method = type.GetMethod("CopyTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTexture_84);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("CopyTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTexture_85);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("CopyTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTexture_86);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.Texture)};
            method = type.GetMethod("ConvertTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ConvertTexture_87);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(System.Int32), typeof(UnityEngine.Texture), typeof(System.Int32)};
            method = type.GetMethod("ConvertTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ConvertTexture_88);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("DrawMeshNow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshNow_89);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(System.Int32)};
            method = type.GetMethod("DrawMeshNow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshNow_90);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("DrawMeshNow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshNow_91);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(System.Int32)};
            method = type.GetMethod("DrawMeshNow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshNow_92);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Graphics());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Graphics[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* DrawMesh_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean receiveShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean castShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Quaternion rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Vector3 position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows);

            return __ret;
        }

        static StackObject* DrawMesh_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean castShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Quaternion rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Vector3 position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows);

            return __ret;
        }

        static StackObject* DrawMesh_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Quaternion rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector3 position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties);

            return __ret;
        }

        static StackObject* DrawMesh_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Quaternion rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector3 position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex);

            return __ret;
        }

        static StackObject* DrawMesh_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Quaternion rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector3 position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer, camera);

            return __ret;
        }

        static StackObject* DrawMesh_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Quaternion rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector3 position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer);

            return __ret;
        }

        static StackObject* DrawMesh_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 11);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean useLightProbes = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean receiveShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean castShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Quaternion rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Vector3 position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, useLightProbes);

            return __ret;
        }

        static StackObject* DrawMesh_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 11);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform probeAnchor = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean receiveShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.ShadowCastingMode castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Quaternion rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Vector3 position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor);

            return __ret;
        }

        static StackObject* DrawMesh_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean receiveShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.ShadowCastingMode castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Quaternion rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Vector3 position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows);

            return __ret;
        }

        static StackObject* DrawMesh_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ShadowCastingMode castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Quaternion rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Vector3 position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows);

            return __ret;
        }

        static StackObject* DrawMesh_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 12);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean useLightProbes = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform probeAnchor = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean receiveShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.ShadowCastingMode castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Quaternion rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            UnityEngine.Vector3 position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 12);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes);

            return __ret;
        }

        static StackObject* DrawMesh_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean receiveShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean castShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows);

            return __ret;
        }

        static StackObject* DrawMesh_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean castShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows);

            return __ret;
        }

        static StackObject* DrawMesh_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties);

            return __ret;
        }

        static StackObject* DrawMesh_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex);

            return __ret;
        }

        static StackObject* DrawMesh_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera);

            return __ret;
        }

        static StackObject* DrawMesh_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer);

            return __ret;
        }

        static StackObject* DrawMesh_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean useLightProbes = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean receiveShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean castShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, useLightProbes);

            return __ret;
        }

        static StackObject* DrawMesh_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform probeAnchor = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean receiveShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.ShadowCastingMode castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor);

            return __ret;
        }

        static StackObject* DrawMesh_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean receiveShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.ShadowCastingMode castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows);

            return __ret;
        }

        static StackObject* DrawMesh_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ShadowCastingMode castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows);

            return __ret;
        }

        static StackObject* DrawMesh_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 11);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean useLightProbes = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform probeAnchor = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean receiveShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.ShadowCastingMode castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes);

            return __ret;
        }

        static StackObject* DrawProcedural_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 instanceCount = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 vertexCount = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MeshTopology topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawProcedural(topology, vertexCount, instanceCount);

            return __ret;
        }

        static StackObject* DrawProcedural_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 vertexCount = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MeshTopology topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawProcedural(topology, vertexCount);

            return __ret;
        }

        static StackObject* DrawProceduralIndirect_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 argsOffset = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MeshTopology topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawProceduralIndirect(topology, bufferWithArgs, argsOffset);

            return __ret;
        }

        static StackObject* DrawProceduralIndirect_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MeshTopology topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawProceduralIndirect(topology, bufferWithArgs);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean receiveShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.ShadowCastingMode castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Matrix4x4[] matrices = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean receiveShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.ShadowCastingMode castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Matrix4x4[] matrices = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ShadowCastingMode castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Matrix4x4[] matrices = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Matrix4x4[] matrices = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Matrix4x4[] matrices = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4[] matrices = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean receiveShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.ShadowCastingMode castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Matrix4x4[] matrices = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean receiveShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.ShadowCastingMode castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean receiveShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.ShadowCastingMode castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ShadowCastingMode castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean receiveShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.ShadowCastingMode castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera);

            return __ret;
        }

        static StackObject* DrawMeshInstancedIndirect_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean receiveShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.ShadowCastingMode castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 argsOffset = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Bounds bounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer);

            return __ret;
        }

        static StackObject* DrawMeshInstancedIndirect_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean receiveShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.ShadowCastingMode castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 argsOffset = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Bounds bounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows);

            return __ret;
        }

        static StackObject* DrawMeshInstancedIndirect_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ShadowCastingMode castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 argsOffset = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Bounds bounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows);

            return __ret;
        }

        static StackObject* DrawMeshInstancedIndirect_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 argsOffset = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Bounds bounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties);

            return __ret;
        }

        static StackObject* DrawMeshInstancedIndirect_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 argsOffset = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Bounds bounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset);

            return __ret;
        }

        static StackObject* DrawMeshInstancedIndirect_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Bounds bounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs);

            return __ret;
        }

        static StackObject* DrawMeshInstancedIndirect_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 11);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean receiveShadows = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.ShadowCastingMode castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 argsOffset = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Bounds bounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera);

            return __ret;
        }

        static StackObject* DrawTexture_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rect screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawTexture(screenRect, texture, mat);

            return __ret;
        }

        static StackObject* DrawTexture_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rect screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawTexture(screenRect, texture);

            return __ret;
        }

        static StackObject* DrawTexture_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 pass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Texture texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rect screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawTexture(screenRect, texture, mat, pass);

            return __ret;
        }

        static StackObject* DrawTexture_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 bottomBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 topBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 rightBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 leftBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Texture texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Rect screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat);

            return __ret;
        }

        static StackObject* DrawTexture_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 bottomBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 topBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 rightBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 leftBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Texture texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rect screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder);

            return __ret;
        }

        static StackObject* DrawTexture_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 pass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 bottomBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 topBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 rightBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 leftBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Texture texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Rect screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat, pass);

            return __ret;
        }

        static StackObject* DrawTexture_52(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 bottomBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 topBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 rightBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 leftBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rect sourceRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Texture texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Rect screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, mat);

            return __ret;
        }

        static StackObject* DrawTexture_53(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 bottomBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 topBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 rightBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 leftBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rect sourceRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Texture texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Rect screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder);

            return __ret;
        }

        static StackObject* DrawTexture_54(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 pass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 bottomBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 topBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 rightBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 leftBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Rect sourceRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Texture texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Rect screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, mat, pass);

            return __ret;
        }

        static StackObject* DrawTexture_55(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Color color = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 bottomBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 topBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 rightBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 leftBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Rect sourceRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Texture texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Rect screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat);

            return __ret;
        }

        static StackObject* DrawTexture_56(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color color = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 bottomBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 topBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 rightBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 leftBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rect sourceRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Texture texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Rect screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color);

            return __ret;
        }

        static StackObject* DrawTexture_57(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 pass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Color color = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 bottomBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 topBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 rightBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 leftBorder = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Rect sourceRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Texture texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Rect screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, pass);

            return __ret;
        }

        static StackObject* ExecuteCommandBuffer_58(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.CommandBuffer buffer = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.ExecuteCommandBuffer(buffer);

            return __ret;
        }

        static StackObject* Blit_59(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderTexture dest = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.Blit(source, dest);

            return __ret;
        }

        static StackObject* Blit_60(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RenderTexture dest = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Texture source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.Blit(source, dest, mat);

            return __ret;
        }

        static StackObject* Blit_61(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 pass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RenderTexture dest = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Texture source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.Blit(source, dest, mat, pass);

            return __ret;
        }

        static StackObject* Blit_62(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.Blit(source, mat);

            return __ret;
        }

        static StackObject* Blit_63(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 pass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Texture source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.Blit(source, mat, pass);

            return __ret;
        }

        static StackObject* BlitMultiTap_64(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2[] offsets = (UnityEngine.Vector2[])typeof(UnityEngine.Vector2[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RenderTexture dest = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Texture source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.BlitMultiTap(source, dest, mat, offsets);

            return __ret;
        }

        static StackObject* get_activeColorBuffer_65(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Graphics.activeColorBuffer;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_activeDepthBuffer_66(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Graphics.activeDepthBuffer;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetRandomWriteTarget_67(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderTexture uav = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;

            UnityEngine.Graphics.SetRandomWriteTarget(index, uav);

            return __ret;
        }

        static StackObject* SetRandomWriteTarget_68(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ComputeBuffer uav = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;

            UnityEngine.Graphics.SetRandomWriteTarget(index, uav);

            return __ret;
        }

        static StackObject* SetRandomWriteTarget_69(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean preserveCounterValue = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ComputeBuffer uav = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 index = ptr_of_this_method->Value;

            UnityEngine.Graphics.SetRandomWriteTarget(index, uav, preserveCounterValue);

            return __ret;
        }

        static StackObject* ClearRandomWriteTargets_70(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            UnityEngine.Graphics.ClearRandomWriteTargets();

            return __ret;
        }

        static StackObject* get_activeTier_71(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Graphics.activeTier;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_activeTier_72(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.GraphicsTier value = (UnityEngine.Rendering.GraphicsTier)typeof(UnityEngine.Rendering.GraphicsTier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.activeTier = value;

            return __ret;
        }

        static StackObject* SetRenderTarget_73(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderTexture rt = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.SetRenderTarget(rt);

            return __ret;
        }

        static StackObject* SetRenderTarget_74(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 mipLevel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RenderTexture rt = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.SetRenderTarget(rt, mipLevel);

            return __ret;
        }

        static StackObject* SetRenderTarget_75(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CubemapFace face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 mipLevel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RenderTexture rt = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.SetRenderTarget(rt, mipLevel, face);

            return __ret;
        }

        static StackObject* SetRenderTarget_76(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 depthSlice = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CubemapFace face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 mipLevel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.RenderTexture rt = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.SetRenderTarget(rt, mipLevel, face, depthSlice);

            return __ret;
        }

        static StackObject* SetRenderTarget_77(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderBuffer depthBuffer = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RenderBuffer colorBuffer = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.SetRenderTarget(colorBuffer, depthBuffer);

            return __ret;
        }

        static StackObject* SetRenderTarget_78(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 mipLevel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RenderBuffer depthBuffer = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RenderBuffer colorBuffer = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.SetRenderTarget(colorBuffer, depthBuffer, mipLevel);

            return __ret;
        }

        static StackObject* SetRenderTarget_79(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CubemapFace face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 mipLevel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RenderBuffer depthBuffer = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.RenderBuffer colorBuffer = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.SetRenderTarget(colorBuffer, depthBuffer, mipLevel, face);

            return __ret;
        }

        static StackObject* SetRenderTarget_80(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 depthSlice = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CubemapFace face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 mipLevel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.RenderBuffer depthBuffer = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.RenderBuffer colorBuffer = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.SetRenderTarget(colorBuffer, depthBuffer, mipLevel, face, depthSlice);

            return __ret;
        }

        static StackObject* SetRenderTarget_81(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderBuffer depthBuffer = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RenderBuffer[] colorBuffers = (UnityEngine.RenderBuffer[])typeof(UnityEngine.RenderBuffer[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.SetRenderTarget(colorBuffers, depthBuffer);

            return __ret;
        }

        static StackObject* SetRenderTarget_82(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderTargetSetup setup = (UnityEngine.RenderTargetSetup)typeof(UnityEngine.RenderTargetSetup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.SetRenderTarget(setup);

            return __ret;
        }

        static StackObject* CopyTexture_83(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture dst = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture src = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.CopyTexture(src, dst);

            return __ret;
        }

        static StackObject* CopyTexture_84(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 dstElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture dst = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 srcElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Texture src = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.CopyTexture(src, srcElement, dst, dstElement);

            return __ret;
        }

        static StackObject* CopyTexture_85(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 dstMip = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 dstElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Texture dst = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 srcMip = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 srcElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Texture src = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.CopyTexture(src, srcElement, srcMip, dst, dstElement, dstMip);

            return __ret;
        }

        static StackObject* CopyTexture_86(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 12);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 dstY = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 dstX = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 dstMip = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 dstElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Texture dst = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 srcHeight = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 srcWidth = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Int32 srcY = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            System.Int32 srcX = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            System.Int32 srcMip = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            System.Int32 srcElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 12);
            UnityEngine.Texture src = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.CopyTexture(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dst, dstElement, dstMip, dstX, dstY);

            return __ret;
        }

        static StackObject* ConvertTexture_87(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture dst = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture src = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.Graphics.ConvertTexture(src, dst);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* ConvertTexture_88(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 dstElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture dst = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 srcElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Texture src = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.Graphics.ConvertTexture(src, srcElement, dst, dstElement);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* DrawMeshNow_89(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshNow(mesh, position, rotation);

            return __ret;
        }

        static StackObject* DrawMeshNow_90(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 materialIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Quaternion rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshNow(mesh, position, rotation, materialIndex);

            return __ret;
        }

        static StackObject* DrawMeshNow_91(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshNow(mesh, matrix);

            return __ret;
        }

        static StackObject* DrawMeshNow_92(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 materialIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Graphics.DrawMeshNow(mesh, matrix, materialIndex);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Graphics();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
