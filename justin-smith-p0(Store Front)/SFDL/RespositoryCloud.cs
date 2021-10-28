using System.Collections.Generic;
using System.Linq;
using Entity = SFDL.Entities;
using Model = SFModels;

namespace SFDL
{
    public class RespositoryCloud : IRepository
    {
        private Entity.SFDatabaseContext _context;
        public RespositoryCloud(Entity.SFDatabaseContext p_context) 
        {
            _context = p_context;
        }

        public Model.Store AddStore(Model.Store p_store)
        {
            _context.Stores.Add
            (
                new Entity.Store()
                {
                    StoreName = p_store.Name,
                    StoreAddress = p_store.Address,
                    StorePhone = p_store.Phone
                   
                }
            );

            //This method will save the changes made to the database
            _context.SaveChanges();

            return p_store;
        }

        public List<Model.Store> GetAllStore()
        {
            //Method Syntax
            return _context.Store.Select(store => 
                new Model.Store()
                {
                    Name = store.StoreName,
                    Address = store.StoreAddress,
                }
            ).ToList();


            //Query Syntax
            // var result = (from rest in _context.Restaurants
            //             select rest);

            // List<Model.Restaurant> listOfRest = new List<Model.Restaurant>();
            // foreach (var rest in result)
            // {
            //     listOfRest.Add(new Model.Restaurant(){
            //         Name = rest.RestName,
            //         State = rest.RestState,
            //         City = rest.RestCity,
            //         Id = rest.RestId
            //     });
            // }

            // return listOfRest;
        }

        public Model.Store GetStoreById(int p_id)
        {
            Entity.Store storeToFind = _context.Stores.Find(p_id);
            
            return new Model.Store()
            {
                Id = storeToFind.StoreId,
                Name = storeToFind.StoreName,
                Address = storeToFind.StoreAddress,
                //This is the super ugly code that I avoided during demo that you need right now
                //So if you are lazy instead of doing a mapper class
                //This is all you need to do
                //Select statement to convert each element to Model.Review
                //ToList to convert it into a List collection instead of IEnumerable
                
                
                // Reviews = storeToFind.Reviews.Select(rev => new Model.Review(){ 
                //     Id = rev.RevId,
                //     Rating = rev.RevRating
                // }).ToList()
            };
        }





        // public List<Model.Review> GetAllReview(Model.Restaurant p_rest)
        // {
        //     //Query syntax
        //     // var result = (from rev in _context.Reviews
        //     //             where rev.RestId == p_rest.Id
        //     //             select rev);

        //     // //Mapping the Queryable<Entity.Review> into a list<Model.Review>
        //     // List<Model.Review> listOfReview = new List<Model.Review>();
        //     // foreach (Entity.Review rev in result)
        //     // {
        //     //     listOfReview.Add(new Model.Review(){
        //     //         Id = rev.RevId,
        //     //         Rating = rev.RevRating,
        //     //         RestId = rev.RestId
        //     //     });
        //     // }

        //     // return listOfReview;

        //     //Method Syntax - since this looks cleaner
        //     return _context.Reviews
        //         .Where(rev => rev.RevId == p_rest.Id) //We find the reviews that have matching restId
        //         .Select(rev => new Model.Review(){ //Convert it into Model.Review
        //           Id = rev.RevId,
        //           Rating = rev.RevRating,
        //           Restaurant = p_rest
        //         })
        //         .ToList(); //Convert it into List
        
    }
}