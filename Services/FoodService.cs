using POS_server.Models;
using POS_server.Repositories;

namespace POS_server.Services
{
    public class FoodsService : IFoodsService
    {
        private IFoodsRepository _foodRepository;
        public FoodsService(IFoodsRepository foodsRepository)
        {
            _foodRepository = foodsRepository;
        }
        public List<Food> GetFoods()
        {
            return _foodRepository.GetFoods();

        }

        public List<Food> GetFoodsByCategory(string restaurantId, string categoryId)
        {
            return _foodRepository.GetFoodsByCategory(restaurantId, categoryId);
        }


        public Food GetFoodsDetail(string id)
        {
            return _foodRepository.GetFoodsDetail(id);
        }

        public async Task<string> AddFood(Food food)
        {
            return await _foodRepository.AddFood(food);
        }
    }

}