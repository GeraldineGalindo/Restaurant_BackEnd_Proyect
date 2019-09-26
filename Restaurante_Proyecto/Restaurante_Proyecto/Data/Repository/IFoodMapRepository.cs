using Restaurante_Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante_Proyecto.Data.Repository
{
    public interface IFoodMapRepository
    {
        //Restaurant's Methods
        List<Restaurant> GetRestaurants();
        Restaurant GetRestaurant(int id);
        bool DeleteRestaurant(int id);
        Restaurant CreateRestaurant(Restaurant restaurant);
        Restaurant UpdateRestaurant(int id, Restaurant restaurant);

        //Dishes Methods
        Dish GetDish(int idRestaurant, int idDish);
        IEnumerable<Dish> GetDishes(int idRestaurant);
        bool DeleteDish(int idRestaurant, int idDish);
        Dish CreateDish(Dish dish);
        Dish UpdateDish(int idRestaurant, int idDish, Dish dish);
    }
}
