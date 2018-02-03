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
using System.Reflection;
using System.Text;

namespace LCL
{
    public class DelegateGen
    {
        private Assembly m_Assembly = null;

        public void Run(string dllPath, string delegatePath)
        {
            var lines = LoadAssembly(dllPath);

            var delegateWriter = new DelegateWriter();

            delegateWriter.WriteFunctionDelegate(delegatePath, lines);


            //ILRuntime_RegisterFunctionDelegate_Writer registerFunctionDelegate = new ILRuntime_RegisterFunctionDelegate_Writer();
            //registerFunctionDelegate.WriteRegisterFunctionDelegate(delegatePath, lines);
        }
        private List<LMethodInfo> LoadAssembly(string assemblyName)
        {
            List<LMethodInfo> funcLines = new List<LMethodInfo>();

            m_Assembly = Assembly.LoadFile(assemblyName);
            var types = m_Assembly.GetTypes();
            int methodId = 0;
            foreach (var type in types)
            {
                if(type.Namespace == null || !type.Namespace.Contains("LCL") )
                {
                    continue;
                }
                if (type.Name.Contains("LCLFunctionDelegate")||
                    type.Name.Contains("LCLRegisterFunctionDelegate"))
                {
                    continue;
                }
                if (type.DeclaringType != null && (
                    type.DeclaringType.Name.Contains("LCLFunctionDelegate")||
                    type.DeclaringType.Name.Contains("LCLRegisterFunctionDelegate")
                    ))
                {
                    continue;
                }
                var methodInfos = type.GetMethods(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                foreach (var methodinfo in methodInfos)
                {
                    //只处理本类的方法，派生方法不要
                    LMethodInfo info = new LMethodInfo();
                    var returnparamter = methodinfo.ReturnParameter;
                    info.m_ReturnString = returnparamter.ParameterType.ToString();
                    if (info.m_ReturnString.Contains("Void"))
                    {
                        info.m_ReturnString = "void";
                    }

                    var paramters = methodinfo.GetParameters();
                    if (paramters != null)
                    {
                        //添加this的object，每个委托都需要默认有一个
                        info.m_Params.Add(new ParamData() { m_ParamString = "System.Object", m_RefOut = RefOutArrayEnum.None });
                        foreach (var pi in paramters)
                        {
                            ParamData paramdata = new ParamData();
                            if (pi.IsOut)
                            {
                                //暂时不支持out
                                paramdata.m_RefOut = RefOutArrayEnum.Out;
                                continue;
                            }
                            else if (pi.ParameterType.IsByRef)
                            {
                                //暂时不支持ref
                                paramdata.m_RefOut = RefOutArrayEnum.Ref;
                                continue;
                            }
                            else if (pi.ParameterType.IsArray)
                            {
                                paramdata.m_RefOut = RefOutArrayEnum.Array;
                            }


                            paramdata.m_ParamString = pi.ParameterType.ToString().Replace("&", "");
                            info.m_Params.Add(paramdata);
                        }
                    }
                    if (!funcLines.Exists((oldInfo) => { return IsEqualLMethodInfo(oldInfo, info); }))
                    {
                        funcLines.Add(info);
                    }
                }
            }

            return funcLines;
        }

        private bool IsEqualLMethodInfo(LMethodInfo info0, LMethodInfo info1)
        {
            if (info0.m_ReturnString != info1.m_ReturnString)
            {
                return false;
            }
            if (info0.m_Params.Count != info1.m_Params.Count)
            {
                return false;
            }
            for (int i = 0; i < info0.m_Params.Count; ++i)
            {
                var paramData0 = info0.m_Params[i];
                var paramData1 = info1.m_Params[i];
                if (paramData0.m_ParamString != paramData1.m_ParamString)
                {
                    return false;
                }
                if (paramData0.m_RefOut != paramData1.m_RefOut)
                {
                    return false;
                }
            }
            return true;
        }
    }

}