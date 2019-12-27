
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
    unsafe class UnityEngine_PrimitiveType_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.PrimitiveType);

            field = type.GetField("Sphere", flag);
            app.RegisterCLRFieldGetter(field, get_Sphere_0);
            field = type.GetField("Capsule", flag);
            app.RegisterCLRFieldGetter(field, get_Capsule_1);
            field = type.GetField("Cylinder", flag);
            app.RegisterCLRFieldGetter(field, get_Cylinder_2);
            field = type.GetField("Cube", flag);
            app.RegisterCLRFieldGetter(field, get_Cube_3);
            field = type.GetField("Plane", flag);
            app.RegisterCLRFieldGetter(field, get_Plane_4);
            field = type.GetField("Quad", flag);
            app.RegisterCLRFieldGetter(field, get_Quad_5);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.PrimitiveType());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.PrimitiveType[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.PrimitiveType instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.PrimitiveType[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Sphere_0(ref object o)
        {
            return UnityEngine.PrimitiveType.Sphere;
        }
        static object get_Capsule_1(ref object o)
        {
            return UnityEngine.PrimitiveType.Capsule;
        }
        static object get_Cylinder_2(ref object o)
        {
            return UnityEngine.PrimitiveType.Cylinder;
        }
        static object get_Cube_3(ref object o)
        {
            return UnityEngine.PrimitiveType.Cube;
        }
        static object get_Plane_4(ref object o)
        {
            return UnityEngine.PrimitiveType.Plane;
        }
        static object get_Quad_5(ref object o)
        {
            return UnityEngine.PrimitiveType.Quad;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.PrimitiveType();
            ins = (UnityEngine.PrimitiveType)o;
            return ins;
        }


    }
}
#endif
