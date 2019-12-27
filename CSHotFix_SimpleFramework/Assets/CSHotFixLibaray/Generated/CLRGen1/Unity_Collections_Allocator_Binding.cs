
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
    unsafe class Unity_Collections_Allocator_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Collections.Allocator);

            field = type.GetField("Invalid", flag);
            app.RegisterCLRFieldGetter(field, get_Invalid_0);
            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_1);
            field = type.GetField("Temp", flag);
            app.RegisterCLRFieldGetter(field, get_Temp_2);
            field = type.GetField("TempJob", flag);
            app.RegisterCLRFieldGetter(field, get_TempJob_3);
            field = type.GetField("Persistent", flag);
            app.RegisterCLRFieldGetter(field, get_Persistent_4);
            field = type.GetField("AudioKernel", flag);
            app.RegisterCLRFieldGetter(field, get_AudioKernel_5);


            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.Collections.Allocator());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Collections.Allocator[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref Unity.Collections.Allocator instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Unity.Collections.Allocator[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Invalid_0(ref object o)
        {
            return Unity.Collections.Allocator.Invalid;
        }
        static object get_None_1(ref object o)
        {
            return Unity.Collections.Allocator.None;
        }
        static object get_Temp_2(ref object o)
        {
            return Unity.Collections.Allocator.Temp;
        }
        static object get_TempJob_3(ref object o)
        {
            return Unity.Collections.Allocator.TempJob;
        }
        static object get_Persistent_4(ref object o)
        {
            return Unity.Collections.Allocator.Persistent;
        }
        static object get_AudioKernel_5(ref object o)
        {
            return Unity.Collections.Allocator.AudioKernel;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Unity.Collections.Allocator();
            ins = (Unity.Collections.Allocator)o;
            return ins;
        }


    }
}
#endif
