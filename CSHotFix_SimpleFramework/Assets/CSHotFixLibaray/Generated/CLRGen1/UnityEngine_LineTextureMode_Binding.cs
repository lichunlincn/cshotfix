
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
    unsafe class UnityEngine_LineTextureMode_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.LineTextureMode);

            field = type.GetField("Stretch", flag);
            app.RegisterCLRFieldGetter(field, get_Stretch_0);
            field = type.GetField("Tile", flag);
            app.RegisterCLRFieldGetter(field, get_Tile_1);
            field = type.GetField("DistributePerSegment", flag);
            app.RegisterCLRFieldGetter(field, get_DistributePerSegment_2);
            field = type.GetField("RepeatPerSegment", flag);
            app.RegisterCLRFieldGetter(field, get_RepeatPerSegment_3);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.LineTextureMode());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.LineTextureMode[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.LineTextureMode instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.LineTextureMode[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Stretch_0(ref object o)
        {
            return UnityEngine.LineTextureMode.Stretch;
        }
        static object get_Tile_1(ref object o)
        {
            return UnityEngine.LineTextureMode.Tile;
        }
        static object get_DistributePerSegment_2(ref object o)
        {
            return UnityEngine.LineTextureMode.DistributePerSegment;
        }
        static object get_RepeatPerSegment_3(ref object o)
        {
            return UnityEngine.LineTextureMode.RepeatPerSegment;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.LineTextureMode();
            ins = (UnityEngine.LineTextureMode)o;
            return ins;
        }


    }
}
#endif
