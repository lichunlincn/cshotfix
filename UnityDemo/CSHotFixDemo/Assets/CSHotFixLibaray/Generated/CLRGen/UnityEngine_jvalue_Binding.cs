
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
    unsafe class UnityEngine_jvalue_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.jvalue);

            field = type.GetField("z", flag);
            app.RegisterCLRFieldGetter(field, get_z_0);
            app.RegisterCLRFieldSetter(field, set_z_0);
            field = type.GetField("b", flag);
            app.RegisterCLRFieldGetter(field, get_b_1);
            app.RegisterCLRFieldSetter(field, set_b_1);
            field = type.GetField("c", flag);
            app.RegisterCLRFieldGetter(field, get_c_2);
            app.RegisterCLRFieldSetter(field, set_c_2);
            field = type.GetField("s", flag);
            app.RegisterCLRFieldGetter(field, get_s_3);
            app.RegisterCLRFieldSetter(field, set_s_3);
            field = type.GetField("i", flag);
            app.RegisterCLRFieldGetter(field, get_i_4);
            app.RegisterCLRFieldSetter(field, set_i_4);
            field = type.GetField("j", flag);
            app.RegisterCLRFieldGetter(field, get_j_5);
            app.RegisterCLRFieldSetter(field, set_j_5);
            field = type.GetField("f", flag);
            app.RegisterCLRFieldGetter(field, get_f_6);
            app.RegisterCLRFieldSetter(field, set_f_6);
            field = type.GetField("d", flag);
            app.RegisterCLRFieldGetter(field, get_d_7);
            app.RegisterCLRFieldSetter(field, set_d_7);
            field = type.GetField("l", flag);
            app.RegisterCLRFieldGetter(field, get_l_8);
            app.RegisterCLRFieldSetter(field, set_l_8);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.jvalue());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.jvalue[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.jvalue instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.jvalue[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_z_0(ref object o)
        {
            return ((UnityEngine.jvalue)o).z;
        }
        static void set_z_0(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.jvalue* p = (UnityEngine.jvalue *)(void *)h.AddrOfPinnedObject();
            p->z = (System.Boolean)v;
            h.Free();
        }
        static object get_b_1(ref object o)
        {
            return ((UnityEngine.jvalue)o).b;
        }
        static void set_b_1(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.jvalue* p = (UnityEngine.jvalue *)(void *)h.AddrOfPinnedObject();
            p->b = (System.Byte)v;
            h.Free();
        }
        static object get_c_2(ref object o)
        {
            return ((UnityEngine.jvalue)o).c;
        }
        static void set_c_2(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.jvalue* p = (UnityEngine.jvalue *)(void *)h.AddrOfPinnedObject();
            p->c = (System.Char)v;
            h.Free();
        }
        static object get_s_3(ref object o)
        {
            return ((UnityEngine.jvalue)o).s;
        }
        static void set_s_3(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.jvalue* p = (UnityEngine.jvalue *)(void *)h.AddrOfPinnedObject();
            p->s = (System.Int16)v;
            h.Free();
        }
        static object get_i_4(ref object o)
        {
            return ((UnityEngine.jvalue)o).i;
        }
        static void set_i_4(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.jvalue* p = (UnityEngine.jvalue *)(void *)h.AddrOfPinnedObject();
            p->i = (System.Int32)v;
            h.Free();
        }
        static object get_j_5(ref object o)
        {
            return ((UnityEngine.jvalue)o).j;
        }
        static void set_j_5(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.jvalue* p = (UnityEngine.jvalue *)(void *)h.AddrOfPinnedObject();
            p->j = (System.Int64)v;
            h.Free();
        }
        static object get_f_6(ref object o)
        {
            return ((UnityEngine.jvalue)o).f;
        }
        static void set_f_6(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.jvalue* p = (UnityEngine.jvalue *)(void *)h.AddrOfPinnedObject();
            p->f = (System.Single)v;
            h.Free();
        }
        static object get_d_7(ref object o)
        {
            return ((UnityEngine.jvalue)o).d;
        }
        static void set_d_7(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.jvalue* p = (UnityEngine.jvalue *)(void *)h.AddrOfPinnedObject();
            p->d = (System.Double)v;
            h.Free();
        }
        static object get_l_8(ref object o)
        {
            return ((UnityEngine.jvalue)o).l;
        }
        static void set_l_8(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.jvalue* p = (UnityEngine.jvalue *)(void *)h.AddrOfPinnedObject();
            p->l = (System.IntPtr)v;
            h.Free();
        }

        static object PerformMemberwiseClone(ref object o)
        {
            return new UnityEngine.jvalue
            {
                z = ((UnityEngine.jvalue) o).z,
                b = ((UnityEngine.jvalue) o).b,
                c = ((UnityEngine.jvalue) o).c,
                s = ((UnityEngine.jvalue) o).s,
                i = ((UnityEngine.jvalue) o).i,
                j = ((UnityEngine.jvalue) o).j,
                f = ((UnityEngine.jvalue) o).f,
                d = ((UnityEngine.jvalue) o).d,
                l = ((UnityEngine.jvalue) o).l,
            };
        }


    }
}
