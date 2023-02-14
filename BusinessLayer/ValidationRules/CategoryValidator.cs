﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category Name cannot be empty");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Category Description cannot be empty");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Category Name should be 3 characters at least");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Category Name should be 3 characters at most");
        }
    }
}
