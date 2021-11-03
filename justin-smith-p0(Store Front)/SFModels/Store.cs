using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace SFModels
{
    public class Store
    {
        // public Store(){
        //     this.StoreName = "Name";
        //     this.StoreAddress = "Address";
        //     this.StorePhone = "Phone";

        // }

        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
        public string StorePhone { get; set; }


        public override string ToString()
        {
            return $"ID: {StoreId}\nName: {StoreName}\nAddress: {StoreAddress} \nPhone: {StorePhone}";
        }






        //  //This is a field
        // private string _city;

        // //This is a property that uses the field called _city
        // public string City
        // {
        //     get { return _city; }
        //     set 
        //     {
        //         //Main idea - this Regex will find me any number inside of my string
        //         if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
        //         {
        //             //Will give the user an exception whenever you try to set the city field with a number
        //             throw new Exception("City can only hold letters!");
        //         }
        //         _city = value;
        //     }
        

    }
}



