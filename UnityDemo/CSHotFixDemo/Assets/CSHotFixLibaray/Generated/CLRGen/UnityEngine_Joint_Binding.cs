
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
    unsafe class UnityEngine_Joint_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Joint);
            args = new Type[]{};
            method = type.GetMethod("get_connectedBody", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_connectedBody_0);
            args = new Type[]{typeof(UnityEngine.Rigidbody)};
            method = type.GetMethod("set_connectedBody", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_connectedBody_1);
            args = new Type[]{};
            method = type.GetMethod("get_axis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_axis_2);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_axis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_axis_3);
            args = new Type[]{};
            method = type.GetMethod("get_anchor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_anchor_4);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_anchor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_anchor_5);
            args = new Type[]{};
            method = type.GetMethod("get_connectedAnchor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_connectedAnchor_6);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_connectedAnchor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_connectedAnchor_7);
            args = new Type[]{};
            method = type.GetMethod("get_autoConfigureConnectedAnchor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_autoConfigureConnectedAnchor_8);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_autoConfigureConnectedAnchor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_autoConfigureConnectedAnchor_9);
            args = new Type[]{};
            method = type.GetMethod("get_breakForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_breakForce_10);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_breakForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_breakForce_11);
            args = new Type[]{};
            method = type.GetMethod("get_breakTorque", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_breakTorque_12);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_breakTorque", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_breakTorque_13);
            args = new Type[]{};
            method = type.GetMethod("get_enableCollision", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_enableCollision_14);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_enableCollision", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_enableCollision_15);
            args = new Type[]{};
            method = type.GetMethod("get_enablePreprocessing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_enablePreprocessing_16);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_enablePreprocessing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_enablePreprocessing_17);
            args = new Type[]{};
            method = type.GetMethod("get_currentForce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentForce_18);
            args = new Type[]{};
            method = type.GetMethod("get_currentTorque", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentTorque_19);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Joint());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Joint[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_connectedBody_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Joint instance_of_this_method;
            instance_of_this_method = (UnityEngine.Joint)typeof(UnityEngine.Joint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.connectedBody;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_connectedBody_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rigidbody value = (UnityEngine.Rigidbody)typeof(UnityEngine.Rigidbody).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Joint instance_of_this_method;
            instance_of_this_method = (UnityEngine.Joint)typeof(UnityEngine.Joint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.connectedBody = value;

            return __ret;
        }

        static StackObject* get_axis_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Joint instance_of_this_method;
            instance_of_this_method = (UnityEngine.Joint)typeof(UnityEngine.Joint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.axis;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_axis_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Joint instance_of_this_method;
            instance_of_this_method = (UnityEngine.Joint)typeof(UnityEngine.Joint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.axis = value;

            return __ret;
        }

        static StackObject* get_anchor_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Joint instance_of_this_method;
            instance_of_this_method = (UnityEngine.Joint)typeof(UnityEngine.Joint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.anchor;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_anchor_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Joint instance_of_this_method;
            instance_of_this_method = (UnityEngine.Joint)typeof(UnityEngine.Joint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.anchor = value;

            return __ret;
        }

        static StackObject* get_connectedAnchor_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Joint instance_of_this_method;
            instance_of_this_method = (UnityEngine.Joint)typeof(UnityEngine.Joint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.connectedAnchor;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_connectedAnchor_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Joint instance_of_this_method;
            instance_of_this_method = (UnityEngine.Joint)typeof(UnityEngine.Joint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.connectedAnchor = value;

            return __ret;
        }

        static StackObject* get_autoConfigureConnectedAnchor_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Joint instance_of_this_method;
            instance_of_this_method = (UnityEngine.Joint)typeof(UnityEngine.Joint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.autoConfigureConnectedAnchor;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_autoConfigureConnectedAnchor_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Joint instance_of_this_method;
            instance_of_this_method = (UnityEngine.Joint)typeof(UnityEngine.Joint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.autoConfigureConnectedAnchor = value;

            return __ret;
        }

        static StackObject* get_breakForce_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Joint instance_of_this_method;
            instance_of_this_method = (UnityEngine.Joint)typeof(UnityEngine.Joint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.breakForce;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_breakForce_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Joint instance_of_this_method;
            instance_of_this_method = (UnityEngine.Joint)typeof(UnityEngine.Joint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.breakForce = value;

            return __ret;
        }

        static StackObject* get_breakTorque_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Joint instance_of_this_method;
            instance_of_this_method = (UnityEngine.Joint)typeof(UnityEngine.Joint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.breakTorque;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_breakTorque_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Joint instance_of_this_method;
            instance_of_this_method = (UnityEngine.Joint)typeof(UnityEngine.Joint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.breakTorque = value;

            return __ret;
        }

        static StackObject* get_enableCollision_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Joint instance_of_this_method;
            instance_of_this_method = (UnityEngine.Joint)typeof(UnityEngine.Joint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.enableCollision;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_enableCollision_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Joint instance_of_this_method;
            instance_of_this_method = (UnityEngine.Joint)typeof(UnityEngine.Joint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.enableCollision = value;

            return __ret;
        }

        static StackObject* get_enablePreprocessing_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Joint instance_of_this_method;
            instance_of_this_method = (UnityEngine.Joint)typeof(UnityEngine.Joint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.enablePreprocessing;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_enablePreprocessing_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Joint instance_of_this_method;
            instance_of_this_method = (UnityEngine.Joint)typeof(UnityEngine.Joint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.enablePreprocessing = value;

            return __ret;
        }

        static StackObject* get_currentForce_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Joint instance_of_this_method;
            instance_of_this_method = (UnityEngine.Joint)typeof(UnityEngine.Joint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.currentForce;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_currentTorque_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Joint instance_of_this_method;
            instance_of_this_method = (UnityEngine.Joint)typeof(UnityEngine.Joint).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.currentTorque;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Joint();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
