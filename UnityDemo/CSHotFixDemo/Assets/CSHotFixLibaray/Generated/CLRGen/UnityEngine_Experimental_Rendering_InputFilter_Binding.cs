
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
    unsafe class UnityEngine_Experimental_Rendering_InputFilter_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Experimental.Rendering.InputFilter);
            args = new Type[]{};
            method = type.GetMethod("Default", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Default_0);
            args = new Type[]{};
            method = type.GetMethod("SetQueuesOpaque", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetQueuesOpaque_1);
            args = new Type[]{};
            method = type.GetMethod("SetQueuesTransparent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetQueuesTransparent_2);

            field = type.GetField("renderQueueMin", flag);
            app.RegisterCLRFieldGetter(field, get_renderQueueMin_0);
            app.RegisterCLRFieldSetter(field, set_renderQueueMin_0);
            field = type.GetField("renderQueueMax", flag);
            app.RegisterCLRFieldGetter(field, get_renderQueueMax_1);
            app.RegisterCLRFieldSetter(field, set_renderQueueMax_1);
            field = type.GetField("layerMask", flag);
            app.RegisterCLRFieldGetter(field, get_layerMask_2);
            app.RegisterCLRFieldSetter(field, set_layerMask_2);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Experimental.Rendering.InputFilter());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Experimental.Rendering.InputFilter[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.Experimental.Rendering.InputFilter instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Experimental.Rendering.InputFilter[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* Default_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.Experimental.Rendering.InputFilter.Default();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetQueuesOpaque_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Rendering.InputFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Rendering.InputFilter)typeof(UnityEngine.Experimental.Rendering.InputFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.SetQueuesOpaque();

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* SetQueuesTransparent_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Experimental.Rendering.InputFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Rendering.InputFilter)typeof(UnityEngine.Experimental.Rendering.InputFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.SetQueuesTransparent();

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }


        static object get_renderQueueMin_0(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.InputFilter)o).renderQueueMin;
        }
        static void set_renderQueueMin_0(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.Experimental.Rendering.InputFilter* p = (UnityEngine.Experimental.Rendering.InputFilter *)(void *)h.AddrOfPinnedObject();
            p->renderQueueMin = (System.Int32)v;
            h.Free();
        }
        static object get_renderQueueMax_1(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.InputFilter)o).renderQueueMax;
        }
        static void set_renderQueueMax_1(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.Experimental.Rendering.InputFilter* p = (UnityEngine.Experimental.Rendering.InputFilter *)(void *)h.AddrOfPinnedObject();
            p->renderQueueMax = (System.Int32)v;
            h.Free();
        }
        static object get_layerMask_2(ref object o)
        {
            return ((UnityEngine.Experimental.Rendering.InputFilter)o).layerMask;
        }
        static void set_layerMask_2(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.Experimental.Rendering.InputFilter* p = (UnityEngine.Experimental.Rendering.InputFilter *)(void *)h.AddrOfPinnedObject();
            p->layerMask = (System.Int32)v;
            h.Free();
        }

        static object PerformMemberwiseClone(ref object o)
        {
            return new UnityEngine.Experimental.Rendering.InputFilter
            {
                renderQueueMin = ((UnityEngine.Experimental.Rendering.InputFilter) o).renderQueueMin,
                renderQueueMax = ((UnityEngine.Experimental.Rendering.InputFilter) o).renderQueueMax,
                layerMask = ((UnityEngine.Experimental.Rendering.InputFilter) o).layerMask,
            };
        }


    }
}
