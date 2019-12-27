
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
using System.Linq;
namespace CSHotFix.Runtime.Generated
{
    unsafe class UnityEngine_ReflectionProbe_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.ReflectionProbe);
            args = new Type[]{};
            method = type.GetMethod("get_size", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_size_0);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_size", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_size_1);
            args = new Type[]{};
            method = type.GetMethod("get_center", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_center_2);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_center", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_center_3);
            args = new Type[]{};
            method = type.GetMethod("get_nearClipPlane", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_nearClipPlane_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_nearClipPlane", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_nearClipPlane_5);
            args = new Type[]{};
            method = type.GetMethod("get_farClipPlane", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_farClipPlane_6);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_farClipPlane", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_farClipPlane_7);
            args = new Type[]{};
            method = type.GetMethod("get_intensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_intensity_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_intensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_intensity_9);
            args = new Type[]{};
            method = type.GetMethod("get_bounds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_bounds_10);
            args = new Type[]{};
            method = type.GetMethod("get_hdr", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hdr_11);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_hdr", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hdr_12);
            args = new Type[]{};
            method = type.GetMethod("get_shadowDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowDistance_13);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_shadowDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowDistance_14);
            args = new Type[]{};
            method = type.GetMethod("get_resolution", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_resolution_15);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_resolution", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_resolution_16);
            args = new Type[]{};
            method = type.GetMethod("get_cullingMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cullingMask_17);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_cullingMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_cullingMask_18);
            args = new Type[]{};
            method = type.GetMethod("get_clearFlags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_clearFlags_19);
            args = new Type[]{typeof(UnityEngine.Rendering.ReflectionProbeClearFlags)};
            method = type.GetMethod("set_clearFlags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_clearFlags_20);
            args = new Type[]{};
            method = type.GetMethod("get_backgroundColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_backgroundColor_21);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("set_backgroundColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_backgroundColor_22);
            args = new Type[]{};
            method = type.GetMethod("get_blendDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_blendDistance_23);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_blendDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_blendDistance_24);
            args = new Type[]{};
            method = type.GetMethod("get_boxProjection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_boxProjection_25);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_boxProjection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_boxProjection_26);
            args = new Type[]{};
            method = type.GetMethod("get_mode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mode_27);
            args = new Type[]{typeof(UnityEngine.Rendering.ReflectionProbeMode)};
            method = type.GetMethod("set_mode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_mode_28);
            args = new Type[]{};
            method = type.GetMethod("get_importance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_importance_29);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_importance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_importance_30);
            args = new Type[]{};
            method = type.GetMethod("get_refreshMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_refreshMode_31);
            args = new Type[]{typeof(UnityEngine.Rendering.ReflectionProbeRefreshMode)};
            method = type.GetMethod("set_refreshMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_refreshMode_32);
            args = new Type[]{};
            method = type.GetMethod("get_timeSlicingMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_timeSlicingMode_33);
            args = new Type[]{typeof(UnityEngine.Rendering.ReflectionProbeTimeSlicingMode)};
            method = type.GetMethod("set_timeSlicingMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_timeSlicingMode_34);
            args = new Type[]{};
            method = type.GetMethod("get_bakedTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_bakedTexture_35);
            args = new Type[]{typeof(UnityEngine.Texture)};
            method = type.GetMethod("set_bakedTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_bakedTexture_36);
            args = new Type[]{};
            method = type.GetMethod("get_customBakedTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_customBakedTexture_37);
            args = new Type[]{typeof(UnityEngine.Texture)};
            method = type.GetMethod("set_customBakedTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_customBakedTexture_38);
            args = new Type[]{};
            method = type.GetMethod("get_realtimeTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_realtimeTexture_39);
            args = new Type[]{typeof(UnityEngine.RenderTexture)};
            method = type.GetMethod("set_realtimeTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_realtimeTexture_40);
            args = new Type[]{};
            method = type.GetMethod("get_texture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_texture_41);
            args = new Type[]{};
            method = type.GetMethod("get_textureHDRDecodeValues", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_textureHDRDecodeValues_42);
            args = new Type[]{};
            method = type.GetMethod("Reset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Reset_43);
            args = new Type[]{};
            method = type.GetMethod("RenderProbe", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RenderProbe_44);
            args = new Type[]{typeof(UnityEngine.RenderTexture)};
            method = type.GetMethod("RenderProbe", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RenderProbe_45);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("IsFinishedRendering", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsFinishedRendering_46);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.Texture), typeof(System.Single), typeof(UnityEngine.RenderTexture)};
            method = type.GetMethod("BlendCubemap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BlendCubemap_47);
            args = new Type[]{};
            method = type.GetMethod("get_minBakedCubemapResolution", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_minBakedCubemapResolution_48);
            args = new Type[]{};
            method = type.GetMethod("get_maxBakedCubemapResolution", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxBakedCubemapResolution_49);
            args = new Type[]{};
            method = type.GetMethod("get_defaultTextureHDRDecodeValues", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_defaultTextureHDRDecodeValues_50);
            args = new Type[]{};
            method = type.GetMethod("get_defaultTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_defaultTexture_51);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ReflectionProbe());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ReflectionProbe[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_size_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.size;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_size_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.size = value;

            return __ret;
        }

        static StackObject* get_center_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.center;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_center_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.center = value;

            return __ret;
        }

        static StackObject* get_nearClipPlane_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.nearClipPlane;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_nearClipPlane_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.nearClipPlane = value;

            return __ret;
        }

        static StackObject* get_farClipPlane_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.farClipPlane;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_farClipPlane_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.farClipPlane = value;

            return __ret;
        }

        static StackObject* get_intensity_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.intensity;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_intensity_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.intensity = value;

            return __ret;
        }

        static StackObject* get_bounds_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.bounds;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_hdr_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hdr;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_hdr_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hdr = value;

            return __ret;
        }

        static StackObject* get_shadowDistance_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.shadowDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_shadowDistance_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.shadowDistance = value;

            return __ret;
        }

        static StackObject* get_resolution_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.resolution;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_resolution_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.resolution = value;

            return __ret;
        }

        static StackObject* get_cullingMask_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.cullingMask;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_cullingMask_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.cullingMask = value;

            return __ret;
        }

        static StackObject* get_clearFlags_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.clearFlags;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_clearFlags_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ReflectionProbeClearFlags @value = (UnityEngine.Rendering.ReflectionProbeClearFlags)typeof(UnityEngine.Rendering.ReflectionProbeClearFlags).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.clearFlags = value;

            return __ret;
        }

        static StackObject* get_backgroundColor_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.backgroundColor;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_backgroundColor_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.backgroundColor = value;

            return __ret;
        }

        static StackObject* get_blendDistance_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.blendDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_blendDistance_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.blendDistance = value;

            return __ret;
        }

        static StackObject* get_boxProjection_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.boxProjection;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_boxProjection_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.boxProjection = value;

            return __ret;
        }

        static StackObject* get_mode_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.mode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_mode_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ReflectionProbeMode @value = (UnityEngine.Rendering.ReflectionProbeMode)typeof(UnityEngine.Rendering.ReflectionProbeMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.mode = value;

            return __ret;
        }

        static StackObject* get_importance_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.importance;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_importance_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.importance = value;

            return __ret;
        }

        static StackObject* get_refreshMode_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.refreshMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_refreshMode_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ReflectionProbeRefreshMode @value = (UnityEngine.Rendering.ReflectionProbeRefreshMode)typeof(UnityEngine.Rendering.ReflectionProbeRefreshMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.refreshMode = value;

            return __ret;
        }

        static StackObject* get_timeSlicingMode_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.timeSlicingMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_timeSlicingMode_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ReflectionProbeTimeSlicingMode @value = (UnityEngine.Rendering.ReflectionProbeTimeSlicingMode)typeof(UnityEngine.Rendering.ReflectionProbeTimeSlicingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.timeSlicingMode = value;

            return __ret;
        }

        static StackObject* get_bakedTexture_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.bakedTexture;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_bakedTexture_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture @value = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.bakedTexture = value;

            return __ret;
        }

        static StackObject* get_customBakedTexture_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.customBakedTexture;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_customBakedTexture_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture @value = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.customBakedTexture = value;

            return __ret;
        }

        static StackObject* get_realtimeTexture_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.realtimeTexture;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_realtimeTexture_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderTexture @value = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.realtimeTexture = value;

            return __ret;
        }

        static StackObject* get_texture_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.texture;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_textureHDRDecodeValues_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.textureHDRDecodeValues;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Reset_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Reset();

            return __ret;
        }

        static StackObject* RenderProbe_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.RenderProbe();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* RenderProbe_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderTexture @targetTexture = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.RenderProbe(@targetTexture);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* IsFinishedRendering_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @renderId = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ReflectionProbe instance_of_this_method = (UnityEngine.ReflectionProbe)typeof(UnityEngine.ReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsFinishedRendering(@renderId);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* BlendCubemap_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderTexture @target = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @blend = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Texture @dst = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Texture @src = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.ReflectionProbe.BlendCubemap(@src, @dst, @blend, @target);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_minBakedCubemapResolution_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.ReflectionProbe.minBakedCubemapResolution;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_maxBakedCubemapResolution_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.ReflectionProbe.maxBakedCubemapResolution;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_defaultTextureHDRDecodeValues_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.ReflectionProbe.defaultTextureHDRDecodeValues;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_defaultTexture_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.ReflectionProbe.defaultTexture;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.ReflectionProbe();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
