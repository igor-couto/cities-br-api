﻿using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CitiesBr.Model
{
    public class City
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonIgnore]
        public ObjectId Id {get; set;}
        public string Name { get; set; }
        public int Population { get; set; }
        public string State { get; set; }
        public bool IsCapital { get; set; }
    }
}