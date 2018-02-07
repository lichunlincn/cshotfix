
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
    unsafe class UnityEngine_Terrain_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Terrain);
            args = new Type[]{};
            method = type.GetMethod("get_terrainData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_terrainData_0);
            args = new Type[]{typeof(UnityEngine.TerrainData)};
            method = type.GetMethod("set_terrainData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_terrainData_1);
            args = new Type[]{};
            method = type.GetMethod("get_treeDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_treeDistance_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_treeDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_treeDistance_3);
            args = new Type[]{};
            method = type.GetMethod("get_treeBillboardDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_treeBillboardDistance_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_treeBillboardDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_treeBillboardDistance_5);
            args = new Type[]{};
            method = type.GetMethod("get_treeCrossFadeLength", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_treeCrossFadeLength_6);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_treeCrossFadeLength", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_treeCrossFadeLength_7);
            args = new Type[]{};
            method = type.GetMethod("get_treeMaximumFullLODCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_treeMaximumFullLODCount_8);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_treeMaximumFullLODCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_treeMaximumFullLODCount_9);
            args = new Type[]{};
            method = type.GetMethod("get_detailObjectDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_detailObjectDistance_10);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_detailObjectDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_detailObjectDistance_11);
            args = new Type[]{};
            method = type.GetMethod("get_detailObjectDensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_detailObjectDensity_12);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_detailObjectDensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_detailObjectDensity_13);
            args = new Type[]{};
            method = type.GetMethod("get_heightmapPixelError", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_heightmapPixelError_14);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_heightmapPixelError", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_heightmapPixelError_15);
            args = new Type[]{};
            method = type.GetMethod("get_heightmapMaximumLOD", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_heightmapMaximumLOD_16);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_heightmapMaximumLOD", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_heightmapMaximumLOD_17);
            args = new Type[]{};
            method = type.GetMethod("get_basemapDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_basemapDistance_18);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_basemapDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_basemapDistance_19);
            args = new Type[]{};
            method = type.GetMethod("get_lightmapIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lightmapIndex_20);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_lightmapIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lightmapIndex_21);
            args = new Type[]{};
            method = type.GetMethod("get_realtimeLightmapIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_realtimeLightmapIndex_22);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_realtimeLightmapIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_realtimeLightmapIndex_23);
            args = new Type[]{};
            method = type.GetMethod("get_lightmapScaleOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lightmapScaleOffset_24);
            args = new Type[]{typeof(UnityEngine.Vector4)};
            method = type.GetMethod("set_lightmapScaleOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lightmapScaleOffset_25);
            args = new Type[]{};
            method = type.GetMethod("get_realtimeLightmapScaleOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_realtimeLightmapScaleOffset_26);
            args = new Type[]{typeof(UnityEngine.Vector4)};
            method = type.GetMethod("set_realtimeLightmapScaleOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_realtimeLightmapScaleOffset_27);
            args = new Type[]{};
            method = type.GetMethod("get_castShadows", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_castShadows_28);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_castShadows", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_castShadows_29);
            args = new Type[]{};
            method = type.GetMethod("get_reflectionProbeUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_reflectionProbeUsage_30);
            args = new Type[]{typeof(UnityEngine.Rendering.ReflectionProbeUsage)};
            method = type.GetMethod("set_reflectionProbeUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_reflectionProbeUsage_31);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo>)};
            method = type.GetMethod("GetClosestReflectionProbes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetClosestReflectionProbes_32);
            args = new Type[]{};
            method = type.GetMethod("get_materialType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_materialType_33);
            args = new Type[]{typeof(UnityEngine.Terrain.MaterialType)};
            method = type.GetMethod("set_materialType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_materialType_34);
            args = new Type[]{};
            method = type.GetMethod("get_materialTemplate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_materialTemplate_35);
            args = new Type[]{typeof(UnityEngine.Material)};
            method = type.GetMethod("set_materialTemplate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_materialTemplate_36);
            args = new Type[]{};
            method = type.GetMethod("get_legacySpecular", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_legacySpecular_37);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("set_legacySpecular", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_legacySpecular_38);
            args = new Type[]{};
            method = type.GetMethod("get_legacyShininess", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_legacyShininess_39);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_legacyShininess", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_legacyShininess_40);
            args = new Type[]{};
            method = type.GetMethod("get_drawHeightmap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_drawHeightmap_41);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_drawHeightmap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_drawHeightmap_42);
            args = new Type[]{};
            method = type.GetMethod("get_drawTreesAndFoliage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_drawTreesAndFoliage_43);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_drawTreesAndFoliage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_drawTreesAndFoliage_44);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("SampleHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SampleHeight_45);
            args = new Type[]{};
            method = type.GetMethod("ApplyDelayedHeightmapModification", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ApplyDelayedHeightmapModification_46);
            args = new Type[]{typeof(UnityEngine.TreeInstance)};
            method = type.GetMethod("AddTreeInstance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddTreeInstance_47);
            args = new Type[]{typeof(UnityEngine.Terrain), typeof(UnityEngine.Terrain), typeof(UnityEngine.Terrain), typeof(UnityEngine.Terrain)};
            method = type.GetMethod("SetNeighbors", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetNeighbors_48);
            args = new Type[]{};
            method = type.GetMethod("get_treeLODBiasMultiplier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_treeLODBiasMultiplier_49);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_treeLODBiasMultiplier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_treeLODBiasMultiplier_50);
            args = new Type[]{};
            method = type.GetMethod("get_collectDetailPatches", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_collectDetailPatches_51);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_collectDetailPatches", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_collectDetailPatches_52);
            args = new Type[]{};
            method = type.GetMethod("get_editorRenderFlags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_editorRenderFlags_53);
            args = new Type[]{typeof(UnityEngine.TerrainRenderFlags)};
            method = type.GetMethod("set_editorRenderFlags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_editorRenderFlags_54);
            args = new Type[]{};
            method = type.GetMethod("GetPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPosition_55);
            args = new Type[]{};
            method = type.GetMethod("Flush", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Flush_56);
            args = new Type[]{typeof(UnityEngine.MaterialPropertyBlock)};
            method = type.GetMethod("SetSplatMaterialPropertyBlock", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetSplatMaterialPropertyBlock_57);
            args = new Type[]{typeof(UnityEngine.MaterialPropertyBlock)};
            method = type.GetMethod("GetSplatMaterialPropertyBlock", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSplatMaterialPropertyBlock_58);
            args = new Type[]{};
            method = type.GetMethod("get_activeTerrain", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_activeTerrain_59);
            args = new Type[]{};
            method = type.GetMethod("get_activeTerrains", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_activeTerrains_60);
            args = new Type[]{typeof(UnityEngine.TerrainData)};
            method = type.GetMethod("CreateTerrainGameObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateTerrainGameObject_61);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Terrain());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Terrain[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_terrainData_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.terrainData;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_terrainData_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TerrainData value = (UnityEngine.TerrainData)typeof(UnityEngine.TerrainData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.terrainData = value;

            return __ret;
        }

        static StackObject* get_treeDistance_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.treeDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_treeDistance_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.treeDistance = value;

            return __ret;
        }

        static StackObject* get_treeBillboardDistance_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.treeBillboardDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_treeBillboardDistance_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.treeBillboardDistance = value;

            return __ret;
        }

        static StackObject* get_treeCrossFadeLength_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.treeCrossFadeLength;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_treeCrossFadeLength_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.treeCrossFadeLength = value;

            return __ret;
        }

        static StackObject* get_treeMaximumFullLODCount_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.treeMaximumFullLODCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_treeMaximumFullLODCount_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.treeMaximumFullLODCount = value;

            return __ret;
        }

        static StackObject* get_detailObjectDistance_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.detailObjectDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_detailObjectDistance_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.detailObjectDistance = value;

            return __ret;
        }

        static StackObject* get_detailObjectDensity_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.detailObjectDensity;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_detailObjectDensity_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.detailObjectDensity = value;

            return __ret;
        }

        static StackObject* get_heightmapPixelError_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.heightmapPixelError;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_heightmapPixelError_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.heightmapPixelError = value;

            return __ret;
        }

        static StackObject* get_heightmapMaximumLOD_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.heightmapMaximumLOD;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_heightmapMaximumLOD_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.heightmapMaximumLOD = value;

            return __ret;
        }

        static StackObject* get_basemapDistance_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.basemapDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_basemapDistance_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.basemapDistance = value;

            return __ret;
        }

        static StackObject* get_lightmapIndex_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lightmapIndex;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_lightmapIndex_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.lightmapIndex = value;

            return __ret;
        }

        static StackObject* get_realtimeLightmapIndex_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.realtimeLightmapIndex;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_realtimeLightmapIndex_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.realtimeLightmapIndex = value;

            return __ret;
        }

        static StackObject* get_lightmapScaleOffset_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lightmapScaleOffset;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_lightmapScaleOffset_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4 value = (UnityEngine.Vector4)typeof(UnityEngine.Vector4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.lightmapScaleOffset = value;

            return __ret;
        }

        static StackObject* get_realtimeLightmapScaleOffset_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.realtimeLightmapScaleOffset;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_realtimeLightmapScaleOffset_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4 value = (UnityEngine.Vector4)typeof(UnityEngine.Vector4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.realtimeLightmapScaleOffset = value;

            return __ret;
        }

        static StackObject* get_castShadows_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.castShadows;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_castShadows_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.castShadows = value;

            return __ret;
        }

        static StackObject* get_reflectionProbeUsage_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.reflectionProbeUsage;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_reflectionProbeUsage_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ReflectionProbeUsage value = (UnityEngine.Rendering.ReflectionProbeUsage)typeof(UnityEngine.Rendering.ReflectionProbeUsage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.reflectionProbeUsage = value;

            return __ret;
        }

        static StackObject* GetClosestReflectionProbes_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo> result = (System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo>)typeof(System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetClosestReflectionProbes(result);

            return __ret;
        }

        static StackObject* get_materialType_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.materialType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_materialType_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain.MaterialType value = (UnityEngine.Terrain.MaterialType)typeof(UnityEngine.Terrain.MaterialType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.materialType = value;

            return __ret;
        }

        static StackObject* get_materialTemplate_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.materialTemplate;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_materialTemplate_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material value = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.materialTemplate = value;

            return __ret;
        }

        static StackObject* get_legacySpecular_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.legacySpecular;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_legacySpecular_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.legacySpecular = value;

            return __ret;
        }

        static StackObject* get_legacyShininess_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.legacyShininess;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_legacyShininess_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.legacyShininess = value;

            return __ret;
        }

        static StackObject* get_drawHeightmap_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.drawHeightmap;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_drawHeightmap_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.drawHeightmap = value;

            return __ret;
        }

        static StackObject* get_drawTreesAndFoliage_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.drawTreesAndFoliage;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_drawTreesAndFoliage_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.drawTreesAndFoliage = value;

            return __ret;
        }

        static StackObject* SampleHeight_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 worldPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SampleHeight(worldPosition);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* ApplyDelayedHeightmapModification_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ApplyDelayedHeightmapModification();

            return __ret;
        }

        static StackObject* AddTreeInstance_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TreeInstance instance = (UnityEngine.TreeInstance)typeof(UnityEngine.TreeInstance).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddTreeInstance(instance);

            return __ret;
        }

        static StackObject* SetNeighbors_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain bottom = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain right = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Terrain top = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Terrain left = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetNeighbors(left, top, right, bottom);

            return __ret;
        }

        static StackObject* get_treeLODBiasMultiplier_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.treeLODBiasMultiplier;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_treeLODBiasMultiplier_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.treeLODBiasMultiplier = value;

            return __ret;
        }

        static StackObject* get_collectDetailPatches_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.collectDetailPatches;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_collectDetailPatches_52(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.collectDetailPatches = value;

            return __ret;
        }

        static StackObject* get_editorRenderFlags_53(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.editorRenderFlags;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_editorRenderFlags_54(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TerrainRenderFlags value = (UnityEngine.TerrainRenderFlags)typeof(UnityEngine.TerrainRenderFlags).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.editorRenderFlags = value;

            return __ret;
        }

        static StackObject* GetPosition_55(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPosition();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Flush_56(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Flush();

            return __ret;
        }

        static StackObject* SetSplatMaterialPropertyBlock_57(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetSplatMaterialPropertyBlock(properties);

            return __ret;
        }

        static StackObject* GetSplatMaterialPropertyBlock_58(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.MaterialPropertyBlock dest = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Terrain instance_of_this_method;
            instance_of_this_method = (UnityEngine.Terrain)typeof(UnityEngine.Terrain).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetSplatMaterialPropertyBlock(dest);

            return __ret;
        }

        static StackObject* get_activeTerrain_59(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Terrain.activeTerrain;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_activeTerrains_60(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Terrain.activeTerrains;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateTerrainGameObject_61(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TerrainData assignTerrain = (UnityEngine.TerrainData)typeof(UnityEngine.TerrainData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.Terrain.CreateTerrainGameObject(assignTerrain);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Terrain();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
