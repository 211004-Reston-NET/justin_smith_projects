using System;
using System.Collections.Generic;

#nullable disable

namespace SFDL.Entities
{
    public partial class Store
    {
        public Store()
        {
            SOrders = new HashSet<SOrder>();
        }

        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
        public string StorePhone { get; set; }

        public virtual ICollection<SOrder> SOrders { get; set; }
    }
}
