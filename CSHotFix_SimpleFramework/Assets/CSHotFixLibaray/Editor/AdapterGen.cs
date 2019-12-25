/*
* LCL support c# hotfix here.
*Copyright(C) LCL.All rights reserved.
* URL:https://github.com/qq576067421/cshotfix 
*QQ:576067421 
* QQ Group: 673735733 
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at 
*  
* Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License. 
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor;

public class AdapterGen
{
    private static List<Type> m_AdapterList = new List<Type>();
    [MenuItem("CSHotFix/单步操作/生成适配器代码")]
    public static void CreateAdapter()
    {
        if (!EditorUtility.DisplayDialog("警告", "你是否需要重新生成热更新适配器信息？", "需要", "按错了"))
        {
            return;
        }
        m_AdapterList.Clear();
        List<Type> _types = new List<Type>();
        foreach (var assembly in GenConfigEditor.whiteUserAssemblyList)
        {
           _types.AddRange( Assembly.Load(assembly).GetTypes() );
        }
        m_AdapterList = _types.FindAll((_type) =>
        {
            string fullName = _type.FullName;
            return GenConfigPlugins.adapterGenList.Exists((_fullName) => { return _fullName == fullName; });
        });

        string dir = GenConfigEditor.CSHotFixAdapterGenPath;
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
        foreach (var cls in m_AdapterList)
        {
            GenAdapterFile(cls, dir);
        }

        //生成初始化文件
        GenAdapterRegisterFile(m_AdapterList, dir);

        UnityEngine.Debug.Log("CreateAdapter Ok");
        AssetDatabase.Refresh();
    }
    private static void GenAdapterRegisterFile(List<Type> _types , string dir)
    {
        string fileHeader = @"/*
* LCL support c# hotfix here.
*Copyright(C) LCL.All rights reserved
* URL:https://github.com/qq576067421/cshotfix
*QQ:576067421
* QQ Group: 673735733
* Licensed under the MIT License (the 'License'); you may not use this file except in compliance with the License. You may obtain a copy of the License at
* 
* Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an 'AS IS' BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/
using System;
using System.Collections;
using System.Collections.Generic;
using CSHotFix.CLR.Method;
using CSHotFix.Runtime.Enviorment;
using CSHotFix.Runtime.Intepreter;
public class AdapterRegister
    {
        public static void RegisterCrossBindingAdaptor(CSHotFix.Runtime.Enviorment.AppDomain domain)
        {";
        string lines = "\r\n";
        foreach(var t in _types)
        {
            string line = "domain.RegisterCrossBindingAdaptor(new "+ t.Name+ "Adapter());\r\n";
            lines += line;

        }
        string outputString = fileHeader + lines + "}\r\n}";

        FileStream file = null;
        StreamWriter sw = null;
        //有什么错误，就直接让系统去抛吧。
        file = new FileStream( dir + "AdapterRegister.cs", FileMode.Create);
        sw = new StreamWriter(file);
        sw.Write(outputString);
        sw.Flush();
        sw.Close();
        file.Close();
    }


    private static void GenAdapterFile(Type t, string dir)
    {
        string fileHeader = @"/*
* LCL support c# hotfix here.
*Copyright(C) LCL.All rights reserved
* URL:https://github.com/qq576067421/cshotfix
*QQ:576067421
* QQ Group: 673735733
* Licensed under the MIT License (the 'License'); you may not use this file except in compliance with the License. You may obtain a copy of the License at
* 
* Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an 'AS IS' BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/
using System;
using System.Collections;
using System.Collections.Generic;
using CSHotFix.CLR.Method;
using CSHotFix.Runtime.Enviorment;
using CSHotFix.Runtime.Intepreter;";

        string className = t.Name;
        string fullName = t.FullName;
        string publicNameStr = "public class "+ className + "Adapter:CrossBindingAdaptor\r\n" +
"{\r\n";
        string BaseCLRTypeStr = 
    "public override Type BaseCLRType\r\n"+
    "{\r\n" +
    "    get\r\n"+
    "    {\r\n" +
    "        return typeof("+ fullName + ");//这是你想继承的那个类\r\n" +
    "    }\r\n" +
    "}\r\n" +

    "public override Type AdaptorType\r\n" +
    "{\r\n" +
    "    get\r\n" +
    "    {\r\n" +
    "        return typeof(Adaptor);//这是实际的适配器类\r\n" +
    "    }\r\n" +
    "}\r\n" +

    "public override object CreateCLRInstance(CSHotFix.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)\r\n" +
    "{\r\n" +
    "    return new Adaptor(appdomain, instance);//创建一个新的实例\r\n" +
    "}\r\n" +

    "//实际的适配器类需要继承你想继承的那个类，并且实现CrossBindingAdaptorType接口\r\n" +
    "public class Adaptor : "+ fullName + ", CrossBindingAdaptorType\r\n" +
    "{\r\n" +
    "    ILTypeInstance instance;\r\n" +
    "    CSHotFix.Runtime.Enviorment.AppDomain appdomain;\r\n" +
    "    //缓存这个数组来避免调用时的GC Alloc\r\n" +
    "    object[] param1 = new object[1];\r\n" +

    "    public Adaptor()\r\n" +
    "    {\r\n" +
    "\r\n"+
    "    }\r\n" +

    "    public Adaptor(CSHotFix.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)\r\n" +
    "    {\r\n" +
    "        this.appdomain = appdomain;\r\n" +
    "        this.instance = instance;\r\n" +
    "    }\r\n" +

    "    public ILTypeInstance ILInstance { get { return instance; } }\r\n";
        //反射virtual的函数
        List<MethodInfo> methods = t.GetMethods().ToList().FindAll((_method) => 
        {
            return _method.IsPublic && _method.IsVirtual && _method.DeclaringType == t;
        });
        string methodsStr = "";
        foreach(var md in methods)
        {
            methodsStr += CreateOverrideMethod(md) + "\r\n";
        }
        string outputString = fileHeader + "\r\n"+ publicNameStr + BaseCLRTypeStr + methodsStr + "}\r\n}";
        FileStream file = null;
        StreamWriter sw = null;
        //有什么错误，就直接让系统去抛吧。
        file = new FileStream(dir + className+ "Adapter.cs", FileMode.Create);
        sw = new StreamWriter(file);
        sw.Write(outputString);
        sw.Flush();
        sw.Close();
        file.Close();


    }

    private static string CreateOverrideMethod(MethodInfo info)
    {
        string gotFieldStr = "m_b" + info.Name + "Got";
        string fieldStr = "m_" + info.Name;
        string returnTypeStr = "void";
        bool hasReturn = false;
        if(info.ReturnType.Name != "Void")
        {
            hasReturn = true;
            returnTypeStr = info.ReturnType.Name;
        }
        string paramsstr = "";
        int paramCount = 0;
        string paramarg = "null";
        if (info.GetParameters() != null)
        {

            paramCount = info.GetParameters().Length;
            if(paramCount >0)
            {
                paramarg = "";
            }
            int idx = 0;
            foreach (var _param in info.GetParameters())
            {
                string arg = "arg" + idx;
                paramarg += arg;
                paramsstr += _param.ParameterType.Name + " "+arg;
                if(idx++ < info.GetParameters().Length -1)
                {
                    paramsstr += ",";
                    paramarg += ",";
                }
            }
        }

        string callmethod = "       if(" + fieldStr + " != null)\r\n" +
                            "       {\r\n" +
                            "           " + (hasReturn ? "return (" + returnTypeStr + ")" : "") + " appdomain.Invoke(" + fieldStr + ", instance," + paramarg + ");\r\n " +
                            "       }\r\n" +
                            "       else\r\n" +
                            "       {\r\n" +
                            "           " + (hasReturn ? "return default("+ returnTypeStr + ");" : "") + "\r\n" +
                            "       }";
        string gotmethod = "bool " + gotFieldStr + " = false;\r\n" +
                    "IMethod " + fieldStr + " = null;\r\n" +
                    "public override " + returnTypeStr + " " + info.Name + " (" + paramsstr + ")\r\n" +
                    "{\r\n" +
                    "   if(!" + gotFieldStr + ")\r\n" +
                    "   {\r\n" +
                    "       " + fieldStr + " = instance.Type.GetMethod(\"" + info.Name + "\"," + paramCount + ");\r\n" +
                    "       " + gotFieldStr + " = true;\r\n" +
                    "   }\r\n" +
                    "   " + callmethod + " \r\n" +
                    "}";
        return gotmethod;

    }
}

