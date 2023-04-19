using CelilCavus.ElementWebSite.Models.Database.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CelilCavus.ElementWebSite.Models.Database.Configuration
{
    public class BaseEntityConfiguration:EntityTypeConfiguration<BaseEntity>
    {
        public BaseEntityConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}