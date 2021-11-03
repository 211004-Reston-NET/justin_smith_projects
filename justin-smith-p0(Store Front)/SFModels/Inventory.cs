using System;
using System.Collections.Generic;

namespace SFModels
{
    public class Inventory
    {
        public int StoreId { get; set; }
        public int ProdId { get; set; }
        public int Stock { get; set; }

        public virtual Product Prod { get; set; }
        public virtual Store Store { get; set; }


        public override string ToString()
        {
            return $"StoreId: {StoreId}\nProductId: {ProdId}\nStock: {Stock}";
        }
    }
}
