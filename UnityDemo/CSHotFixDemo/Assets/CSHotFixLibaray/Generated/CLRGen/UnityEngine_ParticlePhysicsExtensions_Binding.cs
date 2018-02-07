
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
    unsafe class UnityEngine_ParticlePhysicsExtensions_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ParticlePhysicsExtensions);
            args = new Type[]{typeof(UnityEngine.ParticleSystem)};
            method = type.GetMethod("GetSafeCollisionEventSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSafeCollisionEventSize_0);
            args = new Type[]{typeof(UnityEngine.ParticleSystem), typeof(UnityEngine.GameObject), typeof(System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent>)};
            method = type.GetMethod("GetCollisionEvents", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCollisionEvents_1);
            args = new Type[]{typeof(UnityEngine.ParticleSystem), typeof(UnityEngine.ParticleSystemTriggerEventType)};
            method = type.GetMethod("GetSafeTriggerParticlesSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSafeTriggerParticlesSize_2);
            args = new Type[]{typeof(UnityEngine.ParticleSystem), typeof(UnityEngine.ParticleSystemTriggerEventType), typeof(System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle>)};
            method = type.GetMethod("GetTriggerParticles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTriggerParticles_3);
            args = new Type[]{typeof(UnityEngine.ParticleSystem), typeof(UnityEngine.ParticleSystemTriggerEventType), typeof(System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle>), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetTriggerParticles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTriggerParticles_4);
            args = new Type[]{typeof(UnityEngine.ParticleSystem), typeof(UnityEngine.ParticleSystemTriggerEventType), typeof(System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle>)};
            method = type.GetMethod("SetTriggerParticles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTriggerParticles_5);





        }


        static StackObject* GetSafeCollisionEventSize_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystem ps = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.ParticlePhysicsExtensions.GetSafeCollisionEventSize(ps);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetCollisionEvents_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent> collisionEvents = (System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent>)typeof(System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GameObject go = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ParticleSystem ps = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.ParticlePhysicsExtensions.GetCollisionEvents(ps, go, collisionEvents);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetSafeTriggerParticlesSize_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ParticleSystemTriggerEventType type = (UnityEngine.ParticleSystemTriggerEventType)typeof(UnityEngine.ParticleSystemTriggerEventType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystem ps = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.ParticlePhysicsExtensions.GetSafeTriggerParticlesSize(ps, type);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetTriggerParticles_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles = (System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle>)typeof(System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystemTriggerEventType type = (UnityEngine.ParticleSystemTriggerEventType)typeof(UnityEngine.ParticleSystemTriggerEventType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ParticleSystem ps = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.ParticlePhysicsExtensions.GetTriggerParticles(ps, type, particles);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetTriggerParticles_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 offset = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles = (System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle>)typeof(System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.ParticleSystemTriggerEventType type = (UnityEngine.ParticleSystemTriggerEventType)typeof(UnityEngine.ParticleSystemTriggerEventType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.ParticleSystem ps = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.ParticlePhysicsExtensions.SetTriggerParticles(ps, type, particles, offset, count);

            return __ret;
        }

        static StackObject* SetTriggerParticles_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles = (System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle>)typeof(System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ParticleSystemTriggerEventType type = (UnityEngine.ParticleSystemTriggerEventType)typeof(UnityEngine.ParticleSystemTriggerEventType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ParticleSystem ps = (UnityEngine.ParticleSystem)typeof(UnityEngine.ParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.ParticlePhysicsExtensions.SetTriggerParticles(ps, type, particles);

            return __ret;
        }





    }
}
