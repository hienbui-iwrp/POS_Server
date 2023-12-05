using Microsoft.AspNetCore.Mvc;
using POS_server.Models;
using POS_server.Repositories;

namespace POS_server.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FoodController : ControllerBase
    {

        private readonly IFoodsRepository _repository;
        [ActivatorUtilitiesConstructor]
        public FoodController(IFoodsRepository foodsRepository)
        {
            _repository = foodsRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetFoods());
        }


        [HttpGet("restaurant/{restaurantId}")]
        public IActionResult GetByCategory(string restaurantId, string? categoryId = "")
        {
            return Ok(_repository.GetFoodsByCategory(restaurantId, categoryId));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Food payload)
        {
            return Ok(_repository.AddFood(payload));
        }

        [HttpPost("{id}")]
        public IActionResult Put(string id, [FromBody] Food payload)
        {
            _repository.AddFood(payload);
            return Ok();
        }
    }
}

