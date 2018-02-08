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
    unsafe class UnityEngine_TextGenerationSettings_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.TextGenerationSettings);
            args = new Type[]{typeof(UnityEngine.TextGenerationSettings)};
            method = type.GetMethod("Equals", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Equals_0);

            field = type.GetField("font", flag);
            app.RegisterCLRFieldGetter(field, get_font_0);
            app.RegisterCLRFieldSetter(field, set_font_0);
            field = type.GetField("color", flag);
            app.RegisterCLRFieldGetter(field, get_color_1);
            app.RegisterCLRFieldSetter(field, set_color_1);
            field = type.GetField("fontSize", flag);
            app.RegisterCLRFieldGetter(field, get_fontSize_2);
            app.RegisterCLRFieldSetter(field, set_fontSize_2);
            field = type.GetField("lineSpacing", flag);
            app.RegisterCLRFieldGetter(field, get_lineSpacing_3);
            app.RegisterCLRFieldSetter(field, set_lineSpacing_3);
            field = type.GetField("richText", flag);
            app.RegisterCLRFieldGetter(field, get_richText_4);
            app.RegisterCLRFieldSetter(field, set_richText_4);
            field = type.GetField("scaleFactor", flag);
            app.RegisterCLRFieldGetter(field, get_scaleFactor_5);
            app.RegisterCLRFieldSetter(field, set_scaleFactor_5);
            field = type.GetField("fontStyle", flag);
            app.RegisterCLRFieldGetter(field, get_fontStyle_6);
            app.RegisterCLRFieldSetter(field, set_fontStyle_6);
            field = type.GetField("textAnchor", flag);
            app.RegisterCLRFieldGetter(field, get_textAnchor_7);
            app.RegisterCLRFieldSetter(field, set_textAnchor_7);
            field = type.GetField("alignByGeometry", flag);
            app.RegisterCLRFieldGetter(field, get_alignByGeometry_8);
            app.RegisterCLRFieldSetter(field, set_alignByGeometry_8);
            field = type.GetField("resizeTextForBestFit", flag);
            app.RegisterCLRFieldGetter(field, get_resizeTextForBestFit_9);
            app.RegisterCLRFieldSetter(field, set_resizeTextForBestFit_9);
            field = type.GetField("resizeTextMinSize", flag);
            app.RegisterCLRFieldGetter(field, get_resizeTextMinSize_10);
            app.RegisterCLRFieldSetter(field, set_resizeTextMinSize_10);
            field = type.GetField("resizeTextMaxSize", flag);
            app.RegisterCLRFieldGetter(field, get_resizeTextMaxSize_11);
            app.RegisterCLRFieldSetter(field, set_resizeTextMaxSize_11);
            field = type.GetField("updateBounds", flag);
            app.RegisterCLRFieldGetter(field, get_updateBounds_12);
            app.RegisterCLRFieldSetter(field, set_updateBounds_12);
            field = type.GetField("verticalOverflow", flag);
            app.RegisterCLRFieldGetter(field, get_verticalOverflow_13);
            app.RegisterCLRFieldSetter(field, set_verticalOverflow_13);
            field = type.GetField("horizontalOverflow", flag);
            app.RegisterCLRFieldGetter(field, get_horizontalOverflow_14);
            app.RegisterCLRFieldSetter(field, set_horizontalOverflow_14);
            field = type.GetField("generationExtents", flag);
            app.RegisterCLRFieldGetter(field, get_generationExtents_15);
            app.RegisterCLRFieldSetter(field, set_generationExtents_15);
            field = type.GetField("pivot", flag);
            app.RegisterCLRFieldGetter(field, get_pivot_16);
            app.RegisterCLRFieldSetter(field, set_pivot_16);
            field = type.GetField("generateOutOfBounds", flag);
            app.RegisterCLRFieldGetter(field, get_generateOutOfBounds_17);
            app.RegisterCLRFieldSetter(field, set_generateOutOfBounds_17);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.TextGenerationSettings());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.TextGenerationSettings[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.TextGenerationSettings instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.TextGenerationSettings[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* Equals_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextGenerationSettings other = (UnityEngine.TextGenerationSettings)typeof(UnityEngine.TextGenerationSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.TextGenerationSettings instance_of_this_method;
            instance_of_this_method = (UnityEngine.TextGenerationSettings)typeof(UnityEngine.TextGenerationSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.Equals(other);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static object get_font_0(ref object o)
        {
            return ((UnityEngine.TextGenerationSettings)o).font;
        }
        static void set_font_0(ref object o, object v)
        {
UnityEngine.TextGenerationSettings _o = (UnityEngine.TextGenerationSettings)o;
    _o.font = (UnityEngine.Font)v;
        }
        static object get_color_1(ref object o)
        {
            return ((UnityEngine.TextGenerationSettings)o).color;
        }
        static void set_color_1(ref object o, object v)
        {
UnityEngine.TextGenerationSettings _o = (UnityEngine.TextGenerationSettings)o;
    _o.color = (UnityEngine.Color)v;
        }
        static object get_fontSize_2(ref object o)
        {
            return ((UnityEngine.TextGenerationSettings)o).fontSize;
        }
        static void set_fontSize_2(ref object o, object v)
        {
UnityEngine.TextGenerationSettings _o = (UnityEngine.TextGenerationSettings)o;
    _o.fontSize = (System.Int32)v;
        }
        static object get_lineSpacing_3(ref object o)
        {
            return ((UnityEngine.TextGenerationSettings)o).lineSpacing;
        }
        static void set_lineSpacing_3(ref object o, object v)
        {
UnityEngine.TextGenerationSettings _o = (UnityEngine.TextGenerationSettings)o;
    _o.lineSpacing = (System.Single)v;
        }
        static object get_richText_4(ref object o)
        {
            return ((UnityEngine.TextGenerationSettings)o).richText;
        }
        static void set_richText_4(ref object o, object v)
        {
UnityEngine.TextGenerationSettings _o = (UnityEngine.TextGenerationSettings)o;
    _o.richText = (System.Boolean)v;
        }
        static object get_scaleFactor_5(ref object o)
        {
            return ((UnityEngine.TextGenerationSettings)o).scaleFactor;
        }
        static void set_scaleFactor_5(ref object o, object v)
        {
UnityEngine.TextGenerationSettings _o = (UnityEngine.TextGenerationSettings)o;
    _o.scaleFactor = (System.Single)v;
        }
        static object get_fontStyle_6(ref object o)
        {
            return ((UnityEngine.TextGenerationSettings)o).fontStyle;
        }
        static void set_fontStyle_6(ref object o, object v)
        {
UnityEngine.TextGenerationSettings _o = (UnityEngine.TextGenerationSettings)o;
    _o.fontStyle = (UnityEngine.FontStyle)v;
        }
        static object get_textAnchor_7(ref object o)
        {
            return ((UnityEngine.TextGenerationSettings)o).textAnchor;
        }
        static void set_textAnchor_7(ref object o, object v)
        {
UnityEngine.TextGenerationSettings _o = (UnityEngine.TextGenerationSettings)o;
    _o.textAnchor = (UnityEngine.TextAnchor)v;
        }
        static object get_alignByGeometry_8(ref object o)
        {
            return ((UnityEngine.TextGenerationSettings)o).alignByGeometry;
        }
        static void set_alignByGeometry_8(ref object o, object v)
        {
UnityEngine.TextGenerationSettings _o = (UnityEngine.TextGenerationSettings)o;
    _o.alignByGeometry = (System.Boolean)v;
        }
        static object get_resizeTextForBestFit_9(ref object o)
        {
            return ((UnityEngine.TextGenerationSettings)o).resizeTextForBestFit;
        }
        static void set_resizeTextForBestFit_9(ref object o, object v)
        {
UnityEngine.TextGenerationSettings _o = (UnityEngine.TextGenerationSettings)o;
    _o.resizeTextForBestFit = (System.Boolean)v;
        }
        static object get_resizeTextMinSize_10(ref object o)
        {
            return ((UnityEngine.TextGenerationSettings)o).resizeTextMinSize;
        }
        static void set_resizeTextMinSize_10(ref object o, object v)
        {
UnityEngine.TextGenerationSettings _o = (UnityEngine.TextGenerationSettings)o;
    _o.resizeTextMinSize = (System.Int32)v;
        }
        static object get_resizeTextMaxSize_11(ref object o)
        {
            return ((UnityEngine.TextGenerationSettings)o).resizeTextMaxSize;
        }
        static void set_resizeTextMaxSize_11(ref object o, object v)
        {
UnityEngine.TextGenerationSettings _o = (UnityEngine.TextGenerationSettings)o;
    _o.resizeTextMaxSize = (System.Int32)v;
        }
        static object get_updateBounds_12(ref object o)
        {
            return ((UnityEngine.TextGenerationSettings)o).updateBounds;
        }
        static void set_updateBounds_12(ref object o, object v)
        {
UnityEngine.TextGenerationSettings _o = (UnityEngine.TextGenerationSettings)o;
    _o.updateBounds = (System.Boolean)v;
        }
        static object get_verticalOverflow_13(ref object o)
        {
            return ((UnityEngine.TextGenerationSettings)o).verticalOverflow;
        }
        static void set_verticalOverflow_13(ref object o, object v)
        {
UnityEngine.TextGenerationSettings _o = (UnityEngine.TextGenerationSettings)o;
    _o.verticalOverflow = (UnityEngine.VerticalWrapMode)v;
        }
        static object get_horizontalOverflow_14(ref object o)
        {
            return ((UnityEngine.TextGenerationSettings)o).horizontalOverflow;
        }
        static void set_horizontalOverflow_14(ref object o, object v)
        {
UnityEngine.TextGenerationSettings _o = (UnityEngine.TextGenerationSettings)o;
    _o.horizontalOverflow = (UnityEngine.HorizontalWrapMode)v;
        }
        static object get_generationExtents_15(ref object o)
        {
            return ((UnityEngine.TextGenerationSettings)o).generationExtents;
        }
        static void set_generationExtents_15(ref object o, object v)
        {
UnityEngine.TextGenerationSettings _o = (UnityEngine.TextGenerationSettings)o;
    _o.generationExtents = (UnityEngine.Vector2)v;
        }
        static object get_pivot_16(ref object o)
        {
            return ((UnityEngine.TextGenerationSettings)o).pivot;
        }
        static void set_pivot_16(ref object o, object v)
        {
UnityEngine.TextGenerationSettings _o = (UnityEngine.TextGenerationSettings)o;
    _o.pivot = (UnityEngine.Vector2)v;
        }
        static object get_generateOutOfBounds_17(ref object o)
        {
            return ((UnityEngine.TextGenerationSettings)o).generateOutOfBounds;
        }
        static void set_generateOutOfBounds_17(ref object o, object v)
        {
UnityEngine.TextGenerationSettings _o = (UnityEngine.TextGenerationSettings)o;
    _o.generateOutOfBounds = (System.Boolean)v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.TextGenerationSettings();
            ins = (UnityEngine.TextGenerationSettings)o;
            return ins;
        }


    }
}
