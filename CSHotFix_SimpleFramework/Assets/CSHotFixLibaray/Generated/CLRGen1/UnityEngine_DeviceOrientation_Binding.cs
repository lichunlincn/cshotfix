
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
    unsafe class UnityEngine_DeviceOrientation_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.DeviceOrientation);

            field = type.GetField("Unknown", flag);
            app.RegisterCLRFieldGetter(field, get_Unknown_0);
            field = type.GetField("Portrait", flag);
            app.RegisterCLRFieldGetter(field, get_Portrait_1);
            field = type.GetField("PortraitUpsideDown", flag);
            app.RegisterCLRFieldGetter(field, get_PortraitUpsideDown_2);
            field = type.GetField("LandscapeLeft", flag);
            app.RegisterCLRFieldGetter(field, get_LandscapeLeft_3);
            field = type.GetField("LandscapeRight", flag);
            app.RegisterCLRFieldGetter(field, get_LandscapeRight_4);
            field = type.GetField("FaceUp", flag);
            app.RegisterCLRFieldGetter(field, get_FaceUp_5);
            field = type.GetField("FaceDown", flag);
            app.RegisterCLRFieldGetter(field, get_FaceDown_6);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.DeviceOrientation());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.DeviceOrientation[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.DeviceOrientation instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.DeviceOrientation[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Unknown_0(ref object o)
        {
            return UnityEngine.DeviceOrientation.Unknown;
        }
        static object get_Portrait_1(ref object o)
        {
            return UnityEngine.DeviceOrientation.Portrait;
        }
        static object get_PortraitUpsideDown_2(ref object o)
        {
            return UnityEngine.DeviceOrientation.PortraitUpsideDown;
        }
        static object get_LandscapeLeft_3(ref object o)
        {
            return UnityEngine.DeviceOrientation.LandscapeLeft;
        }
        static object get_LandscapeRight_4(ref object o)
        {
            return UnityEngine.DeviceOrientation.LandscapeRight;
        }
        static object get_FaceUp_5(ref object o)
        {
            return UnityEngine.DeviceOrientation.FaceUp;
        }
        static object get_FaceDown_6(ref object o)
        {
            return UnityEngine.DeviceOrientation.FaceDown;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.DeviceOrientation();
            ins = (UnityEngine.DeviceOrientation)o;
            return ins;
        }


    }
}
#endif
