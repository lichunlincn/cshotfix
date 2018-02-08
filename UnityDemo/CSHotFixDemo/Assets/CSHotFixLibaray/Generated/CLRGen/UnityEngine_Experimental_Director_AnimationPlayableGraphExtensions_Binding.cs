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
    unsafe class UnityEngine_Experimental_Director_AnimationPlayableGraphExtensions_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.PlayableGraph), typeof(System.String), typeof(UnityEngine.Animator)};
            method = type.GetMethod("CreateAnimationOutput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateAnimationOutput_0);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.PlayableGraph), typeof(UnityEngine.AnimationClip)};
            method = type.GetMethod("CreateAnimationClipPlayable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateAnimationClipPlayable_1);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.PlayableGraph), typeof(System.Int32)};
            method = type.GetMethod("CreateAnimationMixerPlayable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateAnimationMixerPlayable_2);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.PlayableGraph)};
            method = type.GetMethod("CreateAnimationMixerPlayable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateAnimationMixerPlayable_3);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.PlayableGraph), typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("CreateAnimationMixerPlayable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateAnimationMixerPlayable_4);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.PlayableGraph), typeof(UnityEngine.RuntimeAnimatorController)};
            method = type.GetMethod("CreateAnimatorControllerPlayable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateAnimatorControllerPlayable_5);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.PlayableGraph), typeof(UnityEngine.Experimental.Director.AnimationPlayableOutput)};
            method = type.GetMethod("DestroyOutput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DestroyOutput_6);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.PlayableGraph)};
            method = type.GetMethod("GetAnimationOutputCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAnimationOutputCount_7);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.PlayableGraph), typeof(System.Int32)};
            method = type.GetMethod("GetAnimationOutput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAnimationOutput_8);





        }


        static StackObject* CreateAnimationOutput_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Animator target = (UnityEngine.Animator)typeof(UnityEngine.Animator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Experimental.Director.PlayableGraph graph = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions.CreateAnimationOutput(graph, name, target);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateAnimationClipPlayable_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnimationClip clip = (UnityEngine.AnimationClip)typeof(UnityEngine.AnimationClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.PlayableGraph graph = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions.CreateAnimationClipPlayable(graph, clip);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateAnimationMixerPlayable_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 inputCount = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.PlayableGraph graph = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions.CreateAnimationMixerPlayable(graph, inputCount);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateAnimationMixerPlayable_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.PlayableGraph graph = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions.CreateAnimationMixerPlayable(graph);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateAnimationMixerPlayable_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean normalizeWeights = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 inputCount = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Experimental.Director.PlayableGraph graph = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions.CreateAnimationMixerPlayable(graph, inputCount, normalizeWeights);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateAnimatorControllerPlayable_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RuntimeAnimatorController controller = (UnityEngine.RuntimeAnimatorController)typeof(UnityEngine.RuntimeAnimatorController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.PlayableGraph graph = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions.CreateAnimatorControllerPlayable(graph, controller);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* DestroyOutput_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.AnimationPlayableOutput output = (UnityEngine.Experimental.Director.AnimationPlayableOutput)typeof(UnityEngine.Experimental.Director.AnimationPlayableOutput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.PlayableGraph graph = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions.DestroyOutput(graph, output);

            return __ret;
        }

        static StackObject* GetAnimationOutputCount_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.PlayableGraph graph = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions.GetAnimationOutputCount(graph);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetAnimationOutput_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.PlayableGraph graph = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.Experimental.Director.AnimationPlayableGraphExtensions.GetAnimationOutput(graph, index);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}
