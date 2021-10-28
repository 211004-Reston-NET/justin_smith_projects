using System;
using System.Collections.Generic;

#nullable disable

namespace SFDL.Entities
{
    public partial class SOrder
    {
        public int? OrderId { get; set; }
        public int? StoreId { get; set; }
        public int? CustId { get; set; }
        public int? Price { get; set; }
    }
}
