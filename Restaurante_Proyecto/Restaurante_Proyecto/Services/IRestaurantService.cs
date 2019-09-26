using Restaurante_Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante_Proyecto.Services
{
    public interface IRestaurantService
    {
        IEnumerable<Restaurant> GetRestaurants();
        Restaurant GetRestaurant(int id);
        Restaurant CreateRestaurant(Restaurant restaurant);
        bool DeleteRestaurant(int id);
        Restaurant UpdateRestaurant(int id, Restaurant restaurant);

    }
}
