using CelilCavus.ElementWebSite.Models.Database.Entity;
using System.Data.Entity.ModelConfiguration;

namespace CelilCavus.ElementWebSite.Models.Database.Configuration
{
    public class ContactConfiguration:EntityTypeConfiguration<Contact>
    {
        public ContactConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.Email).IsRequired();
            Property(x => x.Email).HasMaxLength(100);

            Property(x => x.PhoneNumber).IsRequired();
            Property(x=>x.PhoneNumber).IsVariableLength().HasMaxLength(11);

            Property(x => x.Message).IsRequired();
            Property(x => x.Message).HasMaxLength((ushort.MaxValue));
        }
    }
}