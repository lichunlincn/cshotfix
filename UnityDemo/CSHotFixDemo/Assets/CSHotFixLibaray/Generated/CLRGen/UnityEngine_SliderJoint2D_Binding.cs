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
    unsafe class UnityEngine_SliderJoint2D_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.SliderJoint2D);
            args = new Type[]{};
            method = type.GetMethod("get_autoConfigureAngle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_autoConfigureAngle_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_autoConfigureAngle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_autoConfigureAngle_1);
            args = new Type[]{};
            method = type.GetMethod("get_angle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angle_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_angle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angle_3);
            args = new Type[]{};
            method = type.GetMethod("get_useMotor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useMotor_4);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_useMotor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useMotor_5);
            args = new Type[]{};
            method = type.GetMethod("get_useLimits", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useLimits_6);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_useLimits", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useLimits_7);
            args = new Type[]{};
            method = type.GetMethod("get_motor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_motor_8);
            args = new Type[]{typeof(UnityEngine.JointMotor2D)};
            method = type.GetMethod("set_motor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_motor_9);
            args = new Type[]{};
            method = type.GetMethod("get_limits", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_limits_10);
            args = new Type[]{typeof(UnityEngine.JointTranslationLimits2D)};
            method = type.GetMethod("set_limits", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_limits_11);
            args = new Type[]{};
            method = type.GetMethod("get_limitState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_limitState_12);
            args = new Type[]{};
            method = type.GetMethod("get_referenceAngle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_referenceAngle_13);
            args = new Type[]{};
            method = type.GetMethod("get_jointTranslation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_jointTranslation_14);
            args = new Type[]{};
            method = type.GetMethod("get_jointSpeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_jointSpeed_15);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("GetMotorForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetMotorForce_16);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.SliderJoint2D());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.SliderJoint2D[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_autoConfigureAngle_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SliderJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.SliderJoint2D)typeof(UnityEngine.SliderJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.autoConfigureAngle;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_autoConfigureAngle_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SliderJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.SliderJoint2D)typeof(UnityEngine.SliderJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.autoConfigureAngle = value;

            return __ret;
        }

        static StackObject* get_angle_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SliderJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.SliderJoint2D)typeof(UnityEngine.SliderJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angle;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_angle_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SliderJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.SliderJoint2D)typeof(UnityEngine.SliderJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.angle = value;

            return __ret;
        }

        static StackObject* get_useMotor_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SliderJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.SliderJoint2D)typeof(UnityEngine.SliderJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useMotor;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useMotor_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SliderJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.SliderJoint2D)typeof(UnityEngine.SliderJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useMotor = value;

            return __ret;
        }

        static StackObject* get_useLimits_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SliderJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.SliderJoint2D)typeof(UnityEngine.SliderJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useLimits;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useLimits_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SliderJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.SliderJoint2D)typeof(UnityEngine.SliderJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useLimits = value;

            return __ret;
        }

        static StackObject* get_motor_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SliderJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.SliderJoint2D)typeof(UnityEngine.SliderJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.motor;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_motor_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.JointMotor2D value = (UnityEngine.JointMotor2D)typeof(UnityEngine.JointMotor2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SliderJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.SliderJoint2D)typeof(UnityEngine.SliderJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.motor = value;

            return __ret;
        }

        static StackObject* get_limits_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SliderJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.SliderJoint2D)typeof(UnityEngine.SliderJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.limits;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_limits_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.JointTranslationLimits2D value = (UnityEngine.JointTranslationLimits2D)typeof(UnityEngine.JointTranslationLimits2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SliderJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.SliderJoint2D)typeof(UnityEngine.SliderJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.limits = value;

            return __ret;
        }

        static StackObject* get_limitState_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SliderJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.SliderJoint2D)typeof(UnityEngine.SliderJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.limitState;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_referenceAngle_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SliderJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.SliderJoint2D)typeof(UnityEngine.SliderJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.referenceAngle;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_jointTranslation_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SliderJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.SliderJoint2D)typeof(UnityEngine.SliderJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.jointTranslation;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_jointSpeed_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SliderJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.SliderJoint2D)typeof(UnityEngine.SliderJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.jointSpeed;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetMotorForce_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single timeStep = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SliderJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.SliderJoint2D)typeof(UnityEngine.SliderJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetMotorForce(timeStep);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.SliderJoint2D();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
