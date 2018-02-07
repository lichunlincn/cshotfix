
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
    unsafe class UnityEngine_Cloth_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Cloth);
            args = new Type[]{};
            method = type.GetMethod("get_sleepThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sleepThreshold_0);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_sleepThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sleepThreshold_1);
            args = new Type[]{};
            method = type.GetMethod("get_bendingStiffness", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_bendingStiffness_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_bendingStiffness", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_bendingStiffness_3);
            args = new Type[]{};
            method = type.GetMethod("get_stretchingStiffness", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_stretchingStiffness_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_stretchingStiffness", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_stretchingStiffness_5);
            args = new Type[]{};
            method = type.GetMethod("get_damping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_damping_6);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_damping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_damping_7);
            args = new Type[]{};
            method = type.GetMethod("get_externalAcceleration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_externalAcceleration_8);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_externalAcceleration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_externalAcceleration_9);
            args = new Type[]{};
            method = type.GetMethod("get_randomAcceleration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_randomAcceleration_10);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_randomAcceleration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_randomAcceleration_11);
            args = new Type[]{};
            method = type.GetMethod("get_useGravity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useGravity_12);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_useGravity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useGravity_13);
            args = new Type[]{};
            method = type.GetMethod("get_enabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_enabled_14);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_enabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_enabled_15);
            args = new Type[]{};
            method = type.GetMethod("get_vertices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_vertices_16);
            args = new Type[]{};
            method = type.GetMethod("get_normals", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_normals_17);
            args = new Type[]{};
            method = type.GetMethod("get_friction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_friction_18);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_friction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_friction_19);
            args = new Type[]{};
            method = type.GetMethod("get_collisionMassScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_collisionMassScale_20);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_collisionMassScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_collisionMassScale_21);
            args = new Type[]{};
            method = type.GetMethod("get_useContinuousCollision", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useContinuousCollision_22);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_useContinuousCollision", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useContinuousCollision_23);
            args = new Type[]{};
            method = type.GetMethod("get_useVirtualParticles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useVirtualParticles_24);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_useVirtualParticles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useVirtualParticles_25);
            args = new Type[]{};
            method = type.GetMethod("ClearTransformMotion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearTransformMotion_26);
            args = new Type[]{};
            method = type.GetMethod("get_coefficients", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_coefficients_27);
            args = new Type[]{typeof(UnityEngine.ClothSkinningCoefficient[])};
            method = type.GetMethod("set_coefficients", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_coefficients_28);
            args = new Type[]{};
            method = type.GetMethod("get_worldVelocityScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_worldVelocityScale_29);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_worldVelocityScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_worldVelocityScale_30);
            args = new Type[]{};
            method = type.GetMethod("get_worldAccelerationScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_worldAccelerationScale_31);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_worldAccelerationScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_worldAccelerationScale_32);
            args = new Type[]{typeof(System.Boolean), typeof(System.Single)};
            method = type.GetMethod("SetEnabledFading", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetEnabledFading_33);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("SetEnabledFading", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetEnabledFading_34);
            args = new Type[]{};
            method = type.GetMethod("get_solverFrequency", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_solverFrequency_35);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_solverFrequency", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_solverFrequency_36);
            args = new Type[]{};
            method = type.GetMethod("get_capsuleColliders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_capsuleColliders_37);
            args = new Type[]{typeof(UnityEngine.CapsuleCollider[])};
            method = type.GetMethod("set_capsuleColliders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_capsuleColliders_38);
            args = new Type[]{};
            method = type.GetMethod("get_sphereColliders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sphereColliders_39);
            args = new Type[]{typeof(UnityEngine.ClothSphereColliderPair[])};
            method = type.GetMethod("set_sphereColliders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sphereColliders_40);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Cloth());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Cloth[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_sleepThreshold_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sleepThreshold;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_sleepThreshold_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.sleepThreshold = value;

            return __ret;
        }

        static StackObject* get_bendingStiffness_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.bendingStiffness;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_bendingStiffness_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.bendingStiffness = value;

            return __ret;
        }

        static StackObject* get_stretchingStiffness_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.stretchingStiffness;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_stretchingStiffness_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.stretchingStiffness = value;

            return __ret;
        }

        static StackObject* get_damping_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.damping;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_damping_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.damping = value;

            return __ret;
        }

        static StackObject* get_externalAcceleration_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.externalAcceleration;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_externalAcceleration_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.externalAcceleration = value;

            return __ret;
        }

        static StackObject* get_randomAcceleration_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.randomAcceleration;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_randomAcceleration_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.randomAcceleration = value;

            return __ret;
        }

        static StackObject* get_useGravity_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useGravity;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useGravity_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useGravity = value;

            return __ret;
        }

        static StackObject* get_enabled_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.enabled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_enabled_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.enabled = value;

            return __ret;
        }

        static StackObject* get_vertices_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.vertices;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_normals_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.normals;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_friction_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.friction;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_friction_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.friction = value;

            return __ret;
        }

        static StackObject* get_collisionMassScale_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.collisionMassScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_collisionMassScale_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.collisionMassScale = value;

            return __ret;
        }

        static StackObject* get_useContinuousCollision_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useContinuousCollision;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_useContinuousCollision_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useContinuousCollision = value;

            return __ret;
        }

        static StackObject* get_useVirtualParticles_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useVirtualParticles;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_useVirtualParticles_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useVirtualParticles = value;

            return __ret;
        }

        static StackObject* ClearTransformMotion_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClearTransformMotion();

            return __ret;
        }

        static StackObject* get_coefficients_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.coefficients;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_coefficients_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ClothSkinningCoefficient[] value = (UnityEngine.ClothSkinningCoefficient[])typeof(UnityEngine.ClothSkinningCoefficient[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.coefficients = value;

            return __ret;
        }

        static StackObject* get_worldVelocityScale_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.worldVelocityScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_worldVelocityScale_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.worldVelocityScale = value;

            return __ret;
        }

        static StackObject* get_worldAccelerationScale_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.worldAccelerationScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_worldAccelerationScale_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.worldAccelerationScale = value;

            return __ret;
        }

        static StackObject* SetEnabledFading_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single interpolationTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean enabled = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetEnabledFading(enabled, interpolationTime);

            return __ret;
        }

        static StackObject* SetEnabledFading_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean enabled = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetEnabledFading(enabled);

            return __ret;
        }

        static StackObject* get_solverFrequency_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.solverFrequency;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_solverFrequency_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.solverFrequency = value;

            return __ret;
        }

        static StackObject* get_capsuleColliders_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.capsuleColliders;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_capsuleColliders_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CapsuleCollider[] value = (UnityEngine.CapsuleCollider[])typeof(UnityEngine.CapsuleCollider[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.capsuleColliders = value;

            return __ret;
        }

        static StackObject* get_sphereColliders_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sphereColliders;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_sphereColliders_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ClothSphereColliderPair[] value = (UnityEngine.ClothSphereColliderPair[])typeof(UnityEngine.ClothSphereColliderPair[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cloth instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cloth)typeof(UnityEngine.Cloth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.sphereColliders = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Cloth();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
