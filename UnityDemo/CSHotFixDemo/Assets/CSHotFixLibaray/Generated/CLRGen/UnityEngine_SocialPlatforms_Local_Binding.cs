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
    unsafe class UnityEngine_SocialPlatforms_Local_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.SocialPlatforms.Local);
            args = new Type[]{};
            method = type.GetMethod("get_localUser", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_localUser_0);
            args = new Type[]{typeof(System.String[]), typeof(System.Action<UnityEngine.SocialPlatforms.IUserProfile[]>)};
            method = type.GetMethod("LoadUsers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadUsers_1);
            args = new Type[]{typeof(System.String), typeof(System.Double), typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("ReportProgress", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReportProgress_2);
            args = new Type[]{typeof(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]>)};
            method = type.GetMethod("LoadAchievementDescriptions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadAchievementDescriptions_3);
            args = new Type[]{typeof(System.Action<UnityEngine.SocialPlatforms.IAchievement[]>)};
            method = type.GetMethod("LoadAchievements", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadAchievements_4);
            args = new Type[]{typeof(System.Int64), typeof(System.String), typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("ReportScore", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReportScore_5);
            args = new Type[]{typeof(System.String), typeof(System.Action<UnityEngine.SocialPlatforms.IScore[]>)};
            method = type.GetMethod("LoadScores", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadScores_6);
            args = new Type[]{};
            method = type.GetMethod("ShowAchievementsUI", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ShowAchievementsUI_7);
            args = new Type[]{};
            method = type.GetMethod("ShowLeaderboardUI", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ShowLeaderboardUI_8);
            args = new Type[]{};
            method = type.GetMethod("CreateLeaderboard", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateLeaderboard_9);
            args = new Type[]{};
            method = type.GetMethod("CreateAchievement", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateAchievement_10);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.SocialPlatforms.Local());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.SocialPlatforms.Local[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_localUser_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.Local instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Local)typeof(UnityEngine.SocialPlatforms.Local).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.localUser;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* LoadUsers_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback = (System.Action<UnityEngine.SocialPlatforms.IUserProfile[]>)typeof(System.Action<UnityEngine.SocialPlatforms.IUserProfile[]>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String[] userIDs = (System.String[])typeof(System.String[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.SocialPlatforms.Local instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Local)typeof(UnityEngine.SocialPlatforms.Local).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LoadUsers(userIDs, callback);

            return __ret;
        }

        static StackObject* ReportProgress_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> callback = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Double progress = *(double*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String id = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.SocialPlatforms.Local instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Local)typeof(UnityEngine.SocialPlatforms.Local).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ReportProgress(id, progress, callback);

            return __ret;
        }

        static StackObject* LoadAchievementDescriptions_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> callback = (System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]>)typeof(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.Local instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Local)typeof(UnityEngine.SocialPlatforms.Local).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LoadAchievementDescriptions(callback);

            return __ret;
        }

        static StackObject* LoadAchievements_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback = (System.Action<UnityEngine.SocialPlatforms.IAchievement[]>)typeof(System.Action<UnityEngine.SocialPlatforms.IAchievement[]>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.Local instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Local)typeof(UnityEngine.SocialPlatforms.Local).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LoadAchievements(callback);

            return __ret;
        }

        static StackObject* ReportScore_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> callback = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String board = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int64 score = *(long*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.SocialPlatforms.Local instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Local)typeof(UnityEngine.SocialPlatforms.Local).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ReportScore(score, board, callback);

            return __ret;
        }

        static StackObject* LoadScores_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.SocialPlatforms.IScore[]> callback = (System.Action<UnityEngine.SocialPlatforms.IScore[]>)typeof(System.Action<UnityEngine.SocialPlatforms.IScore[]>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String leaderboardID = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.SocialPlatforms.Local instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Local)typeof(UnityEngine.SocialPlatforms.Local).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LoadScores(leaderboardID, callback);

            return __ret;
        }

        static StackObject* ShowAchievementsUI_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.Local instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Local)typeof(UnityEngine.SocialPlatforms.Local).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ShowAchievementsUI();

            return __ret;
        }

        static StackObject* ShowLeaderboardUI_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.Local instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Local)typeof(UnityEngine.SocialPlatforms.Local).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ShowLeaderboardUI();

            return __ret;
        }

        static StackObject* CreateLeaderboard_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.Local instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Local)typeof(UnityEngine.SocialPlatforms.Local).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CreateLeaderboard();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateAchievement_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.Local instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Local)typeof(UnityEngine.SocialPlatforms.Local).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CreateAchievement();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.SocialPlatforms.Local();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
