using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class InstructorValidator : AbstractValidator<Instructor>
    {
        public InstructorValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Eğitmen ismi boş olamaz");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Eğitmen soyadı boş olamaz.");
            RuleFor(x => x.BirthDate).NotEmpty().WithMessage("Eğitmen doğum tarihi boş olamaz");
        }
    }
}
