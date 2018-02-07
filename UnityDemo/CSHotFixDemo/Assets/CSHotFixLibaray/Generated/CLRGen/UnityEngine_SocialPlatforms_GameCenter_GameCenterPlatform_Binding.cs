
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
    unsafe class UnityEngine_SocialPlatforms_GameCenter_GameCenterPlatform_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.SocialPlatforms.GameCenter.GameCenterPlatform);
            args = new Type[]{typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("ResetAllAchievements", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetAllAchievements_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("ShowDefaultAchievementCompletionBanner", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ShowDefaultAchievementCompletionBanner_1);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.SocialPlatforms.TimeScope)};
            method = type.GetMethod("ShowLeaderboardUI", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ShowLeaderboardUI_2);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.SocialPlatforms.GameCenter.GameCenterPlatform());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.SocialPlatforms.GameCenter.GameCenterPlatform[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* ResetAllAchievements_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> callback = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.SocialPlatforms.GameCenter.GameCenterPlatform.ResetAllAchievements(callback);

            return __ret;
        }

        static StackObject* ShowDefaultAchievementCompletionBanner_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;

            UnityEngine.SocialPlatforms.GameCenter.GameCenterPlatform.ShowDefaultAchievementCompletionBanner(value);

            return __ret;
        }

        static StackObject* ShowLeaderboardUI_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.TimeScope timeScope = (UnityEngine.SocialPlatforms.TimeScope)typeof(UnityEngine.SocialPlatforms.TimeScope).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String leaderboardID = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.SocialPlatforms.GameCenter.GameCenterPlatform.ShowLeaderboardUI(leaderboardID, timeScope);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.SocialPlatforms.GameCenter.GameCenterPlatform();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
