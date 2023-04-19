using CelilCavus.ElementWebSite.Models.Database.Entity;

namespace CelilCavus.ElementWebSite.Dto.AboutDto
{
    public class AboutListDto : BaseEntity
    {
        public string AboutTitle { get; set; }
        public string AboutSubTitle { get; set; }
        public string AboutImage { get; set; }
        public string AboutDescription { get; set; }
    }
}