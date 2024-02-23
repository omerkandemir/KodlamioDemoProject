using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kurs ismi boş olamaz");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori seçilmelidir.");
            RuleFor(x => x.InstructorId).NotEmpty().WithMessage("Eğitmen seçilmelidir");
        }
    }
}
