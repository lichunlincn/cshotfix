
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
    unsafe class UnityEngine_AudioReverbZone_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.AudioReverbZone);
            args = new Type[]{};
            method = type.GetMethod("get_minDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_minDistance_0);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_minDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_minDistance_1);
            args = new Type[]{};
            method = type.GetMethod("get_maxDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxDistance_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_maxDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxDistance_3);
            args = new Type[]{};
            method = type.GetMethod("get_reverbPreset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_reverbPreset_4);
            args = new Type[]{typeof(UnityEngine.AudioReverbPreset)};
            method = type.GetMethod("set_reverbPreset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_reverbPreset_5);
            args = new Type[]{};
            method = type.GetMethod("get_room", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_room_6);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_room", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_room_7);
            args = new Type[]{};
            method = type.GetMethod("get_roomHF", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_roomHF_8);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_roomHF", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_roomHF_9);
            args = new Type[]{};
            method = type.GetMethod("get_roomLF", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_roomLF_10);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_roomLF", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_roomLF_11);
            args = new Type[]{};
            method = type.GetMethod("get_decayTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_decayTime_12);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_decayTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_decayTime_13);
            args = new Type[]{};
            method = type.GetMethod("get_decayHFRatio", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_decayHFRatio_14);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_decayHFRatio", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_decayHFRatio_15);
            args = new Type[]{};
            method = type.GetMethod("get_reflections", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_reflections_16);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_reflections", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_reflections_17);
            args = new Type[]{};
            method = type.GetMethod("get_reflectionsDelay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_reflectionsDelay_18);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_reflectionsDelay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_reflectionsDelay_19);
            args = new Type[]{};
            method = type.GetMethod("get_reverb", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_reverb_20);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_reverb", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_reverb_21);
            args = new Type[]{};
            method = type.GetMethod("get_reverbDelay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_reverbDelay_22);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_reverbDelay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_reverbDelay_23);
            args = new Type[]{};
            method = type.GetMethod("get_HFReference", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_HFReference_24);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_HFReference", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_HFReference_25);
            args = new Type[]{};
            method = type.GetMethod("get_LFReference", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_LFReference_26);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_LFReference", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_LFReference_27);
            args = new Type[]{};
            method = type.GetMethod("get_diffusion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_diffusion_28);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_diffusion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_diffusion_29);
            args = new Type[]{};
            method = type.GetMethod("get_density", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_density_30);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_density", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_density_31);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.AudioReverbZone());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AudioReverbZone[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_minDistance_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.minDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_minDistance_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.minDistance = value;

            return __ret;
        }

        static StackObject* get_maxDistance_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxDistance_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maxDistance = value;

            return __ret;
        }

        static StackObject* get_reverbPreset_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.reverbPreset;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_reverbPreset_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbPreset value = (UnityEngine.AudioReverbPreset)typeof(UnityEngine.AudioReverbPreset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.reverbPreset = value;

            return __ret;
        }

        static StackObject* get_room_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.room;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_room_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.room = value;

            return __ret;
        }

        static StackObject* get_roomHF_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.roomHF;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_roomHF_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.roomHF = value;

            return __ret;
        }

        static StackObject* get_roomLF_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.roomLF;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_roomLF_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.roomLF = value;

            return __ret;
        }

        static StackObject* get_decayTime_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.decayTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_decayTime_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.decayTime = value;

            return __ret;
        }

        static StackObject* get_decayHFRatio_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.decayHFRatio;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_decayHFRatio_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.decayHFRatio = value;

            return __ret;
        }

        static StackObject* get_reflections_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.reflections;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_reflections_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.reflections = value;

            return __ret;
        }

        static StackObject* get_reflectionsDelay_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.reflectionsDelay;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_reflectionsDelay_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.reflectionsDelay = value;

            return __ret;
        }

        static StackObject* get_reverb_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.reverb;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_reverb_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.reverb = value;

            return __ret;
        }

        static StackObject* get_reverbDelay_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.reverbDelay;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_reverbDelay_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.reverbDelay = value;

            return __ret;
        }

        static StackObject* get_HFReference_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.HFReference;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_HFReference_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.HFReference = value;

            return __ret;
        }

        static StackObject* get_LFReference_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LFReference;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_LFReference_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LFReference = value;

            return __ret;
        }

        static StackObject* get_diffusion_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.diffusion;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_diffusion_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.diffusion = value;

            return __ret;
        }

        static StackObject* get_density_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.density;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_density_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioReverbZone instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioReverbZone)typeof(UnityEngine.AudioReverbZone).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.density = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.AudioReverbZone();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
