
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

namespace CSHotFix.Runtime.Generated
{
    unsafe class Setting_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Setting);

            field = type.GetField("UseLocalServer", flag);
            app.RegisterCLRFieldGetter(field, get_UseLocalServer_0);
            app.RegisterCLRFieldSetter(field, set_UseLocalServer_0);
            field = type.GetField("SingleServer", flag);
            app.RegisterCLRFieldGetter(field, get_SingleServer_1);
            app.RegisterCLRFieldSetter(field, set_SingleServer_1);
            field = type.GetField("JumpLogin", flag);
            app.RegisterCLRFieldGetter(field, get_JumpLogin_2);
            app.RegisterCLRFieldSetter(field, set_JumpLogin_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new Setting());
            app.RegisterCLRCreateArrayInstance(type, s => new Setting[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_UseLocalServer_0(ref object o)
        {
            return ((Setting)o).UseLocalServer;
        }
        static void set_UseLocalServer_0(ref object o, object v)
        {
Setting _o = (Setting)o;
    _o.UseLocalServer = (System.Boolean)v;
        }
        static object get_SingleServer_1(ref object o)
        {
            return ((Setting)o).SingleServer;
        }
        static void set_SingleServer_1(ref object o, object v)
        {
Setting _o = (Setting)o;
    _o.SingleServer = (System.Boolean)v;
        }
        static object get_JumpLogin_2(ref object o)
        {
            return ((Setting)o).JumpLogin;
        }
        static void set_JumpLogin_2(ref object o, object v)
        {
Setting _o = (Setting)o;
    _o.JumpLogin = (System.Boolean)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Setting();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
