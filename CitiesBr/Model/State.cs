using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CitiesBr.Model
{
    public class State
    {
        public ObjectId _id {get; set;}
        public string Name {get;set;}
        public string Region {get; set;}
        public int Cities {get; set;}
    }
}