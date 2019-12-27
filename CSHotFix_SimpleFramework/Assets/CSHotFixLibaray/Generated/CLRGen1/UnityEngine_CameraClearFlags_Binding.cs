
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
    unsafe class UnityEngine_CameraClearFlags_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.CameraClearFlags);

            field = type.GetField("Skybox", flag);
            app.RegisterCLRFieldGetter(field, get_Skybox_0);
            field = type.GetField("Color", flag);
            app.RegisterCLRFieldGetter(field, get_Color_1);
            field = type.GetField("SolidColor", flag);
            app.RegisterCLRFieldGetter(field, get_SolidColor_2);
            field = type.GetField("Depth", flag);
            app.RegisterCLRFieldGetter(field, get_Depth_3);
            field = type.GetField("Nothing", flag);
            app.RegisterCLRFieldGetter(field, get_Nothing_4);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.CameraClearFlags());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.CameraClearFlags[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.CameraClearFlags instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.CameraClearFlags[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Skybox_0(ref object o)
        {
            return UnityEngine.CameraClearFlags.Skybox;
        }
        static object get_Color_1(ref object o)
        {
            return UnityEngine.CameraClearFlags.Color;
        }
        static object get_SolidColor_2(ref object o)
        {
            return UnityEngine.CameraClearFlags.SolidColor;
        }
        static object get_Depth_3(ref object o)
        {
            return UnityEngine.CameraClearFlags.Depth;
        }
        static object get_Nothing_4(ref object o)
        {
            return UnityEngine.CameraClearFlags.Nothing;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.CameraClearFlags();
            ins = (UnityEngine.CameraClearFlags)o;
            return ins;
        }


    }
}
#endif
