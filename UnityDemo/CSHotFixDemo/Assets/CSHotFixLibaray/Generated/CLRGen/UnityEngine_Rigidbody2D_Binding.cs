
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
    unsafe class UnityEngine_Rigidbody2D_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Rigidbody2D);
            args = new Type[]{};
            method = type.GetMethod("get_position", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_position_0);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("set_position", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_position_1);
            args = new Type[]{};
            method = type.GetMethod("get_rotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rotation_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_rotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rotation_3);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("MovePosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MovePosition_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("MoveRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveRotation_5);
            args = new Type[]{};
            method = type.GetMethod("get_velocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_velocity_6);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("set_velocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_velocity_7);
            args = new Type[]{};
            method = type.GetMethod("get_angularVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularVelocity_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_angularVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularVelocity_9);
            args = new Type[]{};
            method = type.GetMethod("get_useAutoMass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useAutoMass_10);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_useAutoMass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useAutoMass_11);
            args = new Type[]{};
            method = type.GetMethod("get_mass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mass_12);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_mass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_mass_13);
            args = new Type[]{};
            method = type.GetMethod("get_sharedMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sharedMaterial_14);
            args = new Type[]{typeof(UnityEngine.PhysicsMaterial2D)};
            method = type.GetMethod("set_sharedMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sharedMaterial_15);
            args = new Type[]{};
            method = type.GetMethod("get_centerOfMass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_centerOfMass_16);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("set_centerOfMass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_centerOfMass_17);
            args = new Type[]{};
            method = type.GetMethod("get_worldCenterOfMass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_worldCenterOfMass_18);
            args = new Type[]{};
            method = type.GetMethod("get_inertia", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_inertia_19);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_inertia", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_inertia_20);
            args = new Type[]{};
            method = type.GetMethod("get_drag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_drag_21);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_drag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_drag_22);
            args = new Type[]{};
            method = type.GetMethod("get_angularDrag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularDrag_23);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_angularDrag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularDrag_24);
            args = new Type[]{};
            method = type.GetMethod("get_gravityScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_gravityScale_25);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_gravityScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_gravityScale_26);
            args = new Type[]{};
            method = type.GetMethod("get_bodyType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_bodyType_27);
            args = new Type[]{typeof(UnityEngine.RigidbodyType2D)};
            method = type.GetMethod("set_bodyType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_bodyType_28);
            args = new Type[]{};
            method = type.GetMethod("get_useFullKinematicContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useFullKinematicContacts_29);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_useFullKinematicContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useFullKinematicContacts_30);
            args = new Type[]{};
            method = type.GetMethod("get_isKinematic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isKinematic_31);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_isKinematic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_isKinematic_32);
            args = new Type[]{};
            method = type.GetMethod("get_freezeRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_freezeRotation_33);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_freezeRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_freezeRotation_34);
            args = new Type[]{};
            method = type.GetMethod("get_constraints", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_constraints_35);
            args = new Type[]{typeof(UnityEngine.RigidbodyConstraints2D)};
            method = type.GetMethod("set_constraints", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_constraints_36);
            args = new Type[]{};
            method = type.GetMethod("IsSleeping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsSleeping_37);
            args = new Type[]{};
            method = type.GetMethod("IsAwake", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsAwake_38);
            args = new Type[]{};
            method = type.GetMethod("Sleep", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sleep_39);
            args = new Type[]{};
            method = type.GetMethod("WakeUp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WakeUp_40);
            args = new Type[]{};
            method = type.GetMethod("get_simulated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_simulated_41);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_simulated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_simulated_42);
            args = new Type[]{};
            method = type.GetMethod("get_interpolation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_interpolation_43);
            args = new Type[]{typeof(UnityEngine.RigidbodyInterpolation2D)};
            method = type.GetMethod("set_interpolation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_interpolation_44);
            args = new Type[]{};
            method = type.GetMethod("get_sleepMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sleepMode_45);
            args = new Type[]{typeof(UnityEngine.RigidbodySleepMode2D)};
            method = type.GetMethod("set_sleepMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sleepMode_46);
            args = new Type[]{};
            method = type.GetMethod("get_collisionDetectionMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_collisionDetectionMode_47);
            args = new Type[]{typeof(UnityEngine.CollisionDetectionMode2D)};
            method = type.GetMethod("set_collisionDetectionMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_collisionDetectionMode_48);
            args = new Type[]{};
            method = type.GetMethod("get_attachedColliderCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_attachedColliderCount_49);
            args = new Type[]{typeof(UnityEngine.Collider2D[])};
            method = type.GetMethod("GetAttachedColliders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAttachedColliders_50);
            args = new Type[]{typeof(UnityEngine.Collider2D)};
            method = type.GetMethod("IsTouching", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsTouching_51);
            args = new Type[]{typeof(UnityEngine.Collider2D), typeof(UnityEngine.ContactFilter2D)};
            method = type.GetMethod("IsTouching", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsTouching_52);
            args = new Type[]{typeof(UnityEngine.ContactFilter2D)};
            method = type.GetMethod("IsTouching", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsTouching_53);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("IsTouchingLayers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsTouchingLayers_54);
            args = new Type[]{};
            method = type.GetMethod("IsTouchingLayers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsTouchingLayers_55);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("OverlapPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapPoint_56);
            args = new Type[]{typeof(UnityEngine.ContactFilter2D), typeof(UnityEngine.Collider2D[])};
            method = type.GetMethod("OverlapCollider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverlapCollider_57);
            args = new Type[]{typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[]), typeof(System.Single)};
            method = type.GetMethod("Cast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Cast_58);
            args = new Type[]{typeof(UnityEngine.Vector2), typeof(UnityEngine.RaycastHit2D[])};
            method = type.GetMethod("Cast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Cast_59);
            args = new Type[]{typeof(UnityEngine.Vector2), typeof(UnityEngine.ContactFilter2D), typeof(UnityEngine.RaycastHit2D[])};
            method = type.GetMethod("Cast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Cast_60);
            args = new Type[]{typeof(UnityEngine.Vector2), typeof(UnityEngine.ContactFilter2D), typeof(UnityEngine.RaycastHit2D[]), typeof(System.Single)};
            method = type.GetMethod("Cast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Cast_61);
            args = new Type[]{typeof(UnityEngine.Collider2D)};
            method = type.GetMethod("Distance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Distance_62);
            args = new Type[]{typeof(UnityEngine.Vector2), typeof(UnityEngine.ForceMode2D)};
            method = type.GetMethod("AddForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddForce_63);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("AddForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddForce_64);
            args = new Type[]{typeof(UnityEngine.Vector2), typeof(UnityEngine.ForceMode2D)};
            method = type.GetMethod("AddRelativeForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddRelativeForce_65);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("AddRelativeForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddRelativeForce_66);
            args = new Type[]{typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.ForceMode2D)};
            method = type.GetMethod("AddForceAtPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddForceAtPosition_67);
            args = new Type[]{typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2)};
            method = type.GetMethod("AddForceAtPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddForceAtPosition_68);
            args = new Type[]{typeof(System.Single), typeof(UnityEngine.ForceMode2D)};
            method = type.GetMethod("AddTorque", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddTorque_69);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("AddTorque", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddTorque_70);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("GetPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPoint_71);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("GetRelativePoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRelativePoint_72);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("GetVector", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetVector_73);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("GetRelativeVector", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRelativeVector_74);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("GetPointVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPointVelocity_75);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("GetRelativePointVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRelativePointVelocity_76);
            args = new Type[]{typeof(UnityEngine.ContactPoint2D[])};
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_77);
            args = new Type[]{typeof(UnityEngine.ContactFilter2D), typeof(UnityEngine.ContactPoint2D[])};
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_78);
            args = new Type[]{typeof(UnityEngine.Collider2D[])};
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_79);
            args = new Type[]{typeof(UnityEngine.ContactFilter2D), typeof(UnityEngine.Collider2D[])};
            method = type.GetMethod("GetContacts", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetContacts_80);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Rigidbody2D());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Rigidbody2D[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_position_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.position;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_position_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 value = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.position = value;

            return __ret;
        }

        static StackObject* get_rotation_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rotation;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_rotation_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.rotation = value;

            return __ret;
        }

        static StackObject* MovePosition_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 position = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MovePosition(position);

            return __ret;
        }

        static StackObject* MoveRotation_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single angle = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveRotation(angle);

            return __ret;
        }

        static StackObject* get_velocity_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.velocity;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_velocity_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 value = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.velocity = value;

            return __ret;
        }

        static StackObject* get_angularVelocity_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angularVelocity;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_angularVelocity_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.angularVelocity = value;

            return __ret;
        }

        static StackObject* get_useAutoMass_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useAutoMass;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useAutoMass_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useAutoMass = value;

            return __ret;
        }

        static StackObject* get_mass_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.mass;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_mass_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.mass = value;

            return __ret;
        }

        static StackObject* get_sharedMaterial_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sharedMaterial;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_sharedMaterial_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PhysicsMaterial2D value = (UnityEngine.PhysicsMaterial2D)typeof(UnityEngine.PhysicsMaterial2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.sharedMaterial = value;

            return __ret;
        }

        static StackObject* get_centerOfMass_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.centerOfMass;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_centerOfMass_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 value = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.centerOfMass = value;

            return __ret;
        }

        static StackObject* get_worldCenterOfMass_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.worldCenterOfMass;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_inertia_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.inertia;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_inertia_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.inertia = value;

            return __ret;
        }

        static StackObject* get_drag_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.drag;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_drag_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.drag = value;

            return __ret;
        }

        static StackObject* get_angularDrag_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angularDrag;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_angularDrag_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.angularDrag = value;

            return __ret;
        }

        static StackObject* get_gravityScale_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.gravityScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_gravityScale_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.gravityScale = value;

            return __ret;
        }

        static StackObject* get_bodyType_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.bodyType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_bodyType_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RigidbodyType2D value = (UnityEngine.RigidbodyType2D)typeof(UnityEngine.RigidbodyType2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.bodyType = value;

            return __ret;
        }

        static StackObject* get_useFullKinematicContacts_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useFullKinematicContacts;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useFullKinematicContacts_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useFullKinematicContacts = value;

            return __ret;
        }

        static StackObject* get_isKinematic_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isKinematic;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_isKinematic_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.isKinematic = value;

            return __ret;
        }

        static StackObject* get_freezeRotation_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.freezeRotation;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_freezeRotation_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.freezeRotation = value;

            return __ret;
        }

        static StackObject* get_constraints_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.constraints;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_constraints_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RigidbodyConstraints2D value = (UnityEngine.RigidbodyConstraints2D)typeof(UnityEngine.RigidbodyConstraints2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.constraints = value;

            return __ret;
        }

        static StackObject* IsSleeping_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsSleeping();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsAwake_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsAwake();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Sleep_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Sleep();

            return __ret;
        }

        static StackObject* WakeUp_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WakeUp();

            return __ret;
        }

        static StackObject* get_simulated_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.simulated;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_simulated_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.simulated = value;

            return __ret;
        }

        static StackObject* get_interpolation_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.interpolation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_interpolation_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RigidbodyInterpolation2D value = (UnityEngine.RigidbodyInterpolation2D)typeof(UnityEngine.RigidbodyInterpolation2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.interpolation = value;

            return __ret;
        }

        static StackObject* get_sleepMode_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sleepMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_sleepMode_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RigidbodySleepMode2D value = (UnityEngine.RigidbodySleepMode2D)typeof(UnityEngine.RigidbodySleepMode2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.sleepMode = value;

            return __ret;
        }

        static StackObject* get_collisionDetectionMode_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.collisionDetectionMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_collisionDetectionMode_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CollisionDetectionMode2D value = (UnityEngine.CollisionDetectionMode2D)typeof(UnityEngine.CollisionDetectionMode2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.collisionDetectionMode = value;

            return __ret;
        }

        static StackObject* get_attachedColliderCount_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.attachedColliderCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetAttachedColliders_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])typeof(UnityEngine.Collider2D[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAttachedColliders(results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* IsTouching_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider2D collider = (UnityEngine.Collider2D)typeof(UnityEngine.Collider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsTouching(collider);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsTouching_52(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ContactFilter2D contactFilter = (UnityEngine.ContactFilter2D)typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Collider2D collider = (UnityEngine.Collider2D)typeof(UnityEngine.Collider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsTouching(collider, contactFilter);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsTouching_53(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ContactFilter2D contactFilter = (UnityEngine.ContactFilter2D)typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsTouching(contactFilter);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsTouchingLayers_54(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerMask = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsTouchingLayers(layerMask);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsTouchingLayers_55(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsTouchingLayers();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* OverlapPoint_56(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 point = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.OverlapPoint(point);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* OverlapCollider_57(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])typeof(UnityEngine.Collider2D[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ContactFilter2D contactFilter = (UnityEngine.ContactFilter2D)typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.OverlapCollider(contactFilter, results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Cast_58(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single distance = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 direction = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Cast(direction, results, distance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Cast_59(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 direction = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Cast(direction, results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Cast_60(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ContactFilter2D contactFilter = (UnityEngine.ContactFilter2D)typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 direction = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Cast(direction, contactFilter, results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Cast_61(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single distance = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])typeof(UnityEngine.RaycastHit2D[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ContactFilter2D contactFilter = (UnityEngine.ContactFilter2D)typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 direction = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Cast(direction, contactFilter, results, distance);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Distance_62(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider2D collider = (UnityEngine.Collider2D)typeof(UnityEngine.Collider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Distance(collider);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AddForce_63(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ForceMode2D mode = (UnityEngine.ForceMode2D)typeof(UnityEngine.ForceMode2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 force = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddForce(force, mode);

            return __ret;
        }

        static StackObject* AddForce_64(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 force = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddForce(force);

            return __ret;
        }

        static StackObject* AddRelativeForce_65(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ForceMode2D mode = (UnityEngine.ForceMode2D)typeof(UnityEngine.ForceMode2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 relativeForce = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddRelativeForce(relativeForce, mode);

            return __ret;
        }

        static StackObject* AddRelativeForce_66(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 relativeForce = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddRelativeForce(relativeForce);

            return __ret;
        }

        static StackObject* AddForceAtPosition_67(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ForceMode2D mode = (UnityEngine.ForceMode2D)typeof(UnityEngine.ForceMode2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 position = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 force = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddForceAtPosition(force, position, mode);

            return __ret;
        }

        static StackObject* AddForceAtPosition_68(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 position = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 force = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddForceAtPosition(force, position);

            return __ret;
        }

        static StackObject* AddTorque_69(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ForceMode2D mode = (UnityEngine.ForceMode2D)typeof(UnityEngine.ForceMode2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single torque = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddTorque(torque, mode);

            return __ret;
        }

        static StackObject* AddTorque_70(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single torque = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddTorque(torque);

            return __ret;
        }

        static StackObject* GetPoint_71(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 point = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPoint(point);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRelativePoint_72(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 relativePoint = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetRelativePoint(relativePoint);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetVector_73(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 vector = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetVector(vector);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRelativeVector_74(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 relativeVector = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetRelativeVector(relativeVector);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPointVelocity_75(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 point = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPointVelocity(point);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRelativePointVelocity_76(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 relativePoint = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetRelativePointVelocity(relativePoint);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetContacts_77(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ContactPoint2D[] contacts = (UnityEngine.ContactPoint2D[])typeof(UnityEngine.ContactPoint2D[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetContacts(contacts);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_78(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ContactPoint2D[] contacts = (UnityEngine.ContactPoint2D[])typeof(UnityEngine.ContactPoint2D[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ContactFilter2D contactFilter = (UnityEngine.ContactFilter2D)typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetContacts(contactFilter, contacts);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_79(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider2D[] colliders = (UnityEngine.Collider2D[])typeof(UnityEngine.Collider2D[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetContacts(colliders);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetContacts_80(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider2D[] colliders = (UnityEngine.Collider2D[])typeof(UnityEngine.Collider2D[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ContactFilter2D contactFilter = (UnityEngine.ContactFilter2D)typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rigidbody2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.Rigidbody2D)typeof(UnityEngine.Rigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetContacts(contactFilter, colliders);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Rigidbody2D();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
