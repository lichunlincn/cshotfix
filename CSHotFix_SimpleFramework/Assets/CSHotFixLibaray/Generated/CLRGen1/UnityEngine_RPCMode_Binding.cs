
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
    unsafe class UnityEngine_RPCMode_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.RPCMode);

            field = type.GetField("Server", flag);
            app.RegisterCLRFieldGetter(field, get_Server_0);
            field = type.GetField("Others", flag);
            app.RegisterCLRFieldGetter(field, get_Others_1);
            field = type.GetField("OthersBuffered", flag);
            app.RegisterCLRFieldGetter(field, get_OthersBuffered_2);
            field = type.GetField("All", flag);
            app.RegisterCLRFieldGetter(field, get_All_3);
            field = type.GetField("AllBuffered", flag);
            app.RegisterCLRFieldGetter(field, get_AllBuffered_4);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.RPCMode());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.RPCMode[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.RPCMode instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.RPCMode[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Server_0(ref object o)
        {
            return UnityEngine.RPCMode.Server;
        }
        static object get_Others_1(ref object o)
        {
            return UnityEngine.RPCMode.Others;
        }
        static object get_OthersBuffered_2(ref object o)
        {
            return UnityEngine.RPCMode.OthersBuffered;
        }
        static object get_All_3(ref object o)
        {
            return UnityEngine.RPCMode.All;
        }
        static object get_AllBuffered_4(ref object o)
        {
            return UnityEngine.RPCMode.AllBuffered;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.RPCMode();
            ins = (UnityEngine.RPCMode)o;
            return ins;
        }


    }
}
#endif
