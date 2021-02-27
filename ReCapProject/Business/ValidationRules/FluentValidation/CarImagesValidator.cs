using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImagesValidator:AbstractValidator<CarImages>
    {
        public CarImagesValidator()
        {
            RuleFor(c => c.CarId).NotEmpty();
            RuleFor(c => c.Id).NotEmpty();
            RuleFor(c => c.ImagePath).NotEmpty();
            RuleFor(c => c.Date).NotEmpty();
        }
    }
}
