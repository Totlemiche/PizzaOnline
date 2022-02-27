using Microsoft.EntityFrameworkCore;
using PizzaOnline.Data.Model;
using System;

namespace PizzaOnline.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        public AppDbContext(DbContextOptions option) : base(option)
        {

        }

    }
}
