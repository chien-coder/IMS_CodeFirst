using MemberProjects_API.Models;
using Microsoft.EntityFrameworkCore;

namespace MemberProjects_API.Data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options)
        {

        }

        public DbSet<MemberProjects> memberProjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberProjects>(e =>
            {
                e.ToTable("Member_Projects");
                e.HasKey(e => e.Id);
                e.Property(e => e.Id).HasMaxLength(30);
                e.Property(mp => mp.isActive).HasDefaultValue(true);
                e.Property(mp => mp.IdProject).IsRequired();
                e.Property(mp => mp.IdUser).IsRequired();
                e.Property(mp => mp.isView).HasDefaultValue(false);
                e.Property(mp => mp.isAdd).HasDefaultValue(false);
                e.Property(mp => mp.isUpdate).HasDefaultValue(false);
                e.Property(mp => mp.isDelete).HasDefaultValue(false);
            });
        }
    }
}
