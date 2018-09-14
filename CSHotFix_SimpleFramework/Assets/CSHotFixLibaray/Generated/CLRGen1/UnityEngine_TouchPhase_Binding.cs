
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

namespace CSHotFix.Runtime.Generated
{
    unsafe class UnityEngine_TouchPhase_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.TouchPhase);

            field = type.GetField("Began", flag);
            app.RegisterCLRFieldGetter(field, get_Began_0);
            field = type.GetField("Moved", flag);
            app.RegisterCLRFieldGetter(field, get_Moved_1);
            field = type.GetField("Stationary", flag);
            app.RegisterCLRFieldGetter(field, get_Stationary_2);
            field = type.GetField("Ended", flag);
            app.RegisterCLRFieldGetter(field, get_Ended_3);
            field = type.GetField("Canceled", flag);
            app.RegisterCLRFieldGetter(field, get_Canceled_4);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.TouchPhase());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.TouchPhase[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.TouchPhase instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.TouchPhase[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Began_0(ref object o)
        {
            return UnityEngine.TouchPhase.Began;
        }
        static object get_Moved_1(ref object o)
        {
            return UnityEngine.TouchPhase.Moved;
        }
        static object get_Stationary_2(ref object o)
        {
            return UnityEngine.TouchPhase.Stationary;
        }
        static object get_Ended_3(ref object o)
        {
            return UnityEngine.TouchPhase.Ended;
        }
        static object get_Canceled_4(ref object o)
        {
            return UnityEngine.TouchPhase.Canceled;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.TouchPhase();
            ins = (UnityEngine.TouchPhase)o;
            return ins;
        }


    }
}
#endif
