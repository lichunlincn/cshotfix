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
    unsafe class UnityEngine_SocialPlatforms_IAchievement_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.SocialPlatforms.IAchievement);
            args = new Type[]{typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("ReportProgress", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReportProgress_0);
            args = new Type[]{};
            method = type.GetMethod("get_id", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_id_1);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_id", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_id_2);
            args = new Type[]{};
            method = type.GetMethod("get_percentCompleted", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_percentCompleted_3);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("set_percentCompleted", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_percentCompleted_4);
            args = new Type[]{};
            method = type.GetMethod("get_completed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_completed_5);
            args = new Type[]{};
            method = type.GetMethod("get_hidden", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hidden_6);
            args = new Type[]{};
            method = type.GetMethod("get_lastReportedDate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lastReportedDate_7);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.SocialPlatforms.IAchievement[s]);


        }


        static StackObject* ReportProgress_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> callback = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.IAchievement instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.IAchievement)typeof(UnityEngine.SocialPlatforms.IAchievement).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ReportProgress(callback);

            return __ret;
        }

        static StackObject* get_id_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.IAchievement instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.IAchievement)typeof(UnityEngine.SocialPlatforms.IAchievement).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.id;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_id_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.IAchievement instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.IAchievement)typeof(UnityEngine.SocialPlatforms.IAchievement).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.id = value;

            return __ret;
        }

        static StackObject* get_percentCompleted_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.IAchievement instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.IAchievement)typeof(UnityEngine.SocialPlatforms.IAchievement).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.percentCompleted;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_percentCompleted_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double value = *(double*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.IAchievement instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.IAchievement)typeof(UnityEngine.SocialPlatforms.IAchievement).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.percentCompleted = value;

            return __ret;
        }

        static StackObject* get_completed_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.IAchievement instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.IAchievement)typeof(UnityEngine.SocialPlatforms.IAchievement).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.completed;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_hidden_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.IAchievement instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.IAchievement)typeof(UnityEngine.SocialPlatforms.IAchievement).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hidden;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_lastReportedDate_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.IAchievement instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.IAchievement)typeof(UnityEngine.SocialPlatforms.IAchievement).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lastReportedDate;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}
