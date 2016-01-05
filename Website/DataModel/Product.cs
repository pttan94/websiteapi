using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.DataModel
{
    public partial class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string KeyWord { get; set; }
        public string Image { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> PriceOld { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public bool Status { get; set; }
        public Nullable<System.DateTime> RegDate { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> CountView { get; set; }
        public string MetaDescription { get; set; }
        public string Description { get; set; }
    }
}