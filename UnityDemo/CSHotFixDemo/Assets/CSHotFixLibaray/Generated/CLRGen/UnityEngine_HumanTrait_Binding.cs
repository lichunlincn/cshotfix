
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
    unsafe class UnityEngine_HumanTrait_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.HumanTrait);
            args = new Type[]{};
            method = type.GetMethod("get_MuscleCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MuscleCount_0);
            args = new Type[]{};
            method = type.GetMethod("get_MuscleName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MuscleName_1);
            args = new Type[]{};
            method = type.GetMethod("get_BoneCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_BoneCount_2);
            args = new Type[]{};
            method = type.GetMethod("get_BoneName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_BoneName_3);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("MuscleFromBone", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MuscleFromBone_4);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("BoneFromMuscle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BoneFromMuscle_5);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("RequiredBone", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RequiredBone_6);
            args = new Type[]{};
            method = type.GetMethod("get_RequiredBoneCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_RequiredBoneCount_7);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetMuscleDefaultMin", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetMuscleDefaultMin_8);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetMuscleDefaultMax", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetMuscleDefaultMax_9);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetParentBone", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetParentBone_10);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.HumanTrait());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.HumanTrait[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_MuscleCount_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.HumanTrait.MuscleCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_MuscleName_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.HumanTrait.MuscleName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_BoneCount_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.HumanTrait.BoneCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_BoneName_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.HumanTrait.BoneName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* MuscleFromBone_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 dofIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 i = ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.HumanTrait.MuscleFromBone(i, dofIndex);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* BoneFromMuscle_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 i = ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.HumanTrait.BoneFromMuscle(i);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* RequiredBone_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 i = ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.HumanTrait.RequiredBone(i);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_RequiredBoneCount_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = UnityEngine.HumanTrait.RequiredBoneCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetMuscleDefaultMin_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 i = ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.HumanTrait.GetMuscleDefaultMin(i);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetMuscleDefaultMax_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 i = ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.HumanTrait.GetMuscleDefaultMax(i);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetParentBone_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 i = ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.HumanTrait.GetParentBone(i);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.HumanTrait();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
