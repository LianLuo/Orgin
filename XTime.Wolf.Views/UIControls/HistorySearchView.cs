using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XTime.Wolf.Views.UIControls
{

    public partial class HistorySearchView : UserControl
    {
        public HistorySearchView()
        {
            InitializeComponent();
            searchFormControl.RefreshData += showDataBrowerControl.RefreshData;
        }
    }
}
