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
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Writer Name cannot be empty");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Writer Surname cannot be empty");
            RuleFor(x => x.AboutWriter).NotEmpty().WithMessage("Part of about cannot be empty");
            //RuleFor(x => x.WriterTitles).NotEmpty().WithMessage("This part cannot be empty");
            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("Writer Name should be 2 characters at least");
            RuleFor(x => x.WriterName).MaximumLength(20).WithMessage("Writer Name should be 50 characters at most");
            RuleFor(x => x.WriterSurname).MinimumLength(3).WithMessage("Writer Surname should be 2 characters at least");
            RuleFor(x => x.WriterSurname).MaximumLength(20).WithMessage("Writer Surname should be 50 characters at most");
        }


    }
}
