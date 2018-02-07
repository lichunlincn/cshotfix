
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
    unsafe class UnityEngine_DetailPrototype_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.DetailPrototype);
            args = new Type[]{};
            method = type.GetMethod("get_prototype", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_prototype_0);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("set_prototype", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_prototype_1);
            args = new Type[]{};
            method = type.GetMethod("get_prototypeTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_prototypeTexture_2);
            args = new Type[]{typeof(UnityEngine.Texture2D)};
            method = type.GetMethod("set_prototypeTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_prototypeTexture_3);
            args = new Type[]{};
            method = type.GetMethod("get_minWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_minWidth_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_minWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_minWidth_5);
            args = new Type[]{};
            method = type.GetMethod("get_maxWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxWidth_6);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_maxWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxWidth_7);
            args = new Type[]{};
            method = type.GetMethod("get_minHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_minHeight_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_minHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_minHeight_9);
            args = new Type[]{};
            method = type.GetMethod("get_maxHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxHeight_10);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_maxHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxHeight_11);
            args = new Type[]{};
            method = type.GetMethod("get_noiseSpread", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_noiseSpread_12);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_noiseSpread", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_noiseSpread_13);
            args = new Type[]{};
            method = type.GetMethod("get_bendFactor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_bendFactor_14);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_bendFactor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_bendFactor_15);
            args = new Type[]{};
            method = type.GetMethod("get_healthyColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_healthyColor_16);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("set_healthyColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_healthyColor_17);
            args = new Type[]{};
            method = type.GetMethod("get_dryColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_dryColor_18);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("set_dryColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_dryColor_19);
            args = new Type[]{};
            method = type.GetMethod("get_renderMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_renderMode_20);
            args = new Type[]{typeof(UnityEngine.DetailRenderMode)};
            method = type.GetMethod("set_renderMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_renderMode_21);
            args = new Type[]{};
            method = type.GetMethod("get_usePrototypeMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_usePrototypeMesh_22);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_usePrototypeMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_usePrototypeMesh_23);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.DetailPrototype());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.DetailPrototype[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_prototype_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.prototype;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_prototype_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject value = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.prototype = value;

            return __ret;
        }

        static StackObject* get_prototypeTexture_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.prototypeTexture;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_prototypeTexture_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture2D value = (UnityEngine.Texture2D)typeof(UnityEngine.Texture2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.prototypeTexture = value;

            return __ret;
        }

        static StackObject* get_minWidth_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.minWidth;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_minWidth_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.minWidth = value;

            return __ret;
        }

        static StackObject* get_maxWidth_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxWidth;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxWidth_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maxWidth = value;

            return __ret;
        }

        static StackObject* get_minHeight_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.minHeight;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_minHeight_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.minHeight = value;

            return __ret;
        }

        static StackObject* get_maxHeight_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxHeight;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxHeight_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maxHeight = value;

            return __ret;
        }

        static StackObject* get_noiseSpread_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.noiseSpread;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_noiseSpread_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.noiseSpread = value;

            return __ret;
        }

        static StackObject* get_bendFactor_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.bendFactor;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_bendFactor_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.bendFactor = value;

            return __ret;
        }

        static StackObject* get_healthyColor_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.healthyColor;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_healthyColor_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.healthyColor = value;

            return __ret;
        }

        static StackObject* get_dryColor_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.dryColor;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_dryColor_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.dryColor = value;

            return __ret;
        }

        static StackObject* get_renderMode_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.renderMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_renderMode_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.DetailRenderMode value = (UnityEngine.DetailRenderMode)typeof(UnityEngine.DetailRenderMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.renderMode = value;

            return __ret;
        }

        static StackObject* get_usePrototypeMesh_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.usePrototypeMesh;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_usePrototypeMesh_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.DetailPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.DetailPrototype)typeof(UnityEngine.DetailPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.usePrototypeMesh = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.DetailPrototype();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
