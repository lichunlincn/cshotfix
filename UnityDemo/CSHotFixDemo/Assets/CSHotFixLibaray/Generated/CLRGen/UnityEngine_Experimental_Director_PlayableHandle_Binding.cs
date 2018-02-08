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
    unsafe class UnityEngine_Experimental_Director_PlayableHandle_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Experimental.Director.PlayableHandle);
            args = new Type[]{};
            method = type.GetMethod("GetObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetObject_0);
            args = new Type[]{};
            method = type.GetMethod("IsValid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsValid_1);
            args = new Type[]{};
            method = type.GetMethod("get_Null", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Null_2);
            args = new Type[]{};
            method = type.GetMethod("get_graph", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_graph_3);
            args = new Type[]{};
            method = type.GetMethod("get_inputCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_inputCount_4);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_inputCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_inputCount_5);
            args = new Type[]{};
            method = type.GetMethod("get_outputCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_outputCount_6);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_outputCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_outputCount_7);
            args = new Type[]{};
            method = type.GetMethod("get_playState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playState_8);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.PlayState)};
            method = type.GetMethod("set_playState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_playState_9);
            args = new Type[]{};
            method = type.GetMethod("get_speed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_speed_10);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("set_speed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_speed_11);
            args = new Type[]{};
            method = type.GetMethod("get_time", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_time_12);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("set_time", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_time_13);
            args = new Type[]{};
            method = type.GetMethod("get_isDone", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isDone_14);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_isDone", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_isDone_15);
            args = new Type[]{};
            method = type.GetMethod("get_duration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_duration_16);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("set_duration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_duration_17);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetInput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetInput_18);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetOutput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetOutput_19);
            args = new Type[]{typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("SetInputWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetInputWeight_20);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetInputWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetInputWeight_21);
            args = new Type[]{};
            method = type.GetMethod("Destroy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Destroy_22);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.PlayableHandle), typeof(UnityEngine.Experimental.Director.PlayableHandle)};
            method = type.GetMethod("op_Equality", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, op_Equality_23);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.PlayableHandle), typeof(UnityEngine.Experimental.Director.PlayableHandle)};
            method = type.GetMethod("op_Inequality", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, op_Inequality_24);
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("Equals", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Equals_25);
            args = new Type[]{};
            method = type.GetMethod("GetHashCode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetHashCode_26);


            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Experimental.Director.PlayableHandle());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Experimental.Director.PlayableHandle[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Experimental.Director.PlayableHandle[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* GetObject_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.GetObject();

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* IsValid_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.IsValid();

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_Null_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Experimental.Director.PlayableHandle.Null;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_graph_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.graph;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_inputCount_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.inputCount;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_inputCount_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.inputCount = value;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* get_outputCount_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.outputCount;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_outputCount_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.outputCount = value;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* get_playState_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.playState;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_playState_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.PlayState value = (UnityEngine.Experimental.Director.PlayState)typeof(UnityEngine.Experimental.Director.PlayState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.playState = value;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* get_speed_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.speed;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_speed_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double value = *(double*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.speed = value;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* get_time_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.time;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_time_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double value = *(double*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.time = value;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* get_isDone_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.isDone;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_isDone_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.isDone = value;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* get_duration_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.duration;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_duration_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double value = *(double*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.duration = value;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* GetInput_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 inputPort = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.GetInput(inputPort);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetOutput_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 outputPort = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.GetOutput(outputPort);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetInputWeight_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single weight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 inputIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.SetInputWeight(inputIndex, weight);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetInputWeight_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 inputIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.GetInputWeight(inputIndex);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Destroy_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.Destroy();

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* op_Equality_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.PlayableHandle y = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.PlayableHandle x = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = x == y;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* op_Inequality_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.PlayableHandle y = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.PlayableHandle x = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = x != y;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Equals_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object p = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.Equals(p);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetHashCode_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Director.PlayableHandle instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.PlayableHandle)typeof(UnityEngine.Experimental.Director.PlayableHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.GetHashCode();

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }



        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Experimental.Director.PlayableHandle();
            ins = (UnityEngine.Experimental.Director.PlayableHandle)o;
            return ins;
        }


    }
}
