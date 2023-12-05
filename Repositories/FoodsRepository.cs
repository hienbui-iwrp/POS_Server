using MongoDB.Driver;
using POS_server.Models;

namespace POS_server.Repositories
{
    public class FoodsRepository : IFoodsRepository
    {
        private IMongoCollection<Food> _foodCollection;

        public FoodsRepository(DatabaseSetting setting, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(setting.DatabaseName);
            _foodCollection = database.GetCollection<Food>(setting.FoodCollection);
        }
        public List<Food> GetFoods()
        {
            return _foodCollection.Find(s => true).ToList<Food>();
        }

        public List<Food> GetFoodsByCategory(string restaurantId, string categoryId)
        {

            if (categoryId == "")
                return _foodCollection.Find(s => s.RestaurantId == restaurantId).ToList<Food>();
            return _foodCollection.Find(s => s.RestaurantId == restaurantId && s.Category == categoryId).ToList<Food>();
        }


        public Food GetFoodsDetail(string id)
        {
            return _foodCollection.Find(s => s.Id == id).FirstOrDefault();
        }

        public async Task<string> AddFood(Food food)
        {
            await _foodCollection.InsertOneAsync(food);
            return food.Id;
        }

        // public int UpdateFood(string id, Food food)
        // {
        //     var filter = Builders<Food>.Filter
        //         .Eq(_food => _food.Id, id);
        //     var update = Builders<Food>.Update
        //         .Set(_food => _food, food);
        //     return _foodCollection.UpdateOne(filter, update);
        // }
    }
}