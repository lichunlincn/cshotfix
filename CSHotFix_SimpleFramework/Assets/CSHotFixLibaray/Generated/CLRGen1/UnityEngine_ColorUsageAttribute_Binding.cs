
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

namespace CSHotFix.Runtime.Generated
{
    unsafe class UnityEngine_ColorUsageAttribute_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ColorUsageAttribute);

            field = type.GetField("showAlpha", flag);
            app.RegisterCLRFieldGetter(field, get_showAlpha_0);
            field = type.GetField("hdr", flag);
            app.RegisterCLRFieldGetter(field, get_hdr_1);
            field = type.GetField("minBrightness", flag);
            app.RegisterCLRFieldGetter(field, get_minBrightness_2);
            field = type.GetField("maxBrightness", flag);
            app.RegisterCLRFieldGetter(field, get_maxBrightness_3);
            field = type.GetField("minExposureValue", flag);
            app.RegisterCLRFieldGetter(field, get_minExposureValue_4);
            field = type.GetField("maxExposureValue", flag);
            app.RegisterCLRFieldGetter(field, get_maxExposureValue_5);


            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ColorUsageAttribute[s]);

            args = new Type[]{typeof(System.Boolean)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(System.Boolean), typeof(System.Boolean), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);

        }



        static object get_showAlpha_0(ref object o)
        {
            return ((UnityEngine.ColorUsageAttribute)o).showAlpha;
        }
        static object get_hdr_1(ref object o)
        {
            return ((UnityEngine.ColorUsageAttribute)o).hdr;
        }
        static object get_minBrightness_2(ref object o)
        {
            return ((UnityEngine.ColorUsageAttribute)o).minBrightness;
        }
        static object get_maxBrightness_3(ref object o)
        {
            return ((UnityEngine.ColorUsageAttribute)o).maxBrightness;
        }
        static object get_minExposureValue_4(ref object o)
        {
            return ((UnityEngine.ColorUsageAttribute)o).minExposureValue;
        }
        static object get_maxExposureValue_5(ref object o)
        {
            return ((UnityEngine.ColorUsageAttribute)o).maxExposureValue;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @showAlpha = ptr_of_this_method->Value == 1;


            var result_of_this_method = new UnityEngine.ColorUsageAttribute(@showAlpha);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @maxExposureValue = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @minExposureValue = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @maxBrightness = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @minBrightness = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Boolean @hdr = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Boolean @showAlpha = ptr_of_this_method->Value == 1;


            var result_of_this_method = new UnityEngine.ColorUsageAttribute(@showAlpha, @hdr, @minBrightness, @maxBrightness, @minExposureValue, @maxExposureValue);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
