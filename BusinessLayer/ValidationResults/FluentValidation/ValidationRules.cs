using EntityLayer.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationResults.FluentValidation
{
    public class ValidationRules : AbstractValidator<About>
    {
        public ValidationRules()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz!");
            RuleFor(i => i.Image1).NotEmpty().WithMessage("Lütfen görsel seçiniz");
            RuleFor(d => d.Description).MinimumLength(58).WithMessage("Lütfen en az 50 karakterlik açıklama bilgisi giriniz.");
        }
    }
}
