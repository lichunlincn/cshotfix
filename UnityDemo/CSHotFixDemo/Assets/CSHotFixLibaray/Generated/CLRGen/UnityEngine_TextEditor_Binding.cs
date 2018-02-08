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
    unsafe class UnityEngine_TextEditor_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.TextEditor);
            args = new Type[]{};
            method = type.GetMethod("get_text", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_text_0);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_text", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_text_1);
            args = new Type[]{};
            method = type.GetMethod("get_position", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_position_2);
            args = new Type[]{typeof(UnityEngine.Rect)};
            method = type.GetMethod("set_position", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_position_3);
            args = new Type[]{};
            method = type.GetMethod("get_cursorIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cursorIndex_4);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_cursorIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_cursorIndex_5);
            args = new Type[]{};
            method = type.GetMethod("get_selectIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_selectIndex_6);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_selectIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_selectIndex_7);
            args = new Type[]{};
            method = type.GetMethod("OnFocus", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnFocus_8);
            args = new Type[]{};
            method = type.GetMethod("OnLostFocus", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnLostFocus_9);
            args = new Type[]{typeof(UnityEngine.Event)};
            method = type.GetMethod("HandleKeyEvent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HandleKeyEvent_10);
            args = new Type[]{};
            method = type.GetMethod("DeleteLineBack", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DeleteLineBack_11);
            args = new Type[]{};
            method = type.GetMethod("DeleteWordBack", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DeleteWordBack_12);
            args = new Type[]{};
            method = type.GetMethod("DeleteWordForward", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DeleteWordForward_13);
            args = new Type[]{};
            method = type.GetMethod("Delete", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Delete_14);
            args = new Type[]{};
            method = type.GetMethod("CanPaste", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CanPaste_15);
            args = new Type[]{};
            method = type.GetMethod("Backspace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Backspace_16);
            args = new Type[]{};
            method = type.GetMethod("SelectAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectAll_17);
            args = new Type[]{};
            method = type.GetMethod("SelectNone", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectNone_18);
            args = new Type[]{};
            method = type.GetMethod("get_hasSelection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasSelection_19);
            args = new Type[]{};
            method = type.GetMethod("get_SelectedText", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_SelectedText_20);
            args = new Type[]{};
            method = type.GetMethod("DeleteSelection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DeleteSelection_21);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("ReplaceSelection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReplaceSelection_22);
            args = new Type[]{typeof(System.Char)};
            method = type.GetMethod("Insert", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Insert_23);
            args = new Type[]{};
            method = type.GetMethod("MoveSelectionToAltCursor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveSelectionToAltCursor_24);
            args = new Type[]{};
            method = type.GetMethod("MoveRight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveRight_25);
            args = new Type[]{};
            method = type.GetMethod("MoveLeft", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveLeft_26);
            args = new Type[]{};
            method = type.GetMethod("MoveUp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveUp_27);
            args = new Type[]{};
            method = type.GetMethod("MoveDown", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveDown_28);
            args = new Type[]{};
            method = type.GetMethod("MoveLineStart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveLineStart_29);
            args = new Type[]{};
            method = type.GetMethod("MoveLineEnd", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveLineEnd_30);
            args = new Type[]{};
            method = type.GetMethod("MoveGraphicalLineStart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveGraphicalLineStart_31);
            args = new Type[]{};
            method = type.GetMethod("MoveGraphicalLineEnd", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveGraphicalLineEnd_32);
            args = new Type[]{};
            method = type.GetMethod("MoveTextStart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveTextStart_33);
            args = new Type[]{};
            method = type.GetMethod("MoveTextEnd", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveTextEnd_34);
            args = new Type[]{};
            method = type.GetMethod("MoveParagraphForward", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveParagraphForward_35);
            args = new Type[]{};
            method = type.GetMethod("MoveParagraphBackward", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveParagraphBackward_36);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("MoveCursorToPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveCursorToPosition_37);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("MoveAltCursorToPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveAltCursorToPosition_38);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("IsOverSelection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsOverSelection_39);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("SelectToPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectToPosition_40);
            args = new Type[]{};
            method = type.GetMethod("SelectLeft", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectLeft_41);
            args = new Type[]{};
            method = type.GetMethod("SelectRight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectRight_42);
            args = new Type[]{};
            method = type.GetMethod("SelectUp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectUp_43);
            args = new Type[]{};
            method = type.GetMethod("SelectDown", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectDown_44);
            args = new Type[]{};
            method = type.GetMethod("SelectTextEnd", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectTextEnd_45);
            args = new Type[]{};
            method = type.GetMethod("SelectTextStart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectTextStart_46);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("MouseDragSelectsWholeWords", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MouseDragSelectsWholeWords_47);
            args = new Type[]{typeof(UnityEngine.TextEditor.DblClickSnapping)};
            method = type.GetMethod("DblClickSnap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DblClickSnap_48);
            args = new Type[]{};
            method = type.GetMethod("MoveWordRight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveWordRight_49);
            args = new Type[]{};
            method = type.GetMethod("MoveToStartOfNextWord", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveToStartOfNextWord_50);
            args = new Type[]{};
            method = type.GetMethod("MoveToEndOfPreviousWord", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveToEndOfPreviousWord_51);
            args = new Type[]{};
            method = type.GetMethod("SelectToStartOfNextWord", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectToStartOfNextWord_52);
            args = new Type[]{};
            method = type.GetMethod("SelectToEndOfPreviousWord", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectToEndOfPreviousWord_53);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("FindStartOfNextWord", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindStartOfNextWord_54);
            args = new Type[]{};
            method = type.GetMethod("MoveWordLeft", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveWordLeft_55);
            args = new Type[]{};
            method = type.GetMethod("SelectWordRight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectWordRight_56);
            args = new Type[]{};
            method = type.GetMethod("SelectWordLeft", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectWordLeft_57);
            args = new Type[]{};
            method = type.GetMethod("ExpandSelectGraphicalLineStart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ExpandSelectGraphicalLineStart_58);
            args = new Type[]{};
            method = type.GetMethod("ExpandSelectGraphicalLineEnd", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ExpandSelectGraphicalLineEnd_59);
            args = new Type[]{};
            method = type.GetMethod("SelectGraphicalLineStart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectGraphicalLineStart_60);
            args = new Type[]{};
            method = type.GetMethod("SelectGraphicalLineEnd", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectGraphicalLineEnd_61);
            args = new Type[]{};
            method = type.GetMethod("SelectParagraphForward", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectParagraphForward_62);
            args = new Type[]{};
            method = type.GetMethod("SelectParagraphBackward", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectParagraphBackward_63);
            args = new Type[]{};
            method = type.GetMethod("SelectCurrentWord", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectCurrentWord_64);
            args = new Type[]{};
            method = type.GetMethod("SelectCurrentParagraph", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SelectCurrentParagraph_65);
            args = new Type[]{typeof(UnityEngine.Event)};
            method = type.GetMethod("UpdateScrollOffsetIfNeeded", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UpdateScrollOffsetIfNeeded_66);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("DrawCursor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawCursor_67);
            args = new Type[]{};
            method = type.GetMethod("SaveBackup", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SaveBackup_68);
            args = new Type[]{};
            method = type.GetMethod("Undo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Undo_69);
            args = new Type[]{};
            method = type.GetMethod("Cut", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Cut_70);
            args = new Type[]{};
            method = type.GetMethod("Copy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Copy_71);
            args = new Type[]{};
            method = type.GetMethod("Paste", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Paste_72);
            args = new Type[]{};
            method = type.GetMethod("DetectFocusChange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DetectFocusChange_73);

            field = type.GetField("keyboardOnScreen", flag);
            app.RegisterCLRFieldGetter(field, get_keyboardOnScreen_0);
            app.RegisterCLRFieldSetter(field, set_keyboardOnScreen_0);
            field = type.GetField("controlID", flag);
            app.RegisterCLRFieldGetter(field, get_controlID_1);
            app.RegisterCLRFieldSetter(field, set_controlID_1);
            field = type.GetField("style", flag);
            app.RegisterCLRFieldGetter(field, get_style_2);
            app.RegisterCLRFieldSetter(field, set_style_2);
            field = type.GetField("multiline", flag);
            app.RegisterCLRFieldGetter(field, get_multiline_3);
            app.RegisterCLRFieldSetter(field, set_multiline_3);
            field = type.GetField("hasHorizontalCursorPos", flag);
            app.RegisterCLRFieldGetter(field, get_hasHorizontalCursorPos_4);
            app.RegisterCLRFieldSetter(field, set_hasHorizontalCursorPos_4);
            field = type.GetField("isPasswordField", flag);
            app.RegisterCLRFieldGetter(field, get_isPasswordField_5);
            app.RegisterCLRFieldSetter(field, set_isPasswordField_5);
            field = type.GetField("scrollOffset", flag);
            app.RegisterCLRFieldGetter(field, get_scrollOffset_6);
            app.RegisterCLRFieldSetter(field, set_scrollOffset_6);
            field = type.GetField("graphicalCursorPos", flag);
            app.RegisterCLRFieldGetter(field, get_graphicalCursorPos_7);
            app.RegisterCLRFieldSetter(field, set_graphicalCursorPos_7);
            field = type.GetField("graphicalSelectCursorPos", flag);
            app.RegisterCLRFieldGetter(field, get_graphicalSelectCursorPos_8);
            app.RegisterCLRFieldSetter(field, set_graphicalSelectCursorPos_8);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.TextEditor());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.TextEditor[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_text_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.text;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_text_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.text = value;

            return __ret;
        }

        static StackObject* get_position_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.position;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_position_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rect value = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.position = value;

            return __ret;
        }

        static StackObject* get_cursorIndex_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.cursorIndex;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_cursorIndex_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.cursorIndex = value;

            return __ret;
        }

        static StackObject* get_selectIndex_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.selectIndex;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_selectIndex_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.selectIndex = value;

            return __ret;
        }

        static StackObject* OnFocus_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnFocus();

            return __ret;
        }

        static StackObject* OnLostFocus_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnLostFocus();

            return __ret;
        }

        static StackObject* HandleKeyEvent_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Event e = (UnityEngine.Event)typeof(UnityEngine.Event).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.HandleKeyEvent(e);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* DeleteLineBack_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DeleteLineBack();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* DeleteWordBack_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DeleteWordBack();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* DeleteWordForward_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DeleteWordForward();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Delete_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Delete();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CanPaste_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CanPaste();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Backspace_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Backspace();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SelectAll_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectAll();

            return __ret;
        }

        static StackObject* SelectNone_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectNone();

            return __ret;
        }

        static StackObject* get_hasSelection_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hasSelection;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_SelectedText_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SelectedText;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* DeleteSelection_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DeleteSelection();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* ReplaceSelection_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String replace = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ReplaceSelection(replace);

            return __ret;
        }

        static StackObject* Insert_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Char c = (char)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Insert(c);

            return __ret;
        }

        static StackObject* MoveSelectionToAltCursor_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveSelectionToAltCursor();

            return __ret;
        }

        static StackObject* MoveRight_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveRight();

            return __ret;
        }

        static StackObject* MoveLeft_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveLeft();

            return __ret;
        }

        static StackObject* MoveUp_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveUp();

            return __ret;
        }

        static StackObject* MoveDown_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveDown();

            return __ret;
        }

        static StackObject* MoveLineStart_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveLineStart();

            return __ret;
        }

        static StackObject* MoveLineEnd_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveLineEnd();

            return __ret;
        }

        static StackObject* MoveGraphicalLineStart_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveGraphicalLineStart();

            return __ret;
        }

        static StackObject* MoveGraphicalLineEnd_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveGraphicalLineEnd();

            return __ret;
        }

        static StackObject* MoveTextStart_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveTextStart();

            return __ret;
        }

        static StackObject* MoveTextEnd_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveTextEnd();

            return __ret;
        }

        static StackObject* MoveParagraphForward_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveParagraphForward();

            return __ret;
        }

        static StackObject* MoveParagraphBackward_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveParagraphBackward();

            return __ret;
        }

        static StackObject* MoveCursorToPosition_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 cursorPosition = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveCursorToPosition(cursorPosition);

            return __ret;
        }

        static StackObject* MoveAltCursorToPosition_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 cursorPosition = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveAltCursorToPosition(cursorPosition);

            return __ret;
        }

        static StackObject* IsOverSelection_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 cursorPosition = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsOverSelection(cursorPosition);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SelectToPosition_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 cursorPosition = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectToPosition(cursorPosition);

            return __ret;
        }

        static StackObject* SelectLeft_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectLeft();

            return __ret;
        }

        static StackObject* SelectRight_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectRight();

            return __ret;
        }

        static StackObject* SelectUp_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectUp();

            return __ret;
        }

        static StackObject* SelectDown_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectDown();

            return __ret;
        }

        static StackObject* SelectTextEnd_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectTextEnd();

            return __ret;
        }

        static StackObject* SelectTextStart_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectTextStart();

            return __ret;
        }

        static StackObject* MouseDragSelectsWholeWords_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean on = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MouseDragSelectsWholeWords(on);

            return __ret;
        }

        static StackObject* DblClickSnap_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor.DblClickSnapping snapping = (UnityEngine.TextEditor.DblClickSnapping)typeof(UnityEngine.TextEditor.DblClickSnapping).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DblClickSnap(snapping);

            return __ret;
        }

        static StackObject* MoveWordRight_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveWordRight();

            return __ret;
        }

        static StackObject* MoveToStartOfNextWord_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveToStartOfNextWord();

            return __ret;
        }

        static StackObject* MoveToEndOfPreviousWord_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveToEndOfPreviousWord();

            return __ret;
        }

        static StackObject* SelectToStartOfNextWord_52(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectToStartOfNextWord();

            return __ret;
        }

        static StackObject* SelectToEndOfPreviousWord_53(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectToEndOfPreviousWord();

            return __ret;
        }

        static StackObject* FindStartOfNextWord_54(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 p = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindStartOfNextWord(p);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* MoveWordLeft_55(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MoveWordLeft();

            return __ret;
        }

        static StackObject* SelectWordRight_56(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectWordRight();

            return __ret;
        }

        static StackObject* SelectWordLeft_57(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectWordLeft();

            return __ret;
        }

        static StackObject* ExpandSelectGraphicalLineStart_58(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ExpandSelectGraphicalLineStart();

            return __ret;
        }

        static StackObject* ExpandSelectGraphicalLineEnd_59(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ExpandSelectGraphicalLineEnd();

            return __ret;
        }

        static StackObject* SelectGraphicalLineStart_60(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectGraphicalLineStart();

            return __ret;
        }

        static StackObject* SelectGraphicalLineEnd_61(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectGraphicalLineEnd();

            return __ret;
        }

        static StackObject* SelectParagraphForward_62(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectParagraphForward();

            return __ret;
        }

        static StackObject* SelectParagraphBackward_63(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectParagraphBackward();

            return __ret;
        }

        static StackObject* SelectCurrentWord_64(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectCurrentWord();

            return __ret;
        }

        static StackObject* SelectCurrentParagraph_65(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SelectCurrentParagraph();

            return __ret;
        }

        static StackObject* UpdateScrollOffsetIfNeeded_66(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Event evt = (UnityEngine.Event)typeof(UnityEngine.Event).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UpdateScrollOffsetIfNeeded(evt);

            return __ret;
        }

        static StackObject* DrawCursor_67(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String newText = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DrawCursor(newText);

            return __ret;
        }

        static StackObject* SaveBackup_68(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SaveBackup();

            return __ret;
        }

        static StackObject* Undo_69(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Undo();

            return __ret;
        }

        static StackObject* Cut_70(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Cut();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Copy_71(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Copy();

            return __ret;
        }

        static StackObject* Paste_72(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Paste();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* DetectFocusChange_73(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextEditor instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextEditor)typeof(UnityEngine.TextEditor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DetectFocusChange();

            return __ret;
        }


        static object get_keyboardOnScreen_0(ref object o)
        {
            return ((UnityEngine.TextEditor)o).keyboardOnScreen;
        }
        static void set_keyboardOnScreen_0(ref object o, object v)
        {
UnityEngine.TextEditor _o = (UnityEngine.TextEditor)o;
    _o.keyboardOnScreen = (UnityEngine.TouchScreenKeyboard)v;
        }
        static object get_controlID_1(ref object o)
        {
            return ((UnityEngine.TextEditor)o).controlID;
        }
        static void set_controlID_1(ref object o, object v)
        {
UnityEngine.TextEditor _o = (UnityEngine.TextEditor)o;
    _o.controlID = (System.Int32)v;
        }
        static object get_style_2(ref object o)
        {
            return ((UnityEngine.TextEditor)o).style;
        }
        static void set_style_2(ref object o, object v)
        {
UnityEngine.TextEditor _o = (UnityEngine.TextEditor)o;
    _o.style = (UnityEngine.GUIStyle)v;
        }
        static object get_multiline_3(ref object o)
        {
            return ((UnityEngine.TextEditor)o).multiline;
        }
        static void set_multiline_3(ref object o, object v)
        {
UnityEngine.TextEditor _o = (UnityEngine.TextEditor)o;
    _o.multiline = (System.Boolean)v;
        }
        static object get_hasHorizontalCursorPos_4(ref object o)
        {
            return ((UnityEngine.TextEditor)o).hasHorizontalCursorPos;
        }
        static void set_hasHorizontalCursorPos_4(ref object o, object v)
        {
UnityEngine.TextEditor _o = (UnityEngine.TextEditor)o;
    _o.hasHorizontalCursorPos = (System.Boolean)v;
        }
        static object get_isPasswordField_5(ref object o)
        {
            return ((UnityEngine.TextEditor)o).isPasswordField;
        }
        static void set_isPasswordField_5(ref object o, object v)
        {
UnityEngine.TextEditor _o = (UnityEngine.TextEditor)o;
    _o.isPasswordField = (System.Boolean)v;
        }
        static object get_scrollOffset_6(ref object o)
        {
            return ((UnityEngine.TextEditor)o).scrollOffset;
        }
        static void set_scrollOffset_6(ref object o, object v)
        {
UnityEngine.TextEditor _o = (UnityEngine.TextEditor)o;
    _o.scrollOffset = (UnityEngine.Vector2)v;
        }
        static object get_graphicalCursorPos_7(ref object o)
        {
            return ((UnityEngine.TextEditor)o).graphicalCursorPos;
        }
        static void set_graphicalCursorPos_7(ref object o, object v)
        {
UnityEngine.TextEditor _o = (UnityEngine.TextEditor)o;
    _o.graphicalCursorPos = (UnityEngine.Vector2)v;
        }
        static object get_graphicalSelectCursorPos_8(ref object o)
        {
            return ((UnityEngine.TextEditor)o).graphicalSelectCursorPos;
        }
        static void set_graphicalSelectCursorPos_8(ref object o, object v)
        {
UnityEngine.TextEditor _o = (UnityEngine.TextEditor)o;
    _o.graphicalSelectCursorPos = (UnityEngine.Vector2)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.TextEditor();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
