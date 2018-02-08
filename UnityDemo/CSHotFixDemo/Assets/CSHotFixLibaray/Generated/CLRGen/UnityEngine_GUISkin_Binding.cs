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
    unsafe class UnityEngine_GUISkin_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.GUISkin);
            args = new Type[]{};
            method = type.GetMethod("get_font", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_font_0);
            args = new Type[]{typeof(UnityEngine.Font)};
            method = type.GetMethod("set_font", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_font_1);
            args = new Type[]{};
            method = type.GetMethod("get_box", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_box_2);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("set_box", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_box_3);
            args = new Type[]{};
            method = type.GetMethod("get_label", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_label_4);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("set_label", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_label_5);
            args = new Type[]{};
            method = type.GetMethod("get_textField", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_textField_6);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("set_textField", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_textField_7);
            args = new Type[]{};
            method = type.GetMethod("get_textArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_textArea_8);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("set_textArea", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_textArea_9);
            args = new Type[]{};
            method = type.GetMethod("get_button", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_button_10);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("set_button", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_button_11);
            args = new Type[]{};
            method = type.GetMethod("get_toggle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_toggle_12);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("set_toggle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_toggle_13);
            args = new Type[]{};
            method = type.GetMethod("get_window", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_window_14);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("set_window", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_window_15);
            args = new Type[]{};
            method = type.GetMethod("get_horizontalSlider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_horizontalSlider_16);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("set_horizontalSlider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_horizontalSlider_17);
            args = new Type[]{};
            method = type.GetMethod("get_horizontalSliderThumb", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_horizontalSliderThumb_18);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("set_horizontalSliderThumb", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_horizontalSliderThumb_19);
            args = new Type[]{};
            method = type.GetMethod("get_verticalSlider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_verticalSlider_20);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("set_verticalSlider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_verticalSlider_21);
            args = new Type[]{};
            method = type.GetMethod("get_verticalSliderThumb", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_verticalSliderThumb_22);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("set_verticalSliderThumb", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_verticalSliderThumb_23);
            args = new Type[]{};
            method = type.GetMethod("get_horizontalScrollbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_horizontalScrollbar_24);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("set_horizontalScrollbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_horizontalScrollbar_25);
            args = new Type[]{};
            method = type.GetMethod("get_horizontalScrollbarThumb", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_horizontalScrollbarThumb_26);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("set_horizontalScrollbarThumb", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_horizontalScrollbarThumb_27);
            args = new Type[]{};
            method = type.GetMethod("get_horizontalScrollbarLeftButton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_horizontalScrollbarLeftButton_28);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("set_horizontalScrollbarLeftButton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_horizontalScrollbarLeftButton_29);
            args = new Type[]{};
            method = type.GetMethod("get_horizontalScrollbarRightButton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_horizontalScrollbarRightButton_30);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("set_horizontalScrollbarRightButton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_horizontalScrollbarRightButton_31);
            args = new Type[]{};
            method = type.GetMethod("get_verticalScrollbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_verticalScrollbar_32);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("set_verticalScrollbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_verticalScrollbar_33);
            args = new Type[]{};
            method = type.GetMethod("get_verticalScrollbarThumb", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_verticalScrollbarThumb_34);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("set_verticalScrollbarThumb", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_verticalScrollbarThumb_35);
            args = new Type[]{};
            method = type.GetMethod("get_verticalScrollbarUpButton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_verticalScrollbarUpButton_36);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("set_verticalScrollbarUpButton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_verticalScrollbarUpButton_37);
            args = new Type[]{};
            method = type.GetMethod("get_verticalScrollbarDownButton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_verticalScrollbarDownButton_38);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("set_verticalScrollbarDownButton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_verticalScrollbarDownButton_39);
            args = new Type[]{};
            method = type.GetMethod("get_scrollView", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_scrollView_40);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("set_scrollView", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_scrollView_41);
            args = new Type[]{};
            method = type.GetMethod("get_customStyles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_customStyles_42);
            args = new Type[]{typeof(UnityEngine.GUIStyle[])};
            method = type.GetMethod("set_customStyles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_customStyles_43);
            args = new Type[]{};
            method = type.GetMethod("get_settings", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_settings_44);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetStyle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetStyle_45);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("FindStyle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindStyle_46);
            args = new Type[]{};
            method = type.GetMethod("GetEnumerator", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetEnumerator_47);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.GUISkin());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.GUISkin[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_font_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.font;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_font_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Font value = (UnityEngine.Font)typeof(UnityEngine.Font).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.font = value;

            return __ret;
        }

        static StackObject* get_box_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.box;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_box_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle value = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.box = value;

            return __ret;
        }

        static StackObject* get_label_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.label;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_label_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle value = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.label = value;

            return __ret;
        }

        static StackObject* get_textField_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.textField;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_textField_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle value = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.textField = value;

            return __ret;
        }

        static StackObject* get_textArea_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.textArea;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_textArea_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle value = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.textArea = value;

            return __ret;
        }

        static StackObject* get_button_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.button;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_button_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle value = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.button = value;

            return __ret;
        }

        static StackObject* get_toggle_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.toggle;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_toggle_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle value = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.toggle = value;

            return __ret;
        }

        static StackObject* get_window_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.window;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_window_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle value = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.window = value;

            return __ret;
        }

        static StackObject* get_horizontalSlider_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.horizontalSlider;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_horizontalSlider_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle value = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.horizontalSlider = value;

            return __ret;
        }

        static StackObject* get_horizontalSliderThumb_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.horizontalSliderThumb;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_horizontalSliderThumb_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle value = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.horizontalSliderThumb = value;

            return __ret;
        }

        static StackObject* get_verticalSlider_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.verticalSlider;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_verticalSlider_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle value = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.verticalSlider = value;

            return __ret;
        }

        static StackObject* get_verticalSliderThumb_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.verticalSliderThumb;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_verticalSliderThumb_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle value = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.verticalSliderThumb = value;

            return __ret;
        }

        static StackObject* get_horizontalScrollbar_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.horizontalScrollbar;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_horizontalScrollbar_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle value = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.horizontalScrollbar = value;

            return __ret;
        }

        static StackObject* get_horizontalScrollbarThumb_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.horizontalScrollbarThumb;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_horizontalScrollbarThumb_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle value = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.horizontalScrollbarThumb = value;

            return __ret;
        }

        static StackObject* get_horizontalScrollbarLeftButton_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.horizontalScrollbarLeftButton;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_horizontalScrollbarLeftButton_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle value = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.horizontalScrollbarLeftButton = value;

            return __ret;
        }

        static StackObject* get_horizontalScrollbarRightButton_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.horizontalScrollbarRightButton;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_horizontalScrollbarRightButton_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle value = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.horizontalScrollbarRightButton = value;

            return __ret;
        }

        static StackObject* get_verticalScrollbar_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.verticalScrollbar;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_verticalScrollbar_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle value = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.verticalScrollbar = value;

            return __ret;
        }

        static StackObject* get_verticalScrollbarThumb_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.verticalScrollbarThumb;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_verticalScrollbarThumb_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle value = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.verticalScrollbarThumb = value;

            return __ret;
        }

        static StackObject* get_verticalScrollbarUpButton_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.verticalScrollbarUpButton;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_verticalScrollbarUpButton_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle value = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.verticalScrollbarUpButton = value;

            return __ret;
        }

        static StackObject* get_verticalScrollbarDownButton_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.verticalScrollbarDownButton;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_verticalScrollbarDownButton_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle value = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.verticalScrollbarDownButton = value;

            return __ret;
        }

        static StackObject* get_scrollView_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.scrollView;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_scrollView_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle value = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.scrollView = value;

            return __ret;
        }

        static StackObject* get_customStyles_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.customStyles;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_customStyles_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle[] value = (UnityEngine.GUIStyle[])typeof(UnityEngine.GUIStyle[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.customStyles = value;

            return __ret;
        }

        static StackObject* get_settings_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.settings;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetStyle_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String styleName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetStyle(styleName);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* FindStyle_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String styleName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindStyle(styleName);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetEnumerator_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUISkin instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetEnumerator();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.GUISkin();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
