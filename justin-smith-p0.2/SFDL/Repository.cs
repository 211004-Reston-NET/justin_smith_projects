using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using SFModels;

namespace SFDL
{
    
    public class Repository
    {
        private const string _filepath = "./../RRDL/Database/store.json";
        private string _jsonString;
        
        public Store AddStore(Store p_store)
        {
            List<Store> listOfStores = GetAllStore();
            listOfStores.Add(p_store);

            _j
        }
        
        public List<Store> GetAllStore(){
            _jsonString = File.ReadAllText(_filepath);

            return JsonSerializer.Deserialize<List<Store>>(_jsonString);
        }
    }
}
