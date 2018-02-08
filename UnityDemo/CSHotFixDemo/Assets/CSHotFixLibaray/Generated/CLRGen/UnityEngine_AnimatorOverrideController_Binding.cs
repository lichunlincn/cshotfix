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
    unsafe class UnityEngine_AnimatorOverrideController_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.AnimatorOverrideController);
            args = new Type[]{};
            method = type.GetMethod("get_runtimeAnimatorController", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_runtimeAnimatorController_0);
            args = new Type[]{typeof(UnityEngine.RuntimeAnimatorController)};
            method = type.GetMethod("set_runtimeAnimatorController", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_runtimeAnimatorController_1);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("get_Item", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Item_2);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.AnimationClip)};
            method = type.GetMethod("set_Item", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Item_3);
            args = new Type[]{typeof(UnityEngine.AnimationClip)};
            method = type.GetMethod("get_Item", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Item_4);
            args = new Type[]{typeof(UnityEngine.AnimationClip), typeof(UnityEngine.AnimationClip)};
            method = type.GetMethod("set_Item", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Item_5);
            args = new Type[]{};
            method = type.GetMethod("get_overridesCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_overridesCount_6);
            args = new Type[]{typeof(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>)};
            method = type.GetMethod("GetOverrides", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetOverrides_7);
            args = new Type[]{typeof(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>)};
            method = type.GetMethod("ApplyOverrides", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ApplyOverrides_8);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.AnimatorOverrideController());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AnimatorOverrideController[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(UnityEngine.RuntimeAnimatorController)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);

        }


        static StackObject* get_runtimeAnimatorController_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnimatorOverrideController instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimatorOverrideController)typeof(UnityEngine.AnimatorOverrideController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.runtimeAnimatorController;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_runtimeAnimatorController_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RuntimeAnimatorController value = (UnityEngine.RuntimeAnimatorController)typeof(UnityEngine.RuntimeAnimatorController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimatorOverrideController instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimatorOverrideController)typeof(UnityEngine.AnimatorOverrideController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.runtimeAnimatorController = value;

            return __ret;
        }

        static StackObject* get_Item_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimatorOverrideController instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimatorOverrideController)typeof(UnityEngine.AnimatorOverrideController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method[name];

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_Item_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnimationClip value = (UnityEngine.AnimationClip)typeof(UnityEngine.AnimationClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AnimatorOverrideController instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimatorOverrideController)typeof(UnityEngine.AnimatorOverrideController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method[name] = value;

            return __ret;
        }

        static StackObject* get_Item_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnimationClip clip = (UnityEngine.AnimationClip)typeof(UnityEngine.AnimationClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimatorOverrideController instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimatorOverrideController)typeof(UnityEngine.AnimatorOverrideController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method[clip];

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_Item_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnimationClip value = (UnityEngine.AnimationClip)typeof(UnityEngine.AnimationClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimationClip clip = (UnityEngine.AnimationClip)typeof(UnityEngine.AnimationClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AnimatorOverrideController instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimatorOverrideController)typeof(UnityEngine.AnimatorOverrideController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method[clip] = value;

            return __ret;
        }

        static StackObject* get_overridesCount_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnimatorOverrideController instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimatorOverrideController)typeof(UnityEngine.AnimatorOverrideController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.overridesCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetOverrides_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>> overrides = (System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>)typeof(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimatorOverrideController instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimatorOverrideController)typeof(UnityEngine.AnimatorOverrideController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetOverrides(overrides);

            return __ret;
        }

        static StackObject* ApplyOverrides_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>> overrides = (System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>)typeof(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimatorOverrideController instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimatorOverrideController)typeof(UnityEngine.AnimatorOverrideController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ApplyOverrides(overrides);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.AnimatorOverrideController();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RuntimeAnimatorController controller = (UnityEngine.RuntimeAnimatorController)typeof(UnityEngine.RuntimeAnimatorController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new UnityEngine.AnimatorOverrideController(controller);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
