
using Microsoft.EntityFrameworkCore;
using WaiterAPP.Models;

namespace WaiterAPP.DataBase
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            
        }
       public DbSet<Food> Foods { get; set; } 

        public DbSet<Order> Orders { get; set; }

        public DbSet<Waiter> Waiters { get; set; }




    }
}
