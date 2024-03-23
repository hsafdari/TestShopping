using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Shopping.API.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public int? id { get; set; }
        public string title { get; set; }
        public decimal price { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public Rating rating { get; set; }
    }
    public class Rating {
        public double rate { get; set; }
        public int count { get; set; }
    }
}
