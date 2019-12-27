
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
    unsafe class UnityEngine_TestTools_CoveredSequencePoint_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.TestTools.CoveredSequencePoint);

            field = type.GetField("method", flag);
            app.RegisterCLRFieldGetter(field, get_method_0);
            app.RegisterCLRFieldSetter(field, set_method_0);
            field = type.GetField("ilOffset", flag);
            app.RegisterCLRFieldGetter(field, get_ilOffset_1);
            app.RegisterCLRFieldSetter(field, set_ilOffset_1);
            field = type.GetField("hitCount", flag);
            app.RegisterCLRFieldGetter(field, get_hitCount_2);
            app.RegisterCLRFieldSetter(field, set_hitCount_2);
            field = type.GetField("filename", flag);
            app.RegisterCLRFieldGetter(field, get_filename_3);
            app.RegisterCLRFieldSetter(field, set_filename_3);
            field = type.GetField("line", flag);
            app.RegisterCLRFieldGetter(field, get_line_4);
            app.RegisterCLRFieldSetter(field, set_line_4);
            field = type.GetField("column", flag);
            app.RegisterCLRFieldGetter(field, get_column_5);
            app.RegisterCLRFieldSetter(field, set_column_5);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.TestTools.CoveredSequencePoint());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.TestTools.CoveredSequencePoint[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.TestTools.CoveredSequencePoint instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.TestTools.CoveredSequencePoint[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_method_0(ref object o)
        {
            return ((UnityEngine.TestTools.CoveredSequencePoint)o).method;
        }
        static void set_method_0(ref object o, object v)
        {
UnityEngine.TestTools.CoveredSequencePoint _o = (UnityEngine.TestTools.CoveredSequencePoint)o;
    _o.method = (System.Reflection.MethodBase)v;
        }
        static object get_ilOffset_1(ref object o)
        {
            return ((UnityEngine.TestTools.CoveredSequencePoint)o).ilOffset;
        }
        static void set_ilOffset_1(ref object o, object v)
        {
UnityEngine.TestTools.CoveredSequencePoint _o = (UnityEngine.TestTools.CoveredSequencePoint)o;
    _o.ilOffset = (System.UInt32)v;
        }
        static object get_hitCount_2(ref object o)
        {
            return ((UnityEngine.TestTools.CoveredSequencePoint)o).hitCount;
        }
        static void set_hitCount_2(ref object o, object v)
        {
UnityEngine.TestTools.CoveredSequencePoint _o = (UnityEngine.TestTools.CoveredSequencePoint)o;
    _o.hitCount = (System.UInt32)v;
        }
        static object get_filename_3(ref object o)
        {
            return ((UnityEngine.TestTools.CoveredSequencePoint)o).filename;
        }
        static void set_filename_3(ref object o, object v)
        {
UnityEngine.TestTools.CoveredSequencePoint _o = (UnityEngine.TestTools.CoveredSequencePoint)o;
    _o.filename = (System.String)v;
        }
        static object get_line_4(ref object o)
        {
            return ((UnityEngine.TestTools.CoveredSequencePoint)o).line;
        }
        static void set_line_4(ref object o, object v)
        {
UnityEngine.TestTools.CoveredSequencePoint _o = (UnityEngine.TestTools.CoveredSequencePoint)o;
    _o.line = (System.UInt32)v;
        }
        static object get_column_5(ref object o)
        {
            return ((UnityEngine.TestTools.CoveredSequencePoint)o).column;
        }
        static void set_column_5(ref object o, object v)
        {
UnityEngine.TestTools.CoveredSequencePoint _o = (UnityEngine.TestTools.CoveredSequencePoint)o;
    _o.column = (System.UInt32)v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.TestTools.CoveredSequencePoint();
            ins = (UnityEngine.TestTools.CoveredSequencePoint)o;
            return ins;
        }


    }
}
#endif
