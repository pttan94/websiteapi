using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.DataModel
{
    public partial class ProductImage
    {
        public int ProductImageID { get; set; }
        public int ProductID { get; set; }
        public string Image { get; set; }
    }
}