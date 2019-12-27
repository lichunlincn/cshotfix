
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
    unsafe class UnityEngine_EventSystems_EventTriggerType_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.EventSystems.EventTriggerType);

            field = type.GetField("PointerEnter", flag);
            app.RegisterCLRFieldGetter(field, get_PointerEnter_0);
            field = type.GetField("PointerExit", flag);
            app.RegisterCLRFieldGetter(field, get_PointerExit_1);
            field = type.GetField("PointerDown", flag);
            app.RegisterCLRFieldGetter(field, get_PointerDown_2);
            field = type.GetField("PointerUp", flag);
            app.RegisterCLRFieldGetter(field, get_PointerUp_3);
            field = type.GetField("PointerClick", flag);
            app.RegisterCLRFieldGetter(field, get_PointerClick_4);
            field = type.GetField("Drag", flag);
            app.RegisterCLRFieldGetter(field, get_Drag_5);
            field = type.GetField("Drop", flag);
            app.RegisterCLRFieldGetter(field, get_Drop_6);
            field = type.GetField("Scroll", flag);
            app.RegisterCLRFieldGetter(field, get_Scroll_7);
            field = type.GetField("UpdateSelected", flag);
            app.RegisterCLRFieldGetter(field, get_UpdateSelected_8);
            field = type.GetField("Select", flag);
            app.RegisterCLRFieldGetter(field, get_Select_9);
            field = type.GetField("Deselect", flag);
            app.RegisterCLRFieldGetter(field, get_Deselect_10);
            field = type.GetField("Move", flag);
            app.RegisterCLRFieldGetter(field, get_Move_11);
            field = type.GetField("InitializePotentialDrag", flag);
            app.RegisterCLRFieldGetter(field, get_InitializePotentialDrag_12);
            field = type.GetField("BeginDrag", flag);
            app.RegisterCLRFieldGetter(field, get_BeginDrag_13);
            field = type.GetField("EndDrag", flag);
            app.RegisterCLRFieldGetter(field, get_EndDrag_14);
            field = type.GetField("Submit", flag);
            app.RegisterCLRFieldGetter(field, get_Submit_15);
            field = type.GetField("Cancel", flag);
            app.RegisterCLRFieldGetter(field, get_Cancel_16);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.EventSystems.EventTriggerType());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.EventSystems.EventTriggerType[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.EventSystems.EventTriggerType instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.EventSystems.EventTriggerType[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_PointerEnter_0(ref object o)
        {
            return UnityEngine.EventSystems.EventTriggerType.PointerEnter;
        }
        static object get_PointerExit_1(ref object o)
        {
            return UnityEngine.EventSystems.EventTriggerType.PointerExit;
        }
        static object get_PointerDown_2(ref object o)
        {
            return UnityEngine.EventSystems.EventTriggerType.PointerDown;
        }
        static object get_PointerUp_3(ref object o)
        {
            return UnityEngine.EventSystems.EventTriggerType.PointerUp;
        }
        static object get_PointerClick_4(ref object o)
        {
            return UnityEngine.EventSystems.EventTriggerType.PointerClick;
        }
        static object get_Drag_5(ref object o)
        {
            return UnityEngine.EventSystems.EventTriggerType.Drag;
        }
        static object get_Drop_6(ref object o)
        {
            return UnityEngine.EventSystems.EventTriggerType.Drop;
        }
        static object get_Scroll_7(ref object o)
        {
            return UnityEngine.EventSystems.EventTriggerType.Scroll;
        }
        static object get_UpdateSelected_8(ref object o)
        {
            return UnityEngine.EventSystems.EventTriggerType.UpdateSelected;
        }
        static object get_Select_9(ref object o)
        {
            return UnityEngine.EventSystems.EventTriggerType.Select;
        }
        static object get_Deselect_10(ref object o)
        {
            return UnityEngine.EventSystems.EventTriggerType.Deselect;
        }
        static object get_Move_11(ref object o)
        {
            return UnityEngine.EventSystems.EventTriggerType.Move;
        }
        static object get_InitializePotentialDrag_12(ref object o)
        {
            return UnityEngine.EventSystems.EventTriggerType.InitializePotentialDrag;
        }
        static object get_BeginDrag_13(ref object o)
        {
            return UnityEngine.EventSystems.EventTriggerType.BeginDrag;
        }
        static object get_EndDrag_14(ref object o)
        {
            return UnityEngine.EventSystems.EventTriggerType.EndDrag;
        }
        static object get_Submit_15(ref object o)
        {
            return UnityEngine.EventSystems.EventTriggerType.Submit;
        }
        static object get_Cancel_16(ref object o)
        {
            return UnityEngine.EventSystems.EventTriggerType.Cancel;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.EventSystems.EventTriggerType();
            ins = (UnityEngine.EventSystems.EventTriggerType)o;
            return ins;
        }


    }
}
#endif
