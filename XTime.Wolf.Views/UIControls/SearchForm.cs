using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace XTime.Wolf.Views.UIControls
{
    public partial class SearchForm : UserControl
    {
        private Task task;

        public event EventHandler<InformationArgs> RefreshData;

        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           task = new Task(() =>
            {
                btnSearch.Enabled = false;
                var current = DateTime.Now;

                var startT = startTime.Value;
                var endT = endTime.Value;
                if ((endT < startT) || (current - startT).Days < 30)
                {
                    this.UrlData = "{Rows:{},Total:0}";
                }
                string jsonData = string.Format("importsExamineVo.recordBeginDate={0}&importsExamineVo.recordEndDate={1}&importsExamineVo.page={2}&importsExamineVo.pagesize={3}", startT.ToString("yyyy-MM-dd"), endT.ToString("yyyy-MM-dd"), 1, 25);
                this.UrlData = HttpWebHelper.PostToHttpServer("http://kq.chinasoftosg.com/workAttendance/importsExamineAction_getImportsEarlyExamine", jsonData, RequestMethod.POST);
            });
            task.ContinueWith((t1) => {
                var handler = RefreshData;
                if (handler != null)
                {
                    handler(this, new InformationArgs(this.UrlData, string.Format("{0}到{1}", startTime.Value.ToString("yyyy-MM-dd"), endTime.Value.ToString("yyyy-MM-dd"))));
                }
                btnSearch.Enabled = true;
            });
            task.Start();            
        }

    }
}
