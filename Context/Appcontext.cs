
using Ass2mvc.Models;
  using Microsoft.EntityFrameworkCore;



namespace Ass2mvc.Context
{
    public class Appcontext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-ENE9MV4;Database=MVC2;Trusted_Connection=True");
        }
        public DbSet<User> Users { get; set; }
    }
}
