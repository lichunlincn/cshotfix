using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LCL
{
    //默认只要在LCL命名空间下面的所有类都会被注入
    [CSHotFix(InjectFlag = InjectFlagEnum.NoInject)]
    public class MainTest2
    {

        // Use this for initialization
        void Start()
        {
        }
        void Test0()
        {
            Debug.Log("Unit:void Test0()");
        }
        void Test1(int a)
        {
            Debug.Log("Unit:void Test1(int a)");
        }

        public void Test2(int a, float b)
        {
            Debug.Log("Unit:public void Test2(int a, float b)");
            Debug.LogError("我是一个错误");
        }

        //暂时不支持4个以上的参数，这个取决于ILRT那边
        //很遗憾由于ilrt那边暂时不支持ref 和 out，我们先放弃这个
        //你可以采用test4的方式来实现
        //public float[] test3(ref int b, out float c)
        //{
        //    c = 0;
        //    Debug.LogError("我是一个错误");
        //    return new float[] { 1 };
        //}

        public DataClass test4(DataClass data)
        {
            return data;
        }
        private int m_ImPrivateFieldA = 0;
        private int m_ImPrivateFieldB = 1;
        private int ImPrivateFunction(int a, int b)
        {
            return a + b;
        }

        //不支持泛型，所以当你需要写一个泛型的时候请尤为需要注意不要出错。
        //注入工具那边默认不会处理泛型的
        [CSHotFix(InjectFlag = InjectFlagEnum.NoInject)]
        public T TestGenericTypeFunc<T>(T a)
        {
            return default(T);
        }


    }
}