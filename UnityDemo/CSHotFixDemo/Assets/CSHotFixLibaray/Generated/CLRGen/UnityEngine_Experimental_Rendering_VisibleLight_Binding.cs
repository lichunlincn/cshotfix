
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
    unsafe class UnityEngine_Experimental_Rendering_VisibleLight_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Experimental.Rendering.VisibleLight);
            args = new Type[]{};
            method = type.GetMethod("get_light", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_light_0);

            field = type.GetField("lightType", flag);
            app.RegisterCLRFieldGetter(field, get_lightType_0);
            app.RegisterCLRFieldSetter(field, set_lightType_0);
            field = type.GetField("finalColor", flag);
            app.RegisterCLRFieldGetter(field, get_finalColor_1);
            app.RegisterCLRFieldSetter(field, set_finalColor_1);
            field = type.GetField("screenRect", flag);
            app.RegisterCLRFieldGetter(field, get_screenRect_2);
            app.RegisterCLRFieldSetter(field, set_screenRect_2);
            field = type.GetField("localToWorld", flag);
            app.RegisterCLRFieldGetter(field, get_localToWorld_3);
            app.RegisterCLRFieldSetter(field, set_localToWorld_3);
            field = type.GetField("range", flag);
            app.RegisterCLRFieldGetter(field, get_range_4);
            app.RegisterCLRFieldSetter(field, set_range_4);
            field = type.GetField("spotAngle", flag);
            app.RegisterCLRFieldGetter(field, get_spotAngle_5);
            app.RegisterCLRFieldSetter(field, set_spotAngle_5);
            field = type.GetField("flags", flag);
            app.RegisterCLRFieldGetter(field, get_flags_6);
            app.RegisterCLRFieldSetter(field, set_flags_6);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Experimental.Rendering.VisibleLight());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Experimental.Rendering.VisibleLight[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.Experimental.Rendering.VisibleLight instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Experimental.Rendering.VisibleLight[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* get_light_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Rendering.VisibleLight instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Rendering.VisibleLight)typeof(UnityEngine.Experimental.Rendering.VisibleLight).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.light;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_lightType_0(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.VisibleLight)o).lightType;
        }
        static void set_lightType_0(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.VisibleLight _o = (UnityEngine.Experimental.Rendering.VisibleLight)o;
    _o.lightType = (UnityEngine.LightType)v;
        }
        static object get_finalColor_1(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.VisibleLight)o).finalColor;
        }
        static void set_finalColor_1(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.VisibleLight _o = (UnityEngine.Experimental.Rendering.VisibleLight)o;
    _o.finalColor = (UnityEngine.Color)v;
        }
        static object get_screenRect_2(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.VisibleLight)o).screenRect;
        }
        static void set_screenRect_2(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.VisibleLight _o = (UnityEngine.Experimental.Rendering.VisibleLight)o;
    _o.screenRect = (UnityEngine.Rect)v;
        }
        static object get_localToWorld_3(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.VisibleLight)o).localToWorld;
        }
        static void set_localToWorld_3(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.VisibleLight _o = (UnityEngine.Experimental.Rendering.VisibleLight)o;
    _o.localToWorld = (UnityEngine.Matrix4x4)v;
        }
        static object get_range_4(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.VisibleLight)o).range;
        }
        static void set_range_4(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.VisibleLight _o = (UnityEngine.Experimental.Rendering.VisibleLight)o;
    _o.range = (System.Single)v;
        }
        static object get_spotAngle_5(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.VisibleLight)o).spotAngle;
        }
        static void set_spotAngle_5(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.VisibleLight _o = (UnityEngine.Experimental.Rendering.VisibleLight)o;
    _o.spotAngle = (System.Single)v;
        }
        static object get_flags_6(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.VisibleLight)o).flags;
        }
        static void set_flags_6(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.VisibleLight _o = (UnityEngine.Experimental.Rendering.VisibleLight)o;
    _o.flags = (UnityEngine.Experimental.Rendering.VisibleLightFlags)v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            return new UnityEngine.Experimental.Rendering.VisibleLight
            {
                lightType = ((UnityEngine.Experimental.Rendering.VisibleLight) o).lightType,
                finalColor = ((UnityEngine.Experimental.Rendering.VisibleLight) o).finalColor,
                screenRect = ((UnityEngine.Experimental.Rendering.VisibleLight) o).screenRect,
                localToWorld = ((UnityEngine.Experimental.Rendering.VisibleLight) o).localToWorld,
                range = ((UnityEngine.Experimental.Rendering.VisibleLight) o).range,
                spotAngle = ((UnityEngine.Experimental.Rendering.VisibleLight) o).spotAngle,
                flags = ((UnityEngine.Experimental.Rendering.VisibleLight) o).flags,
            };
        }


    }
}
