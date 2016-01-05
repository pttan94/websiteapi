using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.DataModel
{
    public partial class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public string Address { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PaymentMethod { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public decimal Total { get; set; }
        public System.DateTime DateReg { get; set; }
    }
}