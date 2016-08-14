using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using System.Reflection;
using System.IO;

namespace XTime.Wolf.Commons
{
    /// <summary>
    /// Log4Net日志记录辅助类
    /// </summary>
    public class LogHelper
    {
        private static readonly ILog m_log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static void Debug(object ex)
        {
            m_log.Debug(ex);
        }

        public static void Warn(object ex)
        {
            m_log.Warn(ex);
        }

        public static void Error(object ex)
        {
            m_log.Error(ex);
        }

        public static void Info(object ex)
        {
            m_log.Info(ex);
        }

        public static void Debug(object message, Exception e)
        {
            m_log.Debug(message, e);
        }

        public static void Warn(object message, Exception e)
        {
            m_log.Warn(message, e);
        }

        public static void Error(object message, Exception e)
        {
            m_log.Error(message, e);
        }

        public static void Info(object message, Exception e)
        {
            m_log.Info(message, e);
        }
    }

    public class LogTextHelper
    {
        static string LogFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
        static bool m_IsRecordLog = true;
        static bool m_IsDebugLog = false;

        static LogTextHelper()
        {
            if (!Directory.Exists(LogFolder))
            {
                Directory.CreateDirectory(LogFolder);
            }
        }

        public static void WriteLine(string message)
        {
            string temp = DateTime.Now.ToString("[yyyy-MM-dd HH:ss:mm]  ") + message + "\r\n";
            string fileName = DateTime.Now.ToString("yyyyMMdd") + ".log";
            try
            {
                if (m_IsRecordLog)
                {
                    File.AppendAllText(Path.Combine(LogFolder, fileName), temp, Encoding.GetEncoding("UTF-8"));
                }
                if (m_IsDebugLog)
                {
                    Console.WriteLine(temp);
                }
            }
            catch
            {

            }
        }

        public static void WriteLine(string className, string funName, string message)
        {
            WriteLine(string.Format("{0}：{1}\r\n{2}", className, funName, message));
        }
        
    }
}
