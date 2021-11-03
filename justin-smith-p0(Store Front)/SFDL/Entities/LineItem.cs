using System;
using System.Collections.Generic;

#nullable disable

namespace SFDL.Entities
{
    public partial class LineItem
    {
        public int ProdId { get; set; }
        public int Quantity { get; set; }
        public int? OrderId { get; set; }
        public int? LiPrice { get; set; }

        public virtual SOrder Order { get; set; }
        public virtual Product Prod { get; set; }
    }
}
