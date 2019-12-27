
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
    unsafe class UnityEngine_LightProbeProxyVolume_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.LightProbeProxyVolume);
            args = new Type[]{};
            method = type.GetMethod("get_isFeatureSupported", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isFeatureSupported_0);
            args = new Type[]{};
            method = type.GetMethod("get_boundsGlobal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_boundsGlobal_1);
            args = new Type[]{};
            method = type.GetMethod("get_sizeCustom", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sizeCustom_2);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_sizeCustom", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sizeCustom_3);
            args = new Type[]{};
            method = type.GetMethod("get_originCustom", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_originCustom_4);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_originCustom", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_originCustom_5);
            args = new Type[]{};
            method = type.GetMethod("get_probeDensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_probeDensity_6);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_probeDensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_probeDensity_7);
            args = new Type[]{};
            method = type.GetMethod("get_gridResolutionX", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_gridResolutionX_8);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_gridResolutionX", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_gridResolutionX_9);
            args = new Type[]{};
            method = type.GetMethod("get_gridResolutionY", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_gridResolutionY_10);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_gridResolutionY", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_gridResolutionY_11);
            args = new Type[]{};
            method = type.GetMethod("get_gridResolutionZ", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_gridResolutionZ_12);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_gridResolutionZ", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_gridResolutionZ_13);
            args = new Type[]{};
            method = type.GetMethod("get_boundingBoxMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_boundingBoxMode_14);
            args = new Type[]{typeof(UnityEngine.LightProbeProxyVolume.BoundingBoxMode)};
            method = type.GetMethod("set_boundingBoxMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_boundingBoxMode_15);
            args = new Type[]{};
            method = type.GetMethod("get_resolutionMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_resolutionMode_16);
            args = new Type[]{typeof(UnityEngine.LightProbeProxyVolume.ResolutionMode)};
            method = type.GetMethod("set_resolutionMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_resolutionMode_17);
            args = new Type[]{};
            method = type.GetMethod("get_probePositionMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_probePositionMode_18);
            args = new Type[]{typeof(UnityEngine.LightProbeProxyVolume.ProbePositionMode)};
            method = type.GetMethod("set_probePositionMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_probePositionMode_19);
            args = new Type[]{};
            method = type.GetMethod("get_refreshMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_refreshMode_20);
            args = new Type[]{typeof(UnityEngine.LightProbeProxyVolume.RefreshMode)};
            method = type.GetMethod("set_refreshMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_refreshMode_21);
            args = new Type[]{};
            method = type.GetMethod("get_qualityMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_qualityMode_22);
            args = new Type[]{typeof(UnityEngine.LightProbeProxyVolume.QualityMode)};
            method = type.GetMethod("set_qualityMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_qualityMode_23);
            args = new Type[]{};
            method = type.GetMethod("Update", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Update_24);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.LightProbeProxyVolume());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.LightProbeProxyVolume[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_isFeatureSupported_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.LightProbeProxyVolume.isFeatureSupported;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_boundsGlobal_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.boundsGlobal;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_sizeCustom_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sizeCustom;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_sizeCustom_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.sizeCustom = value;

            return __ret;
        }

        static StackObject* get_originCustom_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.originCustom;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_originCustom_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.originCustom = value;

            return __ret;
        }

        static StackObject* get_probeDensity_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.probeDensity;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_probeDensity_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.probeDensity = value;

            return __ret;
        }

        static StackObject* get_gridResolutionX_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.gridResolutionX;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_gridResolutionX_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.gridResolutionX = value;

            return __ret;
        }

        static StackObject* get_gridResolutionY_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.gridResolutionY;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_gridResolutionY_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.gridResolutionY = value;

            return __ret;
        }

        static StackObject* get_gridResolutionZ_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.gridResolutionZ;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_gridResolutionZ_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.gridResolutionZ = value;

            return __ret;
        }

        static StackObject* get_boundingBoxMode_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.boundingBoxMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_boundingBoxMode_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume.BoundingBoxMode @value = (UnityEngine.LightProbeProxyVolume.BoundingBoxMode)typeof(UnityEngine.LightProbeProxyVolume.BoundingBoxMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.boundingBoxMode = value;

            return __ret;
        }

        static StackObject* get_resolutionMode_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.resolutionMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_resolutionMode_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume.ResolutionMode @value = (UnityEngine.LightProbeProxyVolume.ResolutionMode)typeof(UnityEngine.LightProbeProxyVolume.ResolutionMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.resolutionMode = value;

            return __ret;
        }

        static StackObject* get_probePositionMode_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.probePositionMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_probePositionMode_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume.ProbePositionMode @value = (UnityEngine.LightProbeProxyVolume.ProbePositionMode)typeof(UnityEngine.LightProbeProxyVolume.ProbePositionMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.probePositionMode = value;

            return __ret;
        }

        static StackObject* get_refreshMode_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.refreshMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_refreshMode_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume.RefreshMode @value = (UnityEngine.LightProbeProxyVolume.RefreshMode)typeof(UnityEngine.LightProbeProxyVolume.RefreshMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.refreshMode = value;

            return __ret;
        }

        static StackObject* get_qualityMode_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.qualityMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_qualityMode_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume.QualityMode @value = (UnityEngine.LightProbeProxyVolume.QualityMode)typeof(UnityEngine.LightProbeProxyVolume.QualityMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.qualityMode = value;

            return __ret;
        }

        static StackObject* Update_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume instance_of_this_method = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Update();

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.LightProbeProxyVolume();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
