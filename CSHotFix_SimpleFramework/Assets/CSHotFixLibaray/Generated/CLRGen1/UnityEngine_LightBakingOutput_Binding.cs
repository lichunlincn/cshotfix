
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
    unsafe class UnityEngine_LightBakingOutput_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.LightBakingOutput);

            field = type.GetField("probeOcclusionLightIndex", flag);
            app.RegisterCLRFieldGetter(field, get_probeOcclusionLightIndex_0);
            app.RegisterCLRFieldSetter(field, set_probeOcclusionLightIndex_0);
            field = type.GetField("occlusionMaskChannel", flag);
            app.RegisterCLRFieldGetter(field, get_occlusionMaskChannel_1);
            app.RegisterCLRFieldSetter(field, set_occlusionMaskChannel_1);
            field = type.GetField("mixedLightingMode", flag);
            app.RegisterCLRFieldGetter(field, get_mixedLightingMode_2);
            app.RegisterCLRFieldSetter(field, set_mixedLightingMode_2);
            field = type.GetField("isBaked", flag);
            app.RegisterCLRFieldGetter(field, get_isBaked_3);
            app.RegisterCLRFieldSetter(field, set_isBaked_3);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.LightBakingOutput());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.LightBakingOutput[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.LightBakingOutput instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.LightBakingOutput[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_probeOcclusionLightIndex_0(ref object o)
        {
            return ((UnityEngine.LightBakingOutput)o).probeOcclusionLightIndex;
        }
        static void set_probeOcclusionLightIndex_0(ref object o, object v)
        {
UnityEngine.LightBakingOutput _o = (UnityEngine.LightBakingOutput)o;
    _o.probeOcclusionLightIndex = (System.Int32)v;
        }
        static object get_occlusionMaskChannel_1(ref object o)
        {
            return ((UnityEngine.LightBakingOutput)o).occlusionMaskChannel;
        }
        static void set_occlusionMaskChannel_1(ref object o, object v)
        {
UnityEngine.LightBakingOutput _o = (UnityEngine.LightBakingOutput)o;
    _o.occlusionMaskChannel = (System.Int32)v;
        }
        static object get_mixedLightingMode_2(ref object o)
        {
            return ((UnityEngine.LightBakingOutput)o).mixedLightingMode;
        }
        static void set_mixedLightingMode_2(ref object o, object v)
        {
UnityEngine.LightBakingOutput _o = (UnityEngine.LightBakingOutput)o;
    _o.mixedLightingMode = (UnityEngine.MixedLightingMode)v;
        }
        static object get_isBaked_3(ref object o)
        {
            return ((UnityEngine.LightBakingOutput)o).isBaked;
        }
        static void set_isBaked_3(ref object o, object v)
        {
UnityEngine.LightBakingOutput _o = (UnityEngine.LightBakingOutput)o;
    _o.isBaked = (System.Boolean)v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.LightBakingOutput();
            ins = (UnityEngine.LightBakingOutput)o;
            return ins;
        }


    }
}
#endif
