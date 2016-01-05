using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.DataModel
{
    public partial class AdminUser
    {
        public int AdminID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Name { get; set; }
        public string AdminType { get; set; }
        public bool Status { get; set; }
    }
}