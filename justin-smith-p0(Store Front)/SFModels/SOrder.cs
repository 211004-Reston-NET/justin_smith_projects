using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace SFModels
{
    public class SOrder
    {
        public int OrderId { get; set; }
        public int StoreId { get; set; }
        public int CustId { get; set; }
        public int OrderPrice { get; set; }

        public virtual Customer Cust { get; set; }
        public virtual Store Store { get; set; }

        public override string ToString()
        {
            return $"Order ID: {OrderId}\nStore ID: {StoreId}\nCustomer ID: {CustId} \n OrderPrice: {OrderPrice}";
        }

    }
}
