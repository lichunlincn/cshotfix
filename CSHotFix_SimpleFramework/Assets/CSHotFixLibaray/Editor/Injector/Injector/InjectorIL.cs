/*
 * LCL support c# hotfix here.
 * Copyright (C) LCL. All rights reserved.
 * URL:https://github.com/qq576067421/cshotfix
 * QQ:576067421
 * QQ Group:673735733
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
 * 
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Editor_Mono.Cecil;
using Editor_Mono.Cecil.Cil;
using System.Diagnostics;
using System.Reflection;

namespace LCL
{
    public class InjectorIL
    {
        private List<TypeDefinition> m_DelegateFunctions = null;
        private List<NameLine> m_NameLines = new List<NameLine>();
        private TypeDefinition m_FieldDelegateNameTD;

        private bool m_IsWriteName = false;
        public void InjectAssembly(string dllPath, string[] unitydllPath, string delegatePath, bool isWriteName)
        {
            m_IsWriteName = isWriteName;
            var readerParameters = new ReaderParameters { ReadSymbols = false };
            AssemblyDefinition assemblyDef = AssemblyDefinition.ReadAssembly(dllPath, readerParameters);

            var resolver = assemblyDef.MainModule.AssemblyResolver as BaseAssemblyResolver;
            foreach (string path in unitydllPath)
            {
                UnityEngine.Debug.Log(path);
                resolver.AddSearchDirectory(path);
            }
            var assembly = Assembly.LoadFile(dllPath);
            var assembly_types = assembly.GetTypes().ToList();

            m_NameLines.Clear();
            Stopwatch watch = new Stopwatch();
            watch.Reset();
            watch.Start();
            foreach (var module in assemblyDef.Modules)
            {
                List<TypeDefinition> types = module.Types.ToList();
                TypeDefinition FunctionDelegate = types.Find((td) => td.FullName.Contains("LCLFunctionDelegate"));
                if (FunctionDelegate != null)
                {
                    m_DelegateFunctions = FunctionDelegate.NestedTypes.ToList().FindAll((_type) =>
                    {
                        string name = _type.BaseType.Name;
                        return (name == typeof(Delegate).Name || name == typeof(MulticastDelegate).Name);
                    });
                    if (m_DelegateFunctions != null && m_DelegateFunctions.Count > 0)
                    {
                        break;
                    }
                }
            }
            watch.Stop();
            UnityEngine.Debug.Log("查找委托 time:" + watch.ElapsedMilliseconds);

            if (!isWriteName)
            {
                foreach (var module in assemblyDef.Modules)
                {
                    List<TypeDefinition> types = module.Types.ToList();
                    m_FieldDelegateNameTD = types.Find((td) => td.FullName.Contains("LCLFieldDelegateName"));
                    if (m_FieldDelegateNameTD != null)
                    {
                        break;
                    }
                }
            }

            watch.Reset();
            watch.Start();
            foreach (var module in assemblyDef.Modules)
            {
                foreach (var typ in module.Types)
                {
                    string name = typ.FullName;
                    var dllType = assembly_types.Find((_type) =>
                    {
                        string _name = _type.FullName;
                        return _name == name;
                    });
                    if (dllType == null)
                    {
                        continue;
                    }
                    if (Filter.DelegateTypeFilter(dllType))
                    {
                        continue;
                    }
                    foreach (var method in typ.Methods)
                    {
                        if (isWriteName)
                        {
                            if (!Filter.FilterMethod(method))
                            {
                                continue;
                            }
                        }

                        InjectMethod(typ, method);
                    }
                }
            }
            watch.Stop();
            UnityEngine.Debug.Log("委托字段 time:" + watch.ElapsedMilliseconds);

            if (!isWriteName)
            {
                var writerParameters = new WriterParameters { WriteSymbols = true };
                assemblyDef.Write(dllPath, writerParameters);


                if (assemblyDef.MainModule.SymbolReader != null)
                {
                    assemblyDef.MainModule.SymbolReader.Dispose();
                }
            }
            else
            {
                ILName.WritedFieldDelegateName(delegatePath, m_NameLines);
            }
        }


        private void InjectMethod(TypeDefinition type, MethodDefinition method)
        {
            if (type.Name.Contains("<") || type.IsInterface || type.Methods.Count == 0) // skip anonymous type and interface
                return;
            if (method.Name == ".cctor")
                return;
            if (method.Name == ".ctor")
                return;

            //寻找一个用于注入的委托
            TypeDefinition delegateTypeRef = FindDelegateFunction(method);

            if (delegateTypeRef != null)
            {
                //在type里面定义一个字段，类型是我们刚刚找到的委托方法
                string delegateFieldName = ILName.GenerateMethodName(method);
                m_NameLines.Add(new NameLine() { Method = delegateTypeRef, Name = delegateFieldName });
                if (!m_IsWriteName)
                {
                    ILGen.GenIL(delegateFieldName, type, method, delegateTypeRef, m_FieldDelegateNameTD);
                }
            }
        }
        private bool HasOutRefArrayParameter(MethodDefinition method)
        {
            return method.Parameters.ToList().Exists((pd) => GetParamTypeEnum(pd) != RefOutArrayEnum.None);
        }

        private RefOutArrayEnum GetParamTypeEnum(ParameterDefinition pd)
        {
            if (pd.IsOut)
            {
                return RefOutArrayEnum.Out;
            }
            else if (pd.ParameterType.IsByReference)
            {
                return RefOutArrayEnum.Ref;
            }
            else if (pd.ParameterType.IsArray)
            {
                return RefOutArrayEnum.Array;
            }
            else
            {
                return RefOutArrayEnum.None;
            }
        }
        private TypeDefinition FindDelegateFunction(MethodDefinition method)
        {
            if (method == null)
            {
                return null;
            }
            var t = m_DelegateFunctions.Find((df) =>
            {
                MethodDefinition mdf = df.Methods.ToList().Find((md) => md.Name.Contains("Invoke"));
                if (mdf == null)
                {
                    return false;
                }
                if (mdf.ReturnType.FullName != method.ReturnType.FullName)
                {
                    return false;
                }

                var mdf_params = mdf.Parameters.ToList();
                var mdf_params2 = method.Parameters.ToList();
                if (mdf_params.Count != mdf_params2.Count + 1)
                {
                    return false;
                }
                for (int i = 0; i < mdf_params2.Count; ++i)
                {
                    if (GetParamTypeEnum(mdf_params[i + 1]) != GetParamTypeEnum(mdf_params2[i]))
                    {
                        return false;
                    }
                    if (mdf_params[i + 1].ParameterType.FullName != mdf_params2[i].ParameterType.FullName)
                    {
                        return false;
                    }

                }
                return true;

            });
            return t;
        }
    }

}