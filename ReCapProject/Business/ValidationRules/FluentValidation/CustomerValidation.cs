using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidation:AbstractValidator<Customers>
    {
        public CustomerValidation()
        {
            RuleFor(c => c.CustomerId).NotEmpty();
            RuleFor(c => c.UserId).NotEmpty();
        }
    }
}
