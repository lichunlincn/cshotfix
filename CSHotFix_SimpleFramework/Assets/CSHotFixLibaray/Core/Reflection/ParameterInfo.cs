using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Globalization;

using CSHotFix.CLR.TypeSystem;

namespace CSHotFix.Reflection
{
    public class CSHotFixParameterInfo : ParameterInfo
    {
        IType type;
        MethodBase method;
        Mono.Cecil.ParameterDefinition definition;

        public CSHotFixParameterInfo(Mono.Cecil.ParameterDefinition definition, IType type, MethodBase method)
        {
            this.type = type;
            this.method = method;
            this.MemberImpl = method;
            this.definition = definition;
            NameImpl = definition.Name;
        }
        public override Type ParameterType
        {
            get
            {
                return type.ReflectionType;
            }
        }
    }
}
