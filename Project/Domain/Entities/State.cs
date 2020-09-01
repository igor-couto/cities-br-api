using System.Text.Json.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class State : IEntity
    {
        [BsonId]
        [JsonIgnore]
        public int Id {get; set;}
        public string Name {get;set;}
        public string Region {get; set;}
        public string Abbreviation {get; set;}
        public string Capital {get; set;}
        public int NumberOfCities {get; set;}
    }
}