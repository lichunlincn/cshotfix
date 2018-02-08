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
    unsafe class UnityEngine_AndroidInput_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.AndroidInput);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetSecondaryTouch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSecondaryTouch_0);
            args = new Type[]{};
            method = type.GetMethod("get_touchCountSecondary", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_touchCountSecondary_1);
            args = new Type[]{};
            method = type.GetMethod("get_secondaryTouchEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_secondaryTouchEnabled_2);
            args = new Type[]{};
            method = type.GetMethod("get_secondaryTouchWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_secondaryTouchWidth_3);
            args = new Type[]{};
            method = type.GetMethod("get_secondaryTouchHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_secondaryTouchHeight_4);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AndroidInput[s]);


        }


        static StackObject* GetSecondaryTouch_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.AndroidInput.GetSecondaryTouch(index);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_touchCountSecondary_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.AndroidInput.touchCountSecondary;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_secondaryTouchEnabled_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.AndroidInput.secondaryTouchEnabled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_secondaryTouchWidth_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.AndroidInput.secondaryTouchWidth;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_secondaryTouchHeight_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.AndroidInput.secondaryTouchHeight;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }





    }
}
