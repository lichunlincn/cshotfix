
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
    unsafe class GameDll_RoleStateID_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(GameDll.RoleStateID);

            field = type.GetField("null_state_id", flag);
            app.RegisterCLRFieldGetter(field, get_null_state_id_0);
            field = type.GetField("idle", flag);
            app.RegisterCLRFieldGetter(field, get_idle_1);
            field = type.GetField("angle", flag);
            app.RegisterCLRFieldGetter(field, get_angle_2);
            field = type.GetField("run", flag);
            app.RegisterCLRFieldGetter(field, get_run_3);
            field = type.GetField("jump", flag);
            app.RegisterCLRFieldGetter(field, get_jump_4);
            field = type.GetField("MoveTo", flag);
            app.RegisterCLRFieldGetter(field, get_MoveTo_5);
            field = type.GetField("MoveDir", flag);
            app.RegisterCLRFieldGetter(field, get_MoveDir_6);


            app.RegisterCLRCreateDefaultInstance(type, () => new GameDll.RoleStateID());
            app.RegisterCLRCreateArrayInstance(type, s => new GameDll.RoleStateID[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref GameDll.RoleStateID instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as GameDll.RoleStateID[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_null_state_id_0(ref object o)
        {
            return GameDll.RoleStateID.null_state_id;
        }
        static object get_idle_1(ref object o)
        {
            return GameDll.RoleStateID.idle;
        }
        static object get_angle_2(ref object o)
        {
            return GameDll.RoleStateID.angle;
        }
        static object get_run_3(ref object o)
        {
            return GameDll.RoleStateID.run;
        }
        static object get_jump_4(ref object o)
        {
            return GameDll.RoleStateID.jump;
        }
        static object get_MoveTo_5(ref object o)
        {
            return GameDll.RoleStateID.MoveTo;
        }
        static object get_MoveDir_6(ref object o)
        {
            return GameDll.RoleStateID.MoveDir;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new GameDll.RoleStateID();
            ins = (GameDll.RoleStateID)o;
            return ins;
        }


    }
}
#endif
