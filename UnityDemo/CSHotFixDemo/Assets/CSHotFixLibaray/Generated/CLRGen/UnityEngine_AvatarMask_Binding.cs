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
    unsafe class UnityEngine_AvatarMask_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.AvatarMask);
            args = new Type[]{typeof(UnityEngine.AvatarMaskBodyPart)};
            method = type.GetMethod("GetHumanoidBodyPartActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetHumanoidBodyPartActive_0);
            args = new Type[]{typeof(UnityEngine.AvatarMaskBodyPart), typeof(System.Boolean)};
            method = type.GetMethod("SetHumanoidBodyPartActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetHumanoidBodyPartActive_1);
            args = new Type[]{};
            method = type.GetMethod("get_transformCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_transformCount_2);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_transformCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_transformCount_3);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("AddTransformPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddTransformPath_4);
            args = new Type[]{typeof(UnityEngine.Transform), typeof(System.Boolean)};
            method = type.GetMethod("AddTransformPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddTransformPath_5);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("RemoveTransformPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveTransformPath_6);
            args = new Type[]{typeof(UnityEngine.Transform), typeof(System.Boolean)};
            method = type.GetMethod("RemoveTransformPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveTransformPath_7);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetTransformPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTransformPath_8);
            args = new Type[]{typeof(System.Int32), typeof(System.String)};
            method = type.GetMethod("SetTransformPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTransformPath_9);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetTransformActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTransformActive_10);
            args = new Type[]{typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("SetTransformActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTransformActive_11);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.AvatarMask());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AvatarMask[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* GetHumanoidBodyPartActive_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AvatarMaskBodyPart index = (UnityEngine.AvatarMaskBodyPart)typeof(UnityEngine.AvatarMaskBodyPart).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AvatarMask instance_of_this_method;
            instance_of_this_method = (UnityEngine.AvatarMask)typeof(UnityEngine.AvatarMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetHumanoidBodyPartActive(index);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetHumanoidBodyPartActive_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AvatarMaskBodyPart index = (UnityEngine.AvatarMaskBodyPart)typeof(UnityEngine.AvatarMaskBodyPart).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AvatarMask instance_of_this_method;
            instance_of_this_method = (UnityEngine.AvatarMask)typeof(UnityEngine.AvatarMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetHumanoidBodyPartActive(index, value);

            return __ret;
        }

        static StackObject* get_transformCount_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AvatarMask instance_of_this_method;
            instance_of_this_method = (UnityEngine.AvatarMask)typeof(UnityEngine.AvatarMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.transformCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_transformCount_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AvatarMask instance_of_this_method;
            instance_of_this_method = (UnityEngine.AvatarMask)typeof(UnityEngine.AvatarMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.transformCount = value;

            return __ret;
        }

        static StackObject* AddTransformPath_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform transform = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AvatarMask instance_of_this_method;
            instance_of_this_method = (UnityEngine.AvatarMask)typeof(UnityEngine.AvatarMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddTransformPath(transform);

            return __ret;
        }

        static StackObject* AddTransformPath_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean recursive = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform transform = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AvatarMask instance_of_this_method;
            instance_of_this_method = (UnityEngine.AvatarMask)typeof(UnityEngine.AvatarMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddTransformPath(transform, recursive);

            return __ret;
        }

        static StackObject* RemoveTransformPath_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform transform = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AvatarMask instance_of_this_method;
            instance_of_this_method = (UnityEngine.AvatarMask)typeof(UnityEngine.AvatarMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveTransformPath(transform);

            return __ret;
        }

        static StackObject* RemoveTransformPath_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean recursive = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform transform = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AvatarMask instance_of_this_method;
            instance_of_this_method = (UnityEngine.AvatarMask)typeof(UnityEngine.AvatarMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveTransformPath(transform, recursive);

            return __ret;
        }

        static StackObject* GetTransformPath_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AvatarMask instance_of_this_method;
            instance_of_this_method = (UnityEngine.AvatarMask)typeof(UnityEngine.AvatarMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetTransformPath(index);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetTransformPath_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String path = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AvatarMask instance_of_this_method;
            instance_of_this_method = (UnityEngine.AvatarMask)typeof(UnityEngine.AvatarMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTransformPath(index, path);

            return __ret;
        }

        static StackObject* GetTransformActive_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AvatarMask instance_of_this_method;
            instance_of_this_method = (UnityEngine.AvatarMask)typeof(UnityEngine.AvatarMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetTransformActive(index);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetTransformActive_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AvatarMask instance_of_this_method;
            instance_of_this_method = (UnityEngine.AvatarMask)typeof(UnityEngine.AvatarMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTransformActive(index, value);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.AvatarMask();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
