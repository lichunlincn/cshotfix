
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
    unsafe class UnityEngine_ProceduralMaterial_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ProceduralMaterial);
            args = new Type[]{};
            method = type.GetMethod("GetProceduralPropertyDescriptions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetProceduralPropertyDescriptions_0);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("HasProceduralProperty", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HasProceduralProperty_1);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetProceduralBoolean", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetProceduralBoolean_2);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("IsProceduralPropertyVisible", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsProceduralPropertyVisible_3);
            args = new Type[]{typeof(System.String), typeof(System.Boolean)};
            method = type.GetMethod("SetProceduralBoolean", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetProceduralBoolean_4);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetProceduralFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetProceduralFloat_5);
            args = new Type[]{typeof(System.String), typeof(System.Single)};
            method = type.GetMethod("SetProceduralFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetProceduralFloat_6);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetProceduralVector", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetProceduralVector_7);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Vector4)};
            method = type.GetMethod("SetProceduralVector", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetProceduralVector_8);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetProceduralColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetProceduralColor_9);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Color)};
            method = type.GetMethod("SetProceduralColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetProceduralColor_10);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetProceduralEnum", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetProceduralEnum_11);
            args = new Type[]{typeof(System.String), typeof(System.Int32)};
            method = type.GetMethod("SetProceduralEnum", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetProceduralEnum_12);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetProceduralTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetProceduralTexture_13);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Texture2D)};
            method = type.GetMethod("SetProceduralTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetProceduralTexture_14);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("IsProceduralPropertyCached", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsProceduralPropertyCached_15);
            args = new Type[]{typeof(System.String), typeof(System.Boolean)};
            method = type.GetMethod("CacheProceduralProperty", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CacheProceduralProperty_16);
            args = new Type[]{};
            method = type.GetMethod("ClearCache", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearCache_17);
            args = new Type[]{};
            method = type.GetMethod("get_cacheSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cacheSize_18);
            args = new Type[]{typeof(UnityEngine.ProceduralCacheSize)};
            method = type.GetMethod("set_cacheSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_cacheSize_19);
            args = new Type[]{};
            method = type.GetMethod("get_animationUpdateRate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_animationUpdateRate_20);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_animationUpdateRate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_animationUpdateRate_21);
            args = new Type[]{};
            method = type.GetMethod("RebuildTextures", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RebuildTextures_22);
            args = new Type[]{};
            method = type.GetMethod("RebuildTexturesImmediately", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RebuildTexturesImmediately_23);
            args = new Type[]{};
            method = type.GetMethod("get_isProcessing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isProcessing_24);
            args = new Type[]{};
            method = type.GetMethod("StopRebuilds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StopRebuilds_25);
            args = new Type[]{};
            method = type.GetMethod("get_isCachedDataAvailable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isCachedDataAvailable_26);
            args = new Type[]{};
            method = type.GetMethod("get_isLoadTimeGenerated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isLoadTimeGenerated_27);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_isLoadTimeGenerated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_isLoadTimeGenerated_28);
            args = new Type[]{};
            method = type.GetMethod("get_loadingBehavior", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_loadingBehavior_29);
            args = new Type[]{};
            method = type.GetMethod("get_isSupported", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isSupported_30);
            args = new Type[]{};
            method = type.GetMethod("get_substanceProcessorUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_substanceProcessorUsage_31);
            args = new Type[]{typeof(UnityEngine.ProceduralProcessorUsage)};
            method = type.GetMethod("set_substanceProcessorUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_substanceProcessorUsage_32);
            args = new Type[]{};
            method = type.GetMethod("get_preset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_preset_33);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_preset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_preset_34);
            args = new Type[]{};
            method = type.GetMethod("GetGeneratedTextures", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGeneratedTextures_35);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetGeneratedTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGeneratedTexture_36);
            args = new Type[]{};
            method = type.GetMethod("get_isReadable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isReadable_37);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_isReadable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_isReadable_38);
            args = new Type[]{};
            method = type.GetMethod("FreezeAndReleaseSourceData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FreezeAndReleaseSourceData_39);
            args = new Type[]{};
            method = type.GetMethod("get_isFrozen", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isFrozen_40);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ProceduralMaterial[s]);


        }


        static StackObject* GetProceduralPropertyDescriptions_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetProceduralPropertyDescriptions();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* HasProceduralProperty_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String inputName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.HasProceduralProperty(inputName);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetProceduralBoolean_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String inputName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetProceduralBoolean(inputName);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsProceduralPropertyVisible_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String inputName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsProceduralPropertyVisible(inputName);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetProceduralBoolean_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String inputName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetProceduralBoolean(inputName, value);

            return __ret;
        }

        static StackObject* GetProceduralFloat_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String inputName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetProceduralFloat(inputName);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetProceduralFloat_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String inputName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetProceduralFloat(inputName, value);

            return __ret;
        }

        static StackObject* GetProceduralVector_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String inputName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetProceduralVector(inputName);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetProceduralVector_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4 value = (UnityEngine.Vector4)typeof(UnityEngine.Vector4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String inputName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetProceduralVector(inputName, value);

            return __ret;
        }

        static StackObject* GetProceduralColor_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String inputName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetProceduralColor(inputName);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetProceduralColor_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String inputName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetProceduralColor(inputName, value);

            return __ret;
        }

        static StackObject* GetProceduralEnum_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String inputName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetProceduralEnum(inputName);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetProceduralEnum_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String inputName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetProceduralEnum(inputName, value);

            return __ret;
        }

        static StackObject* GetProceduralTexture_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String inputName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetProceduralTexture(inputName);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetProceduralTexture_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture2D value = (UnityEngine.Texture2D)typeof(UnityEngine.Texture2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String inputName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetProceduralTexture(inputName, value);

            return __ret;
        }

        static StackObject* IsProceduralPropertyCached_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String inputName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsProceduralPropertyCached(inputName);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CacheProceduralProperty_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String inputName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CacheProceduralProperty(inputName, value);

            return __ret;
        }

        static StackObject* ClearCache_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClearCache();

            return __ret;
        }

        static StackObject* get_cacheSize_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.cacheSize;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_cacheSize_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ProceduralCacheSize value = (UnityEngine.ProceduralCacheSize)typeof(UnityEngine.ProceduralCacheSize).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.cacheSize = value;

            return __ret;
        }

        static StackObject* get_animationUpdateRate_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.animationUpdateRate;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_animationUpdateRate_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.animationUpdateRate = value;

            return __ret;
        }

        static StackObject* RebuildTextures_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RebuildTextures();

            return __ret;
        }

        static StackObject* RebuildTexturesImmediately_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RebuildTexturesImmediately();

            return __ret;
        }

        static StackObject* get_isProcessing_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isProcessing;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* StopRebuilds_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            UnityEngine.ProceduralMaterial.StopRebuilds();

            return __ret;
        }

        static StackObject* get_isCachedDataAvailable_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isCachedDataAvailable;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isLoadTimeGenerated_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isLoadTimeGenerated;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_isLoadTimeGenerated_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.isLoadTimeGenerated = value;

            return __ret;
        }

        static StackObject* get_loadingBehavior_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.loadingBehavior;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_isSupported_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.ProceduralMaterial.isSupported;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_substanceProcessorUsage_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.ProceduralMaterial.substanceProcessorUsage;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_substanceProcessorUsage_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ProceduralProcessorUsage value = (UnityEngine.ProceduralProcessorUsage)typeof(UnityEngine.ProceduralProcessorUsage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.ProceduralMaterial.substanceProcessorUsage = value;

            return __ret;
        }

        static StackObject* get_preset_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.preset;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_preset_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.preset = value;

            return __ret;
        }

        static StackObject* GetGeneratedTextures_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetGeneratedTextures();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGeneratedTexture_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String textureName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetGeneratedTexture(textureName);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_isReadable_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isReadable;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_isReadable_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.isReadable = value;

            return __ret;
        }

        static StackObject* FreezeAndReleaseSourceData_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.FreezeAndReleaseSourceData();

            return __ret;
        }

        static StackObject* get_isFrozen_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ProceduralMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralMaterial)typeof(UnityEngine.ProceduralMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isFrozen;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }





    }
}
