
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
using System.Linq;
namespace CSHotFix.Runtime.Generated
{
    unsafe class UnityEngine_FrustumPlanes_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.FrustumPlanes);

            field = type.GetField("left", flag);
            app.RegisterCLRFieldGetter(field, get_left_0);
            app.RegisterCLRFieldSetter(field, set_left_0);
            field = type.GetField("right", flag);
            app.RegisterCLRFieldGetter(field, get_right_1);
            app.RegisterCLRFieldSetter(field, set_right_1);
            field = type.GetField("bottom", flag);
            app.RegisterCLRFieldGetter(field, get_bottom_2);
            app.RegisterCLRFieldSetter(field, set_bottom_2);
            field = type.GetField("top", flag);
            app.RegisterCLRFieldGetter(field, get_top_3);
            app.RegisterCLRFieldSetter(field, set_top_3);
            field = type.GetField("zNear", flag);
            app.RegisterCLRFieldGetter(field, get_zNear_4);
            app.RegisterCLRFieldSetter(field, set_zNear_4);
            field = type.GetField("zFar", flag);
            app.RegisterCLRFieldGetter(field, get_zFar_5);
            app.RegisterCLRFieldSetter(field, set_zFar_5);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.FrustumPlanes());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.FrustumPlanes[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.FrustumPlanes instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.FrustumPlanes[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_left_0(ref object o)
        {
            return ((UnityEngine.FrustumPlanes)o).left;
        }
        static void set_left_0(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.FrustumPlanes* p = (UnityEngine.FrustumPlanes *)(void *)h.AddrOfPinnedObject();
            p->left = (System.Single)v;
            h.Free();
        }
        static object get_right_1(ref object o)
        {
            return ((UnityEngine.FrustumPlanes)o).right;
        }
        static void set_right_1(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.FrustumPlanes* p = (UnityEngine.FrustumPlanes *)(void *)h.AddrOfPinnedObject();
            p->right = (System.Single)v;
            h.Free();
        }
        static object get_bottom_2(ref object o)
        {
            return ((UnityEngine.FrustumPlanes)o).bottom;
        }
        static void set_bottom_2(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.FrustumPlanes* p = (UnityEngine.FrustumPlanes *)(void *)h.AddrOfPinnedObject();
            p->bottom = (System.Single)v;
            h.Free();
        }
        static object get_top_3(ref object o)
        {
            return ((UnityEngine.FrustumPlanes)o).top;
        }
        static void set_top_3(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.FrustumPlanes* p = (UnityEngine.FrustumPlanes *)(void *)h.AddrOfPinnedObject();
            p->top = (System.Single)v;
            h.Free();
        }
        static object get_zNear_4(ref object o)
        {
            return ((UnityEngine.FrustumPlanes)o).zNear;
        }
        static void set_zNear_4(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.FrustumPlanes* p = (UnityEngine.FrustumPlanes *)(void *)h.AddrOfPinnedObject();
            p->zNear = (System.Single)v;
            h.Free();
        }
        static object get_zFar_5(ref object o)
        {
            return ((UnityEngine.FrustumPlanes)o).zFar;
        }
        static void set_zFar_5(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.FrustumPlanes* p = (UnityEngine.FrustumPlanes *)(void *)h.AddrOfPinnedObject();
            p->zFar = (System.Single)v;
            h.Free();
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.FrustumPlanes();
            ins = (UnityEngine.FrustumPlanes)o;
            return ins;
        }


    }
}
#endif
