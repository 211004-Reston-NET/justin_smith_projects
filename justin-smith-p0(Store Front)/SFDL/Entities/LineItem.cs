using System;
using System.Collections.Generic;

#nullable disable

namespace SFDL.Entities
{
    public partial class LineItem
    {
        public int? OrderId { get; set; }
        public int? ProdId { get; set; }
        public int? Quantity { get; set; }
    }
}
