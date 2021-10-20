using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using SFModels;


namespace SFDL
{
    public class Respository : IRepository
    {   
        private const string _filepath = "./../SFDL/Database/";
        private string _jsonString;
        public Store AddStore(Store p_store)
        {
            List<Store> listOfStores = GetAllStores();
            listOfStores.Add(p_store);

            _jsonString = JsonSerializer.Serialize(listOfStores,new JsonSerializerOptions{WriteIndented=true});

            File.WriteAllText(_filepath+"Store.json",_jsonString);

            return p_store;
        }

        public List<Store> GetAllStores()
        {
            try
            {
                _jsonString = File.ReadAllText(_filepath+"Store.json");
            }
            catch(System.IO.FileNotFoundException)
            {
                Store newStore = new Store();
                List<Store> listOfStr = new List<Store>();
                listOfStr.Add(newStore);

                File.WriteAllText(_filepath+"Store.json");
            }
            catch(SystemException ex)
            {
                throw ex;
            }
            return JsonSerializer.Deserialize<List<Store>>(_jsonString);
        }
    }
}
