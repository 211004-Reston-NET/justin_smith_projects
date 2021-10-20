using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace SFModels
{
    public class Orders
    {
        public string Location{ get; set; }

        public string Customer{ get; set; }
        public double Price { get; set; }
        
        public List<string> LineItems { get; set; }

    }
}
