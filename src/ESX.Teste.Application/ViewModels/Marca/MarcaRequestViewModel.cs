using System.ComponentModel.DataAnnotations;

namespace ESX.Teste.Application.ViewModels.Marca
{
    public class MarcaRequestViewModel
    {
        [Required]
        [MaxLength(100)]
        [MarcaIsUnique]
        public string Nome { get; set; }
    } 
}
