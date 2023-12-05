
namespace POS_server.Schemas
{
    // [BsonIgnoreExtraElements]
    public class GetFoodResponse
    {
        
        public string? Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? Image { get; set; }
        public int? Supply { get; set; }
        public string? RestaurantId { get; set; }
        public string? Category { get; set; }
    }
}