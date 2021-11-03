using System;
using System.Collections.Generic;

#nullable disable

namespace SFDL.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            SOrders = new HashSet<SOrder>();
        }

        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get; set; }
        public string CustEmail { get; set; }
        public string CustPhone { get; set; }

        public virtual ICollection<SOrder> SOrders { get; set; }
    }
}
