using System;
using System.Text.RegularExpressions;

namespace SFModels
{
    public class Product
    {
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public int ProdPrice { get; set; }
        public string ProdDescription { get; set; }

        public override string ToString()
        {
            return $"ID: {ProdId}\nName: {ProdName}\nPrice: {ProdPrice} \nDescription: {ProdDescription}";
        }
    }
}


