using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XTime.Wolf.Views
{
    public  class InformationArgs:EventArgs
    {
        public InformationArgs(string json)
        {
            JsonData = json;
            Title = string.Empty;
        }

        public InformationArgs(string json, string title)
        {
            JsonData = json;
            Title = title;
        }

        public string JsonData { get; private set; }

        public string Title { get; private set; }
    }
}
