using CelilCavus.ElementWebSite.Models.Database.Entity;
using System.Data.Entity.ModelConfiguration;

namespace CelilCavus.ElementWebSite.Models.Database.Configuration
{
    public class ServiceConfiguration : EntityTypeConfiguration<Service>
    {
        public ServiceConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.ServiceIcon).IsRequired();
            Property(x => x.ServiceIcon).HasMaxLength(100);

            Property(x => x.ServiceTitle).IsRequired();
            Property(x => x.ServiceTitle).HasMaxLength(100);

            Property(x => x.ServiceDescription).IsRequired();
            Property(x => x.ServiceDescription).HasMaxLength(200);

        }
    }
}