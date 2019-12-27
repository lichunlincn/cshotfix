
#if CSHotFix
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
using System.Linq;
namespace CSHotFix.Runtime.Generated
{
    unsafe class UnityEngine_Scripting_GarbageCollector_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Scripting.GarbageCollector);
            args = new Type[]{};
            method = type.GetMethod("get_GCMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GCMode_0);
            args = new Type[]{typeof(UnityEngine.Scripting.GarbageCollector.Mode)};
            method = type.GetMethod("set_GCMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_GCMode_1);
            args = new Type[]{};
            method = type.GetMethod("get_isIncremental", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isIncremental_2);
            args = new Type[]{};
            method = type.GetMethod("get_incrementalTimeSliceNanoseconds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_incrementalTimeSliceNanoseconds_3);
            args = new Type[]{typeof(System.UInt64)};
            method = type.GetMethod("set_incrementalTimeSliceNanoseconds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_incrementalTimeSliceNanoseconds_4);
            args = new Type[]{typeof(System.UInt64)};
            method = type.GetMethod("CollectIncremental", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CollectIncremental_5);





        }


        static StackObject* get_GCMode_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Scripting.GarbageCollector.GCMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_GCMode_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Scripting.GarbageCollector.Mode @value = (UnityEngine.Scripting.GarbageCollector.Mode)typeof(UnityEngine.Scripting.GarbageCollector.Mode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Scripting.GarbageCollector.GCMode = value;

            return __ret;
        }

        static StackObject* get_isIncremental_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Scripting.GarbageCollector.isIncremental;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_incrementalTimeSliceNanoseconds_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Scripting.GarbageCollector.incrementalTimeSliceNanoseconds;

            __ret->ObjectType = ObjectTypes.Long;
            *(ulong*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_incrementalTimeSliceNanoseconds_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @value = *(ulong*)&ptr_of_this_method->Value;


            UnityEngine.Scripting.GarbageCollector.incrementalTimeSliceNanoseconds = value;

            return __ret;
        }

        static StackObject* CollectIncremental_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @nanoseconds = *(ulong*)&ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Scripting.GarbageCollector.CollectIncremental(@nanoseconds);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }





    }
}
#endif
