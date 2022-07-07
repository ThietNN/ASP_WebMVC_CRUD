using ASP_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_CRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> categories { get; set; }

        public DbSet<Book> books { get; set; }
    }
}
