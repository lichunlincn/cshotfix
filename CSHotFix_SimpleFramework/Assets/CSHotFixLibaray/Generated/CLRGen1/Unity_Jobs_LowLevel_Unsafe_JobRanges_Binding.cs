
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
    unsafe class Unity_Jobs_LowLevel_Unsafe_JobRanges_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Jobs.LowLevel.Unsafe.JobRanges);

            field = type.GetField("BatchSize", flag);
            app.RegisterCLRFieldGetter(field, get_BatchSize_0);
            app.RegisterCLRFieldSetter(field, set_BatchSize_0);
            field = type.GetField("NumJobs", flag);
            app.RegisterCLRFieldGetter(field, get_NumJobs_1);
            app.RegisterCLRFieldSetter(field, set_NumJobs_1);
            field = type.GetField("TotalIterationCount", flag);
            app.RegisterCLRFieldGetter(field, get_TotalIterationCount_2);
            app.RegisterCLRFieldSetter(field, set_TotalIterationCount_2);
            field = type.GetField("NumPhases", flag);
            app.RegisterCLRFieldGetter(field, get_NumPhases_3);
            app.RegisterCLRFieldSetter(field, set_NumPhases_3);
            field = type.GetField("IndicesPerPhase", flag);
            app.RegisterCLRFieldGetter(field, get_IndicesPerPhase_4);
            app.RegisterCLRFieldSetter(field, set_IndicesPerPhase_4);
            field = type.GetField("StartEndIndex", flag);
            app.RegisterCLRFieldGetter(field, get_StartEndIndex_5);
            app.RegisterCLRFieldSetter(field, set_StartEndIndex_5);
            field = type.GetField("PhaseData", flag);
            app.RegisterCLRFieldGetter(field, get_PhaseData_6);
            app.RegisterCLRFieldSetter(field, set_PhaseData_6);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.Jobs.LowLevel.Unsafe.JobRanges());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Jobs.LowLevel.Unsafe.JobRanges[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref Unity.Jobs.LowLevel.Unsafe.JobRanges instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Unity.Jobs.LowLevel.Unsafe.JobRanges[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_BatchSize_0(ref object o)
        {
            return ((Unity.Jobs.LowLevel.Unsafe.JobRanges)o).BatchSize;
        }
        static void set_BatchSize_0(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            Unity.Jobs.LowLevel.Unsafe.JobRanges* p = (Unity.Jobs.LowLevel.Unsafe.JobRanges *)(void *)h.AddrOfPinnedObject();
            p->BatchSize = (System.Int32)v;
            h.Free();
        }
        static object get_NumJobs_1(ref object o)
        {
            return ((Unity.Jobs.LowLevel.Unsafe.JobRanges)o).NumJobs;
        }
        static void set_NumJobs_1(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            Unity.Jobs.LowLevel.Unsafe.JobRanges* p = (Unity.Jobs.LowLevel.Unsafe.JobRanges *)(void *)h.AddrOfPinnedObject();
            p->NumJobs = (System.Int32)v;
            h.Free();
        }
        static object get_TotalIterationCount_2(ref object o)
        {
            return ((Unity.Jobs.LowLevel.Unsafe.JobRanges)o).TotalIterationCount;
        }
        static void set_TotalIterationCount_2(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            Unity.Jobs.LowLevel.Unsafe.JobRanges* p = (Unity.Jobs.LowLevel.Unsafe.JobRanges *)(void *)h.AddrOfPinnedObject();
            p->TotalIterationCount = (System.Int32)v;
            h.Free();
        }
        static object get_NumPhases_3(ref object o)
        {
            return ((Unity.Jobs.LowLevel.Unsafe.JobRanges)o).NumPhases;
        }
        static void set_NumPhases_3(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            Unity.Jobs.LowLevel.Unsafe.JobRanges* p = (Unity.Jobs.LowLevel.Unsafe.JobRanges *)(void *)h.AddrOfPinnedObject();
            p->NumPhases = (System.Int32)v;
            h.Free();
        }
        static object get_IndicesPerPhase_4(ref object o)
        {
            return ((Unity.Jobs.LowLevel.Unsafe.JobRanges)o).IndicesPerPhase;
        }
        static void set_IndicesPerPhase_4(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            Unity.Jobs.LowLevel.Unsafe.JobRanges* p = (Unity.Jobs.LowLevel.Unsafe.JobRanges *)(void *)h.AddrOfPinnedObject();
            p->IndicesPerPhase = (System.Int32)v;
            h.Free();
        }
        static object get_StartEndIndex_5(ref object o)
        {
            return ((Unity.Jobs.LowLevel.Unsafe.JobRanges)o).StartEndIndex;
        }
        static void set_StartEndIndex_5(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            Unity.Jobs.LowLevel.Unsafe.JobRanges* p = (Unity.Jobs.LowLevel.Unsafe.JobRanges *)(void *)h.AddrOfPinnedObject();
            p->StartEndIndex = (System.IntPtr)v;
            h.Free();
        }
        static object get_PhaseData_6(ref object o)
        {
            return ((Unity.Jobs.LowLevel.Unsafe.JobRanges)o).PhaseData;
        }
        static void set_PhaseData_6(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            Unity.Jobs.LowLevel.Unsafe.JobRanges* p = (Unity.Jobs.LowLevel.Unsafe.JobRanges *)(void *)h.AddrOfPinnedObject();
            p->PhaseData = (System.IntPtr)v;
            h.Free();
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Unity.Jobs.LowLevel.Unsafe.JobRanges();
            ins = (Unity.Jobs.LowLevel.Unsafe.JobRanges)o;
            return ins;
        }


    }
}
#endif
