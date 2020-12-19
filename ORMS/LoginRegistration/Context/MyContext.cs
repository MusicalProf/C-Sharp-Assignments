using Microsoft.EntityFrameworkCore;
using LoginRegistration.Models;

namespace LoginRegistration.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}