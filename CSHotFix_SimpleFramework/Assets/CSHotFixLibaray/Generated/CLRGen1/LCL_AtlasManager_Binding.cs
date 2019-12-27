
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
    unsafe class LCL_AtlasManager_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(LCL.AtlasManager);
            args = new Type[]{typeof(LCL.SetImageSpriteParam)};
            method = type.GetMethod("SetImageSprite", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetImageSprite_0);
            args = new Type[]{typeof(System.Int64)};
            method = type.GetMethod("ReturnImageSprite", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReturnImageSprite_1);
            args = new Type[]{typeof(System.Object), typeof(System.Int64)};
            method = type.GetMethod("WindowImageIdCollect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WindowImageIdCollect_2);
            args = new Type[]{typeof(System.Object), typeof(System.Int64)};
            method = type.GetMethod("WindowImageIdReturn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WindowImageIdReturn_3);
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("WindowImageIdReturn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WindowImageIdReturn_4);



            app.RegisterCLRCreateDefaultInstance(type, () => new LCL.AtlasManager());
            app.RegisterCLRCreateArrayInstance(type, s => new LCL.AtlasManager[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* SetImageSprite_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            LCL.SetImageSpriteParam @param = (LCL.SetImageSpriteParam)typeof(LCL.SetImageSpriteParam).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = LCL.AtlasManager.SetImageSprite(@param);

            __ret->ObjectType = ObjectTypes.Long;
            *(long*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* ReturnImageSprite_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int64 @id = *(long*)&ptr_of_this_method->Value;


            LCL.AtlasManager.ReturnImageSprite(@id);

            return __ret;
        }

        static StackObject* WindowImageIdCollect_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int64 @id = *(long*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Object @wnd = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            LCL.AtlasManager.WindowImageIdCollect(@wnd, @id);

            return __ret;
        }

        static StackObject* WindowImageIdReturn_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int64 @returnid = *(long*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Object @wnd = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            LCL.AtlasManager.WindowImageIdReturn(@wnd, @returnid);

            return __ret;
        }

        static StackObject* WindowImageIdReturn_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @wnd = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            LCL.AtlasManager.WindowImageIdReturn(@wnd);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new LCL.AtlasManager();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
