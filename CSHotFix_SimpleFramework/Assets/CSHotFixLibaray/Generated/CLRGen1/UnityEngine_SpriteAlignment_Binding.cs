
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
    unsafe class UnityEngine_SpriteAlignment_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.SpriteAlignment);

            field = type.GetField("Center", flag);
            app.RegisterCLRFieldGetter(field, get_Center_0);
            field = type.GetField("TopLeft", flag);
            app.RegisterCLRFieldGetter(field, get_TopLeft_1);
            field = type.GetField("TopCenter", flag);
            app.RegisterCLRFieldGetter(field, get_TopCenter_2);
            field = type.GetField("TopRight", flag);
            app.RegisterCLRFieldGetter(field, get_TopRight_3);
            field = type.GetField("LeftCenter", flag);
            app.RegisterCLRFieldGetter(field, get_LeftCenter_4);
            field = type.GetField("RightCenter", flag);
            app.RegisterCLRFieldGetter(field, get_RightCenter_5);
            field = type.GetField("BottomLeft", flag);
            app.RegisterCLRFieldGetter(field, get_BottomLeft_6);
            field = type.GetField("BottomCenter", flag);
            app.RegisterCLRFieldGetter(field, get_BottomCenter_7);
            field = type.GetField("BottomRight", flag);
            app.RegisterCLRFieldGetter(field, get_BottomRight_8);
            field = type.GetField("Custom", flag);
            app.RegisterCLRFieldGetter(field, get_Custom_9);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.SpriteAlignment());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.SpriteAlignment[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.SpriteAlignment instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.SpriteAlignment[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Center_0(ref object o)
        {
            return UnityEngine.SpriteAlignment.Center;
        }
        static object get_TopLeft_1(ref object o)
        {
            return UnityEngine.SpriteAlignment.TopLeft;
        }
        static object get_TopCenter_2(ref object o)
        {
            return UnityEngine.SpriteAlignment.TopCenter;
        }
        static object get_TopRight_3(ref object o)
        {
            return UnityEngine.SpriteAlignment.TopRight;
        }
        static object get_LeftCenter_4(ref object o)
        {
            return UnityEngine.SpriteAlignment.LeftCenter;
        }
        static object get_RightCenter_5(ref object o)
        {
            return UnityEngine.SpriteAlignment.RightCenter;
        }
        static object get_BottomLeft_6(ref object o)
        {
            return UnityEngine.SpriteAlignment.BottomLeft;
        }
        static object get_BottomCenter_7(ref object o)
        {
            return UnityEngine.SpriteAlignment.BottomCenter;
        }
        static object get_BottomRight_8(ref object o)
        {
            return UnityEngine.SpriteAlignment.BottomRight;
        }
        static object get_Custom_9(ref object o)
        {
            return UnityEngine.SpriteAlignment.Custom;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.SpriteAlignment();
            ins = (UnityEngine.SpriteAlignment)o;
            return ins;
        }


    }
}
#endif
