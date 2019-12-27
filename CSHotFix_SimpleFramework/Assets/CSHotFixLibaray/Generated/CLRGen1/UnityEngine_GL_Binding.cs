
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
    unsafe class UnityEngine_GL_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.GL);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("Vertex3", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Vertex3_0);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("Vertex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Vertex_1);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("TexCoord3", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TexCoord3_2);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("TexCoord", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TexCoord_3);
            args = new Type[]{typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("TexCoord2", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TexCoord2_4);
            args = new Type[]{typeof(System.Int32), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("MultiTexCoord3", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MultiTexCoord3_5);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("MultiTexCoord", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MultiTexCoord_6);
            args = new Type[]{typeof(System.Int32), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("MultiTexCoord2", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MultiTexCoord2_7);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("Color", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Color_8);
            args = new Type[]{};
            method = type.GetMethod("get_wireframe", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_wireframe_9);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_wireframe", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_wireframe_10);
            args = new Type[]{};
            method = type.GetMethod("get_sRGBWrite", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sRGBWrite_11);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_sRGBWrite", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sRGBWrite_12);
            args = new Type[]{};
            method = type.GetMethod("get_invertCulling", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_invertCulling_13);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_invertCulling", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_invertCulling_14);
            args = new Type[]{};
            method = type.GetMethod("Flush", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Flush_15);
            args = new Type[]{};
            method = type.GetMethod("RenderTargetBarrier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RenderTargetBarrier_16);
            args = new Type[]{};
            method = type.GetMethod("get_modelview", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_modelview_17);
            args = new Type[]{typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("set_modelview", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_modelview_18);
            args = new Type[]{typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("MultMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MultMatrix_19);
            args = new Type[]{};
            method = type.GetMethod("PushMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PushMatrix_20);
            args = new Type[]{};
            method = type.GetMethod("PopMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PopMatrix_21);
            args = new Type[]{};
            method = type.GetMethod("LoadIdentity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadIdentity_22);
            args = new Type[]{};
            method = type.GetMethod("LoadOrtho", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadOrtho_23);
            args = new Type[]{};
            method = type.GetMethod("LoadPixelMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadPixelMatrix_24);
            args = new Type[]{typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("LoadProjectionMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadProjectionMatrix_25);
            args = new Type[]{};
            method = type.GetMethod("InvalidateState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InvalidateState_26);
            args = new Type[]{typeof(UnityEngine.Matrix4x4), typeof(System.Boolean)};
            method = type.GetMethod("GetGPUProjectionMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGPUProjectionMatrix_27);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("LoadPixelMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadPixelMatrix_28);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("Begin", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Begin_29);
            args = new Type[]{};
            method = type.GetMethod("End", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, End_30);
            args = new Type[]{typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.Color), typeof(System.Single)};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_31);
            args = new Type[]{typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.Color)};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_32);
            args = new Type[]{typeof(UnityEngine.Rect)};
            method = type.GetMethod("Viewport", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Viewport_33);
            args = new Type[]{typeof(System.Boolean), typeof(UnityEngine.Camera)};
            method = type.GetMethod("ClearWithSkybox", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearWithSkybox_34);

            field = type.GetField("TRIANGLES", flag);
            app.RegisterCLRFieldGetter(field, get_TRIANGLES_0);
            field = type.GetField("TRIANGLE_STRIP", flag);
            app.RegisterCLRFieldGetter(field, get_TRIANGLE_STRIP_1);
            field = type.GetField("QUADS", flag);
            app.RegisterCLRFieldGetter(field, get_QUADS_2);
            field = type.GetField("LINES", flag);
            app.RegisterCLRFieldGetter(field, get_LINES_3);
            field = type.GetField("LINE_STRIP", flag);
            app.RegisterCLRFieldGetter(field, get_LINE_STRIP_4);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.GL());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.GL[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Vertex3_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @z = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @y = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            UnityEngine.GL.Vertex3(@x, @y, @z);

            return __ret;
        }

        static StackObject* Vertex_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @v = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.GL.Vertex(@v);

            return __ret;
        }

        static StackObject* TexCoord3_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @z = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @y = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            UnityEngine.GL.TexCoord3(@x, @y, @z);

            return __ret;
        }

        static StackObject* TexCoord_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @v = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.GL.TexCoord(@v);

            return __ret;
        }

        static StackObject* TexCoord2_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @y = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            UnityEngine.GL.TexCoord2(@x, @y);

            return __ret;
        }

        static StackObject* MultiTexCoord3_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @z = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @y = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @x = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @unit = ptr_of_this_method->Value;


            UnityEngine.GL.MultiTexCoord3(@unit, @x, @y, @z);

            return __ret;
        }

        static StackObject* MultiTexCoord_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @v = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @unit = ptr_of_this_method->Value;


            UnityEngine.GL.MultiTexCoord(@unit, @v);

            return __ret;
        }

        static StackObject* MultiTexCoord2_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @y = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @x = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @unit = ptr_of_this_method->Value;


            UnityEngine.GL.MultiTexCoord2(@unit, @x, @y);

            return __ret;
        }

        static StackObject* Color_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @c = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.GL.Color(@c);

            return __ret;
        }

        static StackObject* get_wireframe_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.GL.wireframe;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_wireframe_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.GL.wireframe = value;

            return __ret;
        }

        static StackObject* get_sRGBWrite_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.GL.sRGBWrite;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_sRGBWrite_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.GL.sRGBWrite = value;

            return __ret;
        }

        static StackObject* get_invertCulling_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.GL.invertCulling;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_invertCulling_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.GL.invertCulling = value;

            return __ret;
        }

        static StackObject* Flush_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.GL.Flush();

            return __ret;
        }

        static StackObject* RenderTargetBarrier_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.GL.RenderTargetBarrier();

            return __ret;
        }

        static StackObject* get_modelview_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.GL.modelview;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_modelview_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 @value = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.GL.modelview = value;

            return __ret;
        }

        static StackObject* MultMatrix_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 @m = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.GL.MultMatrix(@m);

            return __ret;
        }

        static StackObject* PushMatrix_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.GL.PushMatrix();

            return __ret;
        }

        static StackObject* PopMatrix_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.GL.PopMatrix();

            return __ret;
        }

        static StackObject* LoadIdentity_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.GL.LoadIdentity();

            return __ret;
        }

        static StackObject* LoadOrtho_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.GL.LoadOrtho();

            return __ret;
        }

        static StackObject* LoadPixelMatrix_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.GL.LoadPixelMatrix();

            return __ret;
        }

        static StackObject* LoadProjectionMatrix_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 @mat = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.GL.LoadProjectionMatrix(@mat);

            return __ret;
        }

        static StackObject* InvalidateState_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.GL.InvalidateState();

            return __ret;
        }

        static StackObject* GetGPUProjectionMatrix_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @renderIntoTexture = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Matrix4x4 @proj = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.GL.GetGPUProjectionMatrix(@proj, @renderIntoTexture);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* LoadPixelMatrix_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @top = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @bottom = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @right = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @left = *(float*)&ptr_of_this_method->Value;


            UnityEngine.GL.LoadPixelMatrix(@left, @right, @bottom, @top);

            return __ret;
        }

        static StackObject* Begin_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @mode = ptr_of_this_method->Value;


            UnityEngine.GL.Begin(@mode);

            return __ret;
        }

        static StackObject* End_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.GL.End();

            return __ret;
        }

        static StackObject* Clear_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @depth = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Color @backgroundColor = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @clearColor = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean @clearDepth = ptr_of_this_method->Value == 1;


            UnityEngine.GL.Clear(@clearDepth, @clearColor, @backgroundColor, @depth);

            return __ret;
        }

        static StackObject* Clear_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @backgroundColor = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @clearColor = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @clearDepth = ptr_of_this_method->Value == 1;


            UnityEngine.GL.Clear(@clearDepth, @clearColor, @backgroundColor);

            return __ret;
        }

        static StackObject* Viewport_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rect @pixelRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.GL.Viewport(@pixelRect);

            return __ret;
        }

        static StackObject* ClearWithSkybox_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @clearDepth = ptr_of_this_method->Value == 1;


            UnityEngine.GL.ClearWithSkybox(@clearDepth, @camera);

            return __ret;
        }


        static object get_TRIANGLES_0(ref object o)
        {
            return UnityEngine.GL.TRIANGLES;
        }
        static object get_TRIANGLE_STRIP_1(ref object o)
        {
            return UnityEngine.GL.TRIANGLE_STRIP;
        }
        static object get_QUADS_2(ref object o)
        {
            return UnityEngine.GL.QUADS;
        }
        static object get_LINES_3(ref object o)
        {
            return UnityEngine.GL.LINES;
        }
        static object get_LINE_STRIP_4(ref object o)
        {
            return UnityEngine.GL.LINE_STRIP;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.GL();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
