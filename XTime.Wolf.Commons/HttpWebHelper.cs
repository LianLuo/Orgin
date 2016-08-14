using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace XTime.Wolf.Commons
{
    public class HttpWebHelper
    {
        public static string HttpRequestByPost(string url, string json,bool isProxy,CookieContainer cookie)
        {
            string result = string.Empty;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.106 Safari/537.36";
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            if (isProxy)
            {
                WebProxy proxy = new WebProxy("172.18.32.134", 8080);
                proxy.Credentials = CredentialCache.DefaultCredentials;
                request.Proxy = proxy;
            }
            if (cookie != null)
            {
                request.CookieContainer = cookie;
            }

            request.Timeout = 180000;
            request.ReadWriteTimeout = 180000;
            request.KeepAlive = false;
            byte[] datas = Encoding.UTF8.GetBytes(json);
            request.ContentLength = datas.Length;
            try
            {
                Stream requeStream = request.GetRequestStream();
                requeStream.Write(datas, 0, datas.Length);
                requeStream.Close();
            }
            catch (ProtocolViolationException ex)
            {
                request.Abort();
            }
            catch (WebException e)
            {
                request.Abort();
            }
            catch (ObjectDisposedException e)
            {
                request.Abort();
            }
            catch (InvalidOperationException e)
            {
                request.Abort();
            }
            catch (NotSupportedException e)
            {
                request.Abort();
            }
            HttpWebResponse response = null;
            string responseData = string.Empty;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                using (StreamReader sr = new StreamReader(stream))
                {
                    responseData = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                request.Abort();
            }
            finally
            {
                if (response != null)
                {
                    try
                    {
                        response.Close();
                    }
                    catch
                    {
                        request.Abort();
                    }
                }
            }
            return responseData;
        }
    }
}
