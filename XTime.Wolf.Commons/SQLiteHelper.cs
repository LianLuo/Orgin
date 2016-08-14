using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SQLite;
using System.Data.Common;
using System.Data;
using System.Reflection;

namespace XTime.Wolf.Commons
{
    public class SQLiteHelper
    {
        private static readonly string dataSource = Path.Combine(Environment.CurrentDirectory,@"LocalData/localData.db");

        private static readonly string connstr = string.Format(@"Data Source={0}",dataSource);

        private static readonly string connstrKey = string.Format(@"Data Source={0};Password=root",dataSource);

        /// <summary>
        /// 功能描述：检测数据库文件是否存在
        /// </summary>
        /// <returns></returns>
        private static void CheckFileExist()
        {
            if (!File.Exists(dataSource))
            {
                LogTextHelper.WriteLine("对不起，没有找到数据库文件："+connstr);
                LogTextHelper.WriteLine("尝试创建数据库。");
                SQLiteConnection.CreateFile(dataSource);
                LogTextHelper.WriteLine("创建数据库，数据库文件："+dataSource);
                InitialDatabase();
            }
        }

        /// <summary>
        /// 功能描述：插入，删除，更新操作
        /// </summary>
        /// <param name="cmdText">SQL语句</param>
        /// <param name="paras">参数</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string cmdText, params DbParameter[] paras)
        {
            int result = -1;
            CheckFileExist();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connstrKey))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = cmdText;
                        cmd.Parameters.AddRange(paras);
                        result = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                LogTextHelper.WriteLine(e.Message);
                result = -1;
            }
            return result;
        }

        /// <summary>
        /// 功能描述：查询获取数据列表
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataTable ExecuteTable(string cmdText, params DbParameter[] paras)
        {
            DataTable dt = new DataTable();
            CheckFileExist();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connstrKey))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = cmdText;
                        cmd.Parameters.AddRange(paras);
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (SQLiteException e)
            {
                LogTextHelper.WriteLine(e.Message);
            }
            return dt;
        }

        /// <summary>
        /// 功能描述：返回第一行第一列
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static object ExecuteScaler(string cmdText, params DbParameter[] paras)
        {
            object obj = null;
            CheckFileExist();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connstrKey))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = cmdText;
                        cmd.Parameters.AddRange(paras);
                        obj = cmd.ExecuteScalar();
                    }
                }
            }
            catch(SQLiteException e)
            {
                LogTextHelper.WriteLine(e.Message);
            }
            return obj;
        }

        /// <summary>
        /// 功能描述：初始化数据库
        /// </summary>
        private static void InitialDatabase()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connstr))
                {
                    conn.Open();
                    conn.ChangePassword("root");
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = GetSqlFromResource();
                        cmd.ExecuteNonQuery();
                        LogTextHelper.WriteLine("数据库初始化成功！");
                    }
                }
            }
            catch (SQLiteException e)
            {
                LogTextHelper.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// 功能描述：获取初始化数据库SQL
        /// </summary>
        /// <returns></returns>
        private static string GetSqlFromResource()
        {
            var ass = Assembly.GetExecutingAssembly();
            var fileStream = ass.GetManifestResourceStream("XTime.Wolf.Commons.recorddata.sql");
            return new System.IO.StreamReader(fileStream).ReadToEnd();
        }

        /// <summary>
        /// 功能描述：获取内嵌资源中文件
        /// </summary>
        /// <param name="type"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string GetSqlFromResource(Type type, string filePath)
        {
            var ass = Assembly.GetAssembly(type);
            var fileStream = ass.GetManifestResourceStream(ass.FullName+"."+filePath);
            return new System.IO.StreamReader(fileStream).ReadToEnd();
        }
    }
}
