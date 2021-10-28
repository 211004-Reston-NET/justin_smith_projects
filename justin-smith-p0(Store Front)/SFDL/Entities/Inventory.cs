using System;
using System.Collections.Generic;

#nullable disable

namespace SFDL.Entities
{
    public partial class Inventory
    {
        public int? StoreId { get; set; }
        public int? ProdId { get; set; }
        public int? Quantity { get; set; }
    }
}
