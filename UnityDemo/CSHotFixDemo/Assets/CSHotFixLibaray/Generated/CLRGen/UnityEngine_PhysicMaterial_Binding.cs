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
    unsafe class UnityEngine_PhysicMaterial_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.PhysicMaterial);
            args = new Type[]{};
            method = type.GetMethod("get_dynamicFriction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_dynamicFriction_0);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_dynamicFriction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_dynamicFriction_1);
            args = new Type[]{};
            method = type.GetMethod("get_staticFriction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_staticFriction_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_staticFriction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_staticFriction_3);
            args = new Type[]{};
            method = type.GetMethod("get_bounciness", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_bounciness_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_bounciness", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_bounciness_5);
            args = new Type[]{};
            method = type.GetMethod("get_frictionCombine", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_frictionCombine_6);
            args = new Type[]{typeof(UnityEngine.PhysicMaterialCombine)};
            method = type.GetMethod("set_frictionCombine", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_frictionCombine_7);
            args = new Type[]{};
            method = type.GetMethod("get_bounceCombine", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_bounceCombine_8);
            args = new Type[]{typeof(UnityEngine.PhysicMaterialCombine)};
            method = type.GetMethod("set_bounceCombine", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_bounceCombine_9);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.PhysicMaterial());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.PhysicMaterial[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(System.String)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);

        }


        static StackObject* get_dynamicFriction_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PhysicMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.PhysicMaterial)typeof(UnityEngine.PhysicMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.dynamicFriction;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_dynamicFriction_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.PhysicMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.PhysicMaterial)typeof(UnityEngine.PhysicMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.dynamicFriction = value;

            return __ret;
        }

        static StackObject* get_staticFriction_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PhysicMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.PhysicMaterial)typeof(UnityEngine.PhysicMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.staticFriction;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_staticFriction_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.PhysicMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.PhysicMaterial)typeof(UnityEngine.PhysicMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.staticFriction = value;

            return __ret;
        }

        static StackObject* get_bounciness_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PhysicMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.PhysicMaterial)typeof(UnityEngine.PhysicMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.bounciness;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_bounciness_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.PhysicMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.PhysicMaterial)typeof(UnityEngine.PhysicMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.bounciness = value;

            return __ret;
        }

        static StackObject* get_frictionCombine_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PhysicMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.PhysicMaterial)typeof(UnityEngine.PhysicMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.frictionCombine;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_frictionCombine_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PhysicMaterialCombine value = (UnityEngine.PhysicMaterialCombine)typeof(UnityEngine.PhysicMaterialCombine).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.PhysicMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.PhysicMaterial)typeof(UnityEngine.PhysicMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.frictionCombine = value;

            return __ret;
        }

        static StackObject* get_bounceCombine_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PhysicMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.PhysicMaterial)typeof(UnityEngine.PhysicMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.bounceCombine;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_bounceCombine_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PhysicMaterialCombine value = (UnityEngine.PhysicMaterialCombine)typeof(UnityEngine.PhysicMaterialCombine).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.PhysicMaterial instance_of_this_method;
            instance_of_this_method = (UnityEngine.PhysicMaterial)typeof(UnityEngine.PhysicMaterial).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.bounceCombine = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.PhysicMaterial();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new UnityEngine.PhysicMaterial(name);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
