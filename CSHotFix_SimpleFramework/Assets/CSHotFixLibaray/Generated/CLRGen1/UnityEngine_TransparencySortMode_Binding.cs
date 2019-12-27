
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
    unsafe class UnityEngine_TransparencySortMode_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.TransparencySortMode);

            field = type.GetField("Default", flag);
            app.RegisterCLRFieldGetter(field, get_Default_0);
            field = type.GetField("Perspective", flag);
            app.RegisterCLRFieldGetter(field, get_Perspective_1);
            field = type.GetField("Orthographic", flag);
            app.RegisterCLRFieldGetter(field, get_Orthographic_2);
            field = type.GetField("CustomAxis", flag);
            app.RegisterCLRFieldGetter(field, get_CustomAxis_3);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.TransparencySortMode());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.TransparencySortMode[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.TransparencySortMode instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.TransparencySortMode[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Default_0(ref object o)
        {
            return UnityEngine.TransparencySortMode.Default;
        }
        static object get_Perspective_1(ref object o)
        {
            return UnityEngine.TransparencySortMode.Perspective;
        }
        static object get_Orthographic_2(ref object o)
        {
            return UnityEngine.TransparencySortMode.Orthographic;
        }
        static object get_CustomAxis_3(ref object o)
        {
            return UnityEngine.TransparencySortMode.CustomAxis;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.TransparencySortMode();
            ins = (UnityEngine.TransparencySortMode)o;
            return ins;
        }


    }
}
#endif
