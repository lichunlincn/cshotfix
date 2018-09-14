
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
    unsafe class UnityEngine_ConnectionTesterStatus_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ConnectionTesterStatus);

            field = type.GetField("Error", flag);
            app.RegisterCLRFieldGetter(field, get_Error_0);
            field = type.GetField("Undetermined", flag);
            app.RegisterCLRFieldGetter(field, get_Undetermined_1);
            field = type.GetField("PublicIPIsConnectable", flag);
            app.RegisterCLRFieldGetter(field, get_PublicIPIsConnectable_2);
            field = type.GetField("PublicIPPortBlocked", flag);
            app.RegisterCLRFieldGetter(field, get_PublicIPPortBlocked_3);
            field = type.GetField("PublicIPNoServerStarted", flag);
            app.RegisterCLRFieldGetter(field, get_PublicIPNoServerStarted_4);
            field = type.GetField("LimitedNATPunchthroughPortRestricted", flag);
            app.RegisterCLRFieldGetter(field, get_LimitedNATPunchthroughPortRestricted_5);
            field = type.GetField("LimitedNATPunchthroughSymmetric", flag);
            app.RegisterCLRFieldGetter(field, get_LimitedNATPunchthroughSymmetric_6);
            field = type.GetField("NATpunchthroughFullCone", flag);
            app.RegisterCLRFieldGetter(field, get_NATpunchthroughFullCone_7);
            field = type.GetField("NATpunchthroughAddressRestrictedCone", flag);
            app.RegisterCLRFieldGetter(field, get_NATpunchthroughAddressRestrictedCone_8);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ConnectionTesterStatus());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ConnectionTesterStatus[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.ConnectionTesterStatus instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.ConnectionTesterStatus[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Error_0(ref object o)
        {
            return UnityEngine.ConnectionTesterStatus.Error;
        }
        static object get_Undetermined_1(ref object o)
        {
            return UnityEngine.ConnectionTesterStatus.Undetermined;
        }
        static object get_PublicIPIsConnectable_2(ref object o)
        {
            return UnityEngine.ConnectionTesterStatus.PublicIPIsConnectable;
        }
        static object get_PublicIPPortBlocked_3(ref object o)
        {
            return UnityEngine.ConnectionTesterStatus.PublicIPPortBlocked;
        }
        static object get_PublicIPNoServerStarted_4(ref object o)
        {
            return UnityEngine.ConnectionTesterStatus.PublicIPNoServerStarted;
        }
        static object get_LimitedNATPunchthroughPortRestricted_5(ref object o)
        {
            return UnityEngine.ConnectionTesterStatus.LimitedNATPunchthroughPortRestricted;
        }
        static object get_LimitedNATPunchthroughSymmetric_6(ref object o)
        {
            return UnityEngine.ConnectionTesterStatus.LimitedNATPunchthroughSymmetric;
        }
        static object get_NATpunchthroughFullCone_7(ref object o)
        {
            return UnityEngine.ConnectionTesterStatus.NATpunchthroughFullCone;
        }
        static object get_NATpunchthroughAddressRestrictedCone_8(ref object o)
        {
            return UnityEngine.ConnectionTesterStatus.NATpunchthroughAddressRestrictedCone;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.ConnectionTesterStatus();
            ins = (UnityEngine.ConnectionTesterStatus)o;
            return ins;
        }


    }
}
#endif
