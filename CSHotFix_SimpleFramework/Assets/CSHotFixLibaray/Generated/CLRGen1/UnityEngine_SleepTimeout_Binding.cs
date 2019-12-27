
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
    unsafe class UnityEngine_SleepTimeout_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.SleepTimeout);

            field = type.GetField("NeverSleep", flag);
            app.RegisterCLRFieldGetter(field, get_NeverSleep_0);
            field = type.GetField("SystemSetting", flag);
            app.RegisterCLRFieldGetter(field, get_SystemSetting_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.SleepTimeout());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.SleepTimeout[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_NeverSleep_0(ref object o)
        {
            return UnityEngine.SleepTimeout.NeverSleep;
        }
        static object get_SystemSetting_1(ref object o)
        {
            return UnityEngine.SleepTimeout.SystemSetting;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.SleepTimeout();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
