using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.DataModel
{
    public partial class News
    {
        public int NewsID { get; set; }
        public string Title { get; set; }
        public string MetaDescription { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}