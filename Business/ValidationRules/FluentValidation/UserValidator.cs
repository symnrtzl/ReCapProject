using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator() 
        {
            RuleFor(u => u.UserFirstName).NotEmpty();
            RuleFor(u => u.UserLastName).NotEmpty();
            RuleFor(u => u.Email)
                .NotEmpty()
                .EmailAddress();
            RuleFor(u => u.Password)
                .NotEmpty()
                .MinimumLength(8).WithMessage("Şifreniz en az 8 karakter olmalı")
                .Matches("[A-Z]").WithMessage("Şifreniz en az bir tane büyük harf içermeli")
                .Matches("[a-z]").WithMessage("Şifreniz en az bir tane küçük harf içermeli")
                .Matches("[0-9]").WithMessage("Şifreniz en az bir tane rakam içermelidir");

        }
    }
}
