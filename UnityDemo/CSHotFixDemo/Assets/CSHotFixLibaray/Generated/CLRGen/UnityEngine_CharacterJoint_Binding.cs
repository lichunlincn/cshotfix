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
    unsafe class UnityEngine_CharacterJoint_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.CharacterJoint);
            args = new Type[]{};
            method = type.GetMethod("get_swingAxis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_swingAxis_0);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_swingAxis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_swingAxis_1);
            args = new Type[]{};
            method = type.GetMethod("get_twistLimitSpring", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_twistLimitSpring_2);
            args = new Type[]{typeof(UnityEngine.SoftJointLimitSpring)};
            method = type.GetMethod("set_twistLimitSpring", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_twistLimitSpring_3);
            args = new Type[]{};
            method = type.GetMethod("get_swingLimitSpring", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_swingLimitSpring_4);
            args = new Type[]{typeof(UnityEngine.SoftJointLimitSpring)};
            method = type.GetMethod("set_swingLimitSpring", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_swingLimitSpring_5);
            args = new Type[]{};
            method = type.GetMethod("get_lowTwistLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lowTwistLimit_6);
            args = new Type[]{typeof(UnityEngine.SoftJointLimit)};
            method = type.GetMethod("set_lowTwistLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lowTwistLimit_7);
            args = new Type[]{};
            method = type.GetMethod("get_highTwistLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_highTwistLimit_8);
            args = new Type[]{typeof(UnityEngine.SoftJointLimit)};
            method = type.GetMethod("set_highTwistLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_highTwistLimit_9);
            args = new Type[]{};
            method = type.GetMethod("get_swing1Limit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_swing1Limit_10);
            args = new Type[]{typeof(UnityEngine.SoftJointLimit)};
            method = type.GetMethod("set_swing1Limit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_swing1Limit_11);
            args = new Type[]{};
            method = type.GetMethod("get_swing2Limit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_swing2Limit_12);
            args = new Type[]{typeof(UnityEngine.SoftJointLimit)};
            method = type.GetMethod("set_swing2Limit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_swing2Limit_13);
            args = new Type[]{};
            method = type.GetMethod("get_enableProjection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_enableProjection_14);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_enableProjection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_enableProjection_15);
            args = new Type[]{};
            method = type.GetMethod("get_projectionDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_projectionDistance_16);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_projectionDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_projectionDistance_17);
            args = new Type[]{};
            method = type.GetMethod("get_projectionAngle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_projectionAngle_18);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_projectionAngle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_projectionAngle_19);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.CharacterJoint());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.CharacterJoint[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_swingAxis_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CharacterJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.CharacterJoint)typeof(UnityEngine.CharacterJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.swingAxis;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_swingAxis_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CharacterJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.CharacterJoint)typeof(UnityEngine.CharacterJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.swingAxis = value;

            return __ret;
        }

        static StackObject* get_twistLimitSpring_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CharacterJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.CharacterJoint)typeof(UnityEngine.CharacterJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.twistLimitSpring;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_twistLimitSpring_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SoftJointLimitSpring value = (UnityEngine.SoftJointLimitSpring)typeof(UnityEngine.SoftJointLimitSpring).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CharacterJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.CharacterJoint)typeof(UnityEngine.CharacterJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.twistLimitSpring = value;

            return __ret;
        }

        static StackObject* get_swingLimitSpring_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CharacterJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.CharacterJoint)typeof(UnityEngine.CharacterJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.swingLimitSpring;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_swingLimitSpring_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SoftJointLimitSpring value = (UnityEngine.SoftJointLimitSpring)typeof(UnityEngine.SoftJointLimitSpring).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CharacterJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.CharacterJoint)typeof(UnityEngine.CharacterJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.swingLimitSpring = value;

            return __ret;
        }

        static StackObject* get_lowTwistLimit_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CharacterJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.CharacterJoint)typeof(UnityEngine.CharacterJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lowTwistLimit;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_lowTwistLimit_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SoftJointLimit value = (UnityEngine.SoftJointLimit)typeof(UnityEngine.SoftJointLimit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CharacterJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.CharacterJoint)typeof(UnityEngine.CharacterJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.lowTwistLimit = value;

            return __ret;
        }

        static StackObject* get_highTwistLimit_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CharacterJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.CharacterJoint)typeof(UnityEngine.CharacterJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.highTwistLimit;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_highTwistLimit_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SoftJointLimit value = (UnityEngine.SoftJointLimit)typeof(UnityEngine.SoftJointLimit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CharacterJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.CharacterJoint)typeof(UnityEngine.CharacterJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.highTwistLimit = value;

            return __ret;
        }

        static StackObject* get_swing1Limit_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CharacterJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.CharacterJoint)typeof(UnityEngine.CharacterJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.swing1Limit;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_swing1Limit_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SoftJointLimit value = (UnityEngine.SoftJointLimit)typeof(UnityEngine.SoftJointLimit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CharacterJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.CharacterJoint)typeof(UnityEngine.CharacterJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.swing1Limit = value;

            return __ret;
        }

        static StackObject* get_swing2Limit_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CharacterJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.CharacterJoint)typeof(UnityEngine.CharacterJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.swing2Limit;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_swing2Limit_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SoftJointLimit value = (UnityEngine.SoftJointLimit)typeof(UnityEngine.SoftJointLimit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CharacterJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.CharacterJoint)typeof(UnityEngine.CharacterJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.swing2Limit = value;

            return __ret;
        }

        static StackObject* get_enableProjection_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CharacterJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.CharacterJoint)typeof(UnityEngine.CharacterJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.enableProjection;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_enableProjection_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CharacterJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.CharacterJoint)typeof(UnityEngine.CharacterJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.enableProjection = value;

            return __ret;
        }

        static StackObject* get_projectionDistance_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CharacterJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.CharacterJoint)typeof(UnityEngine.CharacterJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.projectionDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_projectionDistance_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CharacterJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.CharacterJoint)typeof(UnityEngine.CharacterJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.projectionDistance = value;

            return __ret;
        }

        static StackObject* get_projectionAngle_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CharacterJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.CharacterJoint)typeof(UnityEngine.CharacterJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.projectionAngle;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_projectionAngle_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CharacterJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.CharacterJoint)typeof(UnityEngine.CharacterJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.projectionAngle = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.CharacterJoint();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
