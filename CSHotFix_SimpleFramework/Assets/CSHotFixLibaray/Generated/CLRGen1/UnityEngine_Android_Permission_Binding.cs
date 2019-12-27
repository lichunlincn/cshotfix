
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
    unsafe class UnityEngine_Android_Permission_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Android.Permission);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("HasUserAuthorizedPermission", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HasUserAuthorizedPermission_0);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("RequestUserPermission", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RequestUserPermission_1);

            field = type.GetField("Camera", flag);
            app.RegisterCLRFieldGetter(field, get_Camera_0);
            field = type.GetField("Microphone", flag);
            app.RegisterCLRFieldGetter(field, get_Microphone_1);
            field = type.GetField("FineLocation", flag);
            app.RegisterCLRFieldGetter(field, get_FineLocation_2);
            field = type.GetField("CoarseLocation", flag);
            app.RegisterCLRFieldGetter(field, get_CoarseLocation_3);
            field = type.GetField("ExternalStorageRead", flag);
            app.RegisterCLRFieldGetter(field, get_ExternalStorageRead_4);
            field = type.GetField("ExternalStorageWrite", flag);
            app.RegisterCLRFieldGetter(field, get_ExternalStorageWrite_5);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Android.Permission());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Android.Permission[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.Android.Permission instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Android.Permission[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* HasUserAuthorizedPermission_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @permission = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Android.Permission.HasUserAuthorizedPermission(@permission);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RequestUserPermission_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @permission = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.Android.Permission.RequestUserPermission(@permission);

            return __ret;
        }


        static object get_Camera_0(ref object o)
        {
            return UnityEngine.Android.Permission.Camera;
        }
        static object get_Microphone_1(ref object o)
        {
            return UnityEngine.Android.Permission.Microphone;
        }
        static object get_FineLocation_2(ref object o)
        {
            return UnityEngine.Android.Permission.FineLocation;
        }
        static object get_CoarseLocation_3(ref object o)
        {
            return UnityEngine.Android.Permission.CoarseLocation;
        }
        static object get_ExternalStorageRead_4(ref object o)
        {
            return UnityEngine.Android.Permission.ExternalStorageRead;
        }
        static object get_ExternalStorageWrite_5(ref object o)
        {
            return UnityEngine.Android.Permission.ExternalStorageWrite;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Android.Permission();
            ins = (UnityEngine.Android.Permission)o;
            return ins;
        }


    }
}
#endif
