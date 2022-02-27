using PizzaOnline.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline.Services.ViewModel;
using Microsoft.EntityFrameworkCore;
using PizzaOnline.Services.Interfaces;

namespace PizzaOnline.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly AppDbContext _ctx;

        public PizzaService(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<List<PizzasViewModels>> GetAllAsync()
        {
            List<PizzasViewModels> result = default;
            var pizzas = await _ctx.Pizzas
                .Include(p => p.Composition) 
                .ToListAsync();
            
            result = pizzas.Select(p => new PizzasViewModels()
            {
                Name = p.Name,
                Composition = p.Composition

            }).ToList();

            return result;
        }
    }
}
