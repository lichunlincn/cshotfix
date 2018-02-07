
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
    unsafe class UnityEngine_ConfigurableJoint_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ConfigurableJoint);
            args = new Type[]{};
            method = type.GetMethod("get_secondaryAxis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_secondaryAxis_0);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_secondaryAxis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_secondaryAxis_1);
            args = new Type[]{};
            method = type.GetMethod("get_xMotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_xMotion_2);
            args = new Type[]{typeof(UnityEngine.ConfigurableJointMotion)};
            method = type.GetMethod("set_xMotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_xMotion_3);
            args = new Type[]{};
            method = type.GetMethod("get_yMotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_yMotion_4);
            args = new Type[]{typeof(UnityEngine.ConfigurableJointMotion)};
            method = type.GetMethod("set_yMotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_yMotion_5);
            args = new Type[]{};
            method = type.GetMethod("get_zMotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_zMotion_6);
            args = new Type[]{typeof(UnityEngine.ConfigurableJointMotion)};
            method = type.GetMethod("set_zMotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_zMotion_7);
            args = new Type[]{};
            method = type.GetMethod("get_angularXMotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularXMotion_8);
            args = new Type[]{typeof(UnityEngine.ConfigurableJointMotion)};
            method = type.GetMethod("set_angularXMotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularXMotion_9);
            args = new Type[]{};
            method = type.GetMethod("get_angularYMotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularYMotion_10);
            args = new Type[]{typeof(UnityEngine.ConfigurableJointMotion)};
            method = type.GetMethod("set_angularYMotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularYMotion_11);
            args = new Type[]{};
            method = type.GetMethod("get_angularZMotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularZMotion_12);
            args = new Type[]{typeof(UnityEngine.ConfigurableJointMotion)};
            method = type.GetMethod("set_angularZMotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularZMotion_13);
            args = new Type[]{};
            method = type.GetMethod("get_linearLimitSpring", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_linearLimitSpring_14);
            args = new Type[]{typeof(UnityEngine.SoftJointLimitSpring)};
            method = type.GetMethod("set_linearLimitSpring", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_linearLimitSpring_15);
            args = new Type[]{};
            method = type.GetMethod("get_angularXLimitSpring", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularXLimitSpring_16);
            args = new Type[]{typeof(UnityEngine.SoftJointLimitSpring)};
            method = type.GetMethod("set_angularXLimitSpring", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularXLimitSpring_17);
            args = new Type[]{};
            method = type.GetMethod("get_angularYZLimitSpring", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularYZLimitSpring_18);
            args = new Type[]{typeof(UnityEngine.SoftJointLimitSpring)};
            method = type.GetMethod("set_angularYZLimitSpring", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularYZLimitSpring_19);
            args = new Type[]{};
            method = type.GetMethod("get_linearLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_linearLimit_20);
            args = new Type[]{typeof(UnityEngine.SoftJointLimit)};
            method = type.GetMethod("set_linearLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_linearLimit_21);
            args = new Type[]{};
            method = type.GetMethod("get_lowAngularXLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lowAngularXLimit_22);
            args = new Type[]{typeof(UnityEngine.SoftJointLimit)};
            method = type.GetMethod("set_lowAngularXLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lowAngularXLimit_23);
            args = new Type[]{};
            method = type.GetMethod("get_highAngularXLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_highAngularXLimit_24);
            args = new Type[]{typeof(UnityEngine.SoftJointLimit)};
            method = type.GetMethod("set_highAngularXLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_highAngularXLimit_25);
            args = new Type[]{};
            method = type.GetMethod("get_angularYLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularYLimit_26);
            args = new Type[]{typeof(UnityEngine.SoftJointLimit)};
            method = type.GetMethod("set_angularYLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularYLimit_27);
            args = new Type[]{};
            method = type.GetMethod("get_angularZLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularZLimit_28);
            args = new Type[]{typeof(UnityEngine.SoftJointLimit)};
            method = type.GetMethod("set_angularZLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularZLimit_29);
            args = new Type[]{};
            method = type.GetMethod("get_targetPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_targetPosition_30);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_targetPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_targetPosition_31);
            args = new Type[]{};
            method = type.GetMethod("get_targetVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_targetVelocity_32);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_targetVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_targetVelocity_33);
            args = new Type[]{};
            method = type.GetMethod("get_xDrive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_xDrive_34);
            args = new Type[]{typeof(UnityEngine.JointDrive)};
            method = type.GetMethod("set_xDrive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_xDrive_35);
            args = new Type[]{};
            method = type.GetMethod("get_yDrive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_yDrive_36);
            args = new Type[]{typeof(UnityEngine.JointDrive)};
            method = type.GetMethod("set_yDrive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_yDrive_37);
            args = new Type[]{};
            method = type.GetMethod("get_zDrive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_zDrive_38);
            args = new Type[]{typeof(UnityEngine.JointDrive)};
            method = type.GetMethod("set_zDrive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_zDrive_39);
            args = new Type[]{};
            method = type.GetMethod("get_targetRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_targetRotation_40);
            args = new Type[]{typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("set_targetRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_targetRotation_41);
            args = new Type[]{};
            method = type.GetMethod("get_targetAngularVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_targetAngularVelocity_42);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_targetAngularVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_targetAngularVelocity_43);
            args = new Type[]{};
            method = type.GetMethod("get_rotationDriveMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rotationDriveMode_44);
            args = new Type[]{typeof(UnityEngine.RotationDriveMode)};
            method = type.GetMethod("set_rotationDriveMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rotationDriveMode_45);
            args = new Type[]{};
            method = type.GetMethod("get_angularXDrive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularXDrive_46);
            args = new Type[]{typeof(UnityEngine.JointDrive)};
            method = type.GetMethod("set_angularXDrive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularXDrive_47);
            args = new Type[]{};
            method = type.GetMethod("get_angularYZDrive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularYZDrive_48);
            args = new Type[]{typeof(UnityEngine.JointDrive)};
            method = type.GetMethod("set_angularYZDrive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularYZDrive_49);
            args = new Type[]{};
            method = type.GetMethod("get_slerpDrive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_slerpDrive_50);
            args = new Type[]{typeof(UnityEngine.JointDrive)};
            method = type.GetMethod("set_slerpDrive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_slerpDrive_51);
            args = new Type[]{};
            method = type.GetMethod("get_projectionMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_projectionMode_52);
            args = new Type[]{typeof(UnityEngine.JointProjectionMode)};
            method = type.GetMethod("set_projectionMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_projectionMode_53);
            args = new Type[]{};
            method = type.GetMethod("get_projectionDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_projectionDistance_54);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_projectionDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_projectionDistance_55);
            args = new Type[]{};
            method = type.GetMethod("get_projectionAngle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_projectionAngle_56);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_projectionAngle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_projectionAngle_57);
            args = new Type[]{};
            method = type.GetMethod("get_configuredInWorldSpace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_configuredInWorldSpace_58);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_configuredInWorldSpace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_configuredInWorldSpace_59);
            args = new Type[]{};
            method = type.GetMethod("get_swapBodies", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_swapBodies_60);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_swapBodies", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_swapBodies_61);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ConfigurableJoint());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ConfigurableJoint[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_secondaryAxis_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.secondaryAxis;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_secondaryAxis_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.secondaryAxis = value;

            return __ret;
        }

        static StackObject* get_xMotion_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.xMotion;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_xMotion_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJointMotion value = (UnityEngine.ConfigurableJointMotion)typeof(UnityEngine.ConfigurableJointMotion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.xMotion = value;

            return __ret;
        }

        static StackObject* get_yMotion_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.yMotion;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_yMotion_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJointMotion value = (UnityEngine.ConfigurableJointMotion)typeof(UnityEngine.ConfigurableJointMotion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.yMotion = value;

            return __ret;
        }

        static StackObject* get_zMotion_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.zMotion;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_zMotion_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJointMotion value = (UnityEngine.ConfigurableJointMotion)typeof(UnityEngine.ConfigurableJointMotion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.zMotion = value;

            return __ret;
        }

        static StackObject* get_angularXMotion_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angularXMotion;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_angularXMotion_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJointMotion value = (UnityEngine.ConfigurableJointMotion)typeof(UnityEngine.ConfigurableJointMotion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.angularXMotion = value;

            return __ret;
        }

        static StackObject* get_angularYMotion_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angularYMotion;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_angularYMotion_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJointMotion value = (UnityEngine.ConfigurableJointMotion)typeof(UnityEngine.ConfigurableJointMotion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.angularYMotion = value;

            return __ret;
        }

        static StackObject* get_angularZMotion_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angularZMotion;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_angularZMotion_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJointMotion value = (UnityEngine.ConfigurableJointMotion)typeof(UnityEngine.ConfigurableJointMotion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.angularZMotion = value;

            return __ret;
        }

        static StackObject* get_linearLimitSpring_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.linearLimitSpring;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_linearLimitSpring_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SoftJointLimitSpring value = (UnityEngine.SoftJointLimitSpring)typeof(UnityEngine.SoftJointLimitSpring).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.linearLimitSpring = value;

            return __ret;
        }

        static StackObject* get_angularXLimitSpring_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angularXLimitSpring;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_angularXLimitSpring_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SoftJointLimitSpring value = (UnityEngine.SoftJointLimitSpring)typeof(UnityEngine.SoftJointLimitSpring).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.angularXLimitSpring = value;

            return __ret;
        }

        static StackObject* get_angularYZLimitSpring_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angularYZLimitSpring;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_angularYZLimitSpring_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SoftJointLimitSpring value = (UnityEngine.SoftJointLimitSpring)typeof(UnityEngine.SoftJointLimitSpring).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.angularYZLimitSpring = value;

            return __ret;
        }

        static StackObject* get_linearLimit_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.linearLimit;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_linearLimit_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SoftJointLimit value = (UnityEngine.SoftJointLimit)typeof(UnityEngine.SoftJointLimit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.linearLimit = value;

            return __ret;
        }

        static StackObject* get_lowAngularXLimit_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lowAngularXLimit;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_lowAngularXLimit_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SoftJointLimit value = (UnityEngine.SoftJointLimit)typeof(UnityEngine.SoftJointLimit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.lowAngularXLimit = value;

            return __ret;
        }

        static StackObject* get_highAngularXLimit_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.highAngularXLimit;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_highAngularXLimit_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SoftJointLimit value = (UnityEngine.SoftJointLimit)typeof(UnityEngine.SoftJointLimit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.highAngularXLimit = value;

            return __ret;
        }

        static StackObject* get_angularYLimit_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angularYLimit;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_angularYLimit_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SoftJointLimit value = (UnityEngine.SoftJointLimit)typeof(UnityEngine.SoftJointLimit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.angularYLimit = value;

            return __ret;
        }

        static StackObject* get_angularZLimit_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angularZLimit;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_angularZLimit_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SoftJointLimit value = (UnityEngine.SoftJointLimit)typeof(UnityEngine.SoftJointLimit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.angularZLimit = value;

            return __ret;
        }

        static StackObject* get_targetPosition_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.targetPosition;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_targetPosition_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.targetPosition = value;

            return __ret;
        }

        static StackObject* get_targetVelocity_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.targetVelocity;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_targetVelocity_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.targetVelocity = value;

            return __ret;
        }

        static StackObject* get_xDrive_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.xDrive;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_xDrive_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.JointDrive value = (UnityEngine.JointDrive)typeof(UnityEngine.JointDrive).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.xDrive = value;

            return __ret;
        }

        static StackObject* get_yDrive_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.yDrive;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_yDrive_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.JointDrive value = (UnityEngine.JointDrive)typeof(UnityEngine.JointDrive).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.yDrive = value;

            return __ret;
        }

        static StackObject* get_zDrive_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.zDrive;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_zDrive_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.JointDrive value = (UnityEngine.JointDrive)typeof(UnityEngine.JointDrive).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.zDrive = value;

            return __ret;
        }

        static StackObject* get_targetRotation_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.targetRotation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_targetRotation_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion value = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.targetRotation = value;

            return __ret;
        }

        static StackObject* get_targetAngularVelocity_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.targetAngularVelocity;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_targetAngularVelocity_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.targetAngularVelocity = value;

            return __ret;
        }

        static StackObject* get_rotationDriveMode_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rotationDriveMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_rotationDriveMode_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RotationDriveMode value = (UnityEngine.RotationDriveMode)typeof(UnityEngine.RotationDriveMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.rotationDriveMode = value;

            return __ret;
        }

        static StackObject* get_angularXDrive_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angularXDrive;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_angularXDrive_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.JointDrive value = (UnityEngine.JointDrive)typeof(UnityEngine.JointDrive).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.angularXDrive = value;

            return __ret;
        }

        static StackObject* get_angularYZDrive_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angularYZDrive;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_angularYZDrive_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.JointDrive value = (UnityEngine.JointDrive)typeof(UnityEngine.JointDrive).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.angularYZDrive = value;

            return __ret;
        }

        static StackObject* get_slerpDrive_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.slerpDrive;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_slerpDrive_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.JointDrive value = (UnityEngine.JointDrive)typeof(UnityEngine.JointDrive).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.slerpDrive = value;

            return __ret;
        }

        static StackObject* get_projectionMode_52(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.projectionMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_projectionMode_53(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.JointProjectionMode value = (UnityEngine.JointProjectionMode)typeof(UnityEngine.JointProjectionMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.projectionMode = value;

            return __ret;
        }

        static StackObject* get_projectionDistance_54(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.projectionDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_projectionDistance_55(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.projectionDistance = value;

            return __ret;
        }

        static StackObject* get_projectionAngle_56(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.projectionAngle;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_projectionAngle_57(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.projectionAngle = value;

            return __ret;
        }

        static StackObject* get_configuredInWorldSpace_58(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.configuredInWorldSpace;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_configuredInWorldSpace_59(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.configuredInWorldSpace = value;

            return __ret;
        }

        static StackObject* get_swapBodies_60(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.swapBodies;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_swapBodies_61(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ConfigurableJoint instance_of_this_method;
            instance_of_this_method = (UnityEngine.ConfigurableJoint)typeof(UnityEngine.ConfigurableJoint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.swapBodies = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.ConfigurableJoint();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
