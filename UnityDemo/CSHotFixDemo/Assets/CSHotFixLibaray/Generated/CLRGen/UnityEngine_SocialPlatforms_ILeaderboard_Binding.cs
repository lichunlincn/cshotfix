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
    unsafe class UnityEngine_SocialPlatforms_ILeaderboard_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.SocialPlatforms.ILeaderboard);
            args = new Type[]{typeof(System.String[])};
            method = type.GetMethod("SetUserFilter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetUserFilter_0);
            args = new Type[]{typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("LoadScores", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadScores_1);
            args = new Type[]{};
            method = type.GetMethod("get_loading", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_loading_2);
            args = new Type[]{};
            method = type.GetMethod("get_id", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_id_3);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_id", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_id_4);
            args = new Type[]{};
            method = type.GetMethod("get_userScope", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_userScope_5);
            args = new Type[]{typeof(UnityEngine.SocialPlatforms.UserScope)};
            method = type.GetMethod("set_userScope", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_userScope_6);
            args = new Type[]{};
            method = type.GetMethod("get_range", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_range_7);
            args = new Type[]{typeof(UnityEngine.SocialPlatforms.Range)};
            method = type.GetMethod("set_range", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_range_8);
            args = new Type[]{};
            method = type.GetMethod("get_timeScope", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_timeScope_9);
            args = new Type[]{typeof(UnityEngine.SocialPlatforms.TimeScope)};
            method = type.GetMethod("set_timeScope", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_timeScope_10);
            args = new Type[]{};
            method = type.GetMethod("get_localUserScore", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_localUserScore_11);
            args = new Type[]{};
            method = type.GetMethod("get_maxRange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxRange_12);
            args = new Type[]{};
            method = type.GetMethod("get_scores", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_scores_13);
            args = new Type[]{};
            method = type.GetMethod("get_title", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_title_14);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.SocialPlatforms.ILeaderboard[s]);


        }


        static StackObject* SetUserFilter_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String[] userIDs = (System.String[])typeof(System.String[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.ILeaderboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILeaderboard)typeof(UnityEngine.SocialPlatforms.ILeaderboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetUserFilter(userIDs);

            return __ret;
        }

        static StackObject* LoadScores_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> callback = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.ILeaderboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILeaderboard)typeof(UnityEngine.SocialPlatforms.ILeaderboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LoadScores(callback);

            return __ret;
        }

        static StackObject* get_loading_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.ILeaderboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILeaderboard)typeof(UnityEngine.SocialPlatforms.ILeaderboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.loading;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_id_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.ILeaderboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILeaderboard)typeof(UnityEngine.SocialPlatforms.ILeaderboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.id;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_id_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.ILeaderboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILeaderboard)typeof(UnityEngine.SocialPlatforms.ILeaderboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.id = value;

            return __ret;
        }

        static StackObject* get_userScope_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.ILeaderboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILeaderboard)typeof(UnityEngine.SocialPlatforms.ILeaderboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.userScope;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_userScope_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.UserScope value = (UnityEngine.SocialPlatforms.UserScope)typeof(UnityEngine.SocialPlatforms.UserScope).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.ILeaderboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILeaderboard)typeof(UnityEngine.SocialPlatforms.ILeaderboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.userScope = value;

            return __ret;
        }

        static StackObject* get_range_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.ILeaderboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILeaderboard)typeof(UnityEngine.SocialPlatforms.ILeaderboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.range;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_range_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.Range value = (UnityEngine.SocialPlatforms.Range)typeof(UnityEngine.SocialPlatforms.Range).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.ILeaderboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILeaderboard)typeof(UnityEngine.SocialPlatforms.ILeaderboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.range = value;

            return __ret;
        }

        static StackObject* get_timeScope_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.ILeaderboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILeaderboard)typeof(UnityEngine.SocialPlatforms.ILeaderboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.timeScope;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_timeScope_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.TimeScope value = (UnityEngine.SocialPlatforms.TimeScope)typeof(UnityEngine.SocialPlatforms.TimeScope).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.ILeaderboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILeaderboard)typeof(UnityEngine.SocialPlatforms.ILeaderboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.timeScope = value;

            return __ret;
        }

        static StackObject* get_localUserScore_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.ILeaderboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILeaderboard)typeof(UnityEngine.SocialPlatforms.ILeaderboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.localUserScore;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_maxRange_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.ILeaderboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILeaderboard)typeof(UnityEngine.SocialPlatforms.ILeaderboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxRange;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_scores_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.ILeaderboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILeaderboard)typeof(UnityEngine.SocialPlatforms.ILeaderboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.scores;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_title_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.ILeaderboard instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILeaderboard)typeof(UnityEngine.SocialPlatforms.ILeaderboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.title;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}
