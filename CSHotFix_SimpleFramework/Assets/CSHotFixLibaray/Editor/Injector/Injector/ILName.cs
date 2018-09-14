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
using System.IO;

namespace LCL
{
    public class NameLine
    {
        public TypeDefinition Method;
        public string Name;
    }
    public class ILName
    {
      
        public static string GenerateMethodName(MethodDefinition method)
        {
            string delegateFieldName = "__"+ method.DeclaringType.FullName+ "__" + method.Name;
            for (int i = 0; i < method.Parameters.Count; i++)
            {
                delegateFieldName += "_" + method.Parameters[i].ParameterType.FullName;
            }
            string returnname = method.ReturnType.FullName;
            if (returnname.ToLower().Contains("Void"))
            {
                returnname = "void";
            }
            delegateFieldName += "_" + returnname;
            delegateFieldName += "__Delegate";
            delegateFieldName = delegateFieldName.Replace(".", "_").
                Replace("`1", "").
                Replace("`2","").
                Replace("&", "_at_").
                Replace("[]", "_arr_").
                Replace("<","_").
                Replace(">","_").
                Replace(",","_");

            return delegateFieldName;
        }

        public static void WritedFieldDelegateName(string delegatePath, List<NameLine> FieldDelegateNames)
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
"public class LCLFieldDelegateName\r\n" +
"{\r\n";
            string fieldstrings = "";
            foreach(var nameline in FieldDelegateNames)
            {
                string line = "     public static " + nameline.Method.FullName.Replace("/",".") + " " + nameline.Name + ";\r\n";
                fieldstrings += line;
            }
            string fileEnd =
    "}\r\n"+
    "#endif";

            string outputString = fileHeader + fieldstrings + fileEnd;
            FileStream file = null;
            StreamWriter sw = null;
            //有什么错误，就直接让系统去抛吧。
            file = new FileStream(delegatePath + "/LCLFieldDelegateName.cs", FileMode.Create);
            sw = new StreamWriter(file);
            sw.Write(outputString);
            sw.Flush();
            sw.Close();
            file.Close();

        }

    }

}