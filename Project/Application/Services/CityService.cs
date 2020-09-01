using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using System.Linq;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class CityService : ICityService
    {
        private IMongoCollection<City> _cityCollection;

        public CityService() 
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var _database = client.GetDatabase("citiesbr");

            _cityCollection = _database.GetCollection<City>("cities");
        }

        internal IEnumerable<City> GetAll()
            => _cityCollection.Find(new BsonDocument()).ToList();
        
        internal City GetCityById(int id)
            => _cityCollection.Find(new BsonDocument("Id", id )).FirstOrDefault();

        internal City GetCityByName(string name)
            => _cityCollection.Find(new BsonDocument("Name", name )).FirstOrDefault();

        internal City GetRandom()
            => _cityCollection.AsQueryable().Sample(1).FirstOrDefault();
    }    
}