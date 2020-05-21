using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson;
using CitiesBr.Model;

namespace CitiesBr.Services
{
    public class StateService
    {
        private IMongoCollection<State> _stateCollection;

        public StateService() 
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var _database = client.GetDatabase("geoinfo");

            _stateCollection = _database.GetCollection<State>("states");
        }

        public List<State> GetAllStates()
        {
            return _stateCollection.Find(new BsonDocument()).ToList();
        }

        internal List<State> GetByAbbreviation(string abbreviation)
        {
            return _stateCollection.Find(new BsonDocument()).ToList();
        }

        internal List<State> GetByName(string name)
        {
            return _stateCollection.Find(new BsonDocument()).ToList();
        }
    }    
}

