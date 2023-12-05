using POS_server.Models;

namespace POS_server.Services
{
    public interface IFoodsService
    {
        public List<Food> GetFoods();
        public Food GetFoodsDetail(string id);
        public Task<string> AddFood(Food food);

        public List<Food> GetFoodsByCategory(string restaurantId, string categoryId);
    }
}