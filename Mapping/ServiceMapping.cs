using CelilCavus.ElementWebSite.Dto.ServiceDto;
using CelilCavus.ElementWebSite.Models.Database.Context;
using CelilCavus.ElementWebSite.Models.Database.Entity;
using System.Linq;

namespace CelilCavus.ElementWebSite.Mapping
{
    public class ServiceMapping
    {
        private readonly UnitOfWork.UnitOfWork work;

        public ServiceMapping()
        {
            this.work = new UnitOfWork.UnitOfWork(new ElementContext());
        }

        public IQueryable<ServiceListDto> GetServiceListDtos()
        {
            var getService = from x in work.GetRepository<Service>().GetList()
                             select new ServiceListDto
                             {
                                 Id = x.Id,
                                 ServiceTitle = x.ServiceTitle,
                                 ServiceIcon = x.ServiceIcon,
                                 ServiceDescription = x.ServiceDescription
                             };

            return getService.AsQueryable();
        }
        public IQueryable<ServiceListDto> GetServiceListDtos(int top)
        {
            var getService = from x in work.GetRepository<Service>()
                             .SqlQueryDesc($"select top {top} * from Services")
                             select new ServiceListDto
                             {
                                 Id = x.Id,
                                 ServiceTitle = x.ServiceTitle,
                                 ServiceIcon = x.ServiceIcon,
                                 ServiceDescription = x.ServiceDescription
                             };

            return getService.AsQueryable();
        }
    }
}