
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
    unsafe class UnityEngine_LogType_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.LogType);

            field = type.GetField("Error", flag);
            app.RegisterCLRFieldGetter(field, get_Error_0);
            field = type.GetField("Assert", flag);
            app.RegisterCLRFieldGetter(field, get_Assert_1);
            field = type.GetField("Warning", flag);
            app.RegisterCLRFieldGetter(field, get_Warning_2);
            field = type.GetField("Log", flag);
            app.RegisterCLRFieldGetter(field, get_Log_3);
            field = type.GetField("Exception", flag);
            app.RegisterCLRFieldGetter(field, get_Exception_4);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.LogType());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.LogType[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.LogType instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.LogType[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Error_0(ref object o)
        {
            return UnityEngine.LogType.Error;
        }
        static object get_Assert_1(ref object o)
        {
            return UnityEngine.LogType.Assert;
        }
        static object get_Warning_2(ref object o)
        {
            return UnityEngine.LogType.Warning;
        }
        static object get_Log_3(ref object o)
        {
            return UnityEngine.LogType.Log;
        }
        static object get_Exception_4(ref object o)
        {
            return UnityEngine.LogType.Exception;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.LogType();
            ins = (UnityEngine.LogType)o;
            return ins;
        }


    }
}
#endif
