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
    unsafe class UnityEngine_ParticleSystem_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.ParticleSystem);
            args = new Type[]{};
            method = type.GetMethod("get_isPlaying", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isPlaying_0);
            args = new Type[]{};
            method = type.GetMethod("get_isEmitting", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isEmitting_1);
            args = new Type[]{};
            method = type.GetMethod("get_isStopped", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isStopped_2);
            args = new Type[]{};
            method = type.GetMethod("get_isPaused", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isPaused_3);
            args = new Type[]{};
            method = type.GetMethod("get_time", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_time_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_time", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_time_5);
            args = new Type[]{};
            method = type.GetMethod("get_particleCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_particleCount_6);
            args = new Type[]{};
            method = type.GetMethod("get_randomSeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_randomSeed_7);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("set_randomSeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_randomSeed_8);
            args = new Type[]{};
            method = type.GetMethod("get_useAutoRandomSeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useAutoRandomSeed_9);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_useAutoRandomSeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useAutoRandomSeed_10);
            args = new Type[]{};
            method = type.GetMethod("get_main", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_main_11);
            args = new Type[]{};
            method = type.GetMethod("get_emission", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_emission_12);
            args = new Type[]{};
            method = type.GetMethod("get_shape", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shape_13);
            args = new Type[]{};
            method = type.GetMethod("get_velocityOverLifetime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_velocityOverLifetime_14);
            args = new Type[]{};
            method = type.GetMethod("get_limitVelocityOverLifetime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_limitVelocityOverLifetime_15);
            args = new Type[]{};
            method = type.GetMethod("get_inheritVelocity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_inheritVelocity_16);
            args = new Type[]{};
            method = type.GetMethod("get_forceOverLifetime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_forceOverLifetime_17);
            args = new Type[]{};
            method = type.GetMethod("get_colorOverLifetime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_colorOverLifetime_18);
            args = new Type[]{};
            method = type.GetMethod("get_colorBySpeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_colorBySpeed_19);
            args = new Type[]{};
            method = type.GetMethod("get_sizeOverLifetime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sizeOverLifetime_20);
            args = new Type[]{};
            method = type.GetMethod("get_sizeBySpeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sizeBySpeed_21);
            args = new Type[]{};
            method = type.GetMethod("get_rotationOverLifetime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rotationOverLifetime_22);
            args = new Type[]{};
            method = type.GetMethod("get_rotationBySpeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rotationBySpeed_23);
            args = new Type[]{};
            method = type.GetMethod("get_externalForces", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_externalForces_24);
            args = new Type[]{};
            method = type.GetMethod("get_noise", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_noise_25);
            args = new Type[]{};
            method = type.GetMethod("get_collision", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_collision_26);
            args = new Type[]{};
            method = type.GetMethod("get_trigger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_trigger_27);
            args = new Type[]{};
            method = type.GetMethod("get_subEmitters", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_subEmitters_28);
            args = new Type[]{};
            method = type.GetMethod("get_textureSheetAnimation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_textureSheetAnimation_29);
            args = new Type[]{};
            method = type.GetMethod("get_lights", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lights_30);
            args = new Type[]{};
            method = type.GetMethod("get_trails", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_trails_31);
            args = new Type[]{};
            method = type.GetMethod("get_customData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_customData_32);
            args = new Type[]{typeof(UnityEngine.ParticleSystem.Particle[]), typeof(System.Int32)};
            method = type.GetMethod("SetParticles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetParticles_33);
            args = new Type[]{typeof(UnityEngine.ParticleSystem.Particle[])};
            method = type.GetMethod("GetParticles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetParticles_34);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Vector4>), typeof(UnityEngine.ParticleSystemCustomData)};
            method = type.GetMethod("SetCustomParticleData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetCustomParticleData_35);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Vector4>), typeof(UnityEngine.ParticleSystemCustomData)};
            method = type.GetMethod("GetCustomParticleData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCustomParticleData_36);
            args = new Type[]{typeof(System.Single), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("Simulate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Simulate_37);
            args = new Type[]{typeof(System.Single), typeof(System.Boolean)};
            method = type.GetMethod("Simulate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Simulate_38);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("Simulate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Simulate_39);
            args = new Type[]{typeof(System.Single), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("Simulate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Simulate_40);
            args = new Type[]{};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_41);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_42);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("Stop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Stop_43);
            args = new Type[]{};
            method = type.GetMethod("Stop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Stop_44);
            args = new Type[]{typeof(System.Boolean), typeof(UnityEngine.ParticleSystemStopBehavior)};
            method = type.GetMethod("Stop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Stop_45);
            args = new Type[]{};
            method = type.GetMethod("Pause", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Pause_46);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("Pause", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Pause_47);
            args = new Type[]{};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_48);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_49);
            args = new Type[]{};
            method = type.GetMethod("IsAlive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsAlive_50);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("IsAlive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsAlive_51);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("Emit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Emit_52);
            args = new Type[]{typeof(UnityEngine.ParticleSystem.EmitParams), typeof(System.Int32)};
            method = type.GetMethod("Emit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Emit_53);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ParticleSystem());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ParticleSystem[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_isPlaying_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isPlaying;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isEmitting_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isEmitting;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isStopped_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isStopped;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isPaused_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isPaused;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_time_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.time;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_time_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.time = value;

            return __ret;
        }

        static StackObject* get_particleCount_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.particleCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_randomSeed_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.randomSeed;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_randomSeed_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 value = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.randomSeed = value;

            return __ret;
        }

        static StackObject* get_useAutoRandomSeed_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useAutoRandomSeed;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useAutoRandomSeed_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useAutoRandomSeed = value;

            return __ret;
        }

        static StackObject* get_main_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.main;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_emission_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.emission;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_shape_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.shape;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_velocityOverLifetime_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.velocityOverLifetime;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_limitVelocityOverLifetime_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.limitVelocityOverLifetime;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_inheritVelocity_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.inheritVelocity;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_forceOverLifetime_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.forceOverLifetime;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_colorOverLifetime_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.colorOverLifetime;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_colorBySpeed_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.colorBySpeed;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_sizeOverLifetime_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sizeOverLifetime;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_sizeBySpeed_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sizeBySpeed;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_rotationOverLifetime_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rotationOverLifetime;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_rotationBySpeed_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rotationBySpeed;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_externalForces_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.externalForces;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_noise_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.noise;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_collision_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.collision;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_trigger_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.trigger;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_subEmitters_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.subEmitters;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_textureSheetAnimation_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.textureSheetAnimation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_lights_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lights;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_trails_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.trails;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_customData_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.customData;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetParticles_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 size = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystem.Particle[] particles = (UnityEngine.ParticleSystem.Particle[])typeof(UnityEngine.ParticleSystem.Particle[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetParticles(particles, size);

            return __ret;
        }

        static StackObject* GetParticles_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem.Particle[] particles = (UnityEngine.ParticleSystem.Particle[])typeof(UnityEngine.ParticleSystem.Particle[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetParticles(particles);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetCustomParticleData_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemCustomData streamIndex = (UnityEngine.ParticleSystemCustomData)typeof(UnityEngine.ParticleSystemCustomData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.Vector4> customData = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetCustomParticleData(customData, streamIndex);

            return __ret;
        }

        static StackObject* GetCustomParticleData_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemCustomData streamIndex = (UnityEngine.ParticleSystemCustomData)typeof(UnityEngine.ParticleSystemCustomData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.Vector4> customData = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCustomParticleData(customData, streamIndex);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Simulate_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean restart = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean withChildren = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single t = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Simulate(t, withChildren, restart);

            return __ret;
        }

        static StackObject* Simulate_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean withChildren = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single t = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Simulate(t, withChildren);

            return __ret;
        }

        static StackObject* Simulate_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single t = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Simulate(t);

            return __ret;
        }

        static StackObject* Simulate_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean fixedTimeStep = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean restart = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean withChildren = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single t = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Simulate(t, withChildren, restart, fixedTimeStep);

            return __ret;
        }

        static StackObject* Play_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play();

            return __ret;
        }

        static StackObject* Play_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean withChildren = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play(withChildren);

            return __ret;
        }

        static StackObject* Stop_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean withChildren = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Stop(withChildren);

            return __ret;
        }

        static StackObject* Stop_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Stop();

            return __ret;
        }

        static StackObject* Stop_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemStopBehavior stopBehavior = (UnityEngine.ParticleSystemStopBehavior)typeof(UnityEngine.ParticleSystemStopBehavior).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean withChildren = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Stop(withChildren, stopBehavior);

            return __ret;
        }

        static StackObject* Pause_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Pause();

            return __ret;
        }

        static StackObject* Pause_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean withChildren = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Pause(withChildren);

            return __ret;
        }

        static StackObject* Clear_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clear();

            return __ret;
        }

        static StackObject* Clear_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean withChildren = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clear(withChildren);

            return __ret;
        }

        static StackObject* IsAlive_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsAlive();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsAlive_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean withChildren = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsAlive(withChildren);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Emit_52(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Emit(count);

            return __ret;
        }

        static StackObject* Emit_53(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystem.EmitParams emitParams = (UnityEngine.ParticleSystem.EmitParams)typeof(UnityEngine.ParticleSystem.EmitParams).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ParticleSystem instance_of_this_method;
            instance_of_this_method = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Emit(emitParams, count);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.ParticleSystem();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
