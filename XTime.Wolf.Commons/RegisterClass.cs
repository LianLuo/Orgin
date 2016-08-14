using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace XTime.Wolf.Commons
{
    public class RegisterClass
    {
        /// <summary>
        /// 功能描述：创建注册码
        /// 创建日期：2016-06-29
        /// 创建作者：luolian
        /// </summary>
        /// <param name="mac"></param>
        /// <returns></returns>
        public static string CreateRegCode(string mac)
        {
            RSACryptoServiceProvider cryptor = new RSACryptoServiceProvider();
            cryptor.FromXmlString("");//导入私钥
            byte[] regCodeBytes = cryptor.SignData(Encoding.UTF8.GetBytes(mac), "SHA1");
            return Convert.ToBase64String(regCodeBytes);
        }

        /// <summary>
        /// 功能描述：针对该机器码指定使用好长时间
        /// 创建日期：2016-06-29
        /// 创建作者：luolian
        /// </summary>
        /// <param name="mac"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string CreateRegCode(string mac, DateTime date)
        {
            RSACryptoServiceProvider cryptor = new RSACryptoServiceProvider();
            cryptor.FromXmlString("");//导入私钥
            string signature = string.Format("[{0}][{1}]", mac, date.ToString("yyyy-MM-dd"));
            byte[] regCodeBytes = cryptor.SignData(Encoding.UTF8.GetBytes(signature), "SHA1");
            return Convert.ToBase64String(regCodeBytes);
        }

        /// <summary>
        /// 功能描述：验证机器码和注册码是否匹配
        /// 创建日期：2016-06-29
        /// 创建作者：luolian
        /// </summary>
        /// <param name="mac">MAC地址</param>
        /// <param name="code">激活码</param>
        /// <returns></returns>
        public static bool ValidateCode(string mac, string code)
        {
            bool result = false;
            try
            {
                RSACryptoServiceProvider cryptor = new RSACryptoServiceProvider();
                cryptor.FromXmlString(UIConstants.PublicKey);
                byte[] signedData = Convert.FromBase64String(code);
                result = cryptor.VerifyData(Encoding.UTF8.GetBytes(mac), "SHA1", signedData);
            }
            catch (Exception e)
            {

            }
            return result;
        }

        /// <summary>
        /// 功能描述：通过时间进行判断是否到期或者激活
        /// 创建日期：2016-06-29
        /// 创建作者：luolian
        /// </summary>
        /// <param name="mac">mac地址</param>
        /// <param name="code">激活码</param>
        /// <returns></returns>
        public static bool ValidateCodeByDate(string mac, string code)
        {
            try
            {
                RSACryptoServiceProvider cryptor = new RSACryptoServiceProvider();
                cryptor.FromXmlString(UIConstants.PublicKey);
                byte[] signedData = Convert.FromBase64String(code);
                bool isToday = cryptor.VerifyData(Encoding.UTF8.GetBytes(string.Format("[{0}][{0}]", DateTime.Now.ToString("yyyy-MM-dd"))), "SHA1", signedData);
                bool machineToday = cryptor.VerifyData(Encoding.UTF8.GetBytes(string.Format("[{0}][{1}]", mac, DateTime.Now.ToString("yyyy-MM-dd"))), "SHA1", signedData);
                bool isForever = cryptor.VerifyData(Encoding.UTF8.GetBytes(string.Format("[{0}][{0}]", mac, Environment.MachineName)), "SHA1", signedData);
                bool isOverTime = cryptor.VerifyData(Encoding.UTF8.GetBytes(string.Format("[{1}][{1}]", mac, Convert.ToDateTime("2017/03/11"))), "SHA1", signedData);
                return isOverTime || isToday || machineToday || isForever;
            }
            catch
            {
                return false;
            }
        }
    }
}
