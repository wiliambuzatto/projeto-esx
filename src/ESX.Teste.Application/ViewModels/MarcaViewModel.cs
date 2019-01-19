using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ESX.Teste.Application.ViewModels
{
    public class MarcaViewModel
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }
    }
}
