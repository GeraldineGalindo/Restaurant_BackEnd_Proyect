using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurante_Proyecto.Models;
using Restaurante_Proyecto.Services;

namespace Restaurante_Proyecto.Controllers
{
    [Route("api/Restaurant/{restaurantId:int}/Dish")]
    [ApiController]
    public class DishController : ControllerBase
    {
        private IDishService dishService;
        public DishController(IDishService dishService)
        {
            this.dishService = dishService;
        }
        // GET: api/Dish
        [HttpGet]
        public ActionResult<IEnumerable<Dish>> GetDishes(int restaurantId)
        {
            try
            {
                return Ok(dishService.GetDishes(restaurantId));
            }
            catch
            {
                throw new Exception("Not possible to show");
            }
        }

        [HttpGet("{id:int}")]
        public ActionResult<Dish> GetDish(int id, int restaurantId)
        {
            try
            {
                return Ok(dishService.GetDish(restaurantId,id));
            }
            catch
            {
                throw new Exception("Not possible to show");
            }
        }

        [HttpPost]
        public ActionResult<Dish> Post([FromBody] Dish dish, int restaurantId)
        {
            try
            {
                return Ok(dishService.CreateDish(restaurantId, dish));
            }
            catch
            {
                throw new Exception("Not possible to show");
            }
        }

        // PUT: api/Dish/5
        [HttpPut("{id:int}")]
        public ActionResult<Dish> PutDish(int id, [FromBody] Dish dish, int restaurantId)
        {
            try
            {
                return Ok(dishService.UpdateDish(restaurantId, id, dish));
            }
            catch
            {
                throw new Exception("Not possible to show");
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id:int}")]
        public ActionResult<bool> DeleteDish(int id, int restaurantId)
        {
            try
            {
                return Ok(dishService.DeleteDish(restaurantId, id));
            }
            catch
            {
                throw new Exception("Not possible to show");
            }
        }
    }
}
