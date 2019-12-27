
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
    unsafe class JetBrains_Annotations_ImplicitUseKindFlags_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(JetBrains.Annotations.ImplicitUseKindFlags);

            field = type.GetField("Default", flag);
            app.RegisterCLRFieldGetter(field, get_Default_0);
            field = type.GetField("Access", flag);
            app.RegisterCLRFieldGetter(field, get_Access_1);
            field = type.GetField("Assign", flag);
            app.RegisterCLRFieldGetter(field, get_Assign_2);
            field = type.GetField("InstantiatedWithFixedConstructorSignature", flag);
            app.RegisterCLRFieldGetter(field, get_InstantiatedWithFixedConstructorSignature_3);
            field = type.GetField("InstantiatedNoFixedConstructorSignature", flag);
            app.RegisterCLRFieldGetter(field, get_InstantiatedNoFixedConstructorSignature_4);


            app.RegisterCLRCreateDefaultInstance(type, () => new JetBrains.Annotations.ImplicitUseKindFlags());
            app.RegisterCLRCreateArrayInstance(type, s => new JetBrains.Annotations.ImplicitUseKindFlags[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref JetBrains.Annotations.ImplicitUseKindFlags instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as JetBrains.Annotations.ImplicitUseKindFlags[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Default_0(ref object o)
        {
            return JetBrains.Annotations.ImplicitUseKindFlags.Default;
        }
        static object get_Access_1(ref object o)
        {
            return JetBrains.Annotations.ImplicitUseKindFlags.Access;
        }
        static object get_Assign_2(ref object o)
        {
            return JetBrains.Annotations.ImplicitUseKindFlags.Assign;
        }
        static object get_InstantiatedWithFixedConstructorSignature_3(ref object o)
        {
            return JetBrains.Annotations.ImplicitUseKindFlags.InstantiatedWithFixedConstructorSignature;
        }
        static object get_InstantiatedNoFixedConstructorSignature_4(ref object o)
        {
            return JetBrains.Annotations.ImplicitUseKindFlags.InstantiatedNoFixedConstructorSignature;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new JetBrains.Annotations.ImplicitUseKindFlags();
            ins = (JetBrains.Annotations.ImplicitUseKindFlags)o;
            return ins;
        }


    }
}
#endif
