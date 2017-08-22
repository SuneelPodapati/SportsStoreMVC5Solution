using SportsStoreDomainLibrary.Entities;
using System.Data.Entity;

namespace SportsStoreDomainLibrary.Concrete
{
    public class SportsStoreDbContext: DbContext
    {
        public SportsStoreDbContext() : base("SportsStoreConnection") { }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //If Schema is required then will add it here
            //modelBuilder.HasDefaultSchema("<schemaname>");
            base.OnModelCreating(modelBuilder);
        }

    }
}
