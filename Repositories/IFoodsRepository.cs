using POS_server.Models;

namespace POS_server.Repositories
{
    public interface IFoodsRepository
    {
        public List<Food> GetFoods();
    }
}