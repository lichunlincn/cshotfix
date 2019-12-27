
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
    unsafe class UnityEngine_TestTools_Coverage_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.TestTools.Coverage);
            args = new Type[]{};
            method = type.GetMethod("get_enabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_enabled_0);
            args = new Type[]{typeof(System.Reflection.MethodBase)};
            method = type.GetMethod("GetSequencePointsFor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSequencePointsFor_1);
            args = new Type[]{typeof(System.Reflection.MethodBase)};
            method = type.GetMethod("GetStatsFor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetStatsFor_2);
            args = new Type[]{typeof(System.Reflection.MethodBase[])};
            method = type.GetMethod("GetStatsFor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetStatsFor_3);
            args = new Type[]{typeof(System.Type)};
            method = type.GetMethod("GetStatsFor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetStatsFor_4);
            args = new Type[]{};
            method = type.GetMethod("GetStatsForAllCoveredMethods", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetStatsForAllCoveredMethods_5);
            args = new Type[]{typeof(System.Reflection.MethodBase)};
            method = type.GetMethod("ResetFor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetFor_6);
            args = new Type[]{};
            method = type.GetMethod("ResetAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetAll_7);





        }


        static StackObject* get_enabled_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.TestTools.Coverage.enabled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetSequencePointsFor_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Reflection.MethodBase @method = (System.Reflection.MethodBase)typeof(System.Reflection.MethodBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.TestTools.Coverage.GetSequencePointsFor(@method);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetStatsFor_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Reflection.MethodBase @method = (System.Reflection.MethodBase)typeof(System.Reflection.MethodBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.TestTools.Coverage.GetStatsFor(@method);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetStatsFor_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Reflection.MethodBase[] @methods = (System.Reflection.MethodBase[])typeof(System.Reflection.MethodBase[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.TestTools.Coverage.GetStatsFor(@methods);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetStatsFor_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @type = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.TestTools.Coverage.GetStatsFor(@type);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetStatsForAllCoveredMethods_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.TestTools.Coverage.GetStatsForAllCoveredMethods();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ResetFor_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Reflection.MethodBase @method = (System.Reflection.MethodBase)typeof(System.Reflection.MethodBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.TestTools.Coverage.ResetFor(@method);

            return __ret;
        }

        static StackObject* ResetAll_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.TestTools.Coverage.ResetAll();

            return __ret;
        }





    }
}
#endif
