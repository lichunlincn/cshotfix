
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
    unsafe class UnityEngine_WrapMode_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.WrapMode);

            field = type.GetField("Once", flag);
            app.RegisterCLRFieldGetter(field, get_Once_0);
            field = type.GetField("Loop", flag);
            app.RegisterCLRFieldGetter(field, get_Loop_1);
            field = type.GetField("PingPong", flag);
            app.RegisterCLRFieldGetter(field, get_PingPong_2);
            field = type.GetField("Default", flag);
            app.RegisterCLRFieldGetter(field, get_Default_3);
            field = type.GetField("ClampForever", flag);
            app.RegisterCLRFieldGetter(field, get_ClampForever_4);
            field = type.GetField("Clamp", flag);
            app.RegisterCLRFieldGetter(field, get_Clamp_5);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.WrapMode());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.WrapMode[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.WrapMode instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.WrapMode[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Once_0(ref object o)
        {
            return UnityEngine.WrapMode.Once;
        }
        static object get_Loop_1(ref object o)
        {
            return UnityEngine.WrapMode.Loop;
        }
        static object get_PingPong_2(ref object o)
        {
            return UnityEngine.WrapMode.PingPong;
        }
        static object get_Default_3(ref object o)
        {
            return UnityEngine.WrapMode.Default;
        }
        static object get_ClampForever_4(ref object o)
        {
            return UnityEngine.WrapMode.ClampForever;
        }
        static object get_Clamp_5(ref object o)
        {
            return UnityEngine.WrapMode.Clamp;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.WrapMode();
            ins = (UnityEngine.WrapMode)o;
            return ins;
        }


    }
}
#endif
