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
    unsafe class UnityEngine_TextMesh_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.TextMesh);
            args = new Type[]{};
            method = type.GetMethod("get_text", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_text_0);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_text", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_text_1);
            args = new Type[]{};
            method = type.GetMethod("get_font", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_font_2);
            args = new Type[]{typeof(UnityEngine.Font)};
            method = type.GetMethod("set_font", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_font_3);
            args = new Type[]{};
            method = type.GetMethod("get_fontSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_fontSize_4);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_fontSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_fontSize_5);
            args = new Type[]{};
            method = type.GetMethod("get_fontStyle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_fontStyle_6);
            args = new Type[]{typeof(UnityEngine.FontStyle)};
            method = type.GetMethod("set_fontStyle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_fontStyle_7);
            args = new Type[]{};
            method = type.GetMethod("get_offsetZ", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_offsetZ_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_offsetZ", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_offsetZ_9);
            args = new Type[]{};
            method = type.GetMethod("get_alignment", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_alignment_10);
            args = new Type[]{typeof(UnityEngine.TextAlignment)};
            method = type.GetMethod("set_alignment", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_alignment_11);
            args = new Type[]{};
            method = type.GetMethod("get_anchor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_anchor_12);
            args = new Type[]{typeof(UnityEngine.TextAnchor)};
            method = type.GetMethod("set_anchor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_anchor_13);
            args = new Type[]{};
            method = type.GetMethod("get_characterSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_characterSize_14);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_characterSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_characterSize_15);
            args = new Type[]{};
            method = type.GetMethod("get_lineSpacing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lineSpacing_16);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_lineSpacing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lineSpacing_17);
            args = new Type[]{};
            method = type.GetMethod("get_tabSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_tabSize_18);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_tabSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_tabSize_19);
            args = new Type[]{};
            method = type.GetMethod("get_richText", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_richText_20);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_richText", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_richText_21);
            args = new Type[]{};
            method = type.GetMethod("get_color", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_color_22);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("set_color", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_color_23);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.TextMesh());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.TextMesh[s]);

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
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
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
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.text = value;

            return __ret;
        }

        static StackObject* get_font_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.font;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_font_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Font value = (UnityEngine.Font)typeof(UnityEngine.Font).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.font = value;

            return __ret;
        }

        static StackObject* get_fontSize_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.fontSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_fontSize_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.fontSize = value;

            return __ret;
        }

        static StackObject* get_fontStyle_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.fontStyle;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_fontStyle_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.FontStyle value = (UnityEngine.FontStyle)typeof(UnityEngine.FontStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.fontStyle = value;

            return __ret;
        }

        static StackObject* get_offsetZ_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.offsetZ;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_offsetZ_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.offsetZ = value;

            return __ret;
        }

        static StackObject* get_alignment_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.alignment;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_alignment_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextAlignment value = (UnityEngine.TextAlignment)typeof(UnityEngine.TextAlignment).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.alignment = value;

            return __ret;
        }

        static StackObject* get_anchor_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.anchor;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_anchor_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextAnchor value = (UnityEngine.TextAnchor)typeof(UnityEngine.TextAnchor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.anchor = value;

            return __ret;
        }

        static StackObject* get_characterSize_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.characterSize;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_characterSize_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.characterSize = value;

            return __ret;
        }

        static StackObject* get_lineSpacing_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lineSpacing;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_lineSpacing_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.lineSpacing = value;

            return __ret;
        }

        static StackObject* get_tabSize_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.tabSize;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_tabSize_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.tabSize = value;

            return __ret;
        }

        static StackObject* get_richText_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.richText;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_richText_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.richText = value;

            return __ret;
        }

        static StackObject* get_color_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.color;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_color_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextMesh instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextMesh)typeof(UnityEngine.TextMesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.color = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.TextMesh();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
