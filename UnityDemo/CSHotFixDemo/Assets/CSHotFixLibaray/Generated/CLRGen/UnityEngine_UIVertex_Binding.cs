
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
    unsafe class UnityEngine_UIVertex_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.UIVertex);

            field = type.GetField("position", flag);
            app.RegisterCLRFieldGetter(field, get_position_0);
            app.RegisterCLRFieldSetter(field, set_position_0);
            field = type.GetField("normal", flag);
            app.RegisterCLRFieldGetter(field, get_normal_1);
            app.RegisterCLRFieldSetter(field, set_normal_1);
            field = type.GetField("color", flag);
            app.RegisterCLRFieldGetter(field, get_color_2);
            app.RegisterCLRFieldSetter(field, set_color_2);
            field = type.GetField("uv0", flag);
            app.RegisterCLRFieldGetter(field, get_uv0_3);
            app.RegisterCLRFieldSetter(field, set_uv0_3);
            field = type.GetField("uv1", flag);
            app.RegisterCLRFieldGetter(field, get_uv1_4);
            app.RegisterCLRFieldSetter(field, set_uv1_4);
            field = type.GetField("uv2", flag);
            app.RegisterCLRFieldGetter(field, get_uv2_5);
            app.RegisterCLRFieldSetter(field, set_uv2_5);
            field = type.GetField("uv3", flag);
            app.RegisterCLRFieldGetter(field, get_uv3_6);
            app.RegisterCLRFieldSetter(field, set_uv3_6);
            field = type.GetField("tangent", flag);
            app.RegisterCLRFieldGetter(field, get_tangent_7);
            app.RegisterCLRFieldSetter(field, set_tangent_7);
            field = type.GetField("simpleVert", flag);
            app.RegisterCLRFieldGetter(field, get_simpleVert_8);
            app.RegisterCLRFieldSetter(field, set_simpleVert_8);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.UIVertex());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.UIVertex[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.UIVertex instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.UIVertex[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_position_0(ref object o)
        {
            return ((UnityEngine.UIVertex)o).position;
        }
        static void set_position_0(ref object o, object v)
        {
UnityEngine.UIVertex _o = (UnityEngine.UIVertex)o;
    _o.position = (UnityEngine.Vector3)v;
        }
        static object get_normal_1(ref object o)
        {
            return ((UnityEngine.UIVertex)o).normal;
        }
        static void set_normal_1(ref object o, object v)
        {
UnityEngine.UIVertex _o = (UnityEngine.UIVertex)o;
    _o.normal = (UnityEngine.Vector3)v;
        }
        static object get_color_2(ref object o)
        {
            return ((UnityEngine.UIVertex)o).color;
        }
        static void set_color_2(ref object o, object v)
        {
UnityEngine.UIVertex _o = (UnityEngine.UIVertex)o;
    _o.color = (UnityEngine.Color32)v;
        }
        static object get_uv0_3(ref object o)
        {
            return ((UnityEngine.UIVertex)o).uv0;
        }
        static void set_uv0_3(ref object o, object v)
        {
UnityEngine.UIVertex _o = (UnityEngine.UIVertex)o;
    _o.uv0 = (UnityEngine.Vector2)v;
        }
        static object get_uv1_4(ref object o)
        {
            return ((UnityEngine.UIVertex)o).uv1;
        }
        static void set_uv1_4(ref object o, object v)
        {
UnityEngine.UIVertex _o = (UnityEngine.UIVertex)o;
    _o.uv1 = (UnityEngine.Vector2)v;
        }
        static object get_uv2_5(ref object o)
        {
            return ((UnityEngine.UIVertex)o).uv2;
        }
        static void set_uv2_5(ref object o, object v)
        {
UnityEngine.UIVertex _o = (UnityEngine.UIVertex)o;
    _o.uv2 = (UnityEngine.Vector2)v;
        }
        static object get_uv3_6(ref object o)
        {
            return ((UnityEngine.UIVertex)o).uv3;
        }
        static void set_uv3_6(ref object o, object v)
        {
UnityEngine.UIVertex _o = (UnityEngine.UIVertex)o;
    _o.uv3 = (UnityEngine.Vector2)v;
        }
        static object get_tangent_7(ref object o)
        {
            return ((UnityEngine.UIVertex)o).tangent;
        }
        static void set_tangent_7(ref object o, object v)
        {
UnityEngine.UIVertex _o = (UnityEngine.UIVertex)o;
    _o.tangent = (UnityEngine.Vector4)v;
        }
        static object get_simpleVert_8(ref object o)
        {
            return UnityEngine.UIVertex.simpleVert;
        }
        static void set_simpleVert_8(ref object o, object v)
        {
            UnityEngine.UIVertex.simpleVert = (UnityEngine.UIVertex)v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            return new UnityEngine.UIVertex
            {
                position = ((UnityEngine.UIVertex) o).position,
                normal = ((UnityEngine.UIVertex) o).normal,
                color = ((UnityEngine.UIVertex) o).color,
                uv0 = ((UnityEngine.UIVertex) o).uv0,
                uv1 = ((UnityEngine.UIVertex) o).uv1,
                uv2 = ((UnityEngine.UIVertex) o).uv2,
                uv3 = ((UnityEngine.UIVertex) o).uv3,
                tangent = ((UnityEngine.UIVertex) o).tangent,
            };
        }


    }
}
