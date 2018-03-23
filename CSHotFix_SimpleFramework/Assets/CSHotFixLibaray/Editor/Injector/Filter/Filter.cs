using Editor_Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LCL
{

    public static class Filter
    {
        public static List<string> NeedInjects = new List<string>();
        public static InjectFlagEnum GetHotFixAttrValve(object attr)
        {
            BindingFlags flag = BindingFlags.Instance | BindingFlags.Public;
            Type type = attr.GetType();
            PropertyInfo field = type.GetProperty("InjectFlag", flag);
            if(field!= null)
            {
                return (InjectFlagEnum)(int)field.GetValue(attr, null);
            }
            else
            {
                return InjectFlagEnum.Inject;
            }

        }
        public static bool FilterType(Type t)
        {
            if(t.Namespace==null)
            {
                return true;
            }
            if(!t.Namespace.Contains("LCL") && !t.Namespace.Contains("GameDll"))
            {
                return true;
            }
            var cas = t.GetCustomAttributes(false);
            if(cas == null)
            {
                return false;
            }
            else
            {
                foreach(var attr in cas)
                {
                    if(GetHotFixAttrValve(attr) == InjectFlagEnum.NoInject)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        public static bool FilterType(TypeDefinition t)
        {
            if(t.Namespace==null)
            {
                return true;
            }
            if(!t.Namespace.Contains("LCL") && !t.Namespace.Contains("GameDll"))
            {
                return true;
            }
            var cas = t.CustomAttributes;
            if(cas == null)
            {
                return false;
            }
            else
            {
                foreach(var attr in cas)
                {
                    if(GetHotFixAttrValve(attr) == InjectFlagEnum.NoInject)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool FilterMethod(MethodDefinition m)
        {
            foreach(var str in NeedInjects)
            {
                string mstr = GetMethodFullName(m);
                if(str == mstr)
                {
                    return true;
                }
            }
            return false;
        }
        public static string GetMethodFullName(MethodInfo methodinfo)
        {
            string returnstr = DelegateGen.GetTypeName(methodinfo.ReturnType);
            string name = methodinfo.DeclaringType.FullName+"::"+methodinfo.Name;
            string paramstr = "";
            int count = methodinfo.GetParameters().Length;
            int index = 1;

            foreach(var param in methodinfo.GetParameters())
            {
                string split = index++ == count ? "" : ",";
                paramstr += DelegateGen.GetTypeName(param.ParameterType)  + split;
            }
            return returnstr + " " + name + "(" + paramstr + ")";           
        }
        public static string GetMethodFullName(MethodDefinition methodinfo)
        {
            string returnstr = GetCecilParamTypeName(methodinfo.ReturnType);
            string name = methodinfo.DeclaringType.FullName+"::"+methodinfo.Name;
            string paramstr = "";
            int count = methodinfo.Parameters.Count;
            int index = 1;

            foreach(var param in methodinfo.Parameters)
            {
                string split = index++ == count ? "" : ",";
                paramstr += GetCecilParamTypeName(param.ParameterType) + split;
            }
            return returnstr + " " + name + "(" + paramstr + ")";       
        }
        private static string GetCecilParamTypeName(TypeReference t)
        {
            string hr = t.FullName.Replace("`1", "").Replace("`2","").Replace("0...","").Replace(",",", ");
            return hr;
        }
        public static bool FilterMethod(MethodInfo m)
        {
            if(m == null)
            {
                UnityEngine.Debug.LogError("Error: method is null");
                return false;
            }
            var attrs = m.GetCustomAttributes(false);
            foreach (var attr in attrs)
            {
                if (GetHotFixAttrValve(attr) == InjectFlagEnum.NoInject)
                {
                    return false;
                }
            }
            if(m.IsGenericMethod)
            {
                UnityEngine.Debug.LogError("warning:" + m.DeclaringType.FullName+":" + m.Name + " is a generic method");
                return false;
            }
            foreach(var param in m.GetParameters())
            {
                if( param.IsOut)
                {
                    UnityEngine.Debug.LogError("warning:" + m.DeclaringType.FullName+":" + m.Name + " has out param method");
                    return false;
                }
                if(param.ParameterType.IsByRef)
                {
                    UnityEngine.Debug.LogError("warning:" + m.DeclaringType.FullName+":" + m.Name + " has out param method");
                    return false;
                }
            }

            var paramters = m.GetParameters();
            if (paramters != null)
            {
                //这里需要留意的是参数个数还要包括这个类他自己的实例
                const int maxCount = 5;
                if (m.ReturnParameter.Name.Contains("Void"))
                {
                    //action
                    if (1 + paramters.Length > maxCount)
                    {
                        UnityEngine.Debug.LogError("no return method param more than " + maxCount + " " + m.DeclaringType.FullName + " " + m.Name + "count:" + paramters.Length);
                        return false;
                    }
                }
                else
                {
                    //func
                    if (1 + paramters.Length > maxCount)
                    {
                        UnityEngine.Debug.LogError("has return method param more than " + maxCount + " " + m.DeclaringType.FullName + " " + m.Name + "count:" + paramters.Length);
                        return false;
                    }
                }


            }
            return true;
        }
    }
}
