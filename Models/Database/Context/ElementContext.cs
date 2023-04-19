using CelilCavus.ElementWebSite.Models.Database.Configuration;
using CelilCavus.ElementWebSite.Models.Database.Entity;
using System.Data.Entity;

namespace CelilCavus.ElementWebSite.Models.Database.Context
{
    public class ElementContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Configurations.Add(new AboutConfiguration());
            modelBuilder.Configurations.Add(new ContactConfiguration());
            modelBuilder.Configurations.Add(new ServiceConfiguration());
        }
    }
}