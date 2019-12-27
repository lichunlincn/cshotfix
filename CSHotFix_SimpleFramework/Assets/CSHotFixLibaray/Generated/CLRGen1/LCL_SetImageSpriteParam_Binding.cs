
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
    unsafe class LCL_SetImageSpriteParam_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(LCL.SetImageSpriteParam);

            field = type.GetField("abName", flag);
            app.RegisterCLRFieldGetter(field, get_abName_0);
            app.RegisterCLRFieldSetter(field, set_abName_0);
            field = type.GetField("assetName", flag);
            app.RegisterCLRFieldGetter(field, get_assetName_1);
            app.RegisterCLRFieldSetter(field, set_assetName_1);
            field = type.GetField("img", flag);
            app.RegisterCLRFieldGetter(field, get_img_2);
            app.RegisterCLRFieldSetter(field, set_img_2);
            field = type.GetField("call", flag);
            app.RegisterCLRFieldGetter(field, get_call_3);
            app.RegisterCLRFieldSetter(field, set_call_3);


            app.RegisterCLRCreateDefaultInstance(type, () => new LCL.SetImageSpriteParam());
            app.RegisterCLRCreateArrayInstance(type, s => new LCL.SetImageSpriteParam[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_abName_0(ref object o)
        {
            return ((LCL.SetImageSpriteParam)o).abName;
        }
        static void set_abName_0(ref object o, object v)
        {
LCL.SetImageSpriteParam _o = (LCL.SetImageSpriteParam)o;
    _o.abName = (System.String)v;
        }
        static object get_assetName_1(ref object o)
        {
            return ((LCL.SetImageSpriteParam)o).assetName;
        }
        static void set_assetName_1(ref object o, object v)
        {
LCL.SetImageSpriteParam _o = (LCL.SetImageSpriteParam)o;
    _o.assetName = (System.String)v;
        }
        static object get_img_2(ref object o)
        {
            return ((LCL.SetImageSpriteParam)o).img;
        }
        static void set_img_2(ref object o, object v)
        {
LCL.SetImageSpriteParam _o = (LCL.SetImageSpriteParam)o;
    _o.img = (UnityEngine.UI.Image)v;
        }
        static object get_call_3(ref object o)
        {
            return ((LCL.SetImageSpriteParam)o).call;
        }
        static void set_call_3(ref object o, object v)
        {
LCL.SetImageSpriteParam _o = (LCL.SetImageSpriteParam)o;
    _o.call = (System.Action<LCL.SetImageSpriteParam, UnityEngine.Sprite>)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new LCL.SetImageSpriteParam();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
