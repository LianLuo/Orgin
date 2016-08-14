using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XTime.Wolf.Model;
using System.Web.Script.Serialization;

namespace XTime.Wolf.Views.UIControls
{
    public partial class ShowDataBrower : UserControl
    {

        public ShowDataBrower()
        {
            InitializeComponent();
        }

        public void RefreshData(object sender,InformationArgs e)
        {
            var html = ViewHelper.GetStringFromResource("XTime.Wolf.Views.showData.html");
            dataBrower.DocumentText = html.Replace("$body",GetJsonDataFromData(e.JsonData)).Replace("$time",e.Title);
        }

        private string GetJsonDataFromData(string jsonData)
        {
            JsonData data = new JsonData();
            if (string.IsNullOrEmpty(jsonData))
            {
                return "<tr><td colspan='10'><font color='red'>没有找到数据</font></td></tr>";
            }
            data = new JavaScriptSerializer().Deserialize<JsonData>(jsonData);
            StringBuilder sb = new StringBuilder();
            if (data != null)
            {
                foreach (var item in data.Rows)
                {
                    var displayData = item.ConverToData();

                    sb.Append(string.Format("<tr ><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td>{8}</td><td>{9}</td></tr>",
                    displayData.UserNumber,
                    displayData.PlaceArea,
                    displayData.UserName,
                    displayData.CurrentDate.ToString("yyyy-MM-dd"),
                    displayData.StartDate.ToString("HH:mm:ss"),
                    displayData.EndDate.ToString("HH:mm:ss"),
                    displayData.IsOverTime ? "√" : "-",
                    displayData.IsCanBu ? "√" : "-",
                    displayData.IsLate ? "√" : "-",
                    displayData.AllDayTime.ToString("f2")));
                }
            }
            return sb.ToString();
        }
    }
}
