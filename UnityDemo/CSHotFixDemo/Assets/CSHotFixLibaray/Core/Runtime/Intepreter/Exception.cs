using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CSHotFix.Runtime.Stack;

namespace CSHotFix.Runtime.Intepreter
{
    public class CSHotFixException : Exception
    {
        string stackTrace;
        string thisInfo, localInfo;
        internal CSHotFixException(string message, ILIntepreter intepreter, CLR.Method.ILMethod method, Exception innerException = null)
            : base(message, innerException)
        
        {
            if (innerException is CSHotFixException)
            {
                CSHotFixException e = innerException as CSHotFixException;
                stackTrace = e.stackTrace;
                thisInfo = e.thisInfo;
                localInfo = e.localInfo;
            }
            else
            {
                thisInfo = "";
            }
        }

        public override string StackTrace
        {
            get
            {
                return stackTrace;
            }
        }

        public string ThisInfo
        {
            get { return thisInfo; }
        }

        public string LocalInfo
        {
            get
            {
                return localInfo;
            }
        }

        public override string ToString()
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine(Message);
            if (!string.IsNullOrEmpty(ThisInfo))
            {
                message.AppendLine("this:");
                message.AppendLine(ThisInfo);
            }
            message.AppendLine("Local Variables:");
            message.AppendLine(LocalInfo);
            message.AppendLine(StackTrace);
            if (InnerException != null)
                message.AppendLine(InnerException.ToString());
            return message.ToString();
        }
    }
}
