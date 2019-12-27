
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
    unsafe class UnityEngine_Assertions_Assert_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
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
            args = new Type[]{typeof(System.SByte), typeof(System.SByte)};
            method = type.GetMethod("AreEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreEqual_16);
            args = new Type[]{typeof(System.SByte), typeof(System.SByte), typeof(System.String)};
            method = type.GetMethod("AreEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreEqual_17);
            args = new Type[]{typeof(System.SByte), typeof(System.SByte)};
            method = type.GetMethod("AreNotEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotEqual_18);
            args = new Type[]{typeof(System.SByte), typeof(System.SByte), typeof(System.String)};
            method = type.GetMethod("AreNotEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotEqual_19);
            args = new Type[]{typeof(System.Byte), typeof(System.Byte)};
            method = type.GetMethod("AreEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreEqual_20);
            args = new Type[]{typeof(System.Byte), typeof(System.Byte), typeof(System.String)};
            method = type.GetMethod("AreEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreEqual_21);
            args = new Type[]{typeof(System.Byte), typeof(System.Byte)};
            method = type.GetMethod("AreNotEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotEqual_22);
            args = new Type[]{typeof(System.Byte), typeof(System.Byte), typeof(System.String)};
            method = type.GetMethod("AreNotEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotEqual_23);
            args = new Type[]{typeof(System.Char), typeof(System.Char)};
            method = type.GetMethod("AreEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreEqual_24);
            args = new Type[]{typeof(System.Char), typeof(System.Char), typeof(System.String)};
            method = type.GetMethod("AreEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreEqual_25);
            args = new Type[]{typeof(System.Char), typeof(System.Char)};
            method = type.GetMethod("AreNotEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotEqual_26);
            args = new Type[]{typeof(System.Char), typeof(System.Char), typeof(System.String)};
            method = type.GetMethod("AreNotEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotEqual_27);
            args = new Type[]{typeof(System.Int16), typeof(System.Int16)};
            method = type.GetMethod("AreEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreEqual_28);
            args = new Type[]{typeof(System.Int16), typeof(System.Int16), typeof(System.String)};
            method = type.GetMethod("AreEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreEqual_29);
            args = new Type[]{typeof(System.Int16), typeof(System.Int16)};
            method = type.GetMethod("AreNotEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotEqual_30);
            args = new Type[]{typeof(System.Int16), typeof(System.Int16), typeof(System.String)};
            method = type.GetMethod("AreNotEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotEqual_31);
            args = new Type[]{typeof(System.UInt16), typeof(System.UInt16)};
            method = type.GetMethod("AreEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreEqual_32);
            args = new Type[]{typeof(System.UInt16), typeof(System.UInt16), typeof(System.String)};
            method = type.GetMethod("AreEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreEqual_33);
            args = new Type[]{typeof(System.UInt16), typeof(System.UInt16)};
            method = type.GetMethod("AreNotEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotEqual_34);
            args = new Type[]{typeof(System.UInt16), typeof(System.UInt16), typeof(System.String)};
            method = type.GetMethod("AreNotEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotEqual_35);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("AreEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreEqual_36);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.String)};
            method = type.GetMethod("AreEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreEqual_37);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("AreNotEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotEqual_38);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.String)};
            method = type.GetMethod("AreNotEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotEqual_39);
            args = new Type[]{typeof(System.UInt32), typeof(System.UInt32)};
            method = type.GetMethod("AreEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreEqual_40);
            args = new Type[]{typeof(System.UInt32), typeof(System.UInt32), typeof(System.String)};
            method = type.GetMethod("AreEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreEqual_41);
            args = new Type[]{typeof(System.UInt32), typeof(System.UInt32)};
            method = type.GetMethod("AreNotEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotEqual_42);
            args = new Type[]{typeof(System.UInt32), typeof(System.UInt32), typeof(System.String)};
            method = type.GetMethod("AreNotEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotEqual_43);
            args = new Type[]{typeof(System.Int64), typeof(System.Int64)};
            method = type.GetMethod("AreEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreEqual_44);
            args = new Type[]{typeof(System.Int64), typeof(System.Int64), typeof(System.String)};
            method = type.GetMethod("AreEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreEqual_45);
            args = new Type[]{typeof(System.Int64), typeof(System.Int64)};
            method = type.GetMethod("AreNotEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotEqual_46);
            args = new Type[]{typeof(System.Int64), typeof(System.Int64), typeof(System.String)};
            method = type.GetMethod("AreNotEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotEqual_47);
            args = new Type[]{typeof(System.UInt64), typeof(System.UInt64)};
            method = type.GetMethod("AreEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreEqual_48);
            args = new Type[]{typeof(System.UInt64), typeof(System.UInt64), typeof(System.String)};
            method = type.GetMethod("AreEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreEqual_49);
            args = new Type[]{typeof(System.UInt64), typeof(System.UInt64)};
            method = type.GetMethod("AreNotEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotEqual_50);
            args = new Type[]{typeof(System.UInt64), typeof(System.UInt64), typeof(System.String)};
            method = type.GetMethod("AreNotEqual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreNotEqual_51);





        }


        static StackObject* IsTrue_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @condition = ptr_of_this_method->Value == 1;


            UnityEngine.Assertions.Assert.IsTrue(@condition);

            return __ret;
        }

        static StackObject* IsTrue_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @condition = ptr_of_this_method->Value == 1;


            UnityEngine.Assertions.Assert.IsTrue(@condition, @message);

            return __ret;
        }

        static StackObject* IsFalse_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @condition = ptr_of_this_method->Value == 1;


            UnityEngine.Assertions.Assert.IsFalse(@condition);

            return __ret;
        }

        static StackObject* IsFalse_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @condition = ptr_of_this_method->Value == 1;


            UnityEngine.Assertions.Assert.IsFalse(@condition, @message);

            return __ret;
        }

        static StackObject* AreApproximatelyEqual_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @actual = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @expected = *(float*)&ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreApproximatelyEqual(@expected, @actual);

            return __ret;
        }

        static StackObject* AreApproximatelyEqual_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @actual = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @expected = *(float*)&ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreApproximatelyEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* AreApproximatelyEqual_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @tolerance = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @actual = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @expected = *(float*)&ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreApproximatelyEqual(@expected, @actual, @tolerance);

            return __ret;
        }

        static StackObject* AreApproximatelyEqual_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @tolerance = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @actual = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @expected = *(float*)&ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreApproximatelyEqual(@expected, @actual, @tolerance, @message);

            return __ret;
        }

        static StackObject* AreNotApproximatelyEqual_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @actual = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @expected = *(float*)&ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotApproximatelyEqual(@expected, @actual);

            return __ret;
        }

        static StackObject* AreNotApproximatelyEqual_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @actual = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @expected = *(float*)&ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotApproximatelyEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* AreNotApproximatelyEqual_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @tolerance = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @actual = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @expected = *(float*)&ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotApproximatelyEqual(@expected, @actual, @tolerance);

            return __ret;
        }

        static StackObject* AreNotApproximatelyEqual_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @tolerance = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @actual = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @expected = *(float*)&ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotApproximatelyEqual(@expected, @actual, @tolerance, @message);

            return __ret;
        }

        static StackObject* AreEqual_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Object @actual = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Object @expected = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Assertions.Assert.AreEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* AreNotEqual_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Object @actual = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Object @expected = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Assertions.Assert.AreNotEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* IsNull_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Object @value = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Assertions.Assert.IsNull(@value, @message);

            return __ret;
        }

        static StackObject* IsNotNull_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Object @value = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Assertions.Assert.IsNotNull(@value, @message);

            return __ret;
        }

        static StackObject* AreEqual_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.SByte @actual = (sbyte)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.SByte @expected = (sbyte)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreEqual(@expected, @actual);

            return __ret;
        }

        static StackObject* AreEqual_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.SByte @actual = (sbyte)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.SByte @expected = (sbyte)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* AreNotEqual_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.SByte @actual = (sbyte)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.SByte @expected = (sbyte)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotEqual(@expected, @actual);

            return __ret;
        }

        static StackObject* AreNotEqual_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.SByte @actual = (sbyte)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.SByte @expected = (sbyte)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* AreEqual_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Byte @actual = (byte)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Byte @expected = (byte)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreEqual(@expected, @actual);

            return __ret;
        }

        static StackObject* AreEqual_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Byte @actual = (byte)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Byte @expected = (byte)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* AreNotEqual_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Byte @actual = (byte)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Byte @expected = (byte)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotEqual(@expected, @actual);

            return __ret;
        }

        static StackObject* AreNotEqual_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Byte @actual = (byte)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Byte @expected = (byte)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* AreEqual_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Char @actual = (char)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Char @expected = (char)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreEqual(@expected, @actual);

            return __ret;
        }

        static StackObject* AreEqual_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Char @actual = (char)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Char @expected = (char)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* AreNotEqual_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Char @actual = (char)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Char @expected = (char)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotEqual(@expected, @actual);

            return __ret;
        }

        static StackObject* AreNotEqual_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Char @actual = (char)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Char @expected = (char)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* AreEqual_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int16 @actual = (short)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int16 @expected = (short)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreEqual(@expected, @actual);

            return __ret;
        }

        static StackObject* AreEqual_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int16 @actual = (short)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int16 @expected = (short)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* AreNotEqual_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int16 @actual = (short)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int16 @expected = (short)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotEqual(@expected, @actual);

            return __ret;
        }

        static StackObject* AreNotEqual_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int16 @actual = (short)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int16 @expected = (short)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* AreEqual_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt16 @actual = (ushort)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt16 @expected = (ushort)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreEqual(@expected, @actual);

            return __ret;
        }

        static StackObject* AreEqual_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt16 @actual = (ushort)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.UInt16 @expected = (ushort)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* AreNotEqual_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt16 @actual = (ushort)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt16 @expected = (ushort)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotEqual(@expected, @actual);

            return __ret;
        }

        static StackObject* AreNotEqual_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt16 @actual = (ushort)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.UInt16 @expected = (ushort)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* AreEqual_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @actual = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @expected = ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreEqual(@expected, @actual);

            return __ret;
        }

        static StackObject* AreEqual_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @actual = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @expected = ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* AreNotEqual_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @actual = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @expected = ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotEqual(@expected, @actual);

            return __ret;
        }

        static StackObject* AreNotEqual_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @actual = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @expected = ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* AreEqual_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 @actual = (uint)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt32 @expected = (uint)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreEqual(@expected, @actual);

            return __ret;
        }

        static StackObject* AreEqual_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt32 @actual = (uint)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.UInt32 @expected = (uint)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* AreNotEqual_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 @actual = (uint)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt32 @expected = (uint)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotEqual(@expected, @actual);

            return __ret;
        }

        static StackObject* AreNotEqual_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt32 @actual = (uint)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.UInt32 @expected = (uint)ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* AreEqual_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int64 @actual = *(long*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int64 @expected = *(long*)&ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreEqual(@expected, @actual);

            return __ret;
        }

        static StackObject* AreEqual_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int64 @actual = *(long*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int64 @expected = *(long*)&ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* AreNotEqual_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int64 @actual = *(long*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int64 @expected = *(long*)&ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotEqual(@expected, @actual);

            return __ret;
        }

        static StackObject* AreNotEqual_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int64 @actual = *(long*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int64 @expected = *(long*)&ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* AreEqual_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @actual = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt64 @expected = *(ulong*)&ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreEqual(@expected, @actual);

            return __ret;
        }

        static StackObject* AreEqual_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt64 @actual = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.UInt64 @expected = *(ulong*)&ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreEqual(@expected, @actual, @message);

            return __ret;
        }

        static StackObject* AreNotEqual_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @actual = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt64 @expected = *(ulong*)&ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotEqual(@expected, @actual);

            return __ret;
        }

        static StackObject* AreNotEqual_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @message = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt64 @actual = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.UInt64 @expected = *(ulong*)&ptr_of_this_method->Value;


            UnityEngine.Assertions.Assert.AreNotEqual(@expected, @actual, @message);

            return __ret;
        }





    }
}
#endif
