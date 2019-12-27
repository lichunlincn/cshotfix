
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
    unsafe class UnityEngine_LightType_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.LightType);

            field = type.GetField("Spot", flag);
            app.RegisterCLRFieldGetter(field, get_Spot_0);
            field = type.GetField("Directional", flag);
            app.RegisterCLRFieldGetter(field, get_Directional_1);
            field = type.GetField("Point", flag);
            app.RegisterCLRFieldGetter(field, get_Point_2);
            field = type.GetField("Area", flag);
            app.RegisterCLRFieldGetter(field, get_Area_3);
            field = type.GetField("Rectangle", flag);
            app.RegisterCLRFieldGetter(field, get_Rectangle_4);
            field = type.GetField("Disc", flag);
            app.RegisterCLRFieldGetter(field, get_Disc_5);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.LightType());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.LightType[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.LightType instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.LightType[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Spot_0(ref object o)
        {
            return UnityEngine.LightType.Spot;
        }
        static object get_Directional_1(ref object o)
        {
            return UnityEngine.LightType.Directional;
        }
        static object get_Point_2(ref object o)
        {
            return UnityEngine.LightType.Point;
        }
        static object get_Area_3(ref object o)
        {
            return UnityEngine.LightType.Area;
        }
        static object get_Rectangle_4(ref object o)
        {
            return UnityEngine.LightType.Rectangle;
        }
        static object get_Disc_5(ref object o)
        {
            return UnityEngine.LightType.Disc;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.LightType();
            ins = (UnityEngine.LightType)o;
            return ins;
        }


    }
}
#endif
