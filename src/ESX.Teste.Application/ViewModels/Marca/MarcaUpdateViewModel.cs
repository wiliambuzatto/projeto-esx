using System;
using System.ComponentModel.DataAnnotations;

namespace ESX.Teste.Application.ViewModels.Marca
{
    public class MarcaUpdateViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        [MarcaIsUnique]
        public string Nome { get; set; }
    }
}
