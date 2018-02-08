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
    unsafe class UnityEngine_SocialPlatforms_Impl_UserProfile_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.SocialPlatforms.Impl.UserProfile);
            args = new Type[]{};
            method = type.GetMethod("ToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToString_0);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("SetUserName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetUserName_1);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("SetUserID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetUserID_2);
            args = new Type[]{typeof(UnityEngine.Texture2D)};
            method = type.GetMethod("SetImage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetImage_3);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("SetIsFriend", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetIsFriend_4);
            args = new Type[]{typeof(UnityEngine.SocialPlatforms.UserState)};
            method = type.GetMethod("SetState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetState_5);
            args = new Type[]{};
            method = type.GetMethod("get_userName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_userName_6);
            args = new Type[]{};
            method = type.GetMethod("get_id", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_id_7);
            args = new Type[]{};
            method = type.GetMethod("get_isFriend", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isFriend_8);
            args = new Type[]{};
            method = type.GetMethod("get_state", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_state_9);
            args = new Type[]{};
            method = type.GetMethod("get_image", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_image_10);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.SocialPlatforms.Impl.UserProfile());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.SocialPlatforms.Impl.UserProfile[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(System.String), typeof(System.String), typeof(System.Boolean)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);
            args = new Type[]{typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(UnityEngine.SocialPlatforms.UserState), typeof(UnityEngine.Texture2D)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_2);

        }


        static StackObject* ToString_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.Impl.UserProfile instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Impl.UserProfile)typeof(UnityEngine.SocialPlatforms.Impl.UserProfile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ToString();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetUserName_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.Impl.UserProfile instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Impl.UserProfile)typeof(UnityEngine.SocialPlatforms.Impl.UserProfile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetUserName(name);

            return __ret;
        }

        static StackObject* SetUserID_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String id = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.Impl.UserProfile instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Impl.UserProfile)typeof(UnityEngine.SocialPlatforms.Impl.UserProfile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetUserID(id);

            return __ret;
        }

        static StackObject* SetImage_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture2D image = (UnityEngine.Texture2D)typeof(UnityEngine.Texture2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.Impl.UserProfile instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Impl.UserProfile)typeof(UnityEngine.SocialPlatforms.Impl.UserProfile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetImage(image);

            return __ret;
        }

        static StackObject* SetIsFriend_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.Impl.UserProfile instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Impl.UserProfile)typeof(UnityEngine.SocialPlatforms.Impl.UserProfile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetIsFriend(value);

            return __ret;
        }

        static StackObject* SetState_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.UserState state = (UnityEngine.SocialPlatforms.UserState)typeof(UnityEngine.SocialPlatforms.UserState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.Impl.UserProfile instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Impl.UserProfile)typeof(UnityEngine.SocialPlatforms.Impl.UserProfile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetState(state);

            return __ret;
        }

        static StackObject* get_userName_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.Impl.UserProfile instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Impl.UserProfile)typeof(UnityEngine.SocialPlatforms.Impl.UserProfile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.userName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_id_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.Impl.UserProfile instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Impl.UserProfile)typeof(UnityEngine.SocialPlatforms.Impl.UserProfile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.id;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_isFriend_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.Impl.UserProfile instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Impl.UserProfile)typeof(UnityEngine.SocialPlatforms.Impl.UserProfile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isFriend;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_state_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.Impl.UserProfile instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Impl.UserProfile)typeof(UnityEngine.SocialPlatforms.Impl.UserProfile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.state;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_image_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SocialPlatforms.Impl.UserProfile instance_of_this_method;
            instance_of_this_method = (UnityEngine.SocialPlatforms.Impl.UserProfile)typeof(UnityEngine.SocialPlatforms.Impl.UserProfile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.image;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.SocialPlatforms.Impl.UserProfile();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean friend = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String id = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new UnityEngine.SocialPlatforms.Impl.UserProfile(name, id, friend);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture2D image = (UnityEngine.Texture2D)typeof(UnityEngine.Texture2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SocialPlatforms.UserState state = (UnityEngine.SocialPlatforms.UserState)typeof(UnityEngine.SocialPlatforms.UserState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean friend = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String id = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.String name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new UnityEngine.SocialPlatforms.Impl.UserProfile(name, id, friend, state, image);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
