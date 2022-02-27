using PizzaOnline.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOnline.Data.Model
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public virtual List<Pizza> Pizzas { get; set; } = new List<Pizza>();
    }
}
