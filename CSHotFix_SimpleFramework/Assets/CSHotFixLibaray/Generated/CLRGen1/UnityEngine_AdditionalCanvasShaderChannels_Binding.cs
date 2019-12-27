
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
    unsafe class UnityEngine_AdditionalCanvasShaderChannels_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.AdditionalCanvasShaderChannels);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            field = type.GetField("TexCoord1", flag);
            app.RegisterCLRFieldGetter(field, get_TexCoord1_1);
            field = type.GetField("TexCoord2", flag);
            app.RegisterCLRFieldGetter(field, get_TexCoord2_2);
            field = type.GetField("TexCoord3", flag);
            app.RegisterCLRFieldGetter(field, get_TexCoord3_3);
            field = type.GetField("Normal", flag);
            app.RegisterCLRFieldGetter(field, get_Normal_4);
            field = type.GetField("Tangent", flag);
            app.RegisterCLRFieldGetter(field, get_Tangent_5);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.AdditionalCanvasShaderChannels());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AdditionalCanvasShaderChannels[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.AdditionalCanvasShaderChannels instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.AdditionalCanvasShaderChannels[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_None_0(ref object o)
        {
            return UnityEngine.AdditionalCanvasShaderChannels.None;
        }
        static object get_TexCoord1_1(ref object o)
        {
            return UnityEngine.AdditionalCanvasShaderChannels.TexCoord1;
        }
        static object get_TexCoord2_2(ref object o)
        {
            return UnityEngine.AdditionalCanvasShaderChannels.TexCoord2;
        }
        static object get_TexCoord3_3(ref object o)
        {
            return UnityEngine.AdditionalCanvasShaderChannels.TexCoord3;
        }
        static object get_Normal_4(ref object o)
        {
            return UnityEngine.AdditionalCanvasShaderChannels.Normal;
        }
        static object get_Tangent_5(ref object o)
        {
            return UnityEngine.AdditionalCanvasShaderChannels.Tangent;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.AdditionalCanvasShaderChannels();
            ins = (UnityEngine.AdditionalCanvasShaderChannels)o;
            return ins;
        }


    }
}
#endif
