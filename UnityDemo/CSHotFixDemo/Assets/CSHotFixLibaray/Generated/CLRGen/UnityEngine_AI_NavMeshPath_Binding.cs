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
    unsafe class UnityEngine_AI_NavMeshPath_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.AI.NavMeshPath);
            args = new Type[]{typeof(UnityEngine.Vector3[])};
            method = type.GetMethod("GetCornersNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCornersNonAlloc_0);
            args = new Type[]{};
            method = type.GetMethod("ClearCorners", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearCorners_1);
            args = new Type[]{};
            method = type.GetMethod("get_corners", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_corners_2);
            args = new Type[]{};
            method = type.GetMethod("get_status", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_status_3);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.AI.NavMeshPath());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AI.NavMeshPath[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* GetCornersNonAlloc_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3[] results = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AI.NavMeshPath instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshPath)typeof(UnityEngine.AI.NavMeshPath).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCornersNonAlloc(results);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* ClearCorners_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshPath instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshPath)typeof(UnityEngine.AI.NavMeshPath).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClearCorners();

            return __ret;
        }

        static StackObject* get_corners_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshPath instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshPath)typeof(UnityEngine.AI.NavMeshPath).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.corners;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_status_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AI.NavMeshPath instance_of_this_method;
            instance_of_this_method = (UnityEngine.AI.NavMeshPath)typeof(UnityEngine.AI.NavMeshPath).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.status;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.AI.NavMeshPath();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
