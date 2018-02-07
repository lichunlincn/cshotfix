
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
    unsafe class UnityEngine_Profiling_Profiler_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Profiling.Profiler);
            args = new Type[]{};
            method = type.GetMethod("get_supported", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_supported_0);
            args = new Type[]{};
            method = type.GetMethod("get_logFile", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_logFile_1);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_logFile", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_logFile_2);
            args = new Type[]{};
            method = type.GetMethod("get_enableBinaryLog", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_enableBinaryLog_3);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_enableBinaryLog", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_enableBinaryLog_4);
            args = new Type[]{};
            method = type.GetMethod("get_enabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_enabled_5);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_enabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_enabled_6);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("AddFramesFromFile", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddFramesFromFile_7);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("BeginSample", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginSample_8);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Object)};
            method = type.GetMethod("BeginSample", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginSample_9);
            args = new Type[]{};
            method = type.GetMethod("EndSample", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EndSample_10);
            args = new Type[]{};
            method = type.GetMethod("get_usedHeapSizeLong", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_usedHeapSizeLong_11);
            args = new Type[]{typeof(UnityEngine.Object)};
            method = type.GetMethod("GetRuntimeMemorySizeLong", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRuntimeMemorySizeLong_12);
            args = new Type[]{};
            method = type.GetMethod("GetMonoHeapSizeLong", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetMonoHeapSizeLong_13);
            args = new Type[]{};
            method = type.GetMethod("GetMonoUsedSizeLong", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetMonoUsedSizeLong_14);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("SetTempAllocatorRequestedSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTempAllocatorRequestedSize_15);
            args = new Type[]{};
            method = type.GetMethod("GetTempAllocatorSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTempAllocatorSize_16);
            args = new Type[]{};
            method = type.GetMethod("GetTotalAllocatedMemoryLong", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTotalAllocatedMemoryLong_17);
            args = new Type[]{};
            method = type.GetMethod("GetTotalUnusedReservedMemoryLong", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTotalUnusedReservedMemoryLong_18);
            args = new Type[]{};
            method = type.GetMethod("GetTotalReservedMemoryLong", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTotalReservedMemoryLong_19);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Profiling.Profiler[s]);


        }


        static StackObject* get_supported_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Profiling.Profiler.supported;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_logFile_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Profiling.Profiler.logFile;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_logFile_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Profiling.Profiler.logFile = value;

            return __ret;
        }

        static StackObject* get_enableBinaryLog_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Profiling.Profiler.enableBinaryLog;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_enableBinaryLog_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;

            UnityEngine.Profiling.Profiler.enableBinaryLog = value;

            return __ret;
        }

        static StackObject* get_enabled_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Profiling.Profiler.enabled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_enabled_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;

            UnityEngine.Profiling.Profiler.enabled = value;

            return __ret;
        }

        static StackObject* AddFramesFromFile_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String file = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Profiling.Profiler.AddFramesFromFile(file);

            return __ret;
        }

        static StackObject* BeginSample_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Profiling.Profiler.BeginSample(name);

            return __ret;
        }

        static StackObject* BeginSample_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Object targetObject = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Profiling.Profiler.BeginSample(name, targetObject);

            return __ret;
        }

        static StackObject* EndSample_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            UnityEngine.Profiling.Profiler.EndSample();

            return __ret;
        }

        static StackObject* get_usedHeapSizeLong_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Profiling.Profiler.usedHeapSizeLong;

            __ret->ObjectType = ObjectTypes.Long;
            *(long*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetRuntimeMemorySizeLong_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Object o = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.Profiling.Profiler.GetRuntimeMemorySizeLong(o);

            __ret->ObjectType = ObjectTypes.Long;
            *(long*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetMonoHeapSizeLong_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Profiling.Profiler.GetMonoHeapSizeLong();

            __ret->ObjectType = ObjectTypes.Long;
            *(long*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetMonoUsedSizeLong_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Profiling.Profiler.GetMonoUsedSizeLong();

            __ret->ObjectType = ObjectTypes.Long;
            *(long*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetTempAllocatorRequestedSize_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 size = (uint)ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.Profiling.Profiler.SetTempAllocatorRequestedSize(size);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetTempAllocatorSize_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Profiling.Profiler.GetTempAllocatorSize();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetTotalAllocatedMemoryLong_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Profiling.Profiler.GetTotalAllocatedMemoryLong();

            __ret->ObjectType = ObjectTypes.Long;
            *(long*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetTotalUnusedReservedMemoryLong_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Profiling.Profiler.GetTotalUnusedReservedMemoryLong();

            __ret->ObjectType = ObjectTypes.Long;
            *(long*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetTotalReservedMemoryLong_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Profiling.Profiler.GetTotalReservedMemoryLong();

            __ret->ObjectType = ObjectTypes.Long;
            *(long*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }





    }
}
