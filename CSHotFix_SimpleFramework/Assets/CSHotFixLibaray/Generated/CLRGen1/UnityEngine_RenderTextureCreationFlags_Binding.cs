
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
    unsafe class UnityEngine_RenderTextureCreationFlags_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.RenderTextureCreationFlags);

            field = type.GetField("MipMap", flag);
            app.RegisterCLRFieldGetter(field, get_MipMap_0);
            field = type.GetField("AutoGenerateMips", flag);
            app.RegisterCLRFieldGetter(field, get_AutoGenerateMips_1);
            field = type.GetField("SRGB", flag);
            app.RegisterCLRFieldGetter(field, get_SRGB_2);
            field = type.GetField("EyeTexture", flag);
            app.RegisterCLRFieldGetter(field, get_EyeTexture_3);
            field = type.GetField("EnableRandomWrite", flag);
            app.RegisterCLRFieldGetter(field, get_EnableRandomWrite_4);
            field = type.GetField("CreatedFromScript", flag);
            app.RegisterCLRFieldGetter(field, get_CreatedFromScript_5);
            field = type.GetField("AllowVerticalFlip", flag);
            app.RegisterCLRFieldGetter(field, get_AllowVerticalFlip_6);
            field = type.GetField("NoResolvedColorSurface", flag);
            app.RegisterCLRFieldGetter(field, get_NoResolvedColorSurface_7);
            field = type.GetField("DynamicallyScalable", flag);
            app.RegisterCLRFieldGetter(field, get_DynamicallyScalable_8);
            field = type.GetField("BindMS", flag);
            app.RegisterCLRFieldGetter(field, get_BindMS_9);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.RenderTextureCreationFlags());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.RenderTextureCreationFlags[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.RenderTextureCreationFlags instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.RenderTextureCreationFlags[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_MipMap_0(ref object o)
        {
            return UnityEngine.RenderTextureCreationFlags.MipMap;
        }
        static object get_AutoGenerateMips_1(ref object o)
        {
            return UnityEngine.RenderTextureCreationFlags.AutoGenerateMips;
        }
        static object get_SRGB_2(ref object o)
        {
            return UnityEngine.RenderTextureCreationFlags.SRGB;
        }
        static object get_EyeTexture_3(ref object o)
        {
            return UnityEngine.RenderTextureCreationFlags.EyeTexture;
        }
        static object get_EnableRandomWrite_4(ref object o)
        {
            return UnityEngine.RenderTextureCreationFlags.EnableRandomWrite;
        }
        static object get_CreatedFromScript_5(ref object o)
        {
            return UnityEngine.RenderTextureCreationFlags.CreatedFromScript;
        }
        static object get_AllowVerticalFlip_6(ref object o)
        {
            return UnityEngine.RenderTextureCreationFlags.AllowVerticalFlip;
        }
        static object get_NoResolvedColorSurface_7(ref object o)
        {
            return UnityEngine.RenderTextureCreationFlags.NoResolvedColorSurface;
        }
        static object get_DynamicallyScalable_8(ref object o)
        {
            return UnityEngine.RenderTextureCreationFlags.DynamicallyScalable;
        }
        static object get_BindMS_9(ref object o)
        {
            return UnityEngine.RenderTextureCreationFlags.BindMS;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.RenderTextureCreationFlags();
            ins = (UnityEngine.RenderTextureCreationFlags)o;
            return ins;
        }


    }
}
#endif
