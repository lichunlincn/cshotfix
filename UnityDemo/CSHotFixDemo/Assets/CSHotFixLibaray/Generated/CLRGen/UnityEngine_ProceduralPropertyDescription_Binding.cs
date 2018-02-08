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
    unsafe class UnityEngine_ProceduralPropertyDescription_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ProceduralPropertyDescription);

            field = type.GetField("name", flag);
            app.RegisterCLRFieldGetter(field, get_name_0);
            app.RegisterCLRFieldSetter(field, set_name_0);
            field = type.GetField("label", flag);
            app.RegisterCLRFieldGetter(field, get_label_1);
            app.RegisterCLRFieldSetter(field, set_label_1);
            field = type.GetField("group", flag);
            app.RegisterCLRFieldGetter(field, get_group_2);
            app.RegisterCLRFieldSetter(field, set_group_2);
            field = type.GetField("type", flag);
            app.RegisterCLRFieldGetter(field, get_type_3);
            app.RegisterCLRFieldSetter(field, set_type_3);
            field = type.GetField("hasRange", flag);
            app.RegisterCLRFieldGetter(field, get_hasRange_4);
            app.RegisterCLRFieldSetter(field, set_hasRange_4);
            field = type.GetField("minimum", flag);
            app.RegisterCLRFieldGetter(field, get_minimum_5);
            app.RegisterCLRFieldSetter(field, set_minimum_5);
            field = type.GetField("maximum", flag);
            app.RegisterCLRFieldGetter(field, get_maximum_6);
            app.RegisterCLRFieldSetter(field, set_maximum_6);
            field = type.GetField("step", flag);
            app.RegisterCLRFieldGetter(field, get_step_7);
            app.RegisterCLRFieldSetter(field, set_step_7);
            field = type.GetField("enumOptions", flag);
            app.RegisterCLRFieldGetter(field, get_enumOptions_8);
            app.RegisterCLRFieldSetter(field, set_enumOptions_8);
            field = type.GetField("componentLabels", flag);
            app.RegisterCLRFieldGetter(field, get_componentLabels_9);
            app.RegisterCLRFieldSetter(field, set_componentLabels_9);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ProceduralPropertyDescription());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ProceduralPropertyDescription[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_name_0(ref object o)
        {
            return ((UnityEngine.ProceduralPropertyDescription)o).name;
        }
        static void set_name_0(ref object o, object v)
        {
UnityEngine.ProceduralPropertyDescription _o = (UnityEngine.ProceduralPropertyDescription)o;
    _o.name = (System.String)v;
        }
        static object get_label_1(ref object o)
        {
            return ((UnityEngine.ProceduralPropertyDescription)o).label;
        }
        static void set_label_1(ref object o, object v)
        {
UnityEngine.ProceduralPropertyDescription _o = (UnityEngine.ProceduralPropertyDescription)o;
    _o.label = (System.String)v;
        }
        static object get_group_2(ref object o)
        {
            return ((UnityEngine.ProceduralPropertyDescription)o).group;
        }
        static void set_group_2(ref object o, object v)
        {
UnityEngine.ProceduralPropertyDescription _o = (UnityEngine.ProceduralPropertyDescription)o;
    _o.group = (System.String)v;
        }
        static object get_type_3(ref object o)
        {
            return ((UnityEngine.ProceduralPropertyDescription)o).type;
        }
        static void set_type_3(ref object o, object v)
        {
UnityEngine.ProceduralPropertyDescription _o = (UnityEngine.ProceduralPropertyDescription)o;
    _o.type = (UnityEngine.ProceduralPropertyType)v;
        }
        static object get_hasRange_4(ref object o)
        {
            return ((UnityEngine.ProceduralPropertyDescription)o).hasRange;
        }
        static void set_hasRange_4(ref object o, object v)
        {
UnityEngine.ProceduralPropertyDescription _o = (UnityEngine.ProceduralPropertyDescription)o;
    _o.hasRange = (System.Boolean)v;
        }
        static object get_minimum_5(ref object o)
        {
            return ((UnityEngine.ProceduralPropertyDescription)o).minimum;
        }
        static void set_minimum_5(ref object o, object v)
        {
UnityEngine.ProceduralPropertyDescription _o = (UnityEngine.ProceduralPropertyDescription)o;
    _o.minimum = (System.Single)v;
        }
        static object get_maximum_6(ref object o)
        {
            return ((UnityEngine.ProceduralPropertyDescription)o).maximum;
        }
        static void set_maximum_6(ref object o, object v)
        {
UnityEngine.ProceduralPropertyDescription _o = (UnityEngine.ProceduralPropertyDescription)o;
    _o.maximum = (System.Single)v;
        }
        static object get_step_7(ref object o)
        {
            return ((UnityEngine.ProceduralPropertyDescription)o).step;
        }
        static void set_step_7(ref object o, object v)
        {
UnityEngine.ProceduralPropertyDescription _o = (UnityEngine.ProceduralPropertyDescription)o;
    _o.step = (System.Single)v;
        }
        static object get_enumOptions_8(ref object o)
        {
            return ((UnityEngine.ProceduralPropertyDescription)o).enumOptions;
        }
        static void set_enumOptions_8(ref object o, object v)
        {
UnityEngine.ProceduralPropertyDescription _o = (UnityEngine.ProceduralPropertyDescription)o;
    _o.enumOptions = (System.String[])v;
        }
        static object get_componentLabels_9(ref object o)
        {
            return ((UnityEngine.ProceduralPropertyDescription)o).componentLabels;
        }
        static void set_componentLabels_9(ref object o, object v)
        {
UnityEngine.ProceduralPropertyDescription _o = (UnityEngine.ProceduralPropertyDescription)o;
    _o.componentLabels = (System.String[])v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.ProceduralPropertyDescription();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
