using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CSHotFix.CLR.TypeSystem;

namespace CSHotFix.CLR.Method
{
    public enum ExceptionHandlerType
    {
        Catch,
        Finally,
        Fault,
    }
    public class ExceptionHandler
    {
        public ExceptionHandlerType HandlerType { get; set; }

        public int TryStart { get; set; }
        public int TryEnd { get; set; }
        public int HandlerStart { get; set; }
        public int HandlerEnd { get; set; }
        public IType CatchType { get; set; }
    }
}
