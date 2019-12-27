
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
    unsafe class UnityUI_UIPositionBy3D_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityUI.UIPositionBy3D);

            field = type.GetField("m_FromTransform", flag);
            app.RegisterCLRFieldGetter(field, get_m_FromTransform_0);
            app.RegisterCLRFieldSetter(field, set_m_FromTransform_0);
            field = type.GetField("m_SetTransrom", flag);
            app.RegisterCLRFieldGetter(field, get_m_SetTransrom_1);
            app.RegisterCLRFieldSetter(field, set_m_SetTransrom_1);
            field = type.GetField("m_Offset", flag);
            app.RegisterCLRFieldGetter(field, get_m_Offset_2);
            app.RegisterCLRFieldSetter(field, set_m_Offset_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityUI.UIPositionBy3D());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityUI.UIPositionBy3D[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_m_FromTransform_0(ref object o)
        {
            return ((UnityUI.UIPositionBy3D)o).m_FromTransform;
        }
        static void set_m_FromTransform_0(ref object o, object v)
        {
UnityUI.UIPositionBy3D _o = (UnityUI.UIPositionBy3D)o;
    _o.m_FromTransform = (UnityEngine.Transform)v;
        }
        static object get_m_SetTransrom_1(ref object o)
        {
            return ((UnityUI.UIPositionBy3D)o).m_SetTransrom;
        }
        static void set_m_SetTransrom_1(ref object o, object v)
        {
UnityUI.UIPositionBy3D _o = (UnityUI.UIPositionBy3D)o;
    _o.m_SetTransrom = (UnityEngine.Transform)v;
        }
        static object get_m_Offset_2(ref object o)
        {
            return ((UnityUI.UIPositionBy3D)o).m_Offset;
        }
        static void set_m_Offset_2(ref object o, object v)
        {
UnityUI.UIPositionBy3D _o = (UnityUI.UIPositionBy3D)o;
    _o.m_Offset = (UnityEngine.Vector2)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityUI.UIPositionBy3D();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
