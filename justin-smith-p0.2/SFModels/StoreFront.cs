using System;

namespace SFModels
{
    public class StoreFront
    {
        public string Name {get; set;}
        public string Address {get; set;}
        public List<Products> Products {get; set;}
        public List<Orders> Orders {get; set;}


        

        // private string _city;
        // public string City
        // {
        //     get { return _city; }
        //     set {
        //             if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
    
        //                 throw new Exception("City can only hold letters!");
        //             _city = value;

                    
        //         }
        // }
        

    }
}
