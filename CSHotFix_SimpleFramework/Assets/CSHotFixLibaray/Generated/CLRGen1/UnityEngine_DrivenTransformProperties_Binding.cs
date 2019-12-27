
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
    unsafe class UnityEngine_DrivenTransformProperties_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.DrivenTransformProperties);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            field = type.GetField("All", flag);
            app.RegisterCLRFieldGetter(field, get_All_1);
            field = type.GetField("AnchoredPositionX", flag);
            app.RegisterCLRFieldGetter(field, get_AnchoredPositionX_2);
            field = type.GetField("AnchoredPositionY", flag);
            app.RegisterCLRFieldGetter(field, get_AnchoredPositionY_3);
            field = type.GetField("AnchoredPositionZ", flag);
            app.RegisterCLRFieldGetter(field, get_AnchoredPositionZ_4);
            field = type.GetField("Rotation", flag);
            app.RegisterCLRFieldGetter(field, get_Rotation_5);
            field = type.GetField("ScaleX", flag);
            app.RegisterCLRFieldGetter(field, get_ScaleX_6);
            field = type.GetField("ScaleY", flag);
            app.RegisterCLRFieldGetter(field, get_ScaleY_7);
            field = type.GetField("ScaleZ", flag);
            app.RegisterCLRFieldGetter(field, get_ScaleZ_8);
            field = type.GetField("AnchorMinX", flag);
            app.RegisterCLRFieldGetter(field, get_AnchorMinX_9);
            field = type.GetField("AnchorMinY", flag);
            app.RegisterCLRFieldGetter(field, get_AnchorMinY_10);
            field = type.GetField("AnchorMaxX", flag);
            app.RegisterCLRFieldGetter(field, get_AnchorMaxX_11);
            field = type.GetField("AnchorMaxY", flag);
            app.RegisterCLRFieldGetter(field, get_AnchorMaxY_12);
            field = type.GetField("SizeDeltaX", flag);
            app.RegisterCLRFieldGetter(field, get_SizeDeltaX_13);
            field = type.GetField("SizeDeltaY", flag);
            app.RegisterCLRFieldGetter(field, get_SizeDeltaY_14);
            field = type.GetField("PivotX", flag);
            app.RegisterCLRFieldGetter(field, get_PivotX_15);
            field = type.GetField("PivotY", flag);
            app.RegisterCLRFieldGetter(field, get_PivotY_16);
            field = type.GetField("AnchoredPosition", flag);
            app.RegisterCLRFieldGetter(field, get_AnchoredPosition_17);
            field = type.GetField("AnchoredPosition3D", flag);
            app.RegisterCLRFieldGetter(field, get_AnchoredPosition3D_18);
            field = type.GetField("Scale", flag);
            app.RegisterCLRFieldGetter(field, get_Scale_19);
            field = type.GetField("AnchorMin", flag);
            app.RegisterCLRFieldGetter(field, get_AnchorMin_20);
            field = type.GetField("AnchorMax", flag);
            app.RegisterCLRFieldGetter(field, get_AnchorMax_21);
            field = type.GetField("Anchors", flag);
            app.RegisterCLRFieldGetter(field, get_Anchors_22);
            field = type.GetField("SizeDelta", flag);
            app.RegisterCLRFieldGetter(field, get_SizeDelta_23);
            field = type.GetField("Pivot", flag);
            app.RegisterCLRFieldGetter(field, get_Pivot_24);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.DrivenTransformProperties());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.DrivenTransformProperties[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.DrivenTransformProperties instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.DrivenTransformProperties[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_None_0(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.None;
        }
        static object get_All_1(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.All;
        }
        static object get_AnchoredPositionX_2(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.AnchoredPositionX;
        }
        static object get_AnchoredPositionY_3(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.AnchoredPositionY;
        }
        static object get_AnchoredPositionZ_4(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.AnchoredPositionZ;
        }
        static object get_Rotation_5(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.Rotation;
        }
        static object get_ScaleX_6(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.ScaleX;
        }
        static object get_ScaleY_7(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.ScaleY;
        }
        static object get_ScaleZ_8(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.ScaleZ;
        }
        static object get_AnchorMinX_9(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.AnchorMinX;
        }
        static object get_AnchorMinY_10(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.AnchorMinY;
        }
        static object get_AnchorMaxX_11(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.AnchorMaxX;
        }
        static object get_AnchorMaxY_12(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.AnchorMaxY;
        }
        static object get_SizeDeltaX_13(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.SizeDeltaX;
        }
        static object get_SizeDeltaY_14(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.SizeDeltaY;
        }
        static object get_PivotX_15(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.PivotX;
        }
        static object get_PivotY_16(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.PivotY;
        }
        static object get_AnchoredPosition_17(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.AnchoredPosition;
        }
        static object get_AnchoredPosition3D_18(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.AnchoredPosition3D;
        }
        static object get_Scale_19(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.Scale;
        }
        static object get_AnchorMin_20(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.AnchorMin;
        }
        static object get_AnchorMax_21(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.AnchorMax;
        }
        static object get_Anchors_22(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.Anchors;
        }
        static object get_SizeDelta_23(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.SizeDelta;
        }
        static object get_Pivot_24(ref object o)
        {
            return UnityEngine.DrivenTransformProperties.Pivot;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.DrivenTransformProperties();
            ins = (UnityEngine.DrivenTransformProperties)o;
            return ins;
        }


    }
}
#endif
