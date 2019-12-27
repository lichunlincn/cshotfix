
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
    unsafe class UnityUI_UIGray_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityUI.UIGray);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_Gray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Gray_0);
            args = new Type[]{};
            method = type.GetMethod("get_Gray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Gray_1);

            field = type.GetField("m_Graphics", flag);
            app.RegisterCLRFieldGetter(field, get_m_Graphics_0);
            app.RegisterCLRFieldSetter(field, set_m_Graphics_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityUI.UIGray());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityUI.UIGray[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* set_Gray_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityUI.UIGray instance_of_this_method = (UnityUI.UIGray)typeof(UnityUI.UIGray).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Gray = value;

            return __ret;
        }

        static StackObject* get_Gray_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityUI.UIGray instance_of_this_method = (UnityUI.UIGray)typeof(UnityUI.UIGray).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Gray;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static object get_m_Graphics_0(ref object o)
        {
            return ((UnityUI.UIGray)o).m_Graphics;
        }
        static void set_m_Graphics_0(ref object o, object v)
        {
UnityUI.UIGray _o = (UnityUI.UIGray)o;
    _o.m_Graphics = (UnityEngine.UI.Graphic)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityUI.UIGray();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
