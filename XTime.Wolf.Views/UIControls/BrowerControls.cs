using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XTime.Wolf.Commons;
using System.Reflection;
using System.IO;
using System.Web.Script.Serialization;
using XTime.Wolf.Model;

namespace XTime.Wolf.Views.UIControls
{
    public partial class BrowerControls : UserControl
    {
        public BrowerControls()
        {
            InitializeComponent();
        }

        public BrowerControls(string flag):this()
        {
            var html = GetStringFromResource();
            int workDay;
            float currentTime;
            int dinnerBu;
            int overTime;
            WebBrower.DocumentText = html.Replace("$body", JsonSerizer(out workDay, out currentTime,out dinnerBu,out overTime)).Replace("$day", workDay.ToString()).Replace("$shouldTime", (workDay * 8).ToString()).Replace("$allTime", currentTime.ToString("f2")).Replace("$overTime", overTime.ToString()).Replace("$canbu", dinnerBu.ToString());
        }

        /// <summary>
        /// 解析Json数据
        /// </summary>
        private string JsonSerizer(out int workDays,out float currentTimes,out int dinnerBu,out int overTime)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            workDays = 0;
            currentTimes = 0;
            dinnerBu = 0;
            overTime = 0;
            if (string.IsNullOrEmpty(Program.gc.CurrentData))
            {
                return string.Empty;
            }
            var jsonData = serializer.Deserialize<JsonData>(Program.gc.CurrentData);
            StringBuilder sb = new StringBuilder();
            int mon = DateTime.Now.Month;
            int workDay = 0;
            float currentTime = 0;
            int canbu = 0;
            int overTimes=0;
            foreach (var item in jsonData.Rows)
            {
                var displayData = item.ConverToData();
                if (mon != displayData.CurrentDate.Month)
                    continue;
                sb.Append(string.Format("<tr ><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td>{8}</td><td>{9}</td></tr>",
                    displayData.UserNumber,
                    displayData.PlaceArea, 
                    displayData.UserName,
                    displayData.CurrentDate.ToString("yyyy-MM-dd"), 
                    displayData.StartDate.ToString("HH:mm:ss"), 
                    displayData.EndDate.ToString("HH:mm:ss"),
                    displayData.IsOverTime ? "√" : "-",
                    displayData.IsCanBu?"√":"-",
                    displayData.IsLate?"√":"-",
                    displayData.AllDayTime.ToString("f2")));
                if (!displayData.IsOverTime)
                {
                    workDay++;
                    currentTime += displayData.AllDayTime;
                }

                if (displayData.IsCanBu)
                {
                    canbu++;
                }
                if (displayData.IsOverTime)
                {
                    overTimes++;
                }
            }
            workDays = workDay;
            currentTimes = currentTime;
            dinnerBu = canbu;
            overTime = overTimes;
            return sb.ToString();
        }

        private string GetStringFromResource()
        {
            var ass = Assembly.GetExecutingAssembly();
            var fileStream = ass.GetManifestResourceStream("XTime.Wolf.Views.index.html");
            return new StreamReader(fileStream).ReadToEnd();
        }
    }
}
