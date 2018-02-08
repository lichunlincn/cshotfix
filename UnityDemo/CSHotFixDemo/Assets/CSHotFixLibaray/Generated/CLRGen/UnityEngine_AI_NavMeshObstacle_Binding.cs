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
    unsafe class UnityEngine_AI_NavMeshObstacle_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.AI.NavMeshObstacle);
            args = new Type[]{};
            method = type.GetMethod("get_height", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_height_0);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_height", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_height_1);
            args = new Type[]{};
            method = type.GetMethod("get_radius", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_radius_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_radius", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_radius_3);
            args = new Type[]{};
            method = type.GetMethod("get_velocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_velocity_4);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_velocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_velocity_5);
            args = new Type[]{};
            method = type.GetMethod("get_carving", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_carving_6);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_carving", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_carving_7);
            args = new Type[]{};
            method = type.GetMethod("get_carveOnlyStationary", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_carveOnlyStationary_8);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_carveOnlyStationary", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_carveOnlyStationary_9);
            args = new Type[]{};
            method = type.GetMethod("get_carvingMoveThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_carvingMoveThreshold_10);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_carvingMoveThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_carvingMoveThreshold_11);
            args = new Type[]{};
            method = type.GetMethod("get_carvingTimeToStationary", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_carvingTimeToStationary_12);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_carvingTimeToStationary", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_carvingTimeToStationary_13);
            args = new Type[]{};
            method = type.GetMethod("get_shape", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shape_14);
            args = new Type[]{typeof(UnityEngine.AI.NavMeshObstacleShape)};
            method = type.GetMethod("set_shape", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shape_15);
            args = new Type[]{};
            method = type.GetMethod("get_center", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_center_16);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_center", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_center_17);
            args = new Type[]{};
            method = type.GetMethod("get_size", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_size_18);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_size", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_size_19);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.AI.NavMeshObstacle());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AI.NavMeshObstacle[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_height_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshObstacle instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshObstacle)typeof(UnityEngine.AI.NavMeshObstacle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.height;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_height_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.NavMeshObstacle instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshObstacle)typeof(UnityEngine.AI.NavMeshObstacle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.height = value;

            return __ret;
        }

        static StackObject* get_radius_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshObstacle instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshObstacle)typeof(UnityEngine.AI.NavMeshObstacle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.radius;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_radius_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.NavMeshObstacle instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshObstacle)typeof(UnityEngine.AI.NavMeshObstacle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.radius = value;

            return __ret;
        }

        static StackObject* get_velocity_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshObstacle instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshObstacle)typeof(UnityEngine.AI.NavMeshObstacle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.velocity;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_velocity_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.NavMeshObstacle instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshObstacle)typeof(UnityEngine.AI.NavMeshObstacle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.velocity = value;

            return __ret;
        }

        static StackObject* get_carving_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshObstacle instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshObstacle)typeof(UnityEngine.AI.NavMeshObstacle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.carving;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_carving_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.NavMeshObstacle instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshObstacle)typeof(UnityEngine.AI.NavMeshObstacle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.carving = value;

            return __ret;
        }

        static StackObject* get_carveOnlyStationary_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshObstacle instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshObstacle)typeof(UnityEngine.AI.NavMeshObstacle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.carveOnlyStationary;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_carveOnlyStationary_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.NavMeshObstacle instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshObstacle)typeof(UnityEngine.AI.NavMeshObstacle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.carveOnlyStationary = value;

            return __ret;
        }

        static StackObject* get_carvingMoveThreshold_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshObstacle instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshObstacle)typeof(UnityEngine.AI.NavMeshObstacle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.carvingMoveThreshold;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_carvingMoveThreshold_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.NavMeshObstacle instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshObstacle)typeof(UnityEngine.AI.NavMeshObstacle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.carvingMoveThreshold = value;

            return __ret;
        }

        static StackObject* get_carvingTimeToStationary_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshObstacle instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshObstacle)typeof(UnityEngine.AI.NavMeshObstacle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.carvingTimeToStationary;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_carvingTimeToStationary_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.NavMeshObstacle instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshObstacle)typeof(UnityEngine.AI.NavMeshObstacle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.carvingTimeToStationary = value;

            return __ret;
        }

        static StackObject* get_shape_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshObstacle instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshObstacle)typeof(UnityEngine.AI.NavMeshObstacle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.shape;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_shape_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshObstacleShape value = (UnityEngine.AI.NavMeshObstacleShape)typeof(UnityEngine.AI.NavMeshObstacleShape).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.NavMeshObstacle instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshObstacle)typeof(UnityEngine.AI.NavMeshObstacle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.shape = value;

            return __ret;
        }

        static StackObject* get_center_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshObstacle instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshObstacle)typeof(UnityEngine.AI.NavMeshObstacle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.center;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_center_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.NavMeshObstacle instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshObstacle)typeof(UnityEngine.AI.NavMeshObstacle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.center = value;

            return __ret;
        }

        static StackObject* get_size_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshObstacle instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshObstacle)typeof(UnityEngine.AI.NavMeshObstacle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.size;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_size_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.NavMeshObstacle instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshObstacle)typeof(UnityEngine.AI.NavMeshObstacle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.size = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.AI.NavMeshObstacle();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
