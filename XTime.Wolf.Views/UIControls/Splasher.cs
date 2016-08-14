using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace XTime.Wolf.Views
{
    public class Splasher
    {
        private static Form m_SplashView = null;
        private static ISplashView m_SplashInterface = null;
        private static Thread m_SplashThread = null;
        private static string m_TempStatus = string.Empty;

        public static void Close()
        {
            if (m_SplashThread != null && m_SplashView != null)
            {
                try
                {
                    m_SplashView.Invoke(new MethodInvoker(m_SplashView.Close));
                }
                catch (Exception e)
                {

                }
                m_SplashThread = null;
                m_SplashView = null;
            }
        }

        private static void CreateInstance(Type splashForm)
        {
            object instanceObj = splashForm.InvokeMember(null, System.Reflection.BindingFlags.CreateInstance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.DeclaredOnly, null, null, null);
            m_SplashView = instanceObj as Form;
            m_SplashInterface = instanceObj as ISplashView;
            if (m_SplashView == null)
            {
                throw new Exception("Splash Screen must inherit from System.Windows.Forms.Form");
            }
            if (m_SplashInterface == null)
            {
                throw new Exception("Must implement interface ISplashView.");
            }
            if (!string.IsNullOrEmpty(m_TempStatus))
            {
                m_SplashInterface.SetStatusInfo(m_TempStatus);
            }
        }

        public static void Show(Type splashFormType)
        {
            if (m_SplashThread == null)
            {
                if (splashFormType == null)
                {
                    throw new Exception("splashFormType is null.");
                }

                m_SplashThread = new Thread(delegate()
                {
                    CreateInstance(splashFormType);
                    Application.Run(m_SplashView);
                });

                m_SplashThread.IsBackground = true;
                m_SplashThread.SetApartmentState(ApartmentState.STA);
                m_SplashThread.Start();
            }
        }

        public static string Status
        {
            set
            {
                if (m_SplashInterface == null || m_SplashView == null)
                {
                    m_TempStatus = value;
                }
                else
                {
                    SplashStatusChangeHandle handle = (str) =>
                    {
                        m_SplashInterface.SetStatusInfo(str);
                    };
                    m_SplashView.Invoke(handle, new object[] { value });
                }
            }
        }

        private delegate void SplashStatusChangeHandle(string newStatusInfo);
    }
}
