
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
    unsafe class UnityEngine_LightmapSettings_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.LightmapSettings);
            args = new Type[]{};
            method = type.GetMethod("get_lightmaps", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lightmaps_0);
            args = new Type[]{typeof(UnityEngine.LightmapData[])};
            method = type.GetMethod("set_lightmaps", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lightmaps_1);
            args = new Type[]{};
            method = type.GetMethod("get_lightmapsMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lightmapsMode_2);
            args = new Type[]{typeof(UnityEngine.LightmapsMode)};
            method = type.GetMethod("set_lightmapsMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lightmapsMode_3);
            args = new Type[]{};
            method = type.GetMethod("get_lightProbes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lightProbes_4);
            args = new Type[]{typeof(UnityEngine.LightProbes)};
            method = type.GetMethod("set_lightProbes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lightProbes_5);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.LightmapSettings[s]);


        }


        static StackObject* get_lightmaps_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.LightmapSettings.lightmaps;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_lightmaps_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightmapData[] @value = (UnityEngine.LightmapData[])typeof(UnityEngine.LightmapData[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.LightmapSettings.lightmaps = value;

            return __ret;
        }

        static StackObject* get_lightmapsMode_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.LightmapSettings.lightmapsMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_lightmapsMode_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightmapsMode @value = (UnityEngine.LightmapsMode)typeof(UnityEngine.LightmapsMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.LightmapSettings.lightmapsMode = value;

            return __ret;
        }

        static StackObject* get_lightProbes_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.LightmapSettings.lightProbes;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_lightProbes_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbes @value = (UnityEngine.LightProbes)typeof(UnityEngine.LightProbes).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.LightmapSettings.lightProbes = value;

            return __ret;
        }





    }
}
#endif
