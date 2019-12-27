
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
    unsafe class UnityEngine_FrameTimingManager_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.FrameTimingManager);
            args = new Type[]{};
            method = type.GetMethod("CaptureFrameTimings", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CaptureFrameTimings_0);
            args = new Type[]{typeof(System.UInt32), typeof(UnityEngine.FrameTiming[])};
            method = type.GetMethod("GetLatestTimings", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLatestTimings_1);
            args = new Type[]{};
            method = type.GetMethod("GetVSyncsPerSecond", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetVSyncsPerSecond_2);
            args = new Type[]{};
            method = type.GetMethod("GetGpuTimerFrequency", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGpuTimerFrequency_3);
            args = new Type[]{};
            method = type.GetMethod("GetCpuTimerFrequency", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCpuTimerFrequency_4);





        }


        static StackObject* CaptureFrameTimings_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.FrameTimingManager.CaptureFrameTimings();

            return __ret;
        }

        static StackObject* GetLatestTimings_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.FrameTiming[] @timings = (UnityEngine.FrameTiming[])typeof(UnityEngine.FrameTiming[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt32 @numFrames = (uint)ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.FrameTimingManager.GetLatestTimings(@numFrames, @timings);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetVSyncsPerSecond_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.FrameTimingManager.GetVSyncsPerSecond();

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetGpuTimerFrequency_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.FrameTimingManager.GetGpuTimerFrequency();

            __ret->ObjectType = ObjectTypes.Long;
            *(ulong*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetCpuTimerFrequency_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.FrameTimingManager.GetCpuTimerFrequency();

            __ret->ObjectType = ObjectTypes.Long;
            *(ulong*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }





    }
}
#endif
