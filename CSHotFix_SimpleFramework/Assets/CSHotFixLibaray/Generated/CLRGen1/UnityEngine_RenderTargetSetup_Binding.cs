
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
    unsafe class UnityEngine_RenderTargetSetup_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.RenderTargetSetup);

            field = type.GetField("color", flag);
            app.RegisterCLRFieldGetter(field, get_color_0);
            app.RegisterCLRFieldSetter(field, set_color_0);
            field = type.GetField("depth", flag);
            app.RegisterCLRFieldGetter(field, get_depth_1);
            app.RegisterCLRFieldSetter(field, set_depth_1);
            field = type.GetField("mipLevel", flag);
            app.RegisterCLRFieldGetter(field, get_mipLevel_2);
            app.RegisterCLRFieldSetter(field, set_mipLevel_2);
            field = type.GetField("cubemapFace", flag);
            app.RegisterCLRFieldGetter(field, get_cubemapFace_3);
            app.RegisterCLRFieldSetter(field, set_cubemapFace_3);
            field = type.GetField("depthSlice", flag);
            app.RegisterCLRFieldGetter(field, get_depthSlice_4);
            app.RegisterCLRFieldSetter(field, set_depthSlice_4);
            field = type.GetField("colorLoad", flag);
            app.RegisterCLRFieldGetter(field, get_colorLoad_5);
            app.RegisterCLRFieldSetter(field, set_colorLoad_5);
            field = type.GetField("colorStore", flag);
            app.RegisterCLRFieldGetter(field, get_colorStore_6);
            app.RegisterCLRFieldSetter(field, set_colorStore_6);
            field = type.GetField("depthLoad", flag);
            app.RegisterCLRFieldGetter(field, get_depthLoad_7);
            app.RegisterCLRFieldSetter(field, set_depthLoad_7);
            field = type.GetField("depthStore", flag);
            app.RegisterCLRFieldGetter(field, get_depthStore_8);
            app.RegisterCLRFieldSetter(field, set_depthStore_8);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.RenderTargetSetup());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.RenderTargetSetup[s]);

            args = new Type[]{typeof(UnityEngine.RenderBuffer[]), typeof(UnityEngine.RenderBuffer), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(UnityEngine.Rendering.RenderBufferLoadAction[]), typeof(UnityEngine.Rendering.RenderBufferStoreAction[]), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(UnityEngine.RenderBuffer), typeof(UnityEngine.RenderBuffer)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);
            args = new Type[]{typeof(UnityEngine.RenderBuffer), typeof(UnityEngine.RenderBuffer), typeof(System.Int32)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_2);
            args = new Type[]{typeof(UnityEngine.RenderBuffer), typeof(UnityEngine.RenderBuffer), typeof(System.Int32), typeof(UnityEngine.CubemapFace)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_3);
            args = new Type[]{typeof(UnityEngine.RenderBuffer), typeof(UnityEngine.RenderBuffer), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_4);
            args = new Type[]{typeof(UnityEngine.RenderBuffer[]), typeof(UnityEngine.RenderBuffer)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_5);
            args = new Type[]{typeof(UnityEngine.RenderBuffer[]), typeof(UnityEngine.RenderBuffer), typeof(System.Int32)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_6);
            args = new Type[]{typeof(UnityEngine.RenderBuffer[]), typeof(UnityEngine.RenderBuffer), typeof(System.Int32), typeof(UnityEngine.CubemapFace)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_7);

        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.RenderTargetSetup instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.RenderTargetSetup[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_color_0(ref object o)
        {
            return ((UnityEngine.RenderTargetSetup)o).color;
        }
        static void set_color_0(ref object o, object v)
        {
UnityEngine.RenderTargetSetup _o = (UnityEngine.RenderTargetSetup)o;
    _o.color = (UnityEngine.RenderBuffer[])v;
        }
        static object get_depth_1(ref object o)
        {
            return ((UnityEngine.RenderTargetSetup)o).depth;
        }
        static void set_depth_1(ref object o, object v)
        {
UnityEngine.RenderTargetSetup _o = (UnityEngine.RenderTargetSetup)o;
    _o.depth = (UnityEngine.RenderBuffer)v;
        }
        static object get_mipLevel_2(ref object o)
        {
            return ((UnityEngine.RenderTargetSetup)o).mipLevel;
        }
        static void set_mipLevel_2(ref object o, object v)
        {
UnityEngine.RenderTargetSetup _o = (UnityEngine.RenderTargetSetup)o;
    _o.mipLevel = (System.Int32)v;
        }
        static object get_cubemapFace_3(ref object o)
        {
            return ((UnityEngine.RenderTargetSetup)o).cubemapFace;
        }
        static void set_cubemapFace_3(ref object o, object v)
        {
UnityEngine.RenderTargetSetup _o = (UnityEngine.RenderTargetSetup)o;
    _o.cubemapFace = (UnityEngine.CubemapFace)v;
        }
        static object get_depthSlice_4(ref object o)
        {
            return ((UnityEngine.RenderTargetSetup)o).depthSlice;
        }
        static void set_depthSlice_4(ref object o, object v)
        {
UnityEngine.RenderTargetSetup _o = (UnityEngine.RenderTargetSetup)o;
    _o.depthSlice = (System.Int32)v;
        }
        static object get_colorLoad_5(ref object o)
        {
            return ((UnityEngine.RenderTargetSetup)o).colorLoad;
        }
        static void set_colorLoad_5(ref object o, object v)
        {
UnityEngine.RenderTargetSetup _o = (UnityEngine.RenderTargetSetup)o;
    _o.colorLoad = (UnityEngine.Rendering.RenderBufferLoadAction[])v;
        }
        static object get_colorStore_6(ref object o)
        {
            return ((UnityEngine.RenderTargetSetup)o).colorStore;
        }
        static void set_colorStore_6(ref object o, object v)
        {
UnityEngine.RenderTargetSetup _o = (UnityEngine.RenderTargetSetup)o;
    _o.colorStore = (UnityEngine.Rendering.RenderBufferStoreAction[])v;
        }
        static object get_depthLoad_7(ref object o)
        {
            return ((UnityEngine.RenderTargetSetup)o).depthLoad;
        }
        static void set_depthLoad_7(ref object o, object v)
        {
UnityEngine.RenderTargetSetup _o = (UnityEngine.RenderTargetSetup)o;
    _o.depthLoad = (UnityEngine.Rendering.RenderBufferLoadAction)v;
        }
        static object get_depthStore_8(ref object o)
        {
            return ((UnityEngine.RenderTargetSetup)o).depthStore;
        }
        static void set_depthStore_8(ref object o, object v)
        {
UnityEngine.RenderTargetSetup _o = (UnityEngine.RenderTargetSetup)o;
    _o.depthStore = (UnityEngine.Rendering.RenderBufferStoreAction)v;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.RenderTargetSetup();
            ins = (UnityEngine.RenderTargetSetup)o;
            return ins;
        }

        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.RenderBufferStoreAction @depthStore = (UnityEngine.Rendering.RenderBufferStoreAction)typeof(UnityEngine.Rendering.RenderBufferStoreAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.RenderBufferLoadAction @depthLoad = (UnityEngine.Rendering.RenderBufferLoadAction)typeof(UnityEngine.Rendering.RenderBufferLoadAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.RenderBufferStoreAction[] @colorStore = (UnityEngine.Rendering.RenderBufferStoreAction[])typeof(UnityEngine.Rendering.RenderBufferStoreAction[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.RenderBufferLoadAction[] @colorLoad = (UnityEngine.Rendering.RenderBufferLoadAction[])typeof(UnityEngine.Rendering.RenderBufferLoadAction[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.CubemapFace @face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @mip = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.RenderBuffer @depth = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.RenderBuffer[] @color = (UnityEngine.RenderBuffer[])typeof(UnityEngine.RenderBuffer[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new UnityEngine.RenderTargetSetup(@color, @depth, @mip, @face, @colorLoad, @colorStore, @depthLoad, @depthStore);

            if(!isNewObj)
            {
                __ret--;
                WriteBackInstance(__domain, __ret, __mStack, ref result_of_this_method);
                return __ret;
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderBuffer @depth = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RenderBuffer @color = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new UnityEngine.RenderTargetSetup(@color, @depth);

            if(!isNewObj)
            {
                __ret--;
                WriteBackInstance(__domain, __ret, __mStack, ref result_of_this_method);
                return __ret;
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @mipLevel = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RenderBuffer @depth = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RenderBuffer @color = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new UnityEngine.RenderTargetSetup(@color, @depth, @mipLevel);

            if(!isNewObj)
            {
                __ret--;
                WriteBackInstance(__domain, __ret, __mStack, ref result_of_this_method);
                return __ret;
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CubemapFace @face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @mipLevel = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RenderBuffer @depth = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.RenderBuffer @color = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new UnityEngine.RenderTargetSetup(@color, @depth, @mipLevel, @face);

            if(!isNewObj)
            {
                __ret--;
                WriteBackInstance(__domain, __ret, __mStack, ref result_of_this_method);
                return __ret;
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @depthSlice = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CubemapFace @face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @mipLevel = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.RenderBuffer @depth = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.RenderBuffer @color = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new UnityEngine.RenderTargetSetup(@color, @depth, @mipLevel, @face, @depthSlice);

            if(!isNewObj)
            {
                __ret--;
                WriteBackInstance(__domain, __ret, __mStack, ref result_of_this_method);
                return __ret;
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderBuffer @depth = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RenderBuffer[] @color = (UnityEngine.RenderBuffer[])typeof(UnityEngine.RenderBuffer[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new UnityEngine.RenderTargetSetup(@color, @depth);

            if(!isNewObj)
            {
                __ret--;
                WriteBackInstance(__domain, __ret, __mStack, ref result_of_this_method);
                return __ret;
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @mipLevel = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RenderBuffer @depth = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RenderBuffer[] @color = (UnityEngine.RenderBuffer[])typeof(UnityEngine.RenderBuffer[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new UnityEngine.RenderTargetSetup(@color, @depth, @mipLevel);

            if(!isNewObj)
            {
                __ret--;
                WriteBackInstance(__domain, __ret, __mStack, ref result_of_this_method);
                return __ret;
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CubemapFace @face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @mip = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RenderBuffer @depth = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.RenderBuffer[] @color = (UnityEngine.RenderBuffer[])typeof(UnityEngine.RenderBuffer[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new UnityEngine.RenderTargetSetup(@color, @depth, @mip, @face);

            if(!isNewObj)
            {
                __ret--;
                WriteBackInstance(__domain, __ret, __mStack, ref result_of_this_method);
                return __ret;
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
