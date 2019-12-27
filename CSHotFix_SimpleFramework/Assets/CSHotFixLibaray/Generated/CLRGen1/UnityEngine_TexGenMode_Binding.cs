
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
    unsafe class UnityEngine_TexGenMode_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.TexGenMode);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            field = type.GetField("SphereMap", flag);
            app.RegisterCLRFieldGetter(field, get_SphereMap_1);
            field = type.GetField("Object", flag);
            app.RegisterCLRFieldGetter(field, get_Object_2);
            field = type.GetField("EyeLinear", flag);
            app.RegisterCLRFieldGetter(field, get_EyeLinear_3);
            field = type.GetField("CubeReflect", flag);
            app.RegisterCLRFieldGetter(field, get_CubeReflect_4);
            field = type.GetField("CubeNormal", flag);
            app.RegisterCLRFieldGetter(field, get_CubeNormal_5);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.TexGenMode());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.TexGenMode[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.TexGenMode instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.TexGenMode[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_None_0(ref object o)
        {
            return UnityEngine.TexGenMode.None;
        }
        static object get_SphereMap_1(ref object o)
        {
            return UnityEngine.TexGenMode.SphereMap;
        }
        static object get_Object_2(ref object o)
        {
            return UnityEngine.TexGenMode.Object;
        }
        static object get_EyeLinear_3(ref object o)
        {
            return UnityEngine.TexGenMode.EyeLinear;
        }
        static object get_CubeReflect_4(ref object o)
        {
            return UnityEngine.TexGenMode.CubeReflect;
        }
        static object get_CubeNormal_5(ref object o)
        {
            return UnityEngine.TexGenMode.CubeNormal;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.TexGenMode();
            ins = (UnityEngine.TexGenMode)o;
            return ins;
        }


    }
}
#endif
