
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
    unsafe class UnityEngine_AI_OffMeshLink_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.AI.OffMeshLink);
            args = new Type[]{};
            method = type.GetMethod("get_activated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_activated_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_activated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_activated_1);
            args = new Type[]{};
            method = type.GetMethod("get_occupied", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_occupied_2);
            args = new Type[]{};
            method = type.GetMethod("get_costOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_costOverride_3);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_costOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_costOverride_4);
            args = new Type[]{};
            method = type.GetMethod("get_biDirectional", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_biDirectional_5);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_biDirectional", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_biDirectional_6);
            args = new Type[]{};
            method = type.GetMethod("UpdatePositions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UpdatePositions_7);
            args = new Type[]{};
            method = type.GetMethod("get_area", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_area_8);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_area", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_area_9);
            args = new Type[]{};
            method = type.GetMethod("get_autoUpdatePositions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_autoUpdatePositions_10);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_autoUpdatePositions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_autoUpdatePositions_11);
            args = new Type[]{};
            method = type.GetMethod("get_startTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_startTransform_12);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("set_startTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_startTransform_13);
            args = new Type[]{};
            method = type.GetMethod("get_endTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_endTransform_14);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("set_endTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_endTransform_15);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.AI.OffMeshLink());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AI.OffMeshLink[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_activated_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.OffMeshLink instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.OffMeshLink)typeof(UnityEngine.AI.OffMeshLink).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.activated;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_activated_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.OffMeshLink instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.OffMeshLink)typeof(UnityEngine.AI.OffMeshLink).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.activated = value;

            return __ret;
        }

        static StackObject* get_occupied_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.OffMeshLink instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.OffMeshLink)typeof(UnityEngine.AI.OffMeshLink).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.occupied;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_costOverride_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.OffMeshLink instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.OffMeshLink)typeof(UnityEngine.AI.OffMeshLink).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.costOverride;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_costOverride_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.OffMeshLink instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.OffMeshLink)typeof(UnityEngine.AI.OffMeshLink).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.costOverride = value;

            return __ret;
        }

        static StackObject* get_biDirectional_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.OffMeshLink instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.OffMeshLink)typeof(UnityEngine.AI.OffMeshLink).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.biDirectional;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_biDirectional_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.OffMeshLink instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.OffMeshLink)typeof(UnityEngine.AI.OffMeshLink).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.biDirectional = value;

            return __ret;
        }

        static StackObject* UpdatePositions_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.OffMeshLink instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.OffMeshLink)typeof(UnityEngine.AI.OffMeshLink).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UpdatePositions();

            return __ret;
        }

        static StackObject* get_area_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.OffMeshLink instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.OffMeshLink)typeof(UnityEngine.AI.OffMeshLink).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.area;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_area_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.OffMeshLink instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.OffMeshLink)typeof(UnityEngine.AI.OffMeshLink).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.area = value;

            return __ret;
        }

        static StackObject* get_autoUpdatePositions_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.OffMeshLink instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.OffMeshLink)typeof(UnityEngine.AI.OffMeshLink).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.autoUpdatePositions;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_autoUpdatePositions_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.OffMeshLink instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.OffMeshLink)typeof(UnityEngine.AI.OffMeshLink).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.autoUpdatePositions = value;

            return __ret;
        }

        static StackObject* get_startTransform_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.OffMeshLink instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.OffMeshLink)typeof(UnityEngine.AI.OffMeshLink).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.startTransform;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_startTransform_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform value = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.OffMeshLink instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.OffMeshLink)typeof(UnityEngine.AI.OffMeshLink).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.startTransform = value;

            return __ret;
        }

        static StackObject* get_endTransform_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.OffMeshLink instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.OffMeshLink)typeof(UnityEngine.AI.OffMeshLink).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.endTransform;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_endTransform_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform value = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.OffMeshLink instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.OffMeshLink)typeof(UnityEngine.AI.OffMeshLink).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.endTransform = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.AI.OffMeshLink();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
