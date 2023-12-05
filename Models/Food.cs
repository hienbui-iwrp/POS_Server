using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace POS_server.Models
{
    // [BsonIgnoreExtraElements]
    public class Food
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("name")]
        public string? Name { get; set; }
        [BsonElement("price")]
        public int Price { get; set; }
        [BsonElement("image")]
        public string? Image { get; set; }
        [BsonElement("supply")]
        public int? Supply { get; set; }
        [BsonElement("restaurant_id")]
        public string? RestaurantId { get; set; }
        [BsonElement("category")]
        public string? Category { get; set; }
    }
}