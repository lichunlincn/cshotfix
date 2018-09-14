
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

namespace CSHotFix.Runtime.Generated
{
    unsafe class UnityEngine_TextureFormat_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.TextureFormat);

            field = type.GetField("Alpha8", flag);
            app.RegisterCLRFieldGetter(field, get_Alpha8_0);
            field = type.GetField("ARGB4444", flag);
            app.RegisterCLRFieldGetter(field, get_ARGB4444_1);
            field = type.GetField("RGB24", flag);
            app.RegisterCLRFieldGetter(field, get_RGB24_2);
            field = type.GetField("RGBA32", flag);
            app.RegisterCLRFieldGetter(field, get_RGBA32_3);
            field = type.GetField("ARGB32", flag);
            app.RegisterCLRFieldGetter(field, get_ARGB32_4);
            field = type.GetField("RGB565", flag);
            app.RegisterCLRFieldGetter(field, get_RGB565_5);
            field = type.GetField("R16", flag);
            app.RegisterCLRFieldGetter(field, get_R16_6);
            field = type.GetField("DXT1", flag);
            app.RegisterCLRFieldGetter(field, get_DXT1_7);
            field = type.GetField("DXT5", flag);
            app.RegisterCLRFieldGetter(field, get_DXT5_8);
            field = type.GetField("RGBA4444", flag);
            app.RegisterCLRFieldGetter(field, get_RGBA4444_9);
            field = type.GetField("BGRA32", flag);
            app.RegisterCLRFieldGetter(field, get_BGRA32_10);
            field = type.GetField("RHalf", flag);
            app.RegisterCLRFieldGetter(field, get_RHalf_11);
            field = type.GetField("RGHalf", flag);
            app.RegisterCLRFieldGetter(field, get_RGHalf_12);
            field = type.GetField("RGBAHalf", flag);
            app.RegisterCLRFieldGetter(field, get_RGBAHalf_13);
            field = type.GetField("RFloat", flag);
            app.RegisterCLRFieldGetter(field, get_RFloat_14);
            field = type.GetField("RGFloat", flag);
            app.RegisterCLRFieldGetter(field, get_RGFloat_15);
            field = type.GetField("RGBAFloat", flag);
            app.RegisterCLRFieldGetter(field, get_RGBAFloat_16);
            field = type.GetField("YUY2", flag);
            app.RegisterCLRFieldGetter(field, get_YUY2_17);
            field = type.GetField("RGB9e5Float", flag);
            app.RegisterCLRFieldGetter(field, get_RGB9e5Float_18);
            field = type.GetField("BC4", flag);
            app.RegisterCLRFieldGetter(field, get_BC4_19);
            field = type.GetField("BC5", flag);
            app.RegisterCLRFieldGetter(field, get_BC5_20);
            field = type.GetField("BC6H", flag);
            app.RegisterCLRFieldGetter(field, get_BC6H_21);
            field = type.GetField("BC7", flag);
            app.RegisterCLRFieldGetter(field, get_BC7_22);
            field = type.GetField("DXT1Crunched", flag);
            app.RegisterCLRFieldGetter(field, get_DXT1Crunched_23);
            field = type.GetField("DXT5Crunched", flag);
            app.RegisterCLRFieldGetter(field, get_DXT5Crunched_24);
            field = type.GetField("PVRTC_RGB2", flag);
            app.RegisterCLRFieldGetter(field, get_PVRTC_RGB2_25);
            field = type.GetField("PVRTC_RGBA2", flag);
            app.RegisterCLRFieldGetter(field, get_PVRTC_RGBA2_26);
            field = type.GetField("PVRTC_RGB4", flag);
            app.RegisterCLRFieldGetter(field, get_PVRTC_RGB4_27);
            field = type.GetField("PVRTC_RGBA4", flag);
            app.RegisterCLRFieldGetter(field, get_PVRTC_RGBA4_28);
            field = type.GetField("ETC_RGB4", flag);
            app.RegisterCLRFieldGetter(field, get_ETC_RGB4_29);
            field = type.GetField("ATC_RGB4", flag);
            app.RegisterCLRFieldGetter(field, get_ATC_RGB4_30);
            field = type.GetField("ATC_RGBA8", flag);
            app.RegisterCLRFieldGetter(field, get_ATC_RGBA8_31);
            field = type.GetField("EAC_R", flag);
            app.RegisterCLRFieldGetter(field, get_EAC_R_32);
            field = type.GetField("EAC_R_SIGNED", flag);
            app.RegisterCLRFieldGetter(field, get_EAC_R_SIGNED_33);
            field = type.GetField("EAC_RG", flag);
            app.RegisterCLRFieldGetter(field, get_EAC_RG_34);
            field = type.GetField("EAC_RG_SIGNED", flag);
            app.RegisterCLRFieldGetter(field, get_EAC_RG_SIGNED_35);
            field = type.GetField("ETC2_RGB", flag);
            app.RegisterCLRFieldGetter(field, get_ETC2_RGB_36);
            field = type.GetField("ETC2_RGBA1", flag);
            app.RegisterCLRFieldGetter(field, get_ETC2_RGBA1_37);
            field = type.GetField("ETC2_RGBA8", flag);
            app.RegisterCLRFieldGetter(field, get_ETC2_RGBA8_38);
            field = type.GetField("ASTC_RGB_4x4", flag);
            app.RegisterCLRFieldGetter(field, get_ASTC_RGB_4x4_39);
            field = type.GetField("ASTC_RGB_5x5", flag);
            app.RegisterCLRFieldGetter(field, get_ASTC_RGB_5x5_40);
            field = type.GetField("ASTC_RGB_6x6", flag);
            app.RegisterCLRFieldGetter(field, get_ASTC_RGB_6x6_41);
            field = type.GetField("ASTC_RGB_8x8", flag);
            app.RegisterCLRFieldGetter(field, get_ASTC_RGB_8x8_42);
            field = type.GetField("ASTC_RGB_10x10", flag);
            app.RegisterCLRFieldGetter(field, get_ASTC_RGB_10x10_43);
            field = type.GetField("ASTC_RGB_12x12", flag);
            app.RegisterCLRFieldGetter(field, get_ASTC_RGB_12x12_44);
            field = type.GetField("ASTC_RGBA_4x4", flag);
            app.RegisterCLRFieldGetter(field, get_ASTC_RGBA_4x4_45);
            field = type.GetField("ASTC_RGBA_5x5", flag);
            app.RegisterCLRFieldGetter(field, get_ASTC_RGBA_5x5_46);
            field = type.GetField("ASTC_RGBA_6x6", flag);
            app.RegisterCLRFieldGetter(field, get_ASTC_RGBA_6x6_47);
            field = type.GetField("ASTC_RGBA_8x8", flag);
            app.RegisterCLRFieldGetter(field, get_ASTC_RGBA_8x8_48);
            field = type.GetField("ASTC_RGBA_10x10", flag);
            app.RegisterCLRFieldGetter(field, get_ASTC_RGBA_10x10_49);
            field = type.GetField("ASTC_RGBA_12x12", flag);
            app.RegisterCLRFieldGetter(field, get_ASTC_RGBA_12x12_50);
            field = type.GetField("ETC_RGB4_3DS", flag);
            app.RegisterCLRFieldGetter(field, get_ETC_RGB4_3DS_51);
            field = type.GetField("ETC_RGBA8_3DS", flag);
            app.RegisterCLRFieldGetter(field, get_ETC_RGBA8_3DS_52);
            field = type.GetField("RG16", flag);
            app.RegisterCLRFieldGetter(field, get_RG16_53);
            field = type.GetField("R8", flag);
            app.RegisterCLRFieldGetter(field, get_R8_54);
            field = type.GetField("ETC_RGB4Crunched", flag);
            app.RegisterCLRFieldGetter(field, get_ETC_RGB4Crunched_55);
            field = type.GetField("ETC2_RGBA8Crunched", flag);
            app.RegisterCLRFieldGetter(field, get_ETC2_RGBA8Crunched_56);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.TextureFormat());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.TextureFormat[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.TextureFormat instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.TextureFormat[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Alpha8_0(ref object o)
        {
            return UnityEngine.TextureFormat.Alpha8;
        }
        static object get_ARGB4444_1(ref object o)
        {
            return UnityEngine.TextureFormat.ARGB4444;
        }
        static object get_RGB24_2(ref object o)
        {
            return UnityEngine.TextureFormat.RGB24;
        }
        static object get_RGBA32_3(ref object o)
        {
            return UnityEngine.TextureFormat.RGBA32;
        }
        static object get_ARGB32_4(ref object o)
        {
            return UnityEngine.TextureFormat.ARGB32;
        }
        static object get_RGB565_5(ref object o)
        {
            return UnityEngine.TextureFormat.RGB565;
        }
        static object get_R16_6(ref object o)
        {
            return UnityEngine.TextureFormat.R16;
        }
        static object get_DXT1_7(ref object o)
        {
            return UnityEngine.TextureFormat.DXT1;
        }
        static object get_DXT5_8(ref object o)
        {
            return UnityEngine.TextureFormat.DXT5;
        }
        static object get_RGBA4444_9(ref object o)
        {
            return UnityEngine.TextureFormat.RGBA4444;
        }
        static object get_BGRA32_10(ref object o)
        {
            return UnityEngine.TextureFormat.BGRA32;
        }
        static object get_RHalf_11(ref object o)
        {
            return UnityEngine.TextureFormat.RHalf;
        }
        static object get_RGHalf_12(ref object o)
        {
            return UnityEngine.TextureFormat.RGHalf;
        }
        static object get_RGBAHalf_13(ref object o)
        {
            return UnityEngine.TextureFormat.RGBAHalf;
        }
        static object get_RFloat_14(ref object o)
        {
            return UnityEngine.TextureFormat.RFloat;
        }
        static object get_RGFloat_15(ref object o)
        {
            return UnityEngine.TextureFormat.RGFloat;
        }
        static object get_RGBAFloat_16(ref object o)
        {
            return UnityEngine.TextureFormat.RGBAFloat;
        }
        static object get_YUY2_17(ref object o)
        {
            return UnityEngine.TextureFormat.YUY2;
        }
        static object get_RGB9e5Float_18(ref object o)
        {
            return UnityEngine.TextureFormat.RGB9e5Float;
        }
        static object get_BC4_19(ref object o)
        {
            return UnityEngine.TextureFormat.BC4;
        }
        static object get_BC5_20(ref object o)
        {
            return UnityEngine.TextureFormat.BC5;
        }
        static object get_BC6H_21(ref object o)
        {
            return UnityEngine.TextureFormat.BC6H;
        }
        static object get_BC7_22(ref object o)
        {
            return UnityEngine.TextureFormat.BC7;
        }
        static object get_DXT1Crunched_23(ref object o)
        {
            return UnityEngine.TextureFormat.DXT1Crunched;
        }
        static object get_DXT5Crunched_24(ref object o)
        {
            return UnityEngine.TextureFormat.DXT5Crunched;
        }
        static object get_PVRTC_RGB2_25(ref object o)
        {
            return UnityEngine.TextureFormat.PVRTC_RGB2;
        }
        static object get_PVRTC_RGBA2_26(ref object o)
        {
            return UnityEngine.TextureFormat.PVRTC_RGBA2;
        }
        static object get_PVRTC_RGB4_27(ref object o)
        {
            return UnityEngine.TextureFormat.PVRTC_RGB4;
        }
        static object get_PVRTC_RGBA4_28(ref object o)
        {
            return UnityEngine.TextureFormat.PVRTC_RGBA4;
        }
        static object get_ETC_RGB4_29(ref object o)
        {
            return UnityEngine.TextureFormat.ETC_RGB4;
        }
        static object get_ATC_RGB4_30(ref object o)
        {
            return UnityEngine.TextureFormat.ATC_RGB4;
        }
        static object get_ATC_RGBA8_31(ref object o)
        {
            return UnityEngine.TextureFormat.ATC_RGBA8;
        }
        static object get_EAC_R_32(ref object o)
        {
            return UnityEngine.TextureFormat.EAC_R;
        }
        static object get_EAC_R_SIGNED_33(ref object o)
        {
            return UnityEngine.TextureFormat.EAC_R_SIGNED;
        }
        static object get_EAC_RG_34(ref object o)
        {
            return UnityEngine.TextureFormat.EAC_RG;
        }
        static object get_EAC_RG_SIGNED_35(ref object o)
        {
            return UnityEngine.TextureFormat.EAC_RG_SIGNED;
        }
        static object get_ETC2_RGB_36(ref object o)
        {
            return UnityEngine.TextureFormat.ETC2_RGB;
        }
        static object get_ETC2_RGBA1_37(ref object o)
        {
            return UnityEngine.TextureFormat.ETC2_RGBA1;
        }
        static object get_ETC2_RGBA8_38(ref object o)
        {
            return UnityEngine.TextureFormat.ETC2_RGBA8;
        }
        static object get_ASTC_RGB_4x4_39(ref object o)
        {
            return UnityEngine.TextureFormat.ASTC_RGB_4x4;
        }
        static object get_ASTC_RGB_5x5_40(ref object o)
        {
            return UnityEngine.TextureFormat.ASTC_RGB_5x5;
        }
        static object get_ASTC_RGB_6x6_41(ref object o)
        {
            return UnityEngine.TextureFormat.ASTC_RGB_6x6;
        }
        static object get_ASTC_RGB_8x8_42(ref object o)
        {
            return UnityEngine.TextureFormat.ASTC_RGB_8x8;
        }
        static object get_ASTC_RGB_10x10_43(ref object o)
        {
            return UnityEngine.TextureFormat.ASTC_RGB_10x10;
        }
        static object get_ASTC_RGB_12x12_44(ref object o)
        {
            return UnityEngine.TextureFormat.ASTC_RGB_12x12;
        }
        static object get_ASTC_RGBA_4x4_45(ref object o)
        {
            return UnityEngine.TextureFormat.ASTC_RGBA_4x4;
        }
        static object get_ASTC_RGBA_5x5_46(ref object o)
        {
            return UnityEngine.TextureFormat.ASTC_RGBA_5x5;
        }
        static object get_ASTC_RGBA_6x6_47(ref object o)
        {
            return UnityEngine.TextureFormat.ASTC_RGBA_6x6;
        }
        static object get_ASTC_RGBA_8x8_48(ref object o)
        {
            return UnityEngine.TextureFormat.ASTC_RGBA_8x8;
        }
        static object get_ASTC_RGBA_10x10_49(ref object o)
        {
            return UnityEngine.TextureFormat.ASTC_RGBA_10x10;
        }
        static object get_ASTC_RGBA_12x12_50(ref object o)
        {
            return UnityEngine.TextureFormat.ASTC_RGBA_12x12;
        }
        static object get_ETC_RGB4_3DS_51(ref object o)
        {
            return UnityEngine.TextureFormat.ETC_RGB4_3DS;
        }
        static object get_ETC_RGBA8_3DS_52(ref object o)
        {
            return UnityEngine.TextureFormat.ETC_RGBA8_3DS;
        }
        static object get_RG16_53(ref object o)
        {
            return UnityEngine.TextureFormat.RG16;
        }
        static object get_R8_54(ref object o)
        {
            return UnityEngine.TextureFormat.R8;
        }
        static object get_ETC_RGB4Crunched_55(ref object o)
        {
            return UnityEngine.TextureFormat.ETC_RGB4Crunched;
        }
        static object get_ETC2_RGBA8Crunched_56(ref object o)
        {
            return UnityEngine.TextureFormat.ETC2_RGBA8Crunched;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.TextureFormat();
            ins = (UnityEngine.TextureFormat)o;
            return ins;
        }


    }
}
#endif
