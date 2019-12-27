
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
    unsafe class UnityEngine_LOD_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.LOD);

            field = type.GetField("screenRelativeTransitionHeight", flag);
            app.RegisterCLRFieldGetter(field, get_screenRelativeTransitionHeight_0);
            app.RegisterCLRFieldSetter(field, set_screenRelativeTransitionHeight_0);
            field = type.GetField("fadeTransitionWidth", flag);
            app.RegisterCLRFieldGetter(field, get_fadeTransitionWidth_1);
            app.RegisterCLRFieldSetter(field, set_fadeTransitionWidth_1);
            field = type.GetField("renderers", flag);
            app.RegisterCLRFieldGetter(field, get_renderers_2);
            app.RegisterCLRFieldSetter(field, set_renderers_2);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.LOD());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.LOD[s]);

            args = new Type[]{typeof(System.Single), typeof(UnityEngine.Renderer[])};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.LOD instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.LOD[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_screenRelativeTransitionHeight_0(ref object o)
        {
            return ((UnityEngine.LOD)o).screenRelativeTransitionHeight;
        }
        static void set_screenRelativeTransitionHeight_0(ref object o, object v)
        {
UnityEngine.LOD _o = (UnityEngine.LOD)o;
    _o.screenRelativeTransitionHeight = (System.Single)v;
        }
        static object get_fadeTransitionWidth_1(ref object o)
        {
            return ((UnityEngine.LOD)o).fadeTransitionWidth;
        }
        static void set_fadeTransitionWidth_1(ref object o, object v)
        {
UnityEngine.LOD _o = (UnityEngine.LOD)o;
    _o.fadeTransitionWidth = (System.Single)v;
        }
        static object get_renderers_2(ref object o)
        {
            return ((UnityEngine.LOD)o).renderers;
        }
        static void set_renderers_2(ref object o, object v)
        {
UnityEngine.LOD _o = (UnityEngine.LOD)o;
    _o.renderers = (UnityEngine.Renderer[])v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.LOD();
            ins = (UnityEngine.LOD)o;
            return ins;
        }

        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer[] @renderers = (UnityEngine.Renderer[])typeof(UnityEngine.Renderer[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @screenRelativeTransitionHeight = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = new UnityEngine.LOD(@screenRelativeTransitionHeight, @renderers);

            if(!isNewObj)
            {
                __ret--;
                WriteBackInstance(__domain, __ret, __mStack, ref result_of_this_method);
                return __ret;
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
