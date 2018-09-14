
#if CSHotFix
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
    unsafe class UnityEngine_QualitySettings_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.QualitySettings);
            args = new Type[]{};
            method = type.GetMethod("get_names", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_names_0);
            args = new Type[]{};
            method = type.GetMethod("GetQualityLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetQualityLevel_1);
            args = new Type[]{typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("SetQualityLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetQualityLevel_2);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("SetQualityLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetQualityLevel_3);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("IncreaseLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IncreaseLevel_4);
            args = new Type[]{};
            method = type.GetMethod("IncreaseLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IncreaseLevel_5);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("DecreaseLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DecreaseLevel_6);
            args = new Type[]{};
            method = type.GetMethod("DecreaseLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DecreaseLevel_7);
            args = new Type[]{};
            method = type.GetMethod("get_shadowCascade4Split", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowCascade4Split_8);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_shadowCascade4Split", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowCascade4Split_9);
            args = new Type[]{};
            method = type.GetMethod("get_anisotropicFiltering", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_anisotropicFiltering_10);
            args = new Type[]{typeof(UnityEngine.AnisotropicFiltering)};
            method = type.GetMethod("set_anisotropicFiltering", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_anisotropicFiltering_11);
            args = new Type[]{};
            method = type.GetMethod("get_maxQueuedFrames", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxQueuedFrames_12);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_maxQueuedFrames", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxQueuedFrames_13);
            args = new Type[]{};
            method = type.GetMethod("get_blendWeights", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_blendWeights_14);
            args = new Type[]{typeof(UnityEngine.BlendWeights)};
            method = type.GetMethod("set_blendWeights", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_blendWeights_15);
            args = new Type[]{};
            method = type.GetMethod("get_pixelLightCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pixelLightCount_16);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_pixelLightCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_pixelLightCount_17);
            args = new Type[]{};
            method = type.GetMethod("get_shadows", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadows_18);
            args = new Type[]{typeof(UnityEngine.ShadowQuality)};
            method = type.GetMethod("set_shadows", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadows_19);
            args = new Type[]{};
            method = type.GetMethod("get_shadowProjection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowProjection_20);
            args = new Type[]{typeof(UnityEngine.ShadowProjection)};
            method = type.GetMethod("set_shadowProjection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowProjection_21);
            args = new Type[]{};
            method = type.GetMethod("get_shadowCascades", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowCascades_22);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_shadowCascades", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowCascades_23);
            args = new Type[]{};
            method = type.GetMethod("get_shadowDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowDistance_24);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_shadowDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowDistance_25);
            args = new Type[]{};
            method = type.GetMethod("get_shadowResolution", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowResolution_26);
            args = new Type[]{typeof(UnityEngine.ShadowResolution)};
            method = type.GetMethod("set_shadowResolution", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowResolution_27);
            args = new Type[]{};
            method = type.GetMethod("get_shadowmaskMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowmaskMode_28);
            args = new Type[]{typeof(UnityEngine.ShadowmaskMode)};
            method = type.GetMethod("set_shadowmaskMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowmaskMode_29);
            args = new Type[]{};
            method = type.GetMethod("get_shadowNearPlaneOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowNearPlaneOffset_30);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_shadowNearPlaneOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowNearPlaneOffset_31);
            args = new Type[]{};
            method = type.GetMethod("get_shadowCascade2Split", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowCascade2Split_32);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_shadowCascade2Split", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowCascade2Split_33);
            args = new Type[]{};
            method = type.GetMethod("get_lodBias", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lodBias_34);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_lodBias", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lodBias_35);
            args = new Type[]{};
            method = type.GetMethod("get_masterTextureLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_masterTextureLimit_36);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_masterTextureLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_masterTextureLimit_37);
            args = new Type[]{};
            method = type.GetMethod("get_maximumLODLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maximumLODLevel_38);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_maximumLODLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maximumLODLevel_39);
            args = new Type[]{};
            method = type.GetMethod("get_particleRaycastBudget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_particleRaycastBudget_40);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_particleRaycastBudget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_particleRaycastBudget_41);
            args = new Type[]{};
            method = type.GetMethod("get_softParticles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_softParticles_42);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_softParticles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_softParticles_43);
            args = new Type[]{};
            method = type.GetMethod("get_softVegetation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_softVegetation_44);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_softVegetation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_softVegetation_45);
            args = new Type[]{};
            method = type.GetMethod("get_vSyncCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_vSyncCount_46);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_vSyncCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_vSyncCount_47);
            args = new Type[]{};
            method = type.GetMethod("get_antiAliasing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_antiAliasing_48);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_antiAliasing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_antiAliasing_49);
            args = new Type[]{};
            method = type.GetMethod("get_asyncUploadTimeSlice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_asyncUploadTimeSlice_50);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_asyncUploadTimeSlice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_asyncUploadTimeSlice_51);
            args = new Type[]{};
            method = type.GetMethod("get_asyncUploadBufferSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_asyncUploadBufferSize_52);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_asyncUploadBufferSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_asyncUploadBufferSize_53);
            args = new Type[]{};
            method = type.GetMethod("get_realtimeReflectionProbes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_realtimeReflectionProbes_54);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_realtimeReflectionProbes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_realtimeReflectionProbes_55);
            args = new Type[]{};
            method = type.GetMethod("get_billboardsFaceCameraPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_billboardsFaceCameraPosition_56);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_billboardsFaceCameraPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_billboardsFaceCameraPosition_57);
            args = new Type[]{};
            method = type.GetMethod("get_resolutionScalingFixedDPIFactor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_resolutionScalingFixedDPIFactor_58);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_resolutionScalingFixedDPIFactor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_resolutionScalingFixedDPIFactor_59);
            args = new Type[]{};
            method = type.GetMethod("get_desiredColorSpace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_desiredColorSpace_60);
            args = new Type[]{};
            method = type.GetMethod("get_activeColorSpace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_activeColorSpace_61);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.QualitySettings());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.QualitySettings[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_names_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.names;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetQualityLevel_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.GetQualityLevel();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetQualityLevel_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @applyExpensiveChanges = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @index = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.SetQualityLevel(@index, @applyExpensiveChanges);

            return __ret;
        }

        static StackObject* SetQualityLevel_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @index = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.SetQualityLevel(@index);

            return __ret;
        }

        static StackObject* IncreaseLevel_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @applyExpensiveChanges = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.IncreaseLevel(@applyExpensiveChanges);

            return __ret;
        }

        static StackObject* IncreaseLevel_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.QualitySettings.IncreaseLevel();

            return __ret;
        }

        static StackObject* DecreaseLevel_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @applyExpensiveChanges = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.DecreaseLevel(@applyExpensiveChanges);

            return __ret;
        }

        static StackObject* DecreaseLevel_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.QualitySettings.DecreaseLevel();

            return __ret;
        }

        static StackObject* get_shadowCascade4Split_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowCascade4Split;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_shadowCascade4Split_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.shadowCascade4Split = value;

            return __ret;
        }

        static StackObject* get_anisotropicFiltering_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.anisotropicFiltering;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_anisotropicFiltering_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnisotropicFiltering @value = (UnityEngine.AnisotropicFiltering)typeof(UnityEngine.AnisotropicFiltering).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.anisotropicFiltering = value;

            return __ret;
        }

        static StackObject* get_maxQueuedFrames_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.maxQueuedFrames;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxQueuedFrames_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.maxQueuedFrames = value;

            return __ret;
        }

        static StackObject* get_blendWeights_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.blendWeights;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_blendWeights_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.BlendWeights @value = (UnityEngine.BlendWeights)typeof(UnityEngine.BlendWeights).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.blendWeights = value;

            return __ret;
        }

        static StackObject* get_pixelLightCount_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.pixelLightCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_pixelLightCount_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.pixelLightCount = value;

            return __ret;
        }

        static StackObject* get_shadows_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadows;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_shadows_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ShadowQuality @value = (UnityEngine.ShadowQuality)typeof(UnityEngine.ShadowQuality).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.shadows = value;

            return __ret;
        }

        static StackObject* get_shadowProjection_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowProjection;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_shadowProjection_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ShadowProjection @value = (UnityEngine.ShadowProjection)typeof(UnityEngine.ShadowProjection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.shadowProjection = value;

            return __ret;
        }

        static StackObject* get_shadowCascades_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowCascades;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_shadowCascades_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.shadowCascades = value;

            return __ret;
        }

        static StackObject* get_shadowDistance_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_shadowDistance_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.shadowDistance = value;

            return __ret;
        }

        static StackObject* get_shadowResolution_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowResolution;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_shadowResolution_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ShadowResolution @value = (UnityEngine.ShadowResolution)typeof(UnityEngine.ShadowResolution).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.shadowResolution = value;

            return __ret;
        }

        static StackObject* get_shadowmaskMode_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowmaskMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_shadowmaskMode_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ShadowmaskMode @value = (UnityEngine.ShadowmaskMode)typeof(UnityEngine.ShadowmaskMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.shadowmaskMode = value;

            return __ret;
        }

        static StackObject* get_shadowNearPlaneOffset_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowNearPlaneOffset;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_shadowNearPlaneOffset_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.shadowNearPlaneOffset = value;

            return __ret;
        }

        static StackObject* get_shadowCascade2Split_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowCascade2Split;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_shadowCascade2Split_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.shadowCascade2Split = value;

            return __ret;
        }

        static StackObject* get_lodBias_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.lodBias;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_lodBias_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.lodBias = value;

            return __ret;
        }

        static StackObject* get_masterTextureLimit_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.masterTextureLimit;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_masterTextureLimit_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.masterTextureLimit = value;

            return __ret;
        }

        static StackObject* get_maximumLODLevel_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.maximumLODLevel;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maximumLODLevel_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.maximumLODLevel = value;

            return __ret;
        }

        static StackObject* get_particleRaycastBudget_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.particleRaycastBudget;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_particleRaycastBudget_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.particleRaycastBudget = value;

            return __ret;
        }

        static StackObject* get_softParticles_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.softParticles;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_softParticles_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.softParticles = value;

            return __ret;
        }

        static StackObject* get_softVegetation_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.softVegetation;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_softVegetation_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.softVegetation = value;

            return __ret;
        }

        static StackObject* get_vSyncCount_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.vSyncCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_vSyncCount_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.vSyncCount = value;

            return __ret;
        }

        static StackObject* get_antiAliasing_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.antiAliasing;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_antiAliasing_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.antiAliasing = value;

            return __ret;
        }

        static StackObject* get_asyncUploadTimeSlice_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.asyncUploadTimeSlice;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_asyncUploadTimeSlice_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.asyncUploadTimeSlice = value;

            return __ret;
        }

        static StackObject* get_asyncUploadBufferSize_52(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.asyncUploadBufferSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_asyncUploadBufferSize_53(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.asyncUploadBufferSize = value;

            return __ret;
        }

        static StackObject* get_realtimeReflectionProbes_54(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.realtimeReflectionProbes;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_realtimeReflectionProbes_55(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.realtimeReflectionProbes = value;

            return __ret;
        }

        static StackObject* get_billboardsFaceCameraPosition_56(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.billboardsFaceCameraPosition;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_billboardsFaceCameraPosition_57(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.billboardsFaceCameraPosition = value;

            return __ret;
        }

        static StackObject* get_resolutionScalingFixedDPIFactor_58(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.resolutionScalingFixedDPIFactor;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_resolutionScalingFixedDPIFactor_59(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.resolutionScalingFixedDPIFactor = value;

            return __ret;
        }

        static StackObject* get_desiredColorSpace_60(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.desiredColorSpace;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_activeColorSpace_61(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.activeColorSpace;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.QualitySettings();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
