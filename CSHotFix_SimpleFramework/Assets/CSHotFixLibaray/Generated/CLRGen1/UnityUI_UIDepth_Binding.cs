
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
    unsafe class UnityUI_UIDepth_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityUI.UIDepth);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("SetOrder", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetOrder_0);

            field = type.GetField("RenderType", flag);
            app.RegisterCLRFieldGetter(field, get_RenderType_0);
            app.RegisterCLRFieldSetter(field, set_RenderType_0);
            field = type.GetField("Order", flag);
            app.RegisterCLRFieldGetter(field, get_Order_1);
            app.RegisterCLRFieldSetter(field, set_Order_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityUI.UIDepth());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityUI.UIDepth[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* SetOrder_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @order = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityUI.UIDepth instance_of_this_method = (UnityUI.UIDepth)typeof(UnityUI.UIDepth).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetOrder(@order);

            return __ret;
        }


        static object get_RenderType_0(ref object o)
        {
            return ((UnityUI.UIDepth)o).RenderType;
        }
        static void set_RenderType_0(ref object o, object v)
        {
UnityUI.UIDepth _o = (UnityUI.UIDepth)o;
    _o.RenderType = (UnityUI.UIRenderType)v;
        }
        static object get_Order_1(ref object o)
        {
            return ((UnityUI.UIDepth)o).Order;
        }
        static void set_Order_1(ref object o, object v)
        {
UnityUI.UIDepth _o = (UnityUI.UIDepth)o;
    _o.Order = (System.Int32)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityUI.UIDepth();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
