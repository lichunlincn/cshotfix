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
    unsafe class UnityEngine_Rendering_ReflectionProbeBlendInfo_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Rendering.ReflectionProbeBlendInfo);

            field = type.GetField("probe", flag);
            app.RegisterCLRFieldGetter(field, get_probe_0);
            app.RegisterCLRFieldSetter(field, set_probe_0);
            field = type.GetField("weight", flag);
            app.RegisterCLRFieldGetter(field, get_weight_1);
            app.RegisterCLRFieldSetter(field, set_weight_1);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Rendering.ReflectionProbeBlendInfo());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Rendering.ReflectionProbeBlendInfo[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.Rendering.ReflectionProbeBlendInfo instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Rendering.ReflectionProbeBlendInfo[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_probe_0(ref object o)
        {
            return ((UnityEngine.Rendering.ReflectionProbeBlendInfo)o).probe;
        }
        static void set_probe_0(ref object o, object v)
        {
UnityEngine.Rendering.ReflectionProbeBlendInfo _o = (UnityEngine.Rendering.ReflectionProbeBlendInfo)o;
    _o.probe = (UnityEngine.ReflectionProbe)v;
        }
        static object get_weight_1(ref object o)
        {
            return ((UnityEngine.Rendering.ReflectionProbeBlendInfo)o).weight;
        }
        static void set_weight_1(ref object o, object v)
        {
UnityEngine.Rendering.ReflectionProbeBlendInfo _o = (UnityEngine.Rendering.ReflectionProbeBlendInfo)o;
    _o.weight = (System.Single)v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Rendering.ReflectionProbeBlendInfo();
            ins = (UnityEngine.Rendering.ReflectionProbeBlendInfo)o;
            return ins;
        }


    }
}
