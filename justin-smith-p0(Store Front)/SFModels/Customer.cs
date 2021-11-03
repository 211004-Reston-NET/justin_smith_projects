using System;
using System.Collections.Generic;

namespace SFModels
{
    public class Customer
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get; set; }
        public string CustEmail { get; set; }
        public string CustPhone { get; set; }

        public override string ToString()
        {
            return $"ID: {CustId} \nName: {CustName}\nAddress: {CustAddress} \nEmail: {CustEmail} \nPhone: {CustPhone}";
        }

    }
}
