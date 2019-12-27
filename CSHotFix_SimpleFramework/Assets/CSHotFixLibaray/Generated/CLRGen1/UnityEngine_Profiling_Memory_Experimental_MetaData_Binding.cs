
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
    unsafe class UnityEngine_Profiling_Memory_Experimental_MetaData_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Profiling.Memory.Experimental.MetaData);

            field = type.GetField("content", flag);
            app.RegisterCLRFieldGetter(field, get_content_0);
            app.RegisterCLRFieldSetter(field, set_content_0);
            field = type.GetField("platform", flag);
            app.RegisterCLRFieldGetter(field, get_platform_1);
            app.RegisterCLRFieldSetter(field, set_platform_1);
            field = type.GetField("screenshot", flag);
            app.RegisterCLRFieldGetter(field, get_screenshot_2);
            app.RegisterCLRFieldSetter(field, set_screenshot_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Profiling.Memory.Experimental.MetaData());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Profiling.Memory.Experimental.MetaData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_content_0(ref object o)
        {
            return ((UnityEngine.Profiling.Memory.Experimental.MetaData)o).content;
        }
        static void set_content_0(ref object o, object v)
        {
UnityEngine.Profiling.Memory.Experimental.MetaData _o = (UnityEngine.Profiling.Memory.Experimental.MetaData)o;
    _o.content = (System.String)v;
        }
        static object get_platform_1(ref object o)
        {
            return ((UnityEngine.Profiling.Memory.Experimental.MetaData)o).platform;
        }
        static void set_platform_1(ref object o, object v)
        {
UnityEngine.Profiling.Memory.Experimental.MetaData _o = (UnityEngine.Profiling.Memory.Experimental.MetaData)o;
    _o.platform = (System.String)v;
        }
        static object get_screenshot_2(ref object o)
        {
            return ((UnityEngine.Profiling.Memory.Experimental.MetaData)o).screenshot;
        }
        static void set_screenshot_2(ref object o, object v)
        {
UnityEngine.Profiling.Memory.Experimental.MetaData _o = (UnityEngine.Profiling.Memory.Experimental.MetaData)o;
    _o.screenshot = (UnityEngine.Texture2D)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Profiling.Memory.Experimental.MetaData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
