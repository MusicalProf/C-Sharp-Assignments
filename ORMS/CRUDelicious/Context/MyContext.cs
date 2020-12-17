using Microsoft.EntityFrameworkCore;
using CRUDelicious.Models;

namespace CRUDelicious.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}

        public DbSet<Dish> Dishes {get; set;}
    }
}