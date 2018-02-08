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
    unsafe class UnityEngine_AI_NavMesh_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.AI.NavMesh);
            args = new Type[]{typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.AI.NavMeshHit).MakeByRefType(), typeof(System.Int32)};
            method = type.GetMethod("Raycast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Raycast_0);
            args = new Type[]{typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Int32), typeof(UnityEngine.AI.NavMeshPath)};
            method = type.GetMethod("CalculatePath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CalculatePath_1);
            args = new Type[]{typeof(UnityEngine.Vector3), typeof(UnityEngine.AI.NavMeshHit).MakeByRefType(), typeof(System.Int32)};
            method = type.GetMethod("FindClosestEdge", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindClosestEdge_2);
            args = new Type[]{typeof(UnityEngine.Vector3), typeof(UnityEngine.AI.NavMeshHit).MakeByRefType(), typeof(System.Single), typeof(System.Int32)};
            method = type.GetMethod("SamplePosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SamplePosition_3);
            args = new Type[]{typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("SetAreaCost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAreaCost_4);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetAreaCost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAreaCost_5);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetAreaFromName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAreaFromName_6);
            args = new Type[]{};
            method = type.GetMethod("CalculateTriangulation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CalculateTriangulation_7);
            args = new Type[]{};
            method = type.GetMethod("get_avoidancePredictionTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_avoidancePredictionTime_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_avoidancePredictionTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_avoidancePredictionTime_9);
            args = new Type[]{};
            method = type.GetMethod("get_pathfindingIterationsPerFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pathfindingIterationsPerFrame_10);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_pathfindingIterationsPerFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_pathfindingIterationsPerFrame_11);
            args = new Type[]{typeof(UnityEngine.AI.NavMeshData)};
            method = type.GetMethod("AddNavMeshData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddNavMeshData_12);
            args = new Type[]{typeof(UnityEngine.AI.NavMeshData), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("AddNavMeshData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddNavMeshData_13);
            args = new Type[]{typeof(UnityEngine.AI.NavMeshDataInstance)};
            method = type.GetMethod("RemoveNavMeshData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveNavMeshData_14);
            args = new Type[]{typeof(UnityEngine.AI.NavMeshLinkData)};
            method = type.GetMethod("AddLink", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddLink_15);
            args = new Type[]{typeof(UnityEngine.AI.NavMeshLinkData), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("AddLink", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddLink_16);
            args = new Type[]{typeof(UnityEngine.AI.NavMeshLinkInstance)};
            method = type.GetMethod("RemoveLink", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveLink_17);
            args = new Type[]{typeof(UnityEngine.Vector3), typeof(UnityEngine.AI.NavMeshHit).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.AI.NavMeshQueryFilter)};
            method = type.GetMethod("SamplePosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SamplePosition_18);
            args = new Type[]{typeof(UnityEngine.Vector3), typeof(UnityEngine.AI.NavMeshHit).MakeByRefType(), typeof(UnityEngine.AI.NavMeshQueryFilter)};
            method = type.GetMethod("FindClosestEdge", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindClosestEdge_19);
            args = new Type[]{typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.AI.NavMeshHit).MakeByRefType(), typeof(UnityEngine.AI.NavMeshQueryFilter)};
            method = type.GetMethod("Raycast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Raycast_20);
            args = new Type[]{typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.AI.NavMeshQueryFilter), typeof(UnityEngine.AI.NavMeshPath)};
            method = type.GetMethod("CalculatePath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CalculatePath_21);
            args = new Type[]{};
            method = type.GetMethod("CreateSettings", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateSettings_22);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("RemoveSettings", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveSettings_23);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetSettingsByID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSettingsByID_24);
            args = new Type[]{};
            method = type.GetMethod("GetSettingsCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSettingsCount_25);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetSettingsByIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSettingsByIndex_26);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetSettingsNameFromID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSettingsNameFromID_27);

            field = type.GetField("onPreUpdate", flag);
            app.RegisterCLRFieldGetter(field, get_onPreUpdate_0);
            app.RegisterCLRFieldSetter(field, set_onPreUpdate_0);
            field = type.GetField("AllAreas", flag);
            app.RegisterCLRFieldGetter(field, get_AllAreas_1);




        }


        static StackObject* Raycast_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 areaMask = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshHit hit = (UnityEngine.AI.NavMeshHit)typeof(UnityEngine.AI.NavMeshHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 targetPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector3 sourcePosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.AI.NavMesh.Raycast(sourcePosition, targetPosition, out hit, areaMask);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = hit;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = hit;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, hit);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = hit;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, hit);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.AI.NavMeshHit[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = hit;
                    }
                    break;
            }

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CalculatePath_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshPath path = (UnityEngine.AI.NavMeshPath)typeof(UnityEngine.AI.NavMeshPath).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 areaMask = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 targetPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector3 sourcePosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.AI.NavMesh.CalculatePath(sourcePosition, targetPosition, areaMask, path);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* FindClosestEdge_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 areaMask = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshHit hit = (UnityEngine.AI.NavMeshHit)typeof(UnityEngine.AI.NavMeshHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 sourcePosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.AI.NavMesh.FindClosestEdge(sourcePosition, out hit, areaMask);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = hit;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = hit;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, hit);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = hit;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, hit);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.AI.NavMeshHit[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = hit;
                    }
                    break;
            }

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SamplePosition_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 areaMask = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single maxDistance = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshHit hit = (UnityEngine.AI.NavMeshHit)typeof(UnityEngine.AI.NavMeshHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector3 sourcePosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.AI.NavMesh.SamplePosition(sourcePosition, out hit, maxDistance, areaMask);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = hit;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = hit;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, hit);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = hit;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, hit);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.AI.NavMeshHit[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = hit;
                    }
                    break;
            }

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetAreaCost_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single cost = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 areaIndex = ptr_of_this_method->Value;

            UnityEngine.AI.NavMesh.SetAreaCost(areaIndex, cost);

            return __ret;
        }

        static StackObject* GetAreaCost_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 areaIndex = ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.AI.NavMesh.GetAreaCost(areaIndex);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetAreaFromName_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String areaName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.AI.NavMesh.GetAreaFromName(areaName);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CalculateTriangulation_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.AI.NavMesh.CalculateTriangulation();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_avoidancePredictionTime_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.AI.NavMesh.avoidancePredictionTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_avoidancePredictionTime_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;

            UnityEngine.AI.NavMesh.avoidancePredictionTime = value;

            return __ret;
        }

        static StackObject* get_pathfindingIterationsPerFrame_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.AI.NavMesh.pathfindingIterationsPerFrame;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_pathfindingIterationsPerFrame_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;

            UnityEngine.AI.NavMesh.pathfindingIterationsPerFrame = value;

            return __ret;
        }

        static StackObject* AddNavMeshData_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshData navMeshData = (UnityEngine.AI.NavMeshData)typeof(UnityEngine.AI.NavMeshData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.AI.NavMesh.AddNavMeshData(navMeshData);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AddNavMeshData_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AI.NavMeshData navMeshData = (UnityEngine.AI.NavMeshData)typeof(UnityEngine.AI.NavMeshData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.AI.NavMesh.AddNavMeshData(navMeshData, position, rotation);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RemoveNavMeshData_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshDataInstance handle = (UnityEngine.AI.NavMeshDataInstance)typeof(UnityEngine.AI.NavMeshDataInstance).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.AI.NavMesh.RemoveNavMeshData(handle);

            return __ret;
        }

        static StackObject* AddLink_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshLinkData link = (UnityEngine.AI.NavMeshLinkData)typeof(UnityEngine.AI.NavMeshLinkData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.AI.NavMesh.AddLink(link);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AddLink_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AI.NavMeshLinkData link = (UnityEngine.AI.NavMeshLinkData)typeof(UnityEngine.AI.NavMeshLinkData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.AI.NavMesh.AddLink(link, position, rotation);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RemoveLink_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshLinkInstance handle = (UnityEngine.AI.NavMeshLinkInstance)typeof(UnityEngine.AI.NavMeshLinkInstance).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.AI.NavMesh.RemoveLink(handle);

            return __ret;
        }

        static StackObject* SamplePosition_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshQueryFilter filter = (UnityEngine.AI.NavMeshQueryFilter)typeof(UnityEngine.AI.NavMeshQueryFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single maxDistance = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshHit hit = (UnityEngine.AI.NavMeshHit)typeof(UnityEngine.AI.NavMeshHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector3 sourcePosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.AI.NavMesh.SamplePosition(sourcePosition, out hit, maxDistance, filter);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = hit;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = hit;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, hit);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = hit;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, hit);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.AI.NavMeshHit[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = hit;
                    }
                    break;
            }

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* FindClosestEdge_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshQueryFilter filter = (UnityEngine.AI.NavMeshQueryFilter)typeof(UnityEngine.AI.NavMeshQueryFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshHit hit = (UnityEngine.AI.NavMeshHit)typeof(UnityEngine.AI.NavMeshHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 sourcePosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.AI.NavMesh.FindClosestEdge(sourcePosition, out hit, filter);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = hit;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = hit;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, hit);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = hit;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, hit);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.AI.NavMeshHit[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = hit;
                    }
                    break;
            }

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Raycast_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshQueryFilter filter = (UnityEngine.AI.NavMeshQueryFilter)typeof(UnityEngine.AI.NavMeshQueryFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.AI.NavMeshHit hit = (UnityEngine.AI.NavMeshHit)typeof(UnityEngine.AI.NavMeshHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 targetPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector3 sourcePosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.AI.NavMesh.Raycast(sourcePosition, targetPosition, out hit, filter);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = hit;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = hit;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, hit);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = hit;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, hit);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.AI.NavMeshHit[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = hit;
                    }
                    break;
            }

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CalculatePath_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshPath path = (UnityEngine.AI.NavMeshPath)typeof(UnityEngine.AI.NavMeshPath).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.NavMeshQueryFilter filter = (UnityEngine.AI.NavMeshQueryFilter)typeof(UnityEngine.AI.NavMeshQueryFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 targetPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector3 sourcePosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.AI.NavMesh.CalculatePath(sourcePosition, targetPosition, filter, path);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CreateSettings_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.AI.NavMesh.CreateSettings();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RemoveSettings_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 agentTypeID = ptr_of_this_method->Value;

            UnityEngine.AI.NavMesh.RemoveSettings(agentTypeID);

            return __ret;
        }

        static StackObject* GetSettingsByID_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 agentTypeID = ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.AI.NavMesh.GetSettingsByID(agentTypeID);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetSettingsCount_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.AI.NavMesh.GetSettingsCount();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetSettingsByIndex_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.AI.NavMesh.GetSettingsByIndex(index);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetSettingsNameFromID_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 agentTypeID = ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.AI.NavMesh.GetSettingsNameFromID(agentTypeID);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_onPreUpdate_0(ref object o)
        {
            return UnityEngine.AI.NavMesh.onPreUpdate;
        }
        static void set_onPreUpdate_0(ref object o, object v)
        {
            UnityEngine.AI.NavMesh.onPreUpdate = (UnityEngine.AI.NavMesh.OnNavMeshPreUpdate)v;
        }
        static object get_AllAreas_1(ref object o)
        {
            return UnityEngine.AI.NavMesh.AllAreas;
        }



    }
}
