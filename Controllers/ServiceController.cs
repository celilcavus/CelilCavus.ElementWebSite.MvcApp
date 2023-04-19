using CelilCavus.ElementWebSite.Dto.ServiceDto;
using CelilCavus.ElementWebSite.Mapping;
using System.Linq;
using System.Web.Mvc;

namespace CelilCavus.ElementWebSite.Controllers
{
    public class ServiceController : Controller
    {
        private readonly ServiceMapping mapping;

        public ServiceController()
        {
            this.mapping = new ServiceMapping();
        }

        public ActionResult Index()
        {
            var values = mapping.GetServiceListDtos(3);
            if (values is null)
            {
                Enumerable.Empty<ServiceListDto>();
            }
            return View(values);
        }
    }
}