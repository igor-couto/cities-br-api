using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CitiesBr.Model
{
    public class State
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonIgnore]
        public ObjectId _id {get; set;}
        public string Name {get;set;}
        public string Region {get; set;}
        public string Abbreviation {get; set;}
        public string Capital {get; set;}
        public int NumberOfCities {get; set;}
    }
}