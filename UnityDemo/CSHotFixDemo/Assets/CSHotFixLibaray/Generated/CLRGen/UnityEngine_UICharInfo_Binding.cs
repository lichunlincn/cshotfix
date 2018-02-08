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
    unsafe class UnityEngine_UICharInfo_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.UICharInfo);

            field = type.GetField("cursorPos", flag);
            app.RegisterCLRFieldGetter(field, get_cursorPos_0);
            app.RegisterCLRFieldSetter(field, set_cursorPos_0);
            field = type.GetField("charWidth", flag);
            app.RegisterCLRFieldGetter(field, get_charWidth_1);
            app.RegisterCLRFieldSetter(field, set_charWidth_1);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.UICharInfo());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.UICharInfo[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.UICharInfo instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.UICharInfo[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_cursorPos_0(ref object o)
        {
            return ((UnityEngine.UICharInfo)o).cursorPos;
        }
        static void set_cursorPos_0(ref object o, object v)
        {
UnityEngine.UICharInfo _o = (UnityEngine.UICharInfo)o;
    _o.cursorPos = (UnityEngine.Vector2)v;
        }
        static object get_charWidth_1(ref object o)
        {
            return ((UnityEngine.UICharInfo)o).charWidth;
        }
        static void set_charWidth_1(ref object o, object v)
        {
UnityEngine.UICharInfo _o = (UnityEngine.UICharInfo)o;
    _o.charWidth = (System.Single)v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.UICharInfo();
            ins = (UnityEngine.UICharInfo)o;
            return ins;
        }


    }
}
