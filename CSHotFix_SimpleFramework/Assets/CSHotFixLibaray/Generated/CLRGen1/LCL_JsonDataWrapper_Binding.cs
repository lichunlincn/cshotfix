
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
    unsafe class LCL_JsonDataWrapper_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(LCL.JsonDataWrapper);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("Count", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Count_0);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("IsArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsArray_1);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("IsBoolean", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsBoolean_2);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("IsReal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsReal_3);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("IsNatural", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsNatural_4);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("IsObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsObject_5);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("IsString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsString_6);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("Keys", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Keys_7);
            args = new Type[]{typeof(LITJson.JsonData), typeof(System.String)};
            method = type.GetMethod("HasKey", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HasKey_8);
            args = new Type[]{typeof(LITJson.JsonData), typeof(System.String)};
            method = type.GetMethod("GetByName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetByName_9);
            args = new Type[]{typeof(LITJson.JsonData), typeof(System.Int32)};
            method = type.GetMethod("GetByIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetByIndex_10);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("GetBoolean", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBoolean_11);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("GetReal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetReal_12);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("GetString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetString_13);
            args = new Type[]{typeof(LITJson.JsonData), typeof(System.Boolean)};
            method = type.GetMethod("SetBoolean", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetBoolean_14);
            args = new Type[]{typeof(LITJson.JsonData), typeof(System.Double)};
            method = type.GetMethod("SetReal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetReal_15);
            args = new Type[]{typeof(LITJson.JsonData), typeof(System.String)};
            method = type.GetMethod("SetString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetString_16);
            args = new Type[]{typeof(LITJson.JsonData), typeof(System.Object)};
            method = type.GetMethod("Add", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Add_17);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_18);
            args = new Type[]{typeof(LITJson.JsonData), typeof(LITJson.JsonData)};
            method = type.GetMethod("Equals", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Equals_19);
            args = new Type[]{typeof(LITJson.JsonData), typeof(System.Object)};
            method = type.GetMethod("EqualsOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EqualsOverride_20);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("GethashCodeOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GethashCodeOverride_21);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("GetJsonType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetJsonType_22);
            args = new Type[]{typeof(LITJson.JsonData), typeof(System.Int32)};
            method = type.GetMethod("SetJsonType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetJsonType_23);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("ToJson", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToJson_24);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("ToStringOveride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToStringOveride_25);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("SetAsInt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAsInt_26);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("SetAsString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAsString_27);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("SetAsFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAsFloat_28);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("SetAsDouble", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAsDouble_29);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("SetAsBool", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAsBool_30);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("SetAsSByte", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAsSByte_31);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("SetAsByte", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAsByte_32);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("SetAsShort", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAsShort_33);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("SetAsUshort", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAsUshort_34);
            args = new Type[]{typeof(LITJson.JsonData)};
            method = type.GetMethod("SetAsUint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAsUint_35);



            app.RegisterCLRCreateDefaultInstance(type, () => new LCL.JsonDataWrapper());
            app.RegisterCLRCreateArrayInstance(type, s => new LCL.JsonDataWrapper[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Count_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.Count(@m_JsonData);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* IsArray_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.IsArray(@m_JsonData);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsBoolean_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.IsBoolean(@m_JsonData);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsReal_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.IsReal(@m_JsonData);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsNatural_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.IsNatural(@m_JsonData);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsObject_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.IsObject(@m_JsonData);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsString_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.IsString(@m_JsonData);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Keys_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.Keys(@m_JsonData);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* HasKey_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.HasKey(@m_JsonData, @name);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetByName_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.GetByName(@m_JsonData, @name);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetByIndex_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @index = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.GetByIndex(@m_JsonData, @index);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetBoolean_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.GetBoolean(@m_JsonData);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetReal_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.GetReal(@m_JsonData);

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetString_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.GetString(@m_JsonData);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetBoolean_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @val = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            LCL.JsonDataWrapper.SetBoolean(@m_JsonData, @val);

            return __ret;
        }

        static StackObject* SetReal_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @val = *(double*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            LCL.JsonDataWrapper.SetReal(@m_JsonData, @val);

            return __ret;
        }

        static StackObject* SetString_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @val = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            LCL.JsonDataWrapper.SetString(@m_JsonData, @val);

            return __ret;
        }

        static StackObject* Add_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @value = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.Add(@m_JsonData, @value);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Clear_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            LCL.JsonDataWrapper.Clear(@m_JsonData);

            return __ret;
        }

        static StackObject* Equals_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @data = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.Equals(@m_JsonData, @data);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* EqualsOverride_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @obj = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.EqualsOverride(@m_JsonData, @obj);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GethashCodeOverride_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.GethashCodeOverride(@m_JsonData);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetJsonType_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.GetJsonType(@m_JsonData);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetJsonType_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @type = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            LCL.JsonDataWrapper.SetJsonType(@m_JsonData, @type);

            return __ret;
        }

        static StackObject* ToJson_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.ToJson(@m_JsonData);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToStringOveride_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.ToStringOveride(@m_JsonData);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetAsInt_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.SetAsInt(@m_JsonData);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetAsString_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.SetAsString(@m_JsonData);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetAsFloat_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.SetAsFloat(@m_JsonData);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetAsDouble_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.SetAsDouble(@m_JsonData);

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetAsBool_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.SetAsBool(@m_JsonData);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetAsSByte_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.SetAsSByte(@m_JsonData);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetAsByte_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.SetAsByte(@m_JsonData);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetAsShort_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.SetAsShort(@m_JsonData);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetAsUshort_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.SetAsUshort(@m_JsonData);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetAsUint_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LITJson.JsonData @m_JsonData = (LITJson.JsonData)typeof(LITJson.JsonData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.JsonDataWrapper.SetAsUint(@m_JsonData);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new LCL.JsonDataWrapper();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
