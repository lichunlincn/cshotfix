using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LCL;

public class Ping
{
    private static List<long> m_PingTimes = new List<long>();
    private static int m_PingCount = 0;
    private static long m_LastPingTimeOfLoop = 0;
    private static long m_PingPastTime = 0;
    private static bool m_PingBack = false;
    private static long m_PingBackPastTime = 0;
    private static bool m_SendPing = false;

    //设置参数
    public static int m_PingInterval = 200;
    public static int m_PingIntervalOfLoop = 5000;
    public static int m_PingBackWaitTime = 10000;
    public static int m_PingTimesOfLoop = 6;
    public static System.Action<int> m_PingChangeCall = null;
    
    //结果参数
    public static bool m_bDrop = false;
    public static int m_PingValue = 100;

    private static bool m_OpenPing = true;
    public static void OpenPing()
    {
        m_OpenPing = true;
    }
    public static void ClosePing()
    {
        m_OpenPing = false;
    }
    public static bool IsOpenPing()
    {
        return m_OpenPing;
    }
    public static void ResetPing()
    {
        m_PingCount = 0;
        m_LastPingTimeOfLoop = 0;
        m_PingPastTime = 0;
        m_PingBack = false;
        m_PingBackPastTime = 0;
        m_SendPing = false;
        m_bDrop = false;

    }

    public static void OnPingBack(long t)
    {
        long curr = MonoTool.GetTimeStamp();
        long dt = (curr - t) / 2;
        if (m_PingCount <= m_LastPingTimeOfLoop)
        {
            if (m_PingCount < m_PingTimes.Count)
            {
                m_PingTimes[m_PingCount] = dt;
            }
            else
            {
                m_PingTimes.Add(dt);
            }
            m_PingCount++;
        }
        else
        {
            m_LastPingTimeOfLoop = curr;
            m_PingCount = 0;
            JiSuanPing();
            if (m_PingChangeCall != null)
            {
                m_PingChangeCall(m_PingValue);
            }
        }
        m_PingBack = true;
        m_bDrop = false;
        m_SendPing = false;
    }
    private static void JiSuanPing()
    {
        m_PingTimes.Sort();
        double dt = 0;
        for (int i = 1; i < m_PingTimes.Count - 1; ++i)
        {
            dt += (double)m_PingTimes[i];
        }
        double count = m_PingTimesOfLoop - 2;
        m_PingValue = Convert.ToInt32(dt / count);
    }

    public static void Update()
    {
        if (!m_OpenPing)
        {
            return;
        }
        float dt = UnityEngine.Time.deltaTime;
        long mmsec = (long)(dt * 1000);
        long curr = MonoTool.GetTimeStamp();
        if (m_SendPing)
        {
            if (!m_PingBack)
            {
                m_PingBackPastTime += mmsec;
                if (m_PingBackPastTime >= m_PingBackWaitTime)
                {
                    m_bDrop = true;
                }

                return;
            }
        }
        else
        {
            if (curr - m_LastPingTimeOfLoop > m_PingIntervalOfLoop)
            {
                if (m_PingPastTime >= m_PingInterval)
                {
                    MonoMessage.ReqHeart(curr);
                    m_PingPastTime = 0;
                    m_PingBack = false;
                    m_SendPing = true;
                    m_PingBackPastTime = 0;
                    m_bDrop = false;
                }
                else
                {
                    m_PingPastTime += mmsec;
                }
            }
        }
    }
}

