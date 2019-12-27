
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
    unsafe class UnityEngine_CrashReport_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.CrashReport);
            args = new Type[]{};
            method = type.GetMethod("get_reports", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_reports_0);
            args = new Type[]{};
            method = type.GetMethod("get_lastReport", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lastReport_1);
            args = new Type[]{};
            method = type.GetMethod("RemoveAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveAll_2);
            args = new Type[]{};
            method = type.GetMethod("Remove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Remove_3);

            field = type.GetField("time", flag);
            app.RegisterCLRFieldGetter(field, get_time_0);
            field = type.GetField("text", flag);
            app.RegisterCLRFieldGetter(field, get_text_1);


            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.CrashReport[s]);


        }


        static StackObject* get_reports_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.CrashReport.reports;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_lastReport_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.CrashReport.lastReport;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RemoveAll_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.CrashReport.RemoveAll();

            return __ret;
        }

        static StackObject* Remove_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CrashReport instance_of_this_method = (UnityEngine.CrashReport)typeof(UnityEngine.CrashReport).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Remove();

            return __ret;
        }


        static object get_time_0(ref object o)
        {
            return ((UnityEngine.CrashReport)o).time;
        }
        static object get_text_1(ref object o)
        {
            return ((UnityEngine.CrashReport)o).text;
        }



    }
}
#endif
