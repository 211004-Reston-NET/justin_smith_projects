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
    public class StoreBL : IStoreBL
    {
        private IRepository _repo;
        /// <summary>
        ///  Defining dependencies this class needs to operate
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public StoreBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        // public Store AddStore(Store p_store)
        // {
        //     if (p_store.StoreName == null || p_store.StoreAddress == null)
        //     {
        //         throw new Exception("You must have a value in all of the properties of the store class");
        //     }

        //     return _repo.AddStore(p_store);}
        

        public List<Store> GetAllStore()
        {
            //Maybe my business operation needs to capitalize every name of a store
            List<Store> listOfStore = _repo.GetAllStore();
            for (int i = 0; i < listOfStore.Count; i++)
            {
                listOfStore[i].StoreName = listOfStore[i].StoreName.ToLower(); 
            }

            return listOfStore;
        }

        public List<Store> GetStore(string p_name)
        {
            List<Store> listOfStore = _repo.GetAllStore();
            
            //Select method will give a list of boolean if the condition was true/false
            //Where method will give the actual element itself based on some condition
            //ToList method will convert into List that our method currently needs to return.
            //ToLower will lowercase the string to make it not case sensitive
            return listOfStore.Where(store => store.StoreName.ToLower().Contains(p_name.ToLower())).ToList();
        }

        //  public List<Store> GetStore(int p_name)
        // {
        //     List<Store> listOfStore = _repo.GetAllStore();
            
        //     //Select method will give a list of boolean if the condition was true/false
        //     //Where method will give the actual element itself based on some condition
        //     //ToList method will convert into List that our method currently needs to return.
        //     //ToLower will lowercase the string to make it not case sensitive
        //     return listOfStore.Where(store => store.StoreId == p_name).ToList();
        // }
        
        public List<Store> GetStoreById(int p_id)
        {
            List<Store> storeFound = _repo.GetStoreById(p_id);
            if (storeFound == null)
            {
                throw new Exception("Store was not found!");
            }
            return storeFound;
        }
    }
}