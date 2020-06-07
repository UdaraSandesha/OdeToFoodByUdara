using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurentData : IRestaurentData
    {
        List<Restaurent> restaurents;
        public InMemoryRestaurentData()
        {
            restaurents = new List<Restaurent>()
            {
                new Restaurent{Id = 1, Name = "Sathira" ,Cuisine = CuisineType.Indian},
                new Restaurent{Id = 2, Name = "Odara" ,Cuisine = CuisineType.French},
                new Restaurent{Id = 3, Name = "Nirmala" ,Cuisine = CuisineType.Italian}
            };
        }
        public IEnumerable<Restaurent> GetAll()
        {
            return restaurents.OrderBy(r => r.Name);
        }
    }
}
