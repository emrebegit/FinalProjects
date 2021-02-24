using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
   public class UserValidation:AbstractValidator<Users>
    {
        public UserValidation()
        {
            RuleFor(u => u.UserId).NotEmpty();
            RuleFor(u => u.FirstName).NotEmpty().MinimumLength(2).WithMessage("your name is so bad");
            RuleFor(u => u.LastName).NotEmpty().MinimumLength(1).WithMessage("your lastname is so bad");
            RuleFor(u => u.Password).NotEmpty().MinimumLength(8).WithMessage("your password so short");
            RuleFor(u => u.Password).Must(ContainUpChar).WithMessage("your password shoulds contain up char");
            RuleFor(u => u.Password).Must(ContainNumber).WithMessage("your password should contain 3(three) number");
            RuleFor(u => u.Email).Must(ContainEt).WithMessage("your email is invalid(@)");
            RuleFor(u => u.Email).Must(ContainDot).WithMessage("your email is invalid(.)");

        }

        private bool ContainDot(string arg)
        {
            string[] splittedarg = arg.Split('@');
            for (int i = 0; i < splittedarg.Length; i++)
            {
                if (splittedarg[i]==".")
                {
                    return true;
                }
                
            }
            return false;

        }

        private bool ContainEt(string arg)
        {
            for (int i = 0; i < arg.Length; i++)
            {
                char chracktr = arg[i];
                if (chracktr=='@')
                {
                    return true;
                }
            }
            return false;
        }

        private bool ContainNumber(string arg)
        {
            int clock1 = 0;
            for (int i = 0; i < arg.Length; i++)
            {
                char chracter = arg[i];
                if (Char.IsNumber(chracter))
                {
                    clock1 += 1;
                }
                if (clock1==3)
                {
                    return true;
                }
            }
            return false;
        }
        private bool ContainUpChar(string arg)
        {
            for (int i = 0; i < arg.Length; i++)
            {
                char charackter = arg[i];
                if (Char.IsUpper(charackter))
                {
                    return true;
                }           
            }
            return false;
        }
    }
}
