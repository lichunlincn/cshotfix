
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
    unsafe class LCL_MonoTool_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(LCL.MonoTool);
            args = new Type[]{};
            method = type.GetMethod("GetRuntimePlatformName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRuntimePlatformName_0);
            args = new Type[]{};
            method = type.GetMethod("GetInputAxisX", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetInputAxisX_1);
            args = new Type[]{};
            method = type.GetMethod("GetInputAxisY", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetInputAxisY_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("SetMoveBase", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetMoveBase_3);
            args = new Type[]{typeof(UnityEngine.Component), typeof(System.Type)};
            method = type.GetMethod("AddComponent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddComponent_4);
            args = new Type[]{};
            method = type.GetMethod("get_isLoadAssetBundleManifest", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isLoadAssetBundleManifest_5);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_isLoadAssetBundleManifest", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_isLoadAssetBundleManifest_6);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("LoadJson", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadJson_7);
            args = new Type[]{typeof(UnityEngine.TextAsset)};
            method = type.GetMethod("SetJson", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetJson_8);
            args = new Type[]{};
            method = type.GetMethod("GetTimeStamp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTimeStamp_9);
            args = new Type[]{typeof(System.Int64)};
            method = type.GetMethod("StampToDateTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StampToDateTime_10);
            args = new Type[]{typeof(System.DateTime)};
            method = type.GetMethod("DateTimeToStamp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DateTimeToStamp_11);
            args = new Type[]{};
            method = type.GetMethod("GeDataPathHeader", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GeDataPathHeader_12);
            args = new Type[]{};
            method = type.GetMethod("GetWWWDataPathHeader", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetWWWDataPathHeader_13);
            args = new Type[]{};
            method = type.GetMethod("GetDataPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDataPath_14);
            args = new Type[]{};
            method = type.GetMethod("GetPersistentPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPersistentPath_15);
            args = new Type[]{typeof(UnityEngine.GameObject), typeof(System.Boolean), typeof(System.String)};
            method = type.GetMethod("SetLayer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLayer_16);
            args = new Type[]{};
            method = type.GetMethod("GetBackDownloadFlag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBackDownloadFlag_17);
            args = new Type[]{};
            method = type.GetMethod("GetBackDownloadFileName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBackDownloadFileName_18);
            args = new Type[]{};
            method = type.GetMethod("GetAssetbundleSuffix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAssetbundleSuffix_19);



            app.RegisterCLRCreateDefaultInstance(type, () => new LCL.MonoTool());
            app.RegisterCLRCreateArrayInstance(type, s => new LCL.MonoTool[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* GetRuntimePlatformName_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = LCL.MonoTool.GetRuntimePlatformName();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetInputAxisX_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = LCL.MonoTool.GetInputAxisX();

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetInputAxisY_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = LCL.MonoTool.GetInputAxisY();

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetMoveBase_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @canMove = ptr_of_this_method->Value == 1;


            LCL.MonoTool.SetMoveBase(@canMove);

            return __ret;
        }

        static StackObject* AddComponent_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @t = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Component @go = (UnityEngine.Component)typeof(UnityEngine.Component).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.MonoTool.AddComponent(@go, @t);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_isLoadAssetBundleManifest_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = LCL.MonoTool.isLoadAssetBundleManifest;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_isLoadAssetBundleManifest_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            LCL.MonoTool.isLoadAssetBundleManifest = value;

            return __ret;
        }

        static StackObject* LoadJson_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @jsonPath = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.MonoTool.LoadJson(@jsonPath);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetJson_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextAsset @data = (UnityEngine.TextAsset)typeof(UnityEngine.TextAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.MonoTool.SetJson(@data);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetTimeStamp_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = LCL.MonoTool.GetTimeStamp();

            __ret->ObjectType = ObjectTypes.Long;
            *(long*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* StampToDateTime_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int64 @lTime = *(long*)&ptr_of_this_method->Value;


            var result_of_this_method = LCL.MonoTool.StampToDateTime(@lTime);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* DateTimeToStamp_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.DateTime @time = (System.DateTime)typeof(System.DateTime).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.MonoTool.DateTimeToStamp(@time);

            __ret->ObjectType = ObjectTypes.Long;
            *(long*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GeDataPathHeader_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = LCL.MonoTool.GeDataPathHeader();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetWWWDataPathHeader_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = LCL.MonoTool.GetWWWDataPathHeader();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetDataPath_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = LCL.MonoTool.GetDataPath();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPersistentPath_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = LCL.MonoTool.GetPersistentPath();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetLayer_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @layerName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @withChildren = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GameObject @gameObjectRoot = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            LCL.MonoTool.SetLayer(@gameObjectRoot, @withChildren, @layerName);

            return __ret;
        }

        static StackObject* GetBackDownloadFlag_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = LCL.MonoTool.GetBackDownloadFlag();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetBackDownloadFileName_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = LCL.MonoTool.GetBackDownloadFileName();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAssetbundleSuffix_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = LCL.MonoTool.GetAssetbundleSuffix();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new LCL.MonoTool();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
