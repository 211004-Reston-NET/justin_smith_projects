﻿using System;

namespace SFModels
{
    public class Customer
    {
        public string Name {get; set;}
        public string Address {get; set;}
        public string Email {get; set;}
        public string Phone {get; set;}

        public List<Order> Orders {get; set;}


        

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
