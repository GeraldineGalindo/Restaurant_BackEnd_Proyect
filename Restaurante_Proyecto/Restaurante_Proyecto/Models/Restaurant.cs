using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante_Proyecto.Models
{
    public class Restaurant
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string FoodStyle { get; set; }
        public string Street { get; set; }
        public int AddressNumber { get; set; }
        public IEnumerable<Dish> Dishes { get; set; }
    }
}
