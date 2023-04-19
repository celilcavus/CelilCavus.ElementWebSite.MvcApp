using CelilCavus.ElementWebSite.Models.Database.Entity;

namespace CelilCavus.ElementWebSite.Dto.ServiceDto
{
    public class ServiceListDto : BaseEntity
    {
        public string ServiceIcon { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }
    }
}