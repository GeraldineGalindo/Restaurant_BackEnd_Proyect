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
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private IRestaurantService restaurantService;
        public RestaurantController(IRestaurantService restaurantService)
        {
            this.restaurantService = restaurantService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Restaurant>> GetRestaurants()
        {
            try
            {
                return Ok(restaurantService.GetRestaurants());
            }
            catch
            {
                throw new Exception("Not possible to show");
            }
        }
        [HttpGet("{id:int}")]
        public ActionResult<Restaurant> GetRestaurant(int id)
        {
            try
            {
                return Ok(restaurantService.GetRestaurant(id));
            }
            catch
            {
                throw new Exception("Not possible to show");
            }
        }
        [HttpDelete("{id:int}")]
        public ActionResult<bool> DeleteRestaurant(int id)
        {
            try
            {
                return Ok(restaurantService.DeleteRestaurant(id));
            }
            catch
            {
                throw new Exception("Not possible to show");
            }
        }

        [HttpPost]
        public ActionResult<Restaurant> PostRestaurant([FromBody] Restaurant restaurant)
        {
            try
            {
                return Ok(restaurantService.CreateRestaurant(restaurant));
            }
            catch
            {
                throw new Exception("Not possible to show");
            }
        }
        [HttpPut("{id:int}")]
        public ActionResult<Restaurant> PutRestaurant(int id, [FromBody] Restaurant restaurant)
        {
            try
            {
                return Ok(restaurantService.UpdateRestaurant(id, restaurant));
            }
            catch
            {
                throw new Exception("Not possible to show");
            }
        }
    }
}