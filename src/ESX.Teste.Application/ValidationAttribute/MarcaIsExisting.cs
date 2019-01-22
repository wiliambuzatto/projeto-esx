using ESX.Teste.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ESX.Teste.Application
{
    public class MarcaIsExistingAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var repository = validationContext.GetService(typeof(IMarcaService)) as IMarcaService;
            if (repository.GetById((Guid)value) == null)
            {
                return new ValidationResult($"The MarcaId {value} is does not exist!");
            }
            return ValidationResult.Success;

        }
    }
}
