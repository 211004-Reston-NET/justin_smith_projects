using System;
using System.Collections.Generic;

namespace SFModels
{
    public class Inventory
    {
        public int StoreId { get; set; }
        public int ProdId { get; set; }
        public int Stock { get; set; }
        private Product _prod = new Product();
        public virtual Product Prod
        {
            get
            {
                return _prod;
            }
            set
            {
                _prod = value;
            }
        }

        private Store _store = new Store();
        public virtual Store Store
        {
            get
            {
                return _store;
            }
            set
            {
                _store = value;
            }

        }


        public override string ToString()
        {
            return $"StoreId: {StoreId}\nProductId: {ProdId}\nStock: {Stock}";
        }
    }
}
