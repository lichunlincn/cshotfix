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
    unsafe class UnityEngine_Experimental_Director_Playable_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Experimental.Director.Playable);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.Playable)};
            method = type.GetMethod("op_Implicit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, op_Implicit_0);
            args = new Type[]{};
            method = type.GetMethod("IsValid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsValid_1);

            field = type.GetField("handle", flag);
            app.RegisterCLRFieldGetter(field, get_handle_0);
            app.RegisterCLRFieldSetter(field, set_handle_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Experimental.Director.Playable());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Experimental.Director.Playable[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* op_Implicit_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.Playable b = (UnityEngine.Experimental.Director.Playable)typeof(UnityEngine.Experimental.Director.Playable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)b;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* IsValid_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.Playable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.Playable)typeof(UnityEngine.Experimental.Director.Playable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsValid();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static object get_handle_0(ref object o)
        {
            return ((UnityEngine.Experimental.Director.Playable)o).handle;
        }
        static void set_handle_0(ref object o, object v)
        {
UnityEngine.Experimental.Director.Playable _o = (UnityEngine.Experimental.Director.Playable)o;
    _o.handle = (UnityEngine.Experimental.Director.PlayableHandle)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Experimental.Director.Playable();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
