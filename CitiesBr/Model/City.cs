using MongoDB.Bson;

namespace CitiesBr.Model
{
    public class City
    {
        public ObjectId _id {get; set;}
        public string Name { get; set; }
        public int Population { get; set; }
        public int State { get; set; }
    }
}