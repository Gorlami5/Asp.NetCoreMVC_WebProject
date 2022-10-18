using FluentValidation;
using FluentValidation.AspNetCore;
using MvcWebUI.Models;

namespace MvcWebUI.ValidationRule.FluentValidation
{
    public class ShippingDetailValidator:AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            RuleFor(s => s.FirstName).NotNull();
            RuleFor(s => s.FirstName).MinimumLength(2);
            RuleFor(s => s.LastName).NotEmpty();    
            RuleFor(s => s.Email).NotEmpty();
            RuleFor(s => s.Address).NotEmpty();
            RuleFor(s => s.Age).NotEmpty();
            RuleFor(s => s.City).NotEmpty().When(s => s.Age < 25);
            
        }

       
    }
}
