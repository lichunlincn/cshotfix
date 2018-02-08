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
    unsafe class UnityEngine_CompositeCollider2D_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.CompositeCollider2D);
            args = new Type[]{};
            method = type.GetMethod("get_geometryType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_geometryType_0);
            args = new Type[]{typeof(UnityEngine.CompositeCollider2D.GeometryType)};
            method = type.GetMethod("set_geometryType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_geometryType_1);
            args = new Type[]{};
            method = type.GetMethod("get_generationType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_generationType_2);
            args = new Type[]{typeof(UnityEngine.CompositeCollider2D.GenerationType)};
            method = type.GetMethod("set_generationType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_generationType_3);
            args = new Type[]{};
            method = type.GetMethod("get_vertexDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_vertexDistance_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_vertexDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_vertexDistance_5);
            args = new Type[]{};
            method = type.GetMethod("get_edgeRadius", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_edgeRadius_6);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_edgeRadius", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_edgeRadius_7);
            args = new Type[]{};
            method = type.GetMethod("GenerateGeometry", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GenerateGeometry_8);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetPathPointCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPathPointCount_9);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Vector2[])};
            method = type.GetMethod("GetPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPath_10);
            args = new Type[]{};
            method = type.GetMethod("get_pathCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pathCount_11);
            args = new Type[]{};
            method = type.GetMethod("get_pointCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pointCount_12);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.CompositeCollider2D());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.CompositeCollider2D[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_geometryType_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CompositeCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.CompositeCollider2D)typeof(UnityEngine.CompositeCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.geometryType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_geometryType_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CompositeCollider2D.GeometryType value = (UnityEngine.CompositeCollider2D.GeometryType)typeof(UnityEngine.CompositeCollider2D.GeometryType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CompositeCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.CompositeCollider2D)typeof(UnityEngine.CompositeCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.geometryType = value;

            return __ret;
        }

        static StackObject* get_generationType_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CompositeCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.CompositeCollider2D)typeof(UnityEngine.CompositeCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.generationType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_generationType_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CompositeCollider2D.GenerationType value = (UnityEngine.CompositeCollider2D.GenerationType)typeof(UnityEngine.CompositeCollider2D.GenerationType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CompositeCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.CompositeCollider2D)typeof(UnityEngine.CompositeCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.generationType = value;

            return __ret;
        }

        static StackObject* get_vertexDistance_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CompositeCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.CompositeCollider2D)typeof(UnityEngine.CompositeCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.vertexDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_vertexDistance_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CompositeCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.CompositeCollider2D)typeof(UnityEngine.CompositeCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.vertexDistance = value;

            return __ret;
        }

        static StackObject* get_edgeRadius_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CompositeCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.CompositeCollider2D)typeof(UnityEngine.CompositeCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.edgeRadius;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_edgeRadius_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CompositeCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.CompositeCollider2D)typeof(UnityEngine.CompositeCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.edgeRadius = value;

            return __ret;
        }

        static StackObject* GenerateGeometry_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CompositeCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.CompositeCollider2D)typeof(UnityEngine.CompositeCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GenerateGeometry();

            return __ret;
        }

        static StackObject* GetPathPointCount_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CompositeCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.CompositeCollider2D)typeof(UnityEngine.CompositeCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPathPointCount(index);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetPath_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
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
            UnityEngine.CompositeCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.CompositeCollider2D)typeof(UnityEngine.CompositeCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPath(index, points);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_pathCount_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CompositeCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.CompositeCollider2D)typeof(UnityEngine.CompositeCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.pathCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_pointCount_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CompositeCollider2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.CompositeCollider2D)typeof(UnityEngine.CompositeCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.pointCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.CompositeCollider2D();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
