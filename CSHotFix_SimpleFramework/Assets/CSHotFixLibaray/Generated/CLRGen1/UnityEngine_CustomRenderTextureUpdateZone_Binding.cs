
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
    unsafe class UnityEngine_CustomRenderTextureUpdateZone_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.CustomRenderTextureUpdateZone);

            field = type.GetField("updateZoneCenter", flag);
            app.RegisterCLRFieldGetter(field, get_updateZoneCenter_0);
            app.RegisterCLRFieldSetter(field, set_updateZoneCenter_0);
            field = type.GetField("updateZoneSize", flag);
            app.RegisterCLRFieldGetter(field, get_updateZoneSize_1);
            app.RegisterCLRFieldSetter(field, set_updateZoneSize_1);
            field = type.GetField("rotation", flag);
            app.RegisterCLRFieldGetter(field, get_rotation_2);
            app.RegisterCLRFieldSetter(field, set_rotation_2);
            field = type.GetField("passIndex", flag);
            app.RegisterCLRFieldGetter(field, get_passIndex_3);
            app.RegisterCLRFieldSetter(field, set_passIndex_3);
            field = type.GetField("needSwap", flag);
            app.RegisterCLRFieldGetter(field, get_needSwap_4);
            app.RegisterCLRFieldSetter(field, set_needSwap_4);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.CustomRenderTextureUpdateZone());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.CustomRenderTextureUpdateZone[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.CustomRenderTextureUpdateZone instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.CustomRenderTextureUpdateZone[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_updateZoneCenter_0(ref object o)
        {
            return ((UnityEngine.CustomRenderTextureUpdateZone)o).updateZoneCenter;
        }
        static void set_updateZoneCenter_0(ref object o, object v)
        {
UnityEngine.CustomRenderTextureUpdateZone _o = (UnityEngine.CustomRenderTextureUpdateZone)o;
    _o.updateZoneCenter = (UnityEngine.Vector3)v;
        }
        static object get_updateZoneSize_1(ref object o)
        {
            return ((UnityEngine.CustomRenderTextureUpdateZone)o).updateZoneSize;
        }
        static void set_updateZoneSize_1(ref object o, object v)
        {
UnityEngine.CustomRenderTextureUpdateZone _o = (UnityEngine.CustomRenderTextureUpdateZone)o;
    _o.updateZoneSize = (UnityEngine.Vector3)v;
        }
        static object get_rotation_2(ref object o)
        {
            return ((UnityEngine.CustomRenderTextureUpdateZone)o).rotation;
        }
        static void set_rotation_2(ref object o, object v)
        {
UnityEngine.CustomRenderTextureUpdateZone _o = (UnityEngine.CustomRenderTextureUpdateZone)o;
    _o.rotation = (System.Single)v;
        }
        static object get_passIndex_3(ref object o)
        {
            return ((UnityEngine.CustomRenderTextureUpdateZone)o).passIndex;
        }
        static void set_passIndex_3(ref object o, object v)
        {
UnityEngine.CustomRenderTextureUpdateZone _o = (UnityEngine.CustomRenderTextureUpdateZone)o;
    _o.passIndex = (System.Int32)v;
        }
        static object get_needSwap_4(ref object o)
        {
            return ((UnityEngine.CustomRenderTextureUpdateZone)o).needSwap;
        }
        static void set_needSwap_4(ref object o, object v)
        {
UnityEngine.CustomRenderTextureUpdateZone _o = (UnityEngine.CustomRenderTextureUpdateZone)o;
    _o.needSwap = (System.Boolean)v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.CustomRenderTextureUpdateZone();
            ins = (UnityEngine.CustomRenderTextureUpdateZone)o;
            return ins;
        }


    }
}
#endif
