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
    public class InventoryBL : IInventoryBL
    {
        private IRepository _repo;
        /// <summary>
        ///  Defining dependencies this class needs to operate
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public InventoryBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        // public List<Inventory> GetInventoryById(int p_id)
        // {
        //     throw new NotImplementedException();
        // }


        public List<Inventory> GetInventoryById(int p_id)
        {
            List<Inventory> invFound = _repo.GetInventoryById(p_id);
            if (invFound == null)
            {
                throw new Exception("Store Inventory was not found!");
            }
            return invFound;
        }
    }
}