
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
    unsafe class UnityEngine_Events_UnityEventCallState_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Events.UnityEventCallState);

            field = type.GetField("Off", flag);
            app.RegisterCLRFieldGetter(field, get_Off_0);
            field = type.GetField("EditorAndRuntime", flag);
            app.RegisterCLRFieldGetter(field, get_EditorAndRuntime_1);
            field = type.GetField("RuntimeOnly", flag);
            app.RegisterCLRFieldGetter(field, get_RuntimeOnly_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Events.UnityEventCallState());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Events.UnityEventCallState[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.Events.UnityEventCallState instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Events.UnityEventCallState[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Off_0(ref object o)
        {
            return UnityEngine.Events.UnityEventCallState.Off;
        }
        static object get_EditorAndRuntime_1(ref object o)
        {
            return UnityEngine.Events.UnityEventCallState.EditorAndRuntime;
        }
        static object get_RuntimeOnly_2(ref object o)
        {
            return UnityEngine.Events.UnityEventCallState.RuntimeOnly;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Events.UnityEventCallState();
            ins = (UnityEngine.Events.UnityEventCallState)o;
            return ins;
        }


    }
}
#endif
