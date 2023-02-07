using Microsoft.EntityFrameworkCore;
using Rpg_api.Models;
namespace Rpg_api.Data
{
    public class Api_context : DbContext
    {
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<Users> Users { get; set; } = null!;
        public DbSet<InvestorInfo> InvestorInfos { get; set; } = null!;
        public DbSet<InvestmentType> InvestmentTypes { get; set; } = null!;
        public DbSet<InvestmentStrategy> InvestmentStrategies { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=G1-DBS2MQ3-L;Initial Catalog=Rpg_api;TrustServerCertificate=True;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Users>()
                .Property(u => u.SortName)
                .HasComputedColumnSql("[LastName] + ' ' + [FirstName]");
        }

    }
}
