using CelilCavus.ElementWebSite.Dto.ContactDto;
using CelilCavus.ElementWebSite.Models.Database.Context;
using CelilCavus.ElementWebSite.Models.Database.Entity;


namespace CelilCavus.ElementWebSite.Mapping
{
    public class ContactMapping
    {
        private readonly UnitOfWork.UnitOfWork _work;
        Contact cont;
        public ContactMapping()
        {
            _work = new UnitOfWork.UnitOfWork(new ElementContext());
            cont = new Contact();
        }
        public Contact ContactDtoInsert(ContactDtoInsert contact)
        {
            cont.Name = contact.Name;
            cont.Email = contact.Email;
            cont.PhoneNumber = contact.PhoneNumber;
            cont.Message = contact.Message;
            return cont;
        }
    }
}