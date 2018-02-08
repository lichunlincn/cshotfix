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
    unsafe class UnityEngine_Cubemap_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Cubemap);
            args = new Type[]{typeof(UnityEngine.CubemapFace), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color)};
            method = type.GetMethod("SetPixel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPixel_0);
            args = new Type[]{typeof(UnityEngine.CubemapFace), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("GetPixel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPixel_1);
            args = new Type[]{typeof(UnityEngine.CubemapFace), typeof(System.Int32)};
            method = type.GetMethod("GetPixels", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPixels_2);
            args = new Type[]{typeof(UnityEngine.CubemapFace)};
            method = type.GetMethod("GetPixels", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPixels_3);
            args = new Type[]{typeof(UnityEngine.Color[]), typeof(UnityEngine.CubemapFace), typeof(System.Int32)};
            method = type.GetMethod("SetPixels", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPixels_4);
            args = new Type[]{typeof(UnityEngine.Color[]), typeof(UnityEngine.CubemapFace)};
            method = type.GetMethod("SetPixels", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPixels_5);
            args = new Type[]{};
            method = type.GetMethod("get_mipmapCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mipmapCount_6);
            args = new Type[]{typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("Apply", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Apply_7);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("Apply", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Apply_8);
            args = new Type[]{};
            method = type.GetMethod("Apply", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Apply_9);
            args = new Type[]{};
            method = type.GetMethod("get_format", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_format_10);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("SmoothEdges", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SmoothEdges_11);
            args = new Type[]{};
            method = type.GetMethod("SmoothEdges", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SmoothEdges_12);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Cubemap[s]);

            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.TextureFormat), typeof(System.Boolean)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* SetPixel_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color color = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 y = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 x = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.CubemapFace face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Cubemap instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cubemap)typeof(UnityEngine.Cubemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPixel(face, x, y, color);

            return __ret;
        }

        static StackObject* GetPixel_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 y = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 x = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.CubemapFace face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Cubemap instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cubemap)typeof(UnityEngine.Cubemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPixel(face, x, y);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPixels_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 miplevel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CubemapFace face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Cubemap instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cubemap)typeof(UnityEngine.Cubemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPixels(face, miplevel);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPixels_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CubemapFace face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cubemap instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cubemap)typeof(UnityEngine.Cubemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPixels(face);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetPixels_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 miplevel = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CubemapFace face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Color[] colors = (UnityEngine.Color[])typeof(UnityEngine.Color[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Cubemap instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cubemap)typeof(UnityEngine.Cubemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPixels(colors, face, miplevel);

            return __ret;
        }

        static StackObject* SetPixels_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CubemapFace face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Color[] colors = (UnityEngine.Color[])typeof(UnityEngine.Color[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Cubemap instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cubemap)typeof(UnityEngine.Cubemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPixels(colors, face);

            return __ret;
        }

        static StackObject* get_mipmapCount_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cubemap instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cubemap)typeof(UnityEngine.Cubemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.mipmapCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Apply_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean makeNoLongerReadable = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean updateMipmaps = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Cubemap instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cubemap)typeof(UnityEngine.Cubemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Apply(updateMipmaps, makeNoLongerReadable);

            return __ret;
        }

        static StackObject* Apply_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean updateMipmaps = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cubemap instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cubemap)typeof(UnityEngine.Cubemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Apply(updateMipmaps);

            return __ret;
        }

        static StackObject* Apply_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cubemap instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cubemap)typeof(UnityEngine.Cubemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Apply();

            return __ret;
        }

        static StackObject* get_format_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cubemap instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cubemap)typeof(UnityEngine.Cubemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.format;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SmoothEdges_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 smoothRegionWidthInPixels = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Cubemap instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cubemap)typeof(UnityEngine.Cubemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SmoothEdges(smoothRegionWidthInPixels);

            return __ret;
        }

        static StackObject* SmoothEdges_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Cubemap instance_of_this_method;
            instance_of_this_method = (UnityEngine.Cubemap)typeof(UnityEngine.Cubemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SmoothEdges();

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean mipmap = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.TextureFormat format = (UnityEngine.TextureFormat)typeof(UnityEngine.TextureFormat).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 size = ptr_of_this_method->Value;

            var result_of_this_method = new UnityEngine.Cubemap(size, format, mipmap);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
