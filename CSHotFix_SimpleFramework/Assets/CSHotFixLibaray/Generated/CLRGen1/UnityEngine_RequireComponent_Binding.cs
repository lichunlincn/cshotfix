
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
    unsafe class UnityEngine_RequireComponent_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.RequireComponent);

            field = type.GetField("m_Type0", flag);
            app.RegisterCLRFieldGetter(field, get_m_Type0_0);
            app.RegisterCLRFieldSetter(field, set_m_Type0_0);
            field = type.GetField("m_Type1", flag);
            app.RegisterCLRFieldGetter(field, get_m_Type1_1);
            app.RegisterCLRFieldSetter(field, set_m_Type1_1);
            field = type.GetField("m_Type2", flag);
            app.RegisterCLRFieldGetter(field, get_m_Type2_2);
            app.RegisterCLRFieldSetter(field, set_m_Type2_2);


            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.RequireComponent[s]);

            args = new Type[]{typeof(System.Type)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(System.Type), typeof(System.Type)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);
            args = new Type[]{typeof(System.Type), typeof(System.Type), typeof(System.Type)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_2);

        }



        static object get_m_Type0_0(ref object o)
        {
            return ((UnityEngine.RequireComponent)o).m_Type0;
        }
        static void set_m_Type0_0(ref object o, object v)
        {
UnityEngine.RequireComponent _o = (UnityEngine.RequireComponent)o;
    _o.m_Type0 = (System.Type)v;
        }
        static object get_m_Type1_1(ref object o)
        {
            return ((UnityEngine.RequireComponent)o).m_Type1;
        }
        static void set_m_Type1_1(ref object o, object v)
        {
UnityEngine.RequireComponent _o = (UnityEngine.RequireComponent)o;
    _o.m_Type1 = (System.Type)v;
        }
        static object get_m_Type2_2(ref object o)
        {
            return ((UnityEngine.RequireComponent)o).m_Type2;
        }
        static void set_m_Type2_2(ref object o, object v)
        {
UnityEngine.RequireComponent _o = (UnityEngine.RequireComponent)o;
    _o.m_Type2 = (System.Type)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @requiredComponent = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new UnityEngine.RequireComponent(@requiredComponent);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @requiredComponent2 = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Type @requiredComponent = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new UnityEngine.RequireComponent(@requiredComponent, @requiredComponent2);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @requiredComponent3 = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Type @requiredComponent2 = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Type @requiredComponent = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new UnityEngine.RequireComponent(@requiredComponent, @requiredComponent2, @requiredComponent3);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
