using IMS_kien.models;
using Microsoft.EntityFrameworkCore;

namespace IMS_kien.context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Projects> Projects { get; set; }

    }
}
