
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
    unsafe class UnityEngine_AudioType_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.AudioType);

            field = type.GetField("UNKNOWN", flag);
            app.RegisterCLRFieldGetter(field, get_UNKNOWN_0);
            field = type.GetField("ACC", flag);
            app.RegisterCLRFieldGetter(field, get_ACC_1);
            field = type.GetField("AIFF", flag);
            app.RegisterCLRFieldGetter(field, get_AIFF_2);
            field = type.GetField("IT", flag);
            app.RegisterCLRFieldGetter(field, get_IT_3);
            field = type.GetField("MOD", flag);
            app.RegisterCLRFieldGetter(field, get_MOD_4);
            field = type.GetField("MPEG", flag);
            app.RegisterCLRFieldGetter(field, get_MPEG_5);
            field = type.GetField("OGGVORBIS", flag);
            app.RegisterCLRFieldGetter(field, get_OGGVORBIS_6);
            field = type.GetField("S3M", flag);
            app.RegisterCLRFieldGetter(field, get_S3M_7);
            field = type.GetField("WAV", flag);
            app.RegisterCLRFieldGetter(field, get_WAV_8);
            field = type.GetField("XM", flag);
            app.RegisterCLRFieldGetter(field, get_XM_9);
            field = type.GetField("XMA", flag);
            app.RegisterCLRFieldGetter(field, get_XMA_10);
            field = type.GetField("VAG", flag);
            app.RegisterCLRFieldGetter(field, get_VAG_11);
            field = type.GetField("AUDIOQUEUE", flag);
            app.RegisterCLRFieldGetter(field, get_AUDIOQUEUE_12);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.AudioType());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AudioType[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.AudioType instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.AudioType[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_UNKNOWN_0(ref object o)
        {
            return UnityEngine.AudioType.UNKNOWN;
        }
        static object get_ACC_1(ref object o)
        {
            return UnityEngine.AudioType.ACC;
        }
        static object get_AIFF_2(ref object o)
        {
            return UnityEngine.AudioType.AIFF;
        }
        static object get_IT_3(ref object o)
        {
            return UnityEngine.AudioType.IT;
        }
        static object get_MOD_4(ref object o)
        {
            return UnityEngine.AudioType.MOD;
        }
        static object get_MPEG_5(ref object o)
        {
            return UnityEngine.AudioType.MPEG;
        }
        static object get_OGGVORBIS_6(ref object o)
        {
            return UnityEngine.AudioType.OGGVORBIS;
        }
        static object get_S3M_7(ref object o)
        {
            return UnityEngine.AudioType.S3M;
        }
        static object get_WAV_8(ref object o)
        {
            return UnityEngine.AudioType.WAV;
        }
        static object get_XM_9(ref object o)
        {
            return UnityEngine.AudioType.XM;
        }
        static object get_XMA_10(ref object o)
        {
            return UnityEngine.AudioType.XMA;
        }
        static object get_VAG_11(ref object o)
        {
            return UnityEngine.AudioType.VAG;
        }
        static object get_AUDIOQUEUE_12(ref object o)
        {
            return UnityEngine.AudioType.AUDIOQUEUE;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.AudioType();
            ins = (UnityEngine.AudioType)o;
            return ins;
        }


    }
}
#endif
