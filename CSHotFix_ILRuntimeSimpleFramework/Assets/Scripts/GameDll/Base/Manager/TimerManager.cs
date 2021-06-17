using System;
using System.Collections.Generic;
using System.Text;

namespace GameDll
{
    public class Timer : PooledClassObject
    {
        private static long m_IdAll = 0;
        private long id;
        public System.Action<int> perCall;
        public System.Action finishCall;
        public int intervalMMSeconds = 1000; //毫秒
        public int totalMMSeconds = 1;
        //内部变量
        public int currTick;
        public int IntervalPastTime;
        public object userData;
        public static Timer CreateClass()
        {
            return PooledClassManager<Timer>.CreateClass();
        }
        public override void New(object param)
        {
            id = ++m_IdAll;
            perCall = null;
            finishCall = null;
            intervalMMSeconds = 1000; //毫秒
            totalMMSeconds = 1;
            currTick = 0;
            IntervalPastTime = 0;
            userData = null;
        }
        public override void Delete()
        {

        }
        public override void DestroyClass()
        {
            PooledClassManager<Timer>.DeleteClass(this);
        }
        public long GetId()
        {
            return id;
        }
    }
    public class TimerManager
    {

        List<Timer> m_TimerList = new List<Timer>();
        public  void Update()
        {
            int count = m_TimerList.Count;
            int dtmmseconds = (int)(UnityEngine.Time.deltaTime * 1000);
            for (int i = count -1; i >=0; --i)
            {
                Timer t = m_TimerList[i];
                t.IntervalPastTime += dtmmseconds;

                int t_total_left_count = t.totalMMSeconds - t.currTick * 1000;
                if (t_total_left_count <= 0)
                {
                    if (t.finishCall != null)
                    {
                        t.finishCall();
                    }
                    m_TimerList.Remove(t);
                    t = null;
                }
                else
                {
                    for (int n = 0; n < t_total_left_count; ++n)
                    {
                        if (t.IntervalPastTime < t.intervalMMSeconds)
                        {
                            break;
                        }
                        t.IntervalPastTime -= t.intervalMMSeconds;
                        t.currTick++;
                        if (t.perCall != null)
                        {
                            t.perCall(t.intervalMMSeconds * t.currTick);
                        }
                    }
                }

            }
        }

        /// <summary>
        /// 添加计时器,添加的计时器将会在下一个循环开始计时，没有立即执行一次的说法。
        /// </summary>
        /// <param index="delay">延迟多久开始计算第一次</param>
        /// <param index="interval">间隔</param>
        /// <param index="length">总长度</param>
        /// <param index="perCall">每次间隔回调函数，输入参数是当前计时器的时间</param>
        /// <param index="finishCall">完成计时回调</param>
        /// <returns></returns>
        public void AddTimer(Timer param)
        {
            if(param.intervalMMSeconds == 0)
            {
                UnityEngine.Debug.LogError("谁加的timer的间隔时间是0呢？");
                return;
            }
            m_TimerList.Add(param);
        }
        public Timer GetTimer(long id)
        {
            int count = m_TimerList.Count;
            for (int i = 0; i < count; ++i)
            {
                Timer t = m_TimerList[i];
                if (t.GetId() == id)
                {
                    return t;
                }
            }
            return null;
        }
        public void RemoveTimer(long id)
        {
            Timer t = GetTimer(id);
            if (t != null)
            {
                m_TimerList.Remove(t);
                t = null;
            }
        }

        public static void StaticRemoveTimer(long id)
        {
            CGameProcedure.s_TimerManager.RemoveTimer(id);
        }
        public static void StaticAddTimer(Timer t)
        {
            CGameProcedure.s_TimerManager.AddTimer(t);
        }
        public void Destroy()
        {
            m_TimerList.Clear();
            UnityEngine.Debug.Log("TimerManager Destroy");
        }
    }
}
