
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
    unsafe class UnityEngine_UISystemProfilerApi_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.UISystemProfilerApi);
            args = new Type[]{typeof(UnityEngine.UISystemProfilerApi.SampleType)};
            method = type.GetMethod("BeginSample", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeginSample_0);
            args = new Type[]{typeof(UnityEngine.UISystemProfilerApi.SampleType)};
            method = type.GetMethod("EndSample", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EndSample_1);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Object)};
            method = type.GetMethod("AddMarker", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddMarker_2);





        }


        static StackObject* BeginSample_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.UISystemProfilerApi.SampleType @type = (UnityEngine.UISystemProfilerApi.SampleType)typeof(UnityEngine.UISystemProfilerApi.SampleType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.UISystemProfilerApi.BeginSample(@type);

            return __ret;
        }

        static StackObject* EndSample_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.UISystemProfilerApi.SampleType @type = (UnityEngine.UISystemProfilerApi.SampleType)typeof(UnityEngine.UISystemProfilerApi.SampleType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.UISystemProfilerApi.EndSample(@type);

            return __ret;
        }

        static StackObject* AddMarker_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Object @obj = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.UISystemProfilerApi.AddMarker(@name, @obj);

            return __ret;
        }





    }
}
#endif
