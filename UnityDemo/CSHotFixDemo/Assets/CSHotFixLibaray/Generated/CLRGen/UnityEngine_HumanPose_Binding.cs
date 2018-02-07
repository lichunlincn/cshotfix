
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
    unsafe class UnityEngine_HumanPose_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.HumanPose);

            field = type.GetField("bodyPosition", flag);
            app.RegisterCLRFieldGetter(field, get_bodyPosition_0);
            app.RegisterCLRFieldSetter(field, set_bodyPosition_0);
            field = type.GetField("bodyRotation", flag);
            app.RegisterCLRFieldGetter(field, get_bodyRotation_1);
            app.RegisterCLRFieldSetter(field, set_bodyRotation_1);
            field = type.GetField("muscles", flag);
            app.RegisterCLRFieldGetter(field, get_muscles_2);
            app.RegisterCLRFieldSetter(field, set_muscles_2);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.HumanPose());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.HumanPose[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.HumanPose instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.HumanPose[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_bodyPosition_0(ref object o)
        {
            return ((UnityEngine.HumanPose)o).bodyPosition;
        }
        static void set_bodyPosition_0(ref object o, object v)
        {
UnityEngine.HumanPose _o = (UnityEngine.HumanPose)o;
    _o.bodyPosition = (UnityEngine.Vector3)v;
        }
        static object get_bodyRotation_1(ref object o)
        {
            return ((UnityEngine.HumanPose)o).bodyRotation;
        }
        static void set_bodyRotation_1(ref object o, object v)
        {
UnityEngine.HumanPose _o = (UnityEngine.HumanPose)o;
    _o.bodyRotation = (UnityEngine.Quaternion)v;
        }
        static object get_muscles_2(ref object o)
        {
            return ((UnityEngine.HumanPose)o).muscles;
        }
        static void set_muscles_2(ref object o, object v)
        {
UnityEngine.HumanPose _o = (UnityEngine.HumanPose)o;
    _o.muscles = (System.Single[])v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            return new UnityEngine.HumanPose
            {
                bodyPosition = ((UnityEngine.HumanPose) o).bodyPosition,
                bodyRotation = ((UnityEngine.HumanPose) o).bodyRotation,
                muscles = ((UnityEngine.HumanPose) o).muscles,
            };
        }


    }
}
