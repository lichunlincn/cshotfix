
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
    unsafe class UnityEngine_CubemapFace_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.CubemapFace);

            field = type.GetField("Unknown", flag);
            app.RegisterCLRFieldGetter(field, get_Unknown_0);
            field = type.GetField("PositiveX", flag);
            app.RegisterCLRFieldGetter(field, get_PositiveX_1);
            field = type.GetField("NegativeX", flag);
            app.RegisterCLRFieldGetter(field, get_NegativeX_2);
            field = type.GetField("PositiveY", flag);
            app.RegisterCLRFieldGetter(field, get_PositiveY_3);
            field = type.GetField("NegativeY", flag);
            app.RegisterCLRFieldGetter(field, get_NegativeY_4);
            field = type.GetField("PositiveZ", flag);
            app.RegisterCLRFieldGetter(field, get_PositiveZ_5);
            field = type.GetField("NegativeZ", flag);
            app.RegisterCLRFieldGetter(field, get_NegativeZ_6);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.CubemapFace());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.CubemapFace[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.CubemapFace instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.CubemapFace[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Unknown_0(ref object o)
        {
            return UnityEngine.CubemapFace.Unknown;
        }
        static object get_PositiveX_1(ref object o)
        {
            return UnityEngine.CubemapFace.PositiveX;
        }
        static object get_NegativeX_2(ref object o)
        {
            return UnityEngine.CubemapFace.NegativeX;
        }
        static object get_PositiveY_3(ref object o)
        {
            return UnityEngine.CubemapFace.PositiveY;
        }
        static object get_NegativeY_4(ref object o)
        {
            return UnityEngine.CubemapFace.NegativeY;
        }
        static object get_PositiveZ_5(ref object o)
        {
            return UnityEngine.CubemapFace.PositiveZ;
        }
        static object get_NegativeZ_6(ref object o)
        {
            return UnityEngine.CubemapFace.NegativeZ;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.CubemapFace();
            ins = (UnityEngine.CubemapFace)o;
            return ins;
        }


    }
}
#endif
