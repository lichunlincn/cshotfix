using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LCL
{
    public class MainTest
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
        //public static float[] test3(ref int b, out float c)
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
    }
}