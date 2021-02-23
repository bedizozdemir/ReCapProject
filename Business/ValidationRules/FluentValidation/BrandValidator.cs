using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b=>b.BrandName).NotEmpty();
            RuleFor(b => b.BrandName).MinimumLength(2).WithMessage("You cannot write a name with length containing 1 or less character.");
        }
    }
}
