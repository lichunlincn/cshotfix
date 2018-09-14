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
using System.Reflection;
using System.Text;
using CSHotFix.Runtime;
using Editor_Mono.Cecil;

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
        }

        bool FilterMethod(MethodInfoSource mis, List<MethodInfoSource> dealMethod)
        {
            //判断方法的委托信息是否已经添加
            foreach(var mi in dealMethod)
            {
                if(mi.source == mis.source && IsSameMethodDelegate(mis.mothodInfo, mi.mothodInfo))
                {
                    return true;
                }
            }
            return false;
        }
        private enum MethodInfoSourceEnum
        {
            InjectMethod,
            Delegate

        }
        private class MethodInfoSource
        {
            public string name;
            public MethodInfo mothodInfo;
            public MethodInfoSourceEnum source;
        }
        private List<LMethodInfo> LoadAssembly(string assemblyName)
        {
            List<LMethodInfo> funcLines = new List<LMethodInfo>();

            m_Assembly = Assembly.LoadFile(assemblyName);
            var types = m_Assembly.GetTypes();

            Filter.NeedInjects.Clear();
            //从所有类和参数中寻找需要处理的方法
            List<MethodInfoSource> methodList = new List<MethodInfoSource>();
            ParseTypes(null, types, methodList);
            List<MethodInfoSource> dealmethod = new List<MethodInfoSource>();
            foreach (var methodinfoSource in methodList)
            {
                var methodinfo = methodinfoSource.mothodInfo;
                if (!FilterMethod(methodinfoSource, dealmethod))
                {
                    //添加委托信息
                    LMethodInfo info = new LMethodInfo();
                    var returnparamter = methodinfo.ReturnParameter;
                    info.m_ReturnString = GetTypeName(returnparamter.ParameterType);
                    if (info.m_ReturnString.Contains("Void"))
                    {
                        info.m_ReturnString = "void";
                    }

                    var paramters = methodinfo.GetParameters();
                    if (paramters != null)
                    {
                        //为每一个普通的方法添加this的object，这个方法一般是需要注入的方法
                        if (methodinfoSource.source == MethodInfoSourceEnum.InjectMethod)
                        {
                            info.m_Params.Add(new ParamData() { m_ParamString = "System.Object", m_RefOut = RefOutArrayEnum.None });
                        }
                        foreach (var pi in paramters)
                        {
                            ParamData paramdata = new ParamData();
                            if (pi.ParameterType.IsArray)
                            {
                                paramdata.m_RefOut = RefOutArrayEnum.Array;
                            }
                        
                            paramdata.m_ParamString = GetTypeName(pi.ParameterType);
                            info.m_Params.Add(paramdata);
                        }
                    }
                    if(methodinfoSource.source == MethodInfoSourceEnum.Delegate)
                    {
                        //若果是一个委托，那么就不用再次为他生成一个委托类了，避免使用的委托类和定义的不是同一个
                        info.m_DelegateName = methodinfoSource.mothodInfo.DeclaringType.FullName;
                        if (info.m_DelegateName == "EventDelegate+Callback")
                        {
                            continue;
                        }
                    }
                    funcLines.Add(info);
                    dealmethod.Add(methodinfoSource);
                }
                if (methodinfoSource.source == MethodInfoSourceEnum.InjectMethod)
                {
                    string methodfullname = Filter.GetMethodFullName(methodinfo);
                    Filter.NeedInjects.Add(methodfullname);
                }
            }


            return funcLines;
        }
        private void ParseTypes(Type declareType,Type[] types, List<MethodInfoSource> list, bool isDelegate = false)
        {
            foreach (var type in types)
            {
                MethodInfoSourceEnum source = MethodInfoSourceEnum.InjectMethod;
                if (!isDelegate)
                {
                    if (Filter.DelegateTypeFilter(type))
                    {
                        continue;
                    }
                    if (type.Name.Contains("LCLFunctionDelegate") ||
                        type.Name.Contains("LCLRegisterFunctionDelegate"))
                    {
                        continue;
                    }
                    if (type.DeclaringType != null && (
                            type.DeclaringType.Name.Contains("LCLFunctionDelegate") ||
                            type.DeclaringType.Name.Contains("LCLRegisterFunctionDelegate")
                        ))
                    {
                        continue;
                    }
            
                }
                //方法
                var TotalMethodInfos = new List<MethodInfo>();
                if (type.BaseType == typeof(MulticastDelegate) || type.BaseType == typeof(Delegate))
                {
                    source = MethodInfoSourceEnum.Delegate;
                    if (type.FullName.Contains("Predicate`"))
                    {
                        string declareName = declareType == null ? type.FullName : declareType.FullName + "里面的" + type.FullName;
                        UnityEngine.Debug.LogError("脚本引擎好像是不支持Predicate的，请检查相关函数是否有导出到热更新里面使用：" + declareName);
                    }


                    //将委托中的Invoke进行转化，其他函数忽略
                    TotalMethodInfos.AddRange(type.GetMethods().ToList().FindAll(
                    (_m) =>
                    {
                        return _m.Name == "Invoke";
                    }));
                }
                else
                {
                    //字段中含有的委托
                    List<Type> fieldTypes = new List<Type>();
                    var fieldMethods = type.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetField | BindingFlags.DeclaredOnly);
                    foreach (var field in fieldMethods)
                    {
                        Type fieldType = field.FieldType;
                        if (fieldType.BaseType == typeof(MulticastDelegate) || fieldType.BaseType == typeof(Delegate))
                        {
                            fieldTypes.Add(fieldType);
                        }
                    }
                    ParseTypes(type, fieldTypes.ToArray(), list, true);

                    //属性中含有委托
                    List<Type> propertyTypes = new List<Type>();
                    var propertyMethods = type.GetProperties(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.DeclaredOnly);
                    foreach (var property in propertyMethods)
                    {
                        Type propertyType = property.PropertyType;
                        if (propertyType.BaseType == typeof(MulticastDelegate) || propertyType.BaseType == typeof(Delegate))
                        {
                            fieldTypes.Add(propertyType);
                        }
                    }
                    ParseTypes(type, propertyTypes.ToArray(), list, true);

                    //普通方法
                    var methodInfos = type.GetMethods(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                    TotalMethodInfos.AddRange(methodInfos);
                }

                foreach (var methodinfo in TotalMethodInfos)
                {
                    if(CheckMethod(methodinfo, list))
                    {
                        MethodInfoSource mis = new MethodInfoSource();
                        mis.mothodInfo = methodinfo;
                        mis.source = source;
                        list.Add(mis);
                    }
                }
            }
        }

        private bool CheckMethod(MethodInfo methodinfo, List<MethodInfoSource> list)
        {
            if(!Filter.FilterMethod(methodinfo))
            {
                return false;
            }
            var paramters = methodinfo.GetParameters();
            if (paramters != null)
            {
                foreach (var pi in paramters)
                {
                    if (pi.IsOut)
                    {
                        //暂时不支持out
                        UnityEngine.Debug.LogError("function has out param:" + methodinfo.DeclaringType.FullName + ":" + methodinfo.Name);
                        return false;
                    }
                    else if (pi.ParameterType.IsByRef)
                    {
                        //暂时不支持ref
                        UnityEngine.Debug.LogError("function has ref param:" + methodinfo.DeclaringType.FullName + ":" + methodinfo.Name);
                        return false;
                    }
                    if(pi.ParameterType.BaseType == typeof(MulticastDelegate) || pi.ParameterType.BaseType == typeof(Delegate))
                    {
                        var _delegateMethod = pi.ParameterType.GetMethods().ToList().Find((_method) => _method.Name == "Invoke");
                        if( CheckMethod(_delegateMethod, list))
                        {
                            MethodInfoSource mis = new MethodInfoSource();
                            mis.mothodInfo = _delegateMethod;
                            mis.source =  MethodInfoSourceEnum.Delegate;
                            mis.name = methodinfo.Name+"_param_delegate";
                            list.Add(mis);
                        }
                    }
                }
            }
            return true;
        }
        private bool IsSameMethodDelegate(MethodInfo a, MethodInfo b)
        {
            var ra = a.ReturnType;
            var rb = b.ReturnType;
            if(ra != rb)
            {
                return false;
            }

            var pa = a.GetParameters();
            var pb = b.GetParameters();
            if(pa == pb)
            {
                // == null
                return true;
            }
            else
            {
                if(pa.Length != pb.Length)
                {
                    return false;
                }    
                else
                {
                    for(int i=0;i<pa.Length;++i)
                    {
                        var ppa = pa[i];
                        var ppb = pb[i];
                        if(ppa.ParameterType  != ppb.ParameterType)
                        {
                            return false;
                        }
                    }    
                }
            }
            return true;
        }
        public static string GetTypeName(Type t)
        {
            string param_str = "";
            string tmp = "";
            bool isRef = false;
            t.GetClassName(out tmp, out param_str, out isRef);
            return param_str;
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