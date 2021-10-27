using System;
using System.Collections.Generic;
using SFDL;
using SFModels;

namespace SFBL
{
    public class StoreBL
    {
        private Repository _repo;
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it to switch out the implementation details we will be using
        /// But later in the lecture, we will point RRDL to cloud database
        /// </summary>
        /// <param name="p_repo"></param>

        public StoreBL(Repository p_repo){
            _repo = p_repo;
        }
        public List<Store> GetAllStore()
        {
            return _repo.GetAllStore();
        }
    }
}
