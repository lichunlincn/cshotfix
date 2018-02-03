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
using System.IO;
using System.Linq;
using System.Text;

namespace LCL
{
    public class ILRuntime_RegisterFunctionDelegate_Writer
    {
        public void WriteRegisterFunctionDelegate(string filePath, List<LMethodInfo> lines)
        {
            string fileHeader =
    "/*\r\n" +
    "* LCL support c# hotfix here.\r\n" +
    "*Copyright(C) LCL.All rights reserved.\r\n" +
    "* URL:https://github.com/qq576067421/cshotfix \r\n" +
    "*QQ:576067421 \r\n" +
    "* QQ Group: 673735733 \r\n" +
    " * Licensed under the GNU License (the \"License\"); you may not use this file except in compliance with the License. You may obtain a copy of the License at \r\n" +
    "* http://fsf.org/ \r\n" +
    "* Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an \"AS IS\" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License. \r\n" +
    "*/  \r\n" +
    "using System;\r\n" +
    "using System.Collections.Generic;\r\n" +
    "using System.Linq;\r\n" +
    "using System.Text;\r\n" +
    "using ILRuntime.Runtime.Enviorment;\r\n" +
    "public class LCLRegisterFunctionDelegate\r\n" +
    "{\r\n" +
    "   public static void Reg(ILRuntime.Runtime.Enviorment.AppDomain appDomain)\r\n" +
    "   {\r\n";
            string reglines = "";
            foreach (var info in lines)
            {
                string methodName = info.m_ReturnString.ToLower().Contains("void") ? "Method" : "Function";
                string line = "         appDomain.DelegateManager.Register"+methodName+"Delegate<";
                string paramstr = "";
                for(int i=0;i< info.m_Params.Count;++i)
                {
                    paramstr += info.m_Params[i].m_ParamString;
                    if(i< info.m_Params.Count -1)
                    {
                        paramstr +=  ",";
                    }
                }
                if(!info.m_ReturnString.ToLower().Contains("void"))
                {
                    paramstr += "," + info.m_ReturnString;
                }
                line += paramstr;
                line += ">();\r\n";
                reglines += line;

            }
            string fileEnd =
    "   }\r\n" +
    "}";
            string outputString = "#if USE_ILR \r\n" + fileHeader + reglines + fileEnd + "\r\n"+"#endif";

            FileStream file = new FileStream(filePath + "/LCLRegisterFunctionDelegate.cs", FileMode.Create);
            StreamWriter sw = new StreamWriter(file);
            sw.Write(outputString);
            sw.Flush();
            sw.Close();
            file.Close();

        }
    }

}