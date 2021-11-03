using System;
using System.Collections.Generic;

#nullable disable

namespace SFDL.Entities
{
    public partial class SOrder
    {
        public int OrderId { get; set; }
        public int StoreId { get; set; }
        public int CustId { get; set; }
        public int OrderPrice { get; set; }

        public virtual Customer Cust { get; set; }
        public virtual Store Store { get; set; }
    }
}
