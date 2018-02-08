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
    unsafe class UnityEngine_AI_NavMeshQueryFilter_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.AI.NavMeshQueryFilter);
            args = new Type[]{};
            method = type.GetMethod("get_areaMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_areaMask_0);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_areaMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_areaMask_1);
            args = new Type[]{};
            method = type.GetMethod("get_agentTypeID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_agentTypeID_2);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_agentTypeID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_agentTypeID_3);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetAreaCost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAreaCost_4);
            args = new Type[]{typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("SetAreaCost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAreaCost_5);


            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.AI.NavMeshQueryFilter());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AI.NavMeshQueryFilter[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.AI.NavMeshQueryFilter instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.AI.NavMeshQueryFilter[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* get_areaMask_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshQueryFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshQueryFilter)typeof(UnityEngine.AI.NavMeshQueryFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.areaMask;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_areaMask_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshQueryFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshQueryFilter)typeof(UnityEngine.AI.NavMeshQueryFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.areaMask = value;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* get_agentTypeID_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshQueryFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshQueryFilter)typeof(UnityEngine.AI.NavMeshQueryFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.agentTypeID;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_agentTypeID_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshQueryFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshQueryFilter)typeof(UnityEngine.AI.NavMeshQueryFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.agentTypeID = value;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* GetAreaCost_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 areaIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshQueryFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshQueryFilter)typeof(UnityEngine.AI.NavMeshQueryFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.GetAreaCost(areaIndex);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetAreaCost_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single cost = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 areaIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshQueryFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshQueryFilter)typeof(UnityEngine.AI.NavMeshQueryFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.SetAreaCost(areaIndex, cost);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }



        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.AI.NavMeshQueryFilter();
            ins = (UnityEngine.AI.NavMeshQueryFilter)o;
            return ins;
        }


    }
}
