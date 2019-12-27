
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
    unsafe class PooledClassObject_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::PooledClassObject);
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("New", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, New_0);
            args = new Type[]{};
            method = type.GetMethod("DestroyClass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DestroyClass_1);
            args = new Type[]{};
            method = type.GetMethod("Delete", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Delete_2);
            args = new Type[]{};
            method = type.GetMethod("IsDelete", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsDelete_3);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("SetDelete", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDelete_4);

            field = type.GetField("m_bPoolNew", flag);
            app.RegisterCLRFieldGetter(field, get_m_bPoolNew_0);
            app.RegisterCLRFieldSetter(field, set_m_bPoolNew_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new global::PooledClassObject());
            app.RegisterCLRCreateArrayInstance(type, s => new global::PooledClassObject[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* New_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @param = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::PooledClassObject instance_of_this_method = (global::PooledClassObject)typeof(global::PooledClassObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.New(@param);

            return __ret;
        }

        static StackObject* DestroyClass_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::PooledClassObject instance_of_this_method = (global::PooledClassObject)typeof(global::PooledClassObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DestroyClass();

            return __ret;
        }

        static StackObject* Delete_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::PooledClassObject instance_of_this_method = (global::PooledClassObject)typeof(global::PooledClassObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Delete();

            return __ret;
        }

        static StackObject* IsDelete_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::PooledClassObject instance_of_this_method = (global::PooledClassObject)typeof(global::PooledClassObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsDelete();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetDelete_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @delete = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::PooledClassObject instance_of_this_method = (global::PooledClassObject)typeof(global::PooledClassObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetDelete(@delete);

            return __ret;
        }


        static object get_m_bPoolNew_0(ref object o)
        {
            return ((global::PooledClassObject)o).m_bPoolNew;
        }
        static void set_m_bPoolNew_0(ref object o, object v)
        {
global::PooledClassObject _o = (global::PooledClassObject)o;
    _o.m_bPoolNew = (System.Boolean)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new global::PooledClassObject();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
