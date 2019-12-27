
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
    unsafe class UnityEngine_Profiling_Memory_Experimental_CaptureFlags_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Profiling.Memory.Experimental.CaptureFlags);

            field = type.GetField("ManagedObjects", flag);
            app.RegisterCLRFieldGetter(field, get_ManagedObjects_0);
            field = type.GetField("NativeObjects", flag);
            app.RegisterCLRFieldGetter(field, get_NativeObjects_1);
            field = type.GetField("NativeAllocations", flag);
            app.RegisterCLRFieldGetter(field, get_NativeAllocations_2);
            field = type.GetField("NativeAllocationSites", flag);
            app.RegisterCLRFieldGetter(field, get_NativeAllocationSites_3);
            field = type.GetField("NativeStackTraces", flag);
            app.RegisterCLRFieldGetter(field, get_NativeStackTraces_4);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Profiling.Memory.Experimental.CaptureFlags());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Profiling.Memory.Experimental.CaptureFlags[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.Profiling.Memory.Experimental.CaptureFlags instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Profiling.Memory.Experimental.CaptureFlags[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_ManagedObjects_0(ref object o)
        {
            return UnityEngine.Profiling.Memory.Experimental.CaptureFlags.ManagedObjects;
        }
        static object get_NativeObjects_1(ref object o)
        {
            return UnityEngine.Profiling.Memory.Experimental.CaptureFlags.NativeObjects;
        }
        static object get_NativeAllocations_2(ref object o)
        {
            return UnityEngine.Profiling.Memory.Experimental.CaptureFlags.NativeAllocations;
        }
        static object get_NativeAllocationSites_3(ref object o)
        {
            return UnityEngine.Profiling.Memory.Experimental.CaptureFlags.NativeAllocationSites;
        }
        static object get_NativeStackTraces_4(ref object o)
        {
            return UnityEngine.Profiling.Memory.Experimental.CaptureFlags.NativeStackTraces;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Profiling.Memory.Experimental.CaptureFlags();
            ins = (UnityEngine.Profiling.Memory.Experimental.CaptureFlags)o;
            return ins;
        }


    }
}
#endif
