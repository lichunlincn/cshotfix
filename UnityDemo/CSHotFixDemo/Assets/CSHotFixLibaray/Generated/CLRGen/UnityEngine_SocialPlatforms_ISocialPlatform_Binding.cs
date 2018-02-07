
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
    unsafe class UnityEngine_SocialPlatforms_ISocialPlatform_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.SocialPlatforms.ISocialPlatform);
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
            args = new Type[]{};
            method = type.GetMethod("CreateAchievement", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateAchievement_5);
            args = new Type[]{typeof(System.Int64), typeof(System.String), typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("ReportScore", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReportScore_6);
            args = new Type[]{typeof(System.String), typeof(System.Action<UnityEngine.SocialPlatforms.IScore[]>)};
            method = type.GetMethod("LoadScores", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadScores_7);
            args = new Type[]{};
            method = type.GetMethod("CreateLeaderboard", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateLeaderboard_8);
            args = new Type[]{};
            method = type.GetMethod("ShowAchievementsUI", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ShowAchievementsUI_9);
            args = new Type[]{};
            method = type.GetMethod("ShowLeaderboardUI", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ShowLeaderboardUI_10);
            args = new Type[]{typeof(UnityEngine.SocialPlatforms.ILocalUser), typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("Authenticate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Authenticate_11);
            args = new Type[]{typeof(UnityEngine.SocialPlatforms.ILocalUser), typeof(System.Action<System.Boolean, System.String>)};
            method = type.GetMethod("Authenticate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Authenticate_12);
            args = new Type[]{typeof(UnityEngine.SocialPlatforms.ILocalUser), typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("LoadFriends", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadFriends_13);
            args = new Type[]{typeof(UnityEngine.SocialPlatforms.ILeaderboard), typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("LoadScores", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadScores_14);
            args = new Type[]{typeof(UnityEngine.SocialPlatforms.ILeaderboard)};
            method = type.GetMethod("GetLoading", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLoading_15);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.SocialPlatforms.ISocialPlatform[s]);


        }


        static StackObject* get_localUser_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.ISocialPlatform instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ISocialPlatform)typeof(UnityEngine.SocialPlatforms.ISocialPlatform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
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
            UnityEngine.SocialPlatforms.ISocialPlatform instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ISocialPlatform)typeof(UnityEngine.SocialPlatforms.ISocialPlatform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
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
            System.String achievementID = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.SocialPlatforms.ISocialPlatform instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ISocialPlatform)typeof(UnityEngine.SocialPlatforms.ISocialPlatform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ReportProgress(achievementID, progress, callback);

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
            UnityEngine.SocialPlatforms.ISocialPlatform instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ISocialPlatform)typeof(UnityEngine.SocialPlatforms.ISocialPlatform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
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
            UnityEngine.SocialPlatforms.ISocialPlatform instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ISocialPlatform)typeof(UnityEngine.SocialPlatforms.ISocialPlatform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LoadAchievements(callback);

            return __ret;
        }

        static StackObject* CreateAchievement_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.ISocialPlatform instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ISocialPlatform)typeof(UnityEngine.SocialPlatforms.ISocialPlatform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CreateAchievement();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ReportScore_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
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
            UnityEngine.SocialPlatforms.ISocialPlatform instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ISocialPlatform)typeof(UnityEngine.SocialPlatforms.ISocialPlatform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ReportScore(score, board, callback);

            return __ret;
        }

        static StackObject* LoadScores_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
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
            UnityEngine.SocialPlatforms.ISocialPlatform instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ISocialPlatform)typeof(UnityEngine.SocialPlatforms.ISocialPlatform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LoadScores(leaderboardID, callback);

            return __ret;
        }

        static StackObject* CreateLeaderboard_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.ISocialPlatform instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ISocialPlatform)typeof(UnityEngine.SocialPlatforms.ISocialPlatform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CreateLeaderboard();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ShowAchievementsUI_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.ISocialPlatform instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ISocialPlatform)typeof(UnityEngine.SocialPlatforms.ISocialPlatform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ShowAchievementsUI();

            return __ret;
        }

        static StackObject* ShowLeaderboardUI_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.ISocialPlatform instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ISocialPlatform)typeof(UnityEngine.SocialPlatforms.ISocialPlatform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ShowLeaderboardUI();

            return __ret;
        }

        static StackObject* Authenticate_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> callback = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.ILocalUser user = (UnityEngine.SocialPlatforms.ILocalUser)typeof(UnityEngine.SocialPlatforms.ILocalUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.SocialPlatforms.ISocialPlatform instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ISocialPlatform)typeof(UnityEngine.SocialPlatforms.ISocialPlatform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Authenticate(user, callback);

            return __ret;
        }

        static StackObject* Authenticate_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean, System.String> callback = (System.Action<System.Boolean, System.String>)typeof(System.Action<System.Boolean, System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.ILocalUser user = (UnityEngine.SocialPlatforms.ILocalUser)typeof(UnityEngine.SocialPlatforms.ILocalUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.SocialPlatforms.ISocialPlatform instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ISocialPlatform)typeof(UnityEngine.SocialPlatforms.ISocialPlatform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Authenticate(user, callback);

            return __ret;
        }

        static StackObject* LoadFriends_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> callback = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.ILocalUser user = (UnityEngine.SocialPlatforms.ILocalUser)typeof(UnityEngine.SocialPlatforms.ILocalUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.SocialPlatforms.ISocialPlatform instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ISocialPlatform)typeof(UnityEngine.SocialPlatforms.ISocialPlatform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LoadFriends(user, callback);

            return __ret;
        }

        static StackObject* LoadScores_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> callback = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.ILeaderboard board = (UnityEngine.SocialPlatforms.ILeaderboard)typeof(UnityEngine.SocialPlatforms.ILeaderboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.SocialPlatforms.ISocialPlatform instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ISocialPlatform)typeof(UnityEngine.SocialPlatforms.ISocialPlatform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LoadScores(board, callback);

            return __ret;
        }

        static StackObject* GetLoading_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.ILeaderboard board = (UnityEngine.SocialPlatforms.ILeaderboard)typeof(UnityEngine.SocialPlatforms.ILeaderboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.ISocialPlatform instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ISocialPlatform)typeof(UnityEngine.SocialPlatforms.ISocialPlatform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetLoading(board);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }





    }
}
