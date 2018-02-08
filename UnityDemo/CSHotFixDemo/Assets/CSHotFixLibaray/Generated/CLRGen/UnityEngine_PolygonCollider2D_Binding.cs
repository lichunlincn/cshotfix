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
    unsafe class UnityEngine_PolygonCollider2D_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.PolygonCollider2D);
            args = new Type[]{};
            method = type.GetMethod("get_points", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_points_0);
            args = new Type[]{typeof(UnityEngine.Vector2[])};
            method = type.GetMethod("set_points", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_points_1);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPath_2);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Vector2[])};
            method = type.GetMethod("SetPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPath_3);
            args = new Type[]{};
            method = type.GetMethod("get_pathCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pathCount_4);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_pathCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_pathCount_5);
            args = new Type[]{};
            method = type.GetMethod("GetTotalPointCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTotalPointCount_6);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2)};
            method = type.GetMethod("CreatePrimitive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreatePrimitive_7);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Vector2)};
            method = type.GetMethod("CreatePrimitive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreatePrimitive_8);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("CreatePrimitive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreatePrimitive_9);
            args = new Type[]{};
            method = type.GetMethod("get_autoTiling", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_autoTiling_10);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_autoTiling", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_autoTiling_11);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.PolygonCollider2D());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.PolygonCollider2D[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_points_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PolygonCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PolygonCollider2D)typeof(UnityEngine.PolygonCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.points;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_points_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2[] value = (UnityEngine.Vector2[])typeof(UnityEngine.Vector2[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.PolygonCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PolygonCollider2D)typeof(UnityEngine.PolygonCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.points = value;

            return __ret;
        }

        static StackObject* GetPath_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.PolygonCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PolygonCollider2D)typeof(UnityEngine.PolygonCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPath(index);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetPath_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2[] points = (UnityEngine.Vector2[])typeof(UnityEngine.Vector2[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.PolygonCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PolygonCollider2D)typeof(UnityEngine.PolygonCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPath(index, points);

            return __ret;
        }

        static StackObject* get_pathCount_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PolygonCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PolygonCollider2D)typeof(UnityEngine.PolygonCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.pathCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_pathCount_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.PolygonCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PolygonCollider2D)typeof(UnityEngine.PolygonCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.pathCount = value;

            return __ret;
        }

        static StackObject* GetTotalPointCount_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PolygonCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PolygonCollider2D)typeof(UnityEngine.PolygonCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetTotalPointCount();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CreatePrimitive_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 offset = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 scale = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 sides = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.PolygonCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PolygonCollider2D)typeof(UnityEngine.PolygonCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CreatePrimitive(sides, scale, offset);

            return __ret;
        }

        static StackObject* CreatePrimitive_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 scale = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 sides = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.PolygonCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PolygonCollider2D)typeof(UnityEngine.PolygonCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CreatePrimitive(sides, scale);

            return __ret;
        }

        static StackObject* CreatePrimitive_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 sides = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.PolygonCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PolygonCollider2D)typeof(UnityEngine.PolygonCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CreatePrimitive(sides);

            return __ret;
        }

        static StackObject* get_autoTiling_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PolygonCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PolygonCollider2D)typeof(UnityEngine.PolygonCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.autoTiling;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_autoTiling_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.PolygonCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.PolygonCollider2D)typeof(UnityEngine.PolygonCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.autoTiling = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.PolygonCollider2D();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
