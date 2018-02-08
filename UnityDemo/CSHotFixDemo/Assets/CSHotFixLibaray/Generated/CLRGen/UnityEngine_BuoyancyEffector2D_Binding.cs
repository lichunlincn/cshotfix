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
    unsafe class UnityEngine_BuoyancyEffector2D_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.BuoyancyEffector2D);
            args = new Type[]{};
            method = type.GetMethod("get_surfaceLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_surfaceLevel_0);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_surfaceLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_surfaceLevel_1);
            args = new Type[]{};
            method = type.GetMethod("get_density", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_density_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_density", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_density_3);
            args = new Type[]{};
            method = type.GetMethod("get_linearDrag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_linearDrag_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_linearDrag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_linearDrag_5);
            args = new Type[]{};
            method = type.GetMethod("get_angularDrag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularDrag_6);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_angularDrag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularDrag_7);
            args = new Type[]{};
            method = type.GetMethod("get_flowAngle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_flowAngle_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_flowAngle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_flowAngle_9);
            args = new Type[]{};
            method = type.GetMethod("get_flowMagnitude", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_flowMagnitude_10);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_flowMagnitude", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_flowMagnitude_11);
            args = new Type[]{};
            method = type.GetMethod("get_flowVariation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_flowVariation_12);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_flowVariation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_flowVariation_13);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.BuoyancyEffector2D());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.BuoyancyEffector2D[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_surfaceLevel_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.BuoyancyEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.BuoyancyEffector2D)typeof(UnityEngine.BuoyancyEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.surfaceLevel;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_surfaceLevel_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.BuoyancyEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.BuoyancyEffector2D)typeof(UnityEngine.BuoyancyEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.surfaceLevel = value;

            return __ret;
        }

        static StackObject* get_density_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.BuoyancyEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.BuoyancyEffector2D)typeof(UnityEngine.BuoyancyEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.density;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_density_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.BuoyancyEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.BuoyancyEffector2D)typeof(UnityEngine.BuoyancyEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.density = value;

            return __ret;
        }

        static StackObject* get_linearDrag_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.BuoyancyEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.BuoyancyEffector2D)typeof(UnityEngine.BuoyancyEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.linearDrag;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_linearDrag_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.BuoyancyEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.BuoyancyEffector2D)typeof(UnityEngine.BuoyancyEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.linearDrag = value;

            return __ret;
        }

        static StackObject* get_angularDrag_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.BuoyancyEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.BuoyancyEffector2D)typeof(UnityEngine.BuoyancyEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angularDrag;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_angularDrag_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.BuoyancyEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.BuoyancyEffector2D)typeof(UnityEngine.BuoyancyEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.angularDrag = value;

            return __ret;
        }

        static StackObject* get_flowAngle_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.BuoyancyEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.BuoyancyEffector2D)typeof(UnityEngine.BuoyancyEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.flowAngle;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_flowAngle_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.BuoyancyEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.BuoyancyEffector2D)typeof(UnityEngine.BuoyancyEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.flowAngle = value;

            return __ret;
        }

        static StackObject* get_flowMagnitude_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.BuoyancyEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.BuoyancyEffector2D)typeof(UnityEngine.BuoyancyEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.flowMagnitude;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_flowMagnitude_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.BuoyancyEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.BuoyancyEffector2D)typeof(UnityEngine.BuoyancyEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.flowMagnitude = value;

            return __ret;
        }

        static StackObject* get_flowVariation_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.BuoyancyEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.BuoyancyEffector2D)typeof(UnityEngine.BuoyancyEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.flowVariation;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_flowVariation_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.BuoyancyEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.BuoyancyEffector2D)typeof(UnityEngine.BuoyancyEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.flowVariation = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.BuoyancyEffector2D();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
