using System;
using System.Diagnostics;

namespace ConsoleClient
{
    public class StatisticTime :IDisposable
    {
        private Stopwatch m_Watch;

        public StatisticTime()
        {
            m_Watch = new Stopwatch();
            m_Watch.Start();
        }

        public long Time
        {
            get
            {
                m_Watch.Stop();
                m_Watch.Start();
                return m_Watch.ElapsedMilliseconds;
            }
        }
        
        public void Reset()
        {
            m_Watch.Reset();
        }
        
        public void Dispose()
        {
            if (null != m_Watch)
            {
                m_Watch.Stop();
                m_Watch = null;
            }
        }
    }
}