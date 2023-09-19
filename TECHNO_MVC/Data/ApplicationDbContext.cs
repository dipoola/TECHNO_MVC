using Microsoft.EntityFrameworkCore;
using TECHNO_MVC.Models;

namespace TECHNO_MVC.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base (options)
        {
                
        }
        public DbSet<Category> Categories1 { get; set; }
    }
}
