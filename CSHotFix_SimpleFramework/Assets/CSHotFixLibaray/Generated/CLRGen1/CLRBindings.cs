
#if CSHotFix
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSHotFix.Runtime.Generated
{
    class CLRBindings
    {
        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
           
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE CSHotFix Appdomain destroy
        /// </summary>
        public static void Shutdown(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
        }
    }
}
#endif
