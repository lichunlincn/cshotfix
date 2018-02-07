
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
    unsafe class UnityEngine_UILineInfo_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.UILineInfo);

            field = type.GetField("startCharIdx", flag);
            app.RegisterCLRFieldGetter(field, get_startCharIdx_0);
            app.RegisterCLRFieldSetter(field, set_startCharIdx_0);
            field = type.GetField("height", flag);
            app.RegisterCLRFieldGetter(field, get_height_1);
            app.RegisterCLRFieldSetter(field, set_height_1);
            field = type.GetField("topY", flag);
            app.RegisterCLRFieldGetter(field, get_topY_2);
            app.RegisterCLRFieldSetter(field, set_topY_2);
            field = type.GetField("leading", flag);
            app.RegisterCLRFieldGetter(field, get_leading_3);
            app.RegisterCLRFieldSetter(field, set_leading_3);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.UILineInfo());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.UILineInfo[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.UILineInfo instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.UILineInfo[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_startCharIdx_0(ref object o)
        {
            return ((UnityEngine.UILineInfo)o).startCharIdx;
        }
        static void set_startCharIdx_0(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.UILineInfo* p = (UnityEngine.UILineInfo *)(void *)h.AddrOfPinnedObject();
            p->startCharIdx = (System.Int32)v;
            h.Free();
        }
        static object get_height_1(ref object o)
        {
            return ((UnityEngine.UILineInfo)o).height;
        }
        static void set_height_1(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.UILineInfo* p = (UnityEngine.UILineInfo *)(void *)h.AddrOfPinnedObject();
            p->height = (System.Int32)v;
            h.Free();
        }
        static object get_topY_2(ref object o)
        {
            return ((UnityEngine.UILineInfo)o).topY;
        }
        static void set_topY_2(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.UILineInfo* p = (UnityEngine.UILineInfo *)(void *)h.AddrOfPinnedObject();
            p->topY = (System.Single)v;
            h.Free();
        }
        static object get_leading_3(ref object o)
        {
            return ((UnityEngine.UILineInfo)o).leading;
        }
        static void set_leading_3(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.UILineInfo* p = (UnityEngine.UILineInfo *)(void *)h.AddrOfPinnedObject();
            p->leading = (System.Single)v;
            h.Free();
        }

        static object PerformMemberwiseClone(ref object o)
        {
            return new UnityEngine.UILineInfo
            {
                startCharIdx = ((UnityEngine.UILineInfo) o).startCharIdx,
                height = ((UnityEngine.UILineInfo) o).height,
                topY = ((UnityEngine.UILineInfo) o).topY,
                leading = ((UnityEngine.UILineInfo) o).leading,
            };
        }


    }
}
