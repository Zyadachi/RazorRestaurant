using Microsoft.EntityFrameworkCore;
using RazorRestaurant.Models;

namespace RazorRestaurant.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) 
            : base(options)
        {

        }
    }
}
