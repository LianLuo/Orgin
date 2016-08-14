using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XTime.Wolf.Commons
{
    public class UIConstants
    {
        /// <summary>
        /// 过期时间
        /// </summary>
        public static string ApplicationExpiredDate = "12/29/2009";
        /// <summary>
        /// 版本号
        /// </summary>
        public static string SoftwareVersion = "1.0";
        /// <summary>
        /// 产品名称
        /// </summary>
        public static string SoftwareProductName = "XTime.Wolf";
        /// <summary>
        /// 注册表
        /// </summary>
        public static string SoftwareRegistryKey = "SOFTWARE\\Microsoft\\XTime\\" + SoftwareVersion;
        /// <summary>
        /// 试用天数
        /// </summary>
        public static int SoftwareProbationDay = 20;

        public static string IsolatedStorage = System.IO.Path.Combine(Environment.UserName,"XTime.bin");
        public static string IsolatedStorageDirectoryName = Environment.UserName;
        public static string IsolatedStorageEncryptKey = "12345678";
        /// <summary>
        /// 公钥
        /// </summary>
        public static string PublicKey = @"<RSAKeyValue><Modulus>ngqL1JTIW6OLkIipwMdrtG0mvqosJCmYHtWZttKS7d0hRh2O3wQfdqY5yuYAoKOjlzZFSNDPT1iWzOEBeKcuRXUT3COuKHTAnOCytNJSvYjFCLZJOiyek5JuP9SOzAQ3/81EIkrXs9UyFvXk8ddB49/FKPPUWa0wVUs7sy/Aeek=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

        public static string WebRegisterURL = "172586418@qq.com";

        /// <summary>
        /// 设置过期时间，版本号，产品名称，公钥
        /// </summary>
        /// <param name="expiredDate">过期时间</param>
        /// <param name="version">版本号</param>
        /// <param name="name">产品名称</param>
        /// <param name="publicKey">公钥</param>
        public static void SetValue(string expiredDate, string version, string name, string publicKey)
        {
            UIConstants.ApplicationExpiredDate = expiredDate;
            UIConstants.SoftwareVersion = version;
            UIConstants.SoftwareProductName = name;
            UIConstants.SoftwareRegistryKey = "SOFTWARE\\Microsoft\\" + name + "\\" + version;
            UIConstants.IsolatedStorage = string.Format("{0}\\{1}.bin", Environment.UserName, name);
            UIConstants.PublicKey = publicKey;
        }
    }
}
