using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurante_Proyecto.Models;

namespace Restaurante_Proyecto.Data.Repository
{
    public class FoodMapRepository : IFoodMapRepository
    {
        private List<Restaurant> restaurants;
        private List<Dish> dishes;
        public FoodMapRepository()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant(){ Id=1, Name="Suiza", Street="Av. Ballivian", AddressNumber=820, FoodStyle="International" }
            };
            dishes = new List<Dish>()
            {
                new Dish(){ Id=1, Name="Crab Cake", MainIngredient="Crab", Nationality="Greece", Size="Personal", Cost=70.50, RestautantId=1 }
            };
        }

        public Dish CreateDish(Dish dish)
        {
            var lastId = dishes.OrderByDescending(d => d.Id).FirstOrDefault().Id;
            var nextId = lastId == null ? 1 : lastId + 1;
            dish.Id = nextId;
            dishes.Add(dish);
            return dish;
        }

        public Restaurant CreateRestaurant(Restaurant restaurant)
        {
            var lastId = restaurants.OrderByDescending(r => r.Id).FirstOrDefault().Id;
            var nextId = lastId == null ? 1 : lastId + 1;
            restaurant.Id = nextId;
            restaurants.Add(restaurant);
            return restaurant;
        }

        public bool DeleteDish(int idRestaurant, int idDish)
        {
            var dishToDelete = dishes.Single(d => d.Id == idDish && d.RestautantId == idRestaurant);
            return dishes.Remove(dishToDelete);
        }

        public bool DeleteRestaurant(int id)
        {
            var restaurantToDelete = restaurants.Single(r => r.Id == id);
            return restaurants.Remove(restaurantToDelete);
        }

        public Dish GetDish(int idRestaurant, int idDish)
        {
            return dishes.SingleOrDefault(d => d.Id == idDish && d.RestautantId == idRestaurant);
        }

        public IEnumerable<Dish> GetDishes(int idRestaurant)
        {
            return dishes.Where(d => d.RestautantId == idRestaurant).OrderBy(d=>d.Id);
        }

        public Restaurant GetRestaurant(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);
        }

        public List<Restaurant> GetRestaurants()
        {
            return restaurants;
        }

        public Dish UpdateDish(int idRestaurant, int idDish, Dish dish)
        {
            var dishToUpdate = dishes.Single(d => d.Id == idDish && d.RestautantId == idRestaurant);
            dishToUpdate.Name = dish.Name;
            dishToUpdate.MainIngredient = dish.MainIngredient;
            dishToUpdate.Nationality = dish.Nationality;
            dishToUpdate.Size = dish.Size;
            return dishToUpdate;
        }

        public Restaurant UpdateRestaurant(int id, Restaurant restaurant)
        {
            var restaurantToUpdate = restaurants.Single(r => r.Id == id);
            restaurantToUpdate.Name = restaurant.Name;
            restaurantToUpdate.Street = restaurant.Street;
            restaurantToUpdate.AddressNumber = restaurant.AddressNumber;
            restaurantToUpdate.FoodStyle = restaurant.FoodStyle;
            return restaurantToUpdate;
        }
    }
}
