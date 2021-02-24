using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValitador:AbstractValidator<Rentals>
    {
        public RentalValitador()
        {
            RuleFor(r => r.RentalId).NotEmpty();
            RuleFor(r => r.CarId).NotEmpty();
            RuleFor(r => r.CustomerId).NotEmpty();
            RuleFor(r => r.RentDate).NotEmpty();
            RuleFor(r => r.ReturnDate).GreaterThan(r => r.RentDate).WithMessage("This car may be not free!, about error date");
        }
    }
}
