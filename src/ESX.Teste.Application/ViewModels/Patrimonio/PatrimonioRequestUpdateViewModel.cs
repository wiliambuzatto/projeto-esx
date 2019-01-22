using System;
using System.ComponentModel.DataAnnotations;

namespace ESX.Teste.Application.ViewModels.Patrimonio
{
    public class PatrimonioRequestUpdateViewModel
    {
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(200)]
        public string Descricao { get; set; }

        [Required]
        [MarcaIsExisting]
        public Guid MarcaId { get; set; }
    }
}
