
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
    unsafe class UnityEngine_FrameTiming_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.FrameTiming);

            field = type.GetField("cpuTimePresentCalled", flag);
            app.RegisterCLRFieldGetter(field, get_cpuTimePresentCalled_0);
            app.RegisterCLRFieldSetter(field, set_cpuTimePresentCalled_0);
            field = type.GetField("cpuFrameTime", flag);
            app.RegisterCLRFieldGetter(field, get_cpuFrameTime_1);
            app.RegisterCLRFieldSetter(field, set_cpuFrameTime_1);
            field = type.GetField("cpuTimeFrameComplete", flag);
            app.RegisterCLRFieldGetter(field, get_cpuTimeFrameComplete_2);
            app.RegisterCLRFieldSetter(field, set_cpuTimeFrameComplete_2);
            field = type.GetField("gpuFrameTime", flag);
            app.RegisterCLRFieldGetter(field, get_gpuFrameTime_3);
            app.RegisterCLRFieldSetter(field, set_gpuFrameTime_3);
            field = type.GetField("heightScale", flag);
            app.RegisterCLRFieldGetter(field, get_heightScale_4);
            app.RegisterCLRFieldSetter(field, set_heightScale_4);
            field = type.GetField("widthScale", flag);
            app.RegisterCLRFieldGetter(field, get_widthScale_5);
            app.RegisterCLRFieldSetter(field, set_widthScale_5);
            field = type.GetField("syncInterval", flag);
            app.RegisterCLRFieldGetter(field, get_syncInterval_6);
            app.RegisterCLRFieldSetter(field, set_syncInterval_6);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.FrameTiming());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.FrameTiming[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.FrameTiming instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.FrameTiming[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_cpuTimePresentCalled_0(ref object o)
        {
            return ((UnityEngine.FrameTiming)o).cpuTimePresentCalled;
        }
        static void set_cpuTimePresentCalled_0(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.FrameTiming* p = (UnityEngine.FrameTiming *)(void *)h.AddrOfPinnedObject();
            p->cpuTimePresentCalled = (System.UInt64)v;
            h.Free();
        }
        static object get_cpuFrameTime_1(ref object o)
        {
            return ((UnityEngine.FrameTiming)o).cpuFrameTime;
        }
        static void set_cpuFrameTime_1(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.FrameTiming* p = (UnityEngine.FrameTiming *)(void *)h.AddrOfPinnedObject();
            p->cpuFrameTime = (System.Double)v;
            h.Free();
        }
        static object get_cpuTimeFrameComplete_2(ref object o)
        {
            return ((UnityEngine.FrameTiming)o).cpuTimeFrameComplete;
        }
        static void set_cpuTimeFrameComplete_2(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.FrameTiming* p = (UnityEngine.FrameTiming *)(void *)h.AddrOfPinnedObject();
            p->cpuTimeFrameComplete = (System.UInt64)v;
            h.Free();
        }
        static object get_gpuFrameTime_3(ref object o)
        {
            return ((UnityEngine.FrameTiming)o).gpuFrameTime;
        }
        static void set_gpuFrameTime_3(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.FrameTiming* p = (UnityEngine.FrameTiming *)(void *)h.AddrOfPinnedObject();
            p->gpuFrameTime = (System.Double)v;
            h.Free();
        }
        static object get_heightScale_4(ref object o)
        {
            return ((UnityEngine.FrameTiming)o).heightScale;
        }
        static void set_heightScale_4(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.FrameTiming* p = (UnityEngine.FrameTiming *)(void *)h.AddrOfPinnedObject();
            p->heightScale = (System.Single)v;
            h.Free();
        }
        static object get_widthScale_5(ref object o)
        {
            return ((UnityEngine.FrameTiming)o).widthScale;
        }
        static void set_widthScale_5(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.FrameTiming* p = (UnityEngine.FrameTiming *)(void *)h.AddrOfPinnedObject();
            p->widthScale = (System.Single)v;
            h.Free();
        }
        static object get_syncInterval_6(ref object o)
        {
            return ((UnityEngine.FrameTiming)o).syncInterval;
        }
        static void set_syncInterval_6(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.FrameTiming* p = (UnityEngine.FrameTiming *)(void *)h.AddrOfPinnedObject();
            p->syncInterval = (System.UInt32)v;
            h.Free();
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.FrameTiming();
            ins = (UnityEngine.FrameTiming)o;
            return ins;
        }


    }
}
#endif
