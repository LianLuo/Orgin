using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using XTime.Wolf.Commons;
using System.IO;

namespace XTime.Wolf.Views
{
    public sealed class HttpWebHelper
    {
        /// <summary>
        /// 功能描述：通过POST请求获取数据
        /// </summary>
        /// <param name="url"></param>
        /// <param name="json"></param>
        /// <returns></returns>
        public static string PostToHttpServer(string url, string json,RequestMethod method)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = method == RequestMethod.GET ? "GET" : "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.110 Safari/537.36";
            if (Program.gc.IsProxy)
            {
                WebProxy proxy = new WebProxy();
                proxy.Credentials = CredentialCache.DefaultCredentials;
                request.Proxy = proxy;
            }
            if (Program.gc.Cookie != null)
            {
                request.CookieContainer = Program.gc.Cookie;
            }

            request.Timeout = 180000;
            request.ReadWriteTimeout = 180000;

            byte[] datas = Encoding.UTF8.GetBytes(json);
            request.ContentLength = datas.Length;
            try
            {
                var requestStream = request.GetRequestStream();
                requestStream.Write(datas, 0, datas.Length);
            }
            catch (Exception e)
            {
                LogTextHelper.WriteLine(e.StackTrace);
                request.Abort();
                throw e;
            }
            HttpWebResponse response = null;
            string responseData = string.Empty;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                var stream = response.GetResponseStream();
                using (var sr = new StreamReader(stream))
                {
                    responseData = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                LogTextHelper.WriteLine(e.StackTrace);
                request.Abort();
                throw e;
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }
            return responseData;
        }
    }

    /// <summary>
    /// 功能描述：构造请求的JSON对象
    /// </summary>
    public sealed class PostDataEntity
    {
        private static string personForm = "importsExamineVo.page={0}&importsExamineVo.pagesize={1}";
        private static string personHistory = "importsExamineVo.recordBeginDate={0}&importsExamineVo.recordEndDate={1}&importsExamineVo.page={2}&importsExamineVo.pagesize={3}";
        private static string personLogin = "userid={0}&linkpage=&userName={0}&j_username={0}&password={1}&j_password={1}";
        private static string personHub = "linkpage=&lobNumber=00000{0}&userName={1}&function=PERSON&icsKey=";
        private static string jsonData;
        public string JsonData
        {
            get{return jsonData;}
            set{jsonData = value;}
        }

        public PostDataEntity()
        {

        }

        /// <summary>
        /// 功能描述：直接请求个人数据
        /// </summary>
        /// <param name="pageSize">页容量</param>
        public static string GetExamineAction(int pageSize)
        {
            return string.Format(personForm, 1, pageSize);
        }
        /// <summary>
        /// 功能描述：查询历史数据
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="pageSize"></param>
        public static string GetHistoryAction(DateTime start, DateTime end, int pageSize)
        {
            return string.Format(personHistory, start.ToString("yyyy-MM-dd"), end.ToString("yyyy-MM-dd"), 1, pageSize);
        }

        /// <summary>
        /// 功能描述：个人登录信息
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="pwd"></param>
        public static string GetLoginAction(string userName, string pwd)
        {
            return string.Format(personLogin, userName, pwd);
        }

        /// <summary>
        /// 功能描述：获取考情中的Form数据
        /// </summary>
        /// <param name="userNumber"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static string GetHubLoginAction(string userNumber, string userName)
        {
            return string.Format(personHub, userNumber, userName);
        }
    }

    public enum RequestMethod
    {
        POST,
        GET
    }
}
