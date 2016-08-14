using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace XTime.Wolf.Views
{
    public partial class SplashScreen : Form,ISplashView
    {
        public SplashScreen()
        {
            InitializeComponent();
            var rand = new Random().Next(1, 6);
            string fileName = string.Format("XTime.Wolf.Views.ImagesIco.{0}.png",rand);
            this.BackgroundImage = ViewHelper.GetImageFromResource(fileName);
        }

        public void SetStatusInfo(string newStatusInfo)
        {
            this.lbStatusInfo.Text = newStatusInfo;
        }
    }
}
