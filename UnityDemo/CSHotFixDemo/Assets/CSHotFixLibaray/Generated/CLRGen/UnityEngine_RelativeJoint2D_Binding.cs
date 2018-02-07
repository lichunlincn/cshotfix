
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
    unsafe class UnityEngine_RelativeJoint2D_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.RelativeJoint2D);
            args = new Type[]{};
            method = type.GetMethod("get_maxForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxForce_0);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_maxForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxForce_1);
            args = new Type[]{};
            method = type.GetMethod("get_maxTorque", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxTorque_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_maxTorque", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxTorque_3);
            args = new Type[]{};
            method = type.GetMethod("get_correctionScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_correctionScale_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_correctionScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_correctionScale_5);
            args = new Type[]{};
            method = type.GetMethod("get_autoConfigureOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_autoConfigureOffset_6);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_autoConfigureOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_autoConfigureOffset_7);
            args = new Type[]{};
            method = type.GetMethod("get_linearOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_linearOffset_8);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("set_linearOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_linearOffset_9);
            args = new Type[]{};
            method = type.GetMethod("get_angularOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_angularOffset_10);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_angularOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_angularOffset_11);
            args = new Type[]{};
            method = type.GetMethod("get_target", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_target_12);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.RelativeJoint2D());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.RelativeJoint2D[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_maxForce_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RelativeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.RelativeJoint2D)typeof(UnityEngine.RelativeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxForce;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxForce_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RelativeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.RelativeJoint2D)typeof(UnityEngine.RelativeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maxForce = value;

            return __ret;
        }

        static StackObject* get_maxTorque_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RelativeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.RelativeJoint2D)typeof(UnityEngine.RelativeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxTorque;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxTorque_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RelativeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.RelativeJoint2D)typeof(UnityEngine.RelativeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maxTorque = value;

            return __ret;
        }

        static StackObject* get_correctionScale_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RelativeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.RelativeJoint2D)typeof(UnityEngine.RelativeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.correctionScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_correctionScale_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RelativeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.RelativeJoint2D)typeof(UnityEngine.RelativeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.correctionScale = value;

            return __ret;
        }

        static StackObject* get_autoConfigureOffset_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RelativeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.RelativeJoint2D)typeof(UnityEngine.RelativeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.autoConfigureOffset;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_autoConfigureOffset_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RelativeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.RelativeJoint2D)typeof(UnityEngine.RelativeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.autoConfigureOffset = value;

            return __ret;
        }

        static StackObject* get_linearOffset_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RelativeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.RelativeJoint2D)typeof(UnityEngine.RelativeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.linearOffset;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_linearOffset_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 value = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RelativeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.RelativeJoint2D)typeof(UnityEngine.RelativeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.linearOffset = value;

            return __ret;
        }

        static StackObject* get_angularOffset_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RelativeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.RelativeJoint2D)typeof(UnityEngine.RelativeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.angularOffset;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_angularOffset_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RelativeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.RelativeJoint2D)typeof(UnityEngine.RelativeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.angularOffset = value;

            return __ret;
        }

        static StackObject* get_target_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RelativeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.RelativeJoint2D)typeof(UnityEngine.RelativeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.target;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.RelativeJoint2D();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
