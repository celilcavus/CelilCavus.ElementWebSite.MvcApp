namespace CelilCavus.ElementWebSite.Models.Database.Entity
{
    public class Contact:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
    }
}