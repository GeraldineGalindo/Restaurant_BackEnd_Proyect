using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante_Proyecto.Models
{
    public class Dish
    {
        public int? Id { get; set; }
        public string  Name { get; set; }
        public string  MainIngredient { get; set; }
        public string  Nationality { get; set; }
        public double Cost { get; set; }
        public string Size { get; set; }
        public int RestautantId { get; set; }
    }
}
