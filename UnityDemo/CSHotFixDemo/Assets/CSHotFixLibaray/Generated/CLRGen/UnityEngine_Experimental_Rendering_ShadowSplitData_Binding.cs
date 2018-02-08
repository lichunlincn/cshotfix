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
    unsafe class UnityEngine_Experimental_Rendering_ShadowSplitData_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Experimental.Rendering.ShadowSplitData);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetCullingPlane", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCullingPlane_0);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Plane)};
            method = type.GetMethod("SetCullingPlane", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetCullingPlane_1);

            field = type.GetField("cullingPlaneCount", flag);
            app.RegisterCLRFieldGetter(field, get_cullingPlaneCount_0);
            app.RegisterCLRFieldSetter(field, set_cullingPlaneCount_0);
            field = type.GetField("cullingSphere", flag);
            app.RegisterCLRFieldGetter(field, get_cullingSphere_1);
            app.RegisterCLRFieldSetter(field, set_cullingSphere_1);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Experimental.Rendering.ShadowSplitData());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Experimental.Rendering.ShadowSplitData[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.Experimental.Rendering.ShadowSplitData instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Experimental.Rendering.ShadowSplitData[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* GetCullingPlane_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Rendering.ShadowSplitData instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Rendering.ShadowSplitData)typeof(UnityEngine.Experimental.Rendering.ShadowSplitData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.GetCullingPlane(index);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetCullingPlane_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Plane plane = (UnityEngine.Plane)typeof(UnityEngine.Plane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Rendering.ShadowSplitData instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Rendering.ShadowSplitData)typeof(UnityEngine.Experimental.Rendering.ShadowSplitData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.SetCullingPlane(index, plane);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }


        static object get_cullingPlaneCount_0(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.ShadowSplitData)o).cullingPlaneCount;
        }
        static void set_cullingPlaneCount_0(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.ShadowSplitData _o = (UnityEngine.Experimental.Rendering.ShadowSplitData)o;
    _o.cullingPlaneCount = (System.Int32)v;
        }
        static object get_cullingSphere_1(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.ShadowSplitData)o).cullingSphere;
        }
        static void set_cullingSphere_1(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.ShadowSplitData _o = (UnityEngine.Experimental.Rendering.ShadowSplitData)o;
    _o.cullingSphere = (UnityEngine.Vector4)v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Experimental.Rendering.ShadowSplitData();
            ins = (UnityEngine.Experimental.Rendering.ShadowSplitData)o;
            return ins;
        }


    }
}
