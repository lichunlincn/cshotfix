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
    unsafe class UnityEngine_Networking_ConnectionSimulatorConfig_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Networking.ConnectionSimulatorConfig);
            args = new Type[]{};
            method = type.GetMethod("Dispose", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Dispose_0);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Networking.ConnectionSimulatorConfig[s]);

            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Single)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Dispose_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.ConnectionSimulatorConfig instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.ConnectionSimulatorConfig)typeof(UnityEngine.Networking.ConnectionSimulatorConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Dispose();

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single packetLossPercentage = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 inAvgDelay = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 inMinDelay = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 outAvgDelay = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 outMinDelay = ptr_of_this_method->Value;

            var result_of_this_method = new UnityEngine.Networking.ConnectionSimulatorConfig(outMinDelay, outAvgDelay, inMinDelay, inAvgDelay, packetLossPercentage);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
