
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
    unsafe class UnityEngine_Experimental_Director_ScriptPlayable_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Experimental.Director.ScriptPlayable);
            args = new Type[]{};
            method = type.GetMethod("OnGraphStart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnGraphStart_0);
            args = new Type[]{};
            method = type.GetMethod("OnGraphStop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnGraphStop_1);
            args = new Type[]{};
            method = type.GetMethod("OnDestroy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnDestroy_2);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.FrameData)};
            method = type.GetMethod("PrepareFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PrepareFrame_3);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.FrameData), typeof(System.Object)};
            method = type.GetMethod("ProcessFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ProcessFrame_4);
            args = new Type[]{typeof(UnityEngine.Experimental.Director.FrameData), typeof(UnityEngine.Experimental.Director.PlayState)};
            method = type.GetMethod("OnPlayStateChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnPlayStateChanged_5);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Experimental.Director.ScriptPlayable[s]);


        }


        static StackObject* OnGraphStart_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.ScriptPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.ScriptPlayable)typeof(UnityEngine.Experimental.Director.ScriptPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnGraphStart();

            return __ret;
        }

        static StackObject* OnGraphStop_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.ScriptPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.ScriptPlayable)typeof(UnityEngine.Experimental.Director.ScriptPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnGraphStop();

            return __ret;
        }

        static StackObject* OnDestroy_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.ScriptPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.ScriptPlayable)typeof(UnityEngine.Experimental.Director.ScriptPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnDestroy();

            return __ret;
        }

        static StackObject* PrepareFrame_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.FrameData info = (UnityEngine.Experimental.Director.FrameData)typeof(UnityEngine.Experimental.Director.FrameData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.ScriptPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.ScriptPlayable)typeof(UnityEngine.Experimental.Director.ScriptPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PrepareFrame(info);

            return __ret;
        }

        static StackObject* ProcessFrame_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object playerData = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.FrameData info = (UnityEngine.Experimental.Director.FrameData)typeof(UnityEngine.Experimental.Director.FrameData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Experimental.Director.ScriptPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.ScriptPlayable)typeof(UnityEngine.Experimental.Director.ScriptPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ProcessFrame(info, playerData);

            return __ret;
        }

        static StackObject* OnPlayStateChanged_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Director.PlayState newState = (UnityEngine.Experimental.Director.PlayState)typeof(UnityEngine.Experimental.Director.PlayState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Director.FrameData info = (UnityEngine.Experimental.Director.FrameData)typeof(UnityEngine.Experimental.Director.FrameData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Experimental.Director.ScriptPlayable instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Director.ScriptPlayable)typeof(UnityEngine.Experimental.Director.ScriptPlayable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnPlayStateChanged(info, newState);

            return __ret;
        }





    }
}
