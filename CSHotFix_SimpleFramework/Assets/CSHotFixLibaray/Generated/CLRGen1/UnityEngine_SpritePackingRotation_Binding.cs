
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
    unsafe class UnityEngine_SpritePackingRotation_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.SpritePackingRotation);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            field = type.GetField("FlipHorizontal", flag);
            app.RegisterCLRFieldGetter(field, get_FlipHorizontal_1);
            field = type.GetField("FlipVertical", flag);
            app.RegisterCLRFieldGetter(field, get_FlipVertical_2);
            field = type.GetField("Rotate180", flag);
            app.RegisterCLRFieldGetter(field, get_Rotate180_3);
            field = type.GetField("Any", flag);
            app.RegisterCLRFieldGetter(field, get_Any_4);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.SpritePackingRotation());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.SpritePackingRotation[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.SpritePackingRotation instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.SpritePackingRotation[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_None_0(ref object o)
        {
            return UnityEngine.SpritePackingRotation.None;
        }
        static object get_FlipHorizontal_1(ref object o)
        {
            return UnityEngine.SpritePackingRotation.FlipHorizontal;
        }
        static object get_FlipVertical_2(ref object o)
        {
            return UnityEngine.SpritePackingRotation.FlipVertical;
        }
        static object get_Rotate180_3(ref object o)
        {
            return UnityEngine.SpritePackingRotation.Rotate180;
        }
        static object get_Any_4(ref object o)
        {
            return UnityEngine.SpritePackingRotation.Any;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.SpritePackingRotation();
            ins = (UnityEngine.SpritePackingRotation)o;
            return ins;
        }


    }
}
#endif
