using Restaurante_Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante_Proyecto.Services
{
    public interface IDishService
    {
        Dish GetDish(int idRestaurant, int idDish);
        IEnumerable<Dish> GetDishes(int idRestaurant);
        bool DeleteDish(int idRestaurant, int idDish);
        Dish CreateDish(int idRestaurant, Dish dish);
        Dish UpdateDish(int idRestaurant, int idDish, Dish dish);

    }
}
