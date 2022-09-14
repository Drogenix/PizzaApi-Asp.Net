using Microsoft.EntityFrameworkCore;
using PizzaApi.Models;

namespace PizzaApi.Context
{
    public class PizzaDbContext:DbContext
    {
        public PizzaDbContext(DbContextOptions<PizzaDbContext> options)
        : base(options)
        {

        }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
