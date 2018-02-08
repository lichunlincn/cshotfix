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
    unsafe class UnityEngine_Experimental_Rendering_DrawShadowsSettings_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Experimental.Rendering.DrawShadowsSettings);
            args = new Type[]{typeof(UnityEngine.Experimental.Rendering.CullResults)};
            method = type.GetMethod("set_cullResults", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_cullResults_0);

            field = type.GetField("lightIndex", flag);
            app.RegisterCLRFieldGetter(field, get_lightIndex_0);
            app.RegisterCLRFieldSetter(field, set_lightIndex_0);
            field = type.GetField("splitData", flag);
            app.RegisterCLRFieldGetter(field, get_splitData_1);
            app.RegisterCLRFieldSetter(field, set_splitData_1);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Experimental.Rendering.DrawShadowsSettings());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Experimental.Rendering.DrawShadowsSettings[s]);

            args = new Type[]{typeof(UnityEngine.Experimental.Rendering.CullResults), typeof(System.Int32)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.Experimental.Rendering.DrawShadowsSettings instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Experimental.Rendering.DrawShadowsSettings[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* set_cullResults_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Rendering.CullResults value = (UnityEngine.Experimental.Rendering.CullResults)typeof(UnityEngine.Experimental.Rendering.CullResults).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Rendering.DrawShadowsSettings instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Rendering.DrawShadowsSettings)typeof(UnityEngine.Experimental.Rendering.DrawShadowsSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.cullResults = value;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }


        static object get_lightIndex_0(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.DrawShadowsSettings)o).lightIndex;
        }
        static void set_lightIndex_0(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.DrawShadowsSettings _o = (UnityEngine.Experimental.Rendering.DrawShadowsSettings)o;
    _o.lightIndex = (System.Int32)v;
        }
        static object get_splitData_1(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.DrawShadowsSettings)o).splitData;
        }
        static void set_splitData_1(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.DrawShadowsSettings _o = (UnityEngine.Experimental.Rendering.DrawShadowsSettings)o;
    _o.splitData = (UnityEngine.Experimental.Rendering.ShadowSplitData)v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Experimental.Rendering.DrawShadowsSettings();
            ins = (UnityEngine.Experimental.Rendering.DrawShadowsSettings)o;
            return ins;
        }

        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 lightIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Rendering.CullResults cullResults = (UnityEngine.Experimental.Rendering.CullResults)typeof(UnityEngine.Experimental.Rendering.CullResults).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new UnityEngine.Experimental.Rendering.DrawShadowsSettings(cullResults, lightIndex);

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
