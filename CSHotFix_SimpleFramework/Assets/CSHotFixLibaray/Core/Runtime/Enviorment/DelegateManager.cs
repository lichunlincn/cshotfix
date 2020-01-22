using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CSHotFix.CLR.TypeSystem;
using CSHotFix.CLR.Method;
using CSHotFix.Other;
using CSHotFix.Runtime.Intepreter;

namespace System
{
    public delegate void Action<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
    public delegate TResult Func<T1, T2, T3, T4, T5, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
}

namespace CSHotFix.Runtime.Enviorment
{
    public class DelegateManager
    {
        List<DelegateMapNode> methods = new List<DelegateMapNode>();
        List<DelegateMapNode> functions = new List<DelegateMapNode>();
        IDelegateAdapter zeroParamMethodAdapter = new MethodDelegateAdapter();
        IDelegateAdapter dummyAdapter = new DummyDelegateAdapter();
        Dictionary<Type, Func<Delegate, Delegate>> clrDelegates = new Dictionary<Type, Func<Delegate, Delegate>>(new ByReferenceKeyComparer<Type>());
        Func<Delegate, Delegate> defaultConverter;
        Enviorment.AppDomain appdomain;
        public DelegateManager(Enviorment.AppDomain appdomain)
        {
            this.appdomain = appdomain;
            defaultConverter = DefaultConverterStub;
        }

        static Delegate DefaultConverterStub(Delegate dele)
        {
            return dele;
        }

        public void RegisterDelegateConvertor<T>(Func<Delegate, Delegate> action)
        {
            var type = typeof(T);
            if (type.IsSubclassOf(typeof(Delegate)))
            {
                clrDelegates[type] = action;
            }
            else
                throw new NotSupportedException();
        }

        public void RegisterMethodDelegate<T1>()
        {
            DelegateMapNode node = new Enviorment.DelegateManager.DelegateMapNode();
            node.Adapter = new MethodDelegateAdapter<T1>();
            node.ParameterTypes = new Type[] { typeof(T1) };
            methods.Add(node);
            MethodAdd<T1>(m_methods_1, node.Adapter);
            RegisterDelegateConvertor<Action<T1>>(defaultConverter);
        }

        public void RegisterMethodDelegate<T1, T2>()
        {
            DelegateMapNode node = new Enviorment.DelegateManager.DelegateMapNode();
            node.Adapter = new MethodDelegateAdapter<T1, T2>();
            node.ParameterTypes = new Type[] { typeof(T1), typeof(T2) };
            methods.Add(node);
            MethodAdd<T1, T2>(m_methods_2, node.Adapter);
            RegisterDelegateConvertor<Action<T1, T2>>(defaultConverter);
        }

        public void RegisterMethodDelegate<T1, T2, T3>()
        {
            DelegateMapNode node = new Enviorment.DelegateManager.DelegateMapNode();
            node.Adapter = new MethodDelegateAdapter<T1, T2, T3>();
            node.ParameterTypes = new Type[] { typeof(T1), typeof(T2), typeof(T3) };
            methods.Add(node);
            MethodAdd<T1, T2, T3>(m_methods_3, node.Adapter);
            RegisterDelegateConvertor<Action<T1, T2, T3>>(defaultConverter);
        }

        public void RegisterMethodDelegate<T1, T2, T3, T4>()
        {
            DelegateMapNode node = new Enviorment.DelegateManager.DelegateMapNode();
            node.Adapter = new MethodDelegateAdapter<T1, T2, T3, T4>();
            node.ParameterTypes = new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4) };
            methods.Add(node);
            MethodAdd<T1, T2, T3, T4>(m_methods_4, node.Adapter);
            RegisterDelegateConvertor<Action<T1, T2, T3, T4>>(defaultConverter);
        }
        public void RegisterMethodDelegate<T1, T2, T3, T4, T5>()
        {
            DelegateMapNode node = new Enviorment.DelegateManager.DelegateMapNode();
            node.Adapter = new MethodDelegateAdapter<T1, T2, T3, T4, T5>();
            node.ParameterTypes = new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) };
            methods.Add(node);
            MethodAdd<T1, T2, T3, T4, T5>(m_methods_5, node.Adapter);
            RegisterDelegateConvertor<Action<T1, T2, T3, T4, T5>>(defaultConverter);
        }

        public void RegisterFunctionDelegate<TResult>()
        {
            DelegateMapNode node = new Enviorment.DelegateManager.DelegateMapNode();
            node.Adapter = new FunctionDelegateAdapter<TResult>();
            node.ParameterTypes = new Type[] { typeof(TResult) };
            functions.Add(node);
            FunctionAdd<TResult>(m_functions_1, node.Adapter);
            RegisterDelegateConvertor<Func<TResult>>(defaultConverter);
        }

        public void RegisterFunctionDelegate<T1, TResult>()
        {
            DelegateMapNode node = new Enviorment.DelegateManager.DelegateMapNode();
            node.Adapter = new FunctionDelegateAdapter<T1, TResult>();
            node.ParameterTypes = new Type[] { typeof(T1), typeof(TResult) };
            functions.Add(node);
            FunctionAdd<T1, TResult>(m_functions_2, node.Adapter);
            RegisterDelegateConvertor<Func<T1, TResult>>(defaultConverter);
        }

        public void RegisterFunctionDelegate<T1, T2, TResult>()
        {
            DelegateMapNode node = new Enviorment.DelegateManager.DelegateMapNode();
            node.Adapter = new FunctionDelegateAdapter<T1, T2, TResult>();
            node.ParameterTypes = new Type[] { typeof(T1), typeof(T2), typeof(TResult) };
            functions.Add(node);
            FunctionAdd<T1, T2, TResult>(m_functions_3, node.Adapter);
            RegisterDelegateConvertor<Func<T1, T2, TResult>>(defaultConverter);
        }

        public void RegisterFunctionDelegate<T1, T2, T3, TResult>()
        {
            DelegateMapNode node = new Enviorment.DelegateManager.DelegateMapNode();
            node.Adapter = new FunctionDelegateAdapter<T1, T2, T3, TResult>();
            node.ParameterTypes = new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(TResult) };
            functions.Add(node);
            FunctionAdd<T1, T2, T3, TResult>(m_functions_4, node.Adapter);
            RegisterDelegateConvertor<Func<T1, T2, T3, TResult>>(defaultConverter);
        }

        public void RegisterFunctionDelegate<T1, T2, T3, T4, TResult>()
        {
            DelegateMapNode node = new Enviorment.DelegateManager.DelegateMapNode();
            node.Adapter = new FunctionDelegateAdapter<T1, T2, T3, T4, TResult>();
            node.ParameterTypes = new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(TResult) };
            functions.Add(node);
            FunctionAdd<T1, T2, T3, T4, TResult>(m_functions_5, node.Adapter);
            RegisterDelegateConvertor<Func<T1, T2, T3, T4, TResult>>(defaultConverter);
        }

        public void RegisterFunctionDelegate<T1, T2, T3, T4, T5, TResult>()
        {
            DelegateMapNode node = new Enviorment.DelegateManager.DelegateMapNode();
            node.Adapter = new FunctionDelegateAdapter<T1, T2, T3, T4, T5, TResult>();
            node.ParameterTypes = new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(TResult) };
            functions.Add(node);
            FunctionAdd<T1, T2, T3, T4, T5, TResult>(m_functions_6, node.Adapter);
            RegisterDelegateConvertor<Func<T1, T2, T3, T4, T5, TResult>>(defaultConverter);
        }

        internal Delegate ConvertToDelegate(Type clrDelegateType, IDelegateAdapter adapter)
        {
            Func<Delegate, Delegate> func;
            if (adapter is DummyDelegateAdapter)
            {
                DelegateAdapter.ThrowAdapterNotFound(adapter.Method);
                return null;
            }
            if (clrDelegates.TryGetValue(clrDelegateType, out func))
            {
                return func(adapter.Delegate);
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                string clsName, rName;
                bool isByRef;
                clrDelegateType.GetClassName(out clsName, out rName, out isByRef);
                sb.AppendLine("Cannot find convertor for " + rName);
                sb.AppendLine("Please add following code:");
                sb.Append("appdomain.DelegateManager.RegisterDelegateConvertor<");
                sb.Append(rName);
                sb.AppendLine(">((act) =>");
                sb.AppendLine("{");
                sb.Append("    return new ");
                sb.Append(rName);
                sb.Append("((");
                var mi = clrDelegateType.GetMethod("Invoke");
                bool first = true;
                foreach (var i in mi.GetParameters())
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                        sb.Append(", ");
                    sb.Append(i.Name);
                }
                sb.AppendLine(") =>");
                sb.AppendLine("    {");
                if (mi.ReturnType != appdomain.VoidType.TypeForCLR)
                {
                    sb.Append("        return ((Func<");
                    first = true;
                    foreach (var i in mi.GetParameters())
                    {
                        if (first)
                        {
                            first = false;
                        }
                        else
                            sb.Append(", ");
                        i.ParameterType.GetClassName(out clsName, out rName, out isByRef);
                        sb.Append(rName);
                    }
                    if (!first)
                        sb.Append(", ");
                    mi.ReturnType.GetClassName(out clsName, out rName, out isByRef);
                    sb.Append(rName);
                }
                else
                {
                    sb.Append("        ((Action<");
                    first = true;
                    foreach (var i in mi.GetParameters())
                    {
                        if (first)
                        {
                            first = false;
                        }
                        else
                            sb.Append(", ");
                        i.ParameterType.GetClassName(out clsName, out rName, out isByRef);
                        sb.Append(rName);
                    }
                }
                sb.Append(">)act)(");
                first = true;
                foreach (var i in mi.GetParameters())
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                        sb.Append(", ");
                    sb.Append(i.Name);
                }
                sb.AppendLine(");");
                sb.AppendLine("    });");
                sb.AppendLine("});");
                throw new KeyNotFoundException(sb.ToString());
            }
        }

        internal IDelegateAdapter FindDelegateAdapter(ILTypeInstance instance, ILMethod method)
        {
            IDelegateAdapter res = null;
            if (method.ReturnType == appdomain.VoidType)
            {
                if (method.ParameterCount == 0)
                {
                    res = zeroParamMethodAdapter.Instantiate(appdomain, instance, method);
                    if (instance != null)
                        instance.SetDelegateAdapter(method, res);
                    return res;
                }

                res = GetMethodAdapter(instance, method);
                if (res != null)
                {
                    return res;
                }
                else if(false)
                {
                    foreach (var i in methods)
                    {
                        if (i.ParameterTypes.Length == method.ParameterCount)
                        {
                            bool match = true;
                            for (int j = 0; j < method.ParameterCount; j++)
                            {
                                if (i.ParameterTypes[j] != method.Parameters[j].TypeForCLR)
                                {
                                    match = false;
                                    break;
                                }
                            }
                            if (match)
                            {
                                UnityEngine.Debug.Log("快速查找没有找到，但是老的查找却找到了的！");
                                res = i.Adapter.Instantiate(appdomain, instance, method);
                                if (instance != null)
                                    instance.SetDelegateAdapter(method, res);
                                return res;
                            }
                        }
                    }
                }
            }
            else
            {
                res = GetFunctionAdapter(instance, method);
                if (res != null)
                {
                    return res;
                }
                else if(false)
                {
                    foreach (var i in functions)
                    {
                        if (i.ParameterTypes.Length == method.ParameterCount + 1)
                        {
                            bool match = true;
                            for (int j = 0; j < method.ParameterCount; j++)
                            {
                                if (i.ParameterTypes[j] != method.Parameters[j].TypeForCLR)
                                {
                                    match = false;
                                    break;
                                }
                            }
                            if (match)
                            {
                                if (method.ReturnType.TypeForCLR == i.ParameterTypes[method.ParameterCount])
                                {
                                    UnityEngine.Debug.Log("快速查找没有找到，但是老的查找却找到了的！");
                                    res = i.Adapter.Instantiate(appdomain, instance, method);
                                    if (instance != null)
                                        instance.SetDelegateAdapter(method, res);
                                    return res;
                                }
                            }
                        }
                    }
                }
            }

            res = dummyAdapter.Instantiate(appdomain, instance, method);
            if (instance != null)
                instance.SetDelegateAdapter(method, res);
            return res;
        }

        class DelegateMapNode
        {
            public IDelegateAdapter Adapter { get; set; }
            public Type[] ParameterTypes { get; set; }
        }


        #region 重写method的查找方式
        private Dictionary<Type, IDelegateAdapter> m_methods_1 =
            new Dictionary<Type, IDelegateAdapter>();
        private Dictionary<Type, Dictionary<Type, IDelegateAdapter>> m_methods_2 =
            new Dictionary<Type, Dictionary<Type, IDelegateAdapter>>();
        private Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>> m_methods_3 =
            new Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>();
        private Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>> m_methods_4 =
            new Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>>();
        private Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>>> m_methods_5 =
            new Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>>>();

        private Dictionary<Type, IDelegateAdapter> m_functions_1 =
            new Dictionary<Type, IDelegateAdapter>();
        private Dictionary<Type, Dictionary<Type, IDelegateAdapter>> m_functions_2 =
            new Dictionary<Type, Dictionary<Type, IDelegateAdapter>>();
        private Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>> m_functions_3 =
            new Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>();
        private Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>> m_functions_4 =
            new Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>>();
        private Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>>> m_functions_5 =
            new Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>>>();
        private Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>>>> m_functions_6 =
            new Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>>>>();



        private void MethodAdd<T1>(Dictionary<Type, IDelegateAdapter> method, IDelegateAdapter adapter)
        {
            var t1 = typeof(T1);
            if (!method.ContainsKey(t1))
            {
                method.Add(t1, adapter);
            }

        }
        private void MethodAdd<T1, T2>(Dictionary<Type, Dictionary<Type, IDelegateAdapter>> method, IDelegateAdapter adapter)
        {
            var t1 = typeof(T1);
            if (!method.ContainsKey(t1))
            {
                Dictionary<Type, IDelegateAdapter> m = new Dictionary<Type, IDelegateAdapter>();
                method.Add(t1, m);
                MethodAdd<T2>(m, adapter);
            }
            else
            {
                MethodAdd<T2>(method[t1], adapter);
            }

        }
        private void MethodAdd<T1, T2, T3>(Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>> method, IDelegateAdapter adapter)
        {
            var t1 = typeof(T1);
            if (!method.ContainsKey(t1))
            {
                Dictionary<Type, Dictionary<Type, IDelegateAdapter>> m = new Dictionary<Type, Dictionary<Type, IDelegateAdapter>>();
                method.Add(t1, m);
                MethodAdd<T2, T3>(m, adapter);
            }
            else
            {
                MethodAdd<T2, T3>(method[t1], adapter);
            }
        }
        private void MethodAdd<T1, T2, T3, T4>(Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>> method, IDelegateAdapter adapter)
        {
            var t1 = typeof(T1);
            if (!method.ContainsKey(t1))
            {
                Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>> m = new Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>();
                method.Add(t1, m);
                MethodAdd<T2, T3, T4>(m, adapter);
            }
            else
            {
                MethodAdd<T2, T3, T4>(method[t1], adapter);
            }
        }
        private void MethodAdd<T1, T2, T3, T4, T5>(Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>>> method, IDelegateAdapter adapter)
        {
            var t1 = typeof(T1);
            if (!method.ContainsKey(t1))
            {
                Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>> m = new Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>>();
                method.Add(t1, m);
                MethodAdd<T2, T3, T4, T5>(m, adapter);
            }
            else
            {
                MethodAdd<T2, T3, T4, T5>(method[t1], adapter);
            }
        }


        private void FunctionAdd<T1>(Dictionary<Type, IDelegateAdapter> function, IDelegateAdapter adapter)
        {
            var t1 = typeof(T1);
            if (function.ContainsKey(t1))
            {

            }
            else
            {
                function.Add(t1, adapter);
            }

        }
        private void FunctionAdd<T1, T2>(Dictionary<Type, Dictionary<Type, IDelegateAdapter>> function, IDelegateAdapter adapter)
        {

            var t1 = typeof(T1);
            if (!function.ContainsKey(t1))
            {
                Dictionary<Type, IDelegateAdapter> m = new Dictionary<Type, IDelegateAdapter>();
                function.Add(t1, m);
                FunctionAdd<T2>(m, adapter);
            }
            else
            {
                FunctionAdd<T2>(function[t1], adapter);
            }
        }
        private void FunctionAdd<T1, T2, T3>(Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>> function, IDelegateAdapter adapter)
        {
            var t1 = typeof(T1);
            if (!function.ContainsKey(t1))
            {
                Dictionary<Type, Dictionary<Type, IDelegateAdapter>> m = new Dictionary<Type, Dictionary<Type, IDelegateAdapter>>();
                function.Add(t1, m);
                FunctionAdd<T2, T3>(m, adapter);
            }
            else
            {
                FunctionAdd<T2, T3>(function[t1], adapter);
            }

        }
        private void FunctionAdd<T1, T2, T3, T4>(Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>> function, IDelegateAdapter adapter)
        {
            var t1 = typeof(T1);
            if (!function.ContainsKey(t1))
            {
                Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>> m = new Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>();
                function.Add(t1, m);
                FunctionAdd<T2, T3, T4>(m, adapter);
            }
            else
            {
                FunctionAdd<T2, T3, T4>(function[t1], adapter);
            }

        }
        private void FunctionAdd<T1, T2, T3, T4, T5>(Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>>> function, IDelegateAdapter adapter)
        {
            var t1 = typeof(T1);
            if (!function.ContainsKey(t1))
            {
                Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>> m = new Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>>();
                function.Add(t1, m);
                FunctionAdd<T2, T3, T4, T5>(m, adapter);
            }
            else
            {
                FunctionAdd<T2, T3, T4, T5>(function[t1], adapter);
            }

        }
        private void FunctionAdd<T1, T2, T3, T4, T5, T6>(Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>>>> function, IDelegateAdapter adapter)
        {
            var t1 = typeof(T1);
            if (!function.ContainsKey(t1))
            {
                Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>>> m = new Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>>>();
                function.Add(t1, m);
                FunctionAdd<T2, T3, T4, T5, T6>(m, adapter);
            }
            else
            {
                FunctionAdd<T2, T3, T4, T5, T6>(function[t1], adapter);
            }

        }


        private IDelegateAdapter GetMethodAdapter(ILTypeInstance instance, ILMethod method, int curIdx, Dictionary<Type, IDelegateAdapter> dic)
        {
            Type t = method.Parameters[++curIdx].TypeForCLR;
            if (dic.ContainsKey(t))
            {
                return dic[t];
            }
            else
            {
                return null;
            }
        }
        private IDelegateAdapter GetMethodAdapter(ILTypeInstance instance, ILMethod method, int curIdx, Dictionary<Type, Dictionary<Type, IDelegateAdapter>> dic)
        {
            Type t = method.Parameters[++curIdx].TypeForCLR;
            if (dic.ContainsKey(t))
            {
                var newDic = dic[t];
                if (newDic != null)
                {
                    return GetMethodAdapter(instance, method, curIdx, newDic);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        private IDelegateAdapter GetMethodAdapter(ILTypeInstance instance, ILMethod method, int curIdx, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>> dic)
        {
            Type t = method.Parameters[++curIdx].TypeForCLR;
            if (dic.ContainsKey(t))
            {
                var newDic = dic[t];
                if (newDic != null)
                {
                    return GetMethodAdapter(instance, method, curIdx, newDic);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        private IDelegateAdapter GetMethodAdapter(ILTypeInstance instance, ILMethod method, int curIdx, Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>> dic)
        {
            Type t = method.Parameters[++curIdx].TypeForCLR;
            if(dic.ContainsKey(t))
            {
                var newDic = dic[t];
                if(newDic != null)
                {
                    return GetMethodAdapter(instance, method, curIdx, newDic);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        private IDelegateAdapter GetMethodAdapter(ILTypeInstance instance, ILMethod method)
        {
            IDelegateAdapter adapter = null;
            int paramCount = method.ParameterCount;
            switch(paramCount)
            {
                case 1:
                    {
                        if( m_methods_1.ContainsKey(method.Parameters[0].TypeForCLR))
                        {
                            adapter = m_methods_1[method.Parameters[0].TypeForCLR];
                        }
                            
                        break;
                    }
                case 2:
                    {
                        if (m_methods_2.ContainsKey(method.Parameters[0].TypeForCLR))
                        {
                            var dic = m_methods_2[method.Parameters[0].TypeForCLR];
                            adapter = GetMethodAdapter(instance, method, 0, dic);
                        }
                        break;
                    }
                case 3:
                    {
                        if (m_methods_3.ContainsKey(method.Parameters[0].TypeForCLR))
                        {
                            var dic = m_methods_3[method.Parameters[0].TypeForCLR];
                            adapter = GetMethodAdapter(instance, method, 0, dic);
                        }
                        break;
                    }
                case 4:
                    {
                        if (m_methods_4.ContainsKey(method.Parameters[0].TypeForCLR))
                        {
                            var dic = m_methods_4[method.Parameters[0].TypeForCLR];
                            adapter = GetMethodAdapter(instance, method, 0, dic);
                        }
                        break;
                    }
                case 5:
                    {
                        if (m_methods_5.ContainsKey(method.Parameters[0].TypeForCLR))
                        {
                            var dic = m_methods_5[method.Parameters[0].TypeForCLR];
                            adapter = GetMethodAdapter(instance, method, 0, dic);
                        }
                        break;
                    }
            }
            if(adapter == null)
            {
                return null;
            }
            var res = adapter.Instantiate(appdomain, instance, method);
            if (instance != null)
                instance.SetDelegateAdapter(method, res);
            return res;
        }


        private IDelegateAdapter GetFunctionAdapter(ILTypeInstance instance, ILMethod method, int curIdx, Dictionary<Type, IDelegateAdapter> dic)
        {
            Type t = method.ReturnType.TypeForCLR;
            if (dic.ContainsKey(t))
            {
                return dic[t];
            }
            else
            {
                return null;
            }
        }
        private IDelegateAdapter GetFunctionAdapter(ILTypeInstance instance, ILMethod method, int curIdx, Dictionary<Type, Dictionary<Type, IDelegateAdapter>> dic)
        {
            Type t = method.Parameters[++curIdx].TypeForCLR;
            if (dic.ContainsKey(t))
            {
                var newDic = dic[t];
                if (newDic != null)
                {
                    return GetFunctionAdapter(instance, method, curIdx, newDic);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        private IDelegateAdapter GetFunctionAdapter(ILTypeInstance instance, ILMethod method, int curIdx, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>> dic)
        {
            Type t = method.Parameters[++curIdx].TypeForCLR;
            if (dic.ContainsKey(t))
            {
                var newDic = dic[t];
                if (newDic != null)
                {
                    return GetFunctionAdapter(instance, method, curIdx, newDic);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        private IDelegateAdapter GetFunctionAdapter(ILTypeInstance instance, ILMethod method, int curIdx, Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>> dic)
        {
            Type t = method.Parameters[++curIdx].TypeForCLR;
            if (dic.ContainsKey(t))
            {
                var newDic = dic[t];
                if (newDic != null)
                {
                    return GetFunctionAdapter(instance, method, curIdx, newDic);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        private IDelegateAdapter GetFunctionAdapter(ILTypeInstance instance, ILMethod method, int curIdx, Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, Dictionary<Type, IDelegateAdapter>>>>> dic)
        {
            Type t = method.Parameters[++curIdx].TypeForCLR;
            if (dic.ContainsKey(t))
            {
                var newDic = dic[t];
                if (newDic != null)
                {
                    return GetFunctionAdapter(instance, method, curIdx, newDic);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        private IDelegateAdapter GetFunctionAdapter(ILTypeInstance instance, ILMethod method)
        {
            IDelegateAdapter adapter = null;
            int paramCount = method.ParameterCount;
            switch (paramCount)
            {
                case 0:
                    {
                        if (m_functions_1.ContainsKey(method.ReturnType.TypeForCLR))
                        {
                            adapter = m_functions_1[method.ReturnType.TypeForCLR];
                        }
                        break;
                    }
                case 1:
                    {
                        if (m_functions_2.ContainsKey(method.Parameters[0].TypeForCLR))
                        {
                            var dic = m_functions_2[method.Parameters[0].TypeForCLR];
                            adapter = GetFunctionAdapter(instance, method, 0, dic);
                        }
                        break;
                    }
                case 2:
                    {
                        if (m_functions_3.ContainsKey(method.Parameters[0].TypeForCLR))
                        {
                            var dic = m_functions_3[method.Parameters[0].TypeForCLR];
                            adapter = GetFunctionAdapter(instance, method, 0, dic);
                        }
                        break;
                    }
                case 3:
                    {
                        if (m_functions_4.ContainsKey(method.Parameters[0].TypeForCLR))
                        {
                            var dic = m_functions_4[method.Parameters[0].TypeForCLR];
                            adapter = GetFunctionAdapter(instance, method, 0, dic);
                        }
                        break;
                    }
                case 4:
                    {
                        if (m_functions_5.ContainsKey(method.Parameters[0].TypeForCLR))
                        {
                            var dic = m_functions_5[method.Parameters[0].TypeForCLR];
                            adapter = GetFunctionAdapter(instance, method, 0, dic);
                        }
                        break;
                    }
                case 5:
                    {
                        if (m_functions_6.ContainsKey(method.Parameters[0].TypeForCLR))
                        {
                            var dic = m_functions_6[method.Parameters[0].TypeForCLR];
                            adapter = GetFunctionAdapter(instance, method, 0, dic);
                        }
                        break;
                    }
            }
            if(adapter == null)
            {
                return null;
            }
            var res = adapter.Instantiate(appdomain, instance, method);
            if (instance != null)
                instance.SetDelegateAdapter(method, res);
            return res;
        }
        #endregion
    }
}
