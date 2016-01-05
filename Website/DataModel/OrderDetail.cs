using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.DataModel
{
    public partial class OrderDetail
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public Nullable<decimal> Price { get; set; }
    }
}