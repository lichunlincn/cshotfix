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
    unsafe class UnityEngine_CrashReportHandler_CrashReportHandler_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.CrashReportHandler.CrashReportHandler);
            args = new Type[]{};
            method = type.GetMethod("get_enableCaptureExceptions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_enableCaptureExceptions_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_enableCaptureExceptions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_enableCaptureExceptions_1);





        }


        static StackObject* get_enableCaptureExceptions_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.CrashReportHandler.CrashReportHandler.enableCaptureExceptions;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_enableCaptureExceptions_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;

            UnityEngine.CrashReportHandler.CrashReportHandler.enableCaptureExceptions = value;

            return __ret;
        }





    }
}
