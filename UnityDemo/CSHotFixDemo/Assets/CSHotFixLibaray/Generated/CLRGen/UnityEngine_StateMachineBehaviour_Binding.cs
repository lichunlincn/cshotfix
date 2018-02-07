
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
    unsafe class UnityEngine_StateMachineBehaviour_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.StateMachineBehaviour);
            args = new Type[]{typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(System.Int32)};
            method = type.GetMethod("OnStateEnter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnStateEnter_0);
            args = new Type[]{typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(System.Int32)};
            method = type.GetMethod("OnStateUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnStateUpdate_1);
            args = new Type[]{typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(System.Int32)};
            method = type.GetMethod("OnStateExit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnStateExit_2);
            args = new Type[]{typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(System.Int32)};
            method = type.GetMethod("OnStateMove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnStateMove_3);
            args = new Type[]{typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(System.Int32)};
            method = type.GetMethod("OnStateIK", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnStateIK_4);
            args = new Type[]{typeof(UnityEngine.Animator), typeof(System.Int32)};
            method = type.GetMethod("OnStateMachineEnter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnStateMachineEnter_5);
            args = new Type[]{typeof(UnityEngine.Animator), typeof(System.Int32)};
            method = type.GetMethod("OnStateMachineExit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnStateMachineExit_6);
            args = new Type[]{typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(System.Int32), typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable)};
            method = type.GetMethod("OnStateEnter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnStateEnter_7);
            args = new Type[]{typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(System.Int32), typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable)};
            method = type.GetMethod("OnStateUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnStateUpdate_8);
            args = new Type[]{typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(System.Int32), typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable)};
            method = type.GetMethod("OnStateExit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnStateExit_9);
            args = new Type[]{typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(System.Int32), typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable)};
            method = type.GetMethod("OnStateMove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnStateMove_10);
            args = new Type[]{typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(System.Int32), typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable)};
            method = type.GetMethod("OnStateIK", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnStateIK_11);
            args = new Type[]{typeof(UnityEngine.Animator), typeof(System.Int32), typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable)};
            method = type.GetMethod("OnStateMachineEnter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnStateMachineEnter_12);
            args = new Type[]{typeof(UnityEngine.Animator), typeof(System.Int32), typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable)};
            method = type.GetMethod("OnStateMachineExit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnStateMachineExit_13);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.StateMachineBehaviour[s]);


        }


        static StackObject* OnStateEnter_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimatorStateInfo stateInfo = (UnityEngine.AnimatorStateInfo)typeof(UnityEngine.AnimatorStateInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator animator = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.StateMachineBehaviour instance_of_this_method;
            instance_of_this_method = (UnityEngine.StateMachineBehaviour)typeof(UnityEngine.StateMachineBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnStateEnter(animator, stateInfo, layerIndex);

            return __ret;
        }

        static StackObject* OnStateUpdate_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimatorStateInfo stateInfo = (UnityEngine.AnimatorStateInfo)typeof(UnityEngine.AnimatorStateInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator animator = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.StateMachineBehaviour instance_of_this_method;
            instance_of_this_method = (UnityEngine.StateMachineBehaviour)typeof(UnityEngine.StateMachineBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnStateUpdate(animator, stateInfo, layerIndex);

            return __ret;
        }

        static StackObject* OnStateExit_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimatorStateInfo stateInfo = (UnityEngine.AnimatorStateInfo)typeof(UnityEngine.AnimatorStateInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator animator = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.StateMachineBehaviour instance_of_this_method;
            instance_of_this_method = (UnityEngine.StateMachineBehaviour)typeof(UnityEngine.StateMachineBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnStateExit(animator, stateInfo, layerIndex);

            return __ret;
        }

        static StackObject* OnStateMove_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimatorStateInfo stateInfo = (UnityEngine.AnimatorStateInfo)typeof(UnityEngine.AnimatorStateInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator animator = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.StateMachineBehaviour instance_of_this_method;
            instance_of_this_method = (UnityEngine.StateMachineBehaviour)typeof(UnityEngine.StateMachineBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnStateMove(animator, stateInfo, layerIndex);

            return __ret;
        }

        static StackObject* OnStateIK_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimatorStateInfo stateInfo = (UnityEngine.AnimatorStateInfo)typeof(UnityEngine.AnimatorStateInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator animator = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.StateMachineBehaviour instance_of_this_method;
            instance_of_this_method = (UnityEngine.StateMachineBehaviour)typeof(UnityEngine.StateMachineBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnStateIK(animator, stateInfo, layerIndex);

            return __ret;
        }

        static StackObject* OnStateMachineEnter_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 stateMachinePathHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator animator = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.StateMachineBehaviour instance_of_this_method;
            instance_of_this_method = (UnityEngine.StateMachineBehaviour)typeof(UnityEngine.StateMachineBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnStateMachineEnter(animator, stateMachinePathHash);

            return __ret;
        }

        static StackObject* OnStateMachineExit_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 stateMachinePathHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Animator animator = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.StateMachineBehaviour instance_of_this_method;
            instance_of_this_method = (UnityEngine.StateMachineBehaviour)typeof(UnityEngine.StateMachineBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnStateMachineExit(animator, stateMachinePathHash);

            return __ret;
        }

        static StackObject* OnStateEnter_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.AnimatorControllerPlayable controller = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AnimatorStateInfo stateInfo = (UnityEngine.AnimatorStateInfo)typeof(UnityEngine.AnimatorStateInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Animator animator = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.StateMachineBehaviour instance_of_this_method;
            instance_of_this_method = (UnityEngine.StateMachineBehaviour)typeof(UnityEngine.StateMachineBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnStateEnter(animator, stateInfo, layerIndex, controller);

            return __ret;
        }

        static StackObject* OnStateUpdate_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.AnimatorControllerPlayable controller = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AnimatorStateInfo stateInfo = (UnityEngine.AnimatorStateInfo)typeof(UnityEngine.AnimatorStateInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Animator animator = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.StateMachineBehaviour instance_of_this_method;
            instance_of_this_method = (UnityEngine.StateMachineBehaviour)typeof(UnityEngine.StateMachineBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnStateUpdate(animator, stateInfo, layerIndex, controller);

            return __ret;
        }

        static StackObject* OnStateExit_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.AnimatorControllerPlayable controller = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AnimatorStateInfo stateInfo = (UnityEngine.AnimatorStateInfo)typeof(UnityEngine.AnimatorStateInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Animator animator = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.StateMachineBehaviour instance_of_this_method;
            instance_of_this_method = (UnityEngine.StateMachineBehaviour)typeof(UnityEngine.StateMachineBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnStateExit(animator, stateInfo, layerIndex, controller);

            return __ret;
        }

        static StackObject* OnStateMove_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.AnimatorControllerPlayable controller = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AnimatorStateInfo stateInfo = (UnityEngine.AnimatorStateInfo)typeof(UnityEngine.AnimatorStateInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Animator animator = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.StateMachineBehaviour instance_of_this_method;
            instance_of_this_method = (UnityEngine.StateMachineBehaviour)typeof(UnityEngine.StateMachineBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnStateMove(animator, stateInfo, layerIndex, controller);

            return __ret;
        }

        static StackObject* OnStateIK_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.AnimatorControllerPlayable controller = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AnimatorStateInfo stateInfo = (UnityEngine.AnimatorStateInfo)typeof(UnityEngine.AnimatorStateInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Animator animator = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.StateMachineBehaviour instance_of_this_method;
            instance_of_this_method = (UnityEngine.StateMachineBehaviour)typeof(UnityEngine.StateMachineBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnStateIK(animator, stateInfo, layerIndex, controller);

            return __ret;
        }

        static StackObject* OnStateMachineEnter_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.AnimatorControllerPlayable controller = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 stateMachinePathHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator animator = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.StateMachineBehaviour instance_of_this_method;
            instance_of_this_method = (UnityEngine.StateMachineBehaviour)typeof(UnityEngine.StateMachineBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnStateMachineEnter(animator, stateMachinePathHash, controller);

            return __ret;
        }

        static StackObject* OnStateMachineExit_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.AnimatorControllerPlayable controller = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 stateMachinePathHash = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Animator animator = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.StateMachineBehaviour instance_of_this_method;
            instance_of_this_method = (UnityEngine.StateMachineBehaviour)typeof(UnityEngine.StateMachineBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnStateMachineExit(animator, stateMachinePathHash, controller);

            return __ret;
        }





    }
}
