
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
    unsafe class UnityEngine_ComputeBufferType_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ComputeBufferType);

            field = type.GetField("Default", flag);
            app.RegisterCLRFieldGetter(field, get_Default_0);
            field = type.GetField("Raw", flag);
            app.RegisterCLRFieldGetter(field, get_Raw_1);
            field = type.GetField("Append", flag);
            app.RegisterCLRFieldGetter(field, get_Append_2);
            field = type.GetField("Counter", flag);
            app.RegisterCLRFieldGetter(field, get_Counter_3);
            field = type.GetField("Constant", flag);
            app.RegisterCLRFieldGetter(field, get_Constant_4);
            field = type.GetField("Structured", flag);
            app.RegisterCLRFieldGetter(field, get_Structured_5);
            field = type.GetField("IndirectArguments", flag);
            app.RegisterCLRFieldGetter(field, get_IndirectArguments_6);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ComputeBufferType());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ComputeBufferType[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.ComputeBufferType instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.ComputeBufferType[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Default_0(ref object o)
        {
            return UnityEngine.ComputeBufferType.Default;
        }
        static object get_Raw_1(ref object o)
        {
            return UnityEngine.ComputeBufferType.Raw;
        }
        static object get_Append_2(ref object o)
        {
            return UnityEngine.ComputeBufferType.Append;
        }
        static object get_Counter_3(ref object o)
        {
            return UnityEngine.ComputeBufferType.Counter;
        }
        static object get_Constant_4(ref object o)
        {
            return UnityEngine.ComputeBufferType.Constant;
        }
        static object get_Structured_5(ref object o)
        {
            return UnityEngine.ComputeBufferType.Structured;
        }
        static object get_IndirectArguments_6(ref object o)
        {
            return UnityEngine.ComputeBufferType.IndirectArguments;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.ComputeBufferType();
            ins = (UnityEngine.ComputeBufferType)o;
            return ins;
        }


    }
}
#endif
