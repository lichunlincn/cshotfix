
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
    unsafe class UnityEngine_AudioConfiguration_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.AudioConfiguration);

            field = type.GetField("speakerMode", flag);
            app.RegisterCLRFieldGetter(field, get_speakerMode_0);
            app.RegisterCLRFieldSetter(field, set_speakerMode_0);
            field = type.GetField("dspBufferSize", flag);
            app.RegisterCLRFieldGetter(field, get_dspBufferSize_1);
            app.RegisterCLRFieldSetter(field, set_dspBufferSize_1);
            field = type.GetField("sampleRate", flag);
            app.RegisterCLRFieldGetter(field, get_sampleRate_2);
            app.RegisterCLRFieldSetter(field, set_sampleRate_2);
            field = type.GetField("numRealVoices", flag);
            app.RegisterCLRFieldGetter(field, get_numRealVoices_3);
            app.RegisterCLRFieldSetter(field, set_numRealVoices_3);
            field = type.GetField("numVirtualVoices", flag);
            app.RegisterCLRFieldGetter(field, get_numVirtualVoices_4);
            app.RegisterCLRFieldSetter(field, set_numVirtualVoices_4);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.AudioConfiguration());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AudioConfiguration[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.AudioConfiguration instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.AudioConfiguration[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_speakerMode_0(ref object o)
        {
            return ((UnityEngine.AudioConfiguration)o).speakerMode;
        }
        static void set_speakerMode_0(ref object o, object v)
        {
UnityEngine.AudioConfiguration _o = (UnityEngine.AudioConfiguration)o;
    _o.speakerMode = (UnityEngine.AudioSpeakerMode)v;
        }
        static object get_dspBufferSize_1(ref object o)
        {
            return ((UnityEngine.AudioConfiguration)o).dspBufferSize;
        }
        static void set_dspBufferSize_1(ref object o, object v)
        {
UnityEngine.AudioConfiguration _o = (UnityEngine.AudioConfiguration)o;
    _o.dspBufferSize = (System.Int32)v;
        }
        static object get_sampleRate_2(ref object o)
        {
            return ((UnityEngine.AudioConfiguration)o).sampleRate;
        }
        static void set_sampleRate_2(ref object o, object v)
        {
UnityEngine.AudioConfiguration _o = (UnityEngine.AudioConfiguration)o;
    _o.sampleRate = (System.Int32)v;
        }
        static object get_numRealVoices_3(ref object o)
        {
            return ((UnityEngine.AudioConfiguration)o).numRealVoices;
        }
        static void set_numRealVoices_3(ref object o, object v)
        {
UnityEngine.AudioConfiguration _o = (UnityEngine.AudioConfiguration)o;
    _o.numRealVoices = (System.Int32)v;
        }
        static object get_numVirtualVoices_4(ref object o)
        {
            return ((UnityEngine.AudioConfiguration)o).numVirtualVoices;
        }
        static void set_numVirtualVoices_4(ref object o, object v)
        {
UnityEngine.AudioConfiguration _o = (UnityEngine.AudioConfiguration)o;
    _o.numVirtualVoices = (System.Int32)v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            return new UnityEngine.AudioConfiguration
            {
                speakerMode = ((UnityEngine.AudioConfiguration) o).speakerMode,
                dspBufferSize = ((UnityEngine.AudioConfiguration) o).dspBufferSize,
                sampleRate = ((UnityEngine.AudioConfiguration) o).sampleRate,
                numRealVoices = ((UnityEngine.AudioConfiguration) o).numRealVoices,
                numVirtualVoices = ((UnityEngine.AudioConfiguration) o).numVirtualVoices,
            };
        }


    }
}
