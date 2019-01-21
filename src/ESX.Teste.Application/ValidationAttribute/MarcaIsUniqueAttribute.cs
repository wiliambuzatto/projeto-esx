using ESX.Teste.Domain.Interfaces.Services;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ESX.Teste.Application
{
    public class MarcaIsUniqueAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value,
                                                    ValidationContext validationContext)
        {
            var repository = validationContext.GetService(typeof(IMarcaService)) as IMarcaService;
            if (repository.List().Result
                          .Any(p => string.Equals(p.Nome, value?.ToString(), StringComparison.InvariantCultureIgnoreCase)))
            {
                return new ValidationResult($"The name {value} is already registered. Enter another name");
            }
            return ValidationResult.Success;

        }
    }
}
