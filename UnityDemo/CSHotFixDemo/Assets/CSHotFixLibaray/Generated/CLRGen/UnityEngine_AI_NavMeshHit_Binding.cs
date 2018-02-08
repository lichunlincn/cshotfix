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
    unsafe class UnityEngine_AI_NavMeshHit_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.AI.NavMeshHit);
            args = new Type[]{};
            method = type.GetMethod("get_position", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_position_0);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_position", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_position_1);
            args = new Type[]{};
            method = type.GetMethod("get_normal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_normal_2);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_normal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_normal_3);
            args = new Type[]{};
            method = type.GetMethod("get_distance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_distance_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_distance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_distance_5);
            args = new Type[]{};
            method = type.GetMethod("get_mask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mask_6);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_mask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_mask_7);
            args = new Type[]{};
            method = type.GetMethod("get_hit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hit_8);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_hit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hit_9);


            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.AI.NavMeshHit());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AI.NavMeshHit[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.AI.NavMeshHit instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.AI.NavMeshHit[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* get_position_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshHit instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshHit)typeof(UnityEngine.AI.NavMeshHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.position;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_position_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshHit instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshHit)typeof(UnityEngine.AI.NavMeshHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.position = value;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* get_normal_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshHit instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshHit)typeof(UnityEngine.AI.NavMeshHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.normal;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_normal_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshHit instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshHit)typeof(UnityEngine.AI.NavMeshHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.normal = value;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* get_distance_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshHit instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshHit)typeof(UnityEngine.AI.NavMeshHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.distance;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_distance_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshHit instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshHit)typeof(UnityEngine.AI.NavMeshHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.distance = value;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* get_mask_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshHit instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshHit)typeof(UnityEngine.AI.NavMeshHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.mask;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_mask_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshHit instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshHit)typeof(UnityEngine.AI.NavMeshHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.mask = value;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* get_hit_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshHit instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshHit)typeof(UnityEngine.AI.NavMeshHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.hit;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_hit_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshHit instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshHit)typeof(UnityEngine.AI.NavMeshHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.hit = value;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }



        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.AI.NavMeshHit();
            ins = (UnityEngine.AI.NavMeshHit)o;
            return ins;
        }


    }
}
