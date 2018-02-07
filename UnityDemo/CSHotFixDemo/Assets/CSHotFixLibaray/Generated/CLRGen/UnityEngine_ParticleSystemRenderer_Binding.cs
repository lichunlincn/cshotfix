
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
    unsafe class UnityEngine_ParticleSystemRenderer_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ParticleSystemRenderer);
            args = new Type[]{};
            method = type.GetMethod("get_renderMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_renderMode_0);
            args = new Type[]{typeof(UnityEngine.ParticleSystemRenderMode)};
            method = type.GetMethod("set_renderMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_renderMode_1);
            args = new Type[]{};
            method = type.GetMethod("get_lengthScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lengthScale_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_lengthScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lengthScale_3);
            args = new Type[]{};
            method = type.GetMethod("get_velocityScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_velocityScale_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_velocityScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_velocityScale_5);
            args = new Type[]{};
            method = type.GetMethod("get_cameraVelocityScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cameraVelocityScale_6);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_cameraVelocityScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_cameraVelocityScale_7);
            args = new Type[]{};
            method = type.GetMethod("get_normalDirection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_normalDirection_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_normalDirection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_normalDirection_9);
            args = new Type[]{};
            method = type.GetMethod("get_alignment", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_alignment_10);
            args = new Type[]{typeof(UnityEngine.ParticleSystemRenderSpace)};
            method = type.GetMethod("set_alignment", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_alignment_11);
            args = new Type[]{};
            method = type.GetMethod("get_pivot", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pivot_12);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_pivot", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_pivot_13);
            args = new Type[]{};
            method = type.GetMethod("get_sortMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sortMode_14);
            args = new Type[]{typeof(UnityEngine.ParticleSystemSortMode)};
            method = type.GetMethod("set_sortMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sortMode_15);
            args = new Type[]{};
            method = type.GetMethod("get_sortingFudge", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sortingFudge_16);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_sortingFudge", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sortingFudge_17);
            args = new Type[]{};
            method = type.GetMethod("get_minParticleSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_minParticleSize_18);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_minParticleSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_minParticleSize_19);
            args = new Type[]{};
            method = type.GetMethod("get_maxParticleSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxParticleSize_20);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_maxParticleSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxParticleSize_21);
            args = new Type[]{};
            method = type.GetMethod("get_mesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mesh_22);
            args = new Type[]{typeof(UnityEngine.Mesh)};
            method = type.GetMethod("set_mesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_mesh_23);
            args = new Type[]{};
            method = type.GetMethod("get_meshCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_meshCount_24);
            args = new Type[]{typeof(UnityEngine.Mesh[])};
            method = type.GetMethod("GetMeshes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetMeshes_25);
            args = new Type[]{typeof(UnityEngine.Mesh[])};
            method = type.GetMethod("SetMeshes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetMeshes_26);
            args = new Type[]{typeof(UnityEngine.Mesh[]), typeof(System.Int32)};
            method = type.GetMethod("SetMeshes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetMeshes_27);
            args = new Type[]{};
            method = type.GetMethod("get_trailMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_trailMaterial_28);
            args = new Type[]{typeof(UnityEngine.Material)};
            method = type.GetMethod("set_trailMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_trailMaterial_29);
            args = new Type[]{};
            method = type.GetMethod("get_activeVertexStreamsCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_activeVertexStreamsCount_30);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream>)};
            method = type.GetMethod("SetActiveVertexStreams", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetActiveVertexStreams_31);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream>)};
            method = type.GetMethod("GetActiveVertexStreams", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetActiveVertexStreams_32);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ParticleSystemRenderer());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ParticleSystemRenderer[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_renderMode_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.renderMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_renderMode_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemRenderMode value = (UnityEngine.ParticleSystemRenderMode)typeof(UnityEngine.ParticleSystemRenderMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.renderMode = value;

            return __ret;
        }

        static StackObject* get_lengthScale_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lengthScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_lengthScale_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.lengthScale = value;

            return __ret;
        }

        static StackObject* get_velocityScale_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.velocityScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_velocityScale_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.velocityScale = value;

            return __ret;
        }

        static StackObject* get_cameraVelocityScale_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.cameraVelocityScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_cameraVelocityScale_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.cameraVelocityScale = value;

            return __ret;
        }

        static StackObject* get_normalDirection_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.normalDirection;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_normalDirection_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.normalDirection = value;

            return __ret;
        }

        static StackObject* get_alignment_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
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
            UnityEngine.ParticleSystemRenderSpace value = (UnityEngine.ParticleSystemRenderSpace)typeof(UnityEngine.ParticleSystemRenderSpace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.alignment = value;

            return __ret;
        }

        static StackObject* get_pivot_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.pivot;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_pivot_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.pivot = value;

            return __ret;
        }

        static StackObject* get_sortMode_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sortMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_sortMode_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemSortMode value = (UnityEngine.ParticleSystemSortMode)typeof(UnityEngine.ParticleSystemSortMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.sortMode = value;

            return __ret;
        }

        static StackObject* get_sortingFudge_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sortingFudge;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_sortingFudge_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.sortingFudge = value;

            return __ret;
        }

        static StackObject* get_minParticleSize_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.minParticleSize;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_minParticleSize_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.minParticleSize = value;

            return __ret;
        }

        static StackObject* get_maxParticleSize_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxParticleSize;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxParticleSize_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maxParticleSize = value;

            return __ret;
        }

        static StackObject* get_mesh_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.mesh;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_mesh_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh value = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.mesh = value;

            return __ret;
        }

        static StackObject* get_meshCount_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.meshCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetMeshes_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh[] meshes = (UnityEngine.Mesh[])typeof(UnityEngine.Mesh[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetMeshes(meshes);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetMeshes_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh[] meshes = (UnityEngine.Mesh[])typeof(UnityEngine.Mesh[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetMeshes(meshes);

            return __ret;
        }

        static StackObject* SetMeshes_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 size = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh[] meshes = (UnityEngine.Mesh[])typeof(UnityEngine.Mesh[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetMeshes(meshes, size);

            return __ret;
        }

        static StackObject* get_trailMaterial_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.trailMaterial;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_trailMaterial_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material value = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.trailMaterial = value;

            return __ret;
        }

        static StackObject* get_activeVertexStreamsCount_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.activeVertexStreamsCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetActiveVertexStreams_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams = (System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream>)typeof(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetActiveVertexStreams(streams);

            return __ret;
        }

        static StackObject* GetActiveVertexStreams_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams = (System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream>)typeof(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystemRenderer instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystemRenderer)typeof(UnityEngine.ParticleSystemRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetActiveVertexStreams(streams);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.ParticleSystemRenderer();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
