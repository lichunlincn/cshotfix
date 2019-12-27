
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
    unsafe class UnityEngine_RuntimePlatform_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.RuntimePlatform);

            field = type.GetField("OSXEditor", flag);
            app.RegisterCLRFieldGetter(field, get_OSXEditor_0);
            field = type.GetField("OSXPlayer", flag);
            app.RegisterCLRFieldGetter(field, get_OSXPlayer_1);
            field = type.GetField("WindowsPlayer", flag);
            app.RegisterCLRFieldGetter(field, get_WindowsPlayer_2);
            field = type.GetField("WindowsEditor", flag);
            app.RegisterCLRFieldGetter(field, get_WindowsEditor_3);
            field = type.GetField("IPhonePlayer", flag);
            app.RegisterCLRFieldGetter(field, get_IPhonePlayer_4);
            field = type.GetField("Android", flag);
            app.RegisterCLRFieldGetter(field, get_Android_5);
            field = type.GetField("LinuxPlayer", flag);
            app.RegisterCLRFieldGetter(field, get_LinuxPlayer_6);
            field = type.GetField("LinuxEditor", flag);
            app.RegisterCLRFieldGetter(field, get_LinuxEditor_7);
            field = type.GetField("WebGLPlayer", flag);
            app.RegisterCLRFieldGetter(field, get_WebGLPlayer_8);
            field = type.GetField("WSAPlayerX86", flag);
            app.RegisterCLRFieldGetter(field, get_WSAPlayerX86_9);
            field = type.GetField("WSAPlayerX64", flag);
            app.RegisterCLRFieldGetter(field, get_WSAPlayerX64_10);
            field = type.GetField("WSAPlayerARM", flag);
            app.RegisterCLRFieldGetter(field, get_WSAPlayerARM_11);
            field = type.GetField("PS4", flag);
            app.RegisterCLRFieldGetter(field, get_PS4_12);
            field = type.GetField("XboxOne", flag);
            app.RegisterCLRFieldGetter(field, get_XboxOne_13);
            field = type.GetField("tvOS", flag);
            app.RegisterCLRFieldGetter(field, get_tvOS_14);
            field = type.GetField("Switch", flag);
            app.RegisterCLRFieldGetter(field, get_Switch_15);
            field = type.GetField("Lumin", flag);
            app.RegisterCLRFieldGetter(field, get_Lumin_16);
            field = type.GetField("BJM", flag);
            app.RegisterCLRFieldGetter(field, get_BJM_17);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.RuntimePlatform());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.RuntimePlatform[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.RuntimePlatform instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.RuntimePlatform[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_OSXEditor_0(ref object o)
        {
            return UnityEngine.RuntimePlatform.OSXEditor;
        }
        static object get_OSXPlayer_1(ref object o)
        {
            return UnityEngine.RuntimePlatform.OSXPlayer;
        }
        static object get_WindowsPlayer_2(ref object o)
        {
            return UnityEngine.RuntimePlatform.WindowsPlayer;
        }
        static object get_WindowsEditor_3(ref object o)
        {
            return UnityEngine.RuntimePlatform.WindowsEditor;
        }
        static object get_IPhonePlayer_4(ref object o)
        {
            return UnityEngine.RuntimePlatform.IPhonePlayer;
        }
        static object get_Android_5(ref object o)
        {
            return UnityEngine.RuntimePlatform.Android;
        }
        static object get_LinuxPlayer_6(ref object o)
        {
            return UnityEngine.RuntimePlatform.LinuxPlayer;
        }
        static object get_LinuxEditor_7(ref object o)
        {
            return UnityEngine.RuntimePlatform.LinuxEditor;
        }
        static object get_WebGLPlayer_8(ref object o)
        {
            return UnityEngine.RuntimePlatform.WebGLPlayer;
        }
        static object get_WSAPlayerX86_9(ref object o)
        {
            return UnityEngine.RuntimePlatform.WSAPlayerX86;
        }
        static object get_WSAPlayerX64_10(ref object o)
        {
            return UnityEngine.RuntimePlatform.WSAPlayerX64;
        }
        static object get_WSAPlayerARM_11(ref object o)
        {
            return UnityEngine.RuntimePlatform.WSAPlayerARM;
        }
        static object get_PS4_12(ref object o)
        {
            return UnityEngine.RuntimePlatform.PS4;
        }
        static object get_XboxOne_13(ref object o)
        {
            return UnityEngine.RuntimePlatform.XboxOne;
        }
        static object get_tvOS_14(ref object o)
        {
            return UnityEngine.RuntimePlatform.tvOS;
        }
        static object get_Switch_15(ref object o)
        {
            return UnityEngine.RuntimePlatform.Switch;
        }
        static object get_Lumin_16(ref object o)
        {
            return UnityEngine.RuntimePlatform.Lumin;
        }
        static object get_BJM_17(ref object o)
        {
            return UnityEngine.RuntimePlatform.BJM;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.RuntimePlatform();
            ins = (UnityEngine.RuntimePlatform)o;
            return ins;
        }


    }
}
#endif
