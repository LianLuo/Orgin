using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using XTime.Wolf.Commons;
using System.Diagnostics;
using XTime.Wolf.Views.UIControls;

namespace XTime.Wolf.Views
{
    static class Program
    {
        public static GlobalControl gc = new GlobalControl
        {
            Cookie = new System.Net.CookieContainer(),//初始化Cookie
            AppConfig = new AppConfig()
        };
        private static Mutex m_Mutex;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetUIContants();
            GlobalMutex();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;
            try
            {
                var login = new LoginView();
                if (login.ShowDialog() == DialogResult.OK && login.IsLogin)
                {
                    Splasher.Show(typeof(SplashScreen));
                    gc.MainDialog = new MainView();
                    Application.Run(gc.MainDialog);
                }
            }
            catch (Exception e)
            {
                LogTextHelper.WriteLine(e.StackTrace);
            }            
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            LogTextHelper.WriteLine(e.Exception.ToString());
            string msg = string.Format("{0}\r\n操作发生异常，您需要退出么?",e.Exception.Message);
            if (MessageUtil.ShowYesNoAndError(msg) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// 检测是否已有程序在运行
        /// </summary>
        private static void GlobalMutex()
        {
            bool createNew = false;
            string applicationName = @"Global\XTime";
            try
            {
                m_Mutex = new Mutex(false, applicationName, out createNew);
            }
            catch (AbandonedMutexException e)
            {
                Console.WriteLine(e.Message);
            }

            if (createNew)
            {
                Console.WriteLine("This app was running.");
                LogTextHelper.WriteLine("程序已启动.");
            }
            else
            {
                MessageUtil.ShowYesNoAndTips("另外一个窗体已经在运行，不能重复运行。");

                Thread.Sleep(0x3E8);
                Environment.Exit(1);
            }
        }

        /// <summary>
        /// 设置
        /// </summary>
        private static void SetUIContants()
        {
            string expireDate = "12/29/2010";
            string projectName = "XTime";
            string version = "1.0";
            string publicKey = "<RSAKeyValue><Modulus>ngqL1JTIW6OLkIipwMdrtG0mvqosJCmYHtWZttKS7d0hRh2O3wQfdqY5yuYAoKOjlzZFSNDPT1iWzOEBeKcuRXUT3COuKHTAnOCytNJSvYjFCLZJOiyek5JuP9SOzAQ3/81EIkrXs9UyFvXk8ddB49/FKPPUWa0wVUs7sy/Aeek=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
            UIConstants.SetValue(expireDate, version, projectName, publicKey);
        }
    }
}
