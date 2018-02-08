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
    unsafe class UnityEngine_Experimental_Rendering_DrawRendererSortSettings_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Experimental.Rendering.DrawRendererSortSettings);
            args = new Type[]{};
            method = type.GetMethod("get_sortOrthographic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sortOrthographic_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_sortOrthographic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sortOrthographic_1);

            field = type.GetField("worldToCameraMatrix", flag);
            app.RegisterCLRFieldGetter(field, get_worldToCameraMatrix_0);
            app.RegisterCLRFieldSetter(field, set_worldToCameraMatrix_0);
            field = type.GetField("cameraPosition", flag);
            app.RegisterCLRFieldGetter(field, get_cameraPosition_1);
            app.RegisterCLRFieldSetter(field, set_cameraPosition_1);
            field = type.GetField("flags", flag);
            app.RegisterCLRFieldGetter(field, get_flags_2);
            app.RegisterCLRFieldSetter(field, set_flags_2);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Experimental.Rendering.DrawRendererSortSettings());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Experimental.Rendering.DrawRendererSortSettings[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.Experimental.Rendering.DrawRendererSortSettings instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Experimental.Rendering.DrawRendererSortSettings[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* get_sortOrthographic_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Rendering.DrawRendererSortSettings instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Rendering.DrawRendererSortSettings)typeof(UnityEngine.Experimental.Rendering.DrawRendererSortSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.sortOrthographic;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_sortOrthographic_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Rendering.DrawRendererSortSettings instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Rendering.DrawRendererSortSettings)typeof(UnityEngine.Experimental.Rendering.DrawRendererSortSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.sortOrthographic = value;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }


        static object get_worldToCameraMatrix_0(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.DrawRendererSortSettings)o).worldToCameraMatrix;
        }
        static void set_worldToCameraMatrix_0(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.DrawRendererSortSettings _o = (UnityEngine.Experimental.Rendering.DrawRendererSortSettings)o;
    _o.worldToCameraMatrix = (UnityEngine.Matrix4x4)v;
        }
        static object get_cameraPosition_1(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.DrawRendererSortSettings)o).cameraPosition;
        }
        static void set_cameraPosition_1(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.DrawRendererSortSettings _o = (UnityEngine.Experimental.Rendering.DrawRendererSortSettings)o;
    _o.cameraPosition = (UnityEngine.Vector3)v;
        }
        static object get_flags_2(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.DrawRendererSortSettings)o).flags;
        }
        static void set_flags_2(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.DrawRendererSortSettings _o = (UnityEngine.Experimental.Rendering.DrawRendererSortSettings)o;
    _o.flags = (UnityEngine.Experimental.Rendering.SortFlags)v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Experimental.Rendering.DrawRendererSortSettings();
            ins = (UnityEngine.Experimental.Rendering.DrawRendererSortSettings)o;
            return ins;
        }


    }
}
