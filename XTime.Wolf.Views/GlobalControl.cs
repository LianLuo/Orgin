using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using XTime.Wolf.Commons;
using Microsoft.Win32;
using System.Net;
using XTime.Wolf.Model;

namespace XTime.Wolf.Views
{
    public class GlobalControl
    {
        #region filed
        private bool isRegisted = false;
        private DateTime firstRunTime = new DateTime(0x7E0, 3, 10, 0, 0, 0);
        private List<DateTime> timeList = new List<DateTime>();
        private bool isProxy;
        private CookieContainer cookier;
        private UserInfo userInfo;
        private AppConfig appConfig;
        #endregion

        #region property
        public MainView MainDialog;
        /// <summary>
        /// 是否已注册
        /// </summary>
        public bool IsRegister
        {
            get { return isRegisted; }
            set { isRegisted = value; }
        }

        /// <summary>
        /// 第一次运行的时间
        /// </summary>
        public DateTime FirstRunTime
        {
            get { return firstRunTime; }
            set { firstRunTime = value; }
        }

        /// <summary>
        /// 时间列表
        /// </summary>
        public List<DateTime> TimeList
        {
            get { return timeList; }
            set { timeList = value; }
        }

        /// <summary>
        /// 是否采用代理
        /// </summary>
        public bool IsProxy
        {
            get { return isProxy; }
            set { isProxy = value; }
        }

        /// <summary>
        /// Cookie
        /// </summary>
        public CookieContainer Cookie
        {
            get { return cookier; }
            set { cookier = value; }
        }

        public UserInfo UserInformation
        {
            get { return userInfo; }
            set { userInfo = value; }
        }

        public AppConfig AppConfig
        {
            get { return appConfig; }
            set { appConfig = value; }
        }

        /// <summary>
        /// 请求数据后，存储当前个人打卡数据,里面存放是json格式的数据
        /// </summary>
        public string CurrentData { get; set; }

        #endregion

        /// <summary>
        /// 退出
        /// </summary>
        public void Quit()
        {
            Application.Exit();
        }

        /// <summary>
        /// 软件说明
        /// </summary>
        public void About()
        {
            //
        }

        /// <summary>
        /// 功能描述：查看注册表中，该产品是否已经注册
        /// 创建日期：2016-06-29 
        /// 创建作者：luolian
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <returns></returns>
        public bool Register(string serialNumber)
        {
            return RegisterClass.ValidateCode(this.GetHardNumber(), serialNumber);
        }

        /// <summary>
        /// 获取16进制的字符串
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public string GetHexString(string source)
        {
            byte[] bytes = Encoding.Default.GetBytes(source);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("X2", CultureInfo.CurrentCulture));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 功能描述：获取硬件信息
        /// 创建日期：2016-06-28
        /// 创建作者：luolian
        /// </summary>
        /// <returns></returns>
        public string GetHardNumber()
        {
            return HardwareInfoHelper.GetCPUId() + this.GetHexString(HardwareInfoHelper.GetCPUName());
        }

        /// <summary>
        /// 功能描述：检测试用期是否已用完
        /// 创建时间：2016-06-29
        /// 创建作者：luolian
        /// </summary>
        /// <returns></returns>
        public bool CheckTimeString()
        {
            string[] stringArr = IsolatedStorageHelper.GetDataTime().Split(new char[]{',',';'});
            DateTime now = DateTime.Now;
            for (int i = 0; i < stringArr.Length; i++)
            {
                DateTime fileCurrentDate;
                try
                {
                    fileCurrentDate = Convert.ToDateTime(stringArr[i]);
                }
                catch
                {
                    fileCurrentDate = DateTime.Now.AddMinutes(-1);
                }

                if (i == 0)
                {
                    now = fileCurrentDate;
                    firstRunTime = now;
                }
                timeList.Add(fileCurrentDate);
            }

            DateTime currentTime = DateTime.Now;
            if (currentTime < now)
            {
                MessageUtil.ShowWarning("对不起，您在本软件使用期间修改了系统时间。\r\n若您想继续使用，请恢复系统时间。");
                LogTextHelper.WriteLine("用户尝试修改系统时间。");
                return false;
            }
            IsolatedStorageHelper.SaveDataTime();
            if (isRegisted)
            {
                TimeSpan span = new TimeSpan(currentTime.Ticks - now.Ticks);
                if (span.Days > UIConstants.SoftwareProbationDay)
                {
                    MessageUtil.ShowYesNoAndTips("您使用的软件已过期，如果还想继续使用软件，请联系我们。");
                    LogTextHelper.WriteLine("软件已过期。");
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 功能描述：检查是否注册
        /// 创建日期：2016-06-29
        /// 创建作者：luolian
        /// </summary>
        /// <returns></returns>
        public bool CheckRegistered()
        {
            string serialNumber = string.Empty;
            RegistryKey key = Registry.CurrentUser.OpenSubKey(UIConstants.SoftwareRegistryKey, true);
            if (!ReferenceEquals(null, key))
            {
                serialNumber = key.GetValue("SerialNumber").ToString();
                isRegisted = this.Register(serialNumber);
            }
            return isRegisted;
        }
    }
}
