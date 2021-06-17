using System;
using System.Collections.Generic;
using System.Text;

namespace LCL
{
    //pc平台模拟
    public class LWindowsClass
    {
        public static string CallPlatform(string methodName, string strData)
        {
            if (methodName == "DiskSize")
            {
                return DiskSize();
            }
            return null;
        }

        private static string DiskSize()
        {
            //剩余200M
            long size = 1024 * 1024 * 500;
            return size.ToString();
        }
    }

}