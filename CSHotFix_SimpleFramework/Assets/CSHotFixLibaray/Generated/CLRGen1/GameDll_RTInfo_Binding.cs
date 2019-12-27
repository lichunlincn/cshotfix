
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
    unsafe class GameDll_RTInfo_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(GameDll.RTInfo);

            field = type.GetField("m_bIsInUse", flag);
            app.RegisterCLRFieldGetter(field, get_m_bIsInUse_0);
            app.RegisterCLRFieldSetter(field, set_m_bIsInUse_0);
            field = type.GetField("m_RenderTexture", flag);
            app.RegisterCLRFieldGetter(field, get_m_RenderTexture_1);
            app.RegisterCLRFieldSetter(field, set_m_RenderTexture_1);
            field = type.GetField("m_Position", flag);
            app.RegisterCLRFieldGetter(field, get_m_Position_2);
            app.RegisterCLRFieldSetter(field, set_m_Position_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new GameDll.RTInfo());
            app.RegisterCLRCreateArrayInstance(type, s => new GameDll.RTInfo[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_m_bIsInUse_0(ref object o)
        {
            return ((GameDll.RTInfo)o).m_bIsInUse;
        }
        static void set_m_bIsInUse_0(ref object o, object v)
        {
GameDll.RTInfo _o = (GameDll.RTInfo)o;
    _o.m_bIsInUse = (System.Boolean)v;
        }
        static object get_m_RenderTexture_1(ref object o)
        {
            return ((GameDll.RTInfo)o).m_RenderTexture;
        }
        static void set_m_RenderTexture_1(ref object o, object v)
        {
GameDll.RTInfo _o = (GameDll.RTInfo)o;
    _o.m_RenderTexture = (UnityEngine.RenderTexture)v;
        }
        static object get_m_Position_2(ref object o)
        {
            return ((GameDll.RTInfo)o).m_Position;
        }
        static void set_m_Position_2(ref object o, object v)
        {
GameDll.RTInfo _o = (GameDll.RTInfo)o;
    _o.m_Position = (UnityEngine.Vector3)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new GameDll.RTInfo();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
