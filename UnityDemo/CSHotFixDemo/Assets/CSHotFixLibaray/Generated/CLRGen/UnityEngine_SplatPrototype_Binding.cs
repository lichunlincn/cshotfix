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
    unsafe class UnityEngine_SplatPrototype_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.SplatPrototype);
            args = new Type[]{};
            method = type.GetMethod("get_texture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_texture_0);
            args = new Type[]{typeof(UnityEngine.Texture2D)};
            method = type.GetMethod("set_texture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_texture_1);
            args = new Type[]{};
            method = type.GetMethod("get_normalMap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_normalMap_2);
            args = new Type[]{typeof(UnityEngine.Texture2D)};
            method = type.GetMethod("set_normalMap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_normalMap_3);
            args = new Type[]{};
            method = type.GetMethod("get_tileSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_tileSize_4);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("set_tileSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_tileSize_5);
            args = new Type[]{};
            method = type.GetMethod("get_tileOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_tileOffset_6);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("set_tileOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_tileOffset_7);
            args = new Type[]{};
            method = type.GetMethod("get_specular", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_specular_8);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("set_specular", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_specular_9);
            args = new Type[]{};
            method = type.GetMethod("get_metallic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_metallic_10);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_metallic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_metallic_11);
            args = new Type[]{};
            method = type.GetMethod("get_smoothness", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_smoothness_12);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_smoothness", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_smoothness_13);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.SplatPrototype());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.SplatPrototype[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_texture_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SplatPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.SplatPrototype)typeof(UnityEngine.SplatPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.texture;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_texture_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture2D value = (UnityEngine.Texture2D)typeof(UnityEngine.Texture2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SplatPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.SplatPrototype)typeof(UnityEngine.SplatPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.texture = value;

            return __ret;
        }

        static StackObject* get_normalMap_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SplatPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.SplatPrototype)typeof(UnityEngine.SplatPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.normalMap;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_normalMap_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture2D value = (UnityEngine.Texture2D)typeof(UnityEngine.Texture2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SplatPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.SplatPrototype)typeof(UnityEngine.SplatPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.normalMap = value;

            return __ret;
        }

        static StackObject* get_tileSize_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SplatPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.SplatPrototype)typeof(UnityEngine.SplatPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.tileSize;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_tileSize_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 value = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SplatPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.SplatPrototype)typeof(UnityEngine.SplatPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.tileSize = value;

            return __ret;
        }

        static StackObject* get_tileOffset_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SplatPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.SplatPrototype)typeof(UnityEngine.SplatPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.tileOffset;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_tileOffset_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 value = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SplatPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.SplatPrototype)typeof(UnityEngine.SplatPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.tileOffset = value;

            return __ret;
        }

        static StackObject* get_specular_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SplatPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.SplatPrototype)typeof(UnityEngine.SplatPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.specular;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_specular_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SplatPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.SplatPrototype)typeof(UnityEngine.SplatPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.specular = value;

            return __ret;
        }

        static StackObject* get_metallic_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SplatPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.SplatPrototype)typeof(UnityEngine.SplatPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.metallic;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_metallic_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SplatPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.SplatPrototype)typeof(UnityEngine.SplatPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.metallic = value;

            return __ret;
        }

        static StackObject* get_smoothness_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SplatPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.SplatPrototype)typeof(UnityEngine.SplatPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.smoothness;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_smoothness_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SplatPrototype instance_of_this_method;
            instance_of_this_method = (UnityEngine.SplatPrototype)typeof(UnityEngine.SplatPrototype).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.smoothness = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.SplatPrototype();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
