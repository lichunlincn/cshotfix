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
    unsafe class UnityEngine_SocialPlatforms_ILocalUser_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.SocialPlatforms.ILocalUser);
            args = new Type[]{typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("Authenticate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Authenticate_0);
            args = new Type[]{typeof(System.Action<System.Boolean, System.String>)};
            method = type.GetMethod("Authenticate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Authenticate_1);
            args = new Type[]{typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("LoadFriends", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadFriends_2);
            args = new Type[]{};
            method = type.GetMethod("get_friends", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_friends_3);
            args = new Type[]{};
            method = type.GetMethod("get_authenticated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_authenticated_4);
            args = new Type[]{};
            method = type.GetMethod("get_underage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_underage_5);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.SocialPlatforms.ILocalUser[s]);


        }


        static StackObject* Authenticate_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> callback = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.ILocalUser instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILocalUser)typeof(UnityEngine.SocialPlatforms.ILocalUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Authenticate(callback);

            return __ret;
        }

        static StackObject* Authenticate_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean, System.String> callback = (System.Action<System.Boolean, System.String>)typeof(System.Action<System.Boolean, System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.ILocalUser instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILocalUser)typeof(UnityEngine.SocialPlatforms.ILocalUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Authenticate(callback);

            return __ret;
        }

        static StackObject* LoadFriends_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> callback = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.ILocalUser instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILocalUser)typeof(UnityEngine.SocialPlatforms.ILocalUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LoadFriends(callback);

            return __ret;
        }

        static StackObject* get_friends_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.ILocalUser instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILocalUser)typeof(UnityEngine.SocialPlatforms.ILocalUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.friends;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_authenticated_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.ILocalUser instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILocalUser)typeof(UnityEngine.SocialPlatforms.ILocalUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.authenticated;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_underage_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.ILocalUser instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.ILocalUser)typeof(UnityEngine.SocialPlatforms.ILocalUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.underage;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }





    }
}
