using System.Text.Json.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class District : IEntity
    {
        [BsonId]
        [JsonIgnore]
        public int Id {get; set;}
        public string Name {get;set;}
        public string City {get;set;}
    }
}