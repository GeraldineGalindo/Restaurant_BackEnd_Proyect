using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurante_Proyecto.Data.Repository;
using Restaurante_Proyecto.Models;

namespace Restaurante_Proyecto.Services
{
    public class DishService : IDishService
    {
        private IFoodMapRepository foodRepository;
        public DishService(IFoodMapRepository foodRepository)
        {
            this.foodRepository = foodRepository;
        }
        public Dish CreateDish(int idRestaurant, Dish dish)
        {
            var rest = ValidateRestaurant(idRestaurant);
            if (idRestaurant != dish.RestautantId)
                throw new Exception("The Restaurant Id needs to be the same as the dish one");
            dish.RestautantId = idRestaurant;
            var dishCreated = foodRepository.CreateDish(dish);
            return dishCreated;
        }

        public bool DeleteDish(int idRestaurant, int idDish)
        {
            var rest = ValidateRestaurant(idRestaurant);
            return foodRepository.DeleteDish(idRestaurant, idDish);
        }

        public Dish GetDish(int idRestaurant, int idDish)
        {
            var rest = ValidateRestaurant(idRestaurant);
            return foodRepository.GetDish(idRestaurant, idDish);
        }

        public IEnumerable<Dish> GetDishes(int idRestaurant)
        {
            return foodRepository.GetDishes(idRestaurant);
        }

        public Dish UpdateDish(int idRestaurant, int idDish, Dish dish)
        {
            var restaurant = ValidateRestaurant(idRestaurant);
            if(idDish !=dish.Id)
            {
                throw new Exception("Id of the dish in URL needs to be the same that the object");
            }
            if(idRestaurant!=restaurant.Id)
            {
                throw new Exception("This restaurant has never met this dish");
            }
            dish.Id = idDish;
            dish.RestautantId = idRestaurant;
            return foodRepository.UpdateDish(idRestaurant, idDish, dish);
        }
        public Restaurant ValidateRestaurant(int idRestaurant)
        {
            var restaurant = foodRepository.GetRestaurant(idRestaurant);
            if (restaurant == null)
                throw new Exception("Not found");
            return restaurant;
        }
    }
}
