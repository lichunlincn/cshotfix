
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
    unsafe class JetBrains_Annotations_ImplicitUseTargetFlags_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(JetBrains.Annotations.ImplicitUseTargetFlags);

            field = type.GetField("Default", flag);
            app.RegisterCLRFieldGetter(field, get_Default_0);
            field = type.GetField("Itself", flag);
            app.RegisterCLRFieldGetter(field, get_Itself_1);
            field = type.GetField("Members", flag);
            app.RegisterCLRFieldGetter(field, get_Members_2);
            field = type.GetField("WithMembers", flag);
            app.RegisterCLRFieldGetter(field, get_WithMembers_3);


            app.RegisterCLRCreateDefaultInstance(type, () => new JetBrains.Annotations.ImplicitUseTargetFlags());
            app.RegisterCLRCreateArrayInstance(type, s => new JetBrains.Annotations.ImplicitUseTargetFlags[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref JetBrains.Annotations.ImplicitUseTargetFlags instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as JetBrains.Annotations.ImplicitUseTargetFlags[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Default_0(ref object o)
        {
            return JetBrains.Annotations.ImplicitUseTargetFlags.Default;
        }
        static object get_Itself_1(ref object o)
        {
            return JetBrains.Annotations.ImplicitUseTargetFlags.Itself;
        }
        static object get_Members_2(ref object o)
        {
            return JetBrains.Annotations.ImplicitUseTargetFlags.Members;
        }
        static object get_WithMembers_3(ref object o)
        {
            return JetBrains.Annotations.ImplicitUseTargetFlags.WithMembers;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new JetBrains.Annotations.ImplicitUseTargetFlags();
            ins = (JetBrains.Annotations.ImplicitUseTargetFlags)o;
            return ins;
        }


    }
}
#endif
