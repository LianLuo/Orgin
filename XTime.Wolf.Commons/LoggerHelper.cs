using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace XTime.Wolf.Commons
{
    public class LoggerHelper:IDisposable
    {
        #region field
        // 日志文件
        private string m_LogFile;
        private static StreamWriter m_Writer;
        // 是否输出日志
        private string m_LogIsWrite = "true";
        #endregion

        #region construct
        public LoggerHelper()
        {

        }

        public LoggerHelper(string fileName)
        {

        }
        #endregion

        /// <summary>
        /// 创建日志文件
        /// </summary>
        /// <param name="fileName"></param>
        private void CreateLoggerFile(string fileName)
        {
            if (!this.m_LogIsWrite.ToLower().Equals("true"))
            {
                return;
            }
            if (string.IsNullOrEmpty(fileName))
            {
                fileName = DateTimeHelper.GetToday();
            }
            object myLogPath = null;
            if (ReferenceEquals(null, myLogPath))
            {
                this.m_LogFile = @"Log";
                if (File.Exists(this.m_LogFile))
                {
                    Directory.CreateDirectory(this.m_LogFile);
                }
            }
            else
            {
                this.m_LogFile = myLogPath.ToString();
            }

            if (this.m_LogFile.Length < 1)
            {
                Console.WriteLine("配置文件中没有指定文件目录");
            }
            else
            {
                if (!Directory.Exists(this.m_LogFile))
                {
                    Console.WriteLine("配置文件中指定日志文件目录不存在");
                }
                else
                {
                    this.m_LogFile = Path.Combine(m_LogFile, fileName + ".log");
                }
                try
                {
                    FileStream file = new FileStream(m_LogFile, FileMode.OpenOrCreate);
                    file.Close();
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// 打开文件
        /// </summary>
        private void FileOpen()
        {
            LoggerHelper.m_Writer = new StreamWriter(m_LogFile, true);
        }

        /// <summary>
        /// 输出日志
        /// </summary>
        /// <param name="msg"></param>
        private void WriteInfos(string msg)
        {
            try
            {
                this.FileOpen();
                string info = string.Format("[{0}]\t{1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), msg);
                LoggerHelper.m_Writer.WriteLine(info);
                LoggerHelper.m_Writer.Flush();
                LoggerHelper.m_Writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// 关闭文件
        /// </summary>
        private void FileClose()
        {
            if (!ReferenceEquals(null, LoggerHelper.m_Writer))
            {
                LoggerHelper.m_Writer.Flush();
                LoggerHelper.m_Writer.Close();
                LoggerHelper.m_Writer.Dispose();
                LoggerHelper.m_Writer = null;
            }
        }

        /// <summary>
        /// 输出日志
        /// </summary>
        /// <param name="msg"></param>
        public void WriteLog(string msg)
        {
            if (!ReferenceEquals(null, msg))
            {
                this.WriteInfos(msg);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
