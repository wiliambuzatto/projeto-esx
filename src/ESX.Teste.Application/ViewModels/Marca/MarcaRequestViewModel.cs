using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ESX.Teste.Application.ViewModels.Marca
{
    public class MarcaRequestViewModel
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [MaxLength(100, ErrorMessage ="O campo nome deve conter no máximo {0} caracteres")]
        [DisplayName("Nome")]
        public string Nome { get; set; }
    } 
}
