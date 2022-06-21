using IMS_Chien.Models;
using Microsoft.EntityFrameworkCore;

namespace IMS_Chien.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Role> Roles { get; set; }
    }
}
