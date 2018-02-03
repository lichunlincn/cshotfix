using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class LCLFieldDelegateName_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(LCLFieldDelegateName);

            field = type.GetField("__LCL_MainTest__Test2_Int32_Single__Delegate", flag);
            app.RegisterCLRFieldGetter(field, get___LCL_MainTest__Test2_Int32_Single__Delegate_0);
            app.RegisterCLRFieldSetter(field, set___LCL_MainTest__Test2_Int32_Single__Delegate_0);


        }



        static object get___LCL_MainTest__Test2_Int32_Single__Delegate_0(ref object o)
        {
            return LCLFieldDelegateName.__LCL_MainTest__Test2_Int32_Single__Delegate;
        }
        static void set___LCL_MainTest__Test2_Int32_Single__Delegate_0(ref object o, object v)
        {
            LCLFieldDelegateName.__LCL_MainTest__Test2_Int32_Single__Delegate = (LCLFunctionDelegate.method_delegate2)v;
        }


    }
}
