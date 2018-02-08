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
    unsafe class UnityEngine_Experimental_Rendering_IRenderPipeline_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Experimental.Rendering.IRenderPipeline);
            args = new Type[]{};
            method = type.GetMethod("get_disposed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_disposed_0);
            args = new Type[]{typeof(UnityEngine.Experimental.Rendering.ScriptableRenderContext), typeof(UnityEngine.Camera[])};
            method = type.GetMethod("Render", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Render_1);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Experimental.Rendering.IRenderPipeline[s]);


        }


        static StackObject* get_disposed_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Experimental.Rendering.IRenderPipeline instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Rendering.IRenderPipeline)typeof(UnityEngine.Experimental.Rendering.IRenderPipeline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.disposed;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Render_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Camera[] cameras = (UnityEngine.Camera[])typeof(UnityEngine.Camera[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Experimental.Rendering.ScriptableRenderContext renderContext = (UnityEngine.Experimental.Rendering.ScriptableRenderContext)typeof(UnityEngine.Experimental.Rendering.ScriptableRenderContext).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Experimental.Rendering.IRenderPipeline instance_of_this_method;
            instance_of_this_method = (UnityEngine.Experimental.Rendering.IRenderPipeline)typeof(UnityEngine.Experimental.Rendering.IRenderPipeline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Render(renderContext, cameras);

            return __ret;
        }





    }
}
