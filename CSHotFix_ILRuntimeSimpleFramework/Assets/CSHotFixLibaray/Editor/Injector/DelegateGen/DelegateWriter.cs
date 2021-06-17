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
using System.IO;
using System.Linq;
using System.Text;

namespace LCL
{
    public class DelegateWriter
    {
        public void WriteFunctionDelegate(string filePath, List<LMethodInfo> lines)
        {
            string fileHeader =
    "#if CSHotFix\n\r" +
    "/*\r\n" +
    "* LCL support c# hotfix here.\r\n" +
    "*Copyright(C) LCL.All rights reserved.\r\n" +
    "* URL:https://github.com/qq576067421/cshotfix \r\n" +
    "*QQ:576067421 \r\n" +
    "* QQ Group: 673735733 \r\n" +
    " * Licensed under the MIT License (the \"License\"); you may not use this file except in compliance with the License. You may obtain a copy of the License at \r\n" +
    "*  \r\n" +
    "* Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an \"AS IS\" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License. \r\n" +
    "*/  \r\n" +
    "using System;\r\n" +
    "using System.Collections.Generic;\r\n" +
    "using System.Linq;\r\n" +
    "using System.Text;\r\n" +
    "public class LCLFunctionDelegate\r\n" +
    "{\r\n";
            int funcIndex = 0;
            string fileFunctions = "";

            string regLines = "";
            foreach (var info in lines)
            {
                string funcName = "";
                if (string.IsNullOrEmpty(info.m_DelegateName))
                {
                    string funcline = "     public delegate " + info.m_ReturnString + " ";
                    
                    if (info.m_ReturnString.ToLower().Contains("void"))
                    {
                        funcName = "method_delegate" + funcIndex++;
                    }
                    else
                    {
                        funcName = "function_delegate" + funcIndex++;
                    }
                    funcline += funcName + "(";
                    int paramIndex = 0;
                    foreach (var param in info.m_Params)
                    {
                        string paramType = "";
                        if (param.m_RefOut == RefOutArrayEnum.Ref)
                        {
                            paramType += "ref ";
                        }
                        else if (param.m_RefOut == RefOutArrayEnum.Out)
                        {
                            paramType += "out ";
                        }
                        else
                        {

                        }

                        paramType += param.m_ParamString;
                        paramType += " arg" + paramIndex++;
                        if (paramIndex < info.m_Params.Count)
                        {
                            paramType += ",";
                        }
                        funcline += paramType;
                    }
                    funcline += ");\r\n";
                    fileFunctions += funcline;
                }
                else
                {
                    funcName = info.m_DelegateName;
                }
                regLines += WriteRegisterDelegateConvertor(funcName, info)+"\r\n";
            }
            regLines = "    public static void Reg(CSHotFix.Runtime.Enviorment.AppDomain appDomain)\r\n"+
    "{ \r\n"+regLines +
                "}\r\n";


            string fileEnd =
    "}\r\n"+
    "#endif";

            string outputString = fileHeader + fileFunctions + regLines +fileEnd;
            FileStream file = null;
            StreamWriter sw = null;
			if (!Directory.Exists (filePath)) 
            {
				Directory.CreateDirectory(filePath);
			}
            else
            {
                //Directory.Delete(filePath,true);
                //Directory.CreateDirectory(filePath);
            }
            file = new FileStream(filePath + "/LCLFunctionDelegate.cs", FileMode.Create);
            sw = new StreamWriter(file);
            sw.Write(outputString);
            sw.Flush();
            sw.Close();
            file.Close();
        }

        private string WriteRegisterDelegateConvertor(string method_delegate, LMethodInfo info)
        {
            bool isAction = info.m_ReturnString.ToLower().Contains("void");
            string paramstrings = "";
            string paramTypestrings = "";
            int index = 0;
            foreach(var p in info.m_Params)
            {
                paramTypestrings += p.m_ParamString;
                paramstrings += "arg" + index;
                if(index < info.m_Params.Count-1)
                {
                    paramTypestrings += ",";
                    paramstrings += ",";
                }

                index++;
            }
            if (!isAction)
            {
                if (info.m_Params.Count == 0)
                {
                    paramTypestrings = info.m_ReturnString;
                }
                else
                {
                    paramTypestrings += "," + info.m_ReturnString;
                }
            }

            //这里无论是注入生成还是脚本那边的都需要
            paramTypestrings = (string.IsNullOrEmpty(paramTypestrings) ? "" : ("<" + paramTypestrings + ">"));
            string regDelegate = "appDomain.DelegateManager.Register" + (isAction ? "Method" : "Function") + "Delegate" + paramTypestrings + "();\r\n";
            if(string.IsNullOrEmpty(paramTypestrings))
            {
                regDelegate = "";
            }

            string convertor = "";
            ////并且过滤掉system.action
            if (info.m_DelegateName.Contains("Action`") ||
                info.m_DelegateName.Contains("Func`") ||
                info.m_DelegateName.Contains("Predicate`") ||
                info.m_DelegateName.Contains("Comparison`"))
            {
                
            }
            else
            {
                string typeName = string.IsNullOrEmpty(info.m_DelegateName) ? ("LCLFunctionDelegate." + method_delegate) : method_delegate;
                convertor =
                    "   appDomain.DelegateManager.RegisterDelegateConvertor<" + typeName + ">((act) =>\r\n" +
                    "   {\r\n" +
                    "       return new " + typeName + "((" + paramstrings + ") =>\r\n" +
                    "       {\r\n" +
                    "       " + (isAction ? "" : "return ") + "((" + (isAction ? "Action" : "Func") + paramTypestrings + ")act)(" + paramstrings + ");\r\n" +
                    "       });\r\n" +
                    "   });\r\n";
            }
            return regDelegate + convertor;
        }
    }

}