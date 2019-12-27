
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
    unsafe class UnityEngine_ApplicationInstallMode_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ApplicationInstallMode);

            field = type.GetField("Unknown", flag);
            app.RegisterCLRFieldGetter(field, get_Unknown_0);
            field = type.GetField("Store", flag);
            app.RegisterCLRFieldGetter(field, get_Store_1);
            field = type.GetField("DeveloperBuild", flag);
            app.RegisterCLRFieldGetter(field, get_DeveloperBuild_2);
            field = type.GetField("Adhoc", flag);
            app.RegisterCLRFieldGetter(field, get_Adhoc_3);
            field = type.GetField("Enterprise", flag);
            app.RegisterCLRFieldGetter(field, get_Enterprise_4);
            field = type.GetField("Editor", flag);
            app.RegisterCLRFieldGetter(field, get_Editor_5);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ApplicationInstallMode());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ApplicationInstallMode[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.ApplicationInstallMode instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.ApplicationInstallMode[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Unknown_0(ref object o)
        {
            return UnityEngine.ApplicationInstallMode.Unknown;
        }
        static object get_Store_1(ref object o)
        {
            return UnityEngine.ApplicationInstallMode.Store;
        }
        static object get_DeveloperBuild_2(ref object o)
        {
            return UnityEngine.ApplicationInstallMode.DeveloperBuild;
        }
        static object get_Adhoc_3(ref object o)
        {
            return UnityEngine.ApplicationInstallMode.Adhoc;
        }
        static object get_Enterprise_4(ref object o)
        {
            return UnityEngine.ApplicationInstallMode.Enterprise;
        }
        static object get_Editor_5(ref object o)
        {
            return UnityEngine.ApplicationInstallMode.Editor;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.ApplicationInstallMode();
            ins = (UnityEngine.ApplicationInstallMode)o;
            return ins;
        }


    }
}
#endif
