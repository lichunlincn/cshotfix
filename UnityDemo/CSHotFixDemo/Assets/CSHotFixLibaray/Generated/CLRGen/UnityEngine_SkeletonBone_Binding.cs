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
    unsafe class UnityEngine_SkeletonBone_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.SkeletonBone);

            field = type.GetField("name", flag);
            app.RegisterCLRFieldGetter(field, get_name_0);
            app.RegisterCLRFieldSetter(field, set_name_0);
            field = type.GetField("position", flag);
            app.RegisterCLRFieldGetter(field, get_position_1);
            app.RegisterCLRFieldSetter(field, set_position_1);
            field = type.GetField("rotation", flag);
            app.RegisterCLRFieldGetter(field, get_rotation_2);
            app.RegisterCLRFieldSetter(field, set_rotation_2);
            field = type.GetField("scale", flag);
            app.RegisterCLRFieldGetter(field, get_scale_3);
            app.RegisterCLRFieldSetter(field, set_scale_3);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.SkeletonBone());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.SkeletonBone[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.SkeletonBone instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.SkeletonBone[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_name_0(ref object o)
        {
            return ((UnityEngine.SkeletonBone)o).name;
        }
        static void set_name_0(ref object o, object v)
        {
UnityEngine.SkeletonBone _o = (UnityEngine.SkeletonBone)o;
    _o.name = (System.String)v;
        }
        static object get_position_1(ref object o)
        {
            return ((UnityEngine.SkeletonBone)o).position;
        }
        static void set_position_1(ref object o, object v)
        {
UnityEngine.SkeletonBone _o = (UnityEngine.SkeletonBone)o;
    _o.position = (UnityEngine.Vector3)v;
        }
        static object get_rotation_2(ref object o)
        {
            return ((UnityEngine.SkeletonBone)o).rotation;
        }
        static void set_rotation_2(ref object o, object v)
        {
UnityEngine.SkeletonBone _o = (UnityEngine.SkeletonBone)o;
    _o.rotation = (UnityEngine.Quaternion)v;
        }
        static object get_scale_3(ref object o)
        {
            return ((UnityEngine.SkeletonBone)o).scale;
        }
        static void set_scale_3(ref object o, object v)
        {
UnityEngine.SkeletonBone _o = (UnityEngine.SkeletonBone)o;
    _o.scale = (UnityEngine.Vector3)v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.SkeletonBone();
            ins = (UnityEngine.SkeletonBone)o;
            return ins;
        }


    }
}
