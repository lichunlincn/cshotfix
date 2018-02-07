
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
    unsafe class UnityEngine_Experimental_Rendering_DrawRendererSettings_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Experimental.Rendering.DrawRendererSettings);
            args = new Type[]{typeof(UnityEngine.Experimental.Rendering.CullResults)};
            method = type.GetMethod("set_cullResults", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_cullResults_0);

            field = type.GetField("sorting", flag);
            app.RegisterCLRFieldGetter(field, get_sorting_0);
            app.RegisterCLRFieldSetter(field, set_sorting_0);
            field = type.GetField("shaderPassName", flag);
            app.RegisterCLRFieldGetter(field, get_shaderPassName_1);
            app.RegisterCLRFieldSetter(field, set_shaderPassName_1);
            field = type.GetField("inputFilter", flag);
            app.RegisterCLRFieldGetter(field, get_inputFilter_2);
            app.RegisterCLRFieldSetter(field, set_inputFilter_2);
            field = type.GetField("rendererConfiguration", flag);
            app.RegisterCLRFieldGetter(field, get_rendererConfiguration_3);
            app.RegisterCLRFieldSetter(field, set_rendererConfiguration_3);
            field = type.GetField("flags", flag);
            app.RegisterCLRFieldGetter(field, get_flags_4);
            app.RegisterCLRFieldSetter(field, set_flags_4);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Experimental.Rendering.DrawRendererSettings());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Experimental.Rendering.DrawRendererSettings[s]);

            args = new Type[]{typeof(UnityEngine.Experimental.Rendering.CullResults), typeof(UnityEngine.Camera), typeof(UnityEngine.Experimental.Rendering.ShaderPassName)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.Experimental.Rendering.DrawRendererSettings instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Experimental.Rendering.DrawRendererSettings[];
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
            UnityEngine.Experimental.Rendering.DrawRendererSettings instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Rendering.DrawRendererSettings)typeof(UnityEngine.Experimental.Rendering.DrawRendererSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.cullResults = value;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }


        static object get_sorting_0(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.DrawRendererSettings)o).sorting;
        }
        static void set_sorting_0(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.DrawRendererSettings _o = (UnityEngine.Experimental.Rendering.DrawRendererSettings)o;
    _o.sorting = (UnityEngine.Experimental.Rendering.DrawRendererSortSettings)v;
        }
        static object get_shaderPassName_1(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.DrawRendererSettings)o).shaderPassName;
        }
        static void set_shaderPassName_1(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.DrawRendererSettings _o = (UnityEngine.Experimental.Rendering.DrawRendererSettings)o;
    _o.shaderPassName = (UnityEngine.Experimental.Rendering.ShaderPassName)v;
        }
        static object get_inputFilter_2(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.DrawRendererSettings)o).inputFilter;
        }
        static void set_inputFilter_2(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.DrawRendererSettings _o = (UnityEngine.Experimental.Rendering.DrawRendererSettings)o;
    _o.inputFilter = (UnityEngine.Experimental.Rendering.InputFilter)v;
        }
        static object get_rendererConfiguration_3(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.DrawRendererSettings)o).rendererConfiguration;
        }
        static void set_rendererConfiguration_3(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.DrawRendererSettings _o = (UnityEngine.Experimental.Rendering.DrawRendererSettings)o;
    _o.rendererConfiguration = (UnityEngine.Experimental.Rendering.RendererConfiguration)v;
        }
        static object get_flags_4(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.DrawRendererSettings)o).flags;
        }
        static void set_flags_4(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.DrawRendererSettings _o = (UnityEngine.Experimental.Rendering.DrawRendererSettings)o;
    _o.flags = (UnityEngine.Experimental.Rendering.DrawRendererFlags)v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            return new UnityEngine.Experimental.Rendering.DrawRendererSettings
            {
                sorting = ((UnityEngine.Experimental.Rendering.DrawRendererSettings) o).sorting,
                shaderPassName = ((UnityEngine.Experimental.Rendering.DrawRendererSettings) o).shaderPassName,
                inputFilter = ((UnityEngine.Experimental.Rendering.DrawRendererSettings) o).inputFilter,
                rendererConfiguration = ((UnityEngine.Experimental.Rendering.DrawRendererSettings) o).rendererConfiguration,
                flags = ((UnityEngine.Experimental.Rendering.DrawRendererSettings) o).flags,
            };
        }

        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Rendering.ShaderPassName shaderPassName = (UnityEngine.Experimental.Rendering.ShaderPassName)typeof(UnityEngine.Experimental.Rendering.ShaderPassName).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Camera camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Experimental.Rendering.CullResults cullResults = (UnityEngine.Experimental.Rendering.CullResults)typeof(UnityEngine.Experimental.Rendering.CullResults).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new UnityEngine.Experimental.Rendering.DrawRendererSettings(cullResults, camera, shaderPassName);

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
