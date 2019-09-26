using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurante_Proyecto.Data.Repository;
using Restaurante_Proyecto.Models;

namespace Restaurante_Proyecto.Services
{
    public class RestaurantService : IRestaurantService
    {
        private IFoodMapRepository foodRepository;
        public RestaurantService(IFoodMapRepository foodRepository)
        {
            this.foodRepository = foodRepository;
        }
        public Restaurant CreateRestaurant(Restaurant restaurant)
        {
            var restaurantCreated = foodRepository.CreateRestaurant(restaurant);
            return restaurantCreated;
        }

        public bool DeleteRestaurant(int id)
        {
            var restaurant = GetRestaurant(id);
            return foodRepository.DeleteRestaurant(id);
        }

        public Restaurant GetRestaurant(int id)
        {
            var restaurant = foodRepository.GetRestaurant(id);
            if (restaurant == null)
                throw new Exception("Not found Restaurant");
            return restaurant;
        }

        public IEnumerable<Restaurant> GetRestaurants()
        {
            return foodRepository.GetRestaurants().OrderBy(r=>r.Id);
        }

        public Restaurant UpdateRestaurant(int id, Restaurant restaurant)
        {
            var restaurantExists = foodRepository.GetRestaurant(id);
            return foodRepository.UpdateRestaurant(id, restaurant);
        }

    }
}
