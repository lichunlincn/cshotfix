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
    unsafe class UnityEngine_Experimental_Director_PlayableGraph_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Experimental.Director.PlayableGraph);
            args = new Type[]{};
            method = type.GetMethod("IsValid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsValid_0);
            args = new Type[]{};
            method = type.GetMethod("CreateGraph", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateGraph_1);
            args = new Type[]{};
            method = type.GetMethod("get_isDone", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isDone_2);
            args = new Type[]{};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_3);
            args = new Type[]{};
            method = type.GetMethod("Stop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Stop_4);
            args = new Type[]{};
            method = type.GetMethod("get_playableCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playableCount_5);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("CreateScriptOutput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateScriptOutput_6);
            args = new Type[]{};
            method = type.GetMethod("get_scriptOutputCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_scriptOutputCount_7);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetScriptOutput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetScriptOutput_8);
            args = new Type[]{};
            method = type.GetMethod("CreatePlayable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreatePlayable_9);
            args = new Type[]{};
            method = type.GetMethod("CreateGenericMixerPlayable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateGenericMixerPlayable_10);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("CreateGenericMixerPlayable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateGenericMixerPlayable_11);
            args = new Type[]{};
            method = type.GetMethod("Destroy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Destroy_12);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.PlayableHandle), typeof(System.Int32), typeof(UnityEngine.Experimental.Director.PlayableHandle), typeof(System.Int32)};
            method = type.GetMethod("Connect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Connect_13);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.Playable), typeof(System.Int32), typeof(UnityEngine.Experimental.Director.Playable), typeof(System.Int32)};
            method = type.GetMethod("Connect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Connect_14);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.Playable), typeof(System.Int32)};
            method = type.GetMethod("Disconnect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Disconnect_15);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.PlayableHandle), typeof(System.Int32)};
            method = type.GetMethod("Disconnect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Disconnect_16);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.PlayableHandle)};
            method = type.GetMethod("DestroyPlayable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DestroyPlayable_17);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.ScriptPlayableOutput)};
            method = type.GetMethod("DestroyOutput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DestroyOutput_18);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.PlayableHandle)};
            method = type.GetMethod("DestroySubgraph", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DestroySubgraph_19);
            args = new Type[]{};
            method = type.GetMethod("Evaluate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Evaluate_20);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("Evaluate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Evaluate_21);
            args = new Type[]{};
            method = type.GetMethod("get_rootPlayableCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rootPlayableCount_22);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetRootPlayable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRootPlayable_23);


            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Experimental.Director.PlayableGraph());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Experimental.Director.PlayableGraph[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Experimental.Director.PlayableGraph[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* IsValid_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.IsValid();

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CreateGraph_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Experimental.Director.PlayableGraph.CreateGraph();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_isDone_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.isDone;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Play_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.Play();

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* Stop_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.Stop();

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* get_playableCount_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.playableCount;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CreateScriptOutput_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.CreateScriptOutput(name);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_scriptOutputCount_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.scriptOutputCount;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetScriptOutput_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.GetScriptOutput(index);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreatePlayable_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.CreatePlayable();

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateGenericMixerPlayable_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.CreateGenericMixerPlayable();

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateGenericMixerPlayable_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 inputCount = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.CreateGenericMixerPlayable(inputCount);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Destroy_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.Destroy();

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* Connect_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 destinationInputPort = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.PlayableHandle destination = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 sourceOutputPort = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Experimental.Director.PlayableHandle source = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.Connect(source, sourceOutputPort, destination, destinationInputPort);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Connect_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 destinationInputPort = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.Playable destination = (UnityEngine.Experimental.Director.Playable)typeof(UnityEngine.Experimental.Director.Playable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 sourceOutputPort = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Experimental.Director.Playable source = (UnityEngine.Experimental.Director.Playable)typeof(UnityEngine.Experimental.Director.Playable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.Connect(source, sourceOutputPort, destination, destinationInputPort);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Disconnect_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 inputPort = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.Playable playable = (UnityEngine.Experimental.Director.Playable)typeof(UnityEngine.Experimental.Director.Playable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.Disconnect(playable, inputPort);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* Disconnect_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 inputPort = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.PlayableHandle playable = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.Disconnect(playable, inputPort);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* DestroyPlayable_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.PlayableHandle playable = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.DestroyPlayable(playable);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* DestroyOutput_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.ScriptPlayableOutput output = (UnityEngine.Experimental.Director.ScriptPlayableOutput)typeof(UnityEngine.Experimental.Director.ScriptPlayableOutput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.DestroyOutput(output);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* DestroySubgraph_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.PlayableHandle playable = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.DestroySubgraph(playable);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* Evaluate_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.Evaluate();

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* Evaluate_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single deltaTime = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.Evaluate(deltaTime);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* get_rootPlayableCount_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.rootPlayableCount;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetRootPlayable_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableGraph instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableGraph)typeof(UnityEngine.Experimental.Director.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.GetRootPlayable(index);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Experimental.Director.PlayableGraph();
            ins = (UnityEngine.Experimental.Director.PlayableGraph)o;
            return ins;
        }


    }
}
