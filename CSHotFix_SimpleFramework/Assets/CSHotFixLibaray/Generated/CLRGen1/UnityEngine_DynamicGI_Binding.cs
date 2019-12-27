
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
    unsafe class UnityEngine_DynamicGI_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.DynamicGI);
            args = new Type[]{};
            method = type.GetMethod("get_indirectScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_indirectScale_0);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_indirectScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_indirectScale_1);
            args = new Type[]{};
            method = type.GetMethod("get_updateThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_updateThreshold_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_updateThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_updateThreshold_3);
            args = new Type[]{};
            method = type.GetMethod("get_materialUpdateTimeSlice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_materialUpdateTimeSlice_4);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_materialUpdateTimeSlice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_materialUpdateTimeSlice_5);
            args = new Type[]{typeof(UnityEngine.Renderer), typeof(UnityEngine.Color)};
            method = type.GetMethod("SetEmissive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetEmissive_6);
            args = new Type[]{typeof(System.Single[])};
            method = type.GetMethod("SetEnvironmentData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetEnvironmentData_7);
            args = new Type[]{};
            method = type.GetMethod("get_synchronousMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_synchronousMode_8);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_synchronousMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_synchronousMode_9);
            args = new Type[]{};
            method = type.GetMethod("get_isConverged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isConverged_10);
            args = new Type[]{};
            method = type.GetMethod("UpdateEnvironment", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UpdateEnvironment_11);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.DynamicGI());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.DynamicGI[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_indirectScale_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.DynamicGI.indirectScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_indirectScale_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.DynamicGI.indirectScale = value;

            return __ret;
        }

        static StackObject* get_updateThreshold_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.DynamicGI.updateThreshold;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_updateThreshold_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.DynamicGI.updateThreshold = value;

            return __ret;
        }

        static StackObject* get_materialUpdateTimeSlice_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.DynamicGI.materialUpdateTimeSlice;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_materialUpdateTimeSlice_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.DynamicGI.materialUpdateTimeSlice = value;

            return __ret;
        }

        static StackObject* SetEmissive_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @color = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer @renderer = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.DynamicGI.SetEmissive(@renderer, @color);

            return __ret;
        }

        static StackObject* SetEnvironmentData_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single[] @input = (System.Single[])typeof(System.Single[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.DynamicGI.SetEnvironmentData(@input);

            return __ret;
        }

        static StackObject* get_synchronousMode_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.DynamicGI.synchronousMode;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_synchronousMode_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.DynamicGI.synchronousMode = value;

            return __ret;
        }

        static StackObject* get_isConverged_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.DynamicGI.isConverged;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* UpdateEnvironment_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.DynamicGI.UpdateEnvironment();

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.DynamicGI();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
