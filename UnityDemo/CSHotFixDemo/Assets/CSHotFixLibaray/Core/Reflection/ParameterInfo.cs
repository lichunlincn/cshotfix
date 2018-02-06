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

        public CSHotFixParameterInfo(IType type)
        {
            this.type = type;
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
