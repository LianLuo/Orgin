using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XTime.Wolf.Commons;

namespace XTime.Wolf.Views
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
            // 随机产生背景图片
            var rand = new Random().Next(7, 10);
            string fileName = string.Format("XTime.Wolf.Views.ImagesIco.{0}.png", rand);
            this.BackgroundImage = ViewHelper.GetImageFromResource(fileName);
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btLogin_Click(sender, null);
            }
            if (e.KeyCode == Keys.F1)
            {
                LogTextHelper.WriteLine("您操作了一个不存在的功能。【F1】");
            }
        }

        private void cmbzhanhao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.tbPass.Focus();
            }
            if (e.KeyCode == Keys.F1)
            {
                LogTextHelper.WriteLine("您操作了一个不存在的功能。【F1】");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            LogTextHelper.WriteLine("您关闭等你，谢谢您的使用。");
            base.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //test
            //IsLogin = true;
            //this.DialogResult = System.Windows.Forms.DialogResult.OK;
            //return;

            if (this.cmbzhanhao.Text.Length == 0)
            {
                MessageUtil.ShowTips("请输入帐号。");
                this.cmbzhanhao.Focus();
            }
            else
            {
                string result = HttpWebHelper.PostToHttpServer("http://ics.chinasoftosg.com/login", PostDataEntity.GetLoginAction(cmbzhanhao.Text.Trim(), tbPass.Text.Trim()), RequestMethod.POST);
                if (result.Contains("登录系统失败") || result.Contains("忘记密码"))
                {
                    LogTextHelper.WriteLine("用户名或者密码错误");
                    MessageUtil.ShowWarning("用户名或者密码错误");
                    IsLogin = false;
                    return;
                }
                Program.gc.UserInformation = new Model.UserInfo { UserNum = this.cmbzhanhao.Text.Trim(),UserName = ""};
                IsLogin = true;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void Logon_Load(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.cmbzhanhao, "输入帐号，如：54321");
            tip.SetToolTip(this.tbPass, "登录密码");

            AppConfig config = new AppConfig();
            this.Text = config.AppName;
            this.lblTitle.Text = config.AppName;

            if (this.cmbzhanhao.Text != "")
            {
                this.tbPass.Focus();
            }
            else
            {
                this.cmbzhanhao.Focus();
            }
        }

        private void Logon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btLogin_Click(sender, null);
            }
            if (e.KeyCode == Keys.F1)
            {
                LogTextHelper.WriteLine("您操作了一个不存在的功能。【F1】");
            }
        }

        /// <summary>
        /// 功能描述：获取是否需要代理
        /// 创建作者：luolian
        /// 创建日期：2016-7-27
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radbtnIntra_Click(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio != null)
            {
                if (radio.Name == "radbtnIntra")
                {
                    Program.gc.IsProxy = true;
                }
                else
                {
                    Program.gc.IsProxy = false;
                }
            }
        }
    }
}
