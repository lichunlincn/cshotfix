using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LCL
{

    public class Filter
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
            var cas = t.GetCustomAttributes(false);
            if(cas == null)
            {
                return true;
            }
            else
            {
                foreach(var attr in cas)
                {
                    if(GetHotFixAttrValve(attr) == InjectFlagEnum.NoInject)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        public static bool FilterType(TypeDefinition t)
        {
            if (NeedInjects.Exists((str) =>
            {
                return str == t.FullName;
            }))
            {
                return true;
            }
            return false;
        }
        public static bool FilterMethod(MethodDefinition m)
        {
            if (NeedInjects.Exists((str) =>
            {
                return str == m.FullName;
            }))
            {
                return true;
            }
            return false;
        }
        public static bool FilterMethod(MethodInfo m)
        {
            if(m == null)
            {
                Console.WriteLine("Error: method is null");
                return false;
            }
            if(m.IsGenericMethod)
            {
                Console.WriteLine("warning:" + m.Name + " is a generic method");
                return false;
            }
            foreach(var param in m.GetParameters())
            {
                if( param.IsOut)
                {
                    Console.WriteLine("warning:" + m.Name + " has out param method");
                    return false;
                }
                if(param.ParameterType.IsByRef)
                {
                    Console.WriteLine("warning:" + m.Name + " has out param method");
                    return false;
                }
            }
            var attrs = m.GetCustomAttributes(false);
            foreach (var attr in attrs)
            {
                if (GetHotFixAttrValve(attr) == InjectFlagEnum.NoInject)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
