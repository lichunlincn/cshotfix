
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
    unsafe class UnityEngine_AreaEffector2D_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.AreaEffector2D);
            args = new Type[]{};
            method = type.GetMethod("get_forceAngle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_forceAngle_0);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_forceAngle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_forceAngle_1);
            args = new Type[]{};
            method = type.GetMethod("get_useGlobalAngle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useGlobalAngle_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_useGlobalAngle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useGlobalAngle_3);
            args = new Type[]{};
            method = type.GetMethod("get_forceMagnitude", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_forceMagnitude_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_forceMagnitude", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_forceMagnitude_5);
            args = new Type[]{};
            method = type.GetMethod("get_forceVariation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_forceVariation_6);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_forceVariation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_forceVariation_7);
            args = new Type[]{};
            method = type.GetMethod("get_drag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_drag_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_drag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_drag_9);
            args = new Type[]{};
            method = type.GetMethod("get_angularDrag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularDrag_10);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_angularDrag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularDrag_11);
            args = new Type[]{};
            method = type.GetMethod("get_forceTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_forceTarget_12);
            args = new Type[]{typeof(UnityEngine.EffectorSelection2D)};
            method = type.GetMethod("set_forceTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_forceTarget_13);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.AreaEffector2D());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AreaEffector2D[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_forceAngle_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AreaEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.AreaEffector2D)typeof(UnityEngine.AreaEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.forceAngle;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_forceAngle_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AreaEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.AreaEffector2D)typeof(UnityEngine.AreaEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.forceAngle = value;

            return __ret;
        }

        static StackObject* get_useGlobalAngle_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AreaEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.AreaEffector2D)typeof(UnityEngine.AreaEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useGlobalAngle;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useGlobalAngle_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AreaEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.AreaEffector2D)typeof(UnityEngine.AreaEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useGlobalAngle = value;

            return __ret;
        }

        static StackObject* get_forceMagnitude_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AreaEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.AreaEffector2D)typeof(UnityEngine.AreaEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.forceMagnitude;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_forceMagnitude_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AreaEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.AreaEffector2D)typeof(UnityEngine.AreaEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.forceMagnitude = value;

            return __ret;
        }

        static StackObject* get_forceVariation_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AreaEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.AreaEffector2D)typeof(UnityEngine.AreaEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.forceVariation;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_forceVariation_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AreaEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.AreaEffector2D)typeof(UnityEngine.AreaEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.forceVariation = value;

            return __ret;
        }

        static StackObject* get_drag_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AreaEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.AreaEffector2D)typeof(UnityEngine.AreaEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.drag;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_drag_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AreaEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.AreaEffector2D)typeof(UnityEngine.AreaEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.drag = value;

            return __ret;
        }

        static StackObject* get_angularDrag_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AreaEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.AreaEffector2D)typeof(UnityEngine.AreaEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angularDrag;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_angularDrag_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AreaEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.AreaEffector2D)typeof(UnityEngine.AreaEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.angularDrag = value;

            return __ret;
        }

        static StackObject* get_forceTarget_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AreaEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.AreaEffector2D)typeof(UnityEngine.AreaEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.forceTarget;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_forceTarget_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.EffectorSelection2D value = (UnityEngine.EffectorSelection2D)typeof(UnityEngine.EffectorSelection2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AreaEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.AreaEffector2D)typeof(UnityEngine.AreaEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.forceTarget = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.AreaEffector2D();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
