
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
    unsafe class UnityEngine_Rendering_GraphicsSettings_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Rendering.GraphicsSettings);
            args = new Type[]{typeof(UnityEngine.Rendering.BuiltinShaderType), typeof(UnityEngine.Rendering.BuiltinShaderMode)};
            method = type.GetMethod("SetShaderMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetShaderMode_0);
            args = new Type[]{typeof(UnityEngine.Rendering.BuiltinShaderType)};
            method = type.GetMethod("GetShaderMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetShaderMode_1);
            args = new Type[]{};
            method = type.GetMethod("get_renderPipelineAsset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_renderPipelineAsset_2);
            args = new Type[]{typeof(UnityEngine.Experimental.Rendering.RenderPipelineAsset)};
            method = type.GetMethod("set_renderPipelineAsset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_renderPipelineAsset_3);
            args = new Type[]{typeof(UnityEngine.Rendering.BuiltinShaderType), typeof(UnityEngine.Shader)};
            method = type.GetMethod("SetCustomShader", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetCustomShader_4);
            args = new Type[]{typeof(UnityEngine.Rendering.BuiltinShaderType)};
            method = type.GetMethod("GetCustomShader", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCustomShader_5);
            args = new Type[]{};
            method = type.GetMethod("get_transparencySortMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_transparencySortMode_6);
            args = new Type[]{typeof(UnityEngine.TransparencySortMode)};
            method = type.GetMethod("set_transparencySortMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_transparencySortMode_7);
            args = new Type[]{};
            method = type.GetMethod("get_transparencySortAxis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_transparencySortAxis_8);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_transparencySortAxis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_transparencySortAxis_9);
            args = new Type[]{};
            method = type.GetMethod("get_lightsUseLinearIntensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lightsUseLinearIntensity_10);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_lightsUseLinearIntensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lightsUseLinearIntensity_11);
            args = new Type[]{};
            method = type.GetMethod("get_lightsUseColorTemperature", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lightsUseColorTemperature_12);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_lightsUseColorTemperature", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lightsUseColorTemperature_13);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Rendering.GraphicsSettings());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Rendering.GraphicsSettings[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* SetShaderMode_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.BuiltinShaderMode mode = (UnityEngine.Rendering.BuiltinShaderMode)typeof(UnityEngine.Rendering.BuiltinShaderMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.BuiltinShaderType type = (UnityEngine.Rendering.BuiltinShaderType)typeof(UnityEngine.Rendering.BuiltinShaderType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Rendering.GraphicsSettings.SetShaderMode(type, mode);

            return __ret;
        }

        static StackObject* GetShaderMode_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.BuiltinShaderType type = (UnityEngine.Rendering.BuiltinShaderType)typeof(UnityEngine.Rendering.BuiltinShaderType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.GetShaderMode(type);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_renderPipelineAsset_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.renderPipelineAsset;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_renderPipelineAsset_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Rendering.RenderPipelineAsset value = (UnityEngine.Experimental.Rendering.RenderPipelineAsset)typeof(UnityEngine.Experimental.Rendering.RenderPipelineAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Rendering.GraphicsSettings.renderPipelineAsset = value;

            return __ret;
        }

        static StackObject* SetCustomShader_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Shader shader = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.BuiltinShaderType type = (UnityEngine.Rendering.BuiltinShaderType)typeof(UnityEngine.Rendering.BuiltinShaderType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Rendering.GraphicsSettings.SetCustomShader(type, shader);

            return __ret;
        }

        static StackObject* GetCustomShader_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.BuiltinShaderType type = (UnityEngine.Rendering.BuiltinShaderType)typeof(UnityEngine.Rendering.BuiltinShaderType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.GetCustomShader(type);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_transparencySortMode_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.transparencySortMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_transparencySortMode_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TransparencySortMode value = (UnityEngine.TransparencySortMode)typeof(UnityEngine.TransparencySortMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Rendering.GraphicsSettings.transparencySortMode = value;

            return __ret;
        }

        static StackObject* get_transparencySortAxis_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.transparencySortAxis;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_transparencySortAxis_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Rendering.GraphicsSettings.transparencySortAxis = value;

            return __ret;
        }

        static StackObject* get_lightsUseLinearIntensity_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.lightsUseLinearIntensity;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_lightsUseLinearIntensity_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;

            UnityEngine.Rendering.GraphicsSettings.lightsUseLinearIntensity = value;

            return __ret;
        }

        static StackObject* get_lightsUseColorTemperature_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.lightsUseColorTemperature;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_lightsUseColorTemperature_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;

            UnityEngine.Rendering.GraphicsSettings.lightsUseColorTemperature = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Rendering.GraphicsSettings();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
