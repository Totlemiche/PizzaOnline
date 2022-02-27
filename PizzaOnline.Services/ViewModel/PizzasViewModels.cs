using Microsoft.EntityFrameworkCore;
using PizzaOnline.Data;
using PizzaOnline.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnline.Services.ViewModel
{
    public class PizzasViewModels
    {
        public int PizzaId { get; set; }
        public string Name { get; set; }
        public virtual List<Ingredient> Composition { get; set; } = new List<Ingredient>();
    }
}
