using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOnline.Data.Model
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public string Name { get; set; }
        public virtual List<Ingredient> Composition { get; set; } = new List<Ingredient>();
    }
}
