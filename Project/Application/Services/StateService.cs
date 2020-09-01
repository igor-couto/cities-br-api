using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Linq;
using System;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class StateService : IStateService
    {
        private IMongoCollection<State> _stateCollection;

        public StateService() 
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var _database = client.GetDatabase("citiesbr");

            _stateCollection = _database.GetCollection<State>("states");
        }

        internal List<State> GetAllStates()
            => _stateCollection.Find(new BsonDocument()).ToList();

        internal List<State> GetStateById(int id)
            => _stateCollection.Find(new BsonDocument("Id", id)).ToList();

        internal List<State> GetStateByName(string name)
            => _stateCollection.Find(new BsonDocument("Name", name)).ToList();

        internal List<State> GetStateByAbbreviation(string abbreviation)
            => _stateCollection.Find(new BsonDocument()).ToList();
        
        internal State GetRandom()
        {
            Random random = new Random();  
            var documentsCount = (int) _stateCollection.CountDocuments(x => true);
            var elementAt = random.Next(0, documentsCount); 

            return _stateCollection.AsQueryable().ElementAt(elementAt);
        }
    }    
}

