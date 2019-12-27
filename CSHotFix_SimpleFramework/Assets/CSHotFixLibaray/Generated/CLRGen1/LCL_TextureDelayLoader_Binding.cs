
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
    unsafe class LCL_TextureDelayLoader_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(LCL.TextureDelayLoader);

            field = type.GetField("m_Image", flag);
            app.RegisterCLRFieldGetter(field, get_m_Image_0);
            app.RegisterCLRFieldSetter(field, set_m_Image_0);
            field = type.GetField("m_ABName", flag);
            app.RegisterCLRFieldGetter(field, get_m_ABName_1);
            app.RegisterCLRFieldSetter(field, set_m_ABName_1);
            field = type.GetField("m_AssetName", flag);
            app.RegisterCLRFieldGetter(field, get_m_AssetName_2);
            app.RegisterCLRFieldSetter(field, set_m_AssetName_2);
            field = type.GetField("m_DelayTime", flag);
            app.RegisterCLRFieldGetter(field, get_m_DelayTime_3);
            app.RegisterCLRFieldSetter(field, set_m_DelayTime_3);


            app.RegisterCLRCreateDefaultInstance(type, () => new LCL.TextureDelayLoader());
            app.RegisterCLRCreateArrayInstance(type, s => new LCL.TextureDelayLoader[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_m_Image_0(ref object o)
        {
            return ((LCL.TextureDelayLoader)o).m_Image;
        }
        static void set_m_Image_0(ref object o, object v)
        {
LCL.TextureDelayLoader _o = (LCL.TextureDelayLoader)o;
    _o.m_Image = (UnityEngine.UI.Image)v;
        }
        static object get_m_ABName_1(ref object o)
        {
            return ((LCL.TextureDelayLoader)o).m_ABName;
        }
        static void set_m_ABName_1(ref object o, object v)
        {
LCL.TextureDelayLoader _o = (LCL.TextureDelayLoader)o;
    _o.m_ABName = (System.String)v;
        }
        static object get_m_AssetName_2(ref object o)
        {
            return ((LCL.TextureDelayLoader)o).m_AssetName;
        }
        static void set_m_AssetName_2(ref object o, object v)
        {
LCL.TextureDelayLoader _o = (LCL.TextureDelayLoader)o;
    _o.m_AssetName = (System.String)v;
        }
        static object get_m_DelayTime_3(ref object o)
        {
            return ((LCL.TextureDelayLoader)o).m_DelayTime;
        }
        static void set_m_DelayTime_3(ref object o, object v)
        {
LCL.TextureDelayLoader _o = (LCL.TextureDelayLoader)o;
    _o.m_DelayTime = (System.Single)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new LCL.TextureDelayLoader();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
