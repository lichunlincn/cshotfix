
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
    unsafe class Unity_Collections_NativeFixedLengthAttribute_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Collections.NativeFixedLengthAttribute);

            field = type.GetField("FixedLength", flag);
            app.RegisterCLRFieldGetter(field, get_FixedLength_0);
            app.RegisterCLRFieldSetter(field, set_FixedLength_0);


            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Collections.NativeFixedLengthAttribute[s]);

            args = new Type[]{typeof(System.Int32)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_FixedLength_0(ref object o)
        {
            return ((Unity.Collections.NativeFixedLengthAttribute)o).FixedLength;
        }
        static void set_FixedLength_0(ref object o, object v)
        {
Unity.Collections.NativeFixedLengthAttribute _o = (Unity.Collections.NativeFixedLengthAttribute)o;
    _o.FixedLength = (System.Int32)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @fixedLength = ptr_of_this_method->Value;


            var result_of_this_method = new Unity.Collections.NativeFixedLengthAttribute(@fixedLength);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
