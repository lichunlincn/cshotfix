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
    unsafe class UnityEngine_Mesh_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Mesh);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_0);
            args = new Type[]{};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_1);
            args = new Type[]{};
            method = type.GetMethod("get_isReadable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isReadable_2);
            args = new Type[]{typeof(System.Int32[]), typeof(System.Int32)};
            method = type.GetMethod("SetTriangles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTriangles_3);
            args = new Type[]{typeof(System.Int32[]), typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("SetTriangles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTriangles_4);
            args = new Type[]{typeof(System.Collections.Generic.List<System.Int32>), typeof(System.Int32)};
            method = type.GetMethod("SetTriangles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTriangles_5);
            args = new Type[]{typeof(System.Collections.Generic.List<System.Int32>), typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("SetTriangles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTriangles_6);
            args = new Type[]{typeof(System.Int32[]), typeof(UnityEngine.MeshTopology), typeof(System.Int32)};
            method = type.GetMethod("SetIndices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetIndices_7);
            args = new Type[]{typeof(System.Int32[]), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("SetIndices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetIndices_8);
            args = new Type[]{};
            method = type.GetMethod("get_blendShapeCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_blendShapeCount_9);
            args = new Type[]{};
            method = type.GetMethod("ClearBlendShapes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearBlendShapes_10);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetBlendShapeName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBlendShapeName_11);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetBlendShapeFrameCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBlendShapeFrameCount_12);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("GetBlendShapeFrameWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBlendShapeFrameWeight_13);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Vector3[]), typeof(UnityEngine.Vector3[]), typeof(UnityEngine.Vector3[])};
            method = type.GetMethod("GetBlendShapeFrameVertices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBlendShapeFrameVertices_14);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(UnityEngine.Vector3[]), typeof(UnityEngine.Vector3[]), typeof(UnityEngine.Vector3[])};
            method = type.GetMethod("AddBlendShapeFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddBlendShapeFrame_15);
            args = new Type[]{};
            method = type.GetMethod("get_vertexBufferCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_vertexBufferCount_16);
            args = new Type[]{};
            method = type.GetMethod("get_bounds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_bounds_17);
            args = new Type[]{typeof(UnityEngine.Bounds)};
            method = type.GetMethod("set_bounds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_bounds_18);
            args = new Type[]{};
            method = type.GetMethod("RecalculateBounds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RecalculateBounds_19);
            args = new Type[]{};
            method = type.GetMethod("RecalculateNormals", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RecalculateNormals_20);
            args = new Type[]{};
            method = type.GetMethod("RecalculateTangents", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RecalculateTangents_21);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetTopology", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTopology_22);
            args = new Type[]{};
            method = type.GetMethod("get_vertexCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_vertexCount_23);
            args = new Type[]{};
            method = type.GetMethod("get_subMeshCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_subMeshCount_24);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_subMeshCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_subMeshCount_25);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetIndexStart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetIndexStart_26);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetIndexCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetIndexCount_27);
            args = new Type[]{typeof(UnityEngine.CombineInstance[]), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("CombineMeshes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CombineMeshes_28);
            args = new Type[]{typeof(UnityEngine.CombineInstance[]), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("CombineMeshes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CombineMeshes_29);
            args = new Type[]{typeof(UnityEngine.CombineInstance[]), typeof(System.Boolean)};
            method = type.GetMethod("CombineMeshes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CombineMeshes_30);
            args = new Type[]{typeof(UnityEngine.CombineInstance[])};
            method = type.GetMethod("CombineMeshes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CombineMeshes_31);
            args = new Type[]{};
            method = type.GetMethod("get_boneWeights", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_boneWeights_32);
            args = new Type[]{typeof(UnityEngine.BoneWeight[])};
            method = type.GetMethod("set_boneWeights", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_boneWeights_33);
            args = new Type[]{};
            method = type.GetMethod("get_bindposes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_bindposes_34);
            args = new Type[]{typeof(UnityEngine.Matrix4x4[])};
            method = type.GetMethod("set_bindposes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_bindposes_35);
            args = new Type[]{};
            method = type.GetMethod("MarkDynamic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MarkDynamic_36);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("UploadMeshData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UploadMeshData_37);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetBlendShapeIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBlendShapeIndex_38);
            args = new Type[]{};
            method = type.GetMethod("get_vertices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_vertices_39);
            args = new Type[]{typeof(UnityEngine.Vector3[])};
            method = type.GetMethod("set_vertices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_vertices_40);
            args = new Type[]{};
            method = type.GetMethod("get_normals", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_normals_41);
            args = new Type[]{typeof(UnityEngine.Vector3[])};
            method = type.GetMethod("set_normals", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_normals_42);
            args = new Type[]{};
            method = type.GetMethod("get_tangents", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_tangents_43);
            args = new Type[]{typeof(UnityEngine.Vector4[])};
            method = type.GetMethod("set_tangents", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_tangents_44);
            args = new Type[]{};
            method = type.GetMethod("get_uv", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_uv_45);
            args = new Type[]{typeof(UnityEngine.Vector2[])};
            method = type.GetMethod("set_uv", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_uv_46);
            args = new Type[]{};
            method = type.GetMethod("get_uv2", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_uv2_47);
            args = new Type[]{typeof(UnityEngine.Vector2[])};
            method = type.GetMethod("set_uv2", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_uv2_48);
            args = new Type[]{};
            method = type.GetMethod("get_uv3", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_uv3_49);
            args = new Type[]{typeof(UnityEngine.Vector2[])};
            method = type.GetMethod("set_uv3", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_uv3_50);
            args = new Type[]{};
            method = type.GetMethod("get_uv4", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_uv4_51);
            args = new Type[]{typeof(UnityEngine.Vector2[])};
            method = type.GetMethod("set_uv4", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_uv4_52);
            args = new Type[]{};
            method = type.GetMethod("get_colors", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_colors_53);
            args = new Type[]{typeof(UnityEngine.Color[])};
            method = type.GetMethod("set_colors", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_colors_54);
            args = new Type[]{};
            method = type.GetMethod("get_colors32", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_colors32_55);
            args = new Type[]{typeof(UnityEngine.Color32[])};
            method = type.GetMethod("set_colors32", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_colors32_56);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Vector3>)};
            method = type.GetMethod("GetVertices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetVertices_57);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Vector3>)};
            method = type.GetMethod("SetVertices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetVertices_58);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Vector3>)};
            method = type.GetMethod("GetNormals", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetNormals_59);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Vector3>)};
            method = type.GetMethod("SetNormals", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetNormals_60);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Vector4>)};
            method = type.GetMethod("GetTangents", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTangents_61);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Vector4>)};
            method = type.GetMethod("SetTangents", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTangents_62);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Color>)};
            method = type.GetMethod("GetColors", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetColors_63);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Color>)};
            method = type.GetMethod("SetColors", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetColors_64);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Color32>)};
            method = type.GetMethod("GetColors", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetColors_65);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Color32>)};
            method = type.GetMethod("SetColors", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetColors_66);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.Vector2>)};
            method = type.GetMethod("SetUVs", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetUVs_67);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.Vector3>)};
            method = type.GetMethod("SetUVs", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetUVs_68);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.Vector4>)};
            method = type.GetMethod("SetUVs", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetUVs_69);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.Vector2>)};
            method = type.GetMethod("GetUVs", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetUVs_70);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.Vector3>)};
            method = type.GetMethod("GetUVs", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetUVs_71);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.Vector4>)};
            method = type.GetMethod("GetUVs", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetUVs_72);
            args = new Type[]{};
            method = type.GetMethod("get_triangles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_triangles_73);
            args = new Type[]{typeof(System.Int32[])};
            method = type.GetMethod("set_triangles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_triangles_74);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetTriangles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTriangles_75);
            args = new Type[]{typeof(System.Collections.Generic.List<System.Int32>), typeof(System.Int32)};
            method = type.GetMethod("GetTriangles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTriangles_76);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetIndices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetIndices_77);
            args = new Type[]{typeof(System.Collections.Generic.List<System.Int32>), typeof(System.Int32)};
            method = type.GetMethod("GetIndices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetIndices_78);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>)};
            method = type.GetMethod("GetBindposes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBindposes_79);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.BoneWeight>)};
            method = type.GetMethod("GetBoneWeights", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBoneWeights_80);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Mesh());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Mesh[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Clear_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean keepVertexLayout = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clear(keepVertexLayout);

            return __ret;
        }

        static StackObject* Clear_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clear();

            return __ret;
        }

        static StackObject* get_isReadable_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isReadable;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetTriangles_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 submesh = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32[] triangles = (System.Int32[])typeof(System.Int32[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTriangles(triangles, submesh);

            return __ret;
        }

        static StackObject* SetTriangles_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean calculateBounds = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 submesh = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32[] triangles = (System.Int32[])typeof(System.Int32[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTriangles(triangles, submesh, calculateBounds);

            return __ret;
        }

        static StackObject* SetTriangles_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 submesh = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Int32> triangles = (System.Collections.Generic.List<System.Int32>)typeof(System.Collections.Generic.List<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTriangles(triangles, submesh);

            return __ret;
        }

        static StackObject* SetTriangles_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean calculateBounds = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 submesh = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<System.Int32> triangles = (System.Collections.Generic.List<System.Int32>)typeof(System.Collections.Generic.List<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTriangles(triangles, submesh, calculateBounds);

            return __ret;
        }

        static StackObject* SetIndices_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 submesh = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MeshTopology topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32[] indices = (System.Int32[])typeof(System.Int32[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetIndices(indices, topology, submesh);

            return __ret;
        }

        static StackObject* SetIndices_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean calculateBounds = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 submesh = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MeshTopology topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32[] indices = (System.Int32[])typeof(System.Int32[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetIndices(indices, topology, submesh, calculateBounds);

            return __ret;
        }

        static StackObject* get_blendShapeCount_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.blendShapeCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* ClearBlendShapes_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClearBlendShapes();

            return __ret;
        }

        static StackObject* GetBlendShapeName_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 shapeIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetBlendShapeName(shapeIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetBlendShapeFrameCount_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 shapeIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetBlendShapeFrameCount(shapeIndex);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetBlendShapeFrameWeight_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 frameIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 shapeIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetBlendShapeFrameWeight(shapeIndex, frameIndex);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetBlendShapeFrameVertices_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3[] deltaTangents = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3[] deltaNormals = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3[] deltaVertices = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 frameIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 shapeIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetBlendShapeFrameVertices(shapeIndex, frameIndex, deltaVertices, deltaNormals, deltaTangents);

            return __ret;
        }

        static StackObject* AddBlendShapeFrame_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3[] deltaTangents = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3[] deltaNormals = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3[] deltaVertices = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single frameWeight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.String shapeName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddBlendShapeFrame(shapeName, frameWeight, deltaVertices, deltaNormals, deltaTangents);

            return __ret;
        }

        static StackObject* get_vertexBufferCount_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.vertexBufferCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_bounds_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.bounds;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_bounds_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Bounds value = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.bounds = value;

            return __ret;
        }

        static StackObject* RecalculateBounds_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RecalculateBounds();

            return __ret;
        }

        static StackObject* RecalculateNormals_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RecalculateNormals();

            return __ret;
        }

        static StackObject* RecalculateTangents_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RecalculateTangents();

            return __ret;
        }

        static StackObject* GetTopology_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 submesh = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetTopology(submesh);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_vertexCount_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.vertexCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_subMeshCount_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.subMeshCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_subMeshCount_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.subMeshCount = value;

            return __ret;
        }

        static StackObject* GetIndexStart_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 submesh = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetIndexStart(submesh);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetIndexCount_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 submesh = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetIndexCount(submesh);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CombineMeshes_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean hasLightmapData = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean useMatrices = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean mergeSubMeshes = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.CombineInstance[] combine = (UnityEngine.CombineInstance[])typeof(UnityEngine.CombineInstance[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CombineMeshes(combine, mergeSubMeshes, useMatrices, hasLightmapData);

            return __ret;
        }

        static StackObject* CombineMeshes_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean useMatrices = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean mergeSubMeshes = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.CombineInstance[] combine = (UnityEngine.CombineInstance[])typeof(UnityEngine.CombineInstance[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CombineMeshes(combine, mergeSubMeshes, useMatrices);

            return __ret;
        }

        static StackObject* CombineMeshes_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean mergeSubMeshes = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CombineInstance[] combine = (UnityEngine.CombineInstance[])typeof(UnityEngine.CombineInstance[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CombineMeshes(combine, mergeSubMeshes);

            return __ret;
        }

        static StackObject* CombineMeshes_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CombineInstance[] combine = (UnityEngine.CombineInstance[])typeof(UnityEngine.CombineInstance[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CombineMeshes(combine);

            return __ret;
        }

        static StackObject* get_boneWeights_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.boneWeights;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_boneWeights_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.BoneWeight[] value = (UnityEngine.BoneWeight[])typeof(UnityEngine.BoneWeight[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.boneWeights = value;

            return __ret;
        }

        static StackObject* get_bindposes_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.bindposes;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_bindposes_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4[] value = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.bindposes = value;

            return __ret;
        }

        static StackObject* MarkDynamic_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MarkDynamic();

            return __ret;
        }

        static StackObject* UploadMeshData_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean markNoLogerReadable = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UploadMeshData(markNoLogerReadable);

            return __ret;
        }

        static StackObject* GetBlendShapeIndex_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String blendShapeName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetBlendShapeIndex(blendShapeName);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_vertices_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.vertices;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_vertices_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3[] value = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.vertices = value;

            return __ret;
        }

        static StackObject* get_normals_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.normals;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_normals_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3[] value = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.normals = value;

            return __ret;
        }

        static StackObject* get_tangents_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.tangents;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_tangents_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4[] value = (UnityEngine.Vector4[])typeof(UnityEngine.Vector4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.tangents = value;

            return __ret;
        }

        static StackObject* get_uv_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.uv;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_uv_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2[] value = (UnityEngine.Vector2[])typeof(UnityEngine.Vector2[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.uv = value;

            return __ret;
        }

        static StackObject* get_uv2_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.uv2;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_uv2_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2[] value = (UnityEngine.Vector2[])typeof(UnityEngine.Vector2[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.uv2 = value;

            return __ret;
        }

        static StackObject* get_uv3_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.uv3;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_uv3_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2[] value = (UnityEngine.Vector2[])typeof(UnityEngine.Vector2[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.uv3 = value;

            return __ret;
        }

        static StackObject* get_uv4_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.uv4;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_uv4_52(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2[] value = (UnityEngine.Vector2[])typeof(UnityEngine.Vector2[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.uv4 = value;

            return __ret;
        }

        static StackObject* get_colors_53(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.colors;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_colors_54(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color[] value = (UnityEngine.Color[])typeof(UnityEngine.Color[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.colors = value;

            return __ret;
        }

        static StackObject* get_colors32_55(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.colors32;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_colors32_56(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color32[] value = (UnityEngine.Color32[])typeof(UnityEngine.Color32[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.colors32 = value;

            return __ret;
        }

        static StackObject* GetVertices_57(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector3> vertices = (System.Collections.Generic.List<UnityEngine.Vector3>)typeof(System.Collections.Generic.List<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetVertices(vertices);

            return __ret;
        }

        static StackObject* SetVertices_58(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector3> inVertices = (System.Collections.Generic.List<UnityEngine.Vector3>)typeof(System.Collections.Generic.List<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetVertices(inVertices);

            return __ret;
        }

        static StackObject* GetNormals_59(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector3> normals = (System.Collections.Generic.List<UnityEngine.Vector3>)typeof(System.Collections.Generic.List<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetNormals(normals);

            return __ret;
        }

        static StackObject* SetNormals_60(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector3> inNormals = (System.Collections.Generic.List<UnityEngine.Vector3>)typeof(System.Collections.Generic.List<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetNormals(inNormals);

            return __ret;
        }

        static StackObject* GetTangents_61(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector4> tangents = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetTangents(tangents);

            return __ret;
        }

        static StackObject* SetTangents_62(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector4> inTangents = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTangents(inTangents);

            return __ret;
        }

        static StackObject* GetColors_63(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Color> colors = (System.Collections.Generic.List<UnityEngine.Color>)typeof(System.Collections.Generic.List<UnityEngine.Color>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetColors(colors);

            return __ret;
        }

        static StackObject* SetColors_64(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Color> inColors = (System.Collections.Generic.List<UnityEngine.Color>)typeof(System.Collections.Generic.List<UnityEngine.Color>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetColors(inColors);

            return __ret;
        }

        static StackObject* GetColors_65(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Color32> colors = (System.Collections.Generic.List<UnityEngine.Color32>)typeof(System.Collections.Generic.List<UnityEngine.Color32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetColors(colors);

            return __ret;
        }

        static StackObject* SetColors_66(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Color32> inColors = (System.Collections.Generic.List<UnityEngine.Color32>)typeof(System.Collections.Generic.List<UnityEngine.Color32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetColors(inColors);

            return __ret;
        }

        static StackObject* SetUVs_67(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector2> uvs = (System.Collections.Generic.List<UnityEngine.Vector2>)typeof(System.Collections.Generic.List<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 channel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetUVs(channel, uvs);

            return __ret;
        }

        static StackObject* SetUVs_68(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector3> uvs = (System.Collections.Generic.List<UnityEngine.Vector3>)typeof(System.Collections.Generic.List<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 channel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetUVs(channel, uvs);

            return __ret;
        }

        static StackObject* SetUVs_69(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector4> uvs = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 channel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetUVs(channel, uvs);

            return __ret;
        }

        static StackObject* GetUVs_70(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector2> uvs = (System.Collections.Generic.List<UnityEngine.Vector2>)typeof(System.Collections.Generic.List<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 channel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetUVs(channel, uvs);

            return __ret;
        }

        static StackObject* GetUVs_71(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector3> uvs = (System.Collections.Generic.List<UnityEngine.Vector3>)typeof(System.Collections.Generic.List<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 channel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetUVs(channel, uvs);

            return __ret;
        }

        static StackObject* GetUVs_72(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector4> uvs = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 channel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetUVs(channel, uvs);

            return __ret;
        }

        static StackObject* get_triangles_73(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.triangles;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_triangles_74(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32[] value = (System.Int32[])typeof(System.Int32[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.triangles = value;

            return __ret;
        }

        static StackObject* GetTriangles_75(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 submesh = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetTriangles(submesh);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetTriangles_76(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 submesh = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Int32> triangles = (System.Collections.Generic.List<System.Int32>)typeof(System.Collections.Generic.List<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetTriangles(triangles, submesh);

            return __ret;
        }

        static StackObject* GetIndices_77(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 submesh = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetIndices(submesh);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetIndices_78(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 submesh = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Int32> indices = (System.Collections.Generic.List<System.Int32>)typeof(System.Collections.Generic.List<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetIndices(indices, submesh);

            return __ret;
        }

        static StackObject* GetBindposes_79(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> bindposes = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetBindposes(bindposes);

            return __ret;
        }

        static StackObject* GetBoneWeights_80(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.BoneWeight> boneWeights = (System.Collections.Generic.List<UnityEngine.BoneWeight>)typeof(System.Collections.Generic.List<UnityEngine.BoneWeight>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetBoneWeights(boneWeights);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Mesh();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
