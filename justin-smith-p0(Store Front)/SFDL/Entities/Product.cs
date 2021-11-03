using System;
using System.Collections.Generic;

#nullable disable

namespace SFDL.Entities
{
    public partial class Product
    {
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public int ProdPrice { get; set; }
        public string ProdDescription { get; set; }
    }
}
