using CelilCavus.ElementWebSite.Dto.ContactDto;
using FluentValidation;

namespace CelilCavus.ElementWebSite.Validation
{
    public class ContactDtoInsertValidatior : AbstractValidator<ContactDtoInsert>
    {
        public ContactDtoInsertValidatior()
        {
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Name Alanı Minumum 2 Karakter Olmalıdır");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Name Alanı Maksimum 50 Karakter Olmalıdır");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name Alanı Boş Geçilemez");


            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Phone Number Alanı Boş Geçilemez");
            RuleFor(x => x.PhoneNumber).Length(11).WithMessage("Phone Number Alanı 11 Karakter Olmak zorundadır.");

            RuleFor(x => x.Email).MinimumLength(13).WithMessage("Email Alanı Minumum 13 Karakter Olmalıdır");
            RuleFor(x => x.Email).MaximumLength(100).WithMessage("Email Alanı Maksimum 100 Karakter Olmalıdır");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email Alanı Boş Geçilemez");


            RuleFor(x => x.Message).MinimumLength(3).WithMessage("Message Alanı Minumum 3 Karakter Olmalıdır");
            RuleFor(x => x.Message).MaximumLength(400).WithMessage("Message Alanı Maksimum 400 Karakter Olmalıdır");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Message Alanı Boş Geçilemez");

        }
    }
}