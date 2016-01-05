using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.DataModel
{
    public partial class NewsCategory
    {
        public int NewsCategoryID { get; set; }
        public string Title { get; set; }
        public string MetaDescription { get; set; }
        public string Description { get; set; }
        public int ParentID { get; set; }
        public bool Status { get; set; }
        public string KeyWord { get; set; }
    }
}