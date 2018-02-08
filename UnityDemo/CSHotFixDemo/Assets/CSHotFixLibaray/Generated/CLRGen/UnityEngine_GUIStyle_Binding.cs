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
    unsafe class UnityEngine_GUIStyle_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.GUIStyle);
            args = new Type[]{};
            method = type.GetMethod("get_normal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_normal_0);
            args = new Type[]{typeof(UnityEngine.GUIStyleState)};
            method = type.GetMethod("set_normal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_normal_1);
            args = new Type[]{};
            method = type.GetMethod("get_hover", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hover_2);
            args = new Type[]{typeof(UnityEngine.GUIStyleState)};
            method = type.GetMethod("set_hover", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hover_3);
            args = new Type[]{};
            method = type.GetMethod("get_active", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_active_4);
            args = new Type[]{typeof(UnityEngine.GUIStyleState)};
            method = type.GetMethod("set_active", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_active_5);
            args = new Type[]{};
            method = type.GetMethod("get_onNormal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onNormal_6);
            args = new Type[]{typeof(UnityEngine.GUIStyleState)};
            method = type.GetMethod("set_onNormal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onNormal_7);
            args = new Type[]{};
            method = type.GetMethod("get_onHover", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onHover_8);
            args = new Type[]{typeof(UnityEngine.GUIStyleState)};
            method = type.GetMethod("set_onHover", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onHover_9);
            args = new Type[]{};
            method = type.GetMethod("get_onActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onActive_10);
            args = new Type[]{typeof(UnityEngine.GUIStyleState)};
            method = type.GetMethod("set_onActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onActive_11);
            args = new Type[]{};
            method = type.GetMethod("get_focused", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_focused_12);
            args = new Type[]{typeof(UnityEngine.GUIStyleState)};
            method = type.GetMethod("set_focused", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_focused_13);
            args = new Type[]{};
            method = type.GetMethod("get_onFocused", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onFocused_14);
            args = new Type[]{typeof(UnityEngine.GUIStyleState)};
            method = type.GetMethod("set_onFocused", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_onFocused_15);
            args = new Type[]{};
            method = type.GetMethod("get_border", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_border_16);
            args = new Type[]{typeof(UnityEngine.RectOffset)};
            method = type.GetMethod("set_border", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_border_17);
            args = new Type[]{};
            method = type.GetMethod("get_margin", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_margin_18);
            args = new Type[]{typeof(UnityEngine.RectOffset)};
            method = type.GetMethod("set_margin", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_margin_19);
            args = new Type[]{};
            method = type.GetMethod("get_padding", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_padding_20);
            args = new Type[]{typeof(UnityEngine.RectOffset)};
            method = type.GetMethod("set_padding", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_padding_21);
            args = new Type[]{};
            method = type.GetMethod("get_overflow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_overflow_22);
            args = new Type[]{typeof(UnityEngine.RectOffset)};
            method = type.GetMethod("set_overflow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_overflow_23);
            args = new Type[]{};
            method = type.GetMethod("get_font", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_font_24);
            args = new Type[]{typeof(UnityEngine.Font)};
            method = type.GetMethod("set_font", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_font_25);
            args = new Type[]{};
            method = type.GetMethod("get_lineHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lineHeight_26);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("Draw", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Draw_27);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(System.String), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("Draw", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Draw_28);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("Draw", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Draw_29);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("Draw", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Draw_30);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32)};
            method = type.GetMethod("Draw", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Draw_31);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("Draw", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Draw_32);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("DrawCursor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawCursor_33);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("DrawWithTextSelection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawWithTextSelection_34);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("op_Implicit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, op_Implicit_35);
            args = new Type[]{};
            method = type.GetMethod("get_none", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_none_36);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32)};
            method = type.GetMethod("GetCursorPixelPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCursorPixelPosition_37);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(UnityEngine.Vector2)};
            method = type.GetMethod("GetCursorStringIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCursorStringIndex_38);
            args = new Type[]{typeof(UnityEngine.GUIContent)};
            method = type.GetMethod("CalcSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CalcSize_39);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("CalcScreenSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CalcScreenSize_40);
            args = new Type[]{typeof(UnityEngine.GUIContent), typeof(System.Single)};
            method = type.GetMethod("CalcHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CalcHeight_41);
            args = new Type[]{};
            method = type.GetMethod("get_isHeightDependantOnWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isHeightDependantOnWidth_42);
            args = new Type[]{typeof(UnityEngine.GUIContent), typeof(System.Single).MakeByRefType(), typeof(System.Single).MakeByRefType()};
            method = type.GetMethod("CalcMinMaxWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CalcMinMaxWidth_43);
            args = new Type[]{};
            method = type.GetMethod("ToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToString_44);
            args = new Type[]{};
            method = type.GetMethod("get_name", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_name_45);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_name", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_name_46);
            args = new Type[]{};
            method = type.GetMethod("get_imagePosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_imagePosition_47);
            args = new Type[]{typeof(UnityEngine.ImagePosition)};
            method = type.GetMethod("set_imagePosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_imagePosition_48);
            args = new Type[]{};
            method = type.GetMethod("get_alignment", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_alignment_49);
            args = new Type[]{typeof(UnityEngine.TextAnchor)};
            method = type.GetMethod("set_alignment", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_alignment_50);
            args = new Type[]{};
            method = type.GetMethod("get_wordWrap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_wordWrap_51);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_wordWrap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_wordWrap_52);
            args = new Type[]{};
            method = type.GetMethod("get_clipping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_clipping_53);
            args = new Type[]{typeof(UnityEngine.TextClipping)};
            method = type.GetMethod("set_clipping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_clipping_54);
            args = new Type[]{};
            method = type.GetMethod("get_contentOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_contentOffset_55);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("set_contentOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_contentOffset_56);
            args = new Type[]{};
            method = type.GetMethod("get_fixedWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_fixedWidth_57);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_fixedWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_fixedWidth_58);
            args = new Type[]{};
            method = type.GetMethod("get_fixedHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_fixedHeight_59);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_fixedHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_fixedHeight_60);
            args = new Type[]{};
            method = type.GetMethod("get_stretchWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_stretchWidth_61);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_stretchWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_stretchWidth_62);
            args = new Type[]{};
            method = type.GetMethod("get_stretchHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_stretchHeight_63);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_stretchHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_stretchHeight_64);
            args = new Type[]{};
            method = type.GetMethod("get_fontSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_fontSize_65);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_fontSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_fontSize_66);
            args = new Type[]{};
            method = type.GetMethod("get_fontStyle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_fontStyle_67);
            args = new Type[]{typeof(UnityEngine.FontStyle)};
            method = type.GetMethod("set_fontStyle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_fontStyle_68);
            args = new Type[]{};
            method = type.GetMethod("get_richText", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_richText_69);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_richText", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_richText_70);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.GUIStyle());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.GUIStyle[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);

        }


        static StackObject* get_normal_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.normal;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_normal_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyleState value = (UnityEngine.GUIStyleState)typeof(UnityEngine.GUIStyleState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.normal = value;

            return __ret;
        }

        static StackObject* get_hover_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hover;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_hover_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyleState value = (UnityEngine.GUIStyleState)typeof(UnityEngine.GUIStyleState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hover = value;

            return __ret;
        }

        static StackObject* get_active_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.active;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_active_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyleState value = (UnityEngine.GUIStyleState)typeof(UnityEngine.GUIStyleState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.active = value;

            return __ret;
        }

        static StackObject* get_onNormal_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onNormal;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_onNormal_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyleState value = (UnityEngine.GUIStyleState)typeof(UnityEngine.GUIStyleState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onNormal = value;

            return __ret;
        }

        static StackObject* get_onHover_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onHover;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_onHover_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyleState value = (UnityEngine.GUIStyleState)typeof(UnityEngine.GUIStyleState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onHover = value;

            return __ret;
        }

        static StackObject* get_onActive_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onActive;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_onActive_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyleState value = (UnityEngine.GUIStyleState)typeof(UnityEngine.GUIStyleState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onActive = value;

            return __ret;
        }

        static StackObject* get_focused_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.focused;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_focused_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyleState value = (UnityEngine.GUIStyleState)typeof(UnityEngine.GUIStyleState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.focused = value;

            return __ret;
        }

        static StackObject* get_onFocused_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onFocused;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_onFocused_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyleState value = (UnityEngine.GUIStyleState)typeof(UnityEngine.GUIStyleState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.onFocused = value;

            return __ret;
        }

        static StackObject* get_border_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.border;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_border_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectOffset value = (UnityEngine.RectOffset)typeof(UnityEngine.RectOffset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.border = value;

            return __ret;
        }

        static StackObject* get_margin_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.margin;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_margin_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectOffset value = (UnityEngine.RectOffset)typeof(UnityEngine.RectOffset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.margin = value;

            return __ret;
        }

        static StackObject* get_padding_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.padding;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_padding_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectOffset value = (UnityEngine.RectOffset)typeof(UnityEngine.RectOffset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.padding = value;

            return __ret;
        }

        static StackObject* get_overflow_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.overflow;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_overflow_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectOffset value = (UnityEngine.RectOffset)typeof(UnityEngine.RectOffset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.overflow = value;

            return __ret;
        }

        static StackObject* get_font_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.font;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_font_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Font value = (UnityEngine.Font)typeof(UnityEngine.Font).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.font = value;

            return __ret;
        }

        static StackObject* get_lineHeight_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lineHeight;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Draw_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean hasKeyboardFocus = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean on = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean isActive = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean isHover = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rect position = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Draw(position, isHover, isActive, on, hasKeyboardFocus);

            return __ret;
        }

        static StackObject* Draw_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean hasKeyboardFocus = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean on = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean isActive = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean isHover = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.String text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rect position = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Draw(position, text, isHover, isActive, on, hasKeyboardFocus);

            return __ret;
        }

        static StackObject* Draw_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean hasKeyboardFocus = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean on = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean isActive = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean isHover = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Texture image = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rect position = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Draw(position, image, isHover, isActive, on, hasKeyboardFocus);

            return __ret;
        }

        static StackObject* Draw_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean hasKeyboardFocus = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean on = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean isActive = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean isHover = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.GUIContent content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rect position = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Draw(position, content, isHover, isActive, on, hasKeyboardFocus);

            return __ret;
        }

        static StackObject* Draw_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 controlID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIContent content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rect position = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Draw(position, content, controlID);

            return __ret;
        }

        static StackObject* Draw_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean on = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 controlID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIContent content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rect position = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Draw(position, content, controlID, on);

            return __ret;
        }

        static StackObject* DrawCursor_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 Character = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 controlID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIContent content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rect position = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawCursor(position, content, controlID, Character);

            return __ret;
        }

        static StackObject* DrawWithTextSelection_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 lastSelectedCharacter = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 firstSelectedCharacter = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 controlID = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.GUIContent content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rect position = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawWithTextSelection(position, content, controlID, firstSelectedCharacter, lastSelectedCharacter);

            return __ret;
        }

        static StackObject* op_Implicit_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String str = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = (UnityEngine.GUIStyle)str;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_none_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.GUIStyle.none;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetCursorPixelPosition_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 cursorStringIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIContent content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rect position = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCursorPixelPosition(position, content, cursorStringIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetCursorStringIndex_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 cursorPixelPosition = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIContent content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rect position = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCursorStringIndex(position, content, cursorPixelPosition);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CalcSize_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIContent content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CalcSize(content);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CalcScreenSize_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 contentSize = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CalcScreenSize(contentSize);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CalcHeight_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single width = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIContent content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CalcHeight(content, width);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_isHeightDependantOnWidth_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isHeightDependantOnWidth;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CalcMinMaxWidth_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Single maxWidth = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Single minWidth = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIContent content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CalcMinMaxWidth(content, out minWidth, out maxWidth);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        ___dst->ObjectType = ObjectTypes.Float;
                        *(float*)&___dst->Value = maxWidth;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = maxWidth;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, maxWidth);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = maxWidth;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, maxWidth);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Single[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = maxWidth;
                    }
                    break;
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        ___dst->ObjectType = ObjectTypes.Float;
                        *(float*)&___dst->Value = minWidth;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = minWidth;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, minWidth);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = minWidth;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, minWidth);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Single[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = minWidth;
                    }
                    break;
            }

            return __ret;
        }

        static StackObject* ToString_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ToString();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_name_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.name;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_name_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.name = value;

            return __ret;
        }

        static StackObject* get_imagePosition_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.imagePosition;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_imagePosition_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ImagePosition value = (UnityEngine.ImagePosition)typeof(UnityEngine.ImagePosition).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.imagePosition = value;

            return __ret;
        }

        static StackObject* get_alignment_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.alignment;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_alignment_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextAnchor value = (UnityEngine.TextAnchor)typeof(UnityEngine.TextAnchor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.alignment = value;

            return __ret;
        }

        static StackObject* get_wordWrap_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.wordWrap;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_wordWrap_52(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.wordWrap = value;

            return __ret;
        }

        static StackObject* get_clipping_53(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.clipping;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_clipping_54(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextClipping value = (UnityEngine.TextClipping)typeof(UnityEngine.TextClipping).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.clipping = value;

            return __ret;
        }

        static StackObject* get_contentOffset_55(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.contentOffset;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_contentOffset_56(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 value = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.contentOffset = value;

            return __ret;
        }

        static StackObject* get_fixedWidth_57(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.fixedWidth;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_fixedWidth_58(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.fixedWidth = value;

            return __ret;
        }

        static StackObject* get_fixedHeight_59(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.fixedHeight;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_fixedHeight_60(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.fixedHeight = value;

            return __ret;
        }

        static StackObject* get_stretchWidth_61(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.stretchWidth;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_stretchWidth_62(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.stretchWidth = value;

            return __ret;
        }

        static StackObject* get_stretchHeight_63(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.stretchHeight;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_stretchHeight_64(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.stretchHeight = value;

            return __ret;
        }

        static StackObject* get_fontSize_65(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.fontSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_fontSize_66(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.fontSize = value;

            return __ret;
        }

        static StackObject* get_fontStyle_67(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.fontStyle;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_fontStyle_68(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.FontStyle value = (UnityEngine.FontStyle)typeof(UnityEngine.FontStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.fontStyle = value;

            return __ret;
        }

        static StackObject* get_richText_69(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.richText;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_richText_70(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle instance_of_this_method;
            instance_of_this_method = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.richText = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.GUIStyle();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle other = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new UnityEngine.GUIStyle(other);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
