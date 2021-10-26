using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace SFModels
{
    public class Store
    {
        public string Name{ get; set; }
        public string Address { get; set; }

        public string Phone { get; set;}
        
        public List<string> Products { get; set; }

        public List<string> Orders { get; set; }

    }
}
