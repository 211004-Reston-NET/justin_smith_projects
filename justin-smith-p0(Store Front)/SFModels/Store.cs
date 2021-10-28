using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace SFModels
{
    public class Store
    {
        public Store(){
            this.Name = "Name";
            this.Address = "Address";
        }
        public int Id {get; set;}
        public string Name{ get; set; }
        public string Address { get; set; }

        public string Phone { get; set;}
        
        public List<string> Products { get; set; }

        public List<string> Orders { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} \nName: {Name}\nState: {Address}";
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



