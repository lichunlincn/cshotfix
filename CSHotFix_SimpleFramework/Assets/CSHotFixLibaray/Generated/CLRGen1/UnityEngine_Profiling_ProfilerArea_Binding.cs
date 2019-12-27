
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
    unsafe class UnityEngine_Profiling_ProfilerArea_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Profiling.ProfilerArea);

            field = type.GetField("CPU", flag);
            app.RegisterCLRFieldGetter(field, get_CPU_0);
            field = type.GetField("GPU", flag);
            app.RegisterCLRFieldGetter(field, get_GPU_1);
            field = type.GetField("Rendering", flag);
            app.RegisterCLRFieldGetter(field, get_Rendering_2);
            field = type.GetField("Memory", flag);
            app.RegisterCLRFieldGetter(field, get_Memory_3);
            field = type.GetField("Audio", flag);
            app.RegisterCLRFieldGetter(field, get_Audio_4);
            field = type.GetField("Video", flag);
            app.RegisterCLRFieldGetter(field, get_Video_5);
            field = type.GetField("Physics", flag);
            app.RegisterCLRFieldGetter(field, get_Physics_6);
            field = type.GetField("Physics2D", flag);
            app.RegisterCLRFieldGetter(field, get_Physics2D_7);
            field = type.GetField("NetworkMessages", flag);
            app.RegisterCLRFieldGetter(field, get_NetworkMessages_8);
            field = type.GetField("NetworkOperations", flag);
            app.RegisterCLRFieldGetter(field, get_NetworkOperations_9);
            field = type.GetField("UI", flag);
            app.RegisterCLRFieldGetter(field, get_UI_10);
            field = type.GetField("UIDetails", flag);
            app.RegisterCLRFieldGetter(field, get_UIDetails_11);
            field = type.GetField("GlobalIllumination", flag);
            app.RegisterCLRFieldGetter(field, get_GlobalIllumination_12);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Profiling.ProfilerArea());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Profiling.ProfilerArea[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.Profiling.ProfilerArea instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Profiling.ProfilerArea[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_CPU_0(ref object o)
        {
            return UnityEngine.Profiling.ProfilerArea.CPU;
        }
        static object get_GPU_1(ref object o)
        {
            return UnityEngine.Profiling.ProfilerArea.GPU;
        }
        static object get_Rendering_2(ref object o)
        {
            return UnityEngine.Profiling.ProfilerArea.Rendering;
        }
        static object get_Memory_3(ref object o)
        {
            return UnityEngine.Profiling.ProfilerArea.Memory;
        }
        static object get_Audio_4(ref object o)
        {
            return UnityEngine.Profiling.ProfilerArea.Audio;
        }
        static object get_Video_5(ref object o)
        {
            return UnityEngine.Profiling.ProfilerArea.Video;
        }
        static object get_Physics_6(ref object o)
        {
            return UnityEngine.Profiling.ProfilerArea.Physics;
        }
        static object get_Physics2D_7(ref object o)
        {
            return UnityEngine.Profiling.ProfilerArea.Physics2D;
        }
        static object get_NetworkMessages_8(ref object o)
        {
            return UnityEngine.Profiling.ProfilerArea.NetworkMessages;
        }
        static object get_NetworkOperations_9(ref object o)
        {
            return UnityEngine.Profiling.ProfilerArea.NetworkOperations;
        }
        static object get_UI_10(ref object o)
        {
            return UnityEngine.Profiling.ProfilerArea.UI;
        }
        static object get_UIDetails_11(ref object o)
        {
            return UnityEngine.Profiling.ProfilerArea.UIDetails;
        }
        static object get_GlobalIllumination_12(ref object o)
        {
            return UnityEngine.Profiling.ProfilerArea.GlobalIllumination;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Profiling.ProfilerArea();
            ins = (UnityEngine.Profiling.ProfilerArea)o;
            return ins;
        }


    }
}
#endif
