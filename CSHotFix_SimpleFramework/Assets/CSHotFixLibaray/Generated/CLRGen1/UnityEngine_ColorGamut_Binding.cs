
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
    unsafe class UnityEngine_ColorGamut_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ColorGamut);

            field = type.GetField("sRGB", flag);
            app.RegisterCLRFieldGetter(field, get_sRGB_0);
            field = type.GetField("Rec709", flag);
            app.RegisterCLRFieldGetter(field, get_Rec709_1);
            field = type.GetField("Rec2020", flag);
            app.RegisterCLRFieldGetter(field, get_Rec2020_2);
            field = type.GetField("DisplayP3", flag);
            app.RegisterCLRFieldGetter(field, get_DisplayP3_3);
            field = type.GetField("HDR10", flag);
            app.RegisterCLRFieldGetter(field, get_HDR10_4);
            field = type.GetField("DolbyHDR", flag);
            app.RegisterCLRFieldGetter(field, get_DolbyHDR_5);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ColorGamut());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ColorGamut[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.ColorGamut instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.ColorGamut[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_sRGB_0(ref object o)
        {
            return UnityEngine.ColorGamut.sRGB;
        }
        static object get_Rec709_1(ref object o)
        {
            return UnityEngine.ColorGamut.Rec709;
        }
        static object get_Rec2020_2(ref object o)
        {
            return UnityEngine.ColorGamut.Rec2020;
        }
        static object get_DisplayP3_3(ref object o)
        {
            return UnityEngine.ColorGamut.DisplayP3;
        }
        static object get_HDR10_4(ref object o)
        {
            return UnityEngine.ColorGamut.HDR10;
        }
        static object get_DolbyHDR_5(ref object o)
        {
            return UnityEngine.ColorGamut.DolbyHDR;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.ColorGamut();
            ins = (UnityEngine.ColorGamut)o;
            return ins;
        }


    }
}
#endif
