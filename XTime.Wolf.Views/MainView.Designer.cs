using System.Windows.Forms;
namespace XTime.Wolf.Views
{
    partial class MainView
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.SystemMenu = new System.Windows.Forms.MenuStrip();
            this.systemSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyPasswordMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemLogLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemInfoIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemRightRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessibilityTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllButThisOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.supportSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payForPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataDictionaryDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treasuryManagementMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parameterConfigCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.initialDataIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemStrip = new System.Windows.Forms.ToolStrip();
            this.tsSysExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSysTime = new System.Windows.Forms.ToolStripLabel();
            this.tsLabalTime = new System.Windows.Forms.ToolStripLabel();
            this.SystemStatus = new System.Windows.Forms.StatusStrip();
            this.SystemNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.SystemContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showHidenSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitXToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerCurrent = new System.Windows.Forms.Timer(this.components);
            this.DotManager = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.dockSite4 = new DevComponents.DotNetBar.DockSite();
            this.dockSite1 = new DevComponents.DotNetBar.DockSite();
            this.BarNavigate = new DevComponents.DotNetBar.Bar();
            this.PanelContainer = new DevComponents.DotNetBar.PanelDockContainer();
            this.leftSideBar = new DevComponents.DotNetBar.SideBar();
            this.leftSideBarPanelItem = new DevComponents.DotNetBar.SideBarPanelItem();
            this.leftDockContainerItem = new DevComponents.DotNetBar.DockContainerItem();
            this.dockSite2 = new DevComponents.DotNetBar.DockSite();
            this.dockSite8 = new DevComponents.DotNetBar.DockSite();
            this.dockSite5 = new DevComponents.DotNetBar.DockSite();
            this.dockSite6 = new DevComponents.DotNetBar.DockSite();
            this.dockSite7 = new DevComponents.DotNetBar.DockSite();
            this.dockSite3 = new DevComponents.DotNetBar.DockSite();
            this.fillSite = new DevComponents.DotNetBar.DockSite();
            this.SystemMenu.SuspendLayout();
            this.SystemStrip.SuspendLayout();
            this.SystemContextMenu.SuspendLayout();
            this.dockSite1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarNavigate)).BeginInit();
            this.BarNavigate.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemMenu
            // 
            this.SystemMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemSToolStripMenuItem,
            this.accessibilityTToolStripMenuItem,
            this.windowWToolStripMenuItem,
            this.dataDToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.SystemMenu.Location = new System.Drawing.Point(0, 0);
            this.SystemMenu.Name = "SystemMenu";
            this.SystemMenu.Size = new System.Drawing.Size(1019, 25);
            this.SystemMenu.TabIndex = 0;
            this.SystemMenu.Text = "SystemMenu";
            // 
            // systemSToolStripMenuItem
            // 
            this.systemSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyPasswordMToolStripMenuItem,
            this.systemLogLToolStripMenuItem,
            this.systemInfoIToolStripMenuItem,
            this.systemRightRToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitXToolStripMenuItem});
            this.systemSToolStripMenuItem.Name = "systemSToolStripMenuItem";
            this.systemSToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.systemSToolStripMenuItem.Text = "系统(&S)";
            // 
            // modifyPasswordMToolStripMenuItem
            // 
            this.modifyPasswordMToolStripMenuItem.Name = "modifyPasswordMToolStripMenuItem";
            this.modifyPasswordMToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.modifyPasswordMToolStripMenuItem.Text = "修改密码(&M)";
            // 
            // systemLogLToolStripMenuItem
            // 
            this.systemLogLToolStripMenuItem.Name = "systemLogLToolStripMenuItem";
            this.systemLogLToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.systemLogLToolStripMenuItem.Text = "系统日志(&L)";
            // 
            // systemInfoIToolStripMenuItem
            // 
            this.systemInfoIToolStripMenuItem.Name = "systemInfoIToolStripMenuItem";
            this.systemInfoIToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.systemInfoIToolStripMenuItem.Text = "系统信息(&I)";
            // 
            // systemRightRToolStripMenuItem
            // 
            this.systemRightRToolStripMenuItem.Name = "systemRightRToolStripMenuItem";
            this.systemRightRToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.systemRightRToolStripMenuItem.Text = "系统权限(&R)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // exitXToolStripMenuItem
            // 
            this.exitXToolStripMenuItem.Name = "exitXToolStripMenuItem";
            this.exitXToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exitXToolStripMenuItem.Text = "退出(&X)";
            // 
            // accessibilityTToolStripMenuItem
            // 
            this.accessibilityTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcCToolStripMenuItem,
            this.noteNToolStripMenuItem,
            this.paintPToolStripMenuItem});
            this.accessibilityTToolStripMenuItem.Name = "accessibilityTToolStripMenuItem";
            this.accessibilityTToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.accessibilityTToolStripMenuItem.Text = "系统助手(&T)";
            // 
            // calcCToolStripMenuItem
            // 
            this.calcCToolStripMenuItem.Name = "calcCToolStripMenuItem";
            this.calcCToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.calcCToolStripMenuItem.Text = "计算(&C)";
            // 
            // noteNToolStripMenuItem
            // 
            this.noteNToolStripMenuItem.Name = "noteNToolStripMenuItem";
            this.noteNToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.noteNToolStripMenuItem.Text = "记事本(&N)";
            // 
            // paintPToolStripMenuItem
            // 
            this.paintPToolStripMenuItem.Name = "paintPToolStripMenuItem";
            this.paintPToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.paintPToolStripMenuItem.Text = "画图(&P)";
            // 
            // windowWToolStripMenuItem
            // 
            this.windowWToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAllCToolStripMenuItem,
            this.closeAllButThisOToolStripMenuItem,
            this.refreshRToolStripMenuItem});
            this.windowWToolStripMenuItem.Name = "windowWToolStripMenuItem";
            this.windowWToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.windowWToolStripMenuItem.Text = "窗体(&W)";
            // 
            // closeAllCToolStripMenuItem
            // 
            this.closeAllCToolStripMenuItem.Name = "closeAllCToolStripMenuItem";
            this.closeAllCToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.closeAllCToolStripMenuItem.Text = "关闭所有(&C)";
            // 
            // closeAllButThisOToolStripMenuItem
            // 
            this.closeAllButThisOToolStripMenuItem.Name = "closeAllButThisOToolStripMenuItem";
            this.closeAllButThisOToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.closeAllButThisOToolStripMenuItem.Text = "除此之外关闭所有(&O)";
            // 
            // refreshRToolStripMenuItem
            // 
            this.refreshRToolStripMenuItem.Name = "refreshRToolStripMenuItem";
            this.refreshRToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.refreshRToolStripMenuItem.Text = "刷新(&R)";
            // 
            // dataDToolStripMenuItem
            // 
            this.dataDToolStripMenuItem.Name = "dataDToolStripMenuItem";
            this.dataDToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.dataDToolStripMenuItem.Text = "数据(&D)";
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAToolStripMenuItem,
            this.helpFToolStripMenuItem,
            this.registerRToolStripMenuItem,
            this.toolStripSeparator3,
            this.supportSToolStripMenuItem,
            this.payForPToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.helpHToolStripMenuItem.Text = "帮助(&H)";
            // 
            // aboutAToolStripMenuItem
            // 
            this.aboutAToolStripMenuItem.Name = "aboutAToolStripMenuItem";
            this.aboutAToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.aboutAToolStripMenuItem.Text = "关于(&A)";
            this.aboutAToolStripMenuItem.Click += new System.EventHandler(this.SystemNofity_About_Click);
            // 
            // helpFToolStripMenuItem
            // 
            this.helpFToolStripMenuItem.Name = "helpFToolStripMenuItem";
            this.helpFToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.helpFToolStripMenuItem.Text = "帮助(&F)";
            // 
            // registerRToolStripMenuItem
            // 
            this.registerRToolStripMenuItem.Name = "registerRToolStripMenuItem";
            this.registerRToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.registerRToolStripMenuItem.Text = "注册(&R)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(136, 6);
            // 
            // supportSToolStripMenuItem
            // 
            this.supportSToolStripMenuItem.Name = "supportSToolStripMenuItem";
            this.supportSToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.supportSToolStripMenuItem.Text = "技术支持(&S)";
            // 
            // payForPToolStripMenuItem
            // 
            this.payForPToolStripMenuItem.Name = "payForPToolStripMenuItem";
            this.payForPToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.payForPToolStripMenuItem.Text = "支付(&P)";
            // 
            // dataDictionaryDToolStripMenuItem
            // 
            this.dataDictionaryDToolStripMenuItem.Name = "dataDictionaryDToolStripMenuItem";
            this.dataDictionaryDToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.dataDictionaryDToolStripMenuItem.Text = "数据字典(&D)";
            // 
            // treasuryManagementMToolStripMenuItem
            // 
            this.treasuryManagementMToolStripMenuItem.Name = "treasuryManagementMToolStripMenuItem";
            this.treasuryManagementMToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.treasuryManagementMToolStripMenuItem.Text = "Treasury Management(&M)";
            // 
            // parameterConfigCToolStripMenuItem
            // 
            this.parameterConfigCToolStripMenuItem.Name = "parameterConfigCToolStripMenuItem";
            this.parameterConfigCToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.parameterConfigCToolStripMenuItem.Text = "Parameter Config(&C)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(224, 6);
            // 
            // initialDataIToolStripMenuItem
            // 
            this.initialDataIToolStripMenuItem.Name = "initialDataIToolStripMenuItem";
            this.initialDataIToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.initialDataIToolStripMenuItem.Text = "Initial Data(&I)";
            // 
            // SystemStrip
            // 
            this.SystemStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSysExit,
            this.toolStripSeparator4,
            this.tsSysTime,
            this.tsLabalTime});
            this.SystemStrip.Location = new System.Drawing.Point(0, 25);
            this.SystemStrip.Name = "SystemStrip";
            this.SystemStrip.Size = new System.Drawing.Size(1019, 25);
            this.SystemStrip.TabIndex = 1;
            this.SystemStrip.Text = "SystemStrip";
            // 
            // tsSysExit
            // 
            this.tsSysExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSysExit.Image = ((System.Drawing.Image)(resources.GetObject("tsSysExit.Image")));
            this.tsSysExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSysExit.Name = "tsSysExit";
            this.tsSysExit.Size = new System.Drawing.Size(36, 22);
            this.tsSysExit.Text = "退出";
            this.tsSysExit.Click += new System.EventHandler(this.tsSysExit_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsSysTime
            // 
            this.tsSysTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSysTime.Image = ((System.Drawing.Image)(resources.GetObject("tsSysTime.Image")));
            this.tsSysTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSysTime.Name = "tsSysTime";
            this.tsSysTime.Size = new System.Drawing.Size(32, 22);
            this.tsSysTime.Text = "时间";
            // 
            // tsLabalTime
            // 
            this.tsLabalTime.ForeColor = System.Drawing.Color.Red;
            this.tsLabalTime.Name = "tsLabalTime";
            this.tsLabalTime.Size = new System.Drawing.Size(56, 22);
            this.tsLabalTime.Text = "00:00:00";
            // 
            // SystemStatus
            // 
            this.SystemStatus.Location = new System.Drawing.Point(0, 562);
            this.SystemStatus.Name = "SystemStatus";
            this.SystemStatus.Size = new System.Drawing.Size(1019, 22);
            this.SystemStatus.TabIndex = 2;
            this.SystemStatus.Text = "SystemStatus";
            // 
            // SystemNotify
            // 
            this.SystemNotify.ContextMenuStrip = this.SystemContextMenu;
            this.SystemNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("SystemNotify.Icon")));
            this.SystemNotify.Text = "XTime";
            this.SystemNotify.Visible = true;
            this.SystemNotify.DoubleClick += new System.EventHandler(this.SystemNotify_DoubleClick);
            // 
            // SystemContextMenu
            // 
            this.SystemContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAToolStripMenuItem1,
            this.showHidenSToolStripMenuItem,
            this.exitXToolStripMenuItem1});
            this.SystemContextMenu.Name = "SystemContextMenu";
            this.SystemContextMenu.Size = new System.Drawing.Size(145, 70);
            // 
            // aboutAToolStripMenuItem1
            // 
            this.aboutAToolStripMenuItem1.Name = "aboutAToolStripMenuItem1";
            this.aboutAToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.aboutAToolStripMenuItem1.Text = "关于(&A)";
            // 
            // showHidenSToolStripMenuItem
            // 
            this.showHidenSToolStripMenuItem.Name = "showHidenSToolStripMenuItem";
            this.showHidenSToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.showHidenSToolStripMenuItem.Text = "显示/隐藏(&S)";
            this.showHidenSToolStripMenuItem.Click += new System.EventHandler(this.SystemNofify_Show_Click);
            // 
            // exitXToolStripMenuItem1
            // 
            this.exitXToolStripMenuItem1.Name = "exitXToolStripMenuItem1";
            this.exitXToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.exitXToolStripMenuItem1.Text = "退出(&X)";
            this.exitXToolStripMenuItem1.Click += new System.EventHandler(this.exitXToolStripMenu_Click);
            // 
            // timerCurrent
            // 
            this.timerCurrent.Enabled = true;
            this.timerCurrent.Interval = 1000;
            this.timerCurrent.Tick += new System.EventHandler(this.timerCurrent_Tick);
            // 
            // DotManager
            // 
            this.DotManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.DotManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.DotManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.DotManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
            this.DotManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.DotManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            this.DotManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
            this.DotManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.DotManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.DotManager.BottomDockSite = this.dockSite4;
            this.DotManager.EnableFullSizeDock = false;
            this.DotManager.FillDockSite = this.fillSite;
            this.DotManager.LeftDockSite = this.dockSite1;
            this.DotManager.ParentForm = this;
            this.DotManager.RightDockSite = this.dockSite2;
            this.DotManager.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.DotManager.ToolbarBottomDockSite = this.dockSite8;
            this.DotManager.ToolbarLeftDockSite = this.dockSite5;
            this.DotManager.ToolbarRightDockSite = this.dockSite6;
            this.DotManager.ToolbarTopDockSite = this.dockSite7;
            this.DotManager.TopDockSite = this.dockSite3;
            // 
            // dockSite4
            // 
            this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite4.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite4.Location = new System.Drawing.Point(0, 584);
            this.dockSite4.Name = "dockSite4";
            this.dockSite4.Size = new System.Drawing.Size(1019, 0);
            this.dockSite4.TabIndex = 6;
            this.dockSite4.TabStop = false;
            // 
            // dockSite1
            // 
            this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite1.Controls.Add(this.BarNavigate);
            this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.BarNavigate, 99, 512)))}, DevComponents.DotNetBar.eOrientation.Horizontal);
            this.dockSite1.Location = new System.Drawing.Point(0, 50);
            this.dockSite1.Name = "dockSite1";
            this.dockSite1.Size = new System.Drawing.Size(102, 512);
            this.dockSite1.TabIndex = 3;
            this.dockSite1.TabStop = false;
            this.dockSite1.MinimumSize = new System.Drawing.Size(95, 0);
            this.dockSite1.MaximumSize = new System.Drawing.Size(102, 1024);
            // 
            // BarNavigate
            // 
            this.BarNavigate.AccessibleDescription = "DotNetBar Bar (BarNavigate)";
            this.BarNavigate.AccessibleName = "DotNetBar Bar";
            this.BarNavigate.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.BarNavigate.CanAutoHide = false;
            this.BarNavigate.CanMove = false;
            this.BarNavigate.CanUndock = false;
            this.BarNavigate.Controls.Add(this.PanelContainer);
            this.BarNavigate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BarNavigate.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
            this.BarNavigate.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.leftDockContainerItem});
            this.BarNavigate.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.BarNavigate.Location = new System.Drawing.Point(0, 0);
            this.BarNavigate.Name = "BarNavigate";
            this.BarNavigate.Size = new System.Drawing.Size(99, 512);
            this.BarNavigate.Stretch = true;
            this.BarNavigate.TabIndex = 0;
            this.BarNavigate.TabStop = false;
            this.BarNavigate.Text = "导航栏";
            // 
            // PanelContainer
            // 
            this.PanelContainer.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.PanelContainer.Controls.Add(this.leftSideBar);
            this.PanelContainer.Location = new System.Drawing.Point(3, 23);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(93, 486);
            this.PanelContainer.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelContainer.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.PanelContainer.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.PanelContainer.Style.GradientAngle = 90;
            this.PanelContainer.TabIndex = 0;
            this.PanelContainer.TextMarkupEnabled = false;
            // 
            // leftSideBar
            // 
            this.leftSideBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.leftSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftSideBar.ExpandedPanel = this.leftSideBarPanelItem;
            this.leftSideBar.Location = new System.Drawing.Point(0, 0);
            this.leftSideBar.Name = "leftSideBar";
            this.leftSideBar.Panels.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.leftSideBarPanelItem});
            this.leftSideBar.Size = new System.Drawing.Size(93, 486);
            this.leftSideBar.TabIndex = 0;
            this.leftSideBar.ItemClick += new System.EventHandler(this.leftSideBar_ItemClick);
            // 
            // leftSideBarPanelItem
            // 
            this.leftSideBarPanelItem.ItemImageSize = DevComponents.DotNetBar.eBarImageSize.Medium;
            this.leftSideBarPanelItem.Name = "leftSideBarPanelItem";
            // 
            // leftDockContainerItem
            // 
            this.leftDockContainerItem.Control = this.PanelContainer;
            this.leftDockContainerItem.Name = "leftDockContainerItem";
            this.leftDockContainerItem.Text = "导航栏";
            // 
            // dockSite2
            // 
            this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite2.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite2.Location = new System.Drawing.Point(1019, 50);
            this.dockSite2.Name = "dockSite2";
            this.dockSite2.Size = new System.Drawing.Size(0, 512);
            this.dockSite2.TabIndex = 4;
            this.dockSite2.TabStop = false;
            // 
            // dockSite8
            // 
            this.dockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite8.Location = new System.Drawing.Point(0, 584);
            this.dockSite8.Name = "dockSite8";
            this.dockSite8.Size = new System.Drawing.Size(1019, 0);
            this.dockSite8.TabIndex = 10;
            this.dockSite8.TabStop = false;
            // 
            // dockSite5
            // 
            this.dockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite5.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite5.Location = new System.Drawing.Point(0, 0);
            this.dockSite5.Name = "dockSite5";
            this.dockSite5.Size = new System.Drawing.Size(0, 584);
            this.dockSite5.TabIndex = 7;
            this.dockSite5.TabStop = false;
            // 
            // dockSite6
            // 
            this.dockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite6.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite6.Location = new System.Drawing.Point(1019, 0);
            this.dockSite6.Name = "dockSite6";
            this.dockSite6.Size = new System.Drawing.Size(0, 584);
            this.dockSite6.TabIndex = 8;
            this.dockSite6.TabStop = false;
            // 
            // dockSite7
            // 
            this.dockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite7.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite7.Location = new System.Drawing.Point(0, 0);
            this.dockSite7.Name = "dockSite7";
            this.dockSite7.Size = new System.Drawing.Size(1019, 0);
            this.dockSite7.TabIndex = 9;
            this.dockSite7.TabStop = false;
            // 
            // dockSite3
            // 
            this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite3.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite3.Location = new System.Drawing.Point(0, 0);
            this.dockSite3.Name = "dockSite3";
            this.dockSite3.Size = new System.Drawing.Size(1019, 0);
            this.dockSite3.TabIndex = 5;
            this.dockSite3.TabStop = false;
            // 
            // fillSite
            // 
            this.fillSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.fillSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillSite.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.fillSite.Location = new System.Drawing.Point(102, 50);
            this.fillSite.Name = "fillSite";
            this.fillSite.Size = new System.Drawing.Size(917, 512);
            this.fillSite.TabIndex = 6;
            this.fillSite.TabStop = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 584);
            this.Controls.Add(this.fillSite);
            this.Controls.Add(this.dockSite2);
            this.Controls.Add(this.dockSite1);
            this.Controls.Add(this.SystemStatus);
            this.Controls.Add(this.SystemStrip);
            this.Controls.Add(this.SystemMenu);
            this.Controls.Add(this.dockSite3);
            this.Controls.Add(this.dockSite4);
            this.Controls.Add(this.dockSite5);
            this.Controls.Add(this.dockSite6);
            this.Controls.Add(this.dockSite7);
            this.Controls.Add(this.dockSite8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.SystemMenu;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.Move += new System.EventHandler(this.MainView_Move);
            this.SystemMenu.ResumeLayout(false);
            this.SystemMenu.PerformLayout();
            this.SystemStrip.ResumeLayout(false);
            this.SystemStrip.PerformLayout();
            this.SystemContextMenu.ResumeLayout(false);
            this.dockSite1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarNavigate)).EndInit();
            this.BarNavigate.ResumeLayout(false);
            this.PanelContainer.ResumeLayout(false);
            this.MinimumSize = new System.Drawing.Size(1019, 584);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip SystemMenu;
        private System.Windows.Forms.ToolStripMenuItem systemSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyPasswordMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemLogLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemInfoIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemRightRToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessibilityTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllButThisOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataDictionaryDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treasuryManagementMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parameterConfigCToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem initialDataIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerRToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem supportSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payForPToolStripMenuItem;
        private System.Windows.Forms.ToolStrip SystemStrip;
        private System.Windows.Forms.ToolStripButton tsSysExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel tsLabalTime;
        private System.Windows.Forms.StatusStrip SystemStatus;
        private System.Windows.Forms.ToolStripLabel tsSysTime;
        private System.Windows.Forms.NotifyIcon SystemNotify;
        private System.Windows.Forms.ContextMenuStrip SystemContextMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showHidenSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitXToolStripMenuItem1;
        private Timer timerCurrent;
        private DevComponents.DotNetBar.DotNetBarManager DotManager;
        private DevComponents.DotNetBar.DockSite dockSite4;
        private DevComponents.DotNetBar.DockSite dockSite1;
        private DevComponents.DotNetBar.Bar BarNavigate;
        private DevComponents.DotNetBar.PanelDockContainer PanelContainer;
        private DevComponents.DotNetBar.DockContainerItem leftDockContainerItem;
        private DevComponents.DotNetBar.DockSite dockSite2;
        private DevComponents.DotNetBar.DockSite dockSite3;
        private DevComponents.DotNetBar.DockSite dockSite5;
        private DevComponents.DotNetBar.DockSite dockSite6;
        private DevComponents.DotNetBar.DockSite dockSite7;
        private DevComponents.DotNetBar.DockSite dockSite8;
        private DevComponents.DotNetBar.DockSite fillSite;

        private DevComponents.DotNetBar.SideBar leftSideBar;
        private DevComponents.DotNetBar.SideBarPanelItem leftSideBarPanelItem;

    }
}

