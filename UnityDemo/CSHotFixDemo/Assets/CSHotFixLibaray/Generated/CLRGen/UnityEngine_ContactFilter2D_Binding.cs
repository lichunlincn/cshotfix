
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
    unsafe class UnityEngine_ContactFilter2D_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ContactFilter2D);
            args = new Type[]{};
            method = type.GetMethod("NoFilter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, NoFilter_0);
            args = new Type[]{};
            method = type.GetMethod("ClearLayerMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearLayerMask_1);
            args = new Type[]{typeof(UnityEngine.LayerMask)};
            method = type.GetMethod("SetLayerMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLayerMask_2);
            args = new Type[]{};
            method = type.GetMethod("ClearDepth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearDepth_3);
            args = new Type[]{typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SetDepth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDepth_4);
            args = new Type[]{};
            method = type.GetMethod("ClearNormalAngle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearNormalAngle_5);
            args = new Type[]{typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("SetNormalAngle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetNormalAngle_6);
            args = new Type[]{};
            method = type.GetMethod("get_isFiltering", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isFiltering_7);
            args = new Type[]{typeof(UnityEngine.Collider2D)};
            method = type.GetMethod("IsFilteringTrigger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsFilteringTrigger_8);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("IsFilteringLayerMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsFilteringLayerMask_9);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("IsFilteringDepth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsFilteringDepth_10);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("IsFilteringNormalAngle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsFilteringNormalAngle_11);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("IsFilteringNormalAngle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsFilteringNormalAngle_12);

            field = type.GetField("useTriggers", flag);
            app.RegisterCLRFieldGetter(field, get_useTriggers_0);
            app.RegisterCLRFieldSetter(field, set_useTriggers_0);
            field = type.GetField("useLayerMask", flag);
            app.RegisterCLRFieldGetter(field, get_useLayerMask_1);
            app.RegisterCLRFieldSetter(field, set_useLayerMask_1);
            field = type.GetField("useDepth", flag);
            app.RegisterCLRFieldGetter(field, get_useDepth_2);
            app.RegisterCLRFieldSetter(field, set_useDepth_2);
            field = type.GetField("useOutsideDepth", flag);
            app.RegisterCLRFieldGetter(field, get_useOutsideDepth_3);
            app.RegisterCLRFieldSetter(field, set_useOutsideDepth_3);
            field = type.GetField("useNormalAngle", flag);
            app.RegisterCLRFieldGetter(field, get_useNormalAngle_4);
            app.RegisterCLRFieldSetter(field, set_useNormalAngle_4);
            field = type.GetField("useOutsideNormalAngle", flag);
            app.RegisterCLRFieldGetter(field, get_useOutsideNormalAngle_5);
            app.RegisterCLRFieldSetter(field, set_useOutsideNormalAngle_5);
            field = type.GetField("layerMask", flag);
            app.RegisterCLRFieldGetter(field, get_layerMask_6);
            app.RegisterCLRFieldSetter(field, set_layerMask_6);
            field = type.GetField("minDepth", flag);
            app.RegisterCLRFieldGetter(field, get_minDepth_7);
            app.RegisterCLRFieldSetter(field, set_minDepth_7);
            field = type.GetField("maxDepth", flag);
            app.RegisterCLRFieldGetter(field, get_maxDepth_8);
            app.RegisterCLRFieldSetter(field, set_maxDepth_8);
            field = type.GetField("minNormalAngle", flag);
            app.RegisterCLRFieldGetter(field, get_minNormalAngle_9);
            app.RegisterCLRFieldSetter(field, set_minNormalAngle_9);
            field = type.GetField("maxNormalAngle", flag);
            app.RegisterCLRFieldGetter(field, get_maxNormalAngle_10);
            app.RegisterCLRFieldSetter(field, set_maxNormalAngle_10);
            field = type.GetField("NormalAngleUpperLimit", flag);
            app.RegisterCLRFieldGetter(field, get_NormalAngleUpperLimit_11);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ContactFilter2D());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ContactFilter2D[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.ContactFilter2D instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.ContactFilter2D[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* NoFilter_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ContactFilter2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.ContactFilter2D)typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.NoFilter();

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ClearLayerMask_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ContactFilter2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.ContactFilter2D)typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.ClearLayerMask();

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* SetLayerMask_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LayerMask layerMask = (UnityEngine.LayerMask)typeof(UnityEngine.LayerMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ContactFilter2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.ContactFilter2D)typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.SetLayerMask(layerMask);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* ClearDepth_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ContactFilter2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.ContactFilter2D)typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.ClearDepth();

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* SetDepth_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single maxDepth = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single minDepth = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ContactFilter2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.ContactFilter2D)typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.SetDepth(minDepth, maxDepth);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* ClearNormalAngle_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ContactFilter2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.ContactFilter2D)typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.ClearNormalAngle();

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* SetNormalAngle_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single maxNormalAngle = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single minNormalAngle = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ContactFilter2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.ContactFilter2D)typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.SetNormalAngle(minNormalAngle, maxNormalAngle);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* get_isFiltering_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ContactFilter2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.ContactFilter2D)typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.isFiltering;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsFilteringTrigger_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider2D collider = (UnityEngine.Collider2D)typeof(UnityEngine.Collider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ContactFilter2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.ContactFilter2D)typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.IsFilteringTrigger(collider);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsFilteringLayerMask_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject obj = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ContactFilter2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.ContactFilter2D)typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.IsFilteringLayerMask(obj);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsFilteringDepth_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject obj = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ContactFilter2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.ContactFilter2D)typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.IsFilteringDepth(obj);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsFilteringNormalAngle_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 normal = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ContactFilter2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.ContactFilter2D)typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.IsFilteringNormalAngle(normal);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsFilteringNormalAngle_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single angle = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.ContactFilter2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.ContactFilter2D)typeof(UnityEngine.ContactFilter2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.IsFilteringNormalAngle(angle);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static object get_useTriggers_0(ref object o)
        {
            return ((UnityEngine.ContactFilter2D)o).useTriggers;
        }
        static void set_useTriggers_0(ref object o, object v)
        {
UnityEngine.ContactFilter2D _o = (UnityEngine.ContactFilter2D)o;
    _o.useTriggers = (System.Boolean)v;
        }
        static object get_useLayerMask_1(ref object o)
        {
            return ((UnityEngine.ContactFilter2D)o).useLayerMask;
        }
        static void set_useLayerMask_1(ref object o, object v)
        {
UnityEngine.ContactFilter2D _o = (UnityEngine.ContactFilter2D)o;
    _o.useLayerMask = (System.Boolean)v;
        }
        static object get_useDepth_2(ref object o)
        {
            return ((UnityEngine.ContactFilter2D)o).useDepth;
        }
        static void set_useDepth_2(ref object o, object v)
        {
UnityEngine.ContactFilter2D _o = (UnityEngine.ContactFilter2D)o;
    _o.useDepth = (System.Boolean)v;
        }
        static object get_useOutsideDepth_3(ref object o)
        {
            return ((UnityEngine.ContactFilter2D)o).useOutsideDepth;
        }
        static void set_useOutsideDepth_3(ref object o, object v)
        {
UnityEngine.ContactFilter2D _o = (UnityEngine.ContactFilter2D)o;
    _o.useOutsideDepth = (System.Boolean)v;
        }
        static object get_useNormalAngle_4(ref object o)
        {
            return ((UnityEngine.ContactFilter2D)o).useNormalAngle;
        }
        static void set_useNormalAngle_4(ref object o, object v)
        {
UnityEngine.ContactFilter2D _o = (UnityEngine.ContactFilter2D)o;
    _o.useNormalAngle = (System.Boolean)v;
        }
        static object get_useOutsideNormalAngle_5(ref object o)
        {
            return ((UnityEngine.ContactFilter2D)o).useOutsideNormalAngle;
        }
        static void set_useOutsideNormalAngle_5(ref object o, object v)
        {
UnityEngine.ContactFilter2D _o = (UnityEngine.ContactFilter2D)o;
    _o.useOutsideNormalAngle = (System.Boolean)v;
        }
        static object get_layerMask_6(ref object o)
        {
            return ((UnityEngine.ContactFilter2D)o).layerMask;
        }
        static void set_layerMask_6(ref object o, object v)
        {
UnityEngine.ContactFilter2D _o = (UnityEngine.ContactFilter2D)o;
    _o.layerMask = (UnityEngine.LayerMask)v;
        }
        static object get_minDepth_7(ref object o)
        {
            return ((UnityEngine.ContactFilter2D)o).minDepth;
        }
        static void set_minDepth_7(ref object o, object v)
        {
UnityEngine.ContactFilter2D _o = (UnityEngine.ContactFilter2D)o;
    _o.minDepth = (System.Single)v;
        }
        static object get_maxDepth_8(ref object o)
        {
            return ((UnityEngine.ContactFilter2D)o).maxDepth;
        }
        static void set_maxDepth_8(ref object o, object v)
        {
UnityEngine.ContactFilter2D _o = (UnityEngine.ContactFilter2D)o;
    _o.maxDepth = (System.Single)v;
        }
        static object get_minNormalAngle_9(ref object o)
        {
            return ((UnityEngine.ContactFilter2D)o).minNormalAngle;
        }
        static void set_minNormalAngle_9(ref object o, object v)
        {
UnityEngine.ContactFilter2D _o = (UnityEngine.ContactFilter2D)o;
    _o.minNormalAngle = (System.Single)v;
        }
        static object get_maxNormalAngle_10(ref object o)
        {
            return ((UnityEngine.ContactFilter2D)o).maxNormalAngle;
        }
        static void set_maxNormalAngle_10(ref object o, object v)
        {
UnityEngine.ContactFilter2D _o = (UnityEngine.ContactFilter2D)o;
    _o.maxNormalAngle = (System.Single)v;
        }
        static object get_NormalAngleUpperLimit_11(ref object o)
        {
            return UnityEngine.ContactFilter2D.NormalAngleUpperLimit;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            return new UnityEngine.ContactFilter2D
            {
                useTriggers = ((UnityEngine.ContactFilter2D) o).useTriggers,
                useLayerMask = ((UnityEngine.ContactFilter2D) o).useLayerMask,
                useDepth = ((UnityEngine.ContactFilter2D) o).useDepth,
                useOutsideDepth = ((UnityEngine.ContactFilter2D) o).useOutsideDepth,
                useNormalAngle = ((UnityEngine.ContactFilter2D) o).useNormalAngle,
                useOutsideNormalAngle = ((UnityEngine.ContactFilter2D) o).useOutsideNormalAngle,
                layerMask = ((UnityEngine.ContactFilter2D) o).layerMask,
                minDepth = ((UnityEngine.ContactFilter2D) o).minDepth,
                maxDepth = ((UnityEngine.ContactFilter2D) o).maxDepth,
                minNormalAngle = ((UnityEngine.ContactFilter2D) o).minNormalAngle,
                maxNormalAngle = ((UnityEngine.ContactFilter2D) o).maxNormalAngle,
            };
        }


    }
}
