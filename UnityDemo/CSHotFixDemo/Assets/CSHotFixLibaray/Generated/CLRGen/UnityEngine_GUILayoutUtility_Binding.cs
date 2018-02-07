
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
    unsafe class UnityEngine_GUILayoutUtility_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.GUILayoutUtility);
            args = new Type[]{typeof(UnityEngine.GUIContent), typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("GetRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRect_0);
            args = new Type[]{typeof(UnityEngine.GUIContent), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("GetRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRect_1);
            args = new Type[]{typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("GetRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRect_2);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("GetRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRect_3);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("GetRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRect_4);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("GetRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRect_5);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("GetRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRect_6);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("GetRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRect_7);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("GetRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRect_8);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("GetRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRect_9);
            args = new Type[]{};
            method = type.GetMethod("GetLastRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLastRect_10);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("GetAspectRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAspectRect_11);
            args = new Type[]{typeof(System.Single), typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("GetAspectRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAspectRect_12);
            args = new Type[]{typeof(System.Single), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("GetAspectRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAspectRect_13);
            args = new Type[]{typeof(System.Single), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUILayoutOption[])};
            method = type.GetMethod("GetAspectRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAspectRect_14);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.GUILayoutUtility());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.GUILayoutUtility[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* GetRect_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIContent content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.GUILayoutUtility.GetRect(content, style);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRect_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GUIContent content = (UnityEngine.GUIContent)typeof(UnityEngine.GUIContent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.GUILayoutUtility.GetRect(content, style, options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRect_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single height = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single width = *(float*)&ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.GUILayoutUtility.GetRect(width, height);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRect_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single height = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single width = *(float*)&ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.GUILayoutUtility.GetRect(width, height, style);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRect_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single height = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single width = *(float*)&ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.GUILayoutUtility.GetRect(width, height, options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRect_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single height = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single width = *(float*)&ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.GUILayoutUtility.GetRect(width, height, style, options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRect_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single maxHeight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single minHeight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single maxWidth = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single minWidth = *(float*)&ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.GUILayoutUtility.GetRect(minWidth, maxWidth, minHeight, maxHeight);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRect_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single maxHeight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single minHeight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single maxWidth = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single minWidth = *(float*)&ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.GUILayoutUtility.GetRect(minWidth, maxWidth, minHeight, maxHeight, style);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRect_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single maxHeight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single minHeight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single maxWidth = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single minWidth = *(float*)&ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.GUILayoutUtility.GetRect(minWidth, maxWidth, minHeight, maxHeight, options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRect_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single maxHeight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single minHeight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single maxWidth = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Single minWidth = *(float*)&ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.GUILayoutUtility.GetRect(minWidth, maxWidth, minHeight, maxHeight, style, options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetLastRect_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.GUILayoutUtility.GetLastRect();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAspectRect_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single aspect = *(float*)&ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.GUILayoutUtility.GetAspectRect(aspect);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAspectRect_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single aspect = *(float*)&ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.GUILayoutUtility.GetAspectRect(aspect, style);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAspectRect_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single aspect = *(float*)&ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.GUILayoutUtility.GetAspectRect(aspect, options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAspectRect_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUILayoutOption[] options = (UnityEngine.GUILayoutOption[])typeof(UnityEngine.GUILayoutOption[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single aspect = *(float*)&ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.GUILayoutUtility.GetAspectRect(aspect, style, options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.GUILayoutUtility();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
