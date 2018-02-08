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
    unsafe class UnityEngine_Rendering_CommandBuffer_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Rendering.CommandBuffer);
            args = new Type[]{};
            method = type.GetMethod("Dispose", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Dispose_0);
            args = new Type[]{};
            method = type.GetMethod("Release", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Release_1);
            args = new Type[]{typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(System.Single)};
            method = type.GetMethod("SetComputeFloatParam", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetComputeFloatParam_2);
            args = new Type[]{typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(System.Int32)};
            method = type.GetMethod("SetComputeIntParam", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetComputeIntParam_3);
            args = new Type[]{typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(UnityEngine.Vector4)};
            method = type.GetMethod("SetComputeVectorParam", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetComputeVectorParam_4);
            args = new Type[]{typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(System.Single[])};
            method = type.GetMethod("SetComputeFloatParams", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetComputeFloatParams_5);
            args = new Type[]{typeof(UnityEngine.ComputeShader), typeof(System.String), typeof(System.Int32[])};
            method = type.GetMethod("SetComputeIntParams", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetComputeIntParams_6);
            args = new Type[]{typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.String), typeof(UnityEngine.Rendering.RenderTargetIdentifier)};
            method = type.GetMethod("SetComputeTextureParam", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetComputeTextureParam_7);
            args = new Type[]{typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.String), typeof(UnityEngine.ComputeBuffer)};
            method = type.GetMethod("SetComputeBufferParam", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetComputeBufferParam_8);
            args = new Type[]{typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("DispatchCompute", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DispatchCompute_9);
            args = new Type[]{typeof(UnityEngine.ComputeShader), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32)};
            method = type.GetMethod("DispatchCompute", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DispatchCompute_10);
            args = new Type[]{typeof(UnityEngine.ComputeBuffer), typeof(UnityEngine.ComputeBuffer), typeof(System.UInt32)};
            method = type.GetMethod("CopyCounterValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyCounterValue_11);
            args = new Type[]{};
            method = type.GetMethod("get_name", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_name_12);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_name", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_name_13);
            args = new Type[]{};
            method = type.GetMethod("get_sizeInBytes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sizeInBytes_14);
            args = new Type[]{};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_15);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_16);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_17);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_18);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_19);
            args = new Type[]{typeof(UnityEngine.Renderer), typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("DrawRenderer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawRenderer_20);
            args = new Type[]{typeof(UnityEngine.Renderer), typeof(UnityEngine.Material)};
            method = type.GetMethod("DrawRenderer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawRenderer_21);
            args = new Type[]{typeof(UnityEngine.Renderer), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("DrawRenderer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawRenderer_22);
            args = new Type[]{typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("DrawProcedural", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProcedural_23);
            args = new Type[]{typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32)};
            method = type.GetMethod("DrawProcedural", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProcedural_24);
            args = new Type[]{typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock)};
            method = type.GetMethod("DrawProcedural", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProcedural_25);
            args = new Type[]{typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32)};
            method = type.GetMethod("DrawProceduralIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProceduralIndirect_26);
            args = new Type[]{typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer)};
            method = type.GetMethod("DrawProceduralIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProceduralIndirect_27);
            args = new Type[]{typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock)};
            method = type.GetMethod("DrawProceduralIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProceduralIndirect_28);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Matrix4x4[]), typeof(System.Int32)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_29);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Matrix4x4[])};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_30);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Matrix4x4[]), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_31);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32)};
            method = type.GetMethod("DrawMeshInstancedIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstancedIndirect_32);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer)};
            method = type.GetMethod("DrawMeshInstancedIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstancedIndirect_33);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock)};
            method = type.GetMethod("DrawMeshInstancedIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstancedIndirect_34);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderTargetIdentifier)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_35);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_36);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.CubemapFace)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_37);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_38);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_39);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_40);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.CubemapFace)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_41);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_42);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderTargetIdentifier[]), typeof(UnityEngine.Rendering.RenderTargetIdentifier)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_43);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier)};
            method = type.GetMethod("CopyTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTexture_44);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32)};
            method = type.GetMethod("CopyTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTexture_45);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("CopyTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTexture_46);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("CopyTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTexture_47);
            args = new Type[]{typeof(UnityEngine.Rect)};
            method = type.GetMethod("SetViewport", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetViewport_48);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.Rendering.RenderTargetIdentifier)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_49);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Material)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_50);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_51);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_52);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Material)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_53);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_54);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("GetTemporaryRT", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTemporaryRT_55);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32)};
            method = type.GetMethod("GetTemporaryRT", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTemporaryRT_56);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite)};
            method = type.GetMethod("GetTemporaryRT", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTemporaryRT_57);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode), typeof(UnityEngine.RenderTextureFormat)};
            method = type.GetMethod("GetTemporaryRT", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTemporaryRT_58);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FilterMode)};
            method = type.GetMethod("GetTemporaryRT", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTemporaryRT_59);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("GetTemporaryRT", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTemporaryRT_60);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("GetTemporaryRT", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTemporaryRT_61);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("ReleaseTemporaryRT", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReleaseTemporaryRT_62);
            args = new Type[]{typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.Color), typeof(System.Single)};
            method = type.GetMethod("ClearRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearRenderTarget_63);
            args = new Type[]{typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.Color)};
            method = type.GetMethod("ClearRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearRenderTarget_64);
            args = new Type[]{typeof(System.String), typeof(System.Single)};
            method = type.GetMethod("SetGlobalFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalFloat_65);
            args = new Type[]{typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("SetGlobalFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalFloat_66);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Vector4)};
            method = type.GetMethod("SetGlobalVector", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalVector_67);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Vector4)};
            method = type.GetMethod("SetGlobalVector", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalVector_68);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Color)};
            method = type.GetMethod("SetGlobalColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalColor_69);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Color)};
            method = type.GetMethod("SetGlobalColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalColor_70);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("SetGlobalMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalMatrix_71);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("SetGlobalMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalMatrix_72);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("EnableShaderKeyword", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EnableShaderKeyword_73);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("DisableShaderKeyword", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DisableShaderKeyword_74);
            args = new Type[]{typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("SetViewMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetViewMatrix_75);
            args = new Type[]{typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("SetProjectionMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetProjectionMatrix_76);
            args = new Type[]{typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("SetViewProjectionMatrices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetViewProjectionMatrices_77);
            args = new Type[]{typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SetGlobalDepthBias", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalDepthBias_78);
            args = new Type[]{typeof(System.String), typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("SetGlobalFloatArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalFloatArray_79);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("SetGlobalFloatArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalFloatArray_80);
            args = new Type[]{typeof(System.String), typeof(System.Single[])};
            method = type.GetMethod("SetGlobalFloatArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalFloatArray_81);
            args = new Type[]{typeof(System.Int32), typeof(System.Single[])};
            method = type.GetMethod("SetGlobalFloatArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalFloatArray_82);
            args = new Type[]{typeof(System.String), typeof(System.Collections.Generic.List<UnityEngine.Vector4>)};
            method = type.GetMethod("SetGlobalVectorArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalVectorArray_83);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.Vector4>)};
            method = type.GetMethod("SetGlobalVectorArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalVectorArray_84);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Vector4[])};
            method = type.GetMethod("SetGlobalVectorArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalVectorArray_85);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Vector4[])};
            method = type.GetMethod("SetGlobalVectorArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalVectorArray_86);
            args = new Type[]{typeof(System.String), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>)};
            method = type.GetMethod("SetGlobalMatrixArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalMatrixArray_87);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>)};
            method = type.GetMethod("SetGlobalMatrixArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalMatrixArray_88);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Matrix4x4[])};
            method = type.GetMethod("SetGlobalMatrixArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalMatrixArray_89);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Matrix4x4[])};
            method = type.GetMethod("SetGlobalMatrixArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalMatrixArray_90);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Rendering.RenderTargetIdentifier)};
            method = type.GetMethod("SetGlobalTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalTexture_91);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Rendering.RenderTargetIdentifier)};
            method = type.GetMethod("SetGlobalTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalTexture_92);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.ComputeBuffer)};
            method = type.GetMethod("SetGlobalBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalBuffer_93);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.ComputeBuffer)};
            method = type.GetMethod("SetGlobalBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalBuffer_94);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderTargetIdentifier), typeof(UnityEngine.Rendering.ShadowSamplingMode)};
            method = type.GetMethod("SetShadowSamplingMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetShadowSamplingMode_95);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("BeginSample", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginSample_96);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("EndSample", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EndSample_97);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Rendering.CommandBuffer());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Rendering.CommandBuffer[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Dispose_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Dispose();

            return __ret;
        }

        static StackObject* Release_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Release();

            return __ret;
        }

        static StackObject* SetComputeFloatParam_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single val = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ComputeShader computeShader = (UnityEngine.ComputeShader)typeof(UnityEngine.ComputeShader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetComputeFloatParam(computeShader, name, val);

            return __ret;
        }

        static StackObject* SetComputeIntParam_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 val = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ComputeShader computeShader = (UnityEngine.ComputeShader)typeof(UnityEngine.ComputeShader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetComputeIntParam(computeShader, name, val);

            return __ret;
        }

        static StackObject* SetComputeVectorParam_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4 val = (UnityEngine.Vector4)typeof(UnityEngine.Vector4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ComputeShader computeShader = (UnityEngine.ComputeShader)typeof(UnityEngine.ComputeShader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetComputeVectorParam(computeShader, name, val);

            return __ret;
        }

        static StackObject* SetComputeFloatParams_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single[] values = (System.Single[])typeof(System.Single[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ComputeShader computeShader = (UnityEngine.ComputeShader)typeof(UnityEngine.ComputeShader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetComputeFloatParams(computeShader, name, values);

            return __ret;
        }

        static StackObject* SetComputeIntParams_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32[] values = (System.Int32[])typeof(System.Int32[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ComputeShader computeShader = (UnityEngine.ComputeShader)typeof(UnityEngine.ComputeShader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetComputeIntParams(computeShader, name, values);

            return __ret;
        }

        static StackObject* SetComputeTextureParam_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.RenderTargetIdentifier rt = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 kernelIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.ComputeShader computeShader = (UnityEngine.ComputeShader)typeof(UnityEngine.ComputeShader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetComputeTextureParam(computeShader, kernelIndex, name, rt);

            return __ret;
        }

        static StackObject* SetComputeBufferParam_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ComputeBuffer buffer = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 kernelIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.ComputeShader computeShader = (UnityEngine.ComputeShader)typeof(UnityEngine.ComputeShader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetComputeBufferParam(computeShader, kernelIndex, name, buffer);

            return __ret;
        }

        static StackObject* DispatchCompute_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 threadGroupsZ = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 threadGroupsY = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 threadGroupsX = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 kernelIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.ComputeShader computeShader = (UnityEngine.ComputeShader)typeof(UnityEngine.ComputeShader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DispatchCompute(computeShader, kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ);

            return __ret;
        }

        static StackObject* DispatchCompute_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 argsOffset = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ComputeBuffer indirectBuffer = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 kernelIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.ComputeShader computeShader = (UnityEngine.ComputeShader)typeof(UnityEngine.ComputeShader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DispatchCompute(computeShader, kernelIndex, indirectBuffer, argsOffset);

            return __ret;
        }

        static StackObject* CopyCounterValue_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 dstOffset = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ComputeBuffer dst = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ComputeBuffer src = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyCounterValue(src, dst, dstOffset);

            return __ret;
        }

        static StackObject* get_name_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.name;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_name_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.name = value;

            return __ret;
        }

        static StackObject* get_sizeInBytes_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sizeInBytes;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Clear_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clear();

            return __ret;
        }

        static StackObject* DrawMesh_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 shaderPass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawMesh(mesh, matrix, material, submeshIndex, shaderPass);

            return __ret;
        }

        static StackObject* DrawMesh_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawMesh(mesh, matrix, material, submeshIndex);

            return __ret;
        }

        static StackObject* DrawMesh_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawMesh(mesh, matrix, material);

            return __ret;
        }

        static StackObject* DrawMesh_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 shaderPass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawMesh(mesh, matrix, material, submeshIndex, shaderPass, properties);

            return __ret;
        }

        static StackObject* DrawRenderer_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Renderer renderer = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawRenderer(renderer, material, submeshIndex);

            return __ret;
        }

        static StackObject* DrawRenderer_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer renderer = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawRenderer(renderer, material);

            return __ret;
        }

        static StackObject* DrawRenderer_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 shaderPass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Renderer renderer = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawRenderer(renderer, material, submeshIndex, shaderPass);

            return __ret;
        }

        static StackObject* DrawProcedural_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 instanceCount = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 vertexCount = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MeshTopology topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 shaderPass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawProcedural(matrix, material, shaderPass, topology, vertexCount, instanceCount);

            return __ret;
        }

        static StackObject* DrawProcedural_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 vertexCount = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MeshTopology topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 shaderPass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawProcedural(matrix, material, shaderPass, topology, vertexCount);

            return __ret;
        }

        static StackObject* DrawProcedural_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 instanceCount = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 vertexCount = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MeshTopology topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 shaderPass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawProcedural(matrix, material, shaderPass, topology, vertexCount, instanceCount, properties);

            return __ret;
        }

        static StackObject* DrawProceduralIndirect_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 argsOffset = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MeshTopology topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 shaderPass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, argsOffset);

            return __ret;
        }

        static StackObject* DrawProceduralIndirect_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MeshTopology topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 shaderPass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs);

            return __ret;
        }

        static StackObject* DrawProceduralIndirect_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 argsOffset = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MeshTopology topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 shaderPass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Matrix4x4 matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Matrix4x4[] matrices = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 shaderPass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawMeshInstanced(mesh, submeshIndex, material, shaderPass, matrices, count);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4[] matrices = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 shaderPass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawMeshInstanced(mesh, submeshIndex, material, shaderPass, matrices);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Matrix4x4[] matrices = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 shaderPass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawMeshInstanced(mesh, submeshIndex, material, shaderPass, matrices, count, properties);

            return __ret;
        }

        static StackObject* DrawMeshInstancedIndirect_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 argsOffset = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 shaderPass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset);

            return __ret;
        }

        static StackObject* DrawMeshInstancedIndirect_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 shaderPass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs);

            return __ret;
        }

        static StackObject* DrawMeshInstancedIndirect_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 argsOffset = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 shaderPass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Material material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 submeshIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Mesh mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset, properties);

            return __ret;
        }

        static StackObject* SetRenderTarget_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.RenderTargetIdentifier rt = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetRenderTarget(rt);

            return __ret;
        }

        static StackObject* SetRenderTarget_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 mipLevel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.RenderTargetIdentifier rt = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetRenderTarget(rt, mipLevel);

            return __ret;
        }

        static StackObject* SetRenderTarget_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CubemapFace cubemapFace = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 mipLevel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.RenderTargetIdentifier rt = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetRenderTarget(rt, mipLevel, cubemapFace);

            return __ret;
        }

        static StackObject* SetRenderTarget_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 depthSlice = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CubemapFace cubemapFace = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 mipLevel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.RenderTargetIdentifier rt = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetRenderTarget(rt, mipLevel, cubemapFace, depthSlice);

            return __ret;
        }

        static StackObject* SetRenderTarget_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.RenderTargetIdentifier depth = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.RenderTargetIdentifier color = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetRenderTarget(color, depth);

            return __ret;
        }

        static StackObject* SetRenderTarget_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 mipLevel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.RenderTargetIdentifier depth = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.RenderTargetIdentifier color = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetRenderTarget(color, depth, mipLevel);

            return __ret;
        }

        static StackObject* SetRenderTarget_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CubemapFace cubemapFace = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 mipLevel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.RenderTargetIdentifier depth = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.RenderTargetIdentifier color = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetRenderTarget(color, depth, mipLevel, cubemapFace);

            return __ret;
        }

        static StackObject* SetRenderTarget_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 depthSlice = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CubemapFace cubemapFace = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 mipLevel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.RenderTargetIdentifier depth = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rendering.RenderTargetIdentifier color = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetRenderTarget(color, depth, mipLevel, cubemapFace, depthSlice);

            return __ret;
        }

        static StackObject* SetRenderTarget_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.RenderTargetIdentifier depth = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.RenderTargetIdentifier[] colors = (UnityEngine.Rendering.RenderTargetIdentifier[])typeof(UnityEngine.Rendering.RenderTargetIdentifier[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetRenderTarget(colors, depth);

            return __ret;
        }

        static StackObject* CopyTexture_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.RenderTargetIdentifier dst = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.RenderTargetIdentifier src = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyTexture(src, dst);

            return __ret;
        }

        static StackObject* CopyTexture_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 dstElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.RenderTargetIdentifier dst = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 srcElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.RenderTargetIdentifier src = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyTexture(src, srcElement, dst, dstElement);

            return __ret;
        }

        static StackObject* CopyTexture_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 dstMip = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 dstElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.RenderTargetIdentifier dst = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 srcMip = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 srcElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rendering.RenderTargetIdentifier src = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyTexture(src, srcElement, srcMip, dst, dstElement, dstMip);

            return __ret;
        }

        static StackObject* CopyTexture_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 13);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 dstY = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 dstX = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 dstMip = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 dstElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rendering.RenderTargetIdentifier dst = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
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
            UnityEngine.Rendering.RenderTargetIdentifier src = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 13);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyTexture(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dst, dstElement, dstMip, dstX, dstY);

            return __ret;
        }

        static StackObject* SetViewport_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rect pixelRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetViewport(pixelRect);

            return __ret;
        }

        static StackObject* Blit_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.RenderTargetIdentifier dest = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Blit(source, dest);

            return __ret;
        }

        static StackObject* Blit_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.RenderTargetIdentifier dest = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Texture source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Blit(source, dest, mat);

            return __ret;
        }

        static StackObject* Blit_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 pass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.RenderTargetIdentifier dest = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Texture source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Blit(source, dest, mat, pass);

            return __ret;
        }

        static StackObject* Blit_52(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.RenderTargetIdentifier dest = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.RenderTargetIdentifier source = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Blit(source, dest);

            return __ret;
        }

        static StackObject* Blit_53(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.RenderTargetIdentifier dest = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.RenderTargetIdentifier source = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Blit(source, dest, mat);

            return __ret;
        }

        static StackObject* Blit_54(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 pass = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.RenderTargetIdentifier dest = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.RenderTargetIdentifier source = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Blit(source, dest, mat, pass);

            return __ret;
        }

        static StackObject* GetTemporaryRT_55(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean enableRandomWrite = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 antiAliasing = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RenderTextureReadWrite readWrite = (UnityEngine.RenderTextureReadWrite)typeof(UnityEngine.RenderTextureReadWrite).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.RenderTextureFormat format = (UnityEngine.RenderTextureFormat)typeof(UnityEngine.RenderTextureFormat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.FilterMode filter = (UnityEngine.FilterMode)typeof(UnityEngine.FilterMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 depthBuffer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 height = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Int32 width = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            System.Int32 nameID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite);

            return __ret;
        }

        static StackObject* GetTemporaryRT_56(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 antiAliasing = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RenderTextureReadWrite readWrite = (UnityEngine.RenderTextureReadWrite)typeof(UnityEngine.RenderTextureReadWrite).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RenderTextureFormat format = (UnityEngine.RenderTextureFormat)typeof(UnityEngine.RenderTextureFormat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.FilterMode filter = (UnityEngine.FilterMode)typeof(UnityEngine.FilterMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 depthBuffer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 height = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 width = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Int32 nameID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing);

            return __ret;
        }

        static StackObject* GetTemporaryRT_57(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderTextureReadWrite readWrite = (UnityEngine.RenderTextureReadWrite)typeof(UnityEngine.RenderTextureReadWrite).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RenderTextureFormat format = (UnityEngine.RenderTextureFormat)typeof(UnityEngine.RenderTextureFormat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.FilterMode filter = (UnityEngine.FilterMode)typeof(UnityEngine.FilterMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 depthBuffer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 height = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 width = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 nameID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite);

            return __ret;
        }

        static StackObject* GetTemporaryRT_58(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderTextureFormat format = (UnityEngine.RenderTextureFormat)typeof(UnityEngine.RenderTextureFormat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.FilterMode filter = (UnityEngine.FilterMode)typeof(UnityEngine.FilterMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 depthBuffer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 height = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 width = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 nameID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format);

            return __ret;
        }

        static StackObject* GetTemporaryRT_59(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.FilterMode filter = (UnityEngine.FilterMode)typeof(UnityEngine.FilterMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 depthBuffer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 height = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 width = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 nameID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetTemporaryRT(nameID, width, height, depthBuffer, filter);

            return __ret;
        }

        static StackObject* GetTemporaryRT_60(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 depthBuffer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 height = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 width = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 nameID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetTemporaryRT(nameID, width, height, depthBuffer);

            return __ret;
        }

        static StackObject* GetTemporaryRT_61(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 height = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 width = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 nameID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetTemporaryRT(nameID, width, height);

            return __ret;
        }

        static StackObject* ReleaseTemporaryRT_62(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 nameID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ReleaseTemporaryRT(nameID);

            return __ret;
        }

        static StackObject* ClearRenderTarget_63(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single depth = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Color backgroundColor = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean clearColor = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean clearDepth = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClearRenderTarget(clearDepth, clearColor, backgroundColor, depth);

            return __ret;
        }

        static StackObject* ClearRenderTarget_64(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color backgroundColor = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean clearColor = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean clearDepth = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClearRenderTarget(clearDepth, clearColor, backgroundColor);

            return __ret;
        }

        static StackObject* SetGlobalFloat_65(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalFloat(name, value);

            return __ret;
        }

        static StackObject* SetGlobalFloat_66(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 nameID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalFloat(nameID, value);

            return __ret;
        }

        static StackObject* SetGlobalVector_67(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4 value = (UnityEngine.Vector4)typeof(UnityEngine.Vector4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalVector(name, value);

            return __ret;
        }

        static StackObject* SetGlobalVector_68(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4 value = (UnityEngine.Vector4)typeof(UnityEngine.Vector4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 nameID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalVector(nameID, value);

            return __ret;
        }

        static StackObject* SetGlobalColor_69(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalColor(name, value);

            return __ret;
        }

        static StackObject* SetGlobalColor_70(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 nameID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalColor(nameID, value);

            return __ret;
        }

        static StackObject* SetGlobalMatrix_71(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 value = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalMatrix(name, value);

            return __ret;
        }

        static StackObject* SetGlobalMatrix_72(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 value = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 nameID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalMatrix(nameID, value);

            return __ret;
        }

        static StackObject* EnableShaderKeyword_73(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String keyword = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.EnableShaderKeyword(keyword);

            return __ret;
        }

        static StackObject* DisableShaderKeyword_74(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String keyword = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DisableShaderKeyword(keyword);

            return __ret;
        }

        static StackObject* SetViewMatrix_75(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 view = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetViewMatrix(view);

            return __ret;
        }

        static StackObject* SetProjectionMatrix_76(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 proj = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetProjectionMatrix(proj);

            return __ret;
        }

        static StackObject* SetViewProjectionMatrices_77(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 proj = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Matrix4x4 view = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetViewProjectionMatrices(view, proj);

            return __ret;
        }

        static StackObject* SetGlobalDepthBias_78(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single slopeBias = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single bias = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalDepthBias(bias, slopeBias);

            return __ret;
        }

        static StackObject* SetGlobalFloatArray_79(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> values = (System.Collections.Generic.List<System.Single>)typeof(System.Collections.Generic.List<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String propertyName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalFloatArray(propertyName, values);

            return __ret;
        }

        static StackObject* SetGlobalFloatArray_80(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> values = (System.Collections.Generic.List<System.Single>)typeof(System.Collections.Generic.List<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 nameID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalFloatArray(nameID, values);

            return __ret;
        }

        static StackObject* SetGlobalFloatArray_81(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single[] values = (System.Single[])typeof(System.Single[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String propertyName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalFloatArray(propertyName, values);

            return __ret;
        }

        static StackObject* SetGlobalFloatArray_82(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single[] values = (System.Single[])typeof(System.Single[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 nameID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalFloatArray(nameID, values);

            return __ret;
        }

        static StackObject* SetGlobalVectorArray_83(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector4> values = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String propertyName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalVectorArray(propertyName, values);

            return __ret;
        }

        static StackObject* SetGlobalVectorArray_84(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector4> values = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 nameID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalVectorArray(nameID, values);

            return __ret;
        }

        static StackObject* SetGlobalVectorArray_85(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4[] values = (UnityEngine.Vector4[])typeof(UnityEngine.Vector4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String propertyName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalVectorArray(propertyName, values);

            return __ret;
        }

        static StackObject* SetGlobalVectorArray_86(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4[] values = (UnityEngine.Vector4[])typeof(UnityEngine.Vector4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 nameID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalVectorArray(nameID, values);

            return __ret;
        }

        static StackObject* SetGlobalMatrixArray_87(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String propertyName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalMatrixArray(propertyName, values);

            return __ret;
        }

        static StackObject* SetGlobalMatrixArray_88(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 nameID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalMatrixArray(nameID, values);

            return __ret;
        }

        static StackObject* SetGlobalMatrixArray_89(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4[] values = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String propertyName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalMatrixArray(propertyName, values);

            return __ret;
        }

        static StackObject* SetGlobalMatrixArray_90(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4[] values = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 nameID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalMatrixArray(nameID, values);

            return __ret;
        }

        static StackObject* SetGlobalTexture_91(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.RenderTargetIdentifier value = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalTexture(name, value);

            return __ret;
        }

        static StackObject* SetGlobalTexture_92(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.RenderTargetIdentifier value = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 nameID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalTexture(nameID, value);

            return __ret;
        }

        static StackObject* SetGlobalBuffer_93(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ComputeBuffer value = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalBuffer(name, value);

            return __ret;
        }

        static StackObject* SetGlobalBuffer_94(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ComputeBuffer value = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 nameID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetGlobalBuffer(nameID, value);

            return __ret;
        }

        static StackObject* SetShadowSamplingMode_95(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ShadowSamplingMode mode = (UnityEngine.Rendering.ShadowSamplingMode)typeof(UnityEngine.Rendering.ShadowSamplingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.RenderTargetIdentifier shadowmap = (UnityEngine.Rendering.RenderTargetIdentifier)typeof(UnityEngine.Rendering.RenderTargetIdentifier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetShadowSamplingMode(shadowmap, mode);

            return __ret;
        }

        static StackObject* BeginSample_96(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.BeginSample(name);

            return __ret;
        }

        static StackObject* EndSample_97(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.CommandBuffer instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.EndSample(name);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Rendering.CommandBuffer();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
