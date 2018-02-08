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
    unsafe class UnityEngine_Experimental_Rendering_LODParameters_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Experimental.Rendering.LODParameters);

            field = type.GetField("isOrthographic", flag);
            app.RegisterCLRFieldGetter(field, get_isOrthographic_0);
            app.RegisterCLRFieldSetter(field, set_isOrthographic_0);
            field = type.GetField("cameraPosition", flag);
            app.RegisterCLRFieldGetter(field, get_cameraPosition_1);
            app.RegisterCLRFieldSetter(field, set_cameraPosition_1);
            field = type.GetField("fieldOfView", flag);
            app.RegisterCLRFieldGetter(field, get_fieldOfView_2);
            app.RegisterCLRFieldSetter(field, set_fieldOfView_2);
            field = type.GetField("orthoSize", flag);
            app.RegisterCLRFieldGetter(field, get_orthoSize_3);
            app.RegisterCLRFieldSetter(field, set_orthoSize_3);
            field = type.GetField("cameraPixelHeight", flag);
            app.RegisterCLRFieldGetter(field, get_cameraPixelHeight_4);
            app.RegisterCLRFieldSetter(field, set_cameraPixelHeight_4);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Experimental.Rendering.LODParameters());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Experimental.Rendering.LODParameters[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.Experimental.Rendering.LODParameters instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Experimental.Rendering.LODParameters[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_isOrthographic_0(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.LODParameters)o).isOrthographic;
        }
        static void set_isOrthographic_0(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.LODParameters _o = (UnityEngine.Experimental.Rendering.LODParameters)o;
    _o.isOrthographic = (System.Boolean)v;
        }
        static object get_cameraPosition_1(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.LODParameters)o).cameraPosition;
        }
        static void set_cameraPosition_1(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.LODParameters _o = (UnityEngine.Experimental.Rendering.LODParameters)o;
    _o.cameraPosition = (UnityEngine.Vector3)v;
        }
        static object get_fieldOfView_2(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.LODParameters)o).fieldOfView;
        }
        static void set_fieldOfView_2(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.LODParameters _o = (UnityEngine.Experimental.Rendering.LODParameters)o;
    _o.fieldOfView = (System.Single)v;
        }
        static object get_orthoSize_3(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.LODParameters)o).orthoSize;
        }
        static void set_orthoSize_3(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.LODParameters _o = (UnityEngine.Experimental.Rendering.LODParameters)o;
    _o.orthoSize = (System.Single)v;
        }
        static object get_cameraPixelHeight_4(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.LODParameters)o).cameraPixelHeight;
        }
        static void set_cameraPixelHeight_4(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.LODParameters _o = (UnityEngine.Experimental.Rendering.LODParameters)o;
    _o.cameraPixelHeight = (System.Int32)v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Experimental.Rendering.LODParameters();
            ins = (UnityEngine.Experimental.Rendering.LODParameters)o;
            return ins;
        }


    }
}
