
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
    unsafe class UnityEngine_HideFlags_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.HideFlags);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            field = type.GetField("HideInHierarchy", flag);
            app.RegisterCLRFieldGetter(field, get_HideInHierarchy_1);
            field = type.GetField("HideInInspector", flag);
            app.RegisterCLRFieldGetter(field, get_HideInInspector_2);
            field = type.GetField("DontSaveInEditor", flag);
            app.RegisterCLRFieldGetter(field, get_DontSaveInEditor_3);
            field = type.GetField("NotEditable", flag);
            app.RegisterCLRFieldGetter(field, get_NotEditable_4);
            field = type.GetField("DontSaveInBuild", flag);
            app.RegisterCLRFieldGetter(field, get_DontSaveInBuild_5);
            field = type.GetField("DontUnloadUnusedAsset", flag);
            app.RegisterCLRFieldGetter(field, get_DontUnloadUnusedAsset_6);
            field = type.GetField("DontSave", flag);
            app.RegisterCLRFieldGetter(field, get_DontSave_7);
            field = type.GetField("HideAndDontSave", flag);
            app.RegisterCLRFieldGetter(field, get_HideAndDontSave_8);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.HideFlags());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.HideFlags[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.HideFlags instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.HideFlags[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_None_0(ref object o)
        {
            return UnityEngine.HideFlags.None;
        }
        static object get_HideInHierarchy_1(ref object o)
        {
            return UnityEngine.HideFlags.HideInHierarchy;
        }
        static object get_HideInInspector_2(ref object o)
        {
            return UnityEngine.HideFlags.HideInInspector;
        }
        static object get_DontSaveInEditor_3(ref object o)
        {
            return UnityEngine.HideFlags.DontSaveInEditor;
        }
        static object get_NotEditable_4(ref object o)
        {
            return UnityEngine.HideFlags.NotEditable;
        }
        static object get_DontSaveInBuild_5(ref object o)
        {
            return UnityEngine.HideFlags.DontSaveInBuild;
        }
        static object get_DontUnloadUnusedAsset_6(ref object o)
        {
            return UnityEngine.HideFlags.DontUnloadUnusedAsset;
        }
        static object get_DontSave_7(ref object o)
        {
            return UnityEngine.HideFlags.DontSave;
        }
        static object get_HideAndDontSave_8(ref object o)
        {
            return UnityEngine.HideFlags.HideAndDontSave;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.HideFlags();
            ins = (UnityEngine.HideFlags)o;
            return ins;
        }


    }
}
#endif
