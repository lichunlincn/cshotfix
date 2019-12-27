
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
    unsafe class UnityEngine_Shader_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Shader);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("Find", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Find_0);
            args = new Type[]{};
            method = type.GetMethod("get_maximumLOD", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maximumLOD_1);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_maximumLOD", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maximumLOD_2);
            args = new Type[]{};
            method = type.GetMethod("get_globalMaximumLOD", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_globalMaximumLOD_3);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_globalMaximumLOD", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_globalMaximumLOD_4);
            args = new Type[]{};
            method = type.GetMethod("get_isSupported", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isSupported_5);
            args = new Type[]{};
            method = type.GetMethod("get_globalRenderPipeline", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_globalRenderPipeline_6);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_globalRenderPipeline", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_globalRenderPipeline_7);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("EnableKeyword", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EnableKeyword_8);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("DisableKeyword", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DisableKeyword_9);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("IsKeywordEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsKeywordEnabled_10);
            args = new Type[]{};
            method = type.GetMethod("get_renderQueue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_renderQueue_11);
            args = new Type[]{};
            method = type.GetMethod("WarmupAllShaders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WarmupAllShaders_12);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("PropertyToID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PropertyToID_13);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetDependency", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDependency_14);
            args = new Type[]{};
            method = type.GetMethod("get_passCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_passCount_15);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Rendering.ShaderTagId)};
            method = type.GetMethod("FindPassTagValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindPassTagValue_16);
            args = new Type[]{typeof(System.String), typeof(System.Single)};
            method = type.GetMethod("SetGlobalFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalFloat_17);
            args = new Type[]{typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("SetGlobalFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalFloat_18);
            args = new Type[]{typeof(System.String), typeof(System.Int32)};
            method = type.GetMethod("SetGlobalInt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalInt_19);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetGlobalInt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalInt_20);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Vector4)};
            method = type.GetMethod("SetGlobalVector", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalVector_21);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Vector4)};
            method = type.GetMethod("SetGlobalVector", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalVector_22);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Color)};
            method = type.GetMethod("SetGlobalColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalColor_23);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Color)};
            method = type.GetMethod("SetGlobalColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalColor_24);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("SetGlobalMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalMatrix_25);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("SetGlobalMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalMatrix_26);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Texture)};
            method = type.GetMethod("SetGlobalTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalTexture_27);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Texture)};
            method = type.GetMethod("SetGlobalTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalTexture_28);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.ComputeBuffer)};
            method = type.GetMethod("SetGlobalBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalBuffer_29);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.ComputeBuffer)};
            method = type.GetMethod("SetGlobalBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalBuffer_30);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetGlobalConstantBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalConstantBuffer_31);
            args = new Type[]{typeof(System.String), typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("SetGlobalFloatArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalFloatArray_32);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("SetGlobalFloatArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalFloatArray_33);
            args = new Type[]{typeof(System.String), typeof(System.Single[])};
            method = type.GetMethod("SetGlobalFloatArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalFloatArray_34);
            args = new Type[]{typeof(System.Int32), typeof(System.Single[])};
            method = type.GetMethod("SetGlobalFloatArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalFloatArray_35);
            args = new Type[]{typeof(System.String), typeof(System.Collections.Generic.List<UnityEngine.Vector4>)};
            method = type.GetMethod("SetGlobalVectorArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalVectorArray_36);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.Vector4>)};
            method = type.GetMethod("SetGlobalVectorArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalVectorArray_37);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Vector4[])};
            method = type.GetMethod("SetGlobalVectorArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalVectorArray_38);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Vector4[])};
            method = type.GetMethod("SetGlobalVectorArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalVectorArray_39);
            args = new Type[]{typeof(System.String), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>)};
            method = type.GetMethod("SetGlobalMatrixArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalMatrixArray_40);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>)};
            method = type.GetMethod("SetGlobalMatrixArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalMatrixArray_41);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Matrix4x4[])};
            method = type.GetMethod("SetGlobalMatrixArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalMatrixArray_42);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Matrix4x4[])};
            method = type.GetMethod("SetGlobalMatrixArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalMatrixArray_43);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetGlobalFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalFloat_44);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetGlobalFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalFloat_45);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetGlobalInt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalInt_46);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetGlobalInt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalInt_47);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetGlobalVector", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalVector_48);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetGlobalVector", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalVector_49);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetGlobalColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalColor_50);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetGlobalColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalColor_51);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetGlobalMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalMatrix_52);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetGlobalMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalMatrix_53);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetGlobalTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalTexture_54);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetGlobalTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalTexture_55);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetGlobalFloatArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalFloatArray_56);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetGlobalFloatArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalFloatArray_57);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetGlobalVectorArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalVectorArray_58);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetGlobalVectorArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalVectorArray_59);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetGlobalMatrixArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalMatrixArray_60);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetGlobalMatrixArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalMatrixArray_61);
            args = new Type[]{typeof(System.String), typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("GetGlobalFloatArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalFloatArray_62);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("GetGlobalFloatArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalFloatArray_63);
            args = new Type[]{typeof(System.String), typeof(System.Collections.Generic.List<UnityEngine.Vector4>)};
            method = type.GetMethod("GetGlobalVectorArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalVectorArray_64);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.Vector4>)};
            method = type.GetMethod("GetGlobalVectorArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalVectorArray_65);
            args = new Type[]{typeof(System.String), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>)};
            method = type.GetMethod("GetGlobalMatrixArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalMatrixArray_66);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>)};
            method = type.GetMethod("GetGlobalMatrixArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalMatrixArray_67);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Shader[s]);


        }


        static StackObject* Find_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.Find(@name);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_maximumLOD_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maximumLOD;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maximumLOD_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maximumLOD = value;

            return __ret;
        }

        static StackObject* get_globalMaximumLOD_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Shader.globalMaximumLOD;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_globalMaximumLOD_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.Shader.globalMaximumLOD = value;

            return __ret;
        }

        static StackObject* get_isSupported_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isSupported;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_globalRenderPipeline_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Shader.globalRenderPipeline;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_globalRenderPipeline_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.globalRenderPipeline = value;

            return __ret;
        }

        static StackObject* EnableKeyword_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @keyword = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.EnableKeyword(@keyword);

            return __ret;
        }

        static StackObject* DisableKeyword_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @keyword = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.DisableKeyword(@keyword);

            return __ret;
        }

        static StackObject* IsKeywordEnabled_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @keyword = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.IsKeywordEnabled(@keyword);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_renderQueue_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.renderQueue;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* WarmupAllShaders_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.Shader.WarmupAllShaders();

            return __ret;
        }

        static StackObject* PropertyToID_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.PropertyToID(@name);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetDependency_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetDependency(@name);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_passCount_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.passCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* FindPassTagValue_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ShaderTagId @tagName = (UnityEngine.Rendering.ShaderTagId)typeof(UnityEngine.Rendering.ShaderTagId).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @passIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindPassTagValue(@passIndex, @tagName);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetGlobalFloat_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalFloat(@name, @value);

            return __ret;
        }

        static StackObject* SetGlobalFloat_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalFloat(@nameID, @value);

            return __ret;
        }

        static StackObject* SetGlobalInt_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalInt(@name, @value);

            return __ret;
        }

        static StackObject* SetGlobalInt_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalInt(@nameID, @value);

            return __ret;
        }

        static StackObject* SetGlobalVector_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4 @value = (UnityEngine.Vector4)typeof(UnityEngine.Vector4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalVector(@name, @value);

            return __ret;
        }

        static StackObject* SetGlobalVector_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4 @value = (UnityEngine.Vector4)typeof(UnityEngine.Vector4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalVector(@nameID, @value);

            return __ret;
        }

        static StackObject* SetGlobalColor_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalColor(@name, @value);

            return __ret;
        }

        static StackObject* SetGlobalColor_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalColor(@nameID, @value);

            return __ret;
        }

        static StackObject* SetGlobalMatrix_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 @value = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalMatrix(@name, @value);

            return __ret;
        }

        static StackObject* SetGlobalMatrix_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 @value = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalMatrix(@nameID, @value);

            return __ret;
        }

        static StackObject* SetGlobalTexture_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture @value = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalTexture(@name, @value);

            return __ret;
        }

        static StackObject* SetGlobalTexture_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture @value = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalTexture(@nameID, @value);

            return __ret;
        }

        static StackObject* SetGlobalBuffer_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ComputeBuffer @value = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalBuffer(@name, @value);

            return __ret;
        }

        static StackObject* SetGlobalBuffer_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ComputeBuffer @value = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalBuffer(@nameID, @value);

            return __ret;
        }

        static StackObject* SetGlobalConstantBuffer_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @size = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @offset = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ComputeBuffer @value = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalConstantBuffer(@nameID, @value, @offset, @size);

            return __ret;
        }

        static StackObject* SetGlobalFloatArray_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @values = (System.Collections.Generic.List<System.Single>)typeof(System.Collections.Generic.List<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalFloatArray(@name, @values);

            return __ret;
        }

        static StackObject* SetGlobalFloatArray_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @values = (System.Collections.Generic.List<System.Single>)typeof(System.Collections.Generic.List<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalFloatArray(@nameID, @values);

            return __ret;
        }

        static StackObject* SetGlobalFloatArray_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single[] @values = (System.Single[])typeof(System.Single[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalFloatArray(@name, @values);

            return __ret;
        }

        static StackObject* SetGlobalFloatArray_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single[] @values = (System.Single[])typeof(System.Single[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalFloatArray(@nameID, @values);

            return __ret;
        }

        static StackObject* SetGlobalVectorArray_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector4> @values = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalVectorArray(@name, @values);

            return __ret;
        }

        static StackObject* SetGlobalVectorArray_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector4> @values = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalVectorArray(@nameID, @values);

            return __ret;
        }

        static StackObject* SetGlobalVectorArray_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4[] @values = (UnityEngine.Vector4[])typeof(UnityEngine.Vector4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalVectorArray(@name, @values);

            return __ret;
        }

        static StackObject* SetGlobalVectorArray_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4[] @values = (UnityEngine.Vector4[])typeof(UnityEngine.Vector4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalVectorArray(@nameID, @values);

            return __ret;
        }

        static StackObject* SetGlobalMatrixArray_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> @values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalMatrixArray(@name, @values);

            return __ret;
        }

        static StackObject* SetGlobalMatrixArray_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> @values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalMatrixArray(@nameID, @values);

            return __ret;
        }

        static StackObject* SetGlobalMatrixArray_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4[] @values = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalMatrixArray(@name, @values);

            return __ret;
        }

        static StackObject* SetGlobalMatrixArray_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4[] @values = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalMatrixArray(@nameID, @values);

            return __ret;
        }

        static StackObject* GetGlobalFloat_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.GetGlobalFloat(@name);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetGlobalFloat_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @nameID = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Shader.GetGlobalFloat(@nameID);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetGlobalInt_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.GetGlobalInt(@name);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetGlobalInt_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @nameID = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Shader.GetGlobalInt(@nameID);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetGlobalVector_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.GetGlobalVector(@name);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalVector_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @nameID = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Shader.GetGlobalVector(@nameID);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalColor_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.GetGlobalColor(@name);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalColor_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @nameID = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Shader.GetGlobalColor(@nameID);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalMatrix_52(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.GetGlobalMatrix(@name);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalMatrix_53(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @nameID = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Shader.GetGlobalMatrix(@nameID);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalTexture_54(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.GetGlobalTexture(@name);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalTexture_55(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @nameID = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Shader.GetGlobalTexture(@nameID);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalFloatArray_56(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.GetGlobalFloatArray(@name);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalFloatArray_57(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @nameID = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Shader.GetGlobalFloatArray(@nameID);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalVectorArray_58(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.GetGlobalVectorArray(@name);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalVectorArray_59(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @nameID = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Shader.GetGlobalVectorArray(@nameID);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalMatrixArray_60(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.GetGlobalMatrixArray(@name);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalMatrixArray_61(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @nameID = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Shader.GetGlobalMatrixArray(@nameID);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalFloatArray_62(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @values = (System.Collections.Generic.List<System.Single>)typeof(System.Collections.Generic.List<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.GetGlobalFloatArray(@name, @values);

            return __ret;
        }

        static StackObject* GetGlobalFloatArray_63(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @values = (System.Collections.Generic.List<System.Single>)typeof(System.Collections.Generic.List<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.GetGlobalFloatArray(@nameID, @values);

            return __ret;
        }

        static StackObject* GetGlobalVectorArray_64(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector4> @values = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.GetGlobalVectorArray(@name, @values);

            return __ret;
        }

        static StackObject* GetGlobalVectorArray_65(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector4> @values = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.GetGlobalVectorArray(@nameID, @values);

            return __ret;
        }

        static StackObject* GetGlobalMatrixArray_66(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> @values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.GetGlobalMatrixArray(@name, @values);

            return __ret;
        }

        static StackObject* GetGlobalMatrixArray_67(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> @values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.GetGlobalMatrixArray(@nameID, @values);

            return __ret;
        }





    }
}
#endif
