using System;
using System.Collections.Generic;
using System.Linq;
using SFDL;
using SFModels;

namespace SFBL
{
    /// <summary>
    /// Handles all the business logic for the our store application
    /// They are in charge of further processing/sanitizing/furthur validation of data
    /// Any Logic
    /// </summary>
    public class SOrderBL : ISOrderBL
    {
        private IRepository _repo;
        /// <summary>
        ///  Defining dependencies this class needs to operate
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public SOrderBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public List<SOrder> GetCustomerOrderById(int p_id)
        {
            List<SOrder> orderFound = _repo.GetCustomerOrderById(p_id);
            if (orderFound == null)
            {
                throw new Exception("Order was not found!");
            }
            return orderFound;
        }

        public List<SOrder> GetStoreOrderById(int p_id)
        {
            List<SOrder> orderFound = _repo.GetStoreOrderById(p_id);
            if (orderFound == null)
            {
                throw new Exception("Order was not found!");
            }
            return orderFound;
        }

        // public List<Inventory> GetInventoryById(int p_id)
        // {
        //     Inventory invFound = _repo.GetInventoryById(p_id);
        //     if (invFound == null)
        //     {
        //         throw new Exception("Store Inventory was not found!");
        //     }
        //     return invFound;
        // }
    }
}
