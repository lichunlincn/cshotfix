
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
    unsafe class LCL_PrefabCenter_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(LCL.PrefabCenter);

            field = type.GetField("m_Center3D", flag);
            app.RegisterCLRFieldGetter(field, get_m_Center3D_0);
            app.RegisterCLRFieldSetter(field, set_m_Center3D_0);
            field = type.GetField("m_Center2D", flag);
            app.RegisterCLRFieldGetter(field, get_m_Center2D_1);
            app.RegisterCLRFieldSetter(field, set_m_Center2D_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new LCL.PrefabCenter());
            app.RegisterCLRCreateArrayInstance(type, s => new LCL.PrefabCenter[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_m_Center3D_0(ref object o)
        {
            return ((LCL.PrefabCenter)o).m_Center3D;
        }
        static void set_m_Center3D_0(ref object o, object v)
        {
LCL.PrefabCenter _o = (LCL.PrefabCenter)o;
    _o.m_Center3D = (UnityEngine.Transform)v;
        }
        static object get_m_Center2D_1(ref object o)
        {
            return ((LCL.PrefabCenter)o).m_Center2D;
        }
        static void set_m_Center2D_1(ref object o, object v)
        {
LCL.PrefabCenter _o = (LCL.PrefabCenter)o;
    _o.m_Center2D = (UnityEngine.Transform)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new LCL.PrefabCenter();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
