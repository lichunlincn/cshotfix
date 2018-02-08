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
    unsafe class UnityEngine_AudioReverbFilter_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.AudioReverbFilter);
            args = new Type[]{};
            method = type.GetMethod("get_reverbPreset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_reverbPreset_0);
            args = new Type[]{typeof(UnityEngine.AudioReverbPreset)};
            method = type.GetMethod("set_reverbPreset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_reverbPreset_1);
            args = new Type[]{};
            method = type.GetMethod("get_dryLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_dryLevel_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_dryLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_dryLevel_3);
            args = new Type[]{};
            method = type.GetMethod("get_room", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_room_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_room", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_room_5);
            args = new Type[]{};
            method = type.GetMethod("get_roomHF", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_roomHF_6);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_roomHF", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_roomHF_7);
            args = new Type[]{};
            method = type.GetMethod("get_decayTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_decayTime_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_decayTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_decayTime_9);
            args = new Type[]{};
            method = type.GetMethod("get_decayHFRatio", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_decayHFRatio_10);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_decayHFRatio", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_decayHFRatio_11);
            args = new Type[]{};
            method = type.GetMethod("get_reflectionsLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_reflectionsLevel_12);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_reflectionsLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_reflectionsLevel_13);
            args = new Type[]{};
            method = type.GetMethod("get_reflectionsDelay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_reflectionsDelay_14);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_reflectionsDelay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_reflectionsDelay_15);
            args = new Type[]{};
            method = type.GetMethod("get_reverbLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_reverbLevel_16);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_reverbLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_reverbLevel_17);
            args = new Type[]{};
            method = type.GetMethod("get_reverbDelay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_reverbDelay_18);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_reverbDelay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_reverbDelay_19);
            args = new Type[]{};
            method = type.GetMethod("get_diffusion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_diffusion_20);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_diffusion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_diffusion_21);
            args = new Type[]{};
            method = type.GetMethod("get_density", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_density_22);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_density", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_density_23);
            args = new Type[]{};
            method = type.GetMethod("get_hfReference", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hfReference_24);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_hfReference", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hfReference_25);
            args = new Type[]{};
            method = type.GetMethod("get_roomLF", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_roomLF_26);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_roomLF", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_roomLF_27);
            args = new Type[]{};
            method = type.GetMethod("get_lfReference", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lfReference_28);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_lfReference", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lfReference_29);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.AudioReverbFilter());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AudioReverbFilter[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_reverbPreset_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.reverbPreset;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_reverbPreset_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbPreset value = (UnityEngine.AudioReverbPreset)typeof(UnityEngine.AudioReverbPreset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.reverbPreset = value;

            return __ret;
        }

        static StackObject* get_dryLevel_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.dryLevel;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_dryLevel_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.dryLevel = value;

            return __ret;
        }

        static StackObject* get_room_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.room;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_room_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.room = value;

            return __ret;
        }

        static StackObject* get_roomHF_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.roomHF;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_roomHF_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.roomHF = value;

            return __ret;
        }

        static StackObject* get_decayTime_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.decayTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_decayTime_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.decayTime = value;

            return __ret;
        }

        static StackObject* get_decayHFRatio_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.decayHFRatio;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_decayHFRatio_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.decayHFRatio = value;

            return __ret;
        }

        static StackObject* get_reflectionsLevel_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.reflectionsLevel;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_reflectionsLevel_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.reflectionsLevel = value;

            return __ret;
        }

        static StackObject* get_reflectionsDelay_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.reflectionsDelay;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_reflectionsDelay_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.reflectionsDelay = value;

            return __ret;
        }

        static StackObject* get_reverbLevel_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.reverbLevel;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_reverbLevel_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.reverbLevel = value;

            return __ret;
        }

        static StackObject* get_reverbDelay_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.reverbDelay;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_reverbDelay_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.reverbDelay = value;

            return __ret;
        }

        static StackObject* get_diffusion_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.diffusion;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_diffusion_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.diffusion = value;

            return __ret;
        }

        static StackObject* get_density_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.density;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_density_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.density = value;

            return __ret;
        }

        static StackObject* get_hfReference_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hfReference;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_hfReference_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hfReference = value;

            return __ret;
        }

        static StackObject* get_roomLF_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.roomLF;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_roomLF_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.roomLF = value;

            return __ret;
        }

        static StackObject* get_lfReference_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lfReference;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_lfReference_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbFilter)typeof(UnityEngine.AudioReverbFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.lfReference = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.AudioReverbFilter();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
