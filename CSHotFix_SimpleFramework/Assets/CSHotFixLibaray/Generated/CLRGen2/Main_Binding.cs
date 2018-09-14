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
    unsafe class Main_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Main);

            field = type.GetField("m_FixBug", flag);
            app.RegisterCLRFieldGetter(field, get_m_FixBug_0);
            app.RegisterCLRFieldSetter(field, set_m_FixBug_0);


        }



        static object get_m_FixBug_0(ref object o)
        {
            return ((Main)o).m_FixBug;
        }
        static void set_m_FixBug_0(ref object o, object v)
        {
Main _o = (Main)o;
    _o.m_FixBug = (System.Boolean)v;
        }


    }
}
