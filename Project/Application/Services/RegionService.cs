using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Linq;
using System;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class RegionService : IRegionService
    {
        private IMongoCollection<Region> _regionCollection;

        public RegionService() 
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var _database = client.GetDatabase("citiesbr");

            _regionCollection = _database.GetCollection<Region>("regions");
        }

        internal IEnumerable<Region> GetAll()
            => _regionCollection.Find(new BsonDocument()).ToList();
        
        internal Region GetCityById(int id)
            => _regionCollection.Find(new BsonDocument("Id", id )).FirstOrDefault();

        internal Region GetCityByName(string name)
            => _regionCollection.Find(new BsonDocument("Name", name )).FirstOrDefault();

        internal Region GetStateByAbbreviation(string abbreviation)
            => _regionCollection.Find(new BsonDocument("Abbreviation", abbreviation)).FirstOrDefault();

        internal Region GetRandom()
        {
            Random random = new Random();  
            var documentsCount = (int) _regionCollection.CountDocuments(x => true);
            var elementAt = random.Next(0, documentsCount); 

            return _regionCollection.AsQueryable().ElementAt(elementAt);
        }
    }    
}