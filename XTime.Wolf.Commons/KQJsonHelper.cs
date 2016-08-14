using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XTime.Wolf.Commons
{
    /// <summary>
    /// 功能描述：此类仅仅针对中软考情
    /// </summary>
    public class KQJsonHelper
    {
        /// <summary>
        /// 功能描述：获取登录时需要的POST数据格式
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        public static string LoginPostData(string userName, string pwd)
        {
            return string.Format("userid={0}&linkpage=''&userName={0}&j_username={0}&password={1}&j_password={1}",userName,pwd);
        }

        public static string PersonPostData(int pageSize)
        {
            return string.Format("importsExamineVo.page=1&importsExamineVo.pagesize={0}", pageSize);
        }

        /// <summary>
        /// 功能描述：考勤的Url
        /// </summary>
        /// <returns></returns>
        public static string KaoQinUrl()
        {
            return "http://kq.chinasoftosg.com/workAttendance/loginAction";
        }

        /// <summary>
        /// 功能描述：个人打卡数据Url
        /// </summary>
        /// <returns></returns>
        public static string PersonDataUrl()
        {
            return "http://kq.chinasoftosg.com/workAttendance/importsExamineAction_getImportsExamine";
        }

        /// <summary>
        /// 功能描述：个人历史数据Url
        /// </summary>
        /// <returns></returns>
        public static string PersonHistoryDataUrl()
        {
            return "http://kq.chinasoftosg.com/workAttendance/importsExamineAction_getImportsEarlyExamine";
        }

        /// <summary>
        /// 功能描述：个人历史数据的POST数据格式
        /// </summary>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static string PersonHistoryPostData(int pageSize,DateTime startTime,DateTime endTime)
        {
            return string.Format("importsExamineVo.page=1&importsExamineVo.pagesize={0}&importsExamineVo.recordBeginDate={1}&importsExamineVo.recordEndDate={2}", pageSize,startTime.ToString("yyyy-MM-dd"),endTime.ToString("yyyy-MM-dd"));
        }
    }
}
