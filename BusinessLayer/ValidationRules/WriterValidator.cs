using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Bu Alan Boş Geçilemez.");
            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("Yazar Adı En Az 3 Karakterden Oluşturulmalıdır.");
            RuleFor(x => x.WriterName).MaximumLength(30).WithMessage("Yazar Adı En Fazla 30 Karakterden Oluşturulmalıdır.");

            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Bu Alan Boş Geçilemez");
            RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Lütfen Geçerli Bir E-Posta Giriniz.");

            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Lütfen Şifreyi Giriniz");
            RuleFor(x => x.WriterPassword).MinimumLength(3).WithMessage("Şifre En Az 3 Karakterden Oluşturulmalıdır.");
            RuleFor(x => x.WriterPassword).MaximumLength(20).WithMessage("Şifre En Fazla 20 Karakterden Oluşturulmalıdır.");
        }
    }
}
