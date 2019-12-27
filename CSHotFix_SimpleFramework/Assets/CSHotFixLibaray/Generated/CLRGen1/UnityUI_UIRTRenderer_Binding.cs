
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
    unsafe class UnityUI_UIRTRenderer_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityUI.UIRTRenderer);

            field = type.GetField("Camera", flag);
            app.RegisterCLRFieldGetter(field, get_Camera_0);
            app.RegisterCLRFieldSetter(field, set_Camera_0);
            field = type.GetField("Texture", flag);
            app.RegisterCLRFieldGetter(field, get_Texture_1);
            app.RegisterCLRFieldSetter(field, set_Texture_1);
            field = type.GetField("Width", flag);
            app.RegisterCLRFieldGetter(field, get_Width_2);
            app.RegisterCLRFieldSetter(field, set_Width_2);
            field = type.GetField("Height", flag);
            app.RegisterCLRFieldGetter(field, get_Height_3);
            app.RegisterCLRFieldSetter(field, set_Height_3);
            field = type.GetField("Depth", flag);
            app.RegisterCLRFieldGetter(field, get_Depth_4);
            app.RegisterCLRFieldSetter(field, set_Depth_4);
            field = type.GetField("Format", flag);
            app.RegisterCLRFieldGetter(field, get_Format_5);
            app.RegisterCLRFieldSetter(field, set_Format_5);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityUI.UIRTRenderer());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityUI.UIRTRenderer[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_Camera_0(ref object o)
        {
            return ((UnityUI.UIRTRenderer)o).Camera;
        }
        static void set_Camera_0(ref object o, object v)
        {
UnityUI.UIRTRenderer _o = (UnityUI.UIRTRenderer)o;
    _o.Camera = (UnityEngine.Camera)v;
        }
        static object get_Texture_1(ref object o)
        {
            return ((UnityUI.UIRTRenderer)o).Texture;
        }
        static void set_Texture_1(ref object o, object v)
        {
UnityUI.UIRTRenderer _o = (UnityUI.UIRTRenderer)o;
    _o.Texture = (UnityEngine.RenderTexture)v;
        }
        static object get_Width_2(ref object o)
        {
            return ((UnityUI.UIRTRenderer)o).Width;
        }
        static void set_Width_2(ref object o, object v)
        {
UnityUI.UIRTRenderer _o = (UnityUI.UIRTRenderer)o;
    _o.Width = (System.Int32)v;
        }
        static object get_Height_3(ref object o)
        {
            return ((UnityUI.UIRTRenderer)o).Height;
        }
        static void set_Height_3(ref object o, object v)
        {
UnityUI.UIRTRenderer _o = (UnityUI.UIRTRenderer)o;
    _o.Height = (System.Int32)v;
        }
        static object get_Depth_4(ref object o)
        {
            return ((UnityUI.UIRTRenderer)o).Depth;
        }
        static void set_Depth_4(ref object o, object v)
        {
UnityUI.UIRTRenderer _o = (UnityUI.UIRTRenderer)o;
    _o.Depth = (System.Int32)v;
        }
        static object get_Format_5(ref object o)
        {
            return ((UnityUI.UIRTRenderer)o).Format;
        }
        static void set_Format_5(ref object o, object v)
        {
UnityUI.UIRTRenderer _o = (UnityUI.UIRTRenderer)o;
    _o.Format = (UnityEngine.RenderTextureFormat)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityUI.UIRTRenderer();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
