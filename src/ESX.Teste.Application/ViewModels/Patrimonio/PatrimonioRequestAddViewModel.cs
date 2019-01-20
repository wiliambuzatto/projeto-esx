using System;
using System.ComponentModel.DataAnnotations;

namespace ESX.Teste.Application.ViewModels.Patrimonio
{
    public class PatrimonioRequestAddViewModel
    {
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(200)]
        public string Descricao { get; set; }

        [Required]
        public Guid MarcaId { get; set; }
    }
}
