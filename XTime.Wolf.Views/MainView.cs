using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XTime.Wolf.Commons;
using System.Xml;
using System.IO;
using DevComponents.DotNetBar;
using XTime.Wolf.CommonResource;
using XTime.Wolf.Views.UIControls;
using System.Threading;

namespace XTime.Wolf.Views
{
    public partial class MainView : Form
    {

        public MainView()
        {
            InitializeComponent();
            Splasher.Status = "正在获取服务器上面数据...";
            this.LoadDataFromService();
            Splasher.Status = "获取完成";
            Thread.Sleep(200);
            Splasher.Close();
        }

        private void LoadDataFromService()
        {
            //1、需要登录到考勤中去.
            var userData = Program.gc.UserInformation;
            string result = HttpWebHelper.PostToHttpServer("http://kq.chinasoftosg.com/workAttendance/loginAction", PostDataEntity.GetHubLoginAction(userData.UserNum, userData.UserName), RequestMethod.POST);
            if (result.Contains("欢迎"))
            {
                //2、具体获取当月数据
                result = HttpWebHelper.PostToHttpServer("http://kq.chinasoftosg.com/workAttendance/importsExamineAction_getImportsExamine", PostDataEntity.GetExamineAction(60), RequestMethod.POST);
                if (result.Contains("html"))
                {
                    LogTextHelper.WriteLine("获取个人数据失败。");
                    return;
                }
                Program.gc.CurrentData = result;
                return;
            }
            LogTextHelper.WriteLine("切换到考勤系统失败。");
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (base.WindowState != FormWindowState.Minimized)
            {
                e.Cancel = true;
                base.WindowState = FormWindowState.Minimized;
                this.SystemNotify.ShowBalloonTip(0xbb8, "程序最小化提示", "图标已经缩小到托盘，打开窗口请双击图标即可。", ToolTipIcon.Info);
            }
        }

        private void MainView_Move(object sender, EventArgs e)
        {
            if ((this != null) && (base.WindowState == FormWindowState.Minimized))
            {
                base.Hide();
                this.SystemNotify.ShowBalloonTip(0xbb8, "程序最小化提示", "图标已经缩小到托盘，打开窗口请双击图标即可。", ToolTipIcon.Info);
            }
        }

        /// <summary>
        /// 功能描述：退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsSysExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageUtil.ShowYesNoAndTips("您确定退出此系统么？"))
            {
                base.ShowInTaskbar = false;
                LogTextHelper.WriteLine("您即将退出系统，谢谢！");
                Program.gc.Quit();
            }
        }

        private void exitXToolStripMenu_Click(object sender, EventArgs e)
        {
            tsSysExit_Click(sender, e);
        }

        /// <summary>
        /// 功能描述：主窗体加载时，需要加载数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainView_Load(object sender, EventArgs e)
        {
            try
            {
                //TODO:读取配置文件
                AppConfig app = new AppConfig();
                string softProduct = app.AppConfigGet("SoftProduct");
                string applicationName = app.AppConfigGet("ApplicationName");
                string title = string.Format("{0}-{1}", softProduct, applicationName);
                this.Text = title;
                this.SystemNotify.Text = title;
            }
            catch
            {

            }
            // 显示需要显示的Menu
            this.ShowMenuList();
            // 验证用户是否注册
            ValidateRgisterStatus();
            // 加载Button
            InitialButtonItem();
        }

        /// <summary>
        /// 功能描述：验证注册信息
        /// 创建日期：2016-06-29
        /// 创建作者：luolian
        /// </summary>
        private void ValidateRgisterStatus()
        {
            Program.gc.CheckRegistered();
            bool flag = Program.gc.CheckTimeString();
            if (!Program.gc.IsRegister && !flag)
            {
                Program.gc.Quit();
            }
            if (!Program.gc.IsRegister)
            {
                this.Text = this.Text + " [未注册]";
                this.registerRToolStripMenuItem.Enabled = true;
                TimeSpan span = new TimeSpan(DateTime.Now.Ticks - Program.gc.FirstRunTime.Ticks);
                int num = UIConstants.SoftwareProbationDay - Math.Abs(span.Days);
                string str = string.Format(" [还剩下{0}天]", num);
                this.Text = this.Text + str;
            }
            else
            {
                this.Text = this.Text + " [已注册]";
                this.registerRToolStripMenuItem.Enabled = false;
            }
        }

        /// <summary>
        /// 功能描述：显示时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCurrent_Tick(object sender, EventArgs e)
        {
            this.tsLabalTime.Text = DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// SystemNotify点击的显示或者隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemNofify_Show_Click(object sender, EventArgs e)
        {
            if (base.WindowState == FormWindowState.Minimized)
            {
                base.WindowState = FormWindowState.Maximized;
                base.Show();
                base.BringToFront();
                base.Activate();
                base.Focus();
            }
            else
            {
                base.WindowState = FormWindowState.Minimized;
                base.Hide();
            }
        }

        /// <summary>
        /// SystemNofity点击关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemNofity_About_Click(object sender, EventArgs e)
        {
            Program.gc.About();
        }

        /// <summary>
        /// 功能描述：SystemNotify双击，显示主界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemNotify_DoubleClick(object sender, EventArgs e)
        {
            SystemNofify_Show_Click(sender,e);
        }

        /// <summary>
        /// 功能描述：让部分功能不显示
        /// </summary>
        private void ShowMenuList()
        {
            this.systemSToolStripMenuItem.Visible = false;
            this.accessibilityTToolStripMenuItem.Visible = false;
            this.windowWToolStripMenuItem.Visible = false;
            this.dataDToolStripMenuItem.Visible = false;
        }

        /// <summary>
        /// 功能描述：初始化主界面左边的按钮
        /// </summary>
        private void InitialButtonItem()
        {
            ButtonItem btnFind = new ButtonItem();
            btnFind.Name = "btnFind";
            btnFind.Text = "查询当月";
            btnFind.ImagePosition = eImagePosition.Top;
            btnFind.Image = GlobalImages.calendar;
            this.leftSideBarPanelItem.SubItems.Add(btnFind);

            ButtonItem btnHistory = new ButtonItem
            {
                Name = "btnHistory",
                Text = "查询历史",
                ImagePosition = eImagePosition.Top,
                Image = GlobalImages.calendar_day
            };
            this.leftSideBarPanelItem.SubItems.Add(btnHistory);

            ButtonItem btnStatistic = new ButtonItem
            {
                Name = "btnStatistic",
                Text = "当月走势",
                ImagePosition = eImagePosition.Top,
                Image = GlobalImages.monitor,
                Enabled = false
            };
            this.leftSideBarPanelItem.SubItems.Add(btnStatistic);
        }

        private void leftSideBar_ItemClick(object sender, EventArgs e)
        {
            var item = sender as ButtonItem;
            if (item != null)
            {
                DockContainerItem contianer = new DockContainerItem(item.Text, item.Text);
                var control = GetControlByControlName(item.Name);
                if (control == null)
                {
                    return;
                }
                contianer.Control = control;
                Bar bar = FindBar();
                if (bar.Items.IndexOf(item.Text) != -1)
                {
                    bar.SelectedDockTab = bar.Items.IndexOf(contianer);
                }
                else
                {
                    bar.Items.Add(contianer);
                    if (!bar.Visible)
                    {
                        bar.Visible = true;
                    }
                    bar.SelectedDockTab = bar.Items.IndexOf(contianer);
                }
                bar.RecalcLayout();
            }
            
        }

        private Control GetControlByControlName(string name)
        {
            if ("btnFind" == name)
            {
                return new BrowerControls("");
            }
            else if ("btnHistory" == name)
            {
                return new HistorySearchView();
            }
            else if ("btnStatistic" == name)
            {
                return new StaticGraphView();
            }
            return null;
        }

        /// <summary>
        /// 功能描述：查找FillBar
        /// </summary>
        /// <returns></returns>
        private Bar FindBar()
        {
            foreach (Bar b in DotManager.Bars)
            {
                if (b.DockSide == eDockSide.Document && b.Visible)
                {
                    return b;
                }
            }

            Bar bar = BarUtilities.CreateDocumentBar();
            bar.Name = Guid.NewGuid().ToString();
            bar.DockTabClosing += new DockTabClosingEventHandler(Item_DockTabClosing);
            this.fillSite.GetDocumentUIManager().Dock(bar);
            return bar;
        }

        /// <summary>
        /// 功能描述：关闭Document窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Item_DockTabClosing(object sender, DockTabClosingEventArgs e)
        {
            e.RemoveDockTab = true;
            e.DockContainerItem.Control.Dispose();
            e.DockContainerItem.Dispose();

            Bar bar = sender as Bar;
            if (bar != null && bar.Items.Count == 1)
            {
                DotManager.Bars.Remove(bar);
            }
        }
    }
}
