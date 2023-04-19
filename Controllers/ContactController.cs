using CelilCavus.ElementWebSite.Dto.ContactDto;
using CelilCavus.ElementWebSite.Mapping;
using CelilCavus.ElementWebSite.Models.Database.Context;
using CelilCavus.ElementWebSite.Models.Database.Entity;
using CelilCavus.ElementWebSite.Validation;
using FluentValidation.Results;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Web.Mvc;

namespace CelilCavus.ElementWebSite.Controllers
{
    public class ContactController : Controller
    {
        private readonly UnitOfWork.UnitOfWork _work;
        private readonly ContactMapping _mapping;
        private readonly ContactDtoInsertValidatior valid;
        public ContactController()
        {
            _work = new UnitOfWork.UnitOfWork(new ElementContext());
            _mapping = new ContactMapping();
            valid = new ContactDtoInsertValidatior();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ContactDtoInsert contactDto)
        {
            ValidationResult validationResult = valid.Validate(contactDto);
            if (validationResult.IsValid)
            {
                var cont = _mapping.ContactDtoInsert(contactDto);
                _work.GetRepository<Contact>().Add(cont);
                _work.SaveChanges();
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
    }
}