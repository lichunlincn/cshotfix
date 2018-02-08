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
    unsafe class UnityEngine_CubemapArray_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.CubemapArray);
            args = new Type[]{};
            method = type.GetMethod("get_cubemapCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cubemapCount_0);
            args = new Type[]{};
            method = type.GetMethod("get_format", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_format_1);
            args = new Type[]{typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("Apply", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Apply_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("Apply", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Apply_3);
            args = new Type[]{};
            method = type.GetMethod("Apply", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Apply_4);
            args = new Type[]{typeof(UnityEngine.Color[]), typeof(UnityEngine.CubemapFace), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetPixels", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPixels_5);
            args = new Type[]{typeof(UnityEngine.Color[]), typeof(UnityEngine.CubemapFace), typeof(System.Int32)};
            method = type.GetMethod("SetPixels", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPixels_6);
            args = new Type[]{typeof(UnityEngine.Color32[]), typeof(UnityEngine.CubemapFace), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetPixels32", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPixels32_7);
            args = new Type[]{typeof(UnityEngine.Color32[]), typeof(UnityEngine.CubemapFace), typeof(System.Int32)};
            method = type.GetMethod("SetPixels32", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPixels32_8);
            args = new Type[]{typeof(UnityEngine.CubemapFace), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("GetPixels", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPixels_9);
            args = new Type[]{typeof(UnityEngine.CubemapFace), typeof(System.Int32)};
            method = type.GetMethod("GetPixels", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPixels_10);
            args = new Type[]{typeof(UnityEngine.CubemapFace), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("GetPixels32", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPixels32_11);
            args = new Type[]{typeof(UnityEngine.CubemapFace), typeof(System.Int32)};
            method = type.GetMethod("GetPixels32", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPixels32_12);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.CubemapArray[s]);

            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextureFormat), typeof(System.Boolean)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextureFormat), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);

        }


        static StackObject* get_cubemapCount_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CubemapArray instance_of_this_method;
            instance_of_this_method = (UnityEngine.CubemapArray)typeof(UnityEngine.CubemapArray).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.cubemapCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_format_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CubemapArray instance_of_this_method;
            instance_of_this_method = (UnityEngine.CubemapArray)typeof(UnityEngine.CubemapArray).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.format;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Apply_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean makeNoLongerReadable = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean updateMipmaps = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.CubemapArray instance_of_this_method;
            instance_of_this_method = (UnityEngine.CubemapArray)typeof(UnityEngine.CubemapArray).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Apply(updateMipmaps, makeNoLongerReadable);

            return __ret;
        }

        static StackObject* Apply_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean updateMipmaps = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CubemapArray instance_of_this_method;
            instance_of_this_method = (UnityEngine.CubemapArray)typeof(UnityEngine.CubemapArray).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Apply(updateMipmaps);

            return __ret;
        }

        static StackObject* Apply_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CubemapArray instance_of_this_method;
            instance_of_this_method = (UnityEngine.CubemapArray)typeof(UnityEngine.CubemapArray).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Apply();

            return __ret;
        }

        static StackObject* SetPixels_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 miplevel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 arrayElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.CubemapFace face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Color[] colors = (UnityEngine.Color[])typeof(UnityEngine.Color[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.CubemapArray instance_of_this_method;
            instance_of_this_method = (UnityEngine.CubemapArray)typeof(UnityEngine.CubemapArray).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPixels(colors, face, arrayElement, miplevel);

            return __ret;
        }

        static StackObject* SetPixels_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 arrayElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CubemapFace face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Color[] colors = (UnityEngine.Color[])typeof(UnityEngine.Color[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.CubemapArray instance_of_this_method;
            instance_of_this_method = (UnityEngine.CubemapArray)typeof(UnityEngine.CubemapArray).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPixels(colors, face, arrayElement);

            return __ret;
        }

        static StackObject* SetPixels32_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 miplevel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 arrayElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.CubemapFace face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Color32[] colors = (UnityEngine.Color32[])typeof(UnityEngine.Color32[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.CubemapArray instance_of_this_method;
            instance_of_this_method = (UnityEngine.CubemapArray)typeof(UnityEngine.CubemapArray).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPixels32(colors, face, arrayElement, miplevel);

            return __ret;
        }

        static StackObject* SetPixels32_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 arrayElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CubemapFace face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Color32[] colors = (UnityEngine.Color32[])typeof(UnityEngine.Color32[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.CubemapArray instance_of_this_method;
            instance_of_this_method = (UnityEngine.CubemapArray)typeof(UnityEngine.CubemapArray).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPixels32(colors, face, arrayElement);

            return __ret;
        }

        static StackObject* GetPixels_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 miplevel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 arrayElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.CubemapFace face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.CubemapArray instance_of_this_method;
            instance_of_this_method = (UnityEngine.CubemapArray)typeof(UnityEngine.CubemapArray).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPixels(face, arrayElement, miplevel);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPixels_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 arrayElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CubemapFace face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.CubemapArray instance_of_this_method;
            instance_of_this_method = (UnityEngine.CubemapArray)typeof(UnityEngine.CubemapArray).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPixels(face, arrayElement);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPixels32_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 miplevel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 arrayElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.CubemapFace face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.CubemapArray instance_of_this_method;
            instance_of_this_method = (UnityEngine.CubemapArray)typeof(UnityEngine.CubemapArray).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPixels32(face, arrayElement, miplevel);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPixels32_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 arrayElement = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CubemapFace face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.CubemapArray instance_of_this_method;
            instance_of_this_method = (UnityEngine.CubemapArray)typeof(UnityEngine.CubemapArray).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPixels32(face, arrayElement);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean mipmap = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextureFormat format = (UnityEngine.TextureFormat)typeof(UnityEngine.TextureFormat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 cubemapCount = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 faceSize = ptr_of_this_method->Value;

            var result_of_this_method = new UnityEngine.CubemapArray(faceSize, cubemapCount, format, mipmap);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean linear = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean mipmap = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.TextureFormat format = (UnityEngine.TextureFormat)typeof(UnityEngine.TextureFormat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 cubemapCount = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 faceSize = ptr_of_this_method->Value;

            var result_of_this_method = new UnityEngine.CubemapArray(faceSize, cubemapCount, format, mipmap, linear);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
