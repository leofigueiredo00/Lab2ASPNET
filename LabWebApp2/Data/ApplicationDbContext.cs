using Microsoft.EntityFrameworkCore;
using LabWebApp2.Models;

namespace LabWebApp2.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }

}
