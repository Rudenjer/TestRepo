using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TestProject.DataAccessLayer.Entities;

namespace TestProject.DataAccessLayer.Context
{
    [DbConfigurationType(typeof(DatabaseConfiguration))]
    public class FarmDbContext: DbContext
    {
        public FarmDbContext() : base("MyContext")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions
                .Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Pet> Pets { get; set; }

        public DbSet<Owner> Owners { get; set; }
    }
}
