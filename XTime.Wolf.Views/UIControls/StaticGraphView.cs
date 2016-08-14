using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using XTime.Wolf.Model;

namespace XTime.Wolf.Views.UIControls
{
    public partial class StaticGraphView : UserControl
    {
        public StaticGraphView()
        {
            InitializeComponent();
            InitialData();
        }
        
        private void InitialData()
        {
            string json = Program.gc.CurrentData;
            if (string.IsNullOrEmpty(json))
            {
                return;
            }
            var data = new JavaScriptSerializer().Deserialize<JsonData>(json);
            List<int> yMonth = new List<int>();
            List<float> xOnMoning = new List<float>();
            List<float> xOnNight = new List<float>();
            var month = DateTime.Now.Month;
            var random = new Random();
            foreach (var item in data.Rows)
            {
                var display = item.ConverToData();
                if (month != display.CurrentDate.Month)
                {
                    continue;
                }

                yMonth.Add(display.CurrentDate.Day);
                xOnMoning.Add(random.Next(0,25));
                xOnNight.Add(random.Next(0, 25));
            }
            chart1.Series["上班"].Points.DataBindXY(yMonth, xOnMoning);
            chart1.Series["下班"].Points.DataBindXY(yMonth, xOnNight);
        }
    }
}
