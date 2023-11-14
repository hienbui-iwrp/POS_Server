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
    }
}