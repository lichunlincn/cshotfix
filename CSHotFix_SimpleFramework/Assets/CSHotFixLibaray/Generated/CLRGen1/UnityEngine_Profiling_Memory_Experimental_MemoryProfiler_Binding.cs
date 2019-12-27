
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
    unsafe class UnityEngine_Profiling_Memory_Experimental_MemoryProfiler_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Profiling.Memory.Experimental.MemoryProfiler);
            args = new Type[]{typeof(System.String), typeof(System.Action<System.String, System.Boolean>), typeof(UnityEngine.Profiling.Memory.Experimental.CaptureFlags)};
            method = type.GetMethod("TakeSnapshot", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TakeSnapshot_0);
            args = new Type[]{typeof(System.Action<System.String, System.Boolean>), typeof(UnityEngine.Profiling.Memory.Experimental.CaptureFlags)};
            method = type.GetMethod("TakeTempSnapshot", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TakeTempSnapshot_1);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Profiling.Memory.Experimental.MemoryProfiler());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Profiling.Memory.Experimental.MemoryProfiler[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* TakeSnapshot_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Profiling.Memory.Experimental.CaptureFlags @captureFlags = (UnityEngine.Profiling.Memory.Experimental.CaptureFlags)typeof(UnityEngine.Profiling.Memory.Experimental.CaptureFlags).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Action<System.String, System.Boolean> @finishCallback = (System.Action<System.String, System.Boolean>)typeof(System.Action<System.String, System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @path = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Profiling.Memory.Experimental.MemoryProfiler.TakeSnapshot(@path, @finishCallback, @captureFlags);

            return __ret;
        }

        static StackObject* TakeTempSnapshot_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Profiling.Memory.Experimental.CaptureFlags @captureFlags = (UnityEngine.Profiling.Memory.Experimental.CaptureFlags)typeof(UnityEngine.Profiling.Memory.Experimental.CaptureFlags).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Action<System.String, System.Boolean> @finishCallback = (System.Action<System.String, System.Boolean>)typeof(System.Action<System.String, System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Profiling.Memory.Experimental.MemoryProfiler.TakeTempSnapshot(@finishCallback, @captureFlags);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Profiling.Memory.Experimental.MemoryProfiler();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
