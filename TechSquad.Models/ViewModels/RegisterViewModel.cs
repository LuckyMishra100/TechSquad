using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSquad.Models.ViewModels
{
    public class RegisterViewModel
    {
      
        public string UserName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }

    public class RegisterViewModelValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterViewModelValidator()
        {
            RuleFor(x => x.UserName).NotNull();
            RuleFor(x => x.MobileNo).Length(0, 10);
            RuleFor(x => x.Email).EmailAddress();
        
        }
    }
}
