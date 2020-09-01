using System.Text.Json.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class City : IEntity
    {
        [BsonId]
        [JsonIgnore]
        public int Id {get; set;}
        public string Name { get; set; }
        public int Population { get; set; }
        public string State { get; set; }
        public string Microregion { get; set; }
        public string Mesoregion { get; set; }
        public string Region { get; set; }
        public bool? IsCapital { get; set; }
        public bool? IsNationalCapital { get; set; }
    }
}