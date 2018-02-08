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
    unsafe class UnityEngine_Experimental_Director_IAnimatorControllerPlayable_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetFloat_0);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetFloat_1);
            args = new Type[]{typeof(System.String), typeof(System.Single)};
            method = type.GetMethod("SetFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetFloat_2);
            args = new Type[]{typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("SetFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetFloat_3);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetBool", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBool_4);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetBool", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBool_5);
            args = new Type[]{typeof(System.String), typeof(System.Boolean)};
            method = type.GetMethod("SetBool", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetBool_6);
            args = new Type[]{typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("SetBool", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetBool_7);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetInteger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetInteger_8);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetInteger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetInteger_9);
            args = new Type[]{typeof(System.String), typeof(System.Int32)};
            method = type.GetMethod("SetInteger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetInteger_10);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetInteger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetInteger_11);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("SetTrigger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTrigger_12);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("SetTrigger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTrigger_13);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("ResetTrigger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetTrigger_14);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("ResetTrigger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetTrigger_15);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("IsParameterControlledByCurve", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsParameterControlledByCurve_16);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("IsParameterControlledByCurve", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsParameterControlledByCurve_17);
            args = new Type[]{};
            method = type.GetMethod("get_layerCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_layerCount_18);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetLayerName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLayerName_19);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetLayerIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLayerIndex_20);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetLayerWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLayerWeight_21);
            args = new Type[]{typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("SetLayerWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLayerWeight_22);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetCurrentAnimatorStateInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCurrentAnimatorStateInfo_23);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetNextAnimatorStateInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetNextAnimatorStateInfo_24);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetAnimatorTransitionInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAnimatorTransitionInfo_25);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetCurrentAnimatorClipInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCurrentAnimatorClipInfo_26);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetNextAnimatorClipInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetNextAnimatorClipInfo_27);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetCurrentAnimatorClipInfoCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCurrentAnimatorClipInfoCount_28);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>)};
            method = type.GetMethod("GetCurrentAnimatorClipInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCurrentAnimatorClipInfo_29);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetNextAnimatorClipInfoCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetNextAnimatorClipInfoCount_30);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>)};
            method = type.GetMethod("GetNextAnimatorClipInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetNextAnimatorClipInfo_31);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("IsInTransition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsInTransition_32);
            args = new Type[]{};
            method = type.GetMethod("get_parameterCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_parameterCount_33);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetParameter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetParameter_34);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("CrossFadeInFixedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CrossFadeInFixedTime_35);
            args = new Type[]{typeof(System.Int32), typeof(System.Single), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("CrossFadeInFixedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CrossFadeInFixedTime_36);
            args = new Type[]{typeof(System.String), typeof(System.Single), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("CrossFade", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CrossFade_37);
            args = new Type[]{typeof(System.Int32), typeof(System.Single), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("CrossFade", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CrossFade_38);
            args = new Type[]{typeof(System.String), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("PlayInFixedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PlayInFixedTime_39);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("PlayInFixedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PlayInFixedTime_40);
            args = new Type[]{typeof(System.String), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_41);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_42);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("HasState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HasState_43);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Experimental.Director.IAnimatorControllerPlayable[s]);


        }


        static StackObject* GetFloat_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetFloat(name);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetFloat_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 id = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetFloat(id);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetFloat_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
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
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetFloat(name, value);

            return __ret;
        }

        static StackObject* SetFloat_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 id = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetFloat(id, value);

            return __ret;
        }

        static StackObject* GetBool_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetBool(name);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetBool_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 id = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetBool(id);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetBool_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetBool(name, value);

            return __ret;
        }

        static StackObject* SetBool_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 id = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetBool(id, value);

            return __ret;
        }

        static StackObject* GetInteger_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetInteger(name);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetInteger_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 id = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetInteger(id);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetInteger_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetInteger(name, value);

            return __ret;
        }

        static StackObject* SetInteger_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 id = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetInteger(id, value);

            return __ret;
        }

        static StackObject* SetTrigger_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTrigger(name);

            return __ret;
        }

        static StackObject* SetTrigger_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 id = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTrigger(id);

            return __ret;
        }

        static StackObject* ResetTrigger_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResetTrigger(name);

            return __ret;
        }

        static StackObject* ResetTrigger_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 id = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResetTrigger(id);

            return __ret;
        }

        static StackObject* IsParameterControlledByCurve_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsParameterControlledByCurve(name);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsParameterControlledByCurve_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 id = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsParameterControlledByCurve(id);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_layerCount_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.layerCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetLayerName_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetLayerName(layerIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetLayerIndex_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String layerName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetLayerIndex(layerName);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetLayerWeight_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetLayerWeight(layerIndex);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetLayerWeight_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single weight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetLayerWeight(layerIndex, weight);

            return __ret;
        }

        static StackObject* GetCurrentAnimatorStateInfo_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCurrentAnimatorStateInfo(layerIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetNextAnimatorStateInfo_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetNextAnimatorStateInfo(layerIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAnimatorTransitionInfo_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAnimatorTransitionInfo(layerIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetCurrentAnimatorClipInfo_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCurrentAnimatorClipInfo(layerIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetNextAnimatorClipInfo_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetNextAnimatorClipInfo(layerIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetCurrentAnimatorClipInfoCount_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCurrentAnimatorClipInfoCount(layerIndex);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetCurrentAnimatorClipInfo_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips = (System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>)typeof(System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetCurrentAnimatorClipInfo(layerIndex, clips);

            return __ret;
        }

        static StackObject* GetNextAnimatorClipInfoCount_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetNextAnimatorClipInfoCount(layerIndex);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetNextAnimatorClipInfo_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips = (System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>)typeof(System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetNextAnimatorClipInfo(layerIndex, clips);

            return __ret;
        }

        static StackObject* IsInTransition_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsInTransition(layerIndex);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_parameterCount_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.parameterCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetParameter_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetParameter(index);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CrossFadeInFixedTime_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single fixedTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single transitionDuration = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String stateName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CrossFadeInFixedTime(stateName, transitionDuration, layer, fixedTime);

            return __ret;
        }

        static StackObject* CrossFadeInFixedTime_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single fixedTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single transitionDuration = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 stateNameHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CrossFadeInFixedTime(stateNameHash, transitionDuration, layer, fixedTime);

            return __ret;
        }

        static StackObject* CrossFade_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single normalizedTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single transitionDuration = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String stateName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CrossFade(stateName, transitionDuration, layer, normalizedTime);

            return __ret;
        }

        static StackObject* CrossFade_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single normalizedTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single transitionDuration = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 stateNameHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CrossFade(stateNameHash, transitionDuration, layer, normalizedTime);

            return __ret;
        }

        static StackObject* PlayInFixedTime_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single fixedTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String stateName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PlayInFixedTime(stateName, layer, fixedTime);

            return __ret;
        }

        static StackObject* PlayInFixedTime_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single fixedTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 stateNameHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PlayInFixedTime(stateNameHash, layer, fixedTime);

            return __ret;
        }

        static StackObject* Play_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single normalizedTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String stateName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play(stateName, layer, normalizedTime);

            return __ret;
        }

        static StackObject* Play_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single normalizedTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layer = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 stateNameHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play(stateNameHash, layer, normalizedTime);

            return __ret;
        }

        static StackObject* HasState_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 stateID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Experimental.Director.IAnimatorControllerPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.IAnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.IAnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.HasState(layerIndex, stateID);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }





    }
}
