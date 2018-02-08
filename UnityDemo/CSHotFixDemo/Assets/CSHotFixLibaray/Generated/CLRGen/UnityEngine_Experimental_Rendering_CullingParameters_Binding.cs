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
    unsafe class UnityEngine_Experimental_Rendering_CullingParameters_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Experimental.Rendering.CullingParameters);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetLayerCullDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLayerCullDistance_0);
            args = new Type[]{typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("SetLayerCullDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLayerCullDistance_1);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetCullingPlane", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCullingPlane_2);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Plane)};
            method = type.GetMethod("SetCullingPlane", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetCullingPlane_3);

            field = type.GetField("isOrthographic", flag);
            app.RegisterCLRFieldGetter(field, get_isOrthographic_0);
            app.RegisterCLRFieldSetter(field, set_isOrthographic_0);
            field = type.GetField("lodParameters", flag);
            app.RegisterCLRFieldGetter(field, get_lodParameters_1);
            app.RegisterCLRFieldSetter(field, set_lodParameters_1);
            field = type.GetField("cullingPlaneCount", flag);
            app.RegisterCLRFieldGetter(field, get_cullingPlaneCount_2);
            app.RegisterCLRFieldSetter(field, set_cullingPlaneCount_2);
            field = type.GetField("cullingMask", flag);
            app.RegisterCLRFieldGetter(field, get_cullingMask_3);
            app.RegisterCLRFieldSetter(field, set_cullingMask_3);
            field = type.GetField("cullingMatrix", flag);
            app.RegisterCLRFieldGetter(field, get_cullingMatrix_4);
            app.RegisterCLRFieldSetter(field, set_cullingMatrix_4);
            field = type.GetField("position", flag);
            app.RegisterCLRFieldGetter(field, get_position_5);
            app.RegisterCLRFieldSetter(field, set_position_5);
            field = type.GetField("shadowDistance", flag);
            app.RegisterCLRFieldGetter(field, get_shadowDistance_6);
            app.RegisterCLRFieldSetter(field, set_shadowDistance_6);
            field = type.GetField("reflectionProbeSortOptions", flag);
            app.RegisterCLRFieldGetter(field, get_reflectionProbeSortOptions_7);
            app.RegisterCLRFieldSetter(field, set_reflectionProbeSortOptions_7);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Experimental.Rendering.CullingParameters());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Experimental.Rendering.CullingParameters[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.Experimental.Rendering.CullingParameters instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Experimental.Rendering.CullingParameters[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* GetLayerCullDistance_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Rendering.CullingParameters instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Rendering.CullingParameters)typeof(UnityEngine.Experimental.Rendering.CullingParameters).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.GetLayerCullDistance(layerIndex);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetLayerCullDistance_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single distance = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 layerIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Rendering.CullingParameters instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Rendering.CullingParameters)typeof(UnityEngine.Experimental.Rendering.CullingParameters).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.SetLayerCullDistance(layerIndex, distance);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* GetCullingPlane_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Rendering.CullingParameters instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Rendering.CullingParameters)typeof(UnityEngine.Experimental.Rendering.CullingParameters).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.GetCullingPlane(index);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetCullingPlane_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
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
            UnityEngine.Experimental.Rendering.CullingParameters instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Rendering.CullingParameters)typeof(UnityEngine.Experimental.Rendering.CullingParameters).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.SetCullingPlane(index, plane);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }


        static object get_isOrthographic_0(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.CullingParameters)o).isOrthographic;
        }
        static void set_isOrthographic_0(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.CullingParameters _o = (UnityEngine.Experimental.Rendering.CullingParameters)o;
    _o.isOrthographic = (System.Int32)v;
        }
        static object get_lodParameters_1(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.CullingParameters)o).lodParameters;
        }
        static void set_lodParameters_1(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.CullingParameters _o = (UnityEngine.Experimental.Rendering.CullingParameters)o;
    _o.lodParameters = (UnityEngine.Experimental.Rendering.LODParameters)v;
        }
        static object get_cullingPlaneCount_2(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.CullingParameters)o).cullingPlaneCount;
        }
        static void set_cullingPlaneCount_2(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.CullingParameters _o = (UnityEngine.Experimental.Rendering.CullingParameters)o;
    _o.cullingPlaneCount = (System.Int32)v;
        }
        static object get_cullingMask_3(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.CullingParameters)o).cullingMask;
        }
        static void set_cullingMask_3(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.CullingParameters _o = (UnityEngine.Experimental.Rendering.CullingParameters)o;
    _o.cullingMask = (System.Int32)v;
        }
        static object get_cullingMatrix_4(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.CullingParameters)o).cullingMatrix;
        }
        static void set_cullingMatrix_4(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.CullingParameters _o = (UnityEngine.Experimental.Rendering.CullingParameters)o;
    _o.cullingMatrix = (UnityEngine.Matrix4x4)v;
        }
        static object get_position_5(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.CullingParameters)o).position;
        }
        static void set_position_5(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.CullingParameters _o = (UnityEngine.Experimental.Rendering.CullingParameters)o;
    _o.position = (UnityEngine.Vector3)v;
        }
        static object get_shadowDistance_6(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.CullingParameters)o).shadowDistance;
        }
        static void set_shadowDistance_6(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.CullingParameters _o = (UnityEngine.Experimental.Rendering.CullingParameters)o;
    _o.shadowDistance = (System.Single)v;
        }
        static object get_reflectionProbeSortOptions_7(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.CullingParameters)o).reflectionProbeSortOptions;
        }
        static void set_reflectionProbeSortOptions_7(ref object o, object v)
        {
UnityEngine.Experimental.Rendering.CullingParameters _o = (UnityEngine.Experimental.Rendering.CullingParameters)o;
    _o.reflectionProbeSortOptions = (UnityEngine.Experimental.Rendering.ReflectionProbeSortOptions)v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Experimental.Rendering.CullingParameters();
            ins = (UnityEngine.Experimental.Rendering.CullingParameters)o;
            return ins;
        }


    }
}
