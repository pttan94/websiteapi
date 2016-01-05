using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.DataModel
{
    public partial class ProductCategory
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string KeyWord { get; set; }
        public string Image { get; set; }
        public int ParentID { get; set; }
        public int SortOrder { get; set; }
        public Nullable<System.DateTime> RegDate { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string MetaDescription { get; set; }
        public string Description { get; set; }
    }
}