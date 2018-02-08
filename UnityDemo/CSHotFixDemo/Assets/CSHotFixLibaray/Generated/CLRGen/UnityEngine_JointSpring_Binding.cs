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
    unsafe class UnityEngine_JointSpring_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.JointSpring);

            field = type.GetField("spring", flag);
            app.RegisterCLRFieldGetter(field, get_spring_0);
            app.RegisterCLRFieldSetter(field, set_spring_0);
            field = type.GetField("damper", flag);
            app.RegisterCLRFieldGetter(field, get_damper_1);
            app.RegisterCLRFieldSetter(field, set_damper_1);
            field = type.GetField("targetPosition", flag);
            app.RegisterCLRFieldGetter(field, get_targetPosition_2);
            app.RegisterCLRFieldSetter(field, set_targetPosition_2);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.JointSpring());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.JointSpring[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.JointSpring instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.JointSpring[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_spring_0(ref object o)
        {
            return ((UnityEngine.JointSpring)o).spring;
        }
        static void set_spring_0(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.JointSpring* p = (UnityEngine.JointSpring *)(void *)h.AddrOfPinnedObject();
            p->spring = (System.Single)v;
            h.Free();
        }
        static object get_damper_1(ref object o)
        {
            return ((UnityEngine.JointSpring)o).damper;
        }
        static void set_damper_1(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.JointSpring* p = (UnityEngine.JointSpring *)(void *)h.AddrOfPinnedObject();
            p->damper = (System.Single)v;
            h.Free();
        }
        static object get_targetPosition_2(ref object o)
        {
            return ((UnityEngine.JointSpring)o).targetPosition;
        }
        static void set_targetPosition_2(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.JointSpring* p = (UnityEngine.JointSpring *)(void *)h.AddrOfPinnedObject();
            p->targetPosition = (System.Single)v;
            h.Free();
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.JointSpring();
            ins = (UnityEngine.JointSpring)o;
            return ins;
        }


    }
}
