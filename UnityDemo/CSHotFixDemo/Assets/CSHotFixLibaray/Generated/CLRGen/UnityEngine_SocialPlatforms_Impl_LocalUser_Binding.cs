
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
    unsafe class UnityEngine_SocialPlatforms_Impl_LocalUser_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.SocialPlatforms.Impl.LocalUser);
            args = new Type[]{typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("Authenticate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Authenticate_0);
            args = new Type[]{typeof(System.Action<System.Boolean, System.String>)};
            method = type.GetMethod("Authenticate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Authenticate_1);
            args = new Type[]{typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("LoadFriends", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadFriends_2);
            args = new Type[]{typeof(UnityEngine.SocialPlatforms.IUserProfile[])};
            method = type.GetMethod("SetFriends", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetFriends_3);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("SetAuthenticated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAuthenticated_4);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("SetUnderage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetUnderage_5);
            args = new Type[]{};
            method = type.GetMethod("get_friends", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_friends_6);
            args = new Type[]{};
            method = type.GetMethod("get_authenticated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_authenticated_7);
            args = new Type[]{};
            method = type.GetMethod("get_underage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_underage_8);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.SocialPlatforms.Impl.LocalUser());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.SocialPlatforms.Impl.LocalUser[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

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
            UnityEngine.SocialPlatforms.Impl.LocalUser instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Impl.LocalUser)typeof(UnityEngine.SocialPlatforms.Impl.LocalUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
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
            UnityEngine.SocialPlatforms.Impl.LocalUser instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Impl.LocalUser)typeof(UnityEngine.SocialPlatforms.Impl.LocalUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
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
            UnityEngine.SocialPlatforms.Impl.LocalUser instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Impl.LocalUser)typeof(UnityEngine.SocialPlatforms.Impl.LocalUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LoadFriends(callback);

            return __ret;
        }

        static StackObject* SetFriends_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.IUserProfile[] friends = (UnityEngine.SocialPlatforms.IUserProfile[])typeof(UnityEngine.SocialPlatforms.IUserProfile[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.Impl.LocalUser instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Impl.LocalUser)typeof(UnityEngine.SocialPlatforms.Impl.LocalUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetFriends(friends);

            return __ret;
        }

        static StackObject* SetAuthenticated_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.Impl.LocalUser instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Impl.LocalUser)typeof(UnityEngine.SocialPlatforms.Impl.LocalUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetAuthenticated(value);

            return __ret;
        }

        static StackObject* SetUnderage_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.Impl.LocalUser instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Impl.LocalUser)typeof(UnityEngine.SocialPlatforms.Impl.LocalUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetUnderage(value);

            return __ret;
        }

        static StackObject* get_friends_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.Impl.LocalUser instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Impl.LocalUser)typeof(UnityEngine.SocialPlatforms.Impl.LocalUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.friends;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_authenticated_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.Impl.LocalUser instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Impl.LocalUser)typeof(UnityEngine.SocialPlatforms.Impl.LocalUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.authenticated;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_underage_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.Impl.LocalUser instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Impl.LocalUser)typeof(UnityEngine.SocialPlatforms.Impl.LocalUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.underage;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.SocialPlatforms.Impl.LocalUser();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
