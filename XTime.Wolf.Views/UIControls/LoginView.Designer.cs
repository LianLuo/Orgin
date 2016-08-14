using System.Windows.Forms;
using System.Drawing;
using System;
namespace XTime.Wolf.Views
{
    partial class LoginView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.cmbzhanhao = new System.Windows.Forms.ACComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCalendar = new System.Windows.Forms.Label();
            this.radbtnIntra = new System.Windows.Forms.RadioButton();
            this.radbtnInter = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radbtnInter);
            this.groupBox1.Controls.Add(this.radbtnIntra);
            this.groupBox1.Controls.Add(this.tbPass);
            this.groupBox1.Controls.Add(this.cmbzhanhao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(72, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登陆信息";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(96, 80);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(184, 21);
            this.tbPass.TabIndex = 1;
            this.tbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPass_KeyDown);
            // 
            // cmbzhanhao
            // 
            this.cmbzhanhao.Location = new System.Drawing.Point(96, 40);
            this.cmbzhanhao.Name = "cmbzhanhao";
            this.cmbzhanhao.Size = new System.Drawing.Size(184, 20);
            this.cmbzhanhao.TabIndex = 0;
            this.cmbzhanhao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbzhanhao_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "登陆账号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "登陆密码";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(349, 270);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "退出";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(248, 270);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "登陆";
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(32, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(370, 23);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "仓库管理系统登陆界面";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCalendar
            // 
            this.lblCalendar.BackColor = System.Drawing.Color.Transparent;
            this.lblCalendar.Location = new System.Drawing.Point(59, 316);
            this.lblCalendar.Name = "lblCalendar";
            this.lblCalendar.Size = new System.Drawing.Size(354, 24);
            this.lblCalendar.TabIndex = 6;
            // 
            // radbtnIntra
            // 
            this.radbtnIntra.AutoSize = true;
            this.radbtnIntra.Checked = true;
            this.radbtnIntra.Location = new System.Drawing.Point(88, 139);
            this.radbtnIntra.Name = "radbtnIntra";
            this.radbtnIntra.Size = new System.Drawing.Size(47, 16);
            this.radbtnIntra.TabIndex = 2;
            this.radbtnIntra.TabStop = true;
            this.radbtnIntra.Text = "内网";
            this.radbtnIntra.UseVisualStyleBackColor = true;
            this.radbtnIntra.Click += new System.EventHandler(this.radbtnIntra_Click);
            // 
            // radbtnInter
            // 
            this.radbtnInter.AutoSize = true;
            this.radbtnInter.Location = new System.Drawing.Point(217, 139);
            this.radbtnInter.Name = "radbtnInter";
            this.radbtnInter.Size = new System.Drawing.Size(47, 16);
            this.radbtnInter.TabIndex = 2;
            this.radbtnInter.Text = "外网";
            this.radbtnInter.UseVisualStyleBackColor = true;
            this.radbtnInter.Click += new System.EventHandler(this.radbtnIntra_Click);
            // 
            // LoginView
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(500, 343);
            this.Controls.Add(this.lblCalendar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(516, 381);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(516, 381);
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "仓库管理系统登陆界面";
            this.Load += new System.EventHandler(this.Logon_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Logon_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public bool bLogin = false;
        private Button btExit;
        private Button btLogin;
        private ACComboBox cmbzhanhao;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label lblCalendar;
        private Label lblTitle;
        private const string Login_Name_Key = "WareHouseMis_LoginName";
        private TextBox tbPass;
        private RadioButton radbtnInter;
        private RadioButton radbtnIntra;

        /// <summary>
        /// 是否登录
        /// </summary>
        public bool IsLogin { get; set; }
    }
}