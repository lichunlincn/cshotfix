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
    unsafe class UnityEngine_SocialPlatforms_IScore_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.SocialPlatforms.IScore);
            args = new Type[]{typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("ReportScore", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReportScore_0);
            args = new Type[]{};
            method = type.GetMethod("get_leaderboardID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_leaderboardID_1);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_leaderboardID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_leaderboardID_2);
            args = new Type[]{};
            method = type.GetMethod("get_value", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_value_3);
            args = new Type[]{typeof(System.Int64)};
            method = type.GetMethod("set_value", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_value_4);
            args = new Type[]{};
            method = type.GetMethod("get_date", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_date_5);
            args = new Type[]{};
            method = type.GetMethod("get_formattedValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_formattedValue_6);
            args = new Type[]{};
            method = type.GetMethod("get_userID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_userID_7);
            args = new Type[]{};
            method = type.GetMethod("get_rank", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rank_8);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.SocialPlatforms.IScore[s]);


        }


        static StackObject* ReportScore_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> callback = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.IScore instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.IScore)typeof(UnityEngine.SocialPlatforms.IScore).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ReportScore(callback);

            return __ret;
        }

        static StackObject* get_leaderboardID_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.IScore instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.IScore)typeof(UnityEngine.SocialPlatforms.IScore).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.leaderboardID;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_leaderboardID_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.IScore instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.IScore)typeof(UnityEngine.SocialPlatforms.IScore).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.leaderboardID = value;

            return __ret;
        }

        static StackObject* get_value_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.IScore instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.IScore)typeof(UnityEngine.SocialPlatforms.IScore).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.value;

            __ret->ObjectType = ObjectTypes.Long;
            *(long*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_value_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int64 value = *(long*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.IScore instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.IScore)typeof(UnityEngine.SocialPlatforms.IScore).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.value = value;

            return __ret;
        }

        static StackObject* get_date_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.IScore instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.IScore)typeof(UnityEngine.SocialPlatforms.IScore).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.date;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_formattedValue_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.IScore instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.IScore)typeof(UnityEngine.SocialPlatforms.IScore).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.formattedValue;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_userID_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.IScore instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.IScore)typeof(UnityEngine.SocialPlatforms.IScore).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.userID;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_rank_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.IScore instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.IScore)typeof(UnityEngine.SocialPlatforms.IScore).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rank;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }





    }
}
