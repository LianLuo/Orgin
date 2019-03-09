using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleClient
{
    public class WebHelper
    {
        private bool IsStop;
        private int m_CurrentIndex = 0;

        /// <summary>
        /// 处理特别文件
        /// </summary>
        /// <param name="originalUrl"></param>
        /// <param name="basePath"></param>
        public void Run(string originalUrl, string basePath)
        {
            string[] splits = originalUrl.Split('/');
            string key = splits[splits.Length - 2];
            splits[splits.Length - 1] = "out";

            string baseUrl = string.Join("/", splits);
            basePath = Path.Combine(basePath, key);
            if (!Directory.Exists(baseUrl))
            {
                Directory.CreateDirectory(basePath);
            }
            
            // 下载的时候启动四个线程同时下载
            CancellationTokenSource cts = new CancellationTokenSource();
            new Task(() => { FetchData(baseUrl, key, basePath, cts.Token); }).Start();
            new Task(() => { FetchData(baseUrl, key, basePath, cts.Token); }).Start();
            new Task(() => { FetchData(baseUrl, key, basePath, cts.Token); }).Start();
            new Task(() => { FetchData(baseUrl, key, basePath, cts.Token); }).Start();

            while (!IsStop)
            {
                Thread.Sleep(10000);
            }
        }

        /// <summary>
        /// 循环下载
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="key"></param>
        /// <param name="basePath"></param>
        /// <param name="token"></param>
        private void FetchData(string baseUrl, string key, string basePath, CancellationToken token)
        {
            while (true)
            {
                if (token.IsCancellationRequested)
                {
                    break;
                }
                try
                {
                    m_CurrentIndex++;
                    string fileName = $"{m_CurrentIndex:000}.ts";
                    string url = $"{baseUrl}{fileName}";
                    SaveData(url, "", key, Path.Combine(basePath, fileName));
                }
                catch (Exception e)
                {
                    IsStop = true;
                    Console.WriteLine($"Download Success:{e.Message}");
                    break;
                }
            }
        }
        
        /// <summary>
        /// 采用浏览器模拟用户访问
        /// </summary>
        /// <param name="url"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="key"></param>
        /// <param name="filePath"></param>
        private void SaveData(string url, string redirectUrl, string key, string filePath)
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
            request.KeepAlive = true;
            request.ProtocolVersion = HttpVersion.Version11;
            request.Method = "GET";
            request.Accept = "*/*";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.121 Safari/537.36";
            request.Referer = redirectUrl;
            
            using (HttpWebResponse response = (HttpWebResponse) request.GetResponse())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        if (dataStream != null)
                        {
                            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                            {
                                byte[] buffer = new byte[1024 * 1024];
                                // 循坏读取数据
                                while (true)
                                {
                                    int read = dataStream.Read(buffer, 0, buffer.Length);
                                    if (read <= 0)
                                    {
                                        break;
                                    }

                                    fs.Write(buffer, 0, read);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}