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
    unsafe class UnityEngine_WWWForm_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.WWWForm);
            args = new Type[]{typeof(System.String), typeof(System.String)};
            method = type.GetMethod("AddField", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddField_0);
            args = new Type[]{typeof(System.String), typeof(System.String), typeof(System.Text.Encoding)};
            method = type.GetMethod("AddField", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddField_1);
            args = new Type[]{typeof(System.String), typeof(System.Int32)};
            method = type.GetMethod("AddField", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddField_2);
            args = new Type[]{typeof(System.String), typeof(System.Byte[]), typeof(System.String)};
            method = type.GetMethod("AddBinaryData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddBinaryData_3);
            args = new Type[]{typeof(System.String), typeof(System.Byte[])};
            method = type.GetMethod("AddBinaryData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddBinaryData_4);
            args = new Type[]{typeof(System.String), typeof(System.Byte[]), typeof(System.String), typeof(System.String)};
            method = type.GetMethod("AddBinaryData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddBinaryData_5);
            args = new Type[]{};
            method = type.GetMethod("get_headers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_headers_6);
            args = new Type[]{};
            method = type.GetMethod("get_data", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_data_7);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.WWWForm());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.WWWForm[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* AddField_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String fieldName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.WWWForm instance_of_this_method;
            instance_of_this_method = (UnityEngine.WWWForm)typeof(UnityEngine.WWWForm).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddField(fieldName, value);

            return __ret;
        }

        static StackObject* AddField_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Text.Encoding e = (System.Text.Encoding)typeof(System.Text.Encoding).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String fieldName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.WWWForm instance_of_this_method;
            instance_of_this_method = (UnityEngine.WWWForm)typeof(UnityEngine.WWWForm).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddField(fieldName, value, e);

            return __ret;
        }

        static StackObject* AddField_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 i = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String fieldName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.WWWForm instance_of_this_method;
            instance_of_this_method = (UnityEngine.WWWForm)typeof(UnityEngine.WWWForm).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddField(fieldName, i);

            return __ret;
        }

        static StackObject* AddBinaryData_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String fileName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Byte[] contents = (System.Byte[])typeof(System.Byte[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String fieldName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.WWWForm instance_of_this_method;
            instance_of_this_method = (UnityEngine.WWWForm)typeof(UnityEngine.WWWForm).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddBinaryData(fieldName, contents, fileName);

            return __ret;
        }

        static StackObject* AddBinaryData_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Byte[] contents = (System.Byte[])typeof(System.Byte[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String fieldName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.WWWForm instance_of_this_method;
            instance_of_this_method = (UnityEngine.WWWForm)typeof(UnityEngine.WWWForm).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddBinaryData(fieldName, contents);

            return __ret;
        }

        static StackObject* AddBinaryData_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String mimeType = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String fileName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Byte[] contents = (System.Byte[])typeof(System.Byte[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String fieldName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.WWWForm instance_of_this_method;
            instance_of_this_method = (UnityEngine.WWWForm)typeof(UnityEngine.WWWForm).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddBinaryData(fieldName, contents, fileName, mimeType);

            return __ret;
        }

        static StackObject* get_headers_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.WWWForm instance_of_this_method;
            instance_of_this_method = (UnityEngine.WWWForm)typeof(UnityEngine.WWWForm).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.headers;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_data_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.WWWForm instance_of_this_method;
            instance_of_this_method = (UnityEngine.WWWForm)typeof(UnityEngine.WWWForm).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.data;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.WWWForm();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
