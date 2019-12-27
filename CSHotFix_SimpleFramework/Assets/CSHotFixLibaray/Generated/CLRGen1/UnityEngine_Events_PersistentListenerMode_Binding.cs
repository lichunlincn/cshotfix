
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
    unsafe class UnityEngine_Events_PersistentListenerMode_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Events.PersistentListenerMode);

            field = type.GetField("EventDefined", flag);
            app.RegisterCLRFieldGetter(field, get_EventDefined_0);
            field = type.GetField("Void", flag);
            app.RegisterCLRFieldGetter(field, get_Void_1);
            field = type.GetField("Object", flag);
            app.RegisterCLRFieldGetter(field, get_Object_2);
            field = type.GetField("Int", flag);
            app.RegisterCLRFieldGetter(field, get_Int_3);
            field = type.GetField("Float", flag);
            app.RegisterCLRFieldGetter(field, get_Float_4);
            field = type.GetField("String", flag);
            app.RegisterCLRFieldGetter(field, get_String_5);
            field = type.GetField("Bool", flag);
            app.RegisterCLRFieldGetter(field, get_Bool_6);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Events.PersistentListenerMode());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Events.PersistentListenerMode[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.Events.PersistentListenerMode instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Events.PersistentListenerMode[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_EventDefined_0(ref object o)
        {
            return UnityEngine.Events.PersistentListenerMode.EventDefined;
        }
        static object get_Void_1(ref object o)
        {
            return UnityEngine.Events.PersistentListenerMode.Void;
        }
        static object get_Object_2(ref object o)
        {
            return UnityEngine.Events.PersistentListenerMode.Object;
        }
        static object get_Int_3(ref object o)
        {
            return UnityEngine.Events.PersistentListenerMode.Int;
        }
        static object get_Float_4(ref object o)
        {
            return UnityEngine.Events.PersistentListenerMode.Float;
        }
        static object get_String_5(ref object o)
        {
            return UnityEngine.Events.PersistentListenerMode.String;
        }
        static object get_Bool_6(ref object o)
        {
            return UnityEngine.Events.PersistentListenerMode.Bool;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Events.PersistentListenerMode();
            ins = (UnityEngine.Events.PersistentListenerMode)o;
            return ins;
        }


    }
}
#endif
