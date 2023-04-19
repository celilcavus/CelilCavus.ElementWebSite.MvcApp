using CelilCavus.ElementWebSite.Dto.AboutDto;
using CelilCavus.ElementWebSite.Models.Database.Context;
using CelilCavus.ElementWebSite.Models.Database.Entity;
using System.Linq;

namespace CelilCavus.ElementWebSite.Mapping
{
    public class AboutMapping 
    {
        private readonly UnitOfWork.UnitOfWork work;
        public AboutMapping()
        {
            work = new UnitOfWork.UnitOfWork(new ElementContext());
        }
        public IQueryable<AboutListDto> GetAboutListDtos()
        {
            var abouts = from x in work.GetRepository<About>().GetList()
                        select new AboutListDto
                        {
                           Id = x.Id,
                           AboutTitle = x.AboutTitle,
                           AboutSubTitle = x.AboutSubTitle,
                           AboutDescription = x.AboutDescription,
                           AboutImage = x.AboutImage
                        };
            return abouts.AsQueryable();
        }
    }
 
}