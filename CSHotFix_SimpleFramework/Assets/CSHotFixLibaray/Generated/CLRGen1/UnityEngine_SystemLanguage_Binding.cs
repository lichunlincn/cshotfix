
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
    unsafe class UnityEngine_SystemLanguage_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.SystemLanguage);

            field = type.GetField("Afrikaans", flag);
            app.RegisterCLRFieldGetter(field, get_Afrikaans_0);
            field = type.GetField("Arabic", flag);
            app.RegisterCLRFieldGetter(field, get_Arabic_1);
            field = type.GetField("Basque", flag);
            app.RegisterCLRFieldGetter(field, get_Basque_2);
            field = type.GetField("Belarusian", flag);
            app.RegisterCLRFieldGetter(field, get_Belarusian_3);
            field = type.GetField("Bulgarian", flag);
            app.RegisterCLRFieldGetter(field, get_Bulgarian_4);
            field = type.GetField("Catalan", flag);
            app.RegisterCLRFieldGetter(field, get_Catalan_5);
            field = type.GetField("Chinese", flag);
            app.RegisterCLRFieldGetter(field, get_Chinese_6);
            field = type.GetField("Czech", flag);
            app.RegisterCLRFieldGetter(field, get_Czech_7);
            field = type.GetField("Danish", flag);
            app.RegisterCLRFieldGetter(field, get_Danish_8);
            field = type.GetField("Dutch", flag);
            app.RegisterCLRFieldGetter(field, get_Dutch_9);
            field = type.GetField("English", flag);
            app.RegisterCLRFieldGetter(field, get_English_10);
            field = type.GetField("Estonian", flag);
            app.RegisterCLRFieldGetter(field, get_Estonian_11);
            field = type.GetField("Faroese", flag);
            app.RegisterCLRFieldGetter(field, get_Faroese_12);
            field = type.GetField("Finnish", flag);
            app.RegisterCLRFieldGetter(field, get_Finnish_13);
            field = type.GetField("French", flag);
            app.RegisterCLRFieldGetter(field, get_French_14);
            field = type.GetField("German", flag);
            app.RegisterCLRFieldGetter(field, get_German_15);
            field = type.GetField("Greek", flag);
            app.RegisterCLRFieldGetter(field, get_Greek_16);
            field = type.GetField("Hebrew", flag);
            app.RegisterCLRFieldGetter(field, get_Hebrew_17);
            field = type.GetField("Icelandic", flag);
            app.RegisterCLRFieldGetter(field, get_Icelandic_18);
            field = type.GetField("Indonesian", flag);
            app.RegisterCLRFieldGetter(field, get_Indonesian_19);
            field = type.GetField("Italian", flag);
            app.RegisterCLRFieldGetter(field, get_Italian_20);
            field = type.GetField("Japanese", flag);
            app.RegisterCLRFieldGetter(field, get_Japanese_21);
            field = type.GetField("Korean", flag);
            app.RegisterCLRFieldGetter(field, get_Korean_22);
            field = type.GetField("Latvian", flag);
            app.RegisterCLRFieldGetter(field, get_Latvian_23);
            field = type.GetField("Lithuanian", flag);
            app.RegisterCLRFieldGetter(field, get_Lithuanian_24);
            field = type.GetField("Norwegian", flag);
            app.RegisterCLRFieldGetter(field, get_Norwegian_25);
            field = type.GetField("Polish", flag);
            app.RegisterCLRFieldGetter(field, get_Polish_26);
            field = type.GetField("Portuguese", flag);
            app.RegisterCLRFieldGetter(field, get_Portuguese_27);
            field = type.GetField("Romanian", flag);
            app.RegisterCLRFieldGetter(field, get_Romanian_28);
            field = type.GetField("Russian", flag);
            app.RegisterCLRFieldGetter(field, get_Russian_29);
            field = type.GetField("SerboCroatian", flag);
            app.RegisterCLRFieldGetter(field, get_SerboCroatian_30);
            field = type.GetField("Slovak", flag);
            app.RegisterCLRFieldGetter(field, get_Slovak_31);
            field = type.GetField("Slovenian", flag);
            app.RegisterCLRFieldGetter(field, get_Slovenian_32);
            field = type.GetField("Spanish", flag);
            app.RegisterCLRFieldGetter(field, get_Spanish_33);
            field = type.GetField("Swedish", flag);
            app.RegisterCLRFieldGetter(field, get_Swedish_34);
            field = type.GetField("Thai", flag);
            app.RegisterCLRFieldGetter(field, get_Thai_35);
            field = type.GetField("Turkish", flag);
            app.RegisterCLRFieldGetter(field, get_Turkish_36);
            field = type.GetField("Ukrainian", flag);
            app.RegisterCLRFieldGetter(field, get_Ukrainian_37);
            field = type.GetField("Vietnamese", flag);
            app.RegisterCLRFieldGetter(field, get_Vietnamese_38);
            field = type.GetField("ChineseSimplified", flag);
            app.RegisterCLRFieldGetter(field, get_ChineseSimplified_39);
            field = type.GetField("ChineseTraditional", flag);
            app.RegisterCLRFieldGetter(field, get_ChineseTraditional_40);
            field = type.GetField("Unknown", flag);
            app.RegisterCLRFieldGetter(field, get_Unknown_41);
            field = type.GetField("Hungarian", flag);
            app.RegisterCLRFieldGetter(field, get_Hungarian_42);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.SystemLanguage());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.SystemLanguage[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.SystemLanguage instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.SystemLanguage[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Afrikaans_0(ref object o)
        {
            return UnityEngine.SystemLanguage.Afrikaans;
        }
        static object get_Arabic_1(ref object o)
        {
            return UnityEngine.SystemLanguage.Arabic;
        }
        static object get_Basque_2(ref object o)
        {
            return UnityEngine.SystemLanguage.Basque;
        }
        static object get_Belarusian_3(ref object o)
        {
            return UnityEngine.SystemLanguage.Belarusian;
        }
        static object get_Bulgarian_4(ref object o)
        {
            return UnityEngine.SystemLanguage.Bulgarian;
        }
        static object get_Catalan_5(ref object o)
        {
            return UnityEngine.SystemLanguage.Catalan;
        }
        static object get_Chinese_6(ref object o)
        {
            return UnityEngine.SystemLanguage.Chinese;
        }
        static object get_Czech_7(ref object o)
        {
            return UnityEngine.SystemLanguage.Czech;
        }
        static object get_Danish_8(ref object o)
        {
            return UnityEngine.SystemLanguage.Danish;
        }
        static object get_Dutch_9(ref object o)
        {
            return UnityEngine.SystemLanguage.Dutch;
        }
        static object get_English_10(ref object o)
        {
            return UnityEngine.SystemLanguage.English;
        }
        static object get_Estonian_11(ref object o)
        {
            return UnityEngine.SystemLanguage.Estonian;
        }
        static object get_Faroese_12(ref object o)
        {
            return UnityEngine.SystemLanguage.Faroese;
        }
        static object get_Finnish_13(ref object o)
        {
            return UnityEngine.SystemLanguage.Finnish;
        }
        static object get_French_14(ref object o)
        {
            return UnityEngine.SystemLanguage.French;
        }
        static object get_German_15(ref object o)
        {
            return UnityEngine.SystemLanguage.German;
        }
        static object get_Greek_16(ref object o)
        {
            return UnityEngine.SystemLanguage.Greek;
        }
        static object get_Hebrew_17(ref object o)
        {
            return UnityEngine.SystemLanguage.Hebrew;
        }
        static object get_Icelandic_18(ref object o)
        {
            return UnityEngine.SystemLanguage.Icelandic;
        }
        static object get_Indonesian_19(ref object o)
        {
            return UnityEngine.SystemLanguage.Indonesian;
        }
        static object get_Italian_20(ref object o)
        {
            return UnityEngine.SystemLanguage.Italian;
        }
        static object get_Japanese_21(ref object o)
        {
            return UnityEngine.SystemLanguage.Japanese;
        }
        static object get_Korean_22(ref object o)
        {
            return UnityEngine.SystemLanguage.Korean;
        }
        static object get_Latvian_23(ref object o)
        {
            return UnityEngine.SystemLanguage.Latvian;
        }
        static object get_Lithuanian_24(ref object o)
        {
            return UnityEngine.SystemLanguage.Lithuanian;
        }
        static object get_Norwegian_25(ref object o)
        {
            return UnityEngine.SystemLanguage.Norwegian;
        }
        static object get_Polish_26(ref object o)
        {
            return UnityEngine.SystemLanguage.Polish;
        }
        static object get_Portuguese_27(ref object o)
        {
            return UnityEngine.SystemLanguage.Portuguese;
        }
        static object get_Romanian_28(ref object o)
        {
            return UnityEngine.SystemLanguage.Romanian;
        }
        static object get_Russian_29(ref object o)
        {
            return UnityEngine.SystemLanguage.Russian;
        }
        static object get_SerboCroatian_30(ref object o)
        {
            return UnityEngine.SystemLanguage.SerboCroatian;
        }
        static object get_Slovak_31(ref object o)
        {
            return UnityEngine.SystemLanguage.Slovak;
        }
        static object get_Slovenian_32(ref object o)
        {
            return UnityEngine.SystemLanguage.Slovenian;
        }
        static object get_Spanish_33(ref object o)
        {
            return UnityEngine.SystemLanguage.Spanish;
        }
        static object get_Swedish_34(ref object o)
        {
            return UnityEngine.SystemLanguage.Swedish;
        }
        static object get_Thai_35(ref object o)
        {
            return UnityEngine.SystemLanguage.Thai;
        }
        static object get_Turkish_36(ref object o)
        {
            return UnityEngine.SystemLanguage.Turkish;
        }
        static object get_Ukrainian_37(ref object o)
        {
            return UnityEngine.SystemLanguage.Ukrainian;
        }
        static object get_Vietnamese_38(ref object o)
        {
            return UnityEngine.SystemLanguage.Vietnamese;
        }
        static object get_ChineseSimplified_39(ref object o)
        {
            return UnityEngine.SystemLanguage.ChineseSimplified;
        }
        static object get_ChineseTraditional_40(ref object o)
        {
            return UnityEngine.SystemLanguage.ChineseTraditional;
        }
        static object get_Unknown_41(ref object o)
        {
            return UnityEngine.SystemLanguage.Unknown;
        }
        static object get_Hungarian_42(ref object o)
        {
            return UnityEngine.SystemLanguage.Hungarian;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.SystemLanguage();
            ins = (UnityEngine.SystemLanguage)o;
            return ins;
        }


    }
}
#endif
