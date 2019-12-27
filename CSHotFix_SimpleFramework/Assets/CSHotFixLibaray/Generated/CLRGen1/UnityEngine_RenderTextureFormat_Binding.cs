
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
    unsafe class UnityEngine_RenderTextureFormat_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.RenderTextureFormat);

            field = type.GetField("ARGB32", flag);
            app.RegisterCLRFieldGetter(field, get_ARGB32_0);
            field = type.GetField("Depth", flag);
            app.RegisterCLRFieldGetter(field, get_Depth_1);
            field = type.GetField("ARGBHalf", flag);
            app.RegisterCLRFieldGetter(field, get_ARGBHalf_2);
            field = type.GetField("Shadowmap", flag);
            app.RegisterCLRFieldGetter(field, get_Shadowmap_3);
            field = type.GetField("RGB565", flag);
            app.RegisterCLRFieldGetter(field, get_RGB565_4);
            field = type.GetField("ARGB4444", flag);
            app.RegisterCLRFieldGetter(field, get_ARGB4444_5);
            field = type.GetField("ARGB1555", flag);
            app.RegisterCLRFieldGetter(field, get_ARGB1555_6);
            field = type.GetField("Default", flag);
            app.RegisterCLRFieldGetter(field, get_Default_7);
            field = type.GetField("ARGB2101010", flag);
            app.RegisterCLRFieldGetter(field, get_ARGB2101010_8);
            field = type.GetField("DefaultHDR", flag);
            app.RegisterCLRFieldGetter(field, get_DefaultHDR_9);
            field = type.GetField("ARGB64", flag);
            app.RegisterCLRFieldGetter(field, get_ARGB64_10);
            field = type.GetField("ARGBFloat", flag);
            app.RegisterCLRFieldGetter(field, get_ARGBFloat_11);
            field = type.GetField("RGFloat", flag);
            app.RegisterCLRFieldGetter(field, get_RGFloat_12);
            field = type.GetField("RGHalf", flag);
            app.RegisterCLRFieldGetter(field, get_RGHalf_13);
            field = type.GetField("RFloat", flag);
            app.RegisterCLRFieldGetter(field, get_RFloat_14);
            field = type.GetField("RHalf", flag);
            app.RegisterCLRFieldGetter(field, get_RHalf_15);
            field = type.GetField("R8", flag);
            app.RegisterCLRFieldGetter(field, get_R8_16);
            field = type.GetField("ARGBInt", flag);
            app.RegisterCLRFieldGetter(field, get_ARGBInt_17);
            field = type.GetField("RGInt", flag);
            app.RegisterCLRFieldGetter(field, get_RGInt_18);
            field = type.GetField("RInt", flag);
            app.RegisterCLRFieldGetter(field, get_RInt_19);
            field = type.GetField("BGRA32", flag);
            app.RegisterCLRFieldGetter(field, get_BGRA32_20);
            field = type.GetField("RGB111110Float", flag);
            app.RegisterCLRFieldGetter(field, get_RGB111110Float_21);
            field = type.GetField("RG32", flag);
            app.RegisterCLRFieldGetter(field, get_RG32_22);
            field = type.GetField("RGBAUShort", flag);
            app.RegisterCLRFieldGetter(field, get_RGBAUShort_23);
            field = type.GetField("RG16", flag);
            app.RegisterCLRFieldGetter(field, get_RG16_24);
            field = type.GetField("BGRA10101010_XR", flag);
            app.RegisterCLRFieldGetter(field, get_BGRA10101010_XR_25);
            field = type.GetField("BGR101010_XR", flag);
            app.RegisterCLRFieldGetter(field, get_BGR101010_XR_26);
            field = type.GetField("R16", flag);
            app.RegisterCLRFieldGetter(field, get_R16_27);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.RenderTextureFormat());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.RenderTextureFormat[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.RenderTextureFormat instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.RenderTextureFormat[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_ARGB32_0(ref object o)
        {
            return UnityEngine.RenderTextureFormat.ARGB32;
        }
        static object get_Depth_1(ref object o)
        {
            return UnityEngine.RenderTextureFormat.Depth;
        }
        static object get_ARGBHalf_2(ref object o)
        {
            return UnityEngine.RenderTextureFormat.ARGBHalf;
        }
        static object get_Shadowmap_3(ref object o)
        {
            return UnityEngine.RenderTextureFormat.Shadowmap;
        }
        static object get_RGB565_4(ref object o)
        {
            return UnityEngine.RenderTextureFormat.RGB565;
        }
        static object get_ARGB4444_5(ref object o)
        {
            return UnityEngine.RenderTextureFormat.ARGB4444;
        }
        static object get_ARGB1555_6(ref object o)
        {
            return UnityEngine.RenderTextureFormat.ARGB1555;
        }
        static object get_Default_7(ref object o)
        {
            return UnityEngine.RenderTextureFormat.Default;
        }
        static object get_ARGB2101010_8(ref object o)
        {
            return UnityEngine.RenderTextureFormat.ARGB2101010;
        }
        static object get_DefaultHDR_9(ref object o)
        {
            return UnityEngine.RenderTextureFormat.DefaultHDR;
        }
        static object get_ARGB64_10(ref object o)
        {
            return UnityEngine.RenderTextureFormat.ARGB64;
        }
        static object get_ARGBFloat_11(ref object o)
        {
            return UnityEngine.RenderTextureFormat.ARGBFloat;
        }
        static object get_RGFloat_12(ref object o)
        {
            return UnityEngine.RenderTextureFormat.RGFloat;
        }
        static object get_RGHalf_13(ref object o)
        {
            return UnityEngine.RenderTextureFormat.RGHalf;
        }
        static object get_RFloat_14(ref object o)
        {
            return UnityEngine.RenderTextureFormat.RFloat;
        }
        static object get_RHalf_15(ref object o)
        {
            return UnityEngine.RenderTextureFormat.RHalf;
        }
        static object get_R8_16(ref object o)
        {
            return UnityEngine.RenderTextureFormat.R8;
        }
        static object get_ARGBInt_17(ref object o)
        {
            return UnityEngine.RenderTextureFormat.ARGBInt;
        }
        static object get_RGInt_18(ref object o)
        {
            return UnityEngine.RenderTextureFormat.RGInt;
        }
        static object get_RInt_19(ref object o)
        {
            return UnityEngine.RenderTextureFormat.RInt;
        }
        static object get_BGRA32_20(ref object o)
        {
            return UnityEngine.RenderTextureFormat.BGRA32;
        }
        static object get_RGB111110Float_21(ref object o)
        {
            return UnityEngine.RenderTextureFormat.RGB111110Float;
        }
        static object get_RG32_22(ref object o)
        {
            return UnityEngine.RenderTextureFormat.RG32;
        }
        static object get_RGBAUShort_23(ref object o)
        {
            return UnityEngine.RenderTextureFormat.RGBAUShort;
        }
        static object get_RG16_24(ref object o)
        {
            return UnityEngine.RenderTextureFormat.RG16;
        }
        static object get_BGRA10101010_XR_25(ref object o)
        {
            return UnityEngine.RenderTextureFormat.BGRA10101010_XR;
        }
        static object get_BGR101010_XR_26(ref object o)
        {
            return UnityEngine.RenderTextureFormat.BGR101010_XR;
        }
        static object get_R16_27(ref object o)
        {
            return UnityEngine.RenderTextureFormat.R16;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.RenderTextureFormat();
            ins = (UnityEngine.RenderTextureFormat)o;
            return ins;
        }


    }
}
#endif
