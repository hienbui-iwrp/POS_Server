using POS_server.Models;

namespace POS_server.Repositories
{
    public interface IFoodsRepository
    {
        public List<Food> GetFoods();
        public Food GetFoodsDetail(string id);
        public Task<string> AddFood(Food food);
        public List<Food> GetFoodsByCategory(string restaurantId, string categoryId);
    }
}