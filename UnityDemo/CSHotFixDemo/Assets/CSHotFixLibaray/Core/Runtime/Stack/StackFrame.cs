using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CSHotFix.CLR.Method;

namespace CSHotFix.Runtime.Stack
{
    public class IntegerReference
    {
        public int Value { get; set; }
    }
    public unsafe struct StackFrame
    {
        public ILMethod Method;
        public StackObject* LocalVarPointer;
        public StackObject* BasePointer;
        public StackObject* ValueTypeBasePointer;
        public IntegerReference Address;
        public int ManagedStackBase;
    }
}
