using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LCL
{
    public class TestDelegateData
    {
        public int m_Field = 0;
    }
    //自动化处理委托绑定
    public class TestDelegate
    {
        public delegate int TestExportDelegate(TestDelegateData a, int b, long c);
    }
}
