
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
    unsafe class UnityEngine_TreeInstance_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.TreeInstance);

            field = type.GetField("position", flag);
            app.RegisterCLRFieldGetter(field, get_position_0);
            app.RegisterCLRFieldSetter(field, set_position_0);
            field = type.GetField("widthScale", flag);
            app.RegisterCLRFieldGetter(field, get_widthScale_1);
            app.RegisterCLRFieldSetter(field, set_widthScale_1);
            field = type.GetField("heightScale", flag);
            app.RegisterCLRFieldGetter(field, get_heightScale_2);
            app.RegisterCLRFieldSetter(field, set_heightScale_2);
            field = type.GetField("rotation", flag);
            app.RegisterCLRFieldGetter(field, get_rotation_3);
            app.RegisterCLRFieldSetter(field, set_rotation_3);
            field = type.GetField("color", flag);
            app.RegisterCLRFieldGetter(field, get_color_4);
            app.RegisterCLRFieldSetter(field, set_color_4);
            field = type.GetField("lightmapColor", flag);
            app.RegisterCLRFieldGetter(field, get_lightmapColor_5);
            app.RegisterCLRFieldSetter(field, set_lightmapColor_5);
            field = type.GetField("prototypeIndex", flag);
            app.RegisterCLRFieldGetter(field, get_prototypeIndex_6);
            app.RegisterCLRFieldSetter(field, set_prototypeIndex_6);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.TreeInstance());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.TreeInstance[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.TreeInstance instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.TreeInstance[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_position_0(ref object o)
        {
            return ((UnityEngine.TreeInstance)o).position;
        }
        static void set_position_0(ref object o, object v)
        {
UnityEngine.TreeInstance _o = (UnityEngine.TreeInstance)o;
    _o.position = (UnityEngine.Vector3)v;
        }
        static object get_widthScale_1(ref object o)
        {
            return ((UnityEngine.TreeInstance)o).widthScale;
        }
        static void set_widthScale_1(ref object o, object v)
        {
UnityEngine.TreeInstance _o = (UnityEngine.TreeInstance)o;
    _o.widthScale = (System.Single)v;
        }
        static object get_heightScale_2(ref object o)
        {
            return ((UnityEngine.TreeInstance)o).heightScale;
        }
        static void set_heightScale_2(ref object o, object v)
        {
UnityEngine.TreeInstance _o = (UnityEngine.TreeInstance)o;
    _o.heightScale = (System.Single)v;
        }
        static object get_rotation_3(ref object o)
        {
            return ((UnityEngine.TreeInstance)o).rotation;
        }
        static void set_rotation_3(ref object o, object v)
        {
UnityEngine.TreeInstance _o = (UnityEngine.TreeInstance)o;
    _o.rotation = (System.Single)v;
        }
        static object get_color_4(ref object o)
        {
            return ((UnityEngine.TreeInstance)o).color;
        }
        static void set_color_4(ref object o, object v)
        {
UnityEngine.TreeInstance _o = (UnityEngine.TreeInstance)o;
    _o.color = (UnityEngine.Color32)v;
        }
        static object get_lightmapColor_5(ref object o)
        {
            return ((UnityEngine.TreeInstance)o).lightmapColor;
        }
        static void set_lightmapColor_5(ref object o, object v)
        {
UnityEngine.TreeInstance _o = (UnityEngine.TreeInstance)o;
    _o.lightmapColor = (UnityEngine.Color32)v;
        }
        static object get_prototypeIndex_6(ref object o)
        {
            return ((UnityEngine.TreeInstance)o).prototypeIndex;
        }
        static void set_prototypeIndex_6(ref object o, object v)
        {
UnityEngine.TreeInstance _o = (UnityEngine.TreeInstance)o;
    _o.prototypeIndex = (System.Int32)v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            return new UnityEngine.TreeInstance
            {
                position = ((UnityEngine.TreeInstance) o).position,
                widthScale = ((UnityEngine.TreeInstance) o).widthScale,
                heightScale = ((UnityEngine.TreeInstance) o).heightScale,
                rotation = ((UnityEngine.TreeInstance) o).rotation,
                color = ((UnityEngine.TreeInstance) o).color,
                lightmapColor = ((UnityEngine.TreeInstance) o).lightmapColor,
                prototypeIndex = ((UnityEngine.TreeInstance) o).prototypeIndex,
            };
        }


    }
}
