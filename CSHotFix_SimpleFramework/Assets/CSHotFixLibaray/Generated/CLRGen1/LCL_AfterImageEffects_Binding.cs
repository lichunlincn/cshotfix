
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
    unsafe class LCL_AfterImageEffects_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(LCL.AfterImageEffects);

            field = type.GetField("_OpenAfterImage", flag);
            app.RegisterCLRFieldGetter(field, get__OpenAfterImage_0);
            app.RegisterCLRFieldSetter(field, set__OpenAfterImage_0);
            field = type.GetField("_AfterImageColor", flag);
            app.RegisterCLRFieldGetter(field, get__AfterImageColor_1);
            app.RegisterCLRFieldSetter(field, set__AfterImageColor_1);
            field = type.GetField("_SurvivalTime", flag);
            app.RegisterCLRFieldGetter(field, get__SurvivalTime_2);
            app.RegisterCLRFieldSetter(field, set__SurvivalTime_2);
            field = type.GetField("_IntervalTime", flag);
            app.RegisterCLRFieldGetter(field, get__IntervalTime_3);
            app.RegisterCLRFieldSetter(field, set__IntervalTime_3);
            field = type.GetField("_InitialAlpha", flag);
            app.RegisterCLRFieldGetter(field, get__InitialAlpha_4);
            app.RegisterCLRFieldSetter(field, set__InitialAlpha_4);


            app.RegisterCLRCreateDefaultInstance(type, () => new LCL.AfterImageEffects());
            app.RegisterCLRCreateArrayInstance(type, s => new LCL.AfterImageEffects[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get__OpenAfterImage_0(ref object o)
        {
            return ((LCL.AfterImageEffects)o)._OpenAfterImage;
        }
        static void set__OpenAfterImage_0(ref object o, object v)
        {
LCL.AfterImageEffects _o = (LCL.AfterImageEffects)o;
    _o._OpenAfterImage = (System.Boolean)v;
        }
        static object get__AfterImageColor_1(ref object o)
        {
            return ((LCL.AfterImageEffects)o)._AfterImageColor;
        }
        static void set__AfterImageColor_1(ref object o, object v)
        {
LCL.AfterImageEffects _o = (LCL.AfterImageEffects)o;
    _o._AfterImageColor = (UnityEngine.Color)v;
        }
        static object get__SurvivalTime_2(ref object o)
        {
            return ((LCL.AfterImageEffects)o)._SurvivalTime;
        }
        static void set__SurvivalTime_2(ref object o, object v)
        {
LCL.AfterImageEffects _o = (LCL.AfterImageEffects)o;
    _o._SurvivalTime = (System.Single)v;
        }
        static object get__IntervalTime_3(ref object o)
        {
            return ((LCL.AfterImageEffects)o)._IntervalTime;
        }
        static void set__IntervalTime_3(ref object o, object v)
        {
LCL.AfterImageEffects _o = (LCL.AfterImageEffects)o;
    _o._IntervalTime = (System.Single)v;
        }
        static object get__InitialAlpha_4(ref object o)
        {
            return ((LCL.AfterImageEffects)o)._InitialAlpha;
        }
        static void set__InitialAlpha_4(ref object o, object v)
        {
LCL.AfterImageEffects _o = (LCL.AfterImageEffects)o;
    _o._InitialAlpha = (System.Single)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new LCL.AfterImageEffects();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
