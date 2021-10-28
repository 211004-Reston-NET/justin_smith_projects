using System;
using System.Collections.Generic;

#nullable disable

namespace SFDL.Entities
{
    public partial class Customer
    {
        public int? CustId { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get; set; }
        public string CustEmail { get; set; }
        public string CustPhone { get; set; }
    }
}
