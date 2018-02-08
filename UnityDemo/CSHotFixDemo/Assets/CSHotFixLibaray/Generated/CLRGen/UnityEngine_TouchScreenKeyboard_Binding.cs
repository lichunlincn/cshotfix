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
    unsafe class UnityEngine_TouchScreenKeyboard_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.TouchScreenKeyboard);
            args = new Type[]{};
            method = type.GetMethod("get_isSupported", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isSupported_0);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.TouchScreenKeyboardType), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("Open", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Open_1);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.TouchScreenKeyboardType), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("Open", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Open_2);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.TouchScreenKeyboardType), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("Open", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Open_3);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.TouchScreenKeyboardType), typeof(System.Boolean)};
            method = type.GetMethod("Open", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Open_4);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.TouchScreenKeyboardType)};
            method = type.GetMethod("Open", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Open_5);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("Open", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Open_6);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.TouchScreenKeyboardType), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.String)};
            method = type.GetMethod("Open", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Open_7);
            args = new Type[]{};
            method = type.GetMethod("get_text", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_text_8);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_text", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_text_9);
            args = new Type[]{};
            method = type.GetMethod("get_hideInput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hideInput_10);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_hideInput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hideInput_11);
            args = new Type[]{};
            method = type.GetMethod("get_active", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_active_12);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_active", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_active_13);
            args = new Type[]{};
            method = type.GetMethod("get_done", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_done_14);
            args = new Type[]{};
            method = type.GetMethod("get_wasCanceled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_wasCanceled_15);
            args = new Type[]{};
            method = type.GetMethod("get_canGetSelection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_canGetSelection_16);
            args = new Type[]{};
            method = type.GetMethod("get_selection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_selection_17);
            args = new Type[]{};
            method = type.GetMethod("get_targetDisplay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_targetDisplay_18);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_targetDisplay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_targetDisplay_19);
            args = new Type[]{};
            method = type.GetMethod("get_area", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_area_20);
            args = new Type[]{};
            method = type.GetMethod("get_visible", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_visible_21);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.TouchScreenKeyboard[s]);

            args = new Type[]{typeof(System.String), typeof(UnityEngine.TouchScreenKeyboardType), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.String)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_isSupported_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.TouchScreenKeyboard.isSupported;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Open_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean alert = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean secure = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean multiline = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean autocorrection = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.TouchScreenKeyboardType keyboardType = (UnityEngine.TouchScreenKeyboardType)typeof(UnityEngine.TouchScreenKeyboardType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.String text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Open_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean secure = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean multiline = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean autocorrection = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.TouchScreenKeyboardType keyboardType = (UnityEngine.TouchScreenKeyboardType)typeof(UnityEngine.TouchScreenKeyboardType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.String text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Open_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean multiline = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean autocorrection = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.TouchScreenKeyboardType keyboardType = (UnityEngine.TouchScreenKeyboardType)typeof(UnityEngine.TouchScreenKeyboardType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Open_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean autocorrection = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TouchScreenKeyboardType keyboardType = (UnityEngine.TouchScreenKeyboardType)typeof(UnityEngine.TouchScreenKeyboardType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.TouchScreenKeyboard.Open(text, keyboardType, autocorrection);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Open_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TouchScreenKeyboardType keyboardType = (UnityEngine.TouchScreenKeyboardType)typeof(UnityEngine.TouchScreenKeyboardType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.TouchScreenKeyboard.Open(text, keyboardType);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Open_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.TouchScreenKeyboard.Open(text);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Open_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String textPlaceholder = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean alert = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean secure = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean multiline = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Boolean autocorrection = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.TouchScreenKeyboardType keyboardType = (UnityEngine.TouchScreenKeyboardType)typeof(UnityEngine.TouchScreenKeyboardType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.String text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_text_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TouchScreenKeyboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.TouchScreenKeyboard)typeof(UnityEngine.TouchScreenKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.text;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_text_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TouchScreenKeyboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.TouchScreenKeyboard)typeof(UnityEngine.TouchScreenKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.text = value;

            return __ret;
        }

        static StackObject* get_hideInput_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.TouchScreenKeyboard.hideInput;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_hideInput_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;

            UnityEngine.TouchScreenKeyboard.hideInput = value;

            return __ret;
        }

        static StackObject* get_active_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TouchScreenKeyboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.TouchScreenKeyboard)typeof(UnityEngine.TouchScreenKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.active;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_active_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TouchScreenKeyboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.TouchScreenKeyboard)typeof(UnityEngine.TouchScreenKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.active = value;

            return __ret;
        }

        static StackObject* get_done_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TouchScreenKeyboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.TouchScreenKeyboard)typeof(UnityEngine.TouchScreenKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.done;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_wasCanceled_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TouchScreenKeyboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.TouchScreenKeyboard)typeof(UnityEngine.TouchScreenKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.wasCanceled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_canGetSelection_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TouchScreenKeyboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.TouchScreenKeyboard)typeof(UnityEngine.TouchScreenKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.canGetSelection;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_selection_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TouchScreenKeyboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.TouchScreenKeyboard)typeof(UnityEngine.TouchScreenKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.selection;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_targetDisplay_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TouchScreenKeyboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.TouchScreenKeyboard)typeof(UnityEngine.TouchScreenKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.targetDisplay;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_targetDisplay_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TouchScreenKeyboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.TouchScreenKeyboard)typeof(UnityEngine.TouchScreenKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.targetDisplay = value;

            return __ret;
        }

        static StackObject* get_area_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.TouchScreenKeyboard.area;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_visible_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.TouchScreenKeyboard.visible;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String textPlaceholder = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean alert = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean secure = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean multiline = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Boolean autocorrection = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.TouchScreenKeyboardType keyboardType = (UnityEngine.TouchScreenKeyboardType)typeof(UnityEngine.TouchScreenKeyboardType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.String text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new UnityEngine.TouchScreenKeyboard(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
