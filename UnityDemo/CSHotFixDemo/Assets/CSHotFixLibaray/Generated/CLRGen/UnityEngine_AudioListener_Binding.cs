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
    unsafe class UnityEngine_AudioListener_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.AudioListener);
            args = new Type[]{};
            method = type.GetMethod("get_volume", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_volume_0);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_volume", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_volume_1);
            args = new Type[]{};
            method = type.GetMethod("get_pause", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pause_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_pause", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_pause_3);
            args = new Type[]{};
            method = type.GetMethod("get_velocityUpdateMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_velocityUpdateMode_4);
            args = new Type[]{typeof(UnityEngine.AudioVelocityUpdateMode)};
            method = type.GetMethod("set_velocityUpdateMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_velocityUpdateMode_5);
            args = new Type[]{typeof(System.Single[]), typeof(System.Int32)};
            method = type.GetMethod("GetOutputData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetOutputData_6);
            args = new Type[]{typeof(System.Single[]), typeof(System.Int32), typeof(UnityEngine.FFTWindow)};
            method = type.GetMethod("GetSpectrumData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSpectrumData_7);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.AudioListener());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AudioListener[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_volume_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.AudioListener.volume;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_volume_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;

            UnityEngine.AudioListener.volume = value;

            return __ret;
        }

        static StackObject* get_pause_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.AudioListener.pause;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_pause_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;

            UnityEngine.AudioListener.pause = value;

            return __ret;
        }

        static StackObject* get_velocityUpdateMode_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioListener instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioListener)typeof(UnityEngine.AudioListener).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.velocityUpdateMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_velocityUpdateMode_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioVelocityUpdateMode value = (UnityEngine.AudioVelocityUpdateMode)typeof(UnityEngine.AudioVelocityUpdateMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioListener instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioListener)typeof(UnityEngine.AudioListener).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.velocityUpdateMode = value;

            return __ret;
        }

        static StackObject* GetOutputData_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 channel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single[] samples = (System.Single[])typeof(System.Single[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.AudioListener.GetOutputData(samples, channel);

            return __ret;
        }

        static StackObject* GetSpectrumData_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.FFTWindow window = (UnityEngine.FFTWindow)typeof(UnityEngine.FFTWindow).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 channel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single[] samples = (System.Single[])typeof(System.Single[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.AudioListener.GetSpectrumData(samples, channel, window);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.AudioListener();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
