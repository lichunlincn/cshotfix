
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
    unsafe class UnityEngine_WWWAudioExtensions_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.WWWAudioExtensions);
            args = new Type[]{typeof(UnityEngine.WWW)};
            method = type.GetMethod("GetAudioClip", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAudioClip_0);
            args = new Type[]{typeof(UnityEngine.WWW), typeof(System.Boolean)};
            method = type.GetMethod("GetAudioClip", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAudioClip_1);
            args = new Type[]{typeof(UnityEngine.WWW), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("GetAudioClip", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAudioClip_2);
            args = new Type[]{typeof(UnityEngine.WWW), typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.AudioType)};
            method = type.GetMethod("GetAudioClip", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAudioClip_3);
            args = new Type[]{typeof(UnityEngine.WWW)};
            method = type.GetMethod("GetAudioClipCompressed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAudioClipCompressed_4);
            args = new Type[]{typeof(UnityEngine.WWW), typeof(System.Boolean)};
            method = type.GetMethod("GetAudioClipCompressed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAudioClipCompressed_5);
            args = new Type[]{typeof(UnityEngine.WWW), typeof(System.Boolean), typeof(UnityEngine.AudioType)};
            method = type.GetMethod("GetAudioClipCompressed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAudioClipCompressed_6);





        }


        static StackObject* GetAudioClip_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.WWW www = (UnityEngine.WWW)typeof(UnityEngine.WWW).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.WWWAudioExtensions.GetAudioClip(www);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAudioClip_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean threeD = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.WWW www = (UnityEngine.WWW)typeof(UnityEngine.WWW).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.WWWAudioExtensions.GetAudioClip(www, threeD);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAudioClip_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean stream = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean threeD = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.WWW www = (UnityEngine.WWW)typeof(UnityEngine.WWW).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.WWWAudioExtensions.GetAudioClip(www, threeD, stream);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAudioClip_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioType audioType = (UnityEngine.AudioType)typeof(UnityEngine.AudioType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean stream = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean threeD = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.WWW www = (UnityEngine.WWW)typeof(UnityEngine.WWW).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.WWWAudioExtensions.GetAudioClip(www, threeD, stream, audioType);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAudioClipCompressed_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.WWW www = (UnityEngine.WWW)typeof(UnityEngine.WWW).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.WWWAudioExtensions.GetAudioClipCompressed(www);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAudioClipCompressed_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean threeD = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.WWW www = (UnityEngine.WWW)typeof(UnityEngine.WWW).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.WWWAudioExtensions.GetAudioClipCompressed(www, threeD);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAudioClipCompressed_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioType audioType = (UnityEngine.AudioType)typeof(UnityEngine.AudioType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean threeD = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.WWW www = (UnityEngine.WWW)typeof(UnityEngine.WWW).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.WWWAudioExtensions.GetAudioClipCompressed(www, threeD, audioType);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}
