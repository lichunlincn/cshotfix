
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
    unsafe class UnityEngine_ClothSkinningCoefficient_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.ClothSkinningCoefficient);

            field = type.GetField("maxDistance", flag);
            app.RegisterCLRFieldGetter(field, get_maxDistance_0);
            app.RegisterCLRFieldSetter(field, set_maxDistance_0);
            field = type.GetField("collisionSphereDistance", flag);
            app.RegisterCLRFieldGetter(field, get_collisionSphereDistance_1);
            app.RegisterCLRFieldSetter(field, set_collisionSphereDistance_1);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ClothSkinningCoefficient());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ClothSkinningCoefficient[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.ClothSkinningCoefficient instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.ClothSkinningCoefficient[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_maxDistance_0(ref object o)
        {
            return ((UnityEngine.ClothSkinningCoefficient)o).maxDistance;
        }
        static void set_maxDistance_0(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.ClothSkinningCoefficient* p = (UnityEngine.ClothSkinningCoefficient *)(void *)h.AddrOfPinnedObject();
            p->maxDistance = (System.Single)v;
            h.Free();
        }
        static object get_collisionSphereDistance_1(ref object o)
        {
            return ((UnityEngine.ClothSkinningCoefficient)o).collisionSphereDistance;
        }
        static void set_collisionSphereDistance_1(ref object o, object v)
        {
            var h = GCHandle.Alloc(o, GCHandleType.Pinned);
            UnityEngine.ClothSkinningCoefficient* p = (UnityEngine.ClothSkinningCoefficient *)(void *)h.AddrOfPinnedObject();
            p->collisionSphereDistance = (System.Single)v;
            h.Free();
        }

        static object PerformMemberwiseClone(ref object o)
        {
            return new UnityEngine.ClothSkinningCoefficient
            {
                maxDistance = ((UnityEngine.ClothSkinningCoefficient) o).maxDistance,
                collisionSphereDistance = ((UnityEngine.ClothSkinningCoefficient) o).collisionSphereDistance,
            };
        }


    }
}
