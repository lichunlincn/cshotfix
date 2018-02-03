/*
 * LCL support c# hotfix here.
 * Copyright (C) LCL. All rights reserved.
 * URL:https://github.com/qq576067421/cshotfix
 * QQ:576067421
 * QQ Group:673735733
 * Licensed under the GNU License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
 * http://fsf.org/
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil;
using Mono.Cecil.Cil;
namespace LCL
{
    public class InjectorIL
    {
        private List<TypeDefinition> m_DelegateFunctions = null;
        private List<NameLine> m_NameLines = new List<NameLine>();
        private TypeDefinition m_FieldDelegateNameTD;

        private bool m_IsWriteName = false;
        public void InjectAssembly(string dllPath, string delegatePath, bool isWriteName)
        {
            m_IsWriteName = isWriteName;
            var readerParameters = new ReaderParameters { ReadSymbols = false };
            AssemblyDefinition assembly = AssemblyDefinition.ReadAssembly(dllPath, readerParameters);
            m_NameLines.Clear();
            foreach (var module in assembly.Modules)
            {
                List<TypeDefinition> types = module.Types.ToList();
                TypeDefinition FunctionDelegate = types.Find((td) => { return td.FullName.Contains("FunctionDelegate"); });
                if (FunctionDelegate != null)
                {
                    m_DelegateFunctions = FunctionDelegate.NestedTypes.ToList();
                    if (m_DelegateFunctions != null && m_DelegateFunctions.Count > 0)
                    {
                        break;
                    }
                }
            }


            foreach (var module in assembly.Modules)
            {
                List<TypeDefinition> types = module.Types.ToList();
                m_FieldDelegateNameTD = types.Find((td) => { return td.FullName.Contains("LCLFieldDelegateName"); });
                if(m_FieldDelegateNameTD!= null)
                {
                    break;
                }
            }


            foreach (var module in assembly.Modules)
            {
                foreach (var typ in module.Types)
                {
                    if(typ.Namespace == null || !typ.Namespace.Contains("LCL"))
                    {
                        continue;
                    }
                    foreach (var method in typ.Methods)
                    {
                        InjectMethod(typ, method);
                    }
                }
            }

            if (!isWriteName)
            {
                var writerParameters = new WriterParameters { WriteSymbols = true };
                assembly.Write(dllPath, writerParameters);


                if (assembly.MainModule.SymbolReader != null)
                {
                    assembly.MainModule.SymbolReader.Dispose();
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
            return method.Parameters.ToList().Exists((pd) =>
            {
                return GetParamTypeEnum(pd) != RefOutArrayEnum.None;
            });
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
            var t = m_DelegateFunctions.Find((df) =>
            {
                MethodDefinition mdf = df.Methods.ToList().Find((md) => { return md.Name.Contains("Invoke"); });
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