using System.Text.Json.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using CitiesBR.Domain.Interfaces;

namespace CitiesBR.Domain.Entities
{
    public class Region : IEntity
    {
        [BsonId]
        [JsonIgnore]
        public int Id {get; set;}
        public string Name {get;set;}
        public string Abbreviation {get; set;}
    }
}