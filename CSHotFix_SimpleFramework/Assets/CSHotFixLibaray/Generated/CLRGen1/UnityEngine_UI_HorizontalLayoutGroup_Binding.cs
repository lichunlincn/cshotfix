
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
    unsafe class UnityEngine_UI_HorizontalLayoutGroup_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.UI.HorizontalLayoutGroup);
            args = new Type[]{};
            method = type.GetMethod("CalculateLayoutInputHorizontal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CalculateLayoutInputHorizontal_0);
            args = new Type[]{};
            method = type.GetMethod("CalculateLayoutInputVertical", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CalculateLayoutInputVertical_1);
            args = new Type[]{};
            method = type.GetMethod("SetLayoutHorizontal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLayoutHorizontal_2);
            args = new Type[]{};
            method = type.GetMethod("SetLayoutVertical", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLayoutVertical_3);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.UI.HorizontalLayoutGroup[s]);


        }


        static StackObject* CalculateLayoutInputHorizontal_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.UI.HorizontalLayoutGroup instance_of_this_method = (UnityEngine.UI.HorizontalLayoutGroup)typeof(UnityEngine.UI.HorizontalLayoutGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CalculateLayoutInputHorizontal();

            return __ret;
        }

        static StackObject* CalculateLayoutInputVertical_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.UI.HorizontalLayoutGroup instance_of_this_method = (UnityEngine.UI.HorizontalLayoutGroup)typeof(UnityEngine.UI.HorizontalLayoutGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CalculateLayoutInputVertical();

            return __ret;
        }

        static StackObject* SetLayoutHorizontal_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.UI.HorizontalLayoutGroup instance_of_this_method = (UnityEngine.UI.HorizontalLayoutGroup)typeof(UnityEngine.UI.HorizontalLayoutGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetLayoutHorizontal();

            return __ret;
        }

        static StackObject* SetLayoutVertical_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.UI.HorizontalLayoutGroup instance_of_this_method = (UnityEngine.UI.HorizontalLayoutGroup)typeof(UnityEngine.UI.HorizontalLayoutGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetLayoutVertical();

            return __ret;
        }





    }
}
#endif
