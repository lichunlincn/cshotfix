
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
    unsafe class UnityEngine_CanvasRenderer_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.CanvasRenderer);
            args = new Type[]{};
            method = type.GetMethod("get_hasPopInstruction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasPopInstruction_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_hasPopInstruction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hasPopInstruction_1);
            args = new Type[]{};
            method = type.GetMethod("get_materialCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_materialCount_2);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_materialCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_materialCount_3);
            args = new Type[]{};
            method = type.GetMethod("get_popMaterialCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_popMaterialCount_4);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_popMaterialCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_popMaterialCount_5);
            args = new Type[]{};
            method = type.GetMethod("get_absoluteDepth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_absoluteDepth_6);
            args = new Type[]{};
            method = type.GetMethod("get_hasMoved", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasMoved_7);
            args = new Type[]{};
            method = type.GetMethod("get_cullTransparentMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cullTransparentMesh_8);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_cullTransparentMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_cullTransparentMesh_9);
            args = new Type[]{};
            method = type.GetMethod("get_hasRectClipping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasRectClipping_10);
            args = new Type[]{};
            method = type.GetMethod("get_relativeDepth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_relativeDepth_11);
            args = new Type[]{};
            method = type.GetMethod("get_cull", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cull_12);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_cull", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_cull_13);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("SetColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetColor_14);
            args = new Type[]{};
            method = type.GetMethod("GetColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetColor_15);
            args = new Type[]{typeof(UnityEngine.Rect)};
            method = type.GetMethod("EnableRectClipping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EnableRectClipping_16);
            args = new Type[]{};
            method = type.GetMethod("DisableRectClipping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DisableRectClipping_17);
            args = new Type[]{typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("SetMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetMaterial_18);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetMaterial_19);
            args = new Type[]{typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("SetPopMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPopMaterial_20);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetPopMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPopMaterial_21);
            args = new Type[]{typeof(UnityEngine.Texture)};
            method = type.GetMethod("SetTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTexture_22);
            args = new Type[]{typeof(UnityEngine.Texture)};
            method = type.GetMethod("SetAlphaTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAlphaTexture_23);
            args = new Type[]{typeof(UnityEngine.Mesh)};
            method = type.GetMethod("SetMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetMesh_24);
            args = new Type[]{};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_25);
            args = new Type[]{};
            method = type.GetMethod("GetAlpha", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAlpha_26);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("SetAlpha", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAlpha_27);
            args = new Type[]{};
            method = type.GetMethod("GetInheritedAlpha", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetInheritedAlpha_28);
            args = new Type[]{typeof(UnityEngine.Material), typeof(UnityEngine.Texture)};
            method = type.GetMethod("SetMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetMaterial_29);
            args = new Type[]{};
            method = type.GetMethod("GetMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetMaterial_30);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.UIVertex>), typeof(System.Collections.Generic.List<UnityEngine.Vector3>), typeof(System.Collections.Generic.List<UnityEngine.Color32>), typeof(System.Collections.Generic.List<UnityEngine.Vector2>), typeof(System.Collections.Generic.List<UnityEngine.Vector2>), typeof(System.Collections.Generic.List<UnityEngine.Vector3>), typeof(System.Collections.Generic.List<UnityEngine.Vector4>), typeof(System.Collections.Generic.List<System.Int32>)};
            method = type.GetMethod("SplitUIVertexStreams", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SplitUIVertexStreams_31);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.UIVertex>), typeof(System.Collections.Generic.List<UnityEngine.Vector3>), typeof(System.Collections.Generic.List<UnityEngine.Color32>), typeof(System.Collections.Generic.List<UnityEngine.Vector2>), typeof(System.Collections.Generic.List<UnityEngine.Vector2>), typeof(System.Collections.Generic.List<UnityEngine.Vector2>), typeof(System.Collections.Generic.List<UnityEngine.Vector2>), typeof(System.Collections.Generic.List<UnityEngine.Vector3>), typeof(System.Collections.Generic.List<UnityEngine.Vector4>), typeof(System.Collections.Generic.List<System.Int32>)};
            method = type.GetMethod("SplitUIVertexStreams", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SplitUIVertexStreams_32);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.UIVertex>), typeof(System.Collections.Generic.List<UnityEngine.Vector3>), typeof(System.Collections.Generic.List<UnityEngine.Color32>), typeof(System.Collections.Generic.List<UnityEngine.Vector2>), typeof(System.Collections.Generic.List<UnityEngine.Vector2>), typeof(System.Collections.Generic.List<UnityEngine.Vector3>), typeof(System.Collections.Generic.List<UnityEngine.Vector4>), typeof(System.Collections.Generic.List<System.Int32>)};
            method = type.GetMethod("CreateUIVertexStream", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateUIVertexStream_33);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.UIVertex>), typeof(System.Collections.Generic.List<UnityEngine.Vector3>), typeof(System.Collections.Generic.List<UnityEngine.Color32>), typeof(System.Collections.Generic.List<UnityEngine.Vector2>), typeof(System.Collections.Generic.List<UnityEngine.Vector2>), typeof(System.Collections.Generic.List<UnityEngine.Vector2>), typeof(System.Collections.Generic.List<UnityEngine.Vector2>), typeof(System.Collections.Generic.List<UnityEngine.Vector3>), typeof(System.Collections.Generic.List<UnityEngine.Vector4>), typeof(System.Collections.Generic.List<System.Int32>)};
            method = type.GetMethod("CreateUIVertexStream", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateUIVertexStream_34);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.UIVertex>), typeof(System.Collections.Generic.List<UnityEngine.Vector3>), typeof(System.Collections.Generic.List<UnityEngine.Color32>), typeof(System.Collections.Generic.List<UnityEngine.Vector2>), typeof(System.Collections.Generic.List<UnityEngine.Vector2>), typeof(System.Collections.Generic.List<UnityEngine.Vector3>), typeof(System.Collections.Generic.List<UnityEngine.Vector4>)};
            method = type.GetMethod("AddUIVertexStream", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddUIVertexStream_35);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.UIVertex>), typeof(System.Collections.Generic.List<UnityEngine.Vector3>), typeof(System.Collections.Generic.List<UnityEngine.Color32>), typeof(System.Collections.Generic.List<UnityEngine.Vector2>), typeof(System.Collections.Generic.List<UnityEngine.Vector2>), typeof(System.Collections.Generic.List<UnityEngine.Vector2>), typeof(System.Collections.Generic.List<UnityEngine.Vector2>), typeof(System.Collections.Generic.List<UnityEngine.Vector3>), typeof(System.Collections.Generic.List<UnityEngine.Vector4>)};
            method = type.GetMethod("AddUIVertexStream", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddUIVertexStream_36);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.CanvasRenderer());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.CanvasRenderer[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_hasPopInstruction_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hasPopInstruction;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_hasPopInstruction_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hasPopInstruction = value;

            return __ret;
        }

        static StackObject* get_materialCount_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.materialCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_materialCount_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.materialCount = value;

            return __ret;
        }

        static StackObject* get_popMaterialCount_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.popMaterialCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_popMaterialCount_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.popMaterialCount = value;

            return __ret;
        }

        static StackObject* get_absoluteDepth_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.absoluteDepth;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_hasMoved_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hasMoved;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_cullTransparentMesh_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.cullTransparentMesh;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_cullTransparentMesh_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.cullTransparentMesh = value;

            return __ret;
        }

        static StackObject* get_hasRectClipping_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hasRectClipping;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_relativeDepth_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.relativeDepth;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_cull_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.cull;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_cull_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.cull = value;

            return __ret;
        }

        static StackObject* SetColor_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @color = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetColor(@color);

            return __ret;
        }

        static StackObject* GetColor_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetColor();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* EnableRectClipping_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rect @rect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.EnableRectClipping(@rect);

            return __ret;
        }

        static StackObject* DisableRectClipping_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DisableRectClipping();

            return __ret;
        }

        static StackObject* SetMaterial_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @index = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetMaterial(@material, @index);

            return __ret;
        }

        static StackObject* GetMaterial_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @index = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetMaterial(@index);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetPopMaterial_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @index = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPopMaterial(@material, @index);

            return __ret;
        }

        static StackObject* GetPopMaterial_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @index = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPopMaterial(@index);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetTexture_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture @texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTexture(@texture);

            return __ret;
        }

        static StackObject* SetAlphaTexture_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture @texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetAlphaTexture(@texture);

            return __ret;
        }

        static StackObject* SetMesh_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetMesh(@mesh);

            return __ret;
        }

        static StackObject* Clear_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clear();

            return __ret;
        }

        static StackObject* GetAlpha_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAlpha();

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetAlpha_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @alpha = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetAlpha(@alpha);

            return __ret;
        }

        static StackObject* GetInheritedAlpha_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetInheritedAlpha();

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetMaterial_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture @texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetMaterial(@material, @texture);

            return __ret;
        }

        static StackObject* GetMaterial_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CanvasRenderer instance_of_this_method = (UnityEngine.CanvasRenderer)typeof(UnityEngine.CanvasRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetMaterial();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SplitUIVertexStreams_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Int32> @indices = (System.Collections.Generic.List<System.Int32>)typeof(System.Collections.Generic.List<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.Vector4> @tangents = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<UnityEngine.Vector3> @normals = (System.Collections.Generic.List<UnityEngine.Vector3>)typeof(System.Collections.Generic.List<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<UnityEngine.Vector2> @uv1S = (System.Collections.Generic.List<UnityEngine.Vector2>)typeof(System.Collections.Generic.List<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Collections.Generic.List<UnityEngine.Vector2> @uv0S = (System.Collections.Generic.List<UnityEngine.Vector2>)typeof(System.Collections.Generic.List<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Collections.Generic.List<UnityEngine.Color32> @colors = (System.Collections.Generic.List<UnityEngine.Color32>)typeof(System.Collections.Generic.List<UnityEngine.Color32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Collections.Generic.List<UnityEngine.Vector3> @positions = (System.Collections.Generic.List<UnityEngine.Vector3>)typeof(System.Collections.Generic.List<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Collections.Generic.List<UnityEngine.UIVertex> @verts = (System.Collections.Generic.List<UnityEngine.UIVertex>)typeof(System.Collections.Generic.List<UnityEngine.UIVertex>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.CanvasRenderer.SplitUIVertexStreams(@verts, @positions, @colors, @uv0S, @uv1S, @normals, @tangents, @indices);

            return __ret;
        }

        static StackObject* SplitUIVertexStreams_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Int32> @indices = (System.Collections.Generic.List<System.Int32>)typeof(System.Collections.Generic.List<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.Vector4> @tangents = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<UnityEngine.Vector3> @normals = (System.Collections.Generic.List<UnityEngine.Vector3>)typeof(System.Collections.Generic.List<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<UnityEngine.Vector2> @uv3S = (System.Collections.Generic.List<UnityEngine.Vector2>)typeof(System.Collections.Generic.List<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Collections.Generic.List<UnityEngine.Vector2> @uv2S = (System.Collections.Generic.List<UnityEngine.Vector2>)typeof(System.Collections.Generic.List<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Collections.Generic.List<UnityEngine.Vector2> @uv1S = (System.Collections.Generic.List<UnityEngine.Vector2>)typeof(System.Collections.Generic.List<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Collections.Generic.List<UnityEngine.Vector2> @uv0S = (System.Collections.Generic.List<UnityEngine.Vector2>)typeof(System.Collections.Generic.List<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Collections.Generic.List<UnityEngine.Color32> @colors = (System.Collections.Generic.List<UnityEngine.Color32>)typeof(System.Collections.Generic.List<UnityEngine.Color32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            System.Collections.Generic.List<UnityEngine.Vector3> @positions = (System.Collections.Generic.List<UnityEngine.Vector3>)typeof(System.Collections.Generic.List<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            System.Collections.Generic.List<UnityEngine.UIVertex> @verts = (System.Collections.Generic.List<UnityEngine.UIVertex>)typeof(System.Collections.Generic.List<UnityEngine.UIVertex>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.CanvasRenderer.SplitUIVertexStreams(@verts, @positions, @colors, @uv0S, @uv1S, @uv2S, @uv3S, @normals, @tangents, @indices);

            return __ret;
        }

        static StackObject* CreateUIVertexStream_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Int32> @indices = (System.Collections.Generic.List<System.Int32>)typeof(System.Collections.Generic.List<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.Vector4> @tangents = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<UnityEngine.Vector3> @normals = (System.Collections.Generic.List<UnityEngine.Vector3>)typeof(System.Collections.Generic.List<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<UnityEngine.Vector2> @uv1S = (System.Collections.Generic.List<UnityEngine.Vector2>)typeof(System.Collections.Generic.List<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Collections.Generic.List<UnityEngine.Vector2> @uv0S = (System.Collections.Generic.List<UnityEngine.Vector2>)typeof(System.Collections.Generic.List<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Collections.Generic.List<UnityEngine.Color32> @colors = (System.Collections.Generic.List<UnityEngine.Color32>)typeof(System.Collections.Generic.List<UnityEngine.Color32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Collections.Generic.List<UnityEngine.Vector3> @positions = (System.Collections.Generic.List<UnityEngine.Vector3>)typeof(System.Collections.Generic.List<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Collections.Generic.List<UnityEngine.UIVertex> @verts = (System.Collections.Generic.List<UnityEngine.UIVertex>)typeof(System.Collections.Generic.List<UnityEngine.UIVertex>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.CanvasRenderer.CreateUIVertexStream(@verts, @positions, @colors, @uv0S, @uv1S, @normals, @tangents, @indices);

            return __ret;
        }

        static StackObject* CreateUIVertexStream_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Int32> @indices = (System.Collections.Generic.List<System.Int32>)typeof(System.Collections.Generic.List<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.Vector4> @tangents = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<UnityEngine.Vector3> @normals = (System.Collections.Generic.List<UnityEngine.Vector3>)typeof(System.Collections.Generic.List<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<UnityEngine.Vector2> @uv3S = (System.Collections.Generic.List<UnityEngine.Vector2>)typeof(System.Collections.Generic.List<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Collections.Generic.List<UnityEngine.Vector2> @uv2S = (System.Collections.Generic.List<UnityEngine.Vector2>)typeof(System.Collections.Generic.List<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Collections.Generic.List<UnityEngine.Vector2> @uv1S = (System.Collections.Generic.List<UnityEngine.Vector2>)typeof(System.Collections.Generic.List<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Collections.Generic.List<UnityEngine.Vector2> @uv0S = (System.Collections.Generic.List<UnityEngine.Vector2>)typeof(System.Collections.Generic.List<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Collections.Generic.List<UnityEngine.Color32> @colors = (System.Collections.Generic.List<UnityEngine.Color32>)typeof(System.Collections.Generic.List<UnityEngine.Color32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            System.Collections.Generic.List<UnityEngine.Vector3> @positions = (System.Collections.Generic.List<UnityEngine.Vector3>)typeof(System.Collections.Generic.List<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            System.Collections.Generic.List<UnityEngine.UIVertex> @verts = (System.Collections.Generic.List<UnityEngine.UIVertex>)typeof(System.Collections.Generic.List<UnityEngine.UIVertex>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.CanvasRenderer.CreateUIVertexStream(@verts, @positions, @colors, @uv0S, @uv1S, @uv2S, @uv3S, @normals, @tangents, @indices);

            return __ret;
        }

        static StackObject* AddUIVertexStream_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector4> @tangents = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.Vector3> @normals = (System.Collections.Generic.List<UnityEngine.Vector3>)typeof(System.Collections.Generic.List<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<UnityEngine.Vector2> @uv1S = (System.Collections.Generic.List<UnityEngine.Vector2>)typeof(System.Collections.Generic.List<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<UnityEngine.Vector2> @uv0S = (System.Collections.Generic.List<UnityEngine.Vector2>)typeof(System.Collections.Generic.List<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Collections.Generic.List<UnityEngine.Color32> @colors = (System.Collections.Generic.List<UnityEngine.Color32>)typeof(System.Collections.Generic.List<UnityEngine.Color32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Collections.Generic.List<UnityEngine.Vector3> @positions = (System.Collections.Generic.List<UnityEngine.Vector3>)typeof(System.Collections.Generic.List<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Collections.Generic.List<UnityEngine.UIVertex> @verts = (System.Collections.Generic.List<UnityEngine.UIVertex>)typeof(System.Collections.Generic.List<UnityEngine.UIVertex>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.CanvasRenderer.AddUIVertexStream(@verts, @positions, @colors, @uv0S, @uv1S, @normals, @tangents);

            return __ret;
        }

        static StackObject* AddUIVertexStream_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector4> @tangents = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.Vector3> @normals = (System.Collections.Generic.List<UnityEngine.Vector3>)typeof(System.Collections.Generic.List<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<UnityEngine.Vector2> @uv3S = (System.Collections.Generic.List<UnityEngine.Vector2>)typeof(System.Collections.Generic.List<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<UnityEngine.Vector2> @uv2S = (System.Collections.Generic.List<UnityEngine.Vector2>)typeof(System.Collections.Generic.List<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Collections.Generic.List<UnityEngine.Vector2> @uv1S = (System.Collections.Generic.List<UnityEngine.Vector2>)typeof(System.Collections.Generic.List<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Collections.Generic.List<UnityEngine.Vector2> @uv0S = (System.Collections.Generic.List<UnityEngine.Vector2>)typeof(System.Collections.Generic.List<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Collections.Generic.List<UnityEngine.Color32> @colors = (System.Collections.Generic.List<UnityEngine.Color32>)typeof(System.Collections.Generic.List<UnityEngine.Color32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Collections.Generic.List<UnityEngine.Vector3> @positions = (System.Collections.Generic.List<UnityEngine.Vector3>)typeof(System.Collections.Generic.List<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            System.Collections.Generic.List<UnityEngine.UIVertex> @verts = (System.Collections.Generic.List<UnityEngine.UIVertex>)typeof(System.Collections.Generic.List<UnityEngine.UIVertex>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            UnityEngine.CanvasRenderer.AddUIVertexStream(@verts, @positions, @colors, @uv0S, @uv1S, @uv2S, @uv3S, @normals, @tangents);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.CanvasRenderer();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
