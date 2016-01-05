using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.DataModel
{
    public partial class Setting
    {
        public int SettingID { get; set; }
        public string SettingName { get; set; }
        public string SettingKeyWord { get; set; }
        public string SettingContent { get; set; }
        public bool Status { get; set; }
    }
}