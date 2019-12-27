
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
    unsafe class GameDll_InputManager_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(GameDll.InputManager);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("SetEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetEnabled_0);
            args = new Type[]{};
            method = type.GetMethod("GetEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetEnabled_1);
            args = new Type[]{};
            method = type.GetMethod("ResetInput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetInput_2);
            args = new Type[]{};
            method = type.GetMethod("Init", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Init_3);
            args = new Type[]{};
            method = type.GetMethod("Update", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Update_4);
            args = new Type[]{};
            method = type.GetMethod("GetDragX", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDragX_5);
            args = new Type[]{};
            method = type.GetMethod("GetDragY", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDragY_6);
            args = new Type[]{};
            method = type.GetMethod("GetJoystickValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetJoystickValue_7);
            args = new Type[]{};
            method = type.GetMethod("IsJoystickDirty", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsJoystickDirty_8);
            args = new Type[]{};
            method = type.GetMethod("GetClickObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetClickObject_9);
            args = new Type[]{};
            method = type.GetMethod("GetClickPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetClickPosition_10);
            args = new Type[]{};
            method = type.GetMethod("isClickUI", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, isClickUI_11);
            args = new Type[]{};
            method = type.GetMethod("isMouseClick", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, isMouseClick_12);
            args = new Type[]{};
            method = type.GetMethod("isMousePress", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, isMousePress_13);
            args = new Type[]{};
            method = type.GetMethod("isMouseDraging", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, isMouseDraging_14);
            args = new Type[]{};
            method = type.GetMethod("GetMousePos2D", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetMousePos2D_15);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Int32)};
            method = type.GetMethod("GetMouseOverObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetMouseOverObject_16);
            args = new Type[]{};
            method = type.GetMethod("JoystickStopMove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, JoystickStopMove_17);
            args = new Type[]{};
            method = type.GetMethod("JoystickChangeDir", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, JoystickChangeDir_18);
            args = new Type[]{};
            method = type.GetMethod("UpdateRoleMove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UpdateRoleMove_19);

            field = type.GetField("m_bEnableClick3D", flag);
            app.RegisterCLRFieldGetter(field, get_m_bEnableClick3D_0);
            app.RegisterCLRFieldSetter(field, set_m_bEnableClick3D_0);
            field = type.GetField("m_bEnableClick2D", flag);
            app.RegisterCLRFieldGetter(field, get_m_bEnableClick2D_1);
            app.RegisterCLRFieldSetter(field, set_m_bEnableClick2D_1);
            field = type.GetField("m_JoystickValue", flag);
            app.RegisterCLRFieldGetter(field, get_m_JoystickValue_2);
            app.RegisterCLRFieldSetter(field, set_m_JoystickValue_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new GameDll.InputManager());
            app.RegisterCLRCreateArrayInstance(type, s => new GameDll.InputManager[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* SetEnabled_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @enable = ptr_of_this_method->Value == 1;


            GameDll.InputManager.SetEnabled(@enable);

            return __ret;
        }

        static StackObject* GetEnabled_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = GameDll.InputManager.GetEnabled();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* ResetInput_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            GameDll.InputManager.ResetInput();

            return __ret;
        }

        static StackObject* Init_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            GameDll.InputManager.Init();

            return __ret;
        }

        static StackObject* Update_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            GameDll.InputManager.Update();

            return __ret;
        }

        static StackObject* GetDragX_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = GameDll.InputManager.GetDragX();

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetDragY_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = GameDll.InputManager.GetDragY();

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetJoystickValue_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = GameDll.InputManager.GetJoystickValue();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* IsJoystickDirty_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = GameDll.InputManager.IsJoystickDirty();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetClickObject_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = GameDll.InputManager.GetClickObject();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetClickPosition_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = GameDll.InputManager.GetClickPosition();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* isClickUI_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = GameDll.InputManager.isClickUI();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* isMouseClick_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = GameDll.InputManager.isMouseClick();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* isMousePress_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = GameDll.InputManager.isMousePress();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* isMouseDraging_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = GameDll.InputManager.isMouseDraging();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetMousePos2D_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = GameDll.InputManager.GetMousePos2D();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetMouseOverObject_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @y = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = GameDll.InputManager.GetMouseOverObject(@x, @y, @layer);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* JoystickStopMove_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            GameDll.InputManager.JoystickStopMove();

            return __ret;
        }

        static StackObject* JoystickChangeDir_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            GameDll.InputManager.JoystickChangeDir();

            return __ret;
        }

        static StackObject* UpdateRoleMove_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            GameDll.InputManager.UpdateRoleMove();

            return __ret;
        }


        static object get_m_bEnableClick3D_0(ref object o)
        {
            return GameDll.InputManager.m_bEnableClick3D;
        }
        static void set_m_bEnableClick3D_0(ref object o, object v)
        {
            GameDll.InputManager.m_bEnableClick3D = (System.Boolean)v;
        }
        static object get_m_bEnableClick2D_1(ref object o)
        {
            return GameDll.InputManager.m_bEnableClick2D;
        }
        static void set_m_bEnableClick2D_1(ref object o, object v)
        {
            GameDll.InputManager.m_bEnableClick2D = (System.Boolean)v;
        }
        static object get_m_JoystickValue_2(ref object o)
        {
            return GameDll.InputManager.m_JoystickValue;
        }
        static void set_m_JoystickValue_2(ref object o, object v)
        {
            GameDll.InputManager.m_JoystickValue = (UnityEngine.Vector2)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new GameDll.InputManager();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
