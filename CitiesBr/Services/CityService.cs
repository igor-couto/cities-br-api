using System;
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson;
using CitiesBr.Model;
using CitiesBr.Schema;
using System.Linq;

namespace CitiesBr.Services
{
    public class CityService
    {
        private IMongoCollection<City> _cityCollection;

        public CityService() 
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var _database = client.GetDatabase("citiesbr");

            _cityCollection = _database.GetCollection<City>("cities");
        }

        public List<City> GetAll()
        {
            return _cityCollection.Find(new BsonDocument()).ToList();
        }

        public List<City> GetCity(CityRequest request)
            {
            var city = _cityCollection.Find(x => true);

            if(!string.IsNullOrEmpty(request.Name))
            {
                city = _cityCollection.Find(x => x.Name == request.Name);
            }

            if(!string.IsNullOrEmpty(request.Population))
            {

            }

            if(request.IsCapital?? false)
            {
                city = _cityCollection.Find(x => x.IsCapital == true);
            }

            if(!string.IsNullOrEmpty(request.State))
            {
                city = _cityCollection.Find(x => x.State == request.State);
            }

            if(request.MaxResultCount != null)
            {
                city.Limit(request.MaxResultCount.Value);
            }

            if(request.Random?? false)
            {
                var random = new Random();  
                var documentsCount = (int) _cityCollection.CountDocuments(x => true);
                var elementAt = random.Next(0, documentsCount); 

                var aaa = _cityCollection.AsQueryable().ElementAt(elementAt);
            }
            
            if(request.RandomStatistic?? false)
            {

            }

            return city.ToList();
        }
    }    
}