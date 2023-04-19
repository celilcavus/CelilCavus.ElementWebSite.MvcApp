using CelilCavus.ElementWebSite.Models.Database.Entity;
using System.Data.Entity.ModelConfiguration;

namespace CelilCavus.ElementWebSite.Models.Database.Configuration
{
    public class AboutConfiguration : EntityTypeConfiguration<About>
    {
        public AboutConfiguration()
        {
            HasKey(x => x.Id);
            Property(x=>x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.AboutTitle).IsRequired();
            Property(x => x.AboutTitle).HasMaxLength(100);

            Property(x => x.AboutSubTitle).IsRequired();
            Property(x => x.AboutSubTitle).HasMaxLength(150);

            Property(x => x.AboutDescription).IsRequired();
            Property(x => x.AboutDescription).HasMaxLength(300);

            Property(x => x.AboutImage).IsRequired();
            Property(x => x.AboutImage).HasMaxLength(1000);

        }
    }
}