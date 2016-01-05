using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.DataModel
{
    public partial class Cart
    {
        public int CartID { get; set; }
        public int ProductID { get; set; }
        public string ProductImage { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string CustomerID { get; set; }
    }
}