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
    unsafe class UnityEngine_Experimental_Rendering_VisibleReflectionProbe_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Experimental.Rendering.VisibleReflectionProbe);
            args = new Type[]{};
            method = type.GetMethod("get_texture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_texture_0);
            args = new Type[]{};
            method = type.GetMethod("get_probe", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_probe_1);

            field = type.GetField("bounds", flag);
            app.RegisterCLRFieldGetter(field, get_bounds_0);
            app.RegisterCLRFieldSetter(field, set_bounds_0);
            field = type.GetField("localToWorld", flag);
            app.RegisterCLRFieldGetter(field, get_localToWorld_1);
            app.RegisterCLRFieldSetter(field, set_localToWorld_1);
            field = type.GetField("hdr", flag);
            app.RegisterCLRFieldGetter(field, get_hdr_2);
            app.RegisterCLRFieldSetter(field, set_hdr_2);
            field = type.GetField("center", flag);
            app.RegisterCLRFieldGetter(field, get_center_3);
            app.RegisterCLRFieldSetter(field, set_center_3);
            field = type.GetField("blendDistance", flag);
            app.RegisterCLRFieldGetter(field, get_blendDistance_4);
            app.RegisterCLRFieldSetter(field, set_blendDistance_4);
            field = type.GetField("importance", flag);
            app.RegisterCLRFieldGetter(field, get_importance_5);
            app.RegisterCLRFieldSetter(field, set_importance_5);
            field = type.GetField("boxProjection", flag);
            app.RegisterCLRFieldGetter(field, get_boxProjection_6);
            app.RegisterCLRFieldSetter(field, set_boxProjection_6);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Experimental.Rendering.VisibleReflectionProbe());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Experimental.Rendering.VisibleReflectionProbe[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.Experimental.Rendering.VisibleReflectionProbe instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Experimental.Rendering.VisibleReflectionProbe[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* get_texture_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Rendering.VisibleReflectionProbe instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Rendering.VisibleReflectionProbe)typeof(UnityEngine.Experimental.Rendering.VisibleReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.texture;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_probe_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Rendering.VisibleReflectionProbe instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Rendering.VisibleReflectionProbe)typeof(UnityEngine.Experimental.Rendering.VisibleReflectionProbe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.probe;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_bounds_0(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.VisibleReflectionProbe)o).bounds;
        }
        static void set_bounds_0(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.VisibleReflectionProbe _o = (UnityEngine.Experimental.Rendering.VisibleReflectionProbe)o;
    _o.bounds = (UnityEngine.Bounds)v;
        }
        static object get_localToWorld_1(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.VisibleReflectionProbe)o).localToWorld;
        }
        static void set_localToWorld_1(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.VisibleReflectionProbe _o = (UnityEngine.Experimental.Rendering.VisibleReflectionProbe)o;
    _o.localToWorld = (UnityEngine.Matrix4x4)v;
        }
        static object get_hdr_2(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.VisibleReflectionProbe)o).hdr;
        }
        static void set_hdr_2(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.VisibleReflectionProbe _o = (UnityEngine.Experimental.Rendering.VisibleReflectionProbe)o;
    _o.hdr = (UnityEngine.Vector4)v;
        }
        static object get_center_3(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.VisibleReflectionProbe)o).center;
        }
        static void set_center_3(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.VisibleReflectionProbe _o = (UnityEngine.Experimental.Rendering.VisibleReflectionProbe)o;
    _o.center = (UnityEngine.Vector3)v;
        }
        static object get_blendDistance_4(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.VisibleReflectionProbe)o).blendDistance;
        }
        static void set_blendDistance_4(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.VisibleReflectionProbe _o = (UnityEngine.Experimental.Rendering.VisibleReflectionProbe)o;
    _o.blendDistance = (System.Single)v;
        }
        static object get_importance_5(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.VisibleReflectionProbe)o).importance;
        }
        static void set_importance_5(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.VisibleReflectionProbe _o = (UnityEngine.Experimental.Rendering.VisibleReflectionProbe)o;
    _o.importance = (System.Int32)v;
        }
        static object get_boxProjection_6(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.VisibleReflectionProbe)o).boxProjection;
        }
        static void set_boxProjection_6(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.VisibleReflectionProbe _o = (UnityEngine.Experimental.Rendering.VisibleReflectionProbe)o;
    _o.boxProjection = (System.Int32)v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Experimental.Rendering.VisibleReflectionProbe();
            ins = (UnityEngine.Experimental.Rendering.VisibleReflectionProbe)o;
            return ins;
        }


    }
}
