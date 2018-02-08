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
    unsafe class UnityEngine_Assertions_Assert_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Assertions.Assert);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("IsTrue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsTrue_0);
            args = new Type[]{typeof(System.Boolean), typeof(System.String)};
            method = type.GetMethod("IsTrue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsTrue_1);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("IsFalse", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsFalse_2);
            args = new Type[]{typeof(System.Boolean), typeof(System.String)};
            method = type.GetMethod("IsFalse", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsFalse_3);
            args = new Type[]{typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("AreApproximatelyEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreApproximatelyEqual_4);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.String)};
            method = type.GetMethod("AreApproximatelyEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreApproximatelyEqual_5);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("AreApproximatelyEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreApproximatelyEqual_6);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.String)};
            method = type.GetMethod("AreApproximatelyEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreApproximatelyEqual_7);
            args = new Type[]{typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("AreNotApproximatelyEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotApproximatelyEqual_8);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.String)};
            method = type.GetMethod("AreNotApproximatelyEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotApproximatelyEqual_9);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("AreNotApproximatelyEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotApproximatelyEqual_10);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.String)};
            method = type.GetMethod("AreNotApproximatelyEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotApproximatelyEqual_11);
            args = new Type[]{typeof(UnityEngine.Object), typeof(UnityEngine.Object), typeof(System.String)};
            method = type.GetMethod("AreEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreEqual_12);
            args = new Type[]{typeof(UnityEngine.Object), typeof(UnityEngine.Object), typeof(System.String)};
            method = type.GetMethod("AreNotEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotEqual_13);
            args = new Type[]{typeof(UnityEngine.Object), typeof(System.String)};
            method = type.GetMethod("IsNull", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsNull_14);
            args = new Type[]{typeof(UnityEngine.Object), typeof(System.String)};
            method = type.GetMethod("IsNotNull", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsNotNull_15);

            field = type.GetField("raiseExceptions", flag);
            app.RegisterCLRFieldGetter(field, get_raiseExceptions_0);
            app.RegisterCLRFieldSetter(field, set_raiseExceptions_0);




        }


        static StackObject* IsTrue_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean condition = ptr_of_this_method->Value == 1;

            UnityEngine.Assertions.Assert.IsTrue(condition);

            return __ret;
        }

        static StackObject* IsTrue_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean condition = ptr_of_this_method->Value == 1;

            UnityEngine.Assertions.Assert.IsTrue(condition, message);

            return __ret;
        }

        static StackObject* IsFalse_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean condition = ptr_of_this_method->Value == 1;

            UnityEngine.Assertions.Assert.IsFalse(condition);

            return __ret;
        }

        static StackObject* IsFalse_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean condition = ptr_of_this_method->Value == 1;

            UnityEngine.Assertions.Assert.IsFalse(condition, message);

            return __ret;
        }

        static StackObject* AreApproximatelyEqual_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single actual = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single expected = *(float*)&ptr_of_this_method->Value;

            UnityEngine.Assertions.Assert.AreApproximatelyEqual(expected, actual);

            return __ret;
        }

        static StackObject* AreApproximatelyEqual_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single actual = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single expected = *(float*)&ptr_of_this_method->Value;

            UnityEngine.Assertions.Assert.AreApproximatelyEqual(expected, actual, message);

            return __ret;
        }

        static StackObject* AreApproximatelyEqual_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single tolerance = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single actual = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single expected = *(float*)&ptr_of_this_method->Value;

            UnityEngine.Assertions.Assert.AreApproximatelyEqual(expected, actual, tolerance);

            return __ret;
        }

        static StackObject* AreApproximatelyEqual_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single tolerance = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single actual = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single expected = *(float*)&ptr_of_this_method->Value;

            UnityEngine.Assertions.Assert.AreApproximatelyEqual(expected, actual, tolerance, message);

            return __ret;
        }

        static StackObject* AreNotApproximatelyEqual_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single actual = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single expected = *(float*)&ptr_of_this_method->Value;

            UnityEngine.Assertions.Assert.AreNotApproximatelyEqual(expected, actual);

            return __ret;
        }

        static StackObject* AreNotApproximatelyEqual_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single actual = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single expected = *(float*)&ptr_of_this_method->Value;

            UnityEngine.Assertions.Assert.AreNotApproximatelyEqual(expected, actual, message);

            return __ret;
        }

        static StackObject* AreNotApproximatelyEqual_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single tolerance = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single actual = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single expected = *(float*)&ptr_of_this_method->Value;

            UnityEngine.Assertions.Assert.AreNotApproximatelyEqual(expected, actual, tolerance);

            return __ret;
        }

        static StackObject* AreNotApproximatelyEqual_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single tolerance = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single actual = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single expected = *(float*)&ptr_of_this_method->Value;

            UnityEngine.Assertions.Assert.AreNotApproximatelyEqual(expected, actual, tolerance, message);

            return __ret;
        }

        static StackObject* AreEqual_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Object actual = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Object expected = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Assertions.Assert.AreEqual(expected, actual, message);

            return __ret;
        }

        static StackObject* AreNotEqual_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Object actual = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Object expected = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Assertions.Assert.AreNotEqual(expected, actual, message);

            return __ret;
        }

        static StackObject* IsNull_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Object value = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Assertions.Assert.IsNull(value, message);

            return __ret;
        }

        static StackObject* IsNotNull_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Object value = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            UnityEngine.Assertions.Assert.IsNotNull(value, message);

            return __ret;
        }


        static object get_raiseExceptions_0(ref object o)
        {
            return UnityEngine.Assertions.Assert.raiseExceptions;
        }
        static void set_raiseExceptions_0(ref object o, object v)
        {
            UnityEngine.Assertions.Assert.raiseExceptions = (System.Boolean)v;
        }



    }
}
