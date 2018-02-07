
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
    unsafe class UnityEngine_PlatformEffector2D_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.PlatformEffector2D);
            args = new Type[]{};
            method = type.GetMethod("get_useOneWay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useOneWay_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_useOneWay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useOneWay_1);
            args = new Type[]{};
            method = type.GetMethod("get_useOneWayGrouping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useOneWayGrouping_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_useOneWayGrouping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useOneWayGrouping_3);
            args = new Type[]{};
            method = type.GetMethod("get_useSideFriction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useSideFriction_4);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_useSideFriction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useSideFriction_5);
            args = new Type[]{};
            method = type.GetMethod("get_useSideBounce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useSideBounce_6);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_useSideBounce", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useSideBounce_7);
            args = new Type[]{};
            method = type.GetMethod("get_surfaceArc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_surfaceArc_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_surfaceArc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_surfaceArc_9);
            args = new Type[]{};
            method = type.GetMethod("get_sideArc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sideArc_10);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_sideArc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sideArc_11);
            args = new Type[]{};
            method = type.GetMethod("get_rotationalOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rotationalOffset_12);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_rotationalOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rotationalOffset_13);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.PlatformEffector2D());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.PlatformEffector2D[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_useOneWay_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PlatformEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PlatformEffector2D)typeof(UnityEngine.PlatformEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useOneWay;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useOneWay_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.PlatformEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PlatformEffector2D)typeof(UnityEngine.PlatformEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useOneWay = value;

            return __ret;
        }

        static StackObject* get_useOneWayGrouping_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PlatformEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PlatformEffector2D)typeof(UnityEngine.PlatformEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useOneWayGrouping;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useOneWayGrouping_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.PlatformEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PlatformEffector2D)typeof(UnityEngine.PlatformEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useOneWayGrouping = value;

            return __ret;
        }

        static StackObject* get_useSideFriction_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PlatformEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PlatformEffector2D)typeof(UnityEngine.PlatformEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useSideFriction;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useSideFriction_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.PlatformEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PlatformEffector2D)typeof(UnityEngine.PlatformEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useSideFriction = value;

            return __ret;
        }

        static StackObject* get_useSideBounce_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PlatformEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PlatformEffector2D)typeof(UnityEngine.PlatformEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useSideBounce;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useSideBounce_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.PlatformEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PlatformEffector2D)typeof(UnityEngine.PlatformEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useSideBounce = value;

            return __ret;
        }

        static StackObject* get_surfaceArc_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PlatformEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PlatformEffector2D)typeof(UnityEngine.PlatformEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.surfaceArc;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_surfaceArc_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.PlatformEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PlatformEffector2D)typeof(UnityEngine.PlatformEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.surfaceArc = value;

            return __ret;
        }

        static StackObject* get_sideArc_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PlatformEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PlatformEffector2D)typeof(UnityEngine.PlatformEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sideArc;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_sideArc_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.PlatformEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PlatformEffector2D)typeof(UnityEngine.PlatformEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.sideArc = value;

            return __ret;
        }

        static StackObject* get_rotationalOffset_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PlatformEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PlatformEffector2D)typeof(UnityEngine.PlatformEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rotationalOffset;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_rotationalOffset_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.PlatformEffector2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PlatformEffector2D)typeof(UnityEngine.PlatformEffector2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.rotationalOffset = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.PlatformEffector2D();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
