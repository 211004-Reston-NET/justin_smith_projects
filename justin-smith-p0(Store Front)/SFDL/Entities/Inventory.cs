using System;
using System.Collections.Generic;

#nullable disable

namespace SFDL.Entities
{
    public partial class Inventory
    {
        public int StoreId { get; set; }
        public int ProdId { get; set; }
        public int Stock { get; set; }

        public virtual Product Prod { get; set; }
        public virtual Store Store { get; set; }
    }
}
