using System;
using System.Collections.Generic;
using System.Linq;
using SFDL;
using SFModels;

namespace SFBL
{
    /// <summary>
    /// Handles all the business logic for the our customer application
    /// They are in charge of further processing/sanitizing/furthur validation of data
    /// Any Logic
    /// </summary>
    public class CustomerBL : ICustomerBL
    {
        private IRepository _repo;
        /// <summary>
        ///  Defining dependencies this class needs to operate
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public CustomerBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public Customer AddCustomer(Customer p_customer)
        {
            if (p_customer.CustName == null || p_customer.CustAddress == null)
            {
                throw new Exception("You must have a value in all of the properties of the customer class");
            }

            return _repo.AddCustomer(p_customer);
        }
        

        public List<Customer> GetAllCustomer()
        {
            //Maybe my business operation needs to capitalize every name of a Customer
            List<Customer> listOfCustomer = _repo.GetAllCustomer();
            for (int i = 0; i < listOfCustomer.Count; i++)
            {
                listOfCustomer[i].CustName = listOfCustomer[i].CustName.ToLower();
                 
                
            }

            return listOfCustomer;
        }

        public List<Customer> GetCustomerName(string p_name)
        {
            List<Customer> listOfCustomer = _repo.GetAllCustomer();
            
            //Select method will give a list of boolean if the condition was true/false
            //Where method will give the actual element itself based on some condition
            //ToList method will convert into List that our method currently needs to return.
            //ToLower will lowercase the string to make it not case sensitive
            return listOfCustomer.Where(customer => customer.CustName.ToLower().Contains(p_name.ToLower())).ToList();
        }

        public List<Customer> GetCustomerEmail(string p_name)
        {
            List<Customer> listOfCustomer = _repo.GetAllCustomer();
            
            //Select method will give a list of boolean if the condition was true/false
            //Where method will give the actual element itself based on some condition
            //ToList method will convert into List that our method currently needs to return.
            //ToLower will lowercase the string to make it not case sensitive
            return listOfCustomer.Where(customer => customer.CustEmail.ToLower().Contains(p_name.ToLower())).ToList();
        }

        
        
        public Customer GetCustomerById(int p_id)
        {
            Customer custFound = _repo.GetCustomerById(p_id);
            // if (custFound == null)
            // {
            //     throw new Exception("Customer was not found!");
            // }
            return custFound;
        }
    }
}