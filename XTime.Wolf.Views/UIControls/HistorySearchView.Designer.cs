namespace XTime.Wolf.Views.UIControls
{
    partial class HistorySearchView
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SplitForm = new System.Windows.Forms.SplitContainer();
            this.searchFormControl = new XTime.Wolf.Views.UIControls.SearchForm();
            this.showDataBrowerControl = new XTime.Wolf.Views.UIControls.ShowDataBrower();
            ((System.ComponentModel.ISupportInitialize)(this.SplitForm)).BeginInit();
            this.SplitForm.Panel1.SuspendLayout();
            this.SplitForm.Panel2.SuspendLayout();
            this.SplitForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitForm
            // 
            this.SplitForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitForm.Location = new System.Drawing.Point(0, 0);
            this.SplitForm.Name = "SplitForm";
            this.SplitForm.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitForm.Panel1
            // 
            this.SplitForm.Panel1.Controls.Add(this.searchFormControl);
            // 
            // SplitForm.Panel2
            // 
            this.SplitForm.Panel2.Controls.Add(this.showDataBrowerControl);
            this.SplitForm.Size = new System.Drawing.Size(960, 518);
            this.SplitForm.SplitterDistance = 40;
            this.SplitForm.TabIndex = 0;
            // 
            // searchFormControl
            // 
            this.searchFormControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchFormControl.Location = new System.Drawing.Point(0, 0);
            this.searchFormControl.Name = "searchFormControl";
            this.searchFormControl.Size = new System.Drawing.Size(960, 40);
            this.searchFormControl.TabIndex = 0;
            // 
            // showDataBrowerControl
            // 
            this.showDataBrowerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showDataBrowerControl.Location = new System.Drawing.Point(0, 0);
            this.showDataBrowerControl.Name = "showDataBrowerControl";
            this.showDataBrowerControl.Size = new System.Drawing.Size(960, 474);
            this.showDataBrowerControl.TabIndex = 0;
            // 
            // HistorySearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SplitForm);
            this.Name = "HistorySearchView";
            this.Size = new System.Drawing.Size(960, 518);
            this.SplitForm.Panel1.ResumeLayout(false);
            this.SplitForm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitForm)).EndInit();
            this.SplitForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitForm;
        private SearchForm searchFormControl;
        private ShowDataBrower showDataBrowerControl;
    }
}
