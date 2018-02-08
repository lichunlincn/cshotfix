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
    unsafe class UnityEngine_ProceduralTexture_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.ProceduralTexture);
            args = new Type[]{};
            method = type.GetMethod("GetProceduralOutputType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetProceduralOutputType_0);
            args = new Type[]{};
            method = type.GetMethod("get_hasAlpha", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasAlpha_1);
            args = new Type[]{};
            method = type.GetMethod("get_format", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_format_2);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("GetPixels32", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPixels32_3);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.ProceduralTexture());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.ProceduralTexture[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* GetProceduralOutputType_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ProceduralTexture instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralTexture)typeof(UnityEngine.ProceduralTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetProceduralOutputType();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_hasAlpha_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ProceduralTexture instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralTexture)typeof(UnityEngine.ProceduralTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hasAlpha;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_format_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ProceduralTexture instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralTexture)typeof(UnityEngine.ProceduralTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.format;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPixels32_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 blockHeight = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 blockWidth = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 y = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 x = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.ProceduralTexture instance_of_this_method;
            instance_of_this_method = (UnityEngine.ProceduralTexture)typeof(UnityEngine.ProceduralTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPixels32(x, y, blockWidth, blockHeight);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.ProceduralTexture();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
