using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using POS_server.Models;
using POS_server.Repositories;

namespace POS_server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodController : ControllerBase
    {

        private readonly IFoodsRepository _repository;
        [ActivatorUtilitiesConstructor]
        public FoodController(IFoodsRepository foodsRepository)
        {
            _repository = foodsRepository;
        }

        [HttpGet("get")]
        public List<Food> GetFood()
        {
            return _repository.GetFoods();
        }
        
    }
}