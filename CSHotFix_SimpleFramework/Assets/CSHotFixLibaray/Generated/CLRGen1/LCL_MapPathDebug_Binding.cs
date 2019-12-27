
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
    unsafe class LCL_MapPathDebug_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(LCL.MapPathDebug);

            field = type.GetField("m_Material", flag);
            app.RegisterCLRFieldGetter(field, get_m_Material_0);
            app.RegisterCLRFieldSetter(field, set_m_Material_0);
            field = type.GetField("m_GridFilePath", flag);
            app.RegisterCLRFieldGetter(field, get_m_GridFilePath_1);
            app.RegisterCLRFieldSetter(field, set_m_GridFilePath_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new LCL.MapPathDebug());
            app.RegisterCLRCreateArrayInstance(type, s => new LCL.MapPathDebug[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_m_Material_0(ref object o)
        {
            return ((LCL.MapPathDebug)o).m_Material;
        }
        static void set_m_Material_0(ref object o, object v)
        {
LCL.MapPathDebug _o = (LCL.MapPathDebug)o;
    _o.m_Material = (UnityEngine.Material)v;
        }
        static object get_m_GridFilePath_1(ref object o)
        {
            return ((LCL.MapPathDebug)o).m_GridFilePath;
        }
        static void set_m_GridFilePath_1(ref object o, object v)
        {
LCL.MapPathDebug _o = (LCL.MapPathDebug)o;
    _o.m_GridFilePath = (System.String)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new LCL.MapPathDebug();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
