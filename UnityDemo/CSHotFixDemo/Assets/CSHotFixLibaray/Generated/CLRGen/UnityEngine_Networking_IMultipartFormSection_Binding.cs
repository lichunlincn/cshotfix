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
    unsafe class UnityEngine_Networking_IMultipartFormSection_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Networking.IMultipartFormSection);
            args = new Type[]{};
            method = type.GetMethod("get_sectionName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sectionName_0);
            args = new Type[]{};
            method = type.GetMethod("get_sectionData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sectionData_1);
            args = new Type[]{};
            method = type.GetMethod("get_fileName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_fileName_2);
            args = new Type[]{};
            method = type.GetMethod("get_contentType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_contentType_3);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Networking.IMultipartFormSection[s]);


        }


        static StackObject* get_sectionName_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.IMultipartFormSection instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.IMultipartFormSection)typeof(UnityEngine.Networking.IMultipartFormSection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sectionName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_sectionData_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.IMultipartFormSection instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.IMultipartFormSection)typeof(UnityEngine.Networking.IMultipartFormSection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sectionData;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_fileName_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.IMultipartFormSection instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.IMultipartFormSection)typeof(UnityEngine.Networking.IMultipartFormSection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.fileName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_contentType_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.IMultipartFormSection instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.IMultipartFormSection)typeof(UnityEngine.Networking.IMultipartFormSection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.contentType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}
