using System;

namespace SFModels
{
    public class Order
    {
        public string LineItems {get; set;}
        public string OrderLocation {get; set;}
        public int Price {get; set;}
    


        

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
