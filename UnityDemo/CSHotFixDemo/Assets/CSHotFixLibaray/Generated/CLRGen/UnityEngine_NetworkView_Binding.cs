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
    unsafe class UnityEngine_NetworkView_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.NetworkView);
            args = new Type[]{};
            method = type.GetMethod("get_observed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_observed_0);
            args = new Type[]{typeof(UnityEngine.Component)};
            method = type.GetMethod("set_observed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_observed_1);
            args = new Type[]{};
            method = type.GetMethod("get_stateSynchronization", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_stateSynchronization_2);
            args = new Type[]{typeof(UnityEngine.NetworkStateSynchronization)};
            method = type.GetMethod("set_stateSynchronization", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_stateSynchronization_3);
            args = new Type[]{};
            method = type.GetMethod("get_viewID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_viewID_4);
            args = new Type[]{typeof(UnityEngine.NetworkViewID)};
            method = type.GetMethod("set_viewID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_viewID_5);
            args = new Type[]{};
            method = type.GetMethod("get_group", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_group_6);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_group", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_group_7);
            args = new Type[]{};
            method = type.GetMethod("get_isMine", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isMine_8);
            args = new Type[]{};
            method = type.GetMethod("get_owner", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_owner_9);
            args = new Type[]{typeof(UnityEngine.NetworkPlayer), typeof(System.Boolean)};
            method = type.GetMethod("SetScope", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetScope_10);
            args = new Type[]{typeof(UnityEngine.NetworkViewID)};
            method = type.GetMethod("Find", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Find_11);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.NetworkView());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.NetworkView[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_observed_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.NetworkView instance_of_this_method;
            instance_of_this_method = (UnityEngine.NetworkView)typeof(UnityEngine.NetworkView).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.observed;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_observed_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Component value = (UnityEngine.Component)typeof(UnityEngine.Component).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.NetworkView instance_of_this_method;
            instance_of_this_method = (UnityEngine.NetworkView)typeof(UnityEngine.NetworkView).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.observed = value;

            return __ret;
        }

        static StackObject* get_stateSynchronization_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.NetworkView instance_of_this_method;
            instance_of_this_method = (UnityEngine.NetworkView)typeof(UnityEngine.NetworkView).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.stateSynchronization;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_stateSynchronization_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.NetworkStateSynchronization value = (UnityEngine.NetworkStateSynchronization)typeof(UnityEngine.NetworkStateSynchronization).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.NetworkView instance_of_this_method;
            instance_of_this_method = (UnityEngine.NetworkView)typeof(UnityEngine.NetworkView).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.stateSynchronization = value;

            return __ret;
        }

        static StackObject* get_viewID_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.NetworkView instance_of_this_method;
            instance_of_this_method = (UnityEngine.NetworkView)typeof(UnityEngine.NetworkView).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.viewID;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_viewID_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.NetworkViewID value = (UnityEngine.NetworkViewID)typeof(UnityEngine.NetworkViewID).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.NetworkView instance_of_this_method;
            instance_of_this_method = (UnityEngine.NetworkView)typeof(UnityEngine.NetworkView).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.viewID = value;

            return __ret;
        }

        static StackObject* get_group_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.NetworkView instance_of_this_method;
            instance_of_this_method = (UnityEngine.NetworkView)typeof(UnityEngine.NetworkView).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.group;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_group_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.NetworkView instance_of_this_method;
            instance_of_this_method = (UnityEngine.NetworkView)typeof(UnityEngine.NetworkView).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.group = value;

            return __ret;
        }

        static StackObject* get_isMine_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.NetworkView instance_of_this_method;
            instance_of_this_method = (UnityEngine.NetworkView)typeof(UnityEngine.NetworkView).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isMine;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_owner_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.NetworkView instance_of_this_method;
            instance_of_this_method = (UnityEngine.NetworkView)typeof(UnityEngine.NetworkView).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.owner;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetScope_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean relevancy = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.NetworkPlayer player = (UnityEngine.NetworkPlayer)typeof(UnityEngine.NetworkPlayer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.NetworkView instance_of_this_method;
            instance_of_this_method = (UnityEngine.NetworkView)typeof(UnityEngine.NetworkView).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SetScope(player, relevancy);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Find_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.NetworkViewID viewID = (UnityEngine.NetworkViewID)typeof(UnityEngine.NetworkViewID).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = UnityEngine.NetworkView.Find(viewID);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.NetworkView();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
