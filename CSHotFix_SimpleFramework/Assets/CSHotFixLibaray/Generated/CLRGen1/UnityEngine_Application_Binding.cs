
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
    unsafe class UnityEngine_Application_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Application);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("Quit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Quit_0);
            args = new Type[]{};
            method = type.GetMethod("Quit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Quit_1);
            args = new Type[]{};
            method = type.GetMethod("Unload", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Unload_2);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("CanStreamedLevelBeLoaded", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CanStreamedLevelBeLoaded_3);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("CanStreamedLevelBeLoaded", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CanStreamedLevelBeLoaded_4);
            args = new Type[]{};
            method = type.GetMethod("get_isPlaying", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isPlaying_5);
            args = new Type[]{typeof(UnityEngine.Object)};
            method = type.GetMethod("IsPlaying", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsPlaying_6);
            args = new Type[]{};
            method = type.GetMethod("get_isFocused", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isFocused_7);
            args = new Type[]{};
            method = type.GetMethod("get_platform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_platform_8);
            args = new Type[]{};
            method = type.GetMethod("GetBuildTags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBuildTags_9);
            args = new Type[]{typeof(System.String[])};
            method = type.GetMethod("SetBuildTags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetBuildTags_10);
            args = new Type[]{};
            method = type.GetMethod("get_buildGUID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_buildGUID_11);
            args = new Type[]{};
            method = type.GetMethod("get_isMobilePlatform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isMobilePlatform_12);
            args = new Type[]{};
            method = type.GetMethod("get_isConsolePlatform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isConsolePlatform_13);
            args = new Type[]{};
            method = type.GetMethod("get_runInBackground", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_runInBackground_14);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_runInBackground", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_runInBackground_15);
            args = new Type[]{};
            method = type.GetMethod("HasProLicense", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HasProLicense_16);
            args = new Type[]{};
            method = type.GetMethod("get_isBatchMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isBatchMode_17);
            args = new Type[]{};
            method = type.GetMethod("get_dataPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_dataPath_18);
            args = new Type[]{};
            method = type.GetMethod("get_streamingAssetsPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_streamingAssetsPath_19);
            args = new Type[]{};
            method = type.GetMethod("get_persistentDataPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_persistentDataPath_20);
            args = new Type[]{};
            method = type.GetMethod("get_temporaryCachePath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_temporaryCachePath_21);
            args = new Type[]{};
            method = type.GetMethod("get_absoluteURL", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_absoluteURL_22);
            args = new Type[]{};
            method = type.GetMethod("get_unityVersion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_unityVersion_23);
            args = new Type[]{};
            method = type.GetMethod("get_version", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_version_24);
            args = new Type[]{};
            method = type.GetMethod("get_installerName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_installerName_25);
            args = new Type[]{};
            method = type.GetMethod("get_identifier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_identifier_26);
            args = new Type[]{};
            method = type.GetMethod("get_installMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_installMode_27);
            args = new Type[]{};
            method = type.GetMethod("get_sandboxType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sandboxType_28);
            args = new Type[]{};
            method = type.GetMethod("get_productName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_productName_29);
            args = new Type[]{};
            method = type.GetMethod("get_companyName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_companyName_30);
            args = new Type[]{};
            method = type.GetMethod("get_cloudProjectId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cloudProjectId_31);
            args = new Type[]{typeof(UnityEngine.Application.AdvertisingIdentifierCallback)};
            method = type.GetMethod("RequestAdvertisingIdentifierAsync", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RequestAdvertisingIdentifierAsync_32);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("OpenURL", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OpenURL_33);
            args = new Type[]{};
            method = type.GetMethod("get_targetFrameRate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_targetFrameRate_34);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_targetFrameRate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_targetFrameRate_35);
            args = new Type[]{};
            method = type.GetMethod("get_systemLanguage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_systemLanguage_36);
            args = new Type[]{typeof(UnityEngine.LogType)};
            method = type.GetMethod("GetStackTraceLogType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetStackTraceLogType_37);
            args = new Type[]{typeof(UnityEngine.LogType), typeof(UnityEngine.StackTraceLogType)};
            method = type.GetMethod("SetStackTraceLogType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetStackTraceLogType_38);
            args = new Type[]{};
            method = type.GetMethod("get_consoleLogPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_consoleLogPath_39);
            args = new Type[]{};
            method = type.GetMethod("get_backgroundLoadingPriority", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_backgroundLoadingPriority_40);
            args = new Type[]{typeof(UnityEngine.ThreadPriority)};
            method = type.GetMethod("set_backgroundLoadingPriority", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_backgroundLoadingPriority_41);
            args = new Type[]{};
            method = type.GetMethod("get_internetReachability", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_internetReachability_42);
            args = new Type[]{};
            method = type.GetMethod("get_genuine", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_genuine_43);
            args = new Type[]{};
            method = type.GetMethod("get_genuineCheckAvailable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_genuineCheckAvailable_44);
            args = new Type[]{typeof(UnityEngine.UserAuthorization)};
            method = type.GetMethod("RequestUserAuthorization", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RequestUserAuthorization_45);
            args = new Type[]{typeof(UnityEngine.UserAuthorization)};
            method = type.GetMethod("HasUserAuthorization", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HasUserAuthorization_46);
            args = new Type[]{};
            method = type.GetMethod("get_isEditor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isEditor_47);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Application());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Application[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Quit_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @exitCode = ptr_of_this_method->Value;


            UnityEngine.Application.Quit(@exitCode);

            return __ret;
        }

        static StackObject* Quit_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.Application.Quit();

            return __ret;
        }

        static StackObject* Unload_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.Application.Unload();

            return __ret;
        }

        static StackObject* CanStreamedLevelBeLoaded_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @levelIndex = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Application.CanStreamedLevelBeLoaded(@levelIndex);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CanStreamedLevelBeLoaded_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @levelName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Application.CanStreamedLevelBeLoaded(@levelName);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isPlaying_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.isPlaying;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsPlaying_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Object @obj = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Application.IsPlaying(@obj);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isFocused_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.isFocused;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_platform_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.platform;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetBuildTags_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.GetBuildTags();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetBuildTags_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String[] @buildTags = (System.String[])typeof(System.String[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.SetBuildTags(@buildTags);

            return __ret;
        }

        static StackObject* get_buildGUID_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.buildGUID;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_isMobilePlatform_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.isMobilePlatform;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isConsolePlatform_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.isConsolePlatform;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_runInBackground_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.runInBackground;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_runInBackground_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Application.runInBackground = value;

            return __ret;
        }

        static StackObject* HasProLicense_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.HasProLicense();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isBatchMode_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.isBatchMode;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_dataPath_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.dataPath;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_streamingAssetsPath_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.streamingAssetsPath;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_persistentDataPath_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.persistentDataPath;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_temporaryCachePath_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.temporaryCachePath;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_absoluteURL_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.absoluteURL;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_unityVersion_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.unityVersion;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_version_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.version;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_installerName_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.installerName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_identifier_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.identifier;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_installMode_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.installMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_sandboxType_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.sandboxType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_productName_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.productName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_companyName_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.companyName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_cloudProjectId_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.cloudProjectId;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RequestAdvertisingIdentifierAsync_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Application.AdvertisingIdentifierCallback @delegateMethod = (UnityEngine.Application.AdvertisingIdentifierCallback)typeof(UnityEngine.Application.AdvertisingIdentifierCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Application.RequestAdvertisingIdentifierAsync(@delegateMethod);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* OpenURL_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @url = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.OpenURL(@url);

            return __ret;
        }

        static StackObject* get_targetFrameRate_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.targetFrameRate;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_targetFrameRate_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.Application.targetFrameRate = value;

            return __ret;
        }

        static StackObject* get_systemLanguage_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.systemLanguage;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetStackTraceLogType_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LogType @logType = (UnityEngine.LogType)typeof(UnityEngine.LogType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Application.GetStackTraceLogType(@logType);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetStackTraceLogType_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.StackTraceLogType @stackTraceType = (UnityEngine.StackTraceLogType)typeof(UnityEngine.StackTraceLogType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LogType @logType = (UnityEngine.LogType)typeof(UnityEngine.LogType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.SetStackTraceLogType(@logType, @stackTraceType);

            return __ret;
        }

        static StackObject* get_consoleLogPath_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.consoleLogPath;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_backgroundLoadingPriority_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.backgroundLoadingPriority;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_backgroundLoadingPriority_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ThreadPriority @value = (UnityEngine.ThreadPriority)typeof(UnityEngine.ThreadPriority).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Application.backgroundLoadingPriority = value;

            return __ret;
        }

        static StackObject* get_internetReachability_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.internetReachability;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_genuine_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.genuine;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_genuineCheckAvailable_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.genuineCheckAvailable;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RequestUserAuthorization_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.UserAuthorization @mode = (UnityEngine.UserAuthorization)typeof(UnityEngine.UserAuthorization).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Application.RequestUserAuthorization(@mode);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* HasUserAuthorization_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.UserAuthorization @mode = (UnityEngine.UserAuthorization)typeof(UnityEngine.UserAuthorization).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Application.HasUserAuthorization(@mode);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isEditor_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Application.isEditor;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Application();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
