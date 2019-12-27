
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
    unsafe class LCL_RenderingMode_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(LCL.RenderingMode);

            field = type.GetField("Opaque", flag);
            app.RegisterCLRFieldGetter(field, get_Opaque_0);
            field = type.GetField("Cutout", flag);
            app.RegisterCLRFieldGetter(field, get_Cutout_1);
            field = type.GetField("Fade", flag);
            app.RegisterCLRFieldGetter(field, get_Fade_2);
            field = type.GetField("Transparent", flag);
            app.RegisterCLRFieldGetter(field, get_Transparent_3);


            app.RegisterCLRCreateDefaultInstance(type, () => new LCL.RenderingMode());
            app.RegisterCLRCreateArrayInstance(type, s => new LCL.RenderingMode[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref LCL.RenderingMode instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as LCL.RenderingMode[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Opaque_0(ref object o)
        {
            return LCL.RenderingMode.Opaque;
        }
        static object get_Cutout_1(ref object o)
        {
            return LCL.RenderingMode.Cutout;
        }
        static object get_Fade_2(ref object o)
        {
            return LCL.RenderingMode.Fade;
        }
        static object get_Transparent_3(ref object o)
        {
            return LCL.RenderingMode.Transparent;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new LCL.RenderingMode();
            ins = (LCL.RenderingMode)o;
            return ins;
        }


    }
}
#endif
